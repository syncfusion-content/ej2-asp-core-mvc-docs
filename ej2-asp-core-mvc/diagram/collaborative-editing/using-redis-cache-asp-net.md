---
layout: post
title: Collaborative editing in Blazor Diagram Component | Syncfusion
description: Learn how to implement collaborative editing in the Syncfusion Blazor Diagram component using SignalR and Redis.
platform: Blazor
control: Diagram
documentation: ug
---

# How to enable collaborative editing in Blazor Application

## Step 1: Configure SignalR HubConnection

* Initialize a SignalR `HubConnection` on the component’s first render (`OnAfterRenderAsync`) and starts it with `StartAsync`.
* Connects to the `/diagramHub` endpoint via `WebSockets (SkipNegotiation = true)` and enables automatic reconnect to handle transient network issues.
* Subscribes to the `OnConnectedAsync` SignalR Hub callback to receive the unique connection ID, confirming a successful handshake.
* After connecting, calls `JoinDiagram(RoomName)` to join a dedicated SignalR group(room) so updates are shared only with users in the same diagram session.

```csharp
@using Microsoft.AspNetCore.SignalR.Client

@code {
    private HubConnection? connection;
    private string roomName = "Syncfusion";

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender) 
        { 
            if (connection == null)
            {
                connection = new HubConnectionBuilder()
                            .WithUrl(NavigationManager.ToAbsoluteUri("/diagramHub"), options =>
                            {
                                options.SkipNegotiation = true;
                                options.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
                            })
                            .WithAutomaticReconnect()
                            .Build();
                // Triggered when the connection to the SignalR Hub is successfully established
                connection.On<string>("OnConnectedAsync", OnConnectedAsync);
                await connection.StartAsync();
            }
        }
    }
    private async Task OnConnectedAsync(string connectionId)
    {
        if(!string.IsNullOrEmpty(connectionId))
        {
            // Join the room after connection is established
            await connection.SendAsync("JoinDiagram", roomName);
        }
    }
}
```

>**Notes:**
>* Use a unique `RoomName` per diagram (e.g., a diagram ID) to isolate sessions.
>* If `WebSockets` may be unavailable, remove `SkipNegotiation` so SignalR can fall back to SSE or Long Polling.
>* Consider handling reconnecting/disconnected states in the UI and securing the connection with authentication if required.

## Step 3: Sending and Applying Real-Time Diagram Changes

