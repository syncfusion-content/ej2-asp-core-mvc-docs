---
title: Collaborative Editing in ##Platform_Name## Document Editor Control | Syncfusion
component: DocumentEditor
description: Learn how to enable and perform collaborative editing in Syncfusion ##Platform_Name## Document editor.
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
---

# Collaborative Editing

Allows multiple users to work on the same document simultaneously. This can be done in real-time, so that collaborators can see the changes as they are made. Collaborative editing can be a great way to improve efficiency, as it allows team members to work together on a document without having to wait for others to finish their changes.

## Prerequisites

Following things are needed to enable collaborative editing in Document Editor

- SignalR
- Microsoft SQL Server

## How to enable collaborative editing in client side

### Step 1: Enable collaborative editing in Document Editor

To enable collaborative editing, inject `CollaborativeEditingHandler` and set the property `enableCollaborativeEditing` to true in the Document Editor, like in the code snippet below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/collaborative-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/collaborative-editing/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/collaborative-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/collaborative-editing/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Step 2: Configure SignalR to send and receive changes

To broadcast the changes made and receive changes from remote users, configure SignalR like below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/collaborative-editing/script-1 %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/collaborative-editing/script-1 %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Step 3: Join SignalR room while opening the document

When opening a document, we need to generate a unique ID for each document. These unique IDs are then used to create rooms using SignalR, which facilitates sending and receiving data from the server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/collaborative-editing/script-2 %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/collaborative-editing/script-2 %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Step 5: Broadcast current editing changes to remote users

Changes made on the client-side need to be sent to the server-side to broadcast them to other connected users. To send the changes made to the server, use the method shown below from the document editor using the `contentChange` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/collaborative-editing/script-3 %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/collaborative-editing/script-3 %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## How to enable collaborative editing in ASP.NET Core

### Step 1: Configure SignalR in ASP.NET Core 

We are using Microsoft SignalR to broadcast the changes. Please add the following configuration to your application's Program.cs file.

```csharp
    using Microsoft.Azure.SignalR;
    .....
    builder.Services.AddSignalR();
    .....
    .....
    .....
    app.MapHub<DocumentEditorHub>("/documenteditorhub");
    .....
    .....
```

### Step 2: Configure SignalR hub to create room for collaborative editing session

To manage groups for each document, create a folder named "Hub" and add a file named "DocumentEditorHub.cs" inside it. Add the following code to the file to manage SignalR groups using room names.

Join the group by using unique id of the document by using `JoinGroup` method.

```csharp
static Dictionary<string, ActionInfo> userManager = new Dictionary<string, ActionInfo>();
    internal static Dictionary<string, List<ActionInfo>> groupManager = new Dictionary<string, List<ActionInfo>>();

    // Join to the specified room name
    public async Task JoinGroup(ActionInfo info)
    {
        if (!userManager.ContainsKey(Context.ConnectionId))
        {
            userManager.Add(Context.ConnectionId, info);
        }
        info.ConnectionId = Context.ConnectionId;
        //Add the current connected use to the specified group
        await Groups.AddToGroupAsync(Context.ConnectionId, info.RoomName);
        if (groupManager.ContainsKey(info.RoomName))
        {
            await Clients.Caller.SendAsync("dataReceived", "addUser", groupManager[info.RoomName]);
        }
        lock (groupManager)
        {
            if (groupManager.ContainsKey(info.RoomName))
            {
                groupManager[info.RoomName].Add(info);
            }
            else
            {
                List<ActionInfo> actions = new List<ActionInfo>
                {
                    info
                };
                groupManager.Add(info.RoomName, actions);
            }
        }
       // Notify other users in the group about new user joined the collaborative editing session.
        Clients.GroupExcept(info.RoomName, Context.ConnectionId).SendAsync("dataReceived", "addUser", info);
    }

```

Handle user disconnection using SignalR.

```csharp
//Handle disconnection from group.
    public override Task OnDisconnectedAsync(Exception? e)
    {
        string roomName = userManager[Context.ConnectionId].RoomName;
        if (groupManager.ContainsKey(roomName))
        {
            groupManager[roomName].Remove(userManager[Context.ConnectionId]);

            if (groupManager[roomName].Count == 0)
            {
                groupManager.Remove(roomName);
//If all user disconnected from current room. Auto save the change to source document.
CollaborativeEditingController.UpdateOperationsToSourceDocument(roomName, “<<documentpath>>”, false);
            }
        }

        if (userManager.ContainsKey(Context.ConnectionId))
        {
            //Notify other user in the group about user exit the collaborative editing session
            Clients.OthersInGroup(roomName).SendAsync("dataReceived", "removeUser", Context.ConnectionId);
            Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
            userManager.Remove(Context.ConnectionId);
        }
        return base.OnDisconnectedAsync(e);
    }

```

### Step 3: Configure Microsoft SQL database connection string in application level

Configure the SQL database that stores temporary data for the collaborative editing session. Provide the SQL database connection string in `appsettings.json` file.

```json
.....
"ConnectionStrings": {
  "DocumentEditorDatabase": "<SQL server connection string>"
}
.....

```

### Step 4: Configure Web API actions for collaborative editing

#### Import File

1.	When opening a document, create a database table to store temporary data for the collaborative editing session.
2.	If the table already exists, retrieve the records from the table and apply them to the WordDocument instance using the `UpdateActions` method before converting it to the SFDT format.

