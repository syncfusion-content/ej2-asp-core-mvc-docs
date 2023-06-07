---
layout: post
title: Layouts in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Layouts in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Layouts in ASP.NET MVC Ribbon Control

The Ribbon offers to customize the layout by using the [ActiveLayout](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property. The Ribbon control supports the following layouts:

## Classic layout

In classic layout, the Ribbon control organize the items and groups in a traditional form by setting the [ActiveLayout](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Classic](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html). By default, the Ribbon control renders in `Classic` layout.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/classic/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Classic Layout](images/ribbon-classic.png)

## Simplified layout

In simplified layout, the Ribbon control organize the items and groups into a single row by setting the [ActiveLayout](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Simplified](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/simplified/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Simplified Layout](images/ribbon-simplified.png)

## Minimized state

You can hide the Ribbon contents and display only the tab headers by double-clicking on the tab header. In minimized state, the Ribbon control expands to its normal state when click on the tab header.

Also, You can render or programmatically change the Ribbon control to minimized state by setting the [IsMinimized](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_IsMinimized) property to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/minimize/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control in Minimized state](images/ribbon-minimize.png)