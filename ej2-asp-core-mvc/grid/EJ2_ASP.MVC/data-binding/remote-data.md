---
layout: post
title: Remote Data in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Remote Data in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Remote Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Remote Data in ASP.Net MVC Grid Component

To bind remote data to grid component, assign service data as an instance of DataManager to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. To interact with remote data source,  provide the endpoint **url**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/remotedata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/grid/data-binding/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/remotedata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/grid/data-binding/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> By default, DataManager uses **ODataAdaptor** for remote data-binding.

## ExpandoObject with complex column binding using URL adaptor

You can achieve ExpandoObject complex data binding in the data grid by using the dot(.) operator in the column.field. In the following examples, Customer.OrderDate, Customer.Freight, and Customer.ShipCountry are complex data.

The following code example shows how to bind ExpandoObject datasource in grid using URL adaptor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding-URL/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding-URL/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding-URL/razor %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding-URL/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> Perform data and CRUD operations for complex ExpandoObject binding fields as well.

The following image represents ExpandoObject complex data binding.

![Grid with ExpandoObject Binding](../../images/ExpandoObjectDemo.gif)

## DynamicObject with complex column binding using URL adaptor

You can achieve DynamicObject complex data binding in the data grid by using the dot(.) operator in the `column.field`. In the following examples, Customer.OrderDate, Customer.Freight, and Customer.ShipCountry are complex data.

The following code example shows how to bind DynamicObject datasource in grid using URL adaptor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding-URL/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding-URL/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding-URL/razor %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding-URL/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> Perform data and CRUD operations for complex DynamicObject binding fields as well.

The following image represents DynamicObject complex data binding. 

![Grid with DynamicObject Binding](../../images/DynamicObjectDemo.gif)

## OData adaptor - Binding OData service

[OData](http://www.odata.org/documentation/odata-version-3-0/) is a standardized protocol for creating and consuming data. You can retrieve data from OData service using the DataManager. Refer to the following code example for remote Data binding using OData service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/grid/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/grid/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## OData v4 adaptor - Binding OData v4 service

The ODataV4 is an improved version of OData protocols, and the DataManager can also retrieve and consume OData v4 services. For more details on OData v4 services, refer to the [odata documentation](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind OData v4 service, use the **ODataV4Adaptor**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/odataV4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OdataV4.cs" %}
{% include code-snippet/grid/data-binding/odataV4/odataV4.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/odataV4/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OdataV4.cs" %}
{% include code-snippet/grid/data-binding/odataV4/odataV4.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Odata with custom url

The Syncfusion ODataV4 adaptor extends support for calling customized URLs to accommodate data retrieval and CRUD actions as per your application's requirements. However, when utilizing a custom URL with the ODataV4 adaptor, it's essential to modify the routing configurations in your application's route configuration file to align with your custom URL. You can invoke the custom URL by the following methods in the Datamanager

**Configuring Custom URLs**

To work with custom URLs for CRUD operations in the Syncfusion Grid, you can use the following properties:

* insertUrl: Specifies the custom URL for inserting new records.
* removeUrl: Specifies the custom URL for deleting records.
* updateUrl: Specifies the custom URL for updating records.
* batchUrl: Specifies the custom URL for batch editing operations.

> Ensure that the routing configurations on the server-side are properly updated to handle these custom URLs.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" })">
    <e-data-manager url="http://services.odata.org/V4/Northwind/Northwind.svc/Orders/?$top=7" adaptor="ODataV4Adaptor" 
    updateUrl= "https://localhost:xxxx/odata/Orders/Update" 
    insertUrl= "https://localhost:xxxx/odata/Orders/Insert"
    removeUrl= "https://localhost:xxxx/odata/Orders/Delete" 
    crossdomain="true"></e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" type="number" textAlign="Right" width="120" isPrimaryKey="true" validationRules="@(new { required=true})"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" type="string" width="140" validationRules="@(new { required=true, minLength=3})"></e-grid-column>
        <e-grid-column field="Freight" headerText="Freight" textAlign="Right" format="C2" width="120"></e-grid-column>
        <e-grid-column field="OrderDate" headerText="Order Date" format='yMd' textAlign="Right" width="140"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
@Html.EJS().Grid("OdataV4").DataSource(dataManger =>
{
    dataManger.Url("https://ej2services.syncfusion.com/production/web-services/api/Orders").InsertUrl("https://localhost:xxxx/odata/Orders/Insert").
    RemoveUrl("https://localhost:xxxx/odata/Orders/Delete").
    UpdateUrl("https://localhost:xxxx/odata/Orders/Update").
    CrossDomain(true).
    Adaptor("ODataV4Adaptor");
}).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Width("120").ValidationRules(new { required = "true"}).Add();
    col.Field("CustomerID").HeaderText("Customer ID").ValidationRules(new { required = "true", minLength=3 }).Width("160").Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
    col.Field("Freight").HeaderText("Freight").Width("150").Format("C2").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();

}).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()
{% endhighlight %}
{% endtabs %}
{% endif %}

For batch editing, you can specify a custom batch URL as follows:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<ejs-grid id="Grid" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" })">
    <e-data-manager url="http://services.odata.org/V4/Northwind/Northwind.svc/Orders/?$top=7" adaptor="ODataV4Adaptor"
    BatchUrl="https://localhost:xxxx/odata/Orders/BatchUpdate"
    crossdomain="true"></e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Batch"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" type="number" textAlign="Right" width="120" isPrimaryKey="true" validationRules="@(new { required=true})"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" type="string" width="140" validationRules="@(new { required=true, minLength=3})"></e-grid-column>
        <e-grid-column field="Freight" headerText="Freight" textAlign="Right" format="C2" width="120"></e-grid-column>
        <e-grid-column field="OrderDate" headerText="Order Date" format='yMd' textAlign="Right" width="140"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
@Html.EJS().Grid("OdataV4").DataSource(dataManger =>
{
    dataManger.Url("https://ej2services.syncfusion.com/production/web-services/api/Orders").
    BatchUrl("https://localhost:xxxx/odata/Orders/BatchUpdate").
    CrossDomain(true).
    Adaptor("ODataV4Adaptor");
}).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Width("120").ValidationRules(new { required = "true"}).Add();
    col.Field("CustomerID").HeaderText("Customer ID").ValidationRules(new { required = "true", minLength=3 }).Width("160").Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
    col.Field("Freight").HeaderText("Freight").Width("150").Format("C2").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();

}).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Batch); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()
{% endhighlight %}
{% endtabs %}
{% endif %}

