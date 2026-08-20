---
layout: post
title: Sidebar with TreeView in ##Platform_Name## Sidebar | Syncfusion
description: Learn how to integrate a TreeView within the Syncfusion ##Platform_Name## Sidebar and synchronize expand, collapse, and dock state behaviors.
platform: ej2-asp-core-mvc
control: Layout Page Sidebar With Treeview
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sidebar with TreeView in ##Platform_Name## Sidebar

The following example demonstrates how to render TreeView component inside the Sidebar with dock state and how to achieve expand and collapse the functionalities simultaneously in the sidebar and Treeview.

On collapse, the LI elements of TreeView show icons only to represent the short sign of the hidden text content. On expand, hidden text content will be set to be visible.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/layout-page-treeview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/layout-page-treeview/Index.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/layout-page-treeview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/layout-page-treeview/Index.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below in Expanded state.

![Sidebar Sample](../images/expanded.png)

Output be like the below in Collapsed state.

![Sidebar Sample](../images/collapsed.png)
