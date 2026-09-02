---
layout: post
title: ##Platform_Name## Grid Sorting | Syncfusion
description: Learn ##Platform_Name## Data Grid sorting with single-column, multi-column, custom, foreign-key, culture-aware and programmatic sorting capabilities.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Sorting in ASP.NET MVC Data Grid

The Syncfusion ASP.NET MVC Data Grid provides flexible sorting capabilities that help organize, analyze, and locate information efficiently. Sorting can be applied through column headers or customized to support application-specific ordering requirements.

To enable sorting in the grid, set the  [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property to `true`.

Sorting a particular column is accomplished by clicking on its column header. Each click on the header toggles the sort order between `Ascending` and `Descending`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting.gif)

> * Data Grid column sorted in `Ascending` order. If a click occurs on an already sorted column, the sort direction toggles.
> * Apply and clear sorting by using the `sortColumn` and `clearSorting` methods.
> * To disable sorting for a specific column, set the `Columns.AllowSorting` property to `false`.

## Sort order

By default, the sorting order is "ascending → descending → none".

The first click on a column header sorts the column in ascending order. A second click sorts the column in descending order. A third click clears the sorting.

> The [AllowUnsort](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_AllowUnsort) property controls whether sorting can be cleared. When set to `false`, clicking a grid header will only toggle between ascending and descending order, without switching to an unsorted state. The default value is `true`.

## Initial sorting

The Data Grid component provides an option to apply initial sorting by setting the [SortSettings.Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) property to the desired `Field` and sort `Direction`. This feature is useful for displaying data in a specific order when the grid initially loads.

The following example demonstrates setting [SortSettings.Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) for "Order ID" and "Ship City" columns with a specified `Direction`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/initial-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="initial-sort.cs" %}
{% include code-snippet/grid/sorting/initial-sort/initial-sort.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting-initial-sort.png)

> The initial sorting defined in [SortSettings.Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) will override any sorting applied through individual interaction.

## Multi-column sorting

The Data Grid supports multi-column sorting, allowing records to be ordered using multiple sorting criteria simultaneously. Multi-column sorting makes it possible to establish hierarchical sort priorities, ensuring that records with identical values in one column can be further organized using additional columns.

To enable multi-column sorting, set the [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) and the [AllowMultiSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) properties to `true`. This enables sorting of multiple columns by holding the <kbd>CTRL</kbd> key and clicking the column headers. This feature is useful for datasets that require more than a single sorting dimension.

To clear multi-column sorting for a particular column, press <kbd>Shift</kbd> while clicking the column header.

> * The [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) must be `true` while enabling multi-column sort.
> * Set [AllowMultiSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) property as `false` to disable multi-column sorting.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/multi-column-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="multi-column-sort.cs" %}
{% include code-snippet/grid/sorting/multi-column-sort/multi-column-sort.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting-multiple-sort.png)

## Disable sorting for a specific column

The Data Grid component allows disabling sorting for a column. This is useful when certain columns should not be included in the sorting process.

This is achieved by setting the [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property of the particular column to `false`. The following example demonstrates disabling sorting for "Customer ID" column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-prevent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-prevent/sorting.cs %}
{% endhighlight %}
{% endtabs %}

## Custom sorting

The Data Grid supports custom sorting through the [Column.SortComparer](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_SortComparer) property, providing complete control over how values are ordered within a column.

Custom sorting can be used when the required sort order differs from standard alphabetical or numerical sorting. This is useful for scenarios that require custom rankings, status-based ordering, priority sequencing, locale-aware comparisons, display-value sorting, or specialized handling of null values.

The following example demonstrates defining a custom `SortComparer` function for the "Customer ID" column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-compare/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-compare/sorting.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting-custom.gif)

> The "customSortComparer" function takes two parameters: a and b, which are the values being compared. The function returns "-1", "0", or "1", depending on the comparison result.

### Display null values always at bottom 

By default, "null" values in a Syncfusion Grid are displayed at the top when sorting in descending order and at the bottom when sorting in ascending order. However, "null" values can be configured to always display at the bottom of the grid regardless of sort direction. This is achieved by utilizing the [Column.SortComparer](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_SortComparer)  method. This feature is particularly useful when working with data sets where "null" values might need to be clearly separated from actual data entries.

The example below demonstrates displaying "null" values at the bottom of the grid while sorting the "Order Date" column in both ascending and descending order.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sort-comparer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sort-comparer.cs" %}
{% include code-snippet/grid/sorting/sort-comparer/sort-comparer.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting-null-sort.gif)

## Foreign key sorting

Foreign-key sorting enables sorting based on displayed values rather than the underlying identifier values stored in the data source.

To sort a foreign key column based on its displayed text, the foreign key column can be enabled by using `Column.DataSource`, `Column.ForeignKeyField` and `Column.ForeignKeyValue` properties.

### Sort foreign key column based on text for local data

When working with local data in the grid, sorting is performed based on the  `ForeignKeyValue` defined in the column. This field should be specified in the column definition with the corresponding foreign key value for each row. The grid then sorts the foreign key column according to the text representation of that value.

The following example demonstrates sorting with a foreign key column enabled, where the "Customer ID" column acts as a foreign column displaying the "Contact Name" column from foreign data.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/foreign-sort-local/razor %}
{% endhighlight %}
{% highlight c# tabtitle="foreign-sort" %}
{% include code-snippet/grid/sorting/foreign-sort-local/foreign-sort.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting-local-forign.png)

### Sort foreign key column based on text for remote data

In the case of remote data in the grid, the sorting operation will be performed based on the `ForeignKeyField` property of the column. The `ForeignKeyField` property should be defined in the column definition with the corresponding foreign key field name for each row. The grid will send a request to the server-side with the `ForeignKeyField` name, and the server-side should handle the sorting operation and return the sorted data to the grid.

The following example demonstrates sorting a foreign key column where the "Employee ID column is a foreign key, and the corresponding "First Name column is displayed from the employee data source:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/foreign-sort-remote/razor %}
{% endhighlight %}
{% highlight c# tabtitle="foreign-sort" %}
{% include code-snippet/grid/sorting/foreign-sort-remote/foreign-sort.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sort-remote.gif)

## Culture-based sorting

Culture-based sorting applies locale-specific comparison rules, ensuring accurate sorting behavior for multilingual and internationalized applications.

Culture-specific sorting is achieved by utilizing the [Locale](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Locale) property. By setting the `Locale` property to the desired culture code, sorting is enabled based on that specific culture.

In the following example, sorting is performed based on the "ar" locale using the `Column.SortComparer` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-sort-currency/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-sort-currency/sorting.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/Sorting-culture.png)

## Touch interaction

On touch devices, tapping a grid header sorts that column ![Sorting](images/sorting.jpg). 
For multi‑column sorting, tap the sorting indicator ![Multi Sorting](images/msorting.jpg) and then tap the additional grid headers to include them in the sort order.

> The [AllowMultiSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) and [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) should be `true` then only the popup will be shown.

The following screenshot represents a grid touch sorting in the device.

![Touch Interaction](images/touch-sorting.jpg)

## Programmatic sorting

The Data Grid component in Syncfusion's ASP.NET MVC suite allows customization of column sorting and provides flexibility in sorting based on external interactions. Sort columns, remove a sort column, and clear sorting using an external button click.

### Add sort columns

External column sorting is accomplished using the `sortColumn` method with parameters `columnName`, `direction`, and `isMultiSort`. This method enables programmatic sorting of a specific column based on specified requirements.

The following example demonstrates adding sort columns to a grid. The `DropDownList` component selects the column and sort direction. When an external button is clicked, the `sortColumn` method is called with the specified `columnName`, `direction`, and `isMultiSort` parameters.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-sort-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-sort-column/sorting.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting-add-sort.png)

### Remove sort columns

External removal of sort columns is accomplished using the `removeSortColumn` method provided by the Data Grid component. This method removes the sorting applied to a specific column.

The following example demonstrates removing sort columns. The `DropDownList` component selects the column. When an external button is clicked, the `removeSortColumn` method removes the selected sort column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-sort-remove/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-sort-remove/sorting.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sort-remove-sort.gif)

### Clear sorting 

Sorting is cleared on an external button click using the `clearSorting` method provided by the grid component. This method clears the sorting applied to all columns in the grid. 

The following example demonstrates clearing sorting using the `clearSorting` method in an external button click.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting-sort-clear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sorting.cs" %}
{% include code-snippet/grid/sorting/sorting-sort-clear/sorting.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting-clear.gif)

## Sorting events

The Data Grid component provides two events that are triggered during the sorting action such as [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete). These events can be used to perform any custom actions before and after the sorting action is completed.

1. **ActionBegin**: [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event is triggered before the sorting action begins. It provides a way to perform any necessary operations before the sorting action takes place. This event provides a parameter that contains the current grid state, including the current sorting column, direction, and data.

2. **ActionComplete**: [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event is triggered after the sorting action is completed. It provides a way to perform any necessary operations after the sorting action has taken place. This event provides a parameter that contains the current grid state, including the sorted data and column information.

This example demonstrates that the `ActionBegin` event is used to cancel sorting for the "Order ID" column, while the `ActionComplete` event displays a message after the sorting action finishes.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sort-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sort-event.cs" %}
{% include code-snippet/grid/sorting/sort-event/sort-event.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sorting-events.gif)

> `args.requestType` refers to the current action being performed. For example in sorting, the `args.requestType` value is `sorting`.

## Customizing the sort icon

Sort icon customization in the grid is accomplished by overriding the default grid classes `.e-icon-ascending` and `.e-icon-descending` with custom content using CSS. The desired icons or symbols are specified using the `content` property as shown below:

```css
.e-grid .e-icon-ascending::before {
  content: '\e306';
}
	
.e-grid .e-icon-descending::before {
  content: '\e304';
}
```
The following sample demonstrates a grid rendered with a customized sort icon.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sort-customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sort-custom.cs" %}
{% include code-snippet/grid/sorting/sort-customize/sort-custom.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting](images/sorting/sort-customize-icon.png)

## See Also

* [How to perform own sorting logic in ASP.NET MVC Grid](https://www.syncfusion.com/forums/143523/how-to-perform-own-sorting-logic-in-asp-net-mvc-grid)