* Detect changes: The Blazor Diagram component triggers the `HistoryChanged` event whenever the diagram is modified (e.g., add, delete, move, resize, or edit nodes/connectors).
* Create deltas: Use [GetDiagramUpdates](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Diagram.SfDiagramComponent.html#Syncfusion_Blazor_Diagram_SfDiagramComponent_GetDiagramUpdates_Syncfusion_Blazor_Diagram_HistoryChangedEventArgs_) to produce a compact set of incremental updates (JSON-formatted deltas) representing just the changes, not the entire diagram.
* Broadcast to the room: Send these deltas to the hub method `BroadcastToOtherUsers`, which relays them to all users joined to the same SignalR group (room).
* Apply remotely: Each remote user listens for ReceiveData and applies the incoming deltas with [SetDiagramUpdatesAsync](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Diagram.SfDiagramComponent.html#Syncfusion_Blazor_Diagram_SfDiagramComponent_SetDiagramUpdatesAsync_System_Collections_Generic_List_System_String__), keeping their view synchronized without reloading the full diagram.
* Group interactions: Enable [EnableGroupActions](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Diagram.DiagramHistoryManager.html#Syncfusion_Blazor_Diagram_DiagramHistoryManager_EnableGroupActions) in [DiagramHistoryManager](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Diagram.DiagramHistoryManager.html) to treat multi-step edits (like drag/resize sequences or batch changes) as one operation. When enabled, `HistoryChanged` raises [StartGroupAction](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Diagram.SfDiagramComponent.html#Syncfusion_Blazor_Diagram_SfDiagramComponent_StartGroupAction) and [EndGroupAction](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Diagram.SfDiagramComponent.html#Syncfusion_Blazor_Diagram_SfDiagramComponent_EndGroupAction). Send updates after `EndGroupAction` to reduce network traffic (one consolidated update) and apply changes atomically for all collaborators.

```razor
<SfDiagramComponent @ref="@DiagramInstance" ID="@DiagramId" HistoryChanged="@OnHistoryChange" >
    <DiagramHistoryManager EnableGroupActions="true"></DiagramHistoryManager>
</SfDiagramComponent>

@code {
    private async Task InitializeSignalR()
    {
        if (connection == null)
        {
            connection = new HubConnectionBuilder()
                        .WithUrl(NavigationManager.ToAbsoluteUri("/diagramHub"), options =>
                        {
                            options.SkipNegotiation = true;
                            options.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
                        })
                        .WithAutomaticReconnect()
                        .Build();
            // Triggers when connection established to SignalR Hub
            connection.On<string>("OnConnectedAsync", OnConnectedAsync);
            // Apply remote changes to current diagram.
            connection.On<List<string>>("ReceiveData", async (diagramChanges) =>
            {
                await DiagramInstance.SetDiagramUpdatesAsync(diagramChanges);
            });
            await connection.StartAsync();
        }
    }
    public async void OnHistoryChange(HistoryChangedEventArgs args)
    {
        if (args != null)
        {
            List<string> parsedData = DiagramInstance.GetDiagramUpdates(args);
            if (parsedData.Count > 0)
            {
                // Send changes to the SignalR Hub for broadcasting
                await connection.SendAsync("BroadcastToOtherUsers", parsedData, roomName);
            }
        }
    }
}
```

## Asp.NET Core Hub configuration

### Step 1: Configure SignalR with Redis Backplane and Map the Diagram Hub(Program.cs)

Use the following setup to enable real-time collaboration with scale-out support. This configuration:

* Add your Redis connection string to appsettings.json.
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "RedisConnectionString": "<<Your Redis connection string>>"
  }
}
```
* Reuse a single instance across the app to respect Redis connection limits and improve efficiency.

```csharp
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    var cs = builder.Configuration.GetConnectionString("RedisConnectionString");
    return ConnectionMultiplexer.Connect(cs);
});
```
* Configure SignalR to use Redis so group messages are distributed across all app instances in a farm.

```csharp
builder.Services
    .AddSignalR()
    .AddStackExchangeRedis(builder.Configuration.GetConnectionString("RedisConnectionString"));
```
* Add your Redis-backed service(s) for tasks like versioning, history, or cleanup.

```csharp
builder.Services.AddScoped<IRedisService, RedisService>(); // your implementation
```

* Expose the hub at /diagramHub so users can connect with WithUrl("/diagramHub").

```csharp
var app = builder.Build();

app.MapHub<DiagramHub>("/diagramHub");

app.Run();
```
Notes:
- Ensure WebSockets are enabled on the host/proxy, or remove `SkipNegotiation` on the user to allow fallback transports.
- Use a singleton `IConnectionMultiplexer` to respect Redis connection limits.

### Step 2: Configure SignalR Hub to Create Rooms for Collaborative Editing Sessions
Create a folder named `Hubs` and add a file `DiagramHub.cs`. This hub manages SignalR groups (rooms) for each diagram session and broadcasts updates to all participants in the same room.

What this hub does
- Creates a per-connection session ID and sends it to the user.
- Allows users join a specific room (diagram session) using a room name/ID.
- Broadcasts diagram updates to other users in the same room (excluding the sender).
- Cleans up group membership when users disconnect.

The following key methods are implemented on the collaboration hub:
* OnConnectedAsync: Invoked when a user connects. Sends the SignalR Hub-generated connection ID to the user for session tracking.
* JoinDiagram(roomName): Adds the current connection to the specified SignalR group (room) and stores the room mapping for cleanup.
* BroadcastToOtherUsers(payloads, roomName): Broadcasts updates to all other users in the same room, excluding the sender.
* OnDisconnectedAsync: Invoked when a user disconnects. Removes the connection from its room(s) to prevent stale memberships.

```csharp
```csharp
using Microsoft.AspNetCore.SignalR;

namespace DiagramServerApplication.Hubs
{
    public class DiagramHub : Hub
    {
        private readonly ILogger<DiagramHub> _logger;

        public DiagramHub(ILogger<DiagramHub> logger)
        {
            _logger = logger;
        }

        // 1) Called when a user connects to the hub
        public override Task OnConnectedAsync()
        {
            // Send a unique connection ID back to the user
            Clients.Caller.SendAsync("OnConnectedAsync", Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        // 2) Adds the current connection to a SignalR group (room)
        public async Task JoinDiagram(string roomName)
        {
            try
            {
                string userId = Context.ConnectionId;

                // Store the room name in the connection context for later retrieval (e.g., on disconnect)
                Context.Items["roomName"] = roomName;

                // Add this connection to the specified group (room)
                await Groups.AddToGroupAsync(userId, roomName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error joining room {Room}", roomName);
            }
        }

        // 3) Broadcasts updates to other users in the same room (excludes the sender)
        public async Task BroadcastToOtherUsers(List<string> payloads, string roomName)
        {
            try
            {
                // Send the updates to all other connections in the room
                await Clients.OthersInGroup(roomName).SendAsync("ReceiveData", payloads);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error broadcasting to room {Room}", roomName);
            }
        }

        // 4) Removes the connection from its room when the user disconnects
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            try
            {
                // Retrieve previously stored room name
                string? roomName = Context.Items.TryGetValue("roomName", out var value) ? value as string : null;

                if (!string.IsNullOrEmpty(roomName))
                {
                    await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
                }

                await base.OnDisconnectedAsync(exception);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during disconnect");
            }
        }
    }
}
```
## Conflict policy (optimistic concurrency)

