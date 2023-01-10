---
layout: post
title: Zooming in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Zooming in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Zooming
publishingplatform: ##Platform_Name##
documentation: ug
---


# Zooming  and Panning

## Enable Zooming

Chart can be zoomed in three ways.

* Selection - By setting [`EnableSelectionZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true in `ZoomSettings`, you can zoom the chart by using the rubber band selection.
* Mousewheel - By setting [`EnableMouseWheelZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true in `ZoomSettings`, you can zoomin and zoomout the chart by scrolling the mouse wheel.
* Pinch - By setting  [`EnablePinchZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true in `ZoomSettings`, you can zoom the chart through pinch gesture in touch enabled devices.

N> Pinch zooming is supported only in browsers that support multi-touch gestures. Currently IE11, Chrome and Opera browsers support multi-touch in desktop devices.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/user-interaction/zoom/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/user-interaction/zoom/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



After zooming the chart, a zooming toolbar will appear with `zoom`,`zoomin`, `zoomout`, `pan` and `reset` buttons. Selecting the Pan option will allow to pan the chart and selecting the Reset option will reset the zoomed chart.

## Modes

The [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ZoomMode.html) property in zoomSettings specifies whether the chart is allowed to scale along the horizontal axis or vertical axis. The default value of the mode is XY (both axis).

There are three types of mode.

* X - Allows us to zoom the chart horizontally.
* Y - Allows us to zoom the chart vertically.
* XY - Allows us to zoom the chart both vertically and horizontally.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mode.cs" %}
{% include code-snippet/chart/user-interaction/zoom/mode/mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mode.cs" %}
{% include code-snippet/chart/user-interaction/zoom/mode/mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Toolbar

By default, zoomin, zoomout, pan and reset buttons will be displayed for zoomed chart. You can customize to show the desired options in the toolbar using the [`ToolbarItems`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_zoomsettings_ToolbarItems) property. Also using the [`ShowToolbar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_zoomsettings_ShowToolbar) property, you can show toolkit for zooming and panning the chart during initial rendering itself.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar.cs" %}
{% include code-snippet/chart/user-interaction/zoom/toolbar/toolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar.cs" %}
{% include code-snippet/chart/user-interaction/zoom/toolbar/toolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable pan

Using [`EnablePan`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property you can able to pan the zoomed chart without help of toolbar items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/pan/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pan.cs" %}
{% include code-snippet/chart/user-interaction/zoom/pan/pan.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/pan/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pan.cs" %}
{% include code-snippet/chart/user-interaction/zoom/pan/pan.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Auto interval on zooming

By using [`EnableAutoIntervalOnZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html) property, the axis interval will get calculated automatically with respect to the zoomed range.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/auto-interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-interval.cs" %}
{% include code-snippet/chart/user-interaction/zoom/auto-interval/auto-interval.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/auto-interval/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-interval.cs" %}
{% include code-snippet/chart/user-interaction/zoom/auto-interval/auto-interval.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

