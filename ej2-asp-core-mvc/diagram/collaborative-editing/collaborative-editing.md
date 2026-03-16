---
layout: post
title: Collaborative Editing in Syncfusion ASP.NET Core MVC Diagram | Syncfusion
description: Checkout and learn to set up real-time collaborative editing in Syncfusion ASP.NET Core MVC Diagram using WebSocket and Redis.
control: Diagram
documentation: ug
platform: ej2-asp-core-mvc
domainurl: ##DomainURL##
---

# Collaborative editing in ASP.NET Core MVC diagram

Collaborative editing enables multiple users to edit diagrams simultaneously in real-time, providing a seamless collaborative experience in ASP.NET Core MVC applications.

## Purpose

Collaborative editing in diagram control allows multiple users to edit and review diagrams in real time, ensuring accuracy, consistency, and faster updates. It streamlines teamwork by reducing delays, improving communication through comments, and maintaining data integrity with version tracking.

## Configuration

* Use `SignalR` for real-time communication between the ASP.NET Core MVC app and a ASP.NET Core SignalR server
* Use `Redis` as a temporary data store to manage updates and version state
* Basic setup:
    * Configure a SignalR server. [Refer link](./collaborative-editing-hub)
    * Connect the ASP.NET Core MVC app to the server. [Refer link](./mvc-app-collaborative-editing)

## Limitations

* Default deployment
    * By default, a single server instance works without additional setup. For multi-instance (scale-out) deployments, configure a `SignalR` backplane (e.g., Redis) and use a shared `Redis` store so all nodes share group messages and version state consistently.
* View-only interactions
    * Zoom and pan are local to each user and are not synchronized, so collaborators may view different areas of the diagram.
* Unsupported synchronized settings
    * Changes to `pageSettings`, `contextMenuSettings`, `snapSettings`, `rulerSettings`, `layout`, and `scrollSettings` are not propagated to other users and apply only locally.

>**Note:** 
Collaboration applies to actions that raise the [historyChange](https://ej2.syncfusion.com/aspnetcore/documentation/diagram/api-diagram/#historychange) event.

## Sample code

A complete working example is available in the [Syncfusion ASP.NET Core MVC Collaborative Editing GitHub repository](https://github.com/syncfusion/aspnetcore-showcase-diagram-collaborative-editing)

---
