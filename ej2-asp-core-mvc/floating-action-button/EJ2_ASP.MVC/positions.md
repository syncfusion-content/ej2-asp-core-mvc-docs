---
layout: post
title: Positions in ##Platform_Name## FloatingActionButton Component
description: Learn here all about Positions in Syncfusion ##Platform_Name## FloatingActionButton component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Positions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positions in Asp.Net MVC Floating Action Button Component

This section explains the different positions of Floating Action Button.

## Positioning

The floating action button can be positioned using the [`Position`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Position) property. The fab is positioned based on the [`Target`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Target), if target is defined else positioned based on the browser viewport.

## Types of Positions

The types of Floating Action Button Positions are as follows:

* TopLeft
* TopCenter
* TopRight
* MiddleLeft
* MiddleCenter
* MiddleRight
* BottomLeft
* BottomCenter
* BottomRight

## Bottom Left position

In this example, Floating Action Button is demonstrated with BottomLeft position using Position property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/positions/bottom-left-position/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/positions/bottom-left-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabPosition.cs" %}
{% include code-snippet/floating-action-button/positions/bottom-left-position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net MVC Floating Action Button Component](images/bottom-left-position.png)

## All available positions

In this example, Floating Action Button is demonstrated with All position using Position property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/positions/all-position/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/positions/all-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabPosition.cs" %}
{% include code-snippet/floating-action-button/positions/all-position/allposition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net MVC Floating Action Button Component](images/bottom-left-position.png)