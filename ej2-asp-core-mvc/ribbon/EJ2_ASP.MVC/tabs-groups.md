---
layout: post
title: Tabs and Groups in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Tabs and Groups in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tabs and Groups in ASP.NET MVC Ribbon Control

The Ribbon control consists of a series of tabs that are organized into groups to enable quick access to specific commands or tools. Each tab contains a set of groups, and each group contains collections of items that are logically related to each other.

## Adding Tabs

You can use the [Tabs](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_Tabs) property to add tabs to the Ribbon control and define the content of the tab header by using the [Header](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonTab.html#Syncfusion_EJ2_Ribbon_RibbonTab_Header) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/tabs-groups/tabs/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Tabs](images/ribbon-tabs.png)

## Adding Groups

You can use the [Groups](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonTab.html#Syncfusion_EJ2_Ribbon_RibbonTab_Groups) property to add groups for each tab in the Ribbon and define the name of the group header by using the [Header](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Header) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/tabs-groups/groups/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Groups](images/ribbon-groups.png)

## Adding Items

You can add collections of items to each group by using the [Collections](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Collections) and [Items](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonCollection.html#Syncfusion_EJ2_Ribbon_RibbonCollection_Items) properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/tabs-groups/items/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Items](images/ribbon-items.png)

> Check out our [`items`](./items) page for examples and instructions on adding built-in and custom items. It covers different item types and helps you incorporate them into your project.