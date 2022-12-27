---
layout: post
title: Drag resize and rotate in ##Platform_Name## Diagram Component
description: Learn here all about Drag resize and rotate in Syncfusion ##Platform_Name## Diagram component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drag resize rotate
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag Resize and Rotate

## Drag

* An object can be dragged by clicking and dragging it. When multiple elements are selected, dragging any one of the selected elements move every selected element.
* When you drag the elements in the diagram, the [`positionChange`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_PositionChange) event gets triggered and to do customization in this event.

![Drag](../images/drag.gif)

## Resize

* Selector is surrounded by eight thumbs. When dragging these thumbs, selected items can be resized.
* When one corner of the selector is dragged, opposite corner is in a static position.
* When a node is resized, the [`sizeChange`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_SizeChange) event gets triggered.

![Resize](../images/resize.gif)

> While dragging and resizing, the objects are snapped towards the nearest objects to make better alignments. For better alignments, refer to `Snapping`.

## Customize the resize-thumb

You can change the size of the node resize thumb and the connector end point handle by using the `handleSize` property. The appearance such as fill, stroke, and stroke width of the node resize thumb and connector end point handle can be customized by overriding the e-diagram-resize-handle and e-diagram-endpoint-handle classes respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/node/node/node.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/node/node/node.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![handleSize](../images/handleSize.gif)

## Rotate

* A rotate handler is placed above the selector. Clicking and dragging the handler in a circular direction lead to rotate the node.
* The node is rotated with reference to the static pivot point.
* Pivot thumb (thumb at the middle of the node) appears while rotating the node to represent the static point.

![Rotate](../images/rotate.gif)