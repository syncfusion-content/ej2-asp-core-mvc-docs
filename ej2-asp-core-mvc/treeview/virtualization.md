---
layout: post
title: Virtualization in ##Platform_Name## TreeView Control | Syncfusion
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## TreeView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Virtualization in ##Platform_Name## TreeView control

The TreeView control supports UI virtualization to enhance performance when handling a large amount of data. This feature optimizes rendering by initially gathering all data but only rendering a subset of it during the initial load. The remaining items are then loaded dynamically as the user scrolls within the TreeView container.

To enable virtualization, set the `enableVirtualization` property to **true** and define a fixed `height` for the TreeView container.

In the following sample, the `enableVirtualization` property is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/virtualization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Virtualization.cs" %}
{% include code-snippet/treeview/virtualization/virtualization-core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/virtualization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Virtualization.cs" %}
{% include code-snippet/treeview/virtualization/virtualization-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Performance benefits

Virtualization provides the following performance benefits:

* **Reduced DOM elements**: Only visible nodes are rendered in the DOM, reducing memory consumption.

* **Faster initial load**: Large datasets load quickly as only a subset of nodes are rendered initially.

* **Smooth scrolling**: Dynamic loading ensures smooth scrolling experience without lag.

* **Lower CPU usage**: Rendering fewer elements reduces CPU consumption.

## Important notes

* The `height` property is required when virtualization is enabled.