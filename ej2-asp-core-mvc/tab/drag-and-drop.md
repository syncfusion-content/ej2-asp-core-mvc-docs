---
layout: post
title: Drag And Drop in ##Platform_Name## Tab Component
description: Learn here all about Drag And Drop in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag and drop items

The Tab component allows you to drag and drop any item by setting [allowDragAndDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~AllowDragAndDrop.html)&nbsp;to **true**. Items can be reordered to any place by dragging and dropping them onto the desired location.

* If you need to prevent dragging action for a particular item, the [`onDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~OnDragStart.html) event can be used which will trigger when the item drag is started. If you need to prevent dropping action for a particular item, the [`dragged`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~Dragged.html) event can be used which will trigger when the drag action is stopped.

* The [`dragArea`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~DragArea.html) defines the area in which the draggable element movement will be occurring. Outside that area will be restricted for the draggable element movement.

* The [`onDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~OnDragStart.html) event will be triggered before dragging the item from Tab.

* The [`dragging`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~Dragging.html) event will be triggered when the Tab item is being dragged.

* The [`dragged`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~Dragged.html) event will be triggered when the Tab item is dropped on the target element successfully.

In the following sample, the [allowDragAndDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~AllowDragAndDrop.html) property is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/drag-and-drop/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Draganddrop.cs" %}
{% include code-snippet/tab/drag-and-drop/default/draganddrop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/drag-and-drop/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Draganddrop.cs" %}
{% include code-snippet/tab/drag-and-drop/default/draganddrop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Tab drag and drop items](./images/dragdrop.gif)

## Drag and drop item between tabs

It is possible to drag and drop the tab items between two tabs, by manually saving those dropped items as new tab item data through the `addTab` method of Tab and removing the dragged item through the `removeTab` method of Tab.

In this example, we have used the tab control as an external source, and the item from the tab component is dragged and dropped onto another Tab. Therefore, it is necessary to use the `onDragStart` and `dragged` event of the Tab component, where we can form an event object and save it using the `addTab` method of the Tab and remove the dragged item through `removeTab` method of Tab using the dragged item index.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/drag-and-drop/tab-to-tab/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tabtotab.cs" %}
{% include code-snippet/tab/drag-and-drop/tab-to-tab/tabtotab.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/drag-and-drop/tab-to-tab/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tabtotab.cs" %}
{% include code-snippet/tab/drag-and-drop/tab-to-tab/tabtotab.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Drag and drop item between tabs](./images/tabtotab.gif)

## Drag and drop items to external source

It is possible to drag and drop the items to any of the external sources from the Tab, by manually saving those dropped items as new node data through the `addNodes` method of Treeview and removing the dragged item through the `removeTab` method of Tab.

In this example, we have used the tree view control as an external source, and the item from the tab component is dragged and dropped onto the child nodes of the tree view component. Therefore, it is necessary to use  the `dragged` event of the Tab component, where we can form an event object and save it using the `addNodes` method of the Treeview and remove the dragged item through the `removeTab` method of Tab using the dragged item index.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/drag-and-drop/tab-to-treeview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tabtotreeview.cs" %}
{% include code-snippet/tab/drag-and-drop/tab-to-treeview/tabtotreeview.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/drag-and-drop/tab-to-treeview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tabtotreeview.cs" %}
{% include code-snippet/tab/drag-and-drop/tab-to-treeview/tabtotreeview.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Drag and drop tab items to external source](./images/tabtotreeview.gif)

## Drag and drop items from external source

It is possible to drag and drop the items from any of the external sources into the Tab, by manually saving those dropped items as new item data through the `addTab` method of Tab and removing the dragged node through the `removeNodes` method of Treeview.

In this example, we have used the tree view control as an external source, and the child nodes from the tree view component are dragged and dropped onto the Tab. Therefore, it is necessary to use the `nodeDragStop` event of the Treeview component, where we can form an event object and save it using the `addTab` method of the Tab and remove the dragged node through the `removeNodes` method of Treeview.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/drag-and-drop/treeview-to-tab/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Treeviewtotab.cs" %}
{% include code-snippet/tab/drag-and-drop/treeview-to-tab/treeviewtotab.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/drag-and-drop/treeview-to-tab/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Treeviewtotab.cs" %}
{% include code-snippet/tab/drag-and-drop/treeview-to-tab/treeviewtotab.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Drag and drop tab items from external source](./images/treeviewtotab.gif)