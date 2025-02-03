---
layout: post
title: Customize nodes based on levels in ##Platform_Name## TreeView Control | Syncfusion
description: Learn here all about Customize the Tree Nodes Based On Levels in Syncfusion ##Platform_Name## TreeView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the tree nodes based on levels

You can customize the tree nodes based on their levels by adding a custom [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TreeView~CssClass.html) to the control and enabling specific styles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecustomize.cs" %}
{% include code-snippet/treeview/how-to/node-customize/nodecustomize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecustomize.cs" %}
{% include code-snippet/treeview/how-to/node-customize/nodecustomize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](../images/nodecustomize.PNG)
