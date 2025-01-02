---
layout: post
title: Column Rendering in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Column Rendering in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Rendering
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column rendering in ASP.NET Core Grid component

In Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid, column rendering provides you with the ability to finely control how data is presented. This allows you to manually define columns, automatically generate them, and dynamically customize data presentation. With column rendering, you can ensure that your data is displayed exactly as needed, offering a wide range of possibilities for organizing and showcasing information within the grid.

The column definitions are used as the DataSource schema in the grid. The grid operations such as sorting, filtering and grouping etc. are performed based on column definitions. The `field` property of grid column is necessary to map the datasource values in the grid columns.

> 1. If the column `field` is not specified in the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_DataSource), column values will be empty.
> 2. If the `field` name contains **dot** operator, it is considered as complex binding.
> 3. It is must to define the `field` property for a Template column, to perform CRUD or data Operations such as filtering, searching etc.

## Define columns manually 

To define columns manually in grid, you can use the `e-grid-columns` element to define the columns and represent each column with its respective properties such as `field`, `headerText`, `type`, and [width](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Width) set accordingly. This allows you to customize the column's behavior and appearance based on the requirements.

Here's an example code snippet that demonstrates how to define columns manually in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-rendering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-rendering.cs" %}
{% include code-snippet/grid/columns/column-rendering/column-rendering.cs %}
{% endhighlight %}
{% endtabs %}

![Define columns](../images/column-rendering/column-render.png)

## Auto generated columns

The Grid automatically generates columns when the `columns` declaration is empty or undefined while initializing the grid. All the columns in the **dataSource** are bound as grid columns.

You can use the following code snippet to enable auto-generated columns in the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/auto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto.cs" %}
{% include code-snippet/grid/columns/auto/auto.cs %}
{% endhighlight %}
{% endtabs %}

>* When the columns are auto-generated, the column `type` is determined from the first record of the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_DataSource).
>* If you have a large dataset, auto-generating columns can result in performance issues. In this case, it is recommended to specify the columns manually in the columns property during initialization or else use column virtualization feature by setting [enableColumnVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_EnableColumnVirtualization) property value as **true**.

### Set isPrimaryKey for auto generated columns when editing is enabled

When editing is enabled in the grid, you may need to set a primary key for auto-generated columns to uniquely identify each row for operations such as updating or deleting data. This can be achieved using the `isPrimaryKey` property of the column object by using the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event.

By setting `isPrimaryKey` to **true** for an auto-generated column in the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid, you can specify it as the primary key column, which uniquely identifies each row when editing is enabled.

Here is an example code snippet that shows how to set a primary key for an auto-generated column when editing is enabled:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/auto-primary/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Primary.cs" %}
{% include code-snippet/grid/columns/auto-primary/primary.cs %}
{% endhighlight %}
{% endtabs %}

If the column `field` name is known, the `getColumnByField` method can be used to retrieve the column object. Then, the `isPrimaryKey` property can be set to **true** for that column, as demonstrated in the code snippet below:

```typescript
onDataBound: function() {
    let grid = document.getElementById('Grid').ej2_instances[0];
    let column= grid.getColumnByField('OrderID');
    column.isPrimaryKey = true;
  }
```

### Set column options to auto generated columns

To configure column options such as `type`, `format` and [width](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Width) for auto-generated columns in Syncfusion<sup style="font-size:70%">&reg;</sup> Grid, you can use the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the Grid component. This event is triggered after the data has been bound to the Grid. By handling this event, you can specify the desired column options for the auto-generated columns.

Here's an example of how you can set column options for auto-generated columns using the `dataBound` event:

In the below example, `width` is set for **OrderID** column, **date** `type` is set for **OrderDate** column and `format` is set for **Freight** and **OrderDate** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autocolumnformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autocolumnformat.cs" %}
{% include code-snippet/grid/columns/autocolumnformat/autocolumnformat.cs %}
{% endhighlight %}
{% endtabs %}

## Dynamic column generation 

The Syncfusion<sup style="font-size:70%">&reg;</sup> Grid component allows you to dynamically generate columns at runtime, based on the data provided. This feature is useful when you need to display data with varying columns based on user requirements or dynamic data sources.

### Using valueAccessor property

Dynamic column generation using value accessor allows you to access and manipulate the display data values in a grid column. By using the `valueAccessor` property of a grid column, you can customize the display value of the column based on the data.

To use `valueAccessor` property, define the column with the property and provide a function that will return the formatted value. The function receives two arguments:
* **field**: represents the data field of the column.
* **data**: represents the data record for the corresponding row.

