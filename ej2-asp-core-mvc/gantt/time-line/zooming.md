---
layout: post
title: Zooming action in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about zooming in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Time Line
publishingplatform: ##Platform_Name##
documentation: ug
---


# Zooming action in gantt control

The zooming support provides options to increase or decrease the width of timeline cells and also provides options to change the timeline units dynamically. This support enables you to view the tasks in a project clearly from minute to decade timespan. To enable the zooming features, define the `ZoomIn`, `ZoomOut`, and `ZoomToFit` items to [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) items collections, and this action can be performed on external actions such as button click using the `zoomIn`, `zoomOut`, and `fitToProject` built-in methods. The following zooming options are available to view the project:

## Zoom in

This support is used to increase the timeline width and timeline unit from years to minutes timespan. When the `ZoomIn` icon was clicked, the timeline cell width is increased when the cell size exceeds the specified range and the timeline unit is changed based on the current zoom levels.

## Zoom out

This support is used to increase the timeline width and timeline unit from minutes to years timespan. When the `ZoomOut` icon was clicked, the timeline cell width is decreased when the cell size falls behind the specified range and the timeline view mode is changed based on the current zooming levels.

## Zoom to fit

This support is used to view all the tasks available in a project within available area on the chart part of Gantt. When users click the `ZoomToFit` icon, then all the tasks are rendered within the available chart container width.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/zooming/defaultItems/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/zooming/defaultItems/defaultItems.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/zooming/defaultItems/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/zooming/defaultItems/defaultItems.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing zooming levels

In Gantt, the zoom in and zoom out actions are performed based on the predefined zooming levels in the `zoomingLevels` property. You can customize the zooming actions by defining the required zooming collection to the `zoomingLevels` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/zooming/customItems/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomItems.cs" %}
{% include code-snippet/gantt/zooming/customItems/customItems.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/zooming/customItems/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomItems.cs" %}
{% include code-snippet/gantt/zooming/customItems/customItems.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Zoom action by Touch Swipe Gestures

The Gantt chart now supports `ZoomIn` and `ZoomOut` actions using touch swipe gestures:

   * Zoom In - Pinch `outward` with two fingers.
   * Zoom Out - Pinch `inward` with two fingers.

To achieve this functionality, the Gantt chart continuously monitors the pixel difference between the two fingers. If the pixel difference exceeds 15 pixels, the corresponding zoom action (either `ZoomIn` and `ZoomOut`) is triggered based on the gesture's pixel difference.

* Mouse Pad(Track Pad) - The Gantt chart also supports `ZoomIn` and `ZoomOut` actions using pinch gestures on a track pad or mouse pad:

    * Zoom In - Pinch `outward` with two fingers.
    * Zoom Out - Pinch `inward` with two fingers.

The Gantt chart monitors the pixel movement on the mouse pad. If the deltaY pixel value is less than 15, a `ZoomIn` action occurs. If it's greater than 15, a `ZoomOut` action is triggered.

* Mouse Wheel - The Gantt chart also now supports `ZoomIn` and `ZoomOut` actions using the mouse wheel along with the `Ctrl` key:

    * Zoom In - Scroll the mouse wheel `upward` (deltaY pixel value less than 0).
    * Zoom Out - Scroll the mouse wheel `downward` (deltaY pixel value greater than 0).

The Gantt chart continuously monitors the mouse wheel movement. If the deltaY pixel value is less than 0, a `ZoomIn` action occurs, and if it's greater than 0, a `ZoomOut` action is triggered.

## Zoom action by methods

You can perform the various zoom actions dynamically or on external click action using the following methods:
* Zoom in - `zoomIn`
* Zoom out - `zoomOut`
* Fit to project - `fitToProject`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/zooming/method/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Method.cs" %}
{% include code-snippet/gantt/zooming/method/method.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/zooming/method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Method.cs" %}
{% include code-snippet/gantt/zooming/method/method.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}