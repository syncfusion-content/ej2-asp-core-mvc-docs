---
layout: post
title: Data Binding in ##Platform_Name## Grid Control | Syncfusion
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data binding in ASP.NET MVC Grid component

Data binding is a fundamental technique that empowers the Syncfusion ASP.NET MVC Grid to integrate data into its interface, enabling the creation of dynamic and interactive Grid views. This feature is particularly valuable when working with large datasets or when data needs to be fetched remotely. 

The Syncfusion ASP.NET MVC Grid utilizes the **DataManager**, which supports both local binding with JavaScript object arrays and remote binding with RESTful JSON data services. The key property, [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource), can be assigned to a **DataManager** instance or a collection of JavaScript object arrays.

It supports following data binding methods:

* List binding
* DataTable binding
* Remote data

## Loading indicator

The Syncfusion ASP.NET MVC Grid offers a loading animation feature, which makes it easy to identify when data is being loaded or refreshed. This feature provides a clear understanding of the Grid current state and actions, such as sorting, filtering, grouping, and more.

To achieve this, you can utilize the `LoadingIndicator.IndicatorType` property of the Syncfusion ASP.NET MVC Grid, which supports two types of indicators:

* Spinner (default indicator)
* Shimmer

The following example demonstrates how to set the `LoadingIndicator.IndicatorType` property based on changing the dropdown value using the [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event of the [DropDownList](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started). The `refreshColumns` method is used to apply the changes and display the updated loading indicator type. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indicator" %}
{% include code-snippet/grid/data-binding/animation/animationcore.cs %}
{% endhighlight %}
{% endtabs %}

![Loading indicator](../images/data-binding/databinding-animation.gif)

## Refresh the datasource using property

Refreshing the data source in a Syncfusion ASP.NET MVC Grid involves updating the data that the Grid displays dynamically. This operation is essential when you need to reflect changes in the underlying data without reloading the entire page or component.

To achieve this, you can make use of the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property in conjunction with the `setProperties` method. This ensures that the Grid reflects the changes in the data source without requiring a complete page or component reload.

For example, if you add or delete data source records, follow these steps:

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
{% include code-snippet/grid/data-binding/databinding-refresh/databindcore.cs %}
{% endhighlight %}
{% endtabs %}

![Refresh the datasource using property](../images/data-binding/databinding-refersh.gif)

## Dynamically change the datasource or columns or both

The Syncfusion ASP.NET MVC Grid allows dynamic modification of the data source, columns, or both . This feature is particularly valuable when you need to refresh the Grid's content and structure without requiring a complete page reload.

To achieve dynamic changes, you can utilize the `changeDataSource` method. This method enables you to update the data source, columns, or both, based on your application's requirements. However, it is important to note that during the changing process for the data source and columns, Grid's existing actions such as sorting, filtering, grouping, aggregation, and searching will be reset.The `changeDataSource` method has two optional arguments: the first argument represents the data source, and the second argument represents the columns. The various uses of the `changeDataSource` method are explained in the following topic.

**1. Change both data source and columns:**

To modify both the existing columns and the data source, you need to pass the both arguments to the `changeDataSource` method. The following example demonstrates how to change both the data source and columns.

You can assign a JavaScript object array to the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property to bind local data to the Grid. The code below provides an example of how to create a data source for the Grid.

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

The following code demonstrates how to create the [Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) for the Grid, which are based on the provided Grid data source.

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

**2. Modify only the existing columns:**

To modify the existing columns in a Grid, you can either add or remove columns or change the entire set of columns using the `changeDataSource` method. To use this method, you should set the first parameter to null and provide the new columns as the second parameter. However, please note that if a column field is not specified in the data source, its corresponding column values will be empty. The following example illustrates how to modify existing columns.

The following code demonstrates how to add new columns with existing Grid columns ('newColumn') by using `changeDataSource` method.

```typescript
    var grid = document.getElementById("grid").ej2_instances[0];
    newColumn1= [
        { field: 'Freight', headerText: 'Freight', textAlign: 'Right', width: 125 },
        { field: 'ShipCity', headerText: 'ShipCity', width: 125 },
    ];
    let column = this.newColumn.push(...this.newColumn1);
    grid.changeDataSource(null, column);
```

**3. Modify only the data source:**

You can change the entire data source in the Syncfusion ASP.NET MVC Grid using the `changeDataSource` method. To use this method, you should provide the data source as the first argument, and  the second argument which is optional can be used to specify new columns for the Grid. If you are not specifying the columns, the Grid will generate the columns automatically based on the data source. The following example demonstrates how to modify the data source.

You can assign a JavaScript object array to the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property to bind local data to the Grid. The code below provides an example of how to create a new data source for the Grid.

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

The following code demonstrates, how to use the `changeDataSource` method to bind the new **employeeData** to the Grid.

```typescript
    var grid = document.getElementById("grid").ej2_instances[0];
    grid.changeDataSource(employeeData);
```

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/databinding-change-datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/grid/data-binding/databinding-change-datasource/databindcore.cs %}
{% endhighlight %}
{% endtabs %}