In the provided code, the **currencyFormatter** function takes the Freight value of the data object, appends the Euro symbol to it, and returns the formatted string. The **concatenateFields** function concatenates the ShipCity and ShipRegion values of the data object and returns the combined string.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-render-valueaccessor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Valueaccessor.cs" %}
{% include code-snippet/grid/columns/column-render-valueaccessor/valueaccessor.cs %}
{% endhighlight %}
{% endtabs %}

![Using valueAccessor property](../images/column-rendering/column-render-valueaccessor.png)

> The `valueAccessor` function can have performance implications if it is used to access a large number of data records or to perform complex data manipulations. To avoid performance issues, you can enable the virtualization feature while using the `valueAccessor` property. This ensures that only the visible rows are rendered, resulting in faster rendering times.

### Display array type columns

The Grid component allows you to easily bind an array of objects to a column using the `valueAccessor` property. This property allows customization of how the data is displayed in the column.

For example, consider a column named **Name** that contains an array of two objects, **FirstName** and **LastName**.  The `valueAccessor` property can be used to join these two objects and bind them to the column.

This will display the concatenated value of **FirstName** and **LastName** in the **Full Name** column of the grid. Here's an example of how this can be achieved:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-render-array/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arraytypecolumns.cs" %}
{% include code-snippet/grid/columns/column-render-array/arraytypecolumns.cs %}
{% endhighlight %}
{% endtabs %}

![Display array type columns](../images/column-rendering/column-render-array.png)

### Expression column

You can achieve an expression column in the Grid by using the `valueAccessor` property. The `valueAccessor` property allows you to define a function that calculates the value for the expression column based on the values of other columns.

In this example, we have a grid with columns **Food Name**, **Protein**, **Fat**, and **Carbohydrate**. We want to add an expression column called **Calories Intake** that calculates the total calories for each row based on the values of **Protein**, **Fat**, and **Carbohydrate** columns.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-render-expression/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Expressioncolumn.cs" %}
{% include code-snippet/grid/columns/column-render-expression/expressioncolumn.cs %}
{% endhighlight %}
{% endtabs %}

![Expression column](../images/column-rendering/column-render-expression.png)

### Display serial number

To display serial number in the grid for every rows, you can use the [rowDataBound](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event. The `rowDataBound` event is triggered for each row in the grid when the data is bound to the grid.

Within the event handler, the [pagesize](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize) and [currentPage](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_CurrentPage) index can be obtained from the grid's [pageSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html) property. Using these values, the serial number can be calculated based on the page size, current page, and row index. Finally, the calculated serial number can be set as the innerHTML of the corresponding row cell.

Here is an example code snippet that demonstrates how to display serial numbers in a Syncfusion<sup style="font-size:70%">&reg;</sup> Grid using `rowDataBound` event:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-render-serial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Serialnumber.cs" %}
{% include code-snippet/grid/columns/column-render-serial/serialnumber.cs %}
{% endhighlight %}
{% endtabs %}

![Display serial number](../images/column-rendering/column-render-serial.png)

## Complex data binding

The Syncfusion<sup style="font-size:70%">&reg;</sup> Grid component allows you to achieve complex data binding by using the dot (.) operator in the `column.field`. This feature is particularly useful when dealing with nested or complex data structures.

### Using local data

To enable complex data binding in the Grid component using local data, use the dot (.) operator in the `field` property of the column. Here is an example of how to achieve complex data binding using local data:

In the below example, we have bound the nested **Employee** object's **FirstName** and **LastName** properties using the dot (.) operator.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/complexbinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/grid/columns/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}

![Using local data](../images/column-rendering/local-data.png)

### Using remote data

To enable complex data binding in the Grid component using remote data, add the `expand` query to the [query](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property of the Grid, to eager load the complex data. Here is an example of how to achieve complex data binding using remote data:

In the below example, we have used the `expand` query to load the nested Employee object's **City** property using the dot (.) operator.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-render-remote/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/grid/columns/column-render-remote/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

![Using remote data](../images/column-rendering/column-render-remote.png)

### Complex data binding with list of array of objects

The Syncfusion Grid supports complex data binding with lists of arrays of objects. This feature allows you to bind complex data with multiple levels of nested objects and arrays to the Grid.

The following example shows how to set complex field for datasource having array of objects.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-complexbinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/grid/columns/column-complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}

![Complex data binding with list of array of objects](../images/column-rendering/column-complex.png)

### How to set complex column as foreign key column

The Syncfusion Grid control provides the ability to set complex columns as foreign key columns. This allows you to display related data from a foreign data source based on the complex column value.

The following example demonstrates how to set the **Employee.EmployeeID** column as a foreign key column, and display the **FirstName** column from the foreign data.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreignkey/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Foreignkey.cs" %}
{% include code-snippet/grid/columns/foreignkey/foreignkey.cs %}
{% endhighlight %}
{% endtabs %}

![Complex data binding with list of array of objects](../images/column-rendering/column-foriegn-complex.png)
