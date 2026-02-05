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

The chart supports zooming through the following three interaction methods:

* **Selection** – By setting [`EnableSelectionZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) to **true** in `ZoomSettings`, zooming can be performed using a rubber-band selection.
* **Mouse wheel** – By setting [`EnableMouseWheelZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) to **true** in `ZoomSettings`, the chart can be zoomed in and out by scrolling the mouse wheel.
* **Pinch** – By setting [`EnablePinchZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) to **true** in `ZoomSettings`, zooming can be performed using pinch gestures on touch-enabled devices.

N> Pinch zooming is supported only in browsers that support multi-touch gestures.

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



After zooming, a toolbar is displayed that includes **zoom**, **zoomin**, **zoomout**, **pan**, and **reset** buttons.  
Selecting **Pan** allows the chart to be panned, and selecting **Reset** restores the chart to its original zoom state.

## Modes

The [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ZoomMode.html) property in `ZoomSettings` specifies whether zooming can be applied along the horizontal axis, vertical axis, or both. The default value is **XY**.

The supported zooming modes are:

* **X** – Allows zooming along the horizontal axis.
* **Y** – Allows zooming along the vertical axis.
* **XY** – Allows zooming along both horizontal and vertical axes.

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

By default, the **zoomin**, **zoomout**, **pan**, and **reset** buttons are displayed when the chart is zoomed. The toolbar contents can be customized by using the [`ToolbarItems`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_zoomsettings_ToolbarItems) property.  

Additionally, the zooming toolbar can be displayed during initial rendering by setting the [`ShowToolbar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_zoomsettings_ShowToolbar) property to **true**.

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

The zoom toolbar position can be customized by using the [`ToolbarPosition`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_ChartZoomSettings_ToolbarPosition) property. This property supports horizontal alignments (**Near**, **Center**, and **Far**) and vertical alignments (**Top**, **Middle**, and **Bottom**). The default values are **Far** for horizontal alignment and **Top** for vertical alignment.

For precise placement, the [`X`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartToolbarPosition.html#Syncfusion_EJ2_Charts_ChartToolbarPosition_X) and [`Y`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartToolbarPosition.html#Syncfusion_EJ2_Charts_ChartToolbarPosition_Y) properties can be used.  
Enabling the [`Draggable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartToolbarPosition.html#Syncfusion_EJ2_Charts_ChartToolbarPosition_Draggable) property allows the toolbar to be repositioned freely within the chart area.

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

By using the [`EnablePan`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property, the zoomed chart can be panned without using toolbar items.

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

By using the [`EnableScrollbar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_ChartZoomSettings_EnableScrollbar) property, a scrollbar can be displayed for the zoomed chart. This scrollbar supports both zooming and panning interactions.

Scrollbar appearance can be customized using properties within [`ScrollbarSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html). For example:
- [`TrackColor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_TrackColor) and [`TrackRadius`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_TrackRadius) control the track appearance.
- [`ScrollbarColor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_ScrollbarColor) and [`ScrollbarRadius`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_ScrollbarRadius) customize the scroller.
- Zooming through the scrollbar can be enabled or disabled using [`EnableZoom`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_EnableZoom).
- The grip color and scrollbar height can be customized using [`GripColor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_GripColor) and [`Height`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_Height).

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

The [`Position`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartScrollbarSettings.html#Syncfusion_EJ2_Charts_ChartScrollbarSettings_Position) property specifies where the scrollbar is rendered. By default, both vertical and horizontal scrollbars are placed near their respective axes.

The available positions are:

* **Default** – `placeNextToAxisLine`
* **Horizontal scrollbar** – `Top`, `Bottom`
* **Vertical scrollbar** – `Left`, `Right`

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

Use the [`EnableAnimation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html#Syncfusion_EJ2_Charts_ChartZoomSettings_EnableAnimation) property to apply smooth animation effects during zoom operations.

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

By using the [`EnableAutoIntervalOnZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html) property, the axis interval is calculated automatically based on the current zoomed range.

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