```csharp
public string ImportFile([FromBody] FileInfo param)
 {
     .....
     .....
     DocumentContent content = new DocumentContent();

     .....
     //Get source document from database/file system/blob storage
     WordDocument document = GetDocumentFromDatabase(param.fileName, param.documentOwner);
     .....
     //Get temporary records from database 
     List<ActionInfo> actions = CreatedTable(param.fileName);
     if(actions!=null)
     {
         //Apply temporary data to the document.
         document.UpdateActions(actions);
     }
     string json = Newtonsoft.Json.JsonConvert.SerializeObject(document);
     content.version = 0;
     content.sfdt = json;
     return Newtonsoft.Json.JsonConvert.SerializeObject(content);
 }

```

#### Update editing records to database.

Each edit operation made by the user is sent to the server and is pushed to the database. Each operation receives a version number after being inserted into the database.
After inserting the records to the server, the position of the current editing operation must be transformed against any previous editing operations not yet synced with the client using the TransformOperation method.
After performing the transformation, the current operation is broadcast to all connected users within the group.

```csharp
public async Task<ActionInfo> UpdateAction([FromBody] ActionInfo param)
{
    try
    {
        ActionInfo modifiedAction = AddOperationsToTable(param);
        //After transformation broadcast changes to all users in the gropu
        await _hubContext.Clients.Group(param.RoomName).SendAsync("dataReceived", "action", modifiedAction);
        return modifiedAction;
    }
    catch
    {
        return null;
    }
}

private ActionInfo AddOperationsToTable(ActionInfo action)
 {
     int clientVersion = action.Version;
     string tableName = action.RoomName;
     …………
     …………
     …………
     ………… 
     List<ActionInfo> actions = GetOperationsQueue(table);
     foreach (ActionInfo info in actions)
     {
      if (!info.IsTransformed)
      {
        CollaborativeEditingHandler.TransformOperation(info, actions);
      }
     }
     action = actions[actions.Count - 1];
     action.Version = updateVersion;
     //Return the transformed operation to broadcast it to other clients.
     return action;
 }

```

#### Add Web API to get previous operation as a backup to get lost operations

On the client side, messages broadcast using SignalR may be received in a different order, or some operations may be missed due to network issues. In these cases, we need a backup method to retrieve missing records from the database.
Using the following method, we can retrieve all operations after the last successful client-synced version and return all missing operations to the requesting client.

```csharp
public async Task<ActionInfo> UpdateAction([FromBody] ActionInfo param)
{
    try
    {
        ActionInfo modifiedAction = AddOperationsToTable(param);
        //After transformation broadcast changes to all users in the group
        await _hubContext.Clients.Group(param.RoomName).SendAsync("dataReceived", "action", modifiedAction);
        return modifiedAction;
    }
    catch
    {
        return null;
    }
}

private ActionInfo AddOperationsToTable(ActionInfo action)
 {
     int clientVersion = action.Version;
     string tableName = action.RoomName;
     …………
     …………
     …………
     ………… 
     List<ActionInfo> actions = GetOperationsQueue(table);
     foreach (ActionInfo info in actions)
     {
      if (!info.IsTransformed)
      {
        CollaborativeEditingHandler.TransformOperation(info, actions);
      }
     }
     action = actions[actions.Count - 1];
     action.Version = updateVersion;
     //Return the transformed operation to broadcast it to other clients.
     return action;
 }

```
## How to perform Scaling in Collaborative Editing.

As the number of user increases, maintaining responsiveness and performance becomes challenging. Scaling tackles this by distributing the workload across resources. You can scale the collaborative editing application using either ```Azure SignalR service or Redis backplane service```

### 1. Scaling with Azure SignalR

Azure SignalR Service is a scalable, managed service for real-time communication in web applications. It enables real-time messaging between web clients (browsers) and your server-side application(across multiple servers). 

Below is a code snippet to configure Azure SignalR in an ASP.NET Core application using the ```AddAzureSignalR``` method

```csharp
builder.Services.AddSignalR() .AddAzureSignalR("<your-connection-string>", options => { 
// Specify the channel name 
options.Channels.Add("document-editor");
 }); 
```

### 2. Scaling with Redis backplane

Using a Redis backplane, you achieve horizontal scaling of your SignalR application. The SignalR leverages Redis to efficiently broadcast messages across multiple servers. This allows your application to handle large user bases with minimal latency.

In the SignalR app, install the following NuGet package:
* ` Microsoft.AspNetCore.SignalR.StackExchangeRedis`

Below is a code snippet to configure Redis backplane in an ASP.NET Core application using the ```AddStackExchangeRedis ``` method

```csharp
builder.Services.AddSignalR().AddStackExchangeRedis("<your_Redis_connection_string>");
```
Configure options as needed:

The following example shows how to add a channel prefix in the ConfigurationOptions object. 

```csharp
builder.Services.AddDistributedMemoryCache().AddSignalR().AddStackExchangeRedis(connectionString, options =>
  {
      options.Configuration.ChannelPrefix = "document-editor";
  });
```


Full version of the code discussed about can be found in below GitHub location.

GitHub Example: [`Collaborative editing examples`](https://github.com/SyncfusionExamples/EJ2-Document-Editor-Collabrative-Editing)
