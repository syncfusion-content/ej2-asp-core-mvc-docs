---
layout: post
title: Template and Nesting in ##Platform_Name## Context Menu | Syncfusion
description: Define custom templates for Syncfusion ##Platform_Name## Context Menu items with the itemTemplate property and render nested submenus for hierarchical actions.
platform: ej2-asp-core-mvc
control: Template And Multilevel Nesting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template and Nesting in ##Platform_Name## Context Menu

## Item template

The [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_ItemTemplate) property in the ContextMenu component allows you to define custom templates for displaying menu items within the context menu. This feature is particularly useful when you want to customize the appearance or layout of the menu items beyond the default text-based list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/context-menu/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/context-menu/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Drop Down Button Template Support](images/context-menu-item-template.png)

## Template

{% if page.publishingplatform == "aspnet-core" %}

The ContextMenu items can be customized by using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event. The event triggers before each menu item is rendered. The event argument will be used to identify the menu item and customize it based on the requirement. In the following sample, the menu item is rendered with a keyboard shortcut for the specified action in the ContextMenu using the template. Here, the shortcut is specified for Save as, View page source, and Inspect in the right-side corner of the menu items by adding a span element in the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event.

{% elsif page.publishingplatform == "aspnet-mvc" %}

The ContextMenu items can be customized by using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event. The event triggers before each menu item is rendered. The event argument will be used to identify the menu item and customize it based on the requirement. In the following sample, the menu item is rendered with a keyboard shortcut for the specified action in the ContextMenu using the template. Here, the shortcut is specified for Save as, View page source, and Inspect in the right-side corner of the menu items by adding a span element in the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event.

{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/target/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Target.cs" %}
{% include code-snippet/context-menu/target/target.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/target/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Target.cs" %}
{% include code-snippet/context-menu/target/target.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multilevel nesting

{% if page.publishingplatform == "aspnet-core" %}

Multiple-level nesting is supported in the ContextMenu. It can be achieved by mapping the [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Items) property inside the parent [`menuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html).

{% elsif page.publishingplatform == "aspnet-mvc" %}

Multiple-level nesting is supported in the ContextMenu. It can be achieved by mapping the [`items`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Items) property inside the parent [`menuItems`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html).

{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/nesting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nesting.cs" %}
{% include code-snippet/context-menu/nesting/nesting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/nesting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nesting.cs" %}
{% include code-snippet/context-menu/nesting/nesting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Populate menu items with data source](./how-to#data-binding)
