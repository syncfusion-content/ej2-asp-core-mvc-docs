---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Data Binding of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding

The Grid uses `DataManager`, which supports both RESTful JSON data services binding and local JavaScript object array binding. The [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property can be assigned either with the instance of `DataManager` or JavaScript object array collection.
It supports the following kinds of data binding method:
* List binding
* DataTable binding
* Remote data

## List binding

To bind list binding to the grid, you can assign a IEnumerable object to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. The list data source can also be provided as an instance of the `DataManager`.

{% aspTab template="grid/data-binding/localdata", sourceFiles="local.cs" %}

{% endaspTab %}

> By default, `DataManager` uses `JsonAdaptor` for list data-binding.

## Remote data

To bind remote data to grid component, assign service data as an instance of `DataManager` to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. To interact with remote data source,  provide the endpoint `url`.

{% aspTab template="grid/data-binding/remotedata", sourceFiles="remotedata.cs" %}

{% endaspTab %}

> By default, `DataManager` uses `ODataAdaptor` for remote data-binding.

### Binding with OData services

[OData](http://www.odata.org/documentation/odata-version-3-0/) is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager. Refer to the following code example for remote Data binding using `OData` service.

{% aspTab template="grid/data-binding/odata", sourceFiles="odata.cs" %}

{% endaspTab %}

### Binding with OData v4 services

The ODataV4 is an improved version of OData protocols, and the `DataManager` can also retrieve and consume OData v4 services. For more details on OData v4 services, refer to the [OData documentation](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind OData v4 service, use the `ODataV4Adaptor`.

{% aspTab template="grid/data-binding/odataV4", sourceFiles="odataV4.cs" %}

{% endaspTab %}

### Handling On-Demand grid actions

`On-Demand` grid actions help you to improve the performance for large data application. To achieve `On-Demand` in the grid, use `UrlAdaptor`. To define `UrlAdaptor` in the grid, specify the data service in `url` and the `AdaptorType` as `UrlAdaptor` like below.

{% aspTab template="grid/data-binding/dataoperations" %}

{% endaspTab %}

After defined `DataManager`, grid will request an AJAX POST for data. It will be sent to the specified data service for every grid actions with the needed parameters. This query parameters will help you to perform server-side operations for grid.

| Parameters | Description |
|-----|-----|
| `RequiresCounts` | If it is `true` then the total count of records will be included in response. |
| `Skip` | Holds the number of records to skip. |
| `Take` | Holds the number of records to take. |
| `Sorted` | Contains details about current sorted column and its direction. |
| `Table` | Defines data source table name. |
| `Where` | Contains details about current filter column name and its constraints. |

The parameters of DataManager bound to `DataManagerRequest` in the server. You can use `Dataoperations` and `DataManagerRequest` to process grid actions such as `Paging`, `Sorting`, `Searching`, and `Filtering` using the following methods.

| Method Names | Actions |
|-----|-----|
| `PerformSkip` | Bypasses a specified `Skip` value and returns the remaining collections of records. |
| `PerformTake` | Bypasses a specified `Take` value and returns the remaining  collections of records. |
| `PerformFiltering` | `Filters` a sequence of records based on a predicate. |
| `PerformSorting` | `Sorts` the collections of records based on its direction. |
| `PerformSearching` | `Search` the records based on a predicate.  |

{% aspTab template="grid/data-binding/serversideoperation", sourceFiles="dataoperation.cs" %}

{% endaspTab %}

> If the grid rendered rows with empty/blank values then it can be resolved with the procedure explained [here](#troubleshoot-grid-render-rows-without-data).

### Web API

You can use `WebApiAdaptor` to bind grid with Web API created using OData endpoint.

{% aspTab template="grid/data-binding/webapi", sourceFiles="webapi.cs" %}

{% endaspTab %}

The response object should contain properties, `Items` and `Count`, whose values are a collection of entities and total count of the entities, respectively.

The sample response object should look like this:

```json
{
    Items: [{..}, {..}, {..}, ...],
    Count: 830
}
```

### Remote Save Adaptor

You may need to perform all Grid Actions in client-side except the CRUD operations, that should be interacted with server-side to persist data. It can be achieved in Grid by using `RemoteSaveAdaptor`.

Datasource must be set to `json` property and set `RemoteSaveAdaptor` to the `adaptor` property. CRUD operations can be mapped to server-side using `updateUrl`, `insertUrl`, `removeUrl`, `batchUrl`, `crudUrl` properties.

You can use the following code example to use `RemoteSaveAdaptor` in Grid.

{% aspTab template="grid/data-binding/remotesaveadaptor", sourceFiles="remotesaveadaptor.cs" %}

{% endaspTab %}

### Custom adaptor

You can create your own adaptor by extending the built-in adaptors. The following demonstrates custom adaptor approach and how to add a serial number for the records by overriding the built-in response processing using the `processResponse` method of the `ODataAdaptor`.

{% aspTab template="grid/data-binding/customadaptor", sourceFiles="customadaptor.cs" %}

{% endaspTab %}

### WebMethod

The `WebMethodAdaptor` is used to bind datasource from remote services and code behind methods. It can be enabled in Grid using Adaptor property of DataManager as `WebMethodAdaptor`.

For every operations, an AJAX post will be send to the specified data service.

{% aspTab template="grid/data-binding/webmethod", sourceFiles="webapi.cs" %}

{% endaspTab %}

`WebMethodAdaptor` expects JSON response from the server and the response object should contain properties `result` and `count`
whose values are collection of entities and total count of the entities respectively.

The sample response object should look like below.

```json
{
    result: [{..}, {..}, {..}, ...],
    count: 830
}
```

> The controller method's data parameter name must be `value`.

### Offline mode

On remote data binding, all grid actions such as paging, sorting, editing, grouping, filtering, etc, will be processed on server-side. To avoid post back for every action, set the grid to load all data on initialization and make the actions process in client-side. To enable this behavior, use the `Offline` property of `e-data-manager` tag helper.

{% aspTab template="grid/data-binding/offline", sourceFiles="offline.cs" %}

{% endaspTab %}

### Sending additional parameters to the server

To add a custom parameter to the data request, use the `addParams` method of `Query` class. Assign the `Query` object with additional parameters to the grid [`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property.

{% aspTab template="grid/data-binding/params", sourceFiles="params.cs" %}

{% endaspTab %}

> The parameters added using the [`Query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property will be sent along with the data request for every grid action.

### Handling HTTP error

During server interaction from the grid, some server-side exceptions may occur, and you can acquire those error messages or exception details
in client-side using the [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event.

The argument passed to the [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event contains the error details returned from the server.

{% aspTab template="grid/data-binding/httperror", sourceFiles="httperror.cs" %}

{% endaspTab %}

> The [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event will be triggered not only for the server errors, but
also when there is an exception while processing the grid actions.

## DataTable

DataTable represents a table with relational data which has in-built schema to work easily with data column and data row objects.

You can bind `DataTable` to the grid by using [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. While binding DataTable like below, grid actions such as `Sorting`, `Filtering`, `Grouping`, `Paging` etc., will handle at client side..

{% aspTab template="grid/data-binding/datatable", sourceFiles="datatable.cs" %}

{% endaspTab %}

> `DataTable` will be supported from .Net Core 2.0.

### DataTable with On-Demand Grid actions

[`On-Demand grid actions`](#handling-on-demand-grid-actions/) helps you to improve performance for large data application. To perform server side grid actions for DataTable, you need to convert `DataTable` to `IEnumerable` using `Utils.DataTableToJson` method. Thereby in controller action, you need to use `DataOperations` class for performing grid actions and return result as JSON with `result` and `count` pair.

{% aspTab template="grid/data-binding/clientdatatable" , sourceFiles="dataoperation.cs" %}

{% endaspTab %}

### DataTable with CRUD operations

To perform server side CRUD operations for DataTable, you need to use `InsertUrl`, `UpdateUrl` and `RemoveUrl` of `DataManager` for inserting, updating and deleting the records in the specified controller actions.

To pass the data from client side to server side when performing CRUD operations, you need to use `ExpandoObject` as a parameter for inserting and adding actions.

{% aspTab template="grid/data-binding/cruddatatable" , sourceFiles="dataoperation.cs" %}

{% endaspTab %}

## Binding with ajax

You can use Grid [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property to bind the datasource to Grid from external ajax request. In the below code we have fetched the datasource from the server with the help of ajax request and provided that to [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property by using `onSuccess` event of the ajax.

```javascript
<script type="text/javascript">
    var grid = document.getElementById('Grid').ej2_instances[0]; // Grid instance
    var ajax = new ej.base.Ajax('/Home/UrlDatasource', 'GET');
    ajax.send();
    ajax.onSuccess = function (data) {
        grid.dataSource = ej.data.DataUtil.parse.parseJson(data).result;
    };
</script>
```

> If you bind the dataSource from this way, then it acts like a local dataSource. So you cannot perform any server side crud actions.

## Troubleshoot: Grid render rows without data

In ASP.NET Core, by default the JSON results are returned in camelCase format. So grid field names are also changed in camelCase.

To avoid this problem, you need to add **DefaultContractResolver** in **Startup.cs** file.

```javascript
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().AddJsonOptions(options =>
    {
        options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
    });
}
```

**Note:** For ASP.NET **Core  3.0 or above**, use the below code

For this we need to install **Microsoft.AspNetCore.Mvc.NewtonsoftJson** package.

```javascript
  public void ConfigureServices(IServiceCollection services)
          {
            services.AddMvc().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
           }
```