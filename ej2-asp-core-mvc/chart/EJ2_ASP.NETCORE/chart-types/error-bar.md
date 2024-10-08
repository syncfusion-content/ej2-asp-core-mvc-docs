---
layout: post
title: Error Bar Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Error Bar Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Error Bar Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Error Bar in ##Platform_Name## Charts Component

## Error Bar

Error bars are graphical representations of the variability of data and are used on graphs to indicate the error or uncertainty in a reported measurement.

To render error bars for the series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

**Set visibility:** Set the visible property to true for the error bars to be displayed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/errorbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbar.cs" %}
{% include code-snippet/chart/series/error-bar/errorbar/errorbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/errorbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbar.cs" %}
{% include code-snippet/chart/series/error-bar/errorbar/errorbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customizing error bar

To customize the error bar type, set the error bar `type` to **Custom**, and then change the horizontal or vertical positive and negative error values for the error bar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/errorbar-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbar-custom.cs" %}
{% include code-snippet/chart/series/error-bar/errorbar-custom/errorbar-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/errorbar-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbar-custom.cs" %}
{% include code-snippet/chart/series/error-bar/errorbar-custom/errorbar-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Error bar mode

The error bar mode is used to define whether the error bar line is drawn horizontally, vertically or on both sides. To change the error bar mode, use the `mode` option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mode.cs" %}
{% include code-snippet/chart/series/error-bar/mode/mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mode.cs" %}
{% include code-snippet/chart/series/error-bar/mode/mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %} 

## Error bar direction

To change the direction of the error bars to plus, minus, or both sides, use the `direction` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/direction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/chart/series/error-bar/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/direction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/chart/series/error-bar/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customizing error bar cap

To customize the length, width, opacity, and fill color of the error bar caps, you can use the `errorBarCap` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/errorbarcap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbarcap.cs" %}
{% include code-snippet/chart/series/error-bar/errorbarcap/errorbarcap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/errorbarcap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbarcap.cs" %}
{% include code-snippet/chart/series/error-bar/errorbarcap/errorbarcap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customizing error bar color

To customise the error bar color for individual errors, use the `errorBarColorMapping` property. You can also customize the vertical error, horizontal error, horizontal negative and positive error, and vertical negative and positive error for an individual point using the `verticalError`, `horizontalError`, `horizontalNegativeError`, `horizontalPositiveError`, `verticalNegativeError`, and `verticalPositiveError` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/errorbarcolor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbarcolor.cs" %}
{% include code-snippet/chart/series/error-bar/errorbarcolor/errorbarcolor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/errorbarcolor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbarcolor.cs" %}
{% include code-snippet/chart/series/error-bar/errorbarcolor/errorbarcolor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### Series render

The `seriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/error-bar/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/error-bar/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `pointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/error-bar/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/error-bar/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/error-bar/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)