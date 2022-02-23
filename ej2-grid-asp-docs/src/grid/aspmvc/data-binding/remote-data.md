# Remote Data

To bind remote data to grid component, assign service data as an instance of DataManager to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. To interact with remote data source,  provide the endpoint **url**.

{% aspTab template="grid/data-binding/remotedata", sourceFiles="remotedata.cs" %}

{% endaspTab %}

> By default, DataManager uses **ODataAdaptor** for remote data-binding.

## OData adaptor - Binding OData service

[OData](http://www.odata.org/documentation/odata-version-3-0/) is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager. Refer to the following code example for remote Data binding using OData service.

{% aspTab template="grid/data-binding/odata", sourceFiles="odata.cs" %}

{% endaspTab %}

## OData v4 adaptor - Binding OData v4 service

The ODataV4 is an improved version of OData protocols, and the DataManager can also retrieve and consume OData v4 services. For more details on OData v4 services, refer to the [odata documentation](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind OData v4 service, use the **ODataV4Adaptor**.

{% aspTab template="grid/data-binding/odataV4", sourceFiles="odataV4.cs" %}

{% endaspTab %}

## Web API Adaptor

You can use **WebApiAdaptor** to bind grid with Web API created using OData endpoint.

{% aspTab template="grid/data-binding/webapi", sourceFiles="webapi.cs" %}

{% endaspTab %}

The response object should contain properties, **Items** and **Count**, whose values are a collection of entities and total count of the entities, respectively.

The sample response object should look like this:

```json
{
    Items: [{..}, {..}, {..}, ...],
    Count: 830
}
```

## Remote save adaptor

You may need to perform all Grid Actions in client-side except the CRUD operations that should be interacted with server-side to persist data. It can be achieved in Grid by using **RemoteSaveAdaptor**.

Datasource must be set to Json Property and set Adaptor type as **RemoteSaveAdaptor** to the Adaptor Property of Grid [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource). CRUD operations can be mapped to server-side using UpdateUrl, InsertUrl, RemoveUrl, BatchUrl, CrudUrl properties.

You can use the following code example to use **RemoteSaveAdaptor**.

{% aspTab template="grid/data-binding/remotesaveadaptor", sourceFiles="remotesaveadaptor.cs" %}

{% endaspTab %}

## Custom adaptor

You can create your own adaptor by extending the built-in adaptors. The following demonstrates custom adaptor approach and how to add a serial number for the records by overriding the built-in response processing using the processResponse method of the **ODataAdaptor**.

{% aspTab template="grid/data-binding/customadaptor", sourceFiles="customsadaptor.cs" %}

{% endaspTab %}

## Offline mode

On remote data binding, all grid actions such as paging, sorting, editing, grouping, filtering, etc, will be processed on server-side. To avoid post back for every action, set the grid to load all data on initialization and make the actions process in client-side. To enable this behavior, use the **Offline** property of DataManager.

{% aspTab template="grid/data-binding/offline", sourceFiles="offline.cs" %}

{% endaspTab %}

## Handling on-demand grid actions

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

{% aspTab template="grid/data-binding/serversideoperation", sourceFiles="mvcdataoperation.cs" %}

{% endaspTab %}

> If the grid rendered rows with empty/blank values then it can be resolved with the procedure explained [here](#troubleshoot-grid-render-rows-without-data).