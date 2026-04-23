---
layout: post
title: Range Column Chart in ##Platform_Name## Charts
description: Learn here all about Range Column Chart in Syncfusion ##Platform_Name## Charts component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Range Column Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Range Column Chart in ##Platform_Name## Charts

## Range Column

To render a [range column](https://www.syncfusion.com/aspnet-mvc-ui-controls/charts/chart-types/range-column-chart) series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `Type` as **RangeColumn** in your chart configuration. This indicates that the data should be represented as a range column chart, which is ideal for visualizing data that has both minimum and maximum values for each category. This is especially useful for visualizing data ranges, such as temperature fluctuations over time, stock prices, or any other data with upper and lower bounds.

* **Provide high and low values:** The RangeColumn series requires two y-values for each data point, you need to specify both the high and low values. The high value represents the maximum range, while the low value represents the minimum range for each data point. These values define the upper and lower boundaries of the column for each point on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/rangecolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn.cs" %}
{% include code-snippet/chart/series/range-column/rangecolumn/rangecolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/rangecolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn.cs" %}
{% include code-snippet/chart/series/range-column/rangecolumn/rangecolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `DataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `XName`, `High`, and `Low` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/rangecolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn.cs" %}
{% include code-snippet/chart/series/range-column/rangecolumn/rangecolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/rangecolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn.cs" %}
{% include code-snippet/chart/series/range-column/rangecolumn/rangecolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `range column` series.

**Fill**

The `Fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/rangecolumn-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn-fill.cs" %}
{% include code-snippet/chart/series/range-column/rangecolumn-fill/rangecolumn-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/rangecolumn-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn-fill.cs" %}
{% include code-snippet/chart/series/range-column/rangecolumn-fill/rangecolumn-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `Fill` property can be used to apply a gradient color to the range column series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/rangecolumn-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn-grad.cs" %}
{% include code-snippet/chart/series/range-column/rangecolumn-grad/rangecolumn-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/rangecolumn-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn-grad.cs" %}
{% include code-snippet/chart/series/range-column/rangecolumn-grad/rangecolumn-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `Opacity` property controls the transparency of the fill and affects how the series blends with background or overlapping series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/range-column/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/range-column/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to configure the border width, color, and dasharray of the range column series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/range-column/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/range-column/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Empty points

Data points with **null** or **undefined** values are considered empty. Empty data points are ignored and not plotted on the chart.

**Mode**

Use the `Mode` property to control handling of empty points. Available modes: `Gap`, `Drop`, `Zero`, `Average`. The default mode is `Gap`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/range-column/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/range-column/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `Fill` property to set the fill color for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/range-column/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/range-column/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to customize the border width and color for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/range-column/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/range-column/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Corner radius

The [`CornerRadius`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_CornerRadius) property in the chart series is used to customize the corner radius for range column series. This allows you to create range columns with rounded corners, giving your chart a more polished appearance. You can customize each corner of the range columns using the topLeft, topRight, bottomLeft, and bottomRight properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/corner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Corner-radius.cs" %}
{% include code-snippet/chart/series/range-column/corner-radius/corner-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/corner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Corner-radius.cs" %}
{% include code-snippet/chart/series/range-column/corner-radius/corner-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Point corner radius

You can customize the corner radius for individual points in the chart series using the [`PointRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) event by setting the [`CornerRadius`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_CornerRadius) property in its event argument.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/point-corner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-corner-radius.cs" %}
{% include code-snippet/chart/series/range-column/point-corner-radius/point-corner-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/point-corner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-corner-radius.cs" %}
{% include code-snippet/chart/series/range-column/point-corner-radius/point-corner-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Events

### Series render

The `SeriesRender` event enables modification of series properties (for example, data, fill, or name) immediately before rendering. Use this event to adjust series appearance or to dynamically swap data sources.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/range-column/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/range-column/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `PointRender` event provides a hook to customize each data point (for example, marker shape, border, or fill) before it is drawn. Use this to apply per-point styling rules or conditional formatting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/range-column/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/range-column/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/range-column/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)