![Dynamically change the datasource or columns or both](../images/data-binding/change-datsource.gif)

>* The Syncfusion ASP.NET MVC Grid state persistence feature does not support the  `changeDataSource` method.
>* In this document, the above sample uses the local data for `changeDataSource` method. For those using a remote data source, refer to the [FlexibleData](https://ej2.syncfusion.com/aspnetmvc/grid/flexibledata#/fluent2) resource.

## DataTable

The DataTable feature represents a structured table with relational data, equipped with an in-built schema that simplifies working with data column and row objects. This allows for a more intuitive way to manage and display complex data in the Syncfusion ASP.NET MVC Grid.

To bind a DataTable to the Syncfusion ASP.NET MVC Grid, utilize the [dataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. When you bind a DataTable, Grid actions such as Sorting, Filtering, Grouping, and Paging are processed on the client side, enhancing performance and responsiveness.

Here's how to bind a `DataTable` to the Syncfusion ASP.NET MVC Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/datatable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datatable.cs" %}
{% include code-snippet/grid/data-binding/datatable/datatablecore.cs %}
{% endhighlight %}
{% endtabs %}

N> `DataTable` will be supported from .Net Core 2.0. 

### DataTable with on-demand Grid actions

The [On-Demand Grid Actions](#handling-on-demand-grid-actions/) feature in Syncfusion ASP.NET MVC Grid enables server-side processing of Grid actions, such as sorting, filtering, grouping, and paging. This is especially useful for applications with large datasets, where client-side operations can impact performance.

To implement on-demand server-side actions with a DataTable, you need to:

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

To perform server-side CRUD operations for a DataTable, you need to utilize the **InsertUrl**, **UpdateUrl**, and **RemoveUrl** properties of the **DataManager**. These properties allow you to specify the controller actions for inserting, updating, and deleting records.

When passing data from the client side to the server side during CRUD operations, use **ExpandoObject** as a parameter for the insert and update actions. This approach allows you to handle dynamic data structures effectively.

Here’s a sample implementation demonstrating how to set up the Syncfusion ASP.NET MVC Grid for CRUD operations with a DataTable:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/cruddatatable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dataoperation.cs" %}
{% include code-snippet/grid/data-binding/cruddatatable/dataoperation.cs %}
{% endhighlight %}
{% endtabs %}

## Troubleshoot: Syncfusion ASP.NET MVC Grid render rows without data

In ASP.NET MVC, by default the JSON results are returned in camelCase format. So Grid field names are also changed in camelCase.

To avoid this problem, you need to add **DefaultContractResolver** in **Startup.cs** file.

```javascript
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().AddJsonOptions(options =>
    {
        options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
    });
}
```        }
```
