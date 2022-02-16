---
layout: post
title: Frozen in ##Platform_Name## Grid Component
description: Learn here all about Frozen in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Frozen
publishingplatform: ##Platform_Name##
documentation: ug
---


# Frozen rows and columns

Frozen rows and columns provides an option to make rows and columns always visible in the top and left side of the grid while scrolling.

In this demo, the [`frozenColumns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_FrozenColumns) is set as '2' and the [`frozenRows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_FrozenRows)
is set as '3'. Hence, the left two columns and top three rows are frozen.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/freeze-row-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-row-column.cs" %}
{% include code-snippet/grid/scrolling/freeze-row-column/freeze-row-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/freeze-row-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-row-column.cs" %}
{% include code-snippet/grid/scrolling/freeze-row-column/freeze-row-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Frozen rows and columns should not be set outside the grid view port.
> Frozen Grid will support row and column virtualization feature, which helps to improve the Grid performance while loading a large dataset.

## Limitations of Frozen Grid

The following features are not supported in frozen rows and columns:

* Grouping
* Row Template
* Detail Template
* Hierarchy Grid

## Freeze particular columns

To freeze particular column in the grid, the [`isFrozen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsFrozen) property of **e-grid-column** tag helper can be used.

In this demo, the columns with field name **OrderID** and **EmployeeID** is frozen using
the [`isFrozen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsFrozen) property of **e-grid-column**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/freeze-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-column.cs" %}
{% include code-snippet/grid/scrolling/freeze-column/freeze-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/freeze-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-column.cs" %}
{% include code-snippet/grid/scrolling/freeze-column/freeze-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * [`isFrozen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsFrozen) is not compatible with the Freeze direction feature.

## Freeze Direction

You can freeze the Grid columns on the left or right side by using the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Freeze) property and the remaining columns will be movable. The grid will automatically move the columns to the left or right position based on the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Freeze) value.

Types of the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Freeze) directions:

* **`Left`**: Allows you to freeze the columns at the left.
* **`Right`**: Allows you to freeze the columns at the right.

In this demo, the **ShipCountry** column is frozen at the left and the **CustomerID** column is frozen at the right side of the content table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/column-level-frozen/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-column.cs" %}
{% include code-snippet/grid/scrolling/column-level-frozen/freeze-column.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-column.cs" %}
{% include code-snippet/grid/scrolling/column-level-frozen/freeze-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/column-level-frozen/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-column.cs" %}
{% include code-snippet/grid/scrolling/column-level-frozen/freeze-column.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-column.cs" %}
{% include code-snippet/grid/scrolling/column-level-frozen/freeze-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * Freeze Direction is not compatible with the `isFrozen` and `frozenColumns` properties.

## Limitations of Freeze Direction

This feature has the below limitations, along with the above mentioned Frozen Grid limitations.

* Column virtualization
* Infinite scroll cache mode
* Freeze direction in the stacked header is not compatible with column reordering.
