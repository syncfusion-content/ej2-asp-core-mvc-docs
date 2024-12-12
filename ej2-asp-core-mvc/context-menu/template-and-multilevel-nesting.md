---
layout: post
title: Template And Multilevel Nesting in ##Platform_Name## Context Menu Control | Syncfusion
description: Learn here all about Template And Multilevel Nesting in Syncfusion ##Platform_Name## Context Menu control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Template And Multilevel Nesting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template and Multilevel nesting

## Item template

The [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_ItemTemplate) property in the ContextMenu component allows you to define custom templates for displaying menu items within the context menu. This feature is particularly useful when you want to customize the appearance or layout of the menu items beyond the default text-based list.

{% endif %}

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

## Template

{% if page.publishingplatform == "aspnet-core" %}

The ContextMenu items can be customized by using the [`Render`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event. The item render event triggers while rendering each menu item. The event argument will be used to identify the menu item and customize it based on the requirement. In the following sample, the menu item is rendered with keycode for specified action in ContextMenu using the template. Here, the keycode is specified for Save as, View page source, and Inspect in the right side corner of the menu items by adding span element in the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event.

{% elsif page.publishingplatform == "aspnet-mvc" %}

The ContextMenu items can be customized by using the [`Render`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event. The item render event triggers while rendering each menu item. The event argument will be used to identify the menu item and customize it based on the requirement. In the following sample, the menu item is rendered with keycode for specified action in ContextMenu using the template. Here, the keycode is specified for Save as, View page source, and Inspect in the right side corner of the menu items by adding span element in the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event.

{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/target/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/context-menu/target/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/target/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/context-menu/target/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multilevel nesting

{% if page.publishingplatform == "aspnet-core" %}

The Multiple level nesting supports in ContextMenu. It can be achieved by mapping the [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Items) property inside the parent [`menuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html).

{% elsif page.publishingplatform == "aspnet-mvc" %}

The Multiple level nesting supports in ContextMenu. It can be achieved by mapping the [`items`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Items) property inside the parent [`menuItems`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html).

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



## See Also

* [Populate menu items with data source](./how-to#data-binding)