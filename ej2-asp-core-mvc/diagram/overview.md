---
layout: post
title: Overview in ##Platform_Name## Diagram Component
description: Learn here all about Overview in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Overview
publishingplatform: ##Platform_Name##
documentation: ug
---


# Overview Control

Overview control allows you to see a preview or an overall view of the entire content of a diagram. This helps you to look at the overall picture of a large diagram and also to navigate, pan, or zoom, on a particular position of the page.

When you work on a very large diagram, you may not know the part you are actually working on, or navigation from one part to another might be difficult. One solution for navigation is to zoom out the entire diagram and find where you are. Then, you can zoom in a particular area you want to. This solution is not suitable when you need some frequent navigation.

Overview control solves these problems by showing a preview, that is, an overall view of the entire diagram. A rectangle indicates viewport of the diagram. Navigation becomes easy by dragging this rectangle.

## Create overview

The `sourceID` property of overview should be set with the corresponding diagram ID for the overall view.

The `width` and `height` properties of the overview allow you to define the size of the overview.

The following code illustrates how to create overview.

### Zoom and Pan

In overview, the view port of the diagram is highlighted with a red colored rectangle. Diagram can be zoomed/panned by interacting with that. You can interact with overview as follows:

* Resize the rectangle: Zooms in/out the diagram.
* Drag the rectangle: Pans the diagram.
* Click at a position: Navigates to the clicked region.
* Choose a particular region by clicking and dragging: Navigates to the specified region.

The following image shows how the diagram is zoomed/panned with overview.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/overView/overView/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OverView.cs" %}
{% include code-snippet/diagram/overView/overView/overView.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/overView/overView/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OverView.cs" %}
{% include code-snippet/diagram/overView/overView/overView.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


