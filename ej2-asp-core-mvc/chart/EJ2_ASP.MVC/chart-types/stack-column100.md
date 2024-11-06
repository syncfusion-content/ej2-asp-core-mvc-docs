---
layout: post
title: 100% Stacked Column Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about 100% Stacked Column Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: 100% Stacked column chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# 100% Stacked Column in ##Platform_Name## Charts Component

## 100% Stacked column

To render a [100% stacked column](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-types/100-stacked-column-chart) series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `Type` as **StackingColumn100** in your chart configuration. This indicates that the data should be represented as a 100% stacked column chart, with segments that show the percentage contribution of each part.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column100.cs" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100/stacked-column100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column100.cs" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100/stacked-column100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `DataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `XName` and `YName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column100.cs" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100/stacked-column100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column100.cs" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100/stacked-column100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `100% stacked column` series.

**Fill**

The `Fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column100-fill.cs" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100-fill/stacked-column100-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column100-fill.cs" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100-fill/stacked-column100-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `Fill` property can be used to apply a gradient color to the 100% stacked column series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column100-grad.cs" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100-grad/stacked-column100-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column100-grad.cs" %}
{% include code-snippet/chart/series/stacked-column100/stacked-column100-grad/stacked-column100-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `Opacity` property specifies the transparency level of the fill. Adjusting this property allows you to control how opaque or transparent the fill color of the series appears.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/stacked-column100/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/stacked-column100/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Dash array**

The `DashArray` property determines the pattern of dashes and gaps in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/dash-array/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dash-array.cs" %}
{% include code-snippet/chart/series/stacked-column100/dash-array/dash-array.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/dash-array/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dash-array.cs" %}
{% include code-snippet/chart/series/stacked-column100/dash-array/dash-array.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to customize the width and color of the series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/stacked-column100/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/stacked-column100/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## 100% Cylindrical stacked column chart

To render a 100% cylindrical stacked column chart, set the `ColumnFacet` property to **Cylinder** in the chart series. This property transforms the regular 100% stacked columns into cylindrical shapes, enhancing the visual representation of the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stackedcolumn100-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn100-cylinder.cs" %}
{% include code-snippet/chart/series/stacked-column100/stackedcolumn100-cylinder/stackedcolumn100-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/stackedcolumn100-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn100-cylinder.cs" %}
{% include code-snippet/chart/series/stacked-column100/stackedcolumn100-cylinder/stackedcolumn100-cylinder.cs %}
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
{% include code-snippet/chart/series/stacked-column100/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/stacked-column100/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/stacked-column100/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `Fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/stacked-column100/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/stacked-column100/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/stacked-column100/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/stacked-column100/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### Series render

The `SeriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/stacked-column100/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/stacked-column100/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `PointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/stacked-column100/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column100/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/stacked-column100/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [Data Label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)