---
layout: post
title: 100% Stacked Bar Chart in ##Platform_Name## Charts
description: Learn here all about 100% Stacked Bar Chart in Syncfusion ##Platform_Name## Charts component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: 100% Stacked Bar Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# 100% Stacked Bar Chart in ##Platform_Name## Charts

## 100% Stacked Bar

To render a [100% stacked bar](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-types/100-stacked-bar-chart) series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `type` as **StackingBar100** in your chart configuration. This indicates that the data should be represented as a 100% stacked bar chart, with segments that show the percentage contribution of each part.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-bar100.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100/stacked-bar100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-bar100.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100/stacked-bar100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `dataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `xName` and `yName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-bar100.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100/stacked-bar100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-bar100.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100/stacked-bar100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `100% stacked bar` series.

**Fill**

The `fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-bar100-fill.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100-fill/stacked-bar100-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-bar100-fill.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100-fill/stacked-bar100-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `fill` property can be used to apply a gradient color to the 100% stacked bar series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-bar100-grad.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100-grad/stacked-bar100-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-bar100-grad.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stacked-bar100-grad/stacked-bar100-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `opacity` property specifies the transparency level of the fill. Adjusting this property allows you to control how opaque or transparent the fill color of the series appears.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/stacked-bar100/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/stacked-bar100/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `border` property to customize the width, color and dasharray of the series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/stacked-bar100/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/stacked-bar100/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## 100% Cylindrical stacked bar chart

To render a 100% cylindrical stacked bar chart, set the `columnFacet` property to **Cylinder** in the chart series. This property transforms the regular 100% stacked bars into cylindrical shapes, enhancing the visual representation of the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stackedbar100-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar100-cylinder.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stackedbar100-cylinder/stackedbar100-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/stackedbar100-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar100-cylinder.cs" %}
{% include code-snippet/chart/series/stacked-bar100/stackedbar100-cylinder/stackedbar100-cylinder.cs %}
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
{% include code-snippet/chart/series/stacked-bar100/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/stacked-bar100/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/stacked-bar100/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/stacked-bar100/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/stacked-bar100/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/stacked-bar100/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/stacked-bar100/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Corner radius

The [`CornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_CornerRadius) property in the chart series is used to customize the corner radius for 100% stacked bar series. This allows you to create 100% stacked bars with rounded corners, giving your chart a more polished appearance. You can customize each corner of the 100% stacked bars using the topLeft, topRight, bottomLeft, and bottomRight properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/corner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Corner-radius.cs" %}
{% include code-snippet/chart/series/stacked-bar100/corner-radius/corner-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/corner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Corner-radius.cs" %}
{% include code-snippet/chart/series/stacked-bar100/corner-radius/corner-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Point corner radius

We can customize the corner radius for individual points in the chart series using the [`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) event by setting the [`CornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_CornerRadius) property in its event argument.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/point-corner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-corner-radius.cs" %}
{% include code-snippet/chart/series/stacked-bar100/point-corner-radius/point-corner-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/point-corner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-corner-radius.cs" %}
{% include code-snippet/chart/series/stacked-bar100/point-corner-radius/point-corner-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Events

### Series render

The `seriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/stacked-bar100/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/stacked-bar100/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `pointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/stacked-bar100/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-bar100/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/stacked-bar100/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)