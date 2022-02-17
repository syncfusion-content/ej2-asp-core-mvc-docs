---
layout: post
title: Column Reorder in ##Platform_Name## Grid Component
description: Learn here all about Column Reorder in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Column Reorder
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reorder

Reordering can be done by drag and drop of a particular column header from one index to another index within the grid. To enable reordering, set the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowReordering) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reorder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reorder.cs" %}
{% include code-snippet/grid/columns/reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reorder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reorder.cs" %}
{% include code-snippet/grid/columns/reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable reordering a particular column by setting the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowReordering) property of [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) to false.

## Reorder single column

Grid have option to reorder Columns either by Interaction or by using the **reorderColumns** method. In the below sample, **Name** column is reordered to last column position by using the method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reordercols/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reordercols.cs" %}
{% include code-snippet/grid/columns/reordercols/reordercols.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reordercols/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reordercols.cs" %}
{% include code-snippet/grid/columns/reordercols/reordercols.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Reorder multiple columns

User can reorder a single column at a time by Interaction. Sometimes we need to have reorder multiple columns at the same time, It can be achieved through programmatically by using **reorderColumns** method.

In the below sample, **Ship City** and **Ship Region** column is reordered to last column position.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reordercolumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reordercols.cs" %}
{% include code-snippet/grid/columns/reordercolumns/reordercols.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reordercolumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reordercols.cs" %}
{% include code-snippet/grid/columns/reordercolumns/reordercols.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Reorder events

During the reorder action, the grid component triggers the below three events.

1. The [`ColumnDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDragStart) event triggers when column header element drag (move) starts.
2. The [`ColumnDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDrag) event triggers when column header element is dragged (moved) continuously.
3. The [`ColumnDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDrop) event triggers when a column header element is dropped on the target column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reorderevents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reorderevents.cs" %}
{% include code-snippet/grid/columns/reorderevents/reorderevents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reorderevents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reorderevents.cs" %}
{% include code-snippet/grid/columns/reorderevents/reorderevents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

