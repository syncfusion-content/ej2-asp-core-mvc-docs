---
layout: post
title: How to data bind in ##Platform_Name## Context Menu | Syncfusion
description: Populate Syncfusion ##Platform_Name## Context Menu items from a local data source by mapping the data fields to the items property.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to data bind in ##Platform_Name## Context Menu

{% if page.publishingplatform == "aspnet-core" %}

To bind a local data source to the ContextMenu, menu items are populated from the data source and mapped to the [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Items) property. A parent–child relationship between the items can be established by mapping the `id` and `parentId` fields in the data source.

{% elsif page.publishingplatform == "aspnet-mvc" %}

To bind a local data source to the ContextMenu, menu items are populated from the data source and mapped to the [`items`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Items) property. A parent–child relationship between the items can be established by mapping the `id` and `parentId` fields in the data source.

{% endif %}

The following example demonstrates how to bind a local data source to the ContextMenu. A separator item is rendered by adding the `e-separator` class to the corresponding menu item in the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event when the item's `text` field is empty.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/data-bind/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/context-menu/howto/data-bind/databind.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/data-bind/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/context-menu/howto/data-bind/databind.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [Template and multilevel nesting](../template-and-multilevel-nesting)
* [Change animation settings](./change-animation-settings)
* [Open a dialog on context menu item click](./open-a-dialog-on-contextmenu-item-click)


