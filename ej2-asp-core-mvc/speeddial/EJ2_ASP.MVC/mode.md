---
layout: post
title: Mode with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about Mode with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mode in Asp.Net MVC Speed Dial Control

## Types of Mode
* Linear
* Radial

## Linear Mode

SpeedDial items are displayed in linear order like list. Use [Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property to display the Items in linear order direction. In Linear Mode below directions are available

| List of Directions | 
|--|
| Right | 
| Left | 
| Up | 
| Down | 
| Auto |

In `Auto` direction Speed dial action items are displayed vertically above or below the button of Speed Dial based on the Speed Dial button position. In the following example, Speed Dial Items are demonstrated with [Direction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Direction) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/mode/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LinearMode.cs" %}
{% include code-snippet/speeddial/mode/linear.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial Linear Mode](images/LinearDirection.png)

## Radial Mode

SpeedDial items are displayed like radial menu in radial direction (circular direction). Use [Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property to display the Items in Radial menu order direction. In Radial Mode below directions are available

| List of Directions | 
|--|
| Clockwise | 
| AntiClockwise |  
| Auto |

In `Auto` direction Speed dial action items are displayed clockwise or anti-clockwise based on the Speed Dial button position.

> [To learn more about Radial Mode](https://ej2.syncfusion.com/aspnetmvc/documentation/speeddial/radial-menu).