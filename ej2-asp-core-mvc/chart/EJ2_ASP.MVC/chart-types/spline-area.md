---
layout: post
title: Spline Area Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Spline Area Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spline Area Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Spline Area in ##Platform_Name## Charts Component

## Spline Area

To render a [spline area](https://www.syncfusion.com/aspnet-mvc-ui-controls/charts/chart-types/spline-area-chart) series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `Type` as **SplineArea** in your chart configuration. This indicates that the data should be represented as a spline area chart, where data points are connected by smooth, curved lines (splines) instead of straight lines.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/spline-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spline-area.cs" %}
{% include code-snippet/chart/series/spline-area/spline-area/spline-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/spline-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spline-area.cs" %}
{% include code-snippet/chart/series/Spline-area/spline-area/spline-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `DataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `XName` and `YName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/spline-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spline-area.cs" %}
{% include code-snippet/chart/series/spline-area/spline-area/spline-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/spline-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spline-area.cs" %}
{% include code-snippet/chart/series/Spline-area/spline-area/spline-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `spline area` series.

**Fill**

The `Fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/splinearea-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Splinearea-fill.cs" %}
{% include code-snippet/chart/series/spline-area/splinearea-fill/splinearea-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/splinearea-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Splinearea-fill.cs" %}
{% include code-snippet/chart/series/Spline-area/splinearea-fill/splinearea-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `Fill` property can be used to apply a gradient color to the spline area series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/spline-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spline-grad.cs" %}
{% include code-snippet/chart/series/spline-area/spline-grad/spline-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/spline-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spline-grad.cs" %}
{% include code-snippet/chart/series/Spline-area/spline-grad/spline-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `Opacity` property specifies the transparency level of the fill. Adjusting this property allows you to control how opaque or transparent the fill color of the series appears.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/custom-spline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-spline.cs" %}
{% include code-snippet/chart/series/spline-area/custom-spline/custom-spline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/custom-spline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-spline.cs" %}
{% include code-snippet/chart/series/Spline-area/custom-spline/custom-spline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Dash array**

The `DashArray` property determines the pattern of dashes and gaps in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/dash-array/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dash-array.cs" %}
{% include code-snippet/chart/series/spline-area/dash-array/dash-array.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/dash-array/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dash-array.cs" %}
{% include code-snippet/chart/series/Spline-area/dash-array/dash-array.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Empty points

Data points with **null** or **undefined** values are considered empty. Empty data points are ignored and not plotted on the chart.

**Mode**

Use the `Mode` property to define how empty or missing data points are handled in the series. The default mode for empty points is **Gap**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/spline-area/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="empty.cs" %}
{% include code-snippet/chart/series/Spline-area/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `Fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/spline-area/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
 
{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/Spline-area/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/spline-area/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
 
{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/Spline-area/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### Series render

The `SeriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/spline-area/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
 
{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/Spline-area/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `PointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/spline-area/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
 
{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/spline-area/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/Spline-area/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)