Collaborative edits are managed using version-based optimistic concurrency to prevent conflicts without locking:
* Versioned updates from the user:
    * Each change includes the user’s current userVersion, the serialized diagram deltas, and editedElementIds (IDs of nodes/connectors touched by the edit).
    
    ```csharp
    // Capture local changes and send with version + edited IDs
    public async void OnHistoryChange(HistoryChangedEventArgs args)
    {
        if (args == null) return;

        List<string> deltas = DiagramInstance.GetDiagramUpdates(args);
        if (deltas.Count == 0) return;

        List<string> editedElements = GetEditedElements(args);

        await connection!.SendAsync(
            "BroadcastToOtherUsers",
            deltas,
            userVersion,
            editedElements,
            RoomName);
    }
    
    private List<string> GetEditedElements(HistoryChangedEventArgs args)
    {
        // Extract and return IDs of affected nodes/connectors from args
        return new List<string>();
    }
    ```

* ASP.NET Core SignalR Hub-side validation (hub + Redis):
    * The hub compares userVersion with the latest version stored in Redis using a compare-and-increment (CAS) operation.
    * If versions match, the update is accepted and the version is incremented atomically.
    * If the user is stale, the hub checks for overlap with recently edited elements:
        * Stale + overlapping: reject the update, notify the user via ShowConflict.
        * Stale + no overlap: accept the update and atomically advance the version.

```csharp

using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System.Text.Json;
public interface IRedisService
{
    Task<(bool accepted, long version)> CompareAndIncrementAsync(string key, long expectedVersion);
}

public class RedisService : IRedisService
{
    private readonly IDatabase _database;
    private readonly ILogger<RedisService> _logger;

    public RedisService(IConnectionMultiplexer redis, ILogger<RedisService> logger)
    {
        _database = redis.GetDatabase();
        _logger = logger;
    }

    public async Task<(bool accepted, long version)> CompareAndIncrementAsync(string key, long expectedVersion)
    {
        const string lua = @"
            local v = redis.call('GET', KEYS[1])
            if not v then
            v = 0
            else
            v = tonumber(v) or 0
            end

            local expected = tonumber(ARGV[1]) or -1

            if v == expected then
            local newv = redis.call('INCR', KEYS[1])
            return {1, newv}
            else
            return {0, v}
            end
            ";
        try
        {
            RedisResult[] result = (StackExchange.Redis.RedisResult[])await _database.ScriptEvaluateAsync(
                lua,
                keys: new StackExchange.Redis.RedisKey[] { key },
                values: new StackExchange.Redis.RedisValue[] { expectedVersion.ToString() });

            bool accepted = (int)result[0] == 1;
            long version;
            if (result[1].Type == StackExchange.Redis.ResultType.Integer)
                version = (long)result[1];
            else
                version = long.Parse((string)result[1]);

            return (accepted, version);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in CompareAndIncrementAsync for key {Key}", key);
        }
    }
}
```

