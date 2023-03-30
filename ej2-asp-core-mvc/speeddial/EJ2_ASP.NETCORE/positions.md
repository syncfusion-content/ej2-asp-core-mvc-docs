---
layout: post
title: Position in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about different built in positions in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positions in ASP.NET Core Speed Dial Control

This section explains the different positions of SpeedDial.

## Target

The [Target](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Target) property defines the selector for the element in which the speed dial will be positioned. If the Target is not defined, then Speed Dial is positioned based on the browser viewport.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/target/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Speed Dial component with target](./images/SpeedDial-Target.png)

## Built-in positions

The SpeedDial Component can be positioned in the pre-defined positions using the [Position](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Position) property.

The built-in position values of SpeedDial are as follows:

* TopLeft
* TopCenter
* TopRight
* MiddleLeft
* MiddleCenter
* MiddleRight
* BottomLeft
* BottomCenter
* BottomRight

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/bottom-left-position/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Speed Dial SpeedDial component with position](./images/SpeedDial-Position.png)

## Custom Positioning

You can define the custom position for the SpeedDial by overriding the `top`, `left`, `right`, and `bottom` CSS properties using [CssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CssClass).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/custom-positioning/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Asp.Net Core Speed Dial component with custom position](images/SpeedDial-CustomPosition.png)
