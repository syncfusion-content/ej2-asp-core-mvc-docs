---
layout: post
title: Column Chart in ##Platform_Name## Charts
description: Learn here all about Column Chart in Syncfusion ##Platform_Name## Charts component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Column Chart in ##Platform_Name## Charts

## Column

To render a [column series](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-types/column-chart) in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `type` as **Column** in your chart configuration. This indicates that the data should be represented as a column chart, which is ideal for visualizing for comparing different categories of data or tracking changes over time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/series/column-charts/column/column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/series/column-charts/column/column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `dataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `xName` and `yName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/series/column-charts/column/column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/series/column-charts/column/column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `column` series.

**Fill**

The `fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-fill.cs" %}
{% include code-snippet/chart/series/column-charts/column-fill/column-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-fill.cs" %}
{% include code-snippet/chart/series/column-charts/column-fill/column-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `fill` property can be used to apply a gradient color to the column series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-grad.cs" %}
{% include code-snippet/chart/series/column-charts/column-grad/column-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-grad.cs" %}
{% include code-snippet/chart/series/column-charts/column-grad/column-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `opacity` property specifies the transparency level of the fill. Adjusting this property allows you to control how opaque or transparent the fill color of the series appears.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/column-charts/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/column-charts/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `border` property to customize the width, color and dasharray of the series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/column-charts/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/column-charts/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Column space and width

### Column space

Use the `columnSpacing` property in the series to adjust the space between columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-space/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-space.cs" %}
{% include code-snippet/chart/series/column-charts/column-space/column-space.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-space/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-space.cs" %}
{% include code-snippet/chart/series/column-charts/column-space/column-space.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Column width

Use the `columnWidth` property in the series to adjust the width of the columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-width.cs" %}
{% include code-snippet/chart/series/column-charts/column-width/column-width.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-width.cs" %}
{% include code-snippet/chart/series/column-charts/column-width/column-width.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Column width in pixel

Use the `columnWidthInPixel` property in the series to define the exact width of the columns in pixels. This property ensures that each column maintains the specified width, providing a uniform appearance throughout the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-pixel.cs" %}
{% include code-snippet/chart/series/column-charts/column-pixel/column-pixel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-pixel.cs" %}
{% include code-snippet/chart/series/column-charts/column-pixel/column-pixel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Grouped column

Use the `groupName` property to group the data points in column type charts. Data points with the same group name will be grouped together in the chart, making it easy to compare different sets of data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/group-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-column.cs" %}
{% include code-snippet/chart/series/column-charts/group-column/group-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/group-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-column.cs" %}
{% include code-snippet/chart/series/column-charts/group-column/group-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Cylindrical column chart

To render a cylindrical column chart, set the `columnFacet` property to **Cylinder** in the chart series. This property transforms the regular columns into cylindrical shapes, enhancing the visual representation of the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-cylinder.cs" %}
{% include code-snippet/chart/series/column-charts/column-cylinder/column-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-cylinder.cs" %}
{% include code-snippet/chart/series/column-charts/column-cylinder/column-cylinder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Empty points

Data points with **null** or **undefined** values are considered empty. Empty data points are ignored and not plotted on the chart.

**Mode**

Use the `mode` property to define how empty or missing data points are handled in the series. The default mode for empty points is **Gap**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/column-charts/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/column-charts/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/column-charts/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/column-charts/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/column-charts/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/column-charts/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Corner radius

The [`CornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_CornerRadius) property in the chart series is used to customize the corner radius for column series. This allows you to create columns with rounded corners, giving your chart a more polished appearance. You can customize each corner of the columns using the topLeft, topRight, bottomLeft, and bottomRight properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/corner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Corner-radius.cs" %}
{% include code-snippet/chart/series/column-charts/corner-radius/corner-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/corner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Corner-radius.cs" %}
{% include code-snippet/chart/series/column-charts/corner-radius/corner-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Point corner radius

We can customize the corner radius for individual points in the chart series using the [`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) event by setting the [`CornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_CornerRadius) property in its event argument.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/point-corner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-corner-radius.cs" %}
{% include code-snippet/chart/series/column-charts/point-corner-radius/point-corner-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/point-corner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-corner-radius.cs" %}
{% include code-snippet/chart/series/column-charts/point-corner-radius/point-corner-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Events

### Series render

The `seriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/column-charts/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/column-charts/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `pointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/column-charts/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/column-charts/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)