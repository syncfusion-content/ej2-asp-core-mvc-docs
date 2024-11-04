---
layout: post
title: Manipulating nodes in Syncfusion ##Platform_Name## TreeView control
description: Learn here all about Manipulating nodes in Syncfusion ##Platform_Name## TreeView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: Manipulating nodes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Manipulating nodes in Vue TreeView control

The key methods available in the TreeView control for dynamically managing nodes, allowing you to create a highly interactive and customizable tree structure:

* [addNodes](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#addnodes)
* [removeNodes](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#removenodes)
* [updateNode](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#updatenode)
* [refreshNode](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#refreshnode)
* [moveNodes](https://ej2.syncfusion.com/javascript/documentation/api/treeview/#movenodes)

These methods give you the flexibility to add, remove, update, refresh, or move nodes as needed, enabling a fully interactive and customizable TreeView structure. Here’s an overview of each method and how they are typically used:

## Dynamically adding nodes

The TreeView `addNodes` method lets you add new nodes to specific positions in the TreeView by passing the node details. You can add both parent and child nodes by providing their target ID.

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

The TreeView `removeNodes` method lets you remove multiple nodes by providing their IDs. You can remove both parent and child nodes.

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

The `updateNode` method in TreeView lets you update a node’s text by passing its target and the new text. Make sure to enable the [`AllowEditing`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.navigations.treeview.html#Syncfusion_EJ2_Navigations_TreeView_AllowEditing) property.

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

The `refreshNode` method in TreeView lets you update a node’s content by specifying its target and new details. Use the [`getTreeData`](https://ej2.syncfusion.com/javascript/documentation/api/treeview#gettreedata) method with the node’s ID to access its details.

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

The `moveNodes` method in TreeView lets you move a node by specifying the node to move, the target location, and the index in the target.

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