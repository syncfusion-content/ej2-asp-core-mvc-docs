---
layout: post
title: Sorting in ##Platform_Name## Grid Component
description: Learn here all about Sorting in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Sorting in ASP.NET Core Grid component

The Grid component provides built-in support for sorting data-bound columns in ascending or descending order. To enable sorting in the grid, set the [allowSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property to **true**.

To sort a particular column in the grid, click on its column header. Each time you click the header, the order of the column will switch between **Ascending** and **Descending**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}

> * Grid column sorted in **Ascending** order. If you click on an already sorted column, then toggles the sort direction.
> * You can apply and clear sorting by using the `sortColumn` and `clearSorting` methods.
> * To disable sorting for a specific column, set the `columns.allowSorting` property to **false**.

## Initial sorting

By default, the grid component does not apply any sorting to its records at initial rendering. However, you can apply initial sorting by setting the [sortSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) property to the desired `field` and sort `direction`. This feature is helpful when you want to display your data in a specific order when the grid is first loaded.

The following example demonstrates how to set [sortSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) for **OrderID** and **ShipCity** columns with a specified `direction`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/initial-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="initial-sort.cs" %}
{% include code-snippet/grid/sorting/initial-sort/initial-sort.cs %}
{% endhighlight %}
{% endtabs %}


> The initial sorting defined in [sortSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) will override any sorting applied through individual interaction.

## Multi-column sorting

The Grid component allows to sort more than one column at a time using multi-column sorting. To enable multi-column sorting in the grid, set the [allowSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property to **true**, and set the [allowMultiSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) property to **true** which enable the user to sort multiple columns by hold the **CTRL** key and click on the column headers. This feature is useful when you want to sort your data based on multiple criteria to analyze it in various ways.

To clear multi-column sorting for a particular column, press the "Shift + mouse left click".


> * The [allowSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) must be true while enabling multi-column sort.
> * Set [allowMultiSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) property as **false** to disable multi-column sorting.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/multi-column-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="multi-column-sort.cs" %}
{% include code-snippet/grid/sorting/multi-column-sort/multi-column-sort.cs %}
{% endhighlight %}
{% endtabs %}

## Prevent sorting for particular column

The Grid component provides the ability to prevent sorting for a particular column. This can be useful when you have certain columns that you do not want to be included in the sorting process. 

It can be achieved by setting the [allowSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property of the particular column to **false**. 

The following example demonstrates, how to disable sorting for **CustomerID** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-prevent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/gridsorting/sorting-prevent/sorting.cs %}
{% endhighlight %}
{% endtabs %}

## Sort order

By default, the sorting order will be as **ascending -> descending -> none**.

When you click on a column header for the first time, it sorts the column in ascending order. Clicking the same column header again will sort the column in descending order. A repetitive third click on the same column header will clear the sorting.

## Custom sorting 

The Grid component provides a way to customize the default sort action for a column by defining the `column.sortComparer` property. The sort comparer function works similar to the `Array.sort` comparer function, and allows to define custom sorting logic for a specific column.

The following example demonstrates how to define custom sort comparer function for the **Customer ID** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-compare/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-compare/sorting.cs %}
{% endhighlight %}
{% endtabs %}

### Display null values always at bottom 

By default, null values in a Syncfusion Grid are displayed at the top when sorting in descending order and at the bottom when sorting in ascending order. However, there may be scenarios where you want to always display null values at the bottom of the grid regardless of the sort direction. This can be achieved by utilizing the `column.sortComparer`  method. This feature is particularly useful when working with data sets where null values might need to be clearly separated from actual data entries.

The example below demonstrates how to display null values at the bottom of the grid while sorting the **OrderDate** column in both ascending and descending order.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="print.cs" %}
{% include code-snippet/grid/sorting/print/print.cs %}
{% endhighlight %}
{% endtabs %}

> The customSortComparer function takes two parameters: a and b. The a and b parameters are the values to be compared. The function returns -1, 0, or 1, depending on the comparison result.

## Touch interaction

When you tap grid header on touch screen devices, then the selected column header is sorted and display a popup ![Sorting](../images/sorting.jpg) for multi-column sorting, tap on the popup to sort multiple columns ![Multi Sorting](../images/msorting.jpg) and then tap the desired grid headers.

> The [allowMultiSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) and [allowSorting](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) should be **true** then only the popup will be shown.

![Touch Interaction](../images/touch-sorting.jpg)

## Sort foreign key column based on text

To perform sorting based on foreign key column, the foreign key column can be enabled by using `column.dataSource`, `column.foreignKeyField` and `column.foreignKeyValue` properties.

**Sort foreign key column based on text for local data**

In the case of local data in the grid, the sorting operation will be performed based on the `foreignKeyValue` property of the column. The `foreignKeyValue` property should be defined in the column definition with the corresponding foreign key value for each row. The grid will sort the foreign key column based on the text representation of the `foreignKeyValue` property.

The following example demonstrates how to perform sorting by enabling a foreign key column, where the **CustomerID** column acts as a foreign column displaying the **ContactName** column from foreign data.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/foreign-sort-local/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="foreign-sort" %}
{% include code-snippet/grid/sorting/foreign-sort-local/foreign-sort %}
{% endhighlight %}
{% endtabs %}

> Make sure to inject the **ForeignKey** module in the **provide** section to ensure its availability throughout your application.

**Sort foreign key column based on text for remote data**

In the case of remote data in the grid, the sorting operation will be performed based on the `foreignKeyField` property of the column. The `foreignKeyField` property should be defined in the column definition with the corresponding foreign key field name for each row. The grid will send a request to the server-side with the `foreignKeyField` name, and the server-side should handle the sorting operation and return the sorted data to the grid.

## Perform sorting based on its culture

Perform sorting based on culture in the Grid can be achieved by utilizing the [locale](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Locale) property. By setting the `locale` property to the desired culture code, you enable sorting based on that specific culture. This allows you to apply locale-specific sorting rules and ensure accurate ordering for different languages and regions.

In the following example, sorting is performed based on the **"ar"** locale using the `Column.sortComparer` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-sort-currency/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-sort-currency/sorting.cs %}
{% endhighlight %}
{% endtabs %}

## How to customize sort icon

To customize the sort icon in the Grid, you can override the default grid classes **.e-icon-ascending** and **.e-icon-descending** with custom content using CSS. Simply specify the desired icons or symbols using the **content** property as mentioned below

```css
.e-grid .e-icon-ascending::before {
  content: '\e306';
}
    
.e-grid .e-icon-descending::before {
  content: '\e304';
}
```
In the below sample, grid is rendered with a customized sort icon.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sort-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sort-custom.cs" %}
{% include code-snippet/grid/sorting/sort-customize/sort-custom.cs %}
{% endhighlight %}
{% endtabs %}

## Sort columns externally

The Grid component in Syncfusion's ASP.NET Core suite allows you to customize the sorting of columns and provides flexibility in sorting based on external interactions. You can sort columns, remove a sort column, and clear sorting using an external button click.

### Add sort columns

To sort a column externally, you can utilize the `sortColumn` method with parameters **columnName**, **direction** and **isMultiSort** provided by the Grid component. This method allows you to programmatically sort a specific column based on your requirements.

The following example demonstrates how to add sort columns to a grid. It utilizes the **DropDownList** component to select the column and sort direction. When an external button is clicked, the `sortColumn` method is called with the specified **columnName**, **direction**, and **isMultiSort** parameters.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-sort-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-sort-column/sorting.cs %}
{% endhighlight %}
{% endtabs %}

### Remove sort columns

To remove a sort column externally, you can use the `removeSortColumn` method provided by the Grid component. This method allows you to remove the sorting applied to a specific column.

The following example demonstrates how to remove sort columns. It utilizes the **DropDownList** component to select the column. When an external button is clicked, the `removeSortColumn` method is called to remove the selected sort column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-sort-remove/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-sort-remove/sorting.cs %}
{% endhighlight %}
{% endtabs %}

### Clear sorting 

To clear the sorting on an external button click, you can use the `clearSorting` method provided by the Grid component. This method clears the sorting applied to all columns in the grid. 

The following example demonstrates how to clear the sorting using `clearSorting` method in the external button click.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-sort-clear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-sort-clear/sorting.cs %}
{% endhighlight %}
{% endtabs %}

## Sorting events

The Grid component provides two events that are triggered during the sorting action such as [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete). These events can be used to perform any custom actions before and after the sorting action is completed.

1. **actionBegin**: [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event is triggered before the sorting action begins. It provides a way to perform any necessary operations before the sorting action takes place. This event provides a parameter that contains the current grid state, including the current sorting column, direction, and data.

2. **actionComplete**: [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event is triggered after the sorting action is completed. It provides a way to perform any necessary operations after the sorting action has taken place. This event provides a parameter that contains the current grid state, including the sorted data and column information.

The following example demonstrates how the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) events work when sorting is performed. The `actionBegin` event event is used to cancel the sorting of the OrderID column. The `actionComplete` event is used to display a message.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sort-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="sort-event.cs" %}
{% include code-snippet/grid/sorting/sort-event/sort-event.cs %}
{% endhighlight %}
{% endtabs %}

> `args.requestType` refers to the current action being performed. For example in sorting, the `args.requestType` value is **sorting**.

