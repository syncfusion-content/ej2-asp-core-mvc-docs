---
layout: post
title: How to validate text when renaming the TreeView node in ##Platform_Name## TreeView | Syncfusion
description: Validate Syncfusion ##Platform_Name## TreeView node text during rename using the nodeEdited event, preventing empty or duplicate values.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to validate text when renaming the TreeView node in ##Platform_Name## TreeView

You can validate the tree node text during editing by using the `nodeEdited` event of the TreeView. The following example shows how to validate and prevent empty values in a tree node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-validate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodevalidate.cs" %}
{% include code-snippet/treeview/how-to/node-validate/nodevalidate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-validate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodevalidate.cs" %}
{% include code-snippet/treeview/how-to/node-validate/nodevalidate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](../images/renaming-tree.PNG)
