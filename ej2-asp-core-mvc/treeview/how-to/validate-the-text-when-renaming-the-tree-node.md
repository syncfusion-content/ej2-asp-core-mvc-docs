---
layout: post
title: Validate The Text When Renaming The Tree Node in ##Platform_Name## TreeView Control
description: Learn here all about Validate The Text When Renaming The Tree Node in Syncfusion ##Platform_Name## TreeView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validate the text when renaming the tree node

You can validate the tree node text while editing using [`nodeEdited`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.navigations.treeview.html#Syncfusion_EJ2_Navigations_TreeView_NodeEdited) event of the TreeView. Following is an example that shows how to validate and prevent empty values in tree node.

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



Output be like the below.

![TreeView Sample](../images/renaming-tree.PNG)
