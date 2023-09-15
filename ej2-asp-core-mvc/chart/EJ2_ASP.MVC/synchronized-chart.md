---
layout: post
title: Synchronized Charts in ##Platform_Name## Chart Component
description: Learn here all about Synchronized Charts in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Synchronized charts
publishingplatform: ##Platform_Name##
documentation: ug
---


# Synchronized charts in ##Platform_Name## Chart Component

## Tooltip synchronization

The tooltip can be synchronized across multiple charts using the `showTooltip` and `hideTooltip` methods. When we hover over a data point in one chart, we call the `showTooltip` method for the other charts to display related information in other connected charts simultaneously.

In the `showTooltip` method, specify the following parameters programmatically to enable tooltip for a particular chart:

* `x` - Data point x-value or x-coordinate value.
* `y` - Data point y-value or y-coordinate value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/synchronization/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/chart/user-interaction/synchronization/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/synchronization/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/chart/user-interaction/synchronization/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Crosshair synchronization

The crosshair can be synchronized across multiple charts using the `showCrosshair` and `hideCrosshair` methods. When we hover over one chart, we call the `showCrosshair` method for the other charts to align with data points in other connected charts, simplifying data comparison and analysis.

In the `showCrosshair` method, specify the following parameters programmatically to enable crosshair for a particular chart:

* `x` - Specifies the x-value of the point or x-coordinate.
* `y` - Specifies the y-value of the point or y-coordinate.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/synchronization/crosshair/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Crosshair.cs" %}
{% include code-snippet/chart/user-interaction/synchronization/crosshair/crosshair.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/synchronization/crosshair/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Crosshair.cs" %}
{% include code-snippet/chart/user-interaction/synchronization/crosshair/crosshair.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Zooming synchronization

You can maintain constant zoom levels across multiple charts using the [`ZoomComplete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_ZoomComplete) event. In the `ZoomComplete` event, obtain the [`ZoomFactor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_ZoomFactor) and [`ZoomPosition`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_ZoomPosition) values of the particular chart, and then apply those values to the other charts.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/synchronization/zooming/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Zooming.cs" %}
{% include code-snippet/chart/user-interaction/synchronization/zooming/zooming.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/synchronization/zooming/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Zooming.cs" %}
{% include code-snippet/chart/user-interaction/synchronization/zooming/zooming.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Selection synchronization

You can select the data across multiple charts using the [`SelectionComplete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_SelectionComplete) event. In the `SelectionComplete` event, obtain the selected values of the particular chart, and then apply those values to the other charts.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/synchronization/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/chart/user-interaction/synchronization/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/synchronization/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/chart/user-interaction/synchronization/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


