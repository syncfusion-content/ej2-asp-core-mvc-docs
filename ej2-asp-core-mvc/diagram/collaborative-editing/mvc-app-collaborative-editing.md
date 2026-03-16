---
layout: post
title: Collaborative Editing Configuration in ASP.NET Core MVC Diagram | Syncfusion
description: Checkout and learn to configure SignalR and Redis for real-time collaborative editing in Syncfusion ASP.NET Core MVC Diagram.
control: Diagram
documentation: ug
platform: ej2-asp-core-mvc
domainurl: ##DomainURL##
---

# SignalR Hub Configuration in ASP.NET Core MVC Application

## Overview
This guide explains how to configure SignalR Hub in an ASP.NET Core MVC application for real-time collaborative diagram editing.

## Prerequisites

* [System requirements for ASP.NET Core components](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## How to Create ASP.NET Core MVC Application

To create an ASP.NET Core MVC application, follow the steps outlined in the ASP.NET Core MVC [Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/diagram/diagram-getting-started) documentation.

## How to Add Packages in the ASP.NET Core MVC Application

Open the NuGet Package Manager and install the following packages.

* Microsoft.AspNetCore.SignalR.Client
* Syncfusion.EJ2.AspNet.Core

## Configure SignalR Service in ASP.NET Core MVC Application

To enable real-time collaboration, configure SignalR HubConnection in your ASP.NET Core MVC view/controller as follows:

* Initialize the `HubConnection` and start it using `start()`.
* Connect to the `/diagramHub` endpoint with WebSocket transport `skipNegotiation: true` and enable automatic reconnect to handle transient network issues.
* Subscribe to the `OnConnectedAsync` callback to receive the unique connection ID, confirming a successful handshake with the server.
* Join a SignalR group by calling `JoinDiagram(roomName)` after connecting. This ensures updates are shared only with users in the same diagram session.
* Refer to Create ASP.NET Core MVC [Simple Diagram](https://ej2.syncfusion.com/aspnetcore/documentation/diagram/getting-started)

```html
<!-- In your ASP.NET Core MVC View -->
@{
    ViewData["Title"] = "Diagram Collaborative Editing";
}

<div id="diagram-container"></div>

<script src="https://cdn.jsdelivr.net/npm/@microsoft/signalr@latest/signalr.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/ej2/latest/ej2.min.js"></script>

<script>
    let connection = null;
    let roomName = 'Syncfusion';

    async function initializeSignalRConnection() {
        if (connection === null) {
            // Create connection
            connection = new signalR.HubConnectionBuilder()
                .withUrl('/diagramHub', {
                    skipNegotiation: true,
                    transport: signalR.HttpTransportType.WebSockets
                })
                .withAutomaticReconnect()
                .build();

            // Triggered when the connection to the SignalR Hub is successfully established
            connection.on('OnConnectedAsync', (id) => {
                onConnectedAsync(id);
            });

            try {
                await connection.start();
                console.log('Connected to SignalR Hub');
            } catch (error) {
                console.error('Connection failed:', error);
            }
        }
    }

    function onConnectedAsync(id) {
        if (id && id.length > 0) {
            console.log('Connection ID:', id);
            // Join the room after connection is established
            connection.invoke('JoinDiagram', roomName)
                .catch((error) => {
                    console.error('JoinDiagram failed:', error);
                });
        }
    }

    // Initialize connection when page loads
    document.addEventListener('DOMContentLoaded', initializeSignalRConnection);

    // Stop connection when page unloads
    window.addEventListener('beforeunload', () => {
        if (connection && connection.state === signalR.HubConnectionState.Connected) {
            connection.stop();
        }
    });
</script>
```

>**Notes:**
>* Use a unique `roomName` per diagram (e.g., a diagram ID) to isolate sessions.
>* If `WebSockets` may be unavailable, remove `SkipNegotiation` so SignalR can fall back to SSE or Long Polling.
>* Consider handling reconnecting/disconnected states in the UI and securing the connection with authentication if required.
>* For ASP.NET Core MVC, place this script in your shared layout or specific view where the diagram is hosted.


## Sending and Applying Real-Time Diagram Changes

* The ASP.NET Core MVC Diagram component triggers the [historyChange](https://ej2.syncfusion.com/aspnetcore/documentation/diagram/api-diagram/#historychange) event whenever the diagram is modified (e.g., add, delete, move, resize, or edit nodes/connectors).
* Use [getDiagramUpdates](https://ej2.syncfusion.com/aspnetcore/documentation/diagram/api-diagram/#getdiagramupdates) to produce a compact set of incremental updates (JSON-formatted changes) representing just the changes, not the entire diagram.
* Send these changes to the hub method `BroadcastToOtherUsers`, which relays them to all users joined to the same SignalR group (room).
* Each remote user listens for ReceiveData and applies the incoming changes with [setDiagramUpdates](https://ej2.syncfusion.com/aspnetcore/documentation/diagram/api-diagram/#setdiagramupdates), keeping their view synchronized without reloading the full diagram.
* Enable the `enableCollaborativeEditing` property on the diagram to treat multi-step edits (like drag/resize sequences or batch changes) as a single operation.

```html
<!-- In your ASP.NET Core MVC View -->
@{
    ViewData["Title"] = "Collaborative Diagram Editing";
}

<div id="diagram"></div>

<script>
    let diagramInstance;
    let connection = null;
    let roomName = 'Syncfusion';

    // Initialize Diagram
    let diagramConfig = {
        width: '100%',
        height: '700px',
        nodes: [],
        connectors: [],
        enableCollaborativeEditing: true,
        historyChange: onHistoryChange
    };

    // Create diagram when page loads
    document.addEventListener('DOMContentLoaded', function() {
        diagramInstance = new ej.diagrams.Diagram(diagramConfig, '#diagram');
        initializeSignalRConnection();
    });

    async function initializeSignalRConnection() {
        if (connection === null) {
            connection = new signalR.HubConnectionBuilder()
                .withUrl('/diagramHub', {
                    skipNegotiation: true,
                    transport: signalR.HttpTransportType.WebSockets
                })
                .withAutomaticReconnect()
                .build();

            // Listen for remote changes from other users
            connection.on('ReceiveData', (diagramChanges) => {
                if (diagramChanges && diagramChanges.length > 0) {
                    if (diagramInstance && diagramInstance.setDiagramUpdates) {
                        diagramInstance.setDiagramUpdates(diagramChanges);
                    }
                }
            });

            try {
                await connection.start();
                console.log('Connected to SignalR Hub');
                // Join the room after connection is established
                connection.invoke('JoinDiagram', roomName)
                    .catch((error) => {
                        console.error('JoinDiagram failed:', error);
                    });
            } catch (error) {
                console.error('Connection failed:', error);
                setTimeout(initializeSignalRConnection, 5000);
            }
        }
    }

    function onHistoryChange(args) {
        if (args && diagramInstance && diagramInstance.getDiagramUpdates) {
            // Get diagram updates (incremental changes) and send to hub
            const diagramChanges = diagramInstance.getDiagramUpdates(args);
            
            // When enableCollaborativeEditing is enabled, retrieve diagramChanges only after the group action completes.
            if (diagramChanges && diagramChanges.length > 0) {
                // Send changes to the SignalR Hub for broadcasting
                if (connection && connection.state === signalR.HubConnectionState.Connected) {
                    connection.invoke('BroadcastToOtherUsers', diagramChanges, roomName)
                        .catch((err) => {
                            console.error('Send failed:', err);
                        });
                }
            }
        }
    }

    // Stop connection when page unloads
    window.addEventListener('beforeunload', () => {
        if (connection && connection.state === signalR.HubConnectionState.Connected) {
            connection.stop();
        }
    });
</script>
```

## Conflict policy (optimistic concurrency) in ASP.NET Core MVC Application

To maintain consistency during collaborative editing, each user applies incoming changes using `setDiagramUpdates`. After applying changes, the ASP.NET Core MVC sample synchronizes its `userVersion` with the  `serverVersion` through the `UpdateVersion` event. This version-based approach ensures conflicts are resolved without locking, allowing real-time responsiveness while preserving data integrity.

Add the following code in the ASP.NET Core MVC application:
```html
<!-- In your ASP.NET Core MVC View -->
@{
    ViewData["Title"] = "Diagram Conflict Resolution";
}

<div id="diagram"></div>

<script>
    let diagramInstance;
    let connection = null;
    let roomName = 'Syncfusion';
    let userVersion = 0;

    // Initialize Diagram
    let diagramConfig = {
        width: '100%',
        height: '700px',
        nodes: [],
        connectors: [],
        enableCollaborativeEditing: true,
        historyChange: onHistoryChange
    };

    // Create diagram when page loads
    document.addEventListener('DOMContentLoaded', function() {
        diagramInstance = new ej.diagrams.Diagram(diagramConfig, '#diagram');
        initializeSignalRConnection();
    });

    async function initializeSignalRConnection() {
        if (connection === null) {
            connection = new signalR.HubConnectionBuilder()
                .withUrl('/diagramHub', {
                    skipNegotiation: true,
                    transport: signalR.HttpTransportType.WebSockets
                })
                .withAutomaticReconnect()
                .build();

            // Listen for remote changes with version tracking
            connection.on('ReceiveData', (diagramChanges, serverVersion) => {
                applyRemoteDiagramChanges(diagramChanges, serverVersion);
            });

            // Listen for conflict notifications
            connection.on('ShowConflict', () => {
                showConflict();
            });

            // Listen for explicit version updates
            connection.on('UpdateVersion', (serverVersion) => {
                updateVersion(serverVersion);
            });

            try {
                await connection.start();
                console.log('Connected to SignalR Hub');
                // Join the room after connection is established
                connection.invoke('JoinDiagram', roomName)
                    .catch((error) => {
                        console.error('JoinDiagram failed:', error);
                    });
            } catch (error) {
                console.error('Connection failed:', error);
                setTimeout(initializeSignalRConnection, 5000);
            }
        }
    }

    function applyRemoteDiagramChanges(diagramChanges, serverVersion) {
        // Sets diagram updates to current diagram
        if (diagramInstance && diagramInstance.setDiagramUpdates) {
            diagramInstance.setDiagramUpdates(diagramChanges);
        }
        // Update user version to server version after applying changes
        userVersion = serverVersion;
    }

    // Capture local changes and send with version and edited IDs
    function onHistoryChange(args) {
        if (!diagramInstance) {
            return;
        }

        const diagramChanges = diagramInstance.getDiagramUpdates(args);
        if (diagramChanges && diagramChanges.length > 0) {
            const editedElements = getEditedElements(args);
            // Send changes with version and edited element IDs
            if (connection && connection.state === signalR.HubConnectionState.Connected) {
                connection.invoke('BroadcastToOtherUsers', diagramChanges, userVersion, editedElements, roomName)
                    .catch((err) => {
                        console.error('Send failed:', err);
                    });
            }
        }
    }

    function getEditedElements(args) {
        const editedElements = [];
        // Extract and return IDs of affected nodes/connectors from args
        // TODO: implement extraction logic based on historyChange event args
        return editedElements;
    }

    function updateVersion(serverVersion) {
        userVersion = serverVersion;
    }

    function showConflict() {
        // Show notification to inform user their update was rejected due to conflict
        const message = "Your changes conflicted with another user's updates and were not applied. Please refresh to see the latest version.";
        alert(message);
    }

    // Stop connection when page unloads
    window.addEventListener('beforeunload', () => {
        if (connection && connection.state === signalR.HubConnectionState.Connected) {
            connection.stop();
        }
    });
</script>
```