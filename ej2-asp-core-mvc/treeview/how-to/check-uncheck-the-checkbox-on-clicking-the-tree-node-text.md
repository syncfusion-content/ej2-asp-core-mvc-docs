---
layout: post
title: Check/Uncheck The Checkbox On Clicking The Tree Node Text in ##Platform_Name## TreeView Control | Syncfusion
description: Learn here all about Check/Uncheck The Checkbox On Clicking The Tree Node Text in Syncfusion ##Platform_Name## TreeView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Check/Uncheck the checkbox on clicking the tree node text

You can check and uncheck the checkboxes of TreeView by clicking the tree node using the [`nodeClicked`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.navigations.treeview.html#Syncfusion_EJ2_Navigations_TreeView_NodeClicked) event of TreeView.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-check/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/node-check/nodecheck.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-check/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/node-check/nodecheck.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](../images/node-check.PNG)