## Web API Adaptor

You can use **WebApiAdaptor** to bind grid with Web API created using OData endpoint.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/webapi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/grid/data-binding/webapi/controller.cs %}
{% endhighlight %}
{% highlight c# tabtitle="WebAPI.cs" %}
{% include code-snippet/grid/data-binding/webapi/webapi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/webapi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/grid/data-binding/webapi/controller.cs %}
{% endhighlight %}
{% highlight c# tabtitle="WebAPI.cs" %}
{% include code-snippet/grid/data-binding/webapi/webapi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/remotesaveadaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotesaveadaptor.cs" %}
{% include code-snippet/grid/data-binding/remotesaveadaptor/remotesaveadaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/remotesaveadaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotesaveadaptor.cs" %}
{% include code-snippet/grid/data-binding/remotesaveadaptor/remotesaveadaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Custom adaptor

You can create your own adaptor by extending the built-in adaptors. The following demonstrates custom adaptor approach and how to add a serial number for the records by overriding the built-in response processing using the processResponse method of the **ODataAdaptor**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/customadaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customsadaptor.cs" %}
{% include code-snippet/grid/data-binding/customadaptor/customsadaptor.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Customsadaptor.cs" %}
{% include code-snippet/grid/data-binding/customadaptor/customsadaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/customadaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customsadaptor.cs" %}
{% include code-snippet/grid/data-binding/customadaptor/customsadaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Offline mode

On remote data binding, all grid actions such as paging, sorting, editing, grouping, filtering, etc, will be processed on server-side. To avoid post back for every action, set the grid to load all data on initialization and make the actions process in client-side. To enable this behavior, use the **Offline** property of DataManager.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/offline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/grid/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/offline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/grid/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Handling on-demand grid actions

`On-Demand` grid actions help you to improve the performance for large data application. To achieve `On-Demand` in the grid, use `UrlAdaptor`. To define `UrlAdaptor` in the grid, specify the data service in `url` and the `AdaptorType` as `UrlAdaptor` like below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dataoperations/tagHelper %}
{% endhighlight %}
{% highlight cshtml tabtitle="Dataoperations.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dataoperations/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dataoperations.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Mvcdataoperation.cs" %}
{% include code-snippet/grid/data-binding/serversideoperation/mvcdataoperation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Mvcdataoperation.cs" %}
{% include code-snippet/grid/data-binding/serversideoperation/mvcdataoperation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> If the grid rendered rows with empty/blank values then it can be resolved with the procedure explained [here](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/data-binding/data-binding#troubleshoot-grid-render-rows-without-data).
