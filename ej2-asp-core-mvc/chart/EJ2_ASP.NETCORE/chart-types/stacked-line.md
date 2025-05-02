---
layout: post
title: Stacked Line Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Stacked Line Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stacked Line Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stacked line Chart in ##Platform_Name## Charts Component

## Stacked line

To render a [stacked line](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-types/stacked-line-chart) series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `type` as **StackingLine** in your chart configuration. This indicates that the data should be represented as a stacked line chart, allowing multiple data series to be stacked on top of each other. This makes it easier to compare the contribution of each series to the total over a specific period.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `dataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `xName` and `yName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `stacked line` series.

**Fill**

The `fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-fill.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-fill/stacked-line-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-fill.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-fill/stacked-line-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `fill` property can be used to apply a gradient color to the stacked line series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-grad.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-grad/stacked-line-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-grad.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-grad/stacked-line-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `opacity` property specifies the transparency level of the fill. Adjusting this property allows you to control how opaque or transparent the fill color of the series appears.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-opacity.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-opacity/stacked-line-opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-opacity.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line-opacity/stacked-line-opacity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Dash array**

The `dashArray` property determines the pattern of dashes and gaps in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/dash-array/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dash-array.cs" %}
{% include code-snippet/chart/series/stacked-line/dash-array/dash-array.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/dash-array/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dash-array.cs" %}
{% include code-snippet/chart/series/stacked-line/dash-array/dash-array.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Width**

The `width` property specifies the stroke width applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Width.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Width.cs" %}
{% include code-snippet/chart/series/stacked-line/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Empty points

Data points with **null** or **undefined** values are considered empty. Empty data points are ignored and not plotted on the chart.

**Mode**

Use the `mode` property to define how empty or missing data points are handled in the series. The default mode for empty points is Gap.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/stacked-line/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/stacked-line/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/stacked-line/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/stacked-line/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/stacked-line/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/stacked-line/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stack labels

The stack labels in stacked charts display cumulative total values for stack segments directly using data labels. If a stacked point has negative values, the stack labels are displayed below the point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stack-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stack-labels.cs" %}
{% include code-snippet/chart/series/stacked-line/stack-labels/stack-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stack-labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stack-labels.cs" %}
{% include code-snippet/chart/series/stacked-line/stack-labels/stack-labels.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Stack labels customization

Stack labels have various properties for customization to enhance the visual based on your requirements:

* [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Visible) - Specifies whether stack labels are visible. Setting to true will display the labels. Default is false.
* [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Fill) - Defines the background color of the stack labels. Accepts valid CSS color strings (hex, RGBA, etc.). Default is transparent.
* [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Format) - Formats the text displayed in the stack labels. Supports placeholders like {value}. Default is null.
* [`Angle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Angle) - Specifies the rotation angle for stack labels in degrees. Default is 0.
* [`Rx`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Rx) - Defines the rounded corner radius along the X-axis (horizontal direction) for the stack label background. Default is 5.
* [`Ry`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Ry) - Defines the rounded corner radius along the Y-axis (vertical direction) for the stack label background. Default is 5.
* [`Margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Margin) - Configures the margin around the stack label (left, right, top, and bottom).
* [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Border) - Configures the appearance of the stack label's border.
* [`Font`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Font) - Customizes the stack label text, including font size, color, style, weight, and family.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stack-labels-cus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stack-labels-cus.cs" %}
{% include code-snippet/chart/series/stacked-line/stack-labels-cus/stack-labels-cus.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/stack-labels-cus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stack-labels-cus.cs" %}
{% include code-snippet/chart/series/stacked-line/stack-labels-cus/stack-labels-cus.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Events

### Series render

The `seriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/stacked-line/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/stacked-line/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `pointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/stacked-line/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-line/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/stacked-line/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)