---
layout: post
title: Layouts in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Layouts in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Layouts in ASP.NET Core Ribbon Control

The Ribbon offers to customize the layout by using the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property. The Ribbon control supports the following layouts:

## Classic layout

In classic layout, the Ribbon control organize the items and groups in a traditional form by setting the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Classic](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html). By default, the Ribbon control renders in `Classic` layout.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/classic/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Classic Layout](./images/ribbon-classic.png)

## Simplified layout

In simplified layout, the Ribbon control organize the items and groups into a single row by setting the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Simplified](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/simplified/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Simplified Layout](./images/ribbon-simplified.png)

## Minimized state

You can hide the Ribbon contents and display only the tab headers by double-clicking on the tab header. In minimized state, the Ribbon control expands to its normal state when click on the tab header.

Also, you can render or programmatically change the Ribbon control to minimized state by setting the [isMinimized](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_IsMinimized) property to `true`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/minimize/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control in Minimized state](./images/ribbon-minimize.png)
