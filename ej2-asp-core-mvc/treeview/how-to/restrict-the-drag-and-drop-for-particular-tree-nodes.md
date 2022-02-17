---
layout: post
title: Restrict The Drag And Drop For Particular Tree Nodes in ##Platform_Name## Treeview Component
description: Learn here all about Restrict The Drag And Drop For Particular Tree Nodes in Syncfusion ##Platform_Name## Treeview component and more.
platform: ej2-asp-core-mvc
control: Restrict The Drag And Drop For Particular Tree Nodes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Restrict the drag-and-drop for particular tree nodes

You can able to restrict to drag and drop files under folder only. These can be achieved by using 'nodeDragStop' and 'nodeDragging' event of TreeView.

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



Output be like the below.

![TreeView Sample](../images/node-drag.PNG)
