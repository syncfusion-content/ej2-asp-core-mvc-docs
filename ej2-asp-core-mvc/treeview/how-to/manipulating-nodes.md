---
layout: post
title: Nodes manipulation in Syncfusion ##Platform_Name## TreeView control
description: Learn here all about Nodes manipulation in Syncfusion ##Platform_Name## TreeView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Nodes manipulation in TreeView control

The TreeView control provides essential methods for dynamically managing nodes, offering the ability to create a highly interactive and customizable tree structure,

* [addNodes](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#addnodes)
* [removeNodes](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#removenodes)
* [updateNode](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#updatenode)
* [refreshNode](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#refreshnode)
* [moveNodes](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#movenodes)

These methods provide the flexibility to add, remove, update, refresh, or relocate nodes as needed, facilitating a fully interactive and customizable TreeView structure.

## Dynamically adding nodes

The [`addNodes`](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#addnodes) method of TreeView allows you to insert new nodes at designated positions within the TreeView by passing the necessary node information. You can add both parent and child nodes by specifying their target ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs1.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs1/manipulating-nodes-cs1.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs1.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs1/manipulating-nodes-cs1.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/manipulating-nodes-cs1.PNG)

## Dynamically removing nodes

The TreeView [`removeNodes`](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#removenodes) method lets you remove multiple nodes by providing their IDs. You can remove both parent and child nodes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs2.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs2/manipulating-nodes-cs2.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs2.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs2/manipulating-nodes-cs2.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/manipulating-nodes-cs2.PNG)

 ## Dynamically update nodes

The TreeView control has the [`updateNode`](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#updatenode) method, which allows you to change a specific node's text by providing its target (either the node ID or element) and the new text. To enable text editing, set the [`allowEditing`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.navigations.treeview.html#Syncfusion_EJ2_Navigations_TreeView_AllowEditing)property to true, ensuring correct functionality of the `updateNode` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs3.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs3/manipulating-nodes-cs3.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs3/razor %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs3.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs3/manipulating-nodes-cs3.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/manipulating-nodes-cs3.PNG)

## Dynamically refresh nodes

The [`refreshNode`](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#refreshnode) method in TreeView allows you to update the content of a specific node by providing its target and the new details. To retrieve the current details of the node, use the [`getTreeData`](https://ej2.syncfusion.com/documentation/api/treeview/#gettreedata) method in conjunction with the node's ID. This method refreshes a designated node within the TreeView.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs4.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs4/manipulating-nodes-cs4.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs4/razor %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs4.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs4/manipulating-nodes-cs4.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/manipulating-nodes-cs4.PNG)

## Dynamically move nodes

The [`moveNodes`](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#movenodes) method in TreeView allows you to relocate a node by defining the node to be moved, the target location, and the index within that target. It facilitates the repositioning of nodes within the same TreeView based on the specified target.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs5/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs5.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs5/manipulating-nodes-cs5.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs5/razor %}
{% endhighlight %}
{% highlight c# tabtitle="manipulating-nodes-cs5.cs" %}
{% include code-snippet/treeview/how-to/manipulating-nodes-cs5/manipulating-nodes-cs5.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/manipulating-nodes-cs5.PNG)