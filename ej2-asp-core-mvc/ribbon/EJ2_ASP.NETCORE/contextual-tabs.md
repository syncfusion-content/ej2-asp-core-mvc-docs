---
layout: post
title: Contextual Tabs in ##Platform_Name## Ribbon | Syncfusion
description: Learn how to add contextual tabs in the ##Platform_Name## Ribbon that appear contextually for the selected item, with built-in and custom Ribbon item support.
control: Ribbon
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# Contextual Tabs in ##Platform_Name## Ribbon

The Ribbon Contextual tabs are similar to the Ribbon tabs that are displayed on demand based on their needs, such as an image or a table tabs. It supports adding all built-in and custom ribbon items to perform specific actions.

## Visible tabs

You can utilize the [visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonContextualTab.html#Syncfusion_EJ2_Ribbon_RibbonContextualTab_Visible) property to control the visibility of each contextual tab.

## Adding contextual tabs

You can utilize the `e-ribbon-contextual-tabs` tag directive to add contextual tabs in the Ribbon where you can add multiple tabs based on your needs.

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
