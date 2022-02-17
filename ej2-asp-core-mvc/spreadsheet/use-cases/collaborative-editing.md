---
layout: post
title: Collaborative Editing in ##Platform_Name## Spreadsheet Component
description: Learn here all about Collaborative Editing in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Collaborative Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Collaborative Editing

The collaborative editing support allows you to work at a spreadsheet collaboratively with other users. Multiple users can access to the the same spreadsheet simultaneously.

## Dependencies

The following dependent script is required to use the collaborative editing support in spreadsheet.

```js
<script src="https://cdnjs.cloudflare.com/ajax/libs/aspnet-signalr/1.1.4/signalr.js"></script>
```

## Client configuration

To broadcast the data for every action is spreadsheet, you need to transfer the data to the server through `send` method in `actionComplete` event and receive the same data by using the `dataReceived` method. In the `dataReceived` method, you need to update the action to the connected clients through `updateAction` method.

The following code example shows `Collaborative Editing` support in the Spreadsheet control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/collaborative-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CollaborativeController.cs" %}
{% include code-snippet/spreadsheet/collaborative-editing/collaborativeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/collaborative-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CollaborativeController.cs" %}
{% include code-snippet/spreadsheet/collaborative-editing/collaborativeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Server configuration

To make the communication between the server to the connected clients and from clients to the server, you need to configure the signalR Hubs using the following code.

```js

// For signalR Hub connection

var connection = new signalR.HubConnectionBuilder().withUrl('https://localhost:44385/hubs/spreadsheethub', { // localhost from AspNetCore service
    skipNegotiation: true,
    transport: signalR.HttpTransportType.WebSockets
  }).build();

```

## Hub configuration

Initially create a AspNetCore project and add the hub file for sending and receiving the data between server and clients.

```c#
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebApplication.Hubs
{
    public class SpreadsheetHub : Hub
    {
        public async Task BroadcastData(string data)
        {
            await Clients.All.SendAsync("dataReceived", data);
        }
    }
}
```

To configure the SignalR middleware by registering the following service in the `ConfigureServices` method of the `Startup` class.

```c#
    services.AddSignalR();
```

To set up the SignalR routes by calling MapHub in the `Configure` method of the `Startup` class.

```c#
    app.UseEndpoints(endpoints =>

    {

        endpoints.MapRazorPages();

        endpoints.MapHub<SpreadsheetHub>("/spreadsheetHub");

    });
```

For hosting the service, you may use the above code snippet or download and run the [local service](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WebApplication1377017438).

## Prevent the particular action update for collaborative client

Using the `action` argument from the `actionComplete` event, you can prevent the particular action update for collaborative client.

The following code example shows how to prevent collaborative client from updating the `format` action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/collaborative-prevent-action/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CollaborativePreventController.cs" %}
{% include code-snippet/spreadsheet/collaborative-prevent-action/collaborativePreventController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/collaborative-prevent-action/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CollaborativePreventController.cs" %}
{% include code-snippet/spreadsheet/collaborative-prevent-action/collaborativePreventController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

