---
layout: post
title: Ribbon Contextual Tabs in ##Platform_Name## Ribbon Control | Syncfusion
description: Checkout and learn about Ribbon Contextual Tabs in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ribbon contextual tabs

The Ribbon Contextual tabs are similar to the Ribbon tabs that are displayed on demand based on their needs, such as an image or a table tabs. It supports adding all built-in and custom ribbon items to perform specific actions.

## Visible tabs

You can utilize the [visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonContextualTab.html#Syncfusion_EJ2_Ribbon_RibbonContextualTab_Visible) property to control the visibility of each contextual tab.

## Adding contextual tabs

You can utilize the [contextualTabs](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.ribbon.ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ContextualTabs) property to add contextual tabs in the Ribbon. This property accepts an array of Ribbon tabs, where you can add multiple tabs based on your needs.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/contextual-tabs/add-contextual-tab/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with adding contextual tab](./images/ribbon-contextualtab.png)

## Selected tabs

By using the [isSelected](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonContextualTab.html#Syncfusion_EJ2_Ribbon_RibbonContextualTab_IsSelected) property you can control the selected state of each contextual tab and indicates which tab is currently active.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/contextual-tabs/selected-tab/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with contextual tab selected](./images/ribbon-contextualtab-selected.png)

## Methods

### Show tab

You can use the `showTab` method to make the specific Contextual tab visible in the Ribbon.

### Hide tab

You can use the `hideTab` method to hide specific Contextual tab in the Ribbon.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/contextual-tabs/method/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with contextual tab method](./images/ribbon-contextualtab-method.png)
