---
layout: post
title: TreeView Node Ops via Context Menu in ##Platform_Name## | Syncfusion
description: Perform Syncfusion ##Platform_Name## TreeView node add, remove, and rename operations by integrating the Context Menu via the select event.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# TreeView Node Ops via Context Menu in ##Platform_Name##

You can integrate the [Context Menu](https://www.syncfusion.com/aspnet-core-ui-controls/context-menu) with the [TreeView](https://www.syncfusion.com/aspnet-core-ui-controls/treeview) control to perform TreeView-related operations such as adding, removing, and renaming nodes.

The following example demonstrates how to manipulate TreeView operations using the [select](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_Select) event of the Context Menu.

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