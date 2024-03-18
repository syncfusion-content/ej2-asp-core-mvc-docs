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

Contextual tabs are similar to Ribbon tabs that show up when you're working on something specific, such as an image or a table. Just select an image, table, or any other element, and the relevant tabs with configured options will appear at the Tab panel, allowing you to work faster and more efficiently.

## Visible tabs

You can utilize the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonContextualTab.html#Syncfusion_EJ2_Ribbon_RibbonContextualTab_Visible) property within each tab to control the visibility of the contextual tab and its associated content.

## Adding contextual tabs

To add contextual tabs in Syncfusion Ribbon, you can utilize the [ContextualTabs](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.ribbon.ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ContextualTabs) property. This property accepts an array of Ribbon tabs where you can add multiple tabs as per needs.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/contextual-tabs/add-contextual-tab/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with adding contextual tab](images/ribbon-contextualtab.png)

## Selected tabs

By using the [IsSelected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonContextualTab.html#Syncfusion_EJ2_Ribbon_RibbonContextualTab_IsSelected) property within each tab object, you can control the selection state of each contextual tab and indicate which tab is currently active.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/contextual-tabs/selected-tab/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with contextual tab selected](images/ribbon-contextualtab-selected.png)

## Methods

### Show tab

You can make the specific tab visible by using the `ShowTab` method available in the Ribbon.

### Hide tab

You can also hide specific tab by using the `HideTab` method available in the Ribbon.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/contextual-tabs/method/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with contextual tab method](images/ribbon-contextualtab-method.png)
