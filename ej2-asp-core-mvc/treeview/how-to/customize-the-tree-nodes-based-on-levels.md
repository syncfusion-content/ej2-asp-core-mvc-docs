---
layout: post
title: How to customize the TreeView nodes based on levels in ##Platform_Name## TreeView | Syncfusion
description: Customize the Syncfusion ##Platform_Name## TreeView node appearance at each level with a custom cssClass plus per-level styles for clear visual hierarchy.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize the TreeView nodes based on levels in ##Platform_Name## TreeView

You can customize the tree nodes based on their levels by adding a custom `cssClass` to the control and enabling specific styles.

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
{% include code-snippet/treeview/how-to/node-customize/nodecustomize-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](../images/nodecustomize.PNG)
