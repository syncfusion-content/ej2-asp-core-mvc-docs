---
layout: post
title: ##Platform_Name## Grid Data Binding | Syncfusion
description: Learn how to bind local and remote data sources in ##Platform_Name## Data Grid, enable dynamic updates, and manage data flow efficiently.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data Binding in ASP.NET MVC Data Grid

Data binding is a fundamental technique that empowers the Data Grid component to integrate data into its interface, enabling the creation of dynamic and interactive grid views. This feature is particularly valuable when working with large datasets or when data needs to be fetched remotely.

The Data Grid utilizes the `DataManager`, which supports both local binding with JavaScript object arrays and remote binding with RESTful JSON data services. The key property, [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource), can be assigned to a DataManager instance or a collection of JavaScript object arrays.

The Data Grid enables data binding through the following approaches:

* [Local data](./local-data)
* [Remote data](./remote-data)
* [Custom API](./custom-binding)

## Loading indicator

The Data Grid provides a loading animation feature, which makes it easy to identify when data is being loaded or refreshed. This feature provides a clear understanding of the grid's current state and actions, such as sorting, filtering, grouping, and more.

To achieve this, the `loadingIndicator.indicatorType` property of the grid can be utilized, which supports two types of indicators:

* `Spinner` (default)
* `Shimmer`

The following example demonstrates setting the `loadingIndicator.indicatorType` property based on changing the dropdown value using the [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event of the [DropDownList](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started) component. The `refreshColumns` method is used to apply the changes and display the updated loading indicator type.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indicator" %}
{% include code-snippet/grid/data-binding/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

![Loading indicator](../images/data-binding/databinding-animation.gif)

## Refresh the data source using the dataSource property

Refreshing the data shown in an Data Grid involves updating the data that the grid displays dynamically. This operation reflects changes in the underlying data without reloading the entire page or component.

To achieve this, use the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property in conjunction with the `setProperties` method. This ensures the grid reflects changes in the `dataSource` without requiring a complete page or component reload.

For example, when adding or deleting data source records, follow these steps:

**Step 1**: Add/delete the data source record by using the following code.

```typescript
    var grid = document.getElementById("grid").ej2_instances[0];
    grid.dataSource.unshift(data); // Add a new record.
    grid.dataSource.splice(selectedRow, 1); // Delete a record.
```

**Step 2**:  Refresh the data source after changes by invoking the `setProperties` method.

```typescript
   grid.setProperties({ dataSource:  grid.dataSource});
```
The following example demonstrates adding a new record to the data source through an external button:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/databinding-refresh/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/grid/data-binding/databinding-refresh/databind.cs %}
{% endhighlight %}
{% endtabs %}

![Refresh the datasource using property](../images/data-binding/databinding-refersh.gif)

## Change the data source or columns dynamically

The Data Grid component supports dynamic modification of the data source, columns, or both. This feature refreshes the grid's content and structure without requiring a complete page reload.

To achieve dynamic changes, the `changeDataSource` method allows updating the grid's data source dynamically. This method enables updating the data source, columns, or both, based on application requirements. However, it is important to note that during the changing process for the data source and columns, the grid's existing actions such as sorting, filtering, grouping, aggregation, and searching will be reset. The `changeDataSource` method has two optional arguments: the first argument represents the data source, and the second argument represents the columns. The various uses of the `changeDataSource` method are explained in the following topic.

### Change both data source and columns

To modify both the existing columns and the data source, both arguments must be passed to the `changeDataSource` method. The following example demonstrates changing both the data source and columns.

A JavaScript object array can be assigned to the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property to bind local data to the Grid. The code below provides an example of creating a data source for the Grid.

```typescript
    export let data= [
    {
        OrderID: 10248, CustomerID: 'VINET', Freight: 32.38,
        ShipCity: 'Reims'
    },
    {
        OrderID: 10249, CustomerID: 'TOMSP', Freight: 11.61,
        ShipCity: 'Münster'
    },
    {
        OrderID: 10250, CustomerID: 'HANAR', Freight: 61.34,
        ShipCity: 'Rio de Janeiro'
    }];
```

The following code demonstrates creating the [Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) for the Grid, which are based on the provided Grid data source.

```typescript
    newColumn= [
        { field: 'OrderID', headerText: 'Order ID', textAlign: 'Right', width: 125 },
        { field: 'CustomerID', headerText: 'Customer ID', width: 125 },
    ];
```

The following code demonstrates updating the data source and columns defined above using the `changeDataSource` method.

```typescript
    var grid = document.getElementById("grid").ej2_instances[0];
    grid.changeDataSource(data, newColumn);
```

### Change only columns

To modify existing columns in a grid, add or remove columns or replace the entire set of columns using the `changeDataSource` method. To use this method, set the first parameter to `null` and provide the new columns as the second parameter. Note that if a column field is not specified in the `dataSource`, its corresponding column values will be empty. The following example illustrates modifying existing columns.

The following code demonstrates adding new columns with existing grid columns "newColumn" using the `changeDataSource` method:

```typescript
    var grid = document.getElementById("grid").ej2_instances[0];
    newColumn1= [
        { field: 'Freight', headerText: 'Freight', textAlign: 'Right', width: 125 },
        { field: 'ShipCity', headerText: 'ShipCity', width: 125 },
    ];
    let column = this.newColumn.push(...this.newColumn1);
    grid.changeDataSource(null, column);
```

### Change only the data source

The `changeDataSource` method provides an option to change the entire data source in the grid by passing the new data source as the first argument. The optional second argument can specify new columns for the grid. If columns are not specified, the grid auto-generates columns based on the data source.

The following code demonstrates creating a new data source for the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) method:

