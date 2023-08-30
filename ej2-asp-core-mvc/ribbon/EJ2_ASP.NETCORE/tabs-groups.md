---
layout: post
title: Tabs and Groups in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Tabs and Groups in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tabs and Groups

The Ribbon control consists of a series of tabs that are organized into groups to enable quick access to specific commands or tools. Each tab contains a set of groups, and each group contains collections of items that are logically related to each other.

## Adding Tabs

You can use the [tabs](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_Tabs) property to add tabs to the Ribbon control and define the content of the tab header by using the [header](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTab.html#Syncfusion_EJ2_Ribbon_RibbonTab_Header) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/tabs-groups/tabs/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Tabs](./images/ribbon-tabs.png)

## Adding Groups

You can use the [groups](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTab.html#Syncfusion_EJ2_Ribbon_RibbonTab_Groups) property to add groups for each tab in the Ribbon and define the name of the group header by using the [header](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Header) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/tabs-groups/groups/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Groups](./images/ribbon-groups.png)

## Adding Items

You can add collections of items to each group by using the [collections](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Collections) and [items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCollection.html#Syncfusion_EJ2_Ribbon_RibbonCollection_Items) properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/tabs-groups/items/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Items](./images/ribbon-items.png)

> For more information on the built-in and how to add custom Ribbon items, you can visit the [`items`](./items) page.