* Broadcast and user synchronization:
    * On acceptance, the hub broadcasts the deltas plus the authoritative serverVersion to all other users in the same room (ReceiveData).
    * Each user applies the deltas via `SetDiagramUpdatesAsync` and updates its local userVersion (either from the ReceiveData payload or via UpdateVersion)
```csharp
using Microsoft.AspNetCore.SignalR;

public class DiagramUpdateMessage
{
    public string SourceConnectionId { get; set; } = "";
    public long Version { get; set; }
    public List<string>? ModifiedElementIds { get; set; }
}

public class DiagramHub : Hub
{
    private readonly IRedisService _redisService;
    private readonly ILogger<DiagramHub> _logger;

    public DiagramHub(IRedisService redis, ILogger<DiagramHub> logger)
    {
        _redisService = redis;
        _logger = logger;
    }
    public async Task BroadcastToOtherUsers(List<string> payloads, long userVersion, List<string>? elementIds, string roomName)
    {
        try
        {
            string versionKey = "diagram:version";
            // Try to accept based on expected version (CAS via Lua)
            (bool accepted, long serverVersion) = await _redisService.CompareAndIncrementAsync(versionKey, userVersion);

            if (!accepted)
            {
                // Check for overlaps since user's version
                List<DiagramUpdateMessage> recentUpdates = await GetUpdatesSinceVersionAsync(userVersion, maxScan: 200);
                HashSet<string> recentlyTouched = new HashSet<string>(StringComparer.Ordinal);
                foreach (DiagramUpdateMessage upd in recentUpdates)
                {
                    if (upd.ModifiedElementIds == null) continue;
                    foreach (string id in upd.ModifiedElementIds)
                        recentlyTouched.Add(id);
                }

                List<string> overlaps = elementIds?.Where(id => recentlyTouched.Contains(id)).Distinct().ToList();
                if (overlaps?.Count > 0)
                {
                    // Reject & notify caller of conflict
                    await Clients.Caller.SendAsync("ShowConflict");
                    return;
                }

                // Accept non-overlapping stale update: increment once more
                (bool _, long newServerVersion) = await _redisService.CompareAndIncrementAsync(versionKey, serverVersion);
                serverVersion = newServerVersion;
            }
            // Store update in Redis history
            DiagramUpdateMessage update = new DiagramUpdateMessage
            {
                SourceConnectionId = connId,
                Version = serverVersion,
                ModifiedElementIds = elementIds
            };
            await StoreUpdateInRedis(update);
            // Broadcast to others in the same room, including serverVersion
            await Clients.OthersInGroup(roomName).SendAsync("ReceiveData", payloads, serverVersion);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex);
        }
    }
}

* The user subscribes to the following SignalR events:
    * **ShowConflict** to notify users of rejected updates.
    * **UpdateVersion** to sync userVersion with the SignalR Hub.
    * **ReceiveData** to apply remote changes and advance to the new serverVersion.
    * When handling ReceiveData with both payloads and serverVersion, use a handler signature that accepts two parameters (payloads, serverVersion), and pass both to `ApplyRemoteDiagramChanges` so userVersion is updated after applying the deltas.

```csharp
@using Microsoft.AspNetCore.SignalR.Client

<SfDiagramComponent @ref="@DiagramInstance" ID="@DiagramId" HistoryChanged="@OnHistoryChange">
    <DiagramHistoryManager EnableGroupActions="true"></DiagramHistoryManager>
</SfDiagramComponent>

@code {
    private HubConnection? connection;
    private string RoomName = "Syncfusion";
    private long userVersion = 0;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await InitializeSignalR();
    }

    private async Task InitializeSignalR()
    {
        if (connection != null) return;

        connection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/diagramHub"), options =>
            {
                options.SkipNegotiation = true;
                options.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
            })
            .WithAutomaticReconnect()
            .Build();

        // Conflict notification
        connection.On("ShowConflict", ShowConflict);

        // Explicit version sync (optional if version is included in ReceiveData)
        connection.On<long>("UpdateVersion", UpdateVersion);

        // Receive remote deltas with the authoritative server version
        connection.On<List<string>, long>("ReceiveData", async (diagramChanges, serverVersion) =>
        {
            await ApplyRemoteDiagramChanges(diagramChanges, serverVersion);
        });

        // Connection established – join the room
        connection.On<string>("OnConnectedAsync", async (id) =>
        {
            if (!string.IsNullOrEmpty(id))
                await connection.SendAsync("JoinDiagram", RoomName);
        });

        await connection.StartAsync();
    }

    // Apply remote changes and sync version
    private async Task ApplyRemoteDiagramChanges(List<string> diagramChanges, long newVersion)
    {
        await DiagramInstance.SetDiagramUpdatesAsync(diagramChanges);
        userVersion = newVersion;
    }

    // Capture local changes and send with version + edited IDs
    public async void OnHistoryChange(HistoryChangedEventArgs args)
    {
        if (args == null) return;

        List<string> deltas = DiagramInstance.GetDiagramUpdates(args);
        if (deltas.Count == 0) return;

        List<string> editedElements = GetEditedElements(args);

        await connection!.SendAsync(
            "BroadcastToOtherUsers",
            deltas,
            userVersion,
            editedElements,
            RoomName);
    }

    private void UpdateVersion(long newVersion) => userVersion = newVersion;

    private void ShowConflict()
    {
        // Display a notice/toast/dialog to inform the user their update was rejected due to overlap
    }

    private List<string> GetEditedElements(HistoryChangedEventArgs args)
    {
        // Extract and return IDs of affected nodes/connectors from args
        return new List<string>();
    }
}
```

## Cleanup strategy for Redis

To prevent unbounded memory growth and maintain stable performance, implement one or both of the following:
* Keep only the last K versions
    * Maintain a fixed-size history (e.g., the last 200 updates) and trim older entries after each push.
    * Retains only recent updates needed for conflict checks and recovery.
* Apply TTL (Time-to-Live) to keys
    * Set expiration on Redis keys that store version and history data.
    * Bounds memory usage and automatically cleans up stale sessions.
```csharp
// In IRedisService
Task<bool> SetAsync<T>(string key, T value, TimeSpan? expiry = null);
// In RedisService
public async Task<bool> SetAsync<T>(string key, T value, TimeSpan? expiry = null)
{
    try
    {
        string serializedValue = JsonSerializer.Serialize(value);
        return await _database.StringSetAsync(key, serializedValue, expiry);
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error setting key {Key}", key);
        return false;
    }
}

// Applying TTL to the version key
const string versionKey = "diagram:version";
long version = 5;
await _redisService.SetAsync(versionKey, version, TimeSpan.FromHours(1));
```

## Hosting, transport, and serialization

To ensure reliable and efficient collaborative editing, consider the following best practices:
* **1. Hosting**
    * Enable WebSockets on your hosting environment and reverse proxy (e.g., Nginx, IIS, Azure App Service).
    * Configure keep-alives to maintain long-lived connections and prevent timeouts during idle periods.
* **2. Transport**
    * **Preferred:** WebSockets for low-latency, full-duplex communication.
    * **Fallback:** If WebSockets are unavailable, remove SkipNegotiation on the Blazor application to allow SignalR to fall back to ASP.NET Core SignalR Hub-Sent Events (SSE) or Long Polling.
* **3. Serialization**
    * For large payloads, enable MessagePack on both collaboration hub and blazor application projects for efficient binary serialization.
    * Consider sending diffs (incremental changes) instead of full diagram state to reduce bandwidth usage.

## Limitations
* Default deployment
    * By default, a single server instance works without additional setup. For multi-instance (scale-out) deployments, configure a SignalR backplane (e.g., Redis) and use a shared Redis store so all nodes share group messages and version state consistently.
* View-only interactions
    * Zoom and pan are local to each user and are not synchronized, so collaborators may view different areas of the diagram.
* Unsupported synchronized settings
    * Changes to `PageSettings`, `ContextMenu`, `DiagramHistoryManager`, `SnapSettings`, `Rulers`, `UmlSequenceDiagram`, `Layout`, and `ScrollSettings` are not propagated to other users and apply only locally.

>**Note:** 
> * Collaboration is supported for actions that raise the `HistoryChanged` event.

The full version of the code can be found in the GitHub location below.

GitHub Example: [Collaborative editing examples](https://github.com/syncfusion/blazor-showcase-diagram-collaborative-editing).
