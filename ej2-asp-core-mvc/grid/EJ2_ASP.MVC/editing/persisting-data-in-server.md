---
layout: post
title: Persisting Data in Server in ##Platform_Name## Grid Control | Syncfusion
description: Learn here all about Persisting Data in Server in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Persisting Data in Server
publishingplatform: ##Platform_Name##
documentation: ug
---

# Persisting data in server in ASP.NET MVC Grid

The Syncfusion ASP.NET MVC Grid allows data edited within the Grid to be persisted in a database using RESTful web services. All CRUD (Create, Read, Update, and Delete) operations within the Grid are handled by the `DataManager`, which can bind server-side data and send updates to the server. This capability is essential for maintaining data integrity and ensuring that changes made in the UI are reflected in the backend.

> For your information, the `ODataAdaptor` persists data in the server as per OData protocol.

Syncfusion provides multiple adaptors to handle different server protocols and APIs, enabling smooth integration with RESTful services. Below are the various adaptors you can use to persist data in the Syncfusion ASP.NET MVC Grid.

**Using URL adaptor**

The `UrlAdaptor` is the base adaptor that facilitates communication between remote data services and the UI component. It allows seamless data binding and interaction with custom API services or any remote service through URLs. The `UrlAdaptor` is particularly useful when a custom API service has unique logic for handling data and CRUD operations. 

For further details on configuration, refer to the [URL adaptor Documentation]( https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/url-adaptor).

**Using OData v4 adaptor**

The `ODataV4Adaptor` in the Syncfusion ASP.NET MVC Grid facilitates seamless integration with OData V4 services, allowing for efficient data fetching and manipulation. You can perform CRUD operations using the `ODataV4Adaptor` in your Grid.

For further details on configuration, refer to the [OData v4 adaptor Documentation]( https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/odatav4-adaptor).

**Using Web API adaptor**

The `WebApiAdaptor` extends the capabilities of the `ODataAdaptor` and is designed to interact with Web APIs created with OData endpoints. This adaptor ensures seamless communication between the Syncfusion Grid and OData-based Web APIs, enabling efficient data retrieval and manipulation. 

For further details on configuration, refer to the [Web API Adaptor documentation]( https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/web-api-adaptor).

**Using Remote Save adaptor**

The `RemoteSaveAdaptor` in the Syncfusion ASP.NET MVC Grid allows you to perform Grid actions such as sorting, filtering, searching, and paging primarily on the client side, while handling CRUD operations (updating, inserting, and removing data) on the server side for data persistence. This approach optimizes your experience by minimizing unnecessary server interactions.

For further details on configuration, refer to the[Remote Save Adaptor Documentation]( https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/remote-save-adaptor).

**WebMethodAdaptor**

The `WebMethodAdaptor` facilitates data binding from remote services using web methods. This adaptor sends query parameters encapsulated within an object named value, allowing efficient communication between the client-side application and the server.

For further details on configuration, refer to the [Web API Adaptor documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/connecting-to-adaptors/web-method-adaptor).