```typescript
     export let employeeData = [
    {
        FirstName: 'Nancy', City: 'Seattle', Region: 'WA',
        Country: 'USA'
    },
    {
        FirstName: 'Andrew', City: 'London', Region: null,
        Country: 'UK',
    },
    {
        FirstName: 'Janet', City: 'Kirkland', Region: 'WA',
        Country: 'USA'
    }];
```

The following code demonstrates using the `changeDataSource` method to bind the new **employeeData** to the Grid.

```typescript
    var grid = document.getElementById("grid").ej2_instances[0];
    grid.changeDataSource(employeeData);
```

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/databinding-change-datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/grid/data-binding/databinding-change-datasource/databind.cs %}
{% endhighlight %}
{% endtabs %}

![Dynamically change the datasource or columns or both](../images/data-binding/change-datsource.gif)

> * The Grid state persistence feature does not support the  `changeDataSource` method.
> * In this document, the above sample uses the local data for `changeDataSource` method. For those using a remote data source, refer to the [FlexibleData](https://ej2.syncfusion.com/aspnetmvc/grid/flexibledata#/fluent2) resource.

## DataTable

The DataTable feature represents a structured table with relational data, equipped with an in-built schema that simplifies working with data column and row objects. This allows for a more intuitive way to manage and display complex data in the Syncfusion ASP.NET MVC Grid.

To bind a DataTable to the Grid, utilize the [dataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. When a DataTable is bound, Grid actions such as Sorting, Filtering, Grouping, and Paging are processed on the client side, enhancing performance and responsiveness.

The following steps describe binding a `DataTable` to the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/datatable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datatable.cs" %}
{% include code-snippet/grid/data-binding/datatable/datatable.cs %}
{% endhighlight %}
{% endtabs %}

> `DataTable` will be supported from .NET Core 2.0. 

### DataTable with on-demand Grid actions

The [On-Demand Grid Actions](#handling-on-demand-grid-actions/) feature in Data Grid enables server-side processing of Grid actions, such as sorting, filtering, grouping, and paging. This is especially useful for applications with large datasets, where client-side operations can impact performance.

To implement on-demand server-side actions with a DataTable:

1. Convert the `DataTable` to an **IEnumerable** object.

2. Use the **DataOperations** class in the controller to process Grid actions like sorting, filtering, and paging.

3. Return the result as a JSON object with a **result** (data) and **count** (total record count) pair.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/clientdatatable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dataoperation.cs" %}
{% include code-snippet/grid/data-binding/clientdatatable/dataoperation.cs %}
{% endhighlight %}
{% endtabs %}

## DataTable with CRUD operations

The Syncfusion ASP.NET MVC Grid supports server-side CRUD (Create, Read, Update, Delete) operations using a DataTable as the underlying data source. This feature is particularly useful for applications that require dynamic data management with efficient performance and scalability.

To perform server-side CRUD operations for a DataTable, the **InsertUrl**, **UpdateUrl**, and **RemoveUrl** properties of the **DataManager** must be utilized. These properties allow specifying the controller actions for inserting, updating, and deleting records.

When passing data from the client side to the server side during CRUD operations, use **ExpandoObject** as a parameter for the insert and update actions. This approach allows handling dynamic data structures effectively.

Here’s a sample implementation demonstrating setting up the Grid for CRUD operations with a DataTable:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/cruddatatable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dataoperation.cs" %}
{% include code-snippet/grid/data-binding/cruddatatable/dataoperation.cs %}
{% endhighlight %}
{% endtabs %}

## Prevent local time zone conversion for date columns

By default, the Data Grid automatically converts date values to the local time zone of the client system. However, in some scenarios, it may be necessary to display the original date as received from the server without timezone conversion.

To prevent timezone conversion for date columns, use the `serverTimezoneOffset` property from `DataUtil`. Setting this property to "0" ensures dates remain in the original format received from the server without conversion to the local timezone.

The following example demonstrates preventing local time zone conversion for date columns in the grid using the `DataUtil.serverTimezoneOffset` property:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localtime/razor %}
{% endhighlight %}
{% highlight c# tabtitle="localtime.cs" %}
{% include code-snippet/grid/data-binding/localtime/localtime.cs %}
{% endhighlight %}
{% endtabs %}

![Prevent to convert local time zone format](../images/databinding/local-time.gif)

## Add custom HTTP headers using a custom adaptor

Custom headers in HTTP requests are used to send additional information such as authentication tokens, API keys, or metadata required by the server. These headers improve security and enable better control over data communication. In the Data Grid, custom headers can be added when making API requests, ensuring that each request carries the necessary information for server-side validation and processing.

This method is particularly useful when integrating the grid with authenticated APIs, where requests must include authorization tokens or other security credentials to ensure secure access.

To achieve this, extend the `WebApiAdaptor` to create a custom adaptor. The `beforeSend` method in the custom adaptor enables modification of request headers before sending them to the server, ensuring that every request from the grid includes the required headers.

The following example demonstrates setting custom headers using the custom adaptor in Data Grid. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/custom-headers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="custom-headers.cs" %}
{% include code-snippet/grid/data-binding/custom-headers/custom-headers.cs %}
{% endhighlight %}
{% endtabs %}

![Custom headers using custom adaptor](../images/custom-headers.png)

## Troubleshoot: Syncfusion ASP.NET MVC Grid render rows without data

In ASP.NET MVC, by default the JSON results are returned in camelCase format. So Grid field names are also changed in camelCase.

To avoid this problem, add **DefaultContractResolver** in the **Startup.cs** file.

```javascript
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().AddJsonOptions(options =>
    {
        options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
    });
}
```
