---
layout: post
title: ##Platform_Name## Grid Server Data Persistence | Syncfusion
description: Learn how to persist ##Platform_Name## Data Grid changes to a server, send CRUD requests, handle server responses, and synchronize data using adaptors.
platform: ej2-asp-core-mvc
control: Persisting Data in Server
publishingplatform: ##Platform_Name##
documentation: ug
---

# Server Data Persistence in ASP.NET Core Data Grid

The Data Grid component allows data edited within the grid to be persisted in a database using RESTful web services. The `DataManager` handles CRUD (Create, Read, Update, Delete) operations, binds server-side data, and sends updates to the server. This capability helps maintain data integrity and keeps UI changes synchronized with the backend.

Syncfusion<sup style="font-size:70%">&reg;</sup> provides multiple adaptors to handle different server protocols and APIs, enabling smooth integration with RESTful services. The following adaptors are available to persist data in the Data Grid component.

> The ODataAdaptor persists data in the server using the OData protocol.

## URL Adaptor

The `UrlAdaptor` is the base adaptor that facilitates communication between remote data services and the UI component. It allows seamless data binding and interaction with custom API services or any remote service through URLs. The UrlAdaptor is particularly useful when a custom API service has unique logic for handling data and CRUD operations. 

For further details on configuration, refer to the [URL adaptor Documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/url-adaptor).

## Remote Save Adaptor

The `RemoteSaveAdaptor`  in the Data Grid component allows grid actions such as sorting, filtering, searching, and paging to be performed primarily on the client side, while handling CRUD operations such as updating, inserting, and removing data on the server side.

For further details on configuration, refer to the[Remote Save Adaptor Documentation]( https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/remote-save-adaptor).

## OData V4 Adaptor

The `ODataV4Adaptor` in the Data Grid Component facilitates seamless integration with OData V4 services, allowing for efficient data fetching and manipulation. CRUD operations can be performed using the `ODataV4Adaptor` in the Data Grid component.

For further details on configuration, refer to the [OData v4 adaptor Documentation]( https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/odatav4-adaptor).

## Web API Adaptor

The `WebApiAdaptor` extends the capabilities of the ODataAdaptor and is designed to interact with Web APIs created with OData endpoints. This adaptor ensures seamless communication between the Data Grid and OData-based Web APIs, enabling efficient data retrieval and manipulation. 

For further details on configuration, refer to the [Web API Adaptor documentation]( https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/web-api-adaptor).

## Web Method Adaptor

The `WebMethodAdaptor` facilitates data binding from remote services using web methods. This adaptor sends query parameters encapsulated within an object named value, allowing efficient communication between the client-side application and the server.

For further details on configuration, refer to the [Web API Adaptor documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid/connecting-to-adaptors/web-method-adaptor).