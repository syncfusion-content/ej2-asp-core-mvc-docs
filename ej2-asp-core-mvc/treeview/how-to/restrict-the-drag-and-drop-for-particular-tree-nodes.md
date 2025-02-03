---
layout: post
title: Restrict drag and drop for node in ##Platform_Name## TreeView Control | Syncfusion
description: Learn here all about Restrict the Drag And Drop For Particular Tree Nodes in Syncfusion ##Platform_Name## TreeView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Restrict the drag-and-drop for particular tree nodes

You can restrict drag and drop operations to allow files to be dropped only under folders. This can be achieved by using [`nodeDragStop`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.navigations.treeview.html#Syncfusion_EJ2_Navigations_TreeView_NodeDragStop) and [`nodeDragging`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.navigations.treeview.html#Syncfusion_EJ2_Navigations_TreeView_NodeDragging) events of TreeView.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-drag/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodedrag.cs" %}
{% include code-snippet/treeview/how-to/node-drag/nodedrag.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-drag/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodedrag.cs" %}
{% include code-snippet/treeview/how-to/node-drag/nodedrag.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](../images/node-drag.PNG)
