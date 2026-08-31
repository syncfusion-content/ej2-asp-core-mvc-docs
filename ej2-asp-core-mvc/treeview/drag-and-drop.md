---
layout: post
title: Drag and Drop in ##Platform_Name## TreeView | Syncfusion
description: Enable drag and drop in the Syncfusion ##Platform_Name## TreeView with allowDragAndDrop to reposition nodes via indicator lines and rich drag events.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and Drop in ##Platform_Name## TreeView

The [TreeView](https://www.syncfusion.com/aspnet-core-ui-controls/treeview) control allows you to drag and drop any nodes by setting the [allowDragAndDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_AllowDragAndDrop) property to **true**. Nodes can be dragged and dropped at all levels of the same TreeView. 

The dragged nodes can be dropped at any level by indicator lines with **line**, **plus/minus**, and **restrict** icons. They indicate the exact position where the node will be dropped as a sibling or child.

The following table explains the usage of indicator icons.

| Icons | Description |
|------|-------------|
| Plus icon | Indicates that the dragged node is to be added as a child of the target node. |
| Minus or restrict icon |Indicates that the dragged node is not to be dropped at the hovered region. |
| In-between icon | Indicates that the dragged node is to be added as a sibling of the hovered node. |

* To prevent dragging action for a particular node, you can use the [nodeDragStart](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_NodeDragStart) event, which is triggered when the node drag is started. If you need to prevent dropping action for a particular node, the [nodeDragStop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_NodeDragStop) event can be used and is triggered when the drag is stopped.

* The [nodeDragging](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_NodeDragging) event is triggered when the TreeView node is being dragged. You can customize the cloned element in this event.

* The [nodeDropped](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_NodeDropped) event is triggered when the TreeView node is dropped on the target element successfully.

In the following sample, the [allowDragAndDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_AllowDragAndDrop) property is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/draganddrop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Draganddrop.cs" %}
{% include code-snippet/treeview/draganddrop/draganddrop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/draganddrop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Draganddrop.cs" %}
{% include code-snippet/treeview/draganddrop/draganddrop-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The output will look like the image below:

![TreeView Sample](./images/dragdrop.PNG)

## Multiple-node drag and drop

To drag and drop more than one node, you should enable both the [allowMultiSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_AllowMultiSelection) and [allowDragAndDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_AllowDragAndDrop) properties. 

To perform multi-selection, press and hold **CTRL** key and click the desired nodes. To select a range of nodes, press and hold the **SHIFT** key and click the nodes. 

In the following sample,  the `allowMultiSelection` property is enabled along with the `allowDragAndDrop` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/draganddrop/multidraganddrop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Draganddrop.cs" %}
{% include code-snippet/treeview/draganddrop/multidraganddrop/draganddrop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/draganddrop/multidraganddrop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Draganddrop.cs" %}
{% include code-snippet/treeview/draganddrop/multidraganddrop/draganddrop-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The output will look like the image below:

![TreeView Sample](./images/multidrag.PNG)

## See Also

* [How to restrict the drag-and-drop for particular tree nodes](./how-to/restrict-the-drag-and-drop-for-particular-tree-nodes)