---
layout: post
title: Collaborative Editing in ##Platform_Name## Diagram | Syncfusion
description: Checkout and learn to configure SignalR and Redis for real-time collaborative editing in Syncfusion® ##Platform_Name## Diagram.
control: Diagram
documentation: ug
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
---

# SignalR hub configuration in ##Platform_Name## application

## Overview

This guide explains how to configure SignalR Hub in an ##Platform_Name## application for real-time collaborative diagram editing.

## Prerequisites

* [System requirements for ASP.NET Core components](../../system-requirements)

## How to create ##Platform_Name## application

To create an ##Platform_Name## application, follow the steps outlined in the ##Platform_Name## [Getting Started](../../diagram/getting-started) documentation.

## How to add packages in the ##Platform_Name## application

Open the NuGet Package Manager and install the following packages.

* Microsoft.AspNetCore.SignalR.Client
{% if page.publishingplatform == "aspnet-core" %}
* Syncfusion.EJ2.AspNet.Core
{% elsif page.publishingplatform == "aspnet-mvc" %}
* Syncfusion.EJ2.MVC5
{% endif %}

## Configure SignalR service in ##Platform_Name## application

To enable real-time collaboration, configure SignalR HubConnection in your ##Platform_Name## view/controller as follows:

* Initialize the `HubConnection` and start it using `start()`.
* Connect to the `/diagramHub` endpoint with WebSocket transport `skipNegotiation: true` and enable automatic reconnect to handle transient network issues.
* Subscribe to the `OnConnectedAsync` callback to receive the unique connection ID, confirming a successful handshake with the server.
* Join a SignalR group by calling `JoinDiagram(roomName)` after connecting. This ensures updates are shared only with users in the same diagram session.
* Refer to Create ##Platform_Name## [Simple Diagram](../../diagram/getting-started)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/collaborative-editing/config/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/collaborative-editing/config/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

>**Notes:**
>* Use a unique `roomName` per diagram (e.g., a diagram ID) to isolate sessions.
>* If `WebSockets` may be unavailable, remove `SkipNegotiation` so SignalR can fall back to SSE or Long Polling.
>* Consider handling reconnecting/disconnected states in the UI and securing the connection with authentication, if required.
>* For ##Platform_Name##, place this script in your shared layout or specific view where the diagram is hosted.


## Sending and applying real-time diagram changes

* The ##Platform_Name## Diagram component triggers the [historyChange](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_HistoryChange) event whenever the diagram is modified (e.g., add, delete, move, resize, or edit nodes/connectors).
* Use [getDiagramUpdates]() to produce a compact set of incremental updates (JSON-formatted changes) representing just the changes, not the entire diagram.
* Send these changes to the hub method `BroadcastToOtherUsers`, which relays them to all users joined to the same SignalR group (room).
* Each remote user listens for ReceiveData and applies the incoming changes with [setDiagramUpdates](), keeping their view synchronized without reloading the full diagram.
* Enable the `enableCollaborativeEditing` property on the diagram to treat multi-step edits (like drag/resize sequences or batch changes) as a single operation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/collaborative-editing/realtimeChanges/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/collaborative-editing/realtimeChanges/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Conflict policy (optimistic concurrency) in ##Platform_Name## application

To maintain consistency during collaborative editing, each user applies incoming changes using `setDiagramUpdates`. After applying changes, the ##Platform_Name## sample synchronizes its `userVersion` with the  `serverVersion` through the `UpdateVersion` event. This version-based approach ensures conflicts are resolved without locking, allowing real-time responsiveness while preserving data integrity.

Add the following code in the ##Platform_Name## application:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/collaborative-editing/conflict/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/collaborative-editing/conflict/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}
