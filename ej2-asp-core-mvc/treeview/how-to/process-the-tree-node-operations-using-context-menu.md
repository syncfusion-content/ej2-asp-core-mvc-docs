---
layout: post
title: How to perform TreeView node operations using Context Menu in ##Platform_Name## TreeView | Syncfusion
description: Perform Syncfusion ##Platform_Name## TreeView node add, remove, and rename operations by integrating the Context Menu via the select event.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to perform TreeView node operations using Context Menu in ##Platform_Name## TreeView

You can integrate the Context Menu with '**TreeView**' control to perform TreeView-related operations such as adding, removing, and renaming nodes.

The following example demonstrates how to manipulate TreeView operations using the **select** event of the Context Menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenu.cs" %}
{% include code-snippet/treeview/how-to/context-menu/contextmenu-core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/context-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenu.cs" %}
{% include code-snippet/treeview/how-to/context-menu/contextmenu-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](../images/contextmenu.PNG)