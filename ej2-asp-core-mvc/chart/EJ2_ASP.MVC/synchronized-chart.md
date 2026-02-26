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

Synchronized charts allow multiple chart instances to share common interactions so that actions performed on one chart are reflected across the others. This approach is useful for comparing related datasets and analyzing trends consistently across multiple visualizations.

## Tooltip synchronization

The tooltip can be synchronized across multiple charts by using the `ShowTooltip` and `HideTooltip` methods. When the user hovers over a data point in one chart, the `ShowTooltip` method can be invoked for the other charts to display the corresponding tooltip information simultaneously.

In the `ShowTooltip` method, specify the following parameters programmatically to enable the tooltip for a specific chart:

* `X` – The x-value of the data point or the x-coordinate.
* `Y` – The y-value of the data point or the y-coordinate.

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

The crosshair can be synchronized across multiple charts by using the `ShowCrosshair` and `HideCrosshair` methods. When the user moves the pointer over one chart, calling the `ShowCrosshair` method on the other charts aligns the crosshair position across all synchronized charts, making data comparison easier.

In the `ShowCrosshair` method, specify the following parameters to render the crosshair for a particular chart:

* `X` – Specifies the x-value of the data point or the x-coordinate.
* `Y` – Specifies the y-value of the data point or the y-coordinate.

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

Zoom levels can be synchronized across multiple charts by using the [`ZoomComplete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_ZoomComplete) event. In the `ZoomComplete` event, retrieve the [`ZoomFactor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_ZoomFactor) and [`ZoomPosition`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_ZoomPosition) values from the zoomed chart.

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

Selection can be synchronized across multiple charts by using the [`SelectionComplete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_SelectionComplete) event. In the `SelectionComplete` event, retrieve the selected data values or region from the active chart and apply the same selection state to the other charts.

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


