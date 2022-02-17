---
layout: post
title: Column Resizing in ##Platform_Name## Grid Component
description: Learn here all about Column Resizing in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Column Resizing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Resizing

Column width can be resized by clicking and dragging the right edge of the column header. While dragging, the width of the respective column will be resized immediately. Each column can be auto resized by double-clicking the right edge of the column header to fit the width of that column based on the widest cell content. To enable column resize, set the [`allowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowResizing) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/resize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Resize.cs" %}
{% include code-snippet/grid/columns/resize/resize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/resize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resize.cs" %}
{% include code-snippet/grid/columns/resize/resize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable resizing for a particular column by setting the [`allowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowResizing) property of **e-grid-column** tag helper to false.
> In RTL mode, you can click and drag the left edge of the header cell to resize the column.

## Column resizing using method

To resize a column, set width to that particular column and then refresh the grid header by using the **refreshHeader** method. Please refer the below code

```javascript

var grid = document.getElementById('Grid').ej2_instances[0]; //Grid Instance

var columns = grid.columns;

columns[0].width = 150;

grid.refreshHeader();

```

## Min and max width

Column resize can be restricted between minimum and maximum width by defining the [`minWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_MinWidth) and [`maxWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_MaxWidth) properties in  **e-grid-column** tag helper.

In the following sample, minimum and maximum width are defined for **OrderID**, **Ship Name**, and **Ship Country** columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/min/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Min.cs" %}
{% include code-snippet/grid/columns/min/min.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/min/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Min.cs" %}
{% include code-snippet/grid/columns/min/min.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Resize stacked column

Stacked columns can be resized by clicking and dragging the right edge of the stacked column header. While dragging, the width of the respective child columns will be resized at the same time. You can disable resize for any particular stacked column by setting [`allowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowResizing) property **e-grid-column** as **false** to its columns.

In this example, we have disabled resize for **Ship City** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/stacked/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked.cs" %}
{% include code-snippet/grid/columns/stacked/stacked.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/stacked/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked.cs" %}
{% include code-snippet/grid/columns/stacked/stacked.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Touch interaction

When the right edge of the header cell is tapped, a floating handler will be visible over the right border of the column. To resize the column, tap and drag the floating handler as needed. You can autoFit a column by using the Column menu of the grid.

The following screenshot represents the column resizing in touch device.

![Touch interaction](../../images/column-resizing.jpg)

## Resizing events

During the resizing action, the grid component triggers the below three events.

1. The [`resizeStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ResizeStart) event triggers when column resize starts.
2. The [`resizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Resizing) event triggers when column header element is dragged (moved) continuously.
3. The [`resizeStop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ResizeStop) event triggers when column resize ends.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/resizeevents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Resizeevents.cs" %}
{% include code-snippet/grid/columns/resizeevents/resizeevents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/resizeevents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resizeevents.cs" %}
{% include code-snippet/grid/columns/resizeevents/resizeevents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

