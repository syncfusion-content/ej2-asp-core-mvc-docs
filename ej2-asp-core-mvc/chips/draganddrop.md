---
layout: post
title: Drag and drop in ##Platform_Name## Chips Control | Syncfusion
description: Learn here all about Drag and drop in Syncfusion ##Platform_Name## Chips control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drag and drop
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and drop in Chips control

The Chips control enables drag and drop functionality for any chip when [`allowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_AllowDragAndDrop) is set to **true**. Chips can be dragged and dropped within the same or across external ChipList containers.

When dragging a chip, an indicator line appears between chips, showing the exact position where the chip will be dropped. This visual indicator helps users place chips precisely at the desired location.

* To prevent dragging action for a specific chip, use the [`dragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_DragStart) event, which triggers when chip dragging begins. Similarly, to prevent dropping action for a specific chip, use the [`dragStop`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_DragStop) event, which triggers when dragging ends.

* The [`dragging`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_Dragging) event triggers while a chip is being dragged. You can customize the appearance of the cloned chip element during this event.

* You can set the drag area for the chips using the [`dragArea`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_DragArea) property which allows the dragging of cloned chip only within the specified element. It accepts an element Id or class as a string and defaults to `null`.

In the following sample, the [`allowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_AllowDragAndDrop) property is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/trailing/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/trailing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/trailing/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}