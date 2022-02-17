---
layout: post
title: Sorting in ##Platform_Name## Grid Component
description: Learn here all about Sorting in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sorting

Sorting enables you to sort data in the **Ascending** or **Descending** order.
To sort a column, click the column header.

To enable sorting in the Grid, set the [`AllowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) to true. Sorting options can be configured through the [`SortSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/grid/sorting/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/grid/sorting/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Grid columns are sorted in the **Ascending** order. If you click the already sorted column, the sort direction toggles.
> You can apply and clear sorting by invoking **sortColumn** and **clearSorting** methods.
> To disable sorting for a particular column, set the [`AllowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowSorting) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) to false.

## Initial sort

To sort at initial rendering, set the **Field** and
**Direction** in [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) property of [`SortSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/initial-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-sort.cs" %}
{% include code-snippet/grid/sorting/initial-sort/initial-sort.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/initial-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-sort.cs" %}
{% include code-snippet/grid/sorting/initial-sort/initial-sort.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multi-column sorting

You can sort more than one column in a Grid. To sort multiple columns, press and hold the **CTRL** key and click the column header. The sorting order will be displayed in the header while performing multi-column sorting.

To clear sorting for a particular column, press the "Shift + mouse left click".

> The [`AllowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) must be **true** while enabling multi-column sort.
> Set [`AllowMultiSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) property as **false** to disable multi-column sorting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/multi-column-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-column-sort.cs" %}
{% include code-snippet/grid/sorting/multi-column-sort/multi-column-sort.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/multi-column-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-column-sort.cs" %}
{% include code-snippet/grid/sorting/multi-column-sort/multi-column-sort.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sort order

By default, the sorting order will be as **ascending -> descending -> none**.

When first click a column header it sorts the column in ascending. Again click the same column header, it will sort the column in descending. A repetitive third click on the same column header will clear the sorting.

## Sort foreign key column based on Text

For local data in Grid, sorting will be performed based on the [`ForeignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

For remote data in Grid, sorting will be performed based on the [`ForeignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) instead of [`ForeignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue). To sort a column based on the displayed text and not based on the [`ForeignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField), we need to handle the sorting operation at the server side.

The following code example describes the handling of sorting operation at the server side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/foreign-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Foreign-sort.cs" %}
{% include code-snippet/grid/sorting/foreign-sort/foreign-sort.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/foreign-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Foreign-sort.cs" %}
{% include code-snippet/grid/sorting/foreign-sort/foreign-sort.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sorting events

During the sort action, the grid component triggers two events. The [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event triggers before the sort action starts, and the [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event triggers after the sort action is completed. Using these events you can perform the needed actions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sort-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sort-event.cs" %}
{% include code-snippet/grid/sorting/sort-event/sort-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sort-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sort-event.cs" %}
{% include code-snippet/grid/sorting/sort-event/sort-event.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The **args.requestType** is the current action name. For example, in sorting the **args.requestType** is sorting.

## Touch interaction

When you tap the grid header on touchscreen devices, the selected column header is sorted. A popup ![sorting](./images/sorting.jpg) is displayed for multi-column sorting. To sort multiple columns, tap the popup![msorting](./images/msorting.jpg), and then tap the desired grid headers.

> The [`AllowMultiSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) and [`AllowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) should be **true** then only the popup will be shown.

The following screenshot shows grid touch sorting.

![Touch interaction](./images/touch-sorting.jpg)

## See Also

* [How to perform own sorting logic in ASP.NET MVC Grid](https://www.syncfusion.com/forums/143523/how-to-perform-own-sorting-logic-in-asp-net-mvc-grid)