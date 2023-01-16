---
layout: post
title: Positions in ##Platform_Name## Floating Action Button Control | Syncfusion
description: Learn here all about Positions in Syncfusion ##Platform_Name## Floating Action Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Positions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positions in ASP.NET Core Floating Action Button Control

The [ASP.NET Core Floating Action Button](https://www.syncfusion.com/aspnet-core-ui-controls/fab) can be positioned anywhere on the [Target](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Target) using the [Position](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Position) property. If the `Target` is not defined, then FAB is positioned based on the browser viewport.

The position values of Floating Action Button are as follows:

* TopLeft
* TopCenter
* TopRight
* MiddleLeft
* MiddleCenter
* MiddleRight
* BottomLeft
* BottomCenter
* BottomRight

Below example demonstrates Bottom Left position of FAB.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/positions/bottom-left-position/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Floating Action Button Control](images/BottomLeftPosition.png)

Below example demonstrates different supported positions of FAB.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/positions/all-positions/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Floating Action Button Positions](images/FabPositions.png)

## Custom position

You can define the custom position of the Floating Action Button by override the `top`, `left`, `right`, and `bottom` CSS properties using [CssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_CssClass).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/positions/custom-position/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Floating Action Button Custom position](images/CustomPosition.png)


