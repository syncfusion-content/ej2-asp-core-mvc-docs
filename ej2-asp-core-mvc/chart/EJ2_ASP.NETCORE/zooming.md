---
layout: post
title: Zooming in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Zooming in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Zooming
publishingplatform: ##Platform_Name##
documentation: ug
---


# Zooming and Panning in ##Platform_Name## Chart Component

## Enable zooming

Chart can be zoomed in three ways.

* Selection - By setting [`enableSelectionZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true in `zoomSettings`, you can zoom the chart using the rubber band selection.
* Mousewheel - By setting [`enableMouseWheelZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true in `zoomSettings`, you can zoomin and zoomout the chart by scrolling the mouse wheel.
* Pinch - By setting  [`enablePinchZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true in `zoomSettings`, you can zoom the chart through pinch gesture in touch enabled devices.

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

The [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ZoomMode.html) property in zoomSettings specifies whether the chart is allowed to scale along the horizontal axis or vertical axis. The default value of the mode is XY (both axis).

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

By default, zoomin, zoomout, pan and reset buttons will be displayed for zoomed chart. You can customize to show the desired options in the toolbar using the [`toolbarItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_zoomsettings_ToolbarItems) property. Also using the [`showToolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_zoomsettings_ShowToolbar) property, you can show toolkit for zooming and panning the chart during initial rendering itself.

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

### Toolbar customization

The zoom toolbar in the chart can be repositioned using the [`ToolbarPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_ChartZoomSettings_ToolbarPosition) property, allowing flexible alignment and placement. It supports horizontal alignments (**Near**, **Center**, and **Far**) and vertical alignments (**Top**, **Middle**, and **Bottom**), with default values set to **Far** and **Top**, respectively. For precise placement, the [`X`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartToolbarPosition.html#Syncfusion_EJ2_Charts_ChartToolbarPosition_X) and [`Y`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartToolbarPosition.html#Syncfusion_EJ2_Charts_ChartToolbarPosition_Y) properties can be used to adjust the toolbar's position within the chart area. Additionally, enabling the [`Draggable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartToolbarPosition.html#Syncfusion_EJ2_Charts_ChartToolbarPosition_Draggable) property allows users to freely move the toolbar within the chart area, ensuring optimal usability.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/toolbar-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-custom.cs" %}
{% include code-snippet/chart/user-interaction/zoom/toolbar-custom/toolbar-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/toolbar-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-custom.cs" %}
{% include code-snippet/chart/user-interaction/zoom/toolbar-custom/toolbar-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Enable pan

Using [`enablePan`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property, you can pan the zoomed chart without the help of toolbar items.

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



## Enable scrollbar

Using the [`EnableScrollbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_ChartZoomSettings_EnableScrollbar) property, you can add a scrollbar to a zoomed chart. This scrollbar allows you to zoom or pan the chart. The appearance of the scrollbar can be customized using properties in [`ScrollbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html). For example, you can use [`TrackColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_TrackColor) and [`TrackRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_TrackRadius) properties to customize the track of the scrollbar, and [`ScrollbarRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_ScrollbarRadius) and [`ScrollbarColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_ScrollbarColor) properties to customize the scroller. The ability to zoom through the scrollbar can be enabled or disabled using the [`EnableZoom`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_EnableZoom) property in [`ScrollbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html). Additionally, you can change the color of the grip and height of the scrollbar using the [`GripColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_GripColor) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_Height) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/scrollbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollbar.cs" %}
{% include code-snippet/chart/user-interaction/zoom/scrollbar/scrollbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/scrollbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollbar.cs" %}
{% include code-snippet/chart/user-interaction/zoom/scrollbar/scrollbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Position

The `Position` property allows users to specify their preferred scrollbar location. By default, both vertical and horizontal scrollbars are rendered near their respective axes. Using the customization options below, you can position the scrollbar as desired:

* Default: `placeNextToAxisLine`.
* Horizontal scrollbar: Available positions are `Top` and `Bottom`.
* Vertical scrollbar: Available positions are `Left` and `Right`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/user-interaction/zoom/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/user-interaction/zoom/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable animation

Enable the [`EnableAnimation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_ChartZoomSettings_EnableAnimation) property to experience smooth transitions when zooming in on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/chart/user-interaction/zoom/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/zoom/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/chart/user-interaction/zoom/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Auto interval on zooming

By using [`enableAutoIntervalOnZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html) property, the axis interval will get calculated automatically with respect to the zoomed range.

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

