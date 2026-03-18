---
layout: post
title: Collaborative editing in Blazor Diagram Component | Syncfusion
description: Learn how to implement collaborative editing in the Syncfusion Blazor Diagram component using SignalR and Redis.
platform: Blazor
control: Diagram
documentation: ug
---

# Collaborative Editing in Blazor Diagram
Collaborative editing in the Syncfusion Blazor Diagram Component allows multiple users to work on the same diagram simultaneously. All changes are synchronized in real time, so collaborators instantly see updates as they occur. This feature improves productivity and teamwork by eliminating delays.

To achieve this, the system uses:

* `SignalR` for real-time communication between Blazor application and the ASP.NET Core SignalR Hub.
* `Redis` as a temporary data store and backplane for scaling across multiple servers.

## Prerequisites
The following are required to enable collaborative editing in Diagram Component:
* Add the following NuGet packages:
    * Blazor Application:
      * Microsoft.AspNetCore.SignalR.Client
      * Syncfusion.Blazor.Diagram
    * ASP.NET Core SignalR Hub:
      * Microsoft.AspNetCore.SignalR
      * Microsoft.AspNetCore.SignalR.StackExchangeRedis
      * StackExchange.Redis

## How It Works
  1. SignalR Connection
     SignalR enables real-time communication between the Blazor application and the server hub. Each user joins a SignalR group (room) for a specific diagram session. Updates are broadcast only to users in the same room.

  2. Redis Backplane
    Redis ensures that collaborative editing works in a distributed environment by:
      * Storing versioning data for conflict resolution.
      * Acting as a backplane for SignalR to scale across multiple servers.
      * Periodically cleaning old version data to prevent memory issues.

