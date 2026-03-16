---
layout: post
title: Collaborative Editing in ##Platform_Name## Diagram | Syncfusion®
description: Checkout and learn to set up real-time collaborative editing in Syncfusion® ##Platform_Name## Diagram using WebSocket and Redis.
control: Diagram
documentation: ug
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
---

# Collaborative editing in ##Platform_Name## diagram

Collaborative editing enables multiple users to edit diagrams simultaneously in real-time, providing a seamless collaborative experience in ##Platform_Name## applications.

## Purpose

Collaborative editing in diagram control allows multiple users to edit and review diagrams in real time, ensuring accuracy, consistency, and faster updates. It streamlines teamwork by reducing delays, improving communication through comments, and maintaining data integrity with version tracking.

## Configuration

* Use `SignalR` for real-time communication between the ##Platform_Name## app and a ASP.NET Core SignalR server
* Use `Redis` as a temporary data store to manage updates and version state
* Basic setup:
    * Configure a SignalR server. [Refer link](./collaborative-editing-hub)
    * Connect the ##Platform_Name## app to the server. [Refer link](./mvc-app-collaborative-editing)

## Limitations

* Default deployment
    * By default, a single server instance works without additional setup. For multi-instance (scale-out) deployments, configure a `SignalR` backplane (e.g., Redis) and use a shared `Redis` store so all nodes share group messages and version state consistently.
* View-only interactions
    * Zoom and pan are local to each user and are not synchronized, so collaborators may view different areas of the diagram.
* Unsupported synchronized settings
    * Changes to `pageSettings`, `contextMenuSettings`, `snapSettings`, `rulerSettings`, `layout`, and `scrollSettings` are not propagated to other users and apply only locally.

>**Note:** 
Collaboration applies to actions that raise the [historyChange]({% if page.publishingplatform == "aspnet-core" %}https://ej2.syncfusion.com/aspnetcore/documentation/diagram/api-diagram/#historychange{% elsif page.publishingplatform == "aspnet-mvc" %}https://ej2.syncfusion.com/aspnetmvc/documentation/diagram/api-diagram/#historychange{% endif %}) event.

## Sample code

A complete working example is available in the [Syncfusion ##Platform_Name## Collaborative Editing GitHub repository](https://github.com/syncfusion/aspnetcore-showcase-diagram-collaborative-editing)

---
