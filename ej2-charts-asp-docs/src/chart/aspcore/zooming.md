---
title: " Chart Zooming | ASP.NET MVC "

component: "Chart"

description: "Chart have zooming and panning properties. Chart contains different  zoom modes, zoom toolbar items, scrollbar and auto interval zooming. "
---

# Zooming  and Panning

## Enable Zooming

Chart can be zoomed in three ways.

* Selection - By setting [`enableSelectionZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true
  in `zoomSettings`, you can zoom the chart by using the rubber band selection.
* Mousewheel - By setting [`enableMouseWheelZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true
  in `zoomSettings`, you can zoomin and zoomout the chart by scrolling the mouse wheel.
* Pinch - By setting  [`enablePinchZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html) property to true in `zoomSettings`,
  you can zoom the chart through pinch gesture in touch enabled devices.

 >Pinch zooming is supported only in browsers that support multi-touch gestures. Currently IE11, Chrome and Opera

 browsers support multi-touch in desktop devices.

{% aspTab template="chart/user-interaction/zoom/default", sourceFiles="default.cs" %}

{% endaspTab %}

After zooming the chart, a zooming toolbar will appear with `zoom`,`zoomin`, `zoomout`, `pan` and `reset` buttons.
Selecting the Pan option will allow to pan the chart and selecting the Reset option will reset the zoomed chart.

## Modes

The [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ZoomMode.html) property in zoomSettings specifies whether the chart is
allowed to scale along the horizontal axis or vertical axis. The default value of the mode is XY (both axis).

There are three types of mode.

* X - Allows us to zoom the chart horizontally.
* Y - Allows us to zoom the chart vertically.
* XY - Allows us to zoom the chart both vertically and horizontally.

{% aspTab template="chart/user-interaction/zoom/mode", sourceFiles="mode.cs" %}

{% endaspTab %}

## Toolbar

By default, zoomin, zoomout, pan and reset buttons will be displayed for zoomed chart. You can customize
to show your desire tools in the toolbar using [`toolbarItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html)
property.

{% aspTab template="chart/user-interaction/zoom/toolbar", sourceFiles="toolbar.cs" %}

{% endaspTab %}

## Enable pan

Using [`enablePan`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartZoomSettings.html)
property you can able to pan the zoomed chart without help of toolbar items.

{% aspTab template="chart/user-interaction/zoom/pan", sourceFiles="pan.cs" %}

{% endaspTab %}

## Auto interval on zooming

By using [`enableAutoIntervalOnZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html) property,
the axis interval will get calculated automatically with respect to the zoomed range.

{% aspTab template="chart/user-interaction/zoom/auto-interval", sourceFiles="auto-interval.cs" %}

{% endaspTab %}