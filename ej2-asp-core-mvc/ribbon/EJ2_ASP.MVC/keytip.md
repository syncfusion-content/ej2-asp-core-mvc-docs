---
layout: post
title: Ribbon Keytip in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Keytip in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---


# Keytips in ASP.NET MVC Ribbon control

The Ribbon supports keyboard navigations to interact the ribbon items using the keytips which can be enabled by setting the [EnableKeyTips](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.ribbon.ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_EnableKeyTips) property.

The keytips will be shown when the `Alt + Windows/Command` keys are pressed.

## Ribbon items keytip

You can add keytips to all the ribbon items by using the [KeyTip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_KeyTip) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/keytip/items-keytip/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with items keytip](./images/ribbon-items-keytip.png)

## File menu keytip

You can add keytips to the file menu by using the [KeyTip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_KeyTip) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/keytip/filemenu-keytip/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with File menu keytip](./images/ribbon-filemenu-keytip.png)

## Backstage menu keytip

You can add keytips to backstage menu items by using the [KeyTip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.BackStageMenu.html#Syncfusion_EJ2_Ribbon_BackStageMenu_KeyTip) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/keytip/backstagemenu-keytip/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Backstage menu keytip](./images/ribbon-backstage-keytip.png)

## Ribbon layout switcher keytip

You can add keytip to the layout switcher by using the [LayoutSwitcherKeyTip](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.ribbon.ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_LayoutSwitcherKeyTip) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/keytip/layout-switcher-keytip/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with layout switcher keytip](./images/ribbon-layout-switcher-keytip.png)

## Ribbon launcher icon keytip

You can add keytip to the launcher icon by using the [LauncherIconKeyTip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_LauncherIconKeyTip) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/keytip/launcher-icon-keytip/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with launcher icon keytip](./images/ribbon-launchericon-keytip.png)

## Methods

### Show keytips

You can use the `showKeyTips` method to shown the keytips dynamically.

In order to show specific keytips, pass the key string as an argument in the `showKeyTips('H')` method.

### Hide keytips

You can use the `hideKeyTips` method in Ribbon to remove the keytips dynamically. This will remove all the visible keytips.

## Guidelines for adding keytips

Before adding keytips to the ribbon items consider the following:

* Avoid using the same keytip setting on multiple items.

> For example: When you add the keytip text `H` or `HF` for the same items, it activates the first item occurrence of `H`, while any subsequent instances of `H` or `HF` are ignored.

* Do not use the same first letter for the single and double keytip items.

> For example: When accessing keytip text `F`, `FP` and `FPF` added for the different ribbon items and pressing `F` key, only the `F` key tip associated item will be activated while the `FP`, `FPF` configured ribbon items will be ignored.
