---
layout: post
title: Pareto Chart in ##Platform_Name## Charts
description: Learn here all about Pareto Chart in Syncfusion ##Platform_Name## Charts component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pareto Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pareto Chart in ##Platform_Name## Charts

## Pareto

Pareto charts are used to find the cumulative values of data in different categories. It is a combination of **Column** and **Line** series, where the initial values are represented by the column chart and the cumulative values are represented by the line chart.

To render a **pareto** series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

**Set the series type:** Define the series `Type` as **Pareto** in your chart configuration. This indicates that the data should be represented as a pareto chart, will use a combination of column and line series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/pareto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto.cs" %}
{% include code-snippet/chart/series/pareto/pareto/pareto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/pareto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto.cs" %}
{% include code-snippet/chart/series/pareto/pareto/pareto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `DataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `XName` and `YName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/pareto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto.cs" %}
{% include code-snippet/chart/series/pareto/pareto/pareto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/pareto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto.cs" %}
{% include code-snippet/chart/series/pareto/pareto/pareto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Pareto customization

## Fill

Use the `Fill` property to apply a color to the pareto line. By default, a color based on the theme is used.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/pareto-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto-fill.cs" %}
{% include code-snippet/chart/series/pareto/pareto-fill/pareto-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/pareto-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto-fill.cs" %}
{% include code-snippet/chart/series/pareto/pareto-fill/pareto-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Width

Use the `Width` property to control the thickness of the line for the pareto series, which affects its visual weight on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/pareto-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto-width.cs" %}
{% include code-snippet/chart/series/pareto/pareto-width/pareto-width.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/pareto-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto-width.cs" %}
{% include code-snippet/chart/series/pareto/pareto-width/pareto-width.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Dash array

The `DashArray` property determines the pattern of dashes and gaps in the pareto line series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/dasharray/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dasharray.cs" %}
{% include code-snippet/chart/series/pareto/dasharray/dasharray.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/dasharray/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dasharray.cs" %}
{% include code-snippet/chart/series/pareto/dasharray/dasharray.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Marker

Use the `Marker` property to display and customize markers for individual points in a pareto line.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker.cs" %}
{% include code-snippet/chart/series/pareto/marker/marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker.cs" %}
{% include code-snippet/chart/series/pareto/marker/marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Show axis

Use the `ShowAxis` property to show or hide the secondary axis for the pareto series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/showaxis/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Showaxis.cs" %}
{% include code-snippet/chart/series/pareto/showaxis/showaxis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/showaxis/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Showaxis.cs" %}
{% include code-snippet/chart/series/pareto/showaxis/showaxis.cs %}
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
{% include code-snippet/chart/series/pareto/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/pareto/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/pareto/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `Fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/pareto/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/pareto/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/pareto/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/pareto/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

##Events

### Series render

The `SeriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/pareto/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/pareto/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `PointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/pareto/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/pareto/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/pareto/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)