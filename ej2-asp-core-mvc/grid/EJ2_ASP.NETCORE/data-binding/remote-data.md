---
layout: post
title: ##Platform_Name## Grid Remote Data Binding | Syncfusion
description: Learn how to bind remote data sources in ##Platform_Name## Data Grid using adaptors, configure server-side operations, and manage data efficiently.
platform: ej2-asp-core-mvc
control: Remote Data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Remote Data Binding in ASP.NET Core Data Grid

Remote data binding enables the Data Grid to connect directly to external data services or databases through the dataSource property. This approach supports on‑demand, server‑side operations such as paging, sorting, filtering, and CRUD, making it ideal for efficiently handling large datasets.

For proper functionality, the server response must include two key properties:

- `result`: the records to display in the current viewport.
- `count`: the total number of records in the dataset for pagination.

## Bind remote data using DataManager

The Data Grid uses the `DataManager` library to connect with external data services or databases such as REST APIs, Web APIs, OData services, and GraphQL endpoints. The DataManager provides a unified interface for communication between the grid and different backends.

The DataManager relies on adaptors to establish the connection between the data service and the grid. Adaptors define the manner in which requests are generated and responses are processed, ensuring that operations such as paging, sorting, filtering, grouping, and searching follow a consistent pattern.

Adaptors also provide native query support, automatically formatting requests in the expected structure. For example, the `ODataAdaptor` generates queries in OData format, while the `GraphQLAdaptor` builds queries according to GraphQL schema definitions. Server responses are then mapped into the grid’s required format (result and count), ensuring predictable integration across different backends.

| Integration type | Description | Learn more |
|------------------|-------------|------------|
| GraphQL | Connects to GraphQL endpoints for flexible data querying. | [GraphQLAdaptor](../connecting-to-adaptors/graphql-adaptor) |
| OData V4 Services | Connects to OData V4 services with built-in query support. | [ODataV4Adaptor](../connecting-to-adaptors/odatav4-adaptor) |
| Hybrid Data Binding | Performs data operations locally while saving CRUD changes to the server. | [RemoteSaveAdaptor](../connecting-to-adaptors/remote-save-adaptor) |
| REST APIs | Connects to REST-based services with custom endpoints and response formats. | [UrlAdaptor](../connecting-to-adaptors/url-adaptor) |
| REST APIs Using Web Methods | Connects to ASP.NET WebMethod-based services. | [WebMethodAdaptor](../connecting-to-adaptors/web-method-adaptor) |
| Web API Services | Connects to ASP.NET Web APIs and supports server-side data operations. | [WebApiAdaptor](../connecting-to-adaptors/webapi-adaptor) |
| Custom Remote Data | Integrates with custom remote data services and business-specific APIs. | [CustomAdaptor](../connecting-to-adaptors/custom-adaptor) |
| Microsoft SQL Server | Connects to Microsoft SQL Server databases using ADO.NET and Entity Framework. | [SQL Server](../connecting-to-database/microsoft-sql-server) |
| MySQL Server | Provides cross-platform data access for MySQL databases. | [MySQL Server](../connecting-to-database/mysql-server) |
| PostgreSQL | Delivers advanced relational capabilities with PostgreSQL databases. | [PostgreSQL](../connecting-to-database/postgresql-server) |
| SQLite | Supports embedded and local storage scenarios with SQLite databases. | [SQLite](../connecting-to-database/sqlite-server) |
| Entity Framework | Integrates with EF and EF Core-based applications. | [Entity Framework](../connecting-to-database/entityframework) |
| Dapper | Offers lightweight SQL-based data access for applications. | [Dapper](../connecting-to-database/dapper) |

The following code example demonstrates connecting the Data Grid to a REST API using `UrlAdaptor`. For other service types, replace `UrlAdaptor` with the appropriate adaptor (e.g., `WebApiAdaptor`, `ODataV4Adaptor`, `WebMethodAdaptor`, `RemoteSaveAdaptor`, or `GraphQLAdaptor`).

```cshtml
@using Syncfusion.EJ2

@(Html.EJS().Grid("Grid")
    .DataSource(dataManager =>
    {
        dataManager.Url("https://localhost:5001/api/Orders")
                   .Adaptor("UrlAdaptor");
    })
    .Columns(col =>
    {
        col.Field("OrderID").HeaderText("Order ID").Width("120").Add();
        col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
        col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
    })
    .Render()
)
```
## Custom remote binding

The Data Grid supports custom remote binding, which provides complete control over remote data integration when built‑in adaptors do not meet specific application requirements. It enables direct control over the manner in which requests are sent to the backend and responses are processed, making it suitable for unique APIs or specialized workflows.

The Data Grid provides two key events for handling remote data operations.

The `DataStateChange` event is used to capture Data Grid actions such as paging, sorting, and filtering. Within this event, the application can construct the required queries, send them to the backend, and return the response in the expected format (result and count).

The `dataSourceChange` event is used to handle CRUD operations (Create, Read, Update, and Delete). This event allows the application to process changes made in the grid and synchronize them with the backend service. Refer to the [Custom Binding](./custom-binding) documentation.

```cshtml
@using Syncfusion.EJ2

@(Html.EJS().Grid("Grid")
    .AllowPaging()
    .AllowSorting()
    .Columns(col =>
    {
        // Define columns here
    })
    .DataBound("dataBound")
    .Render()
)

<script>
    function dataStateChange(state) {
        var grid = document.getElementById('Grid').ej2_instances[0];

        getOrders(state).then(function (result) {
            grid.dataSource = {
                result: result.result,
                count: result.count
            };
        });
    }
</script>
```