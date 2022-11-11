---
layout: post
title: Radial Menu in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about radial menu and its customization in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Radial Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Radial Menu in ASP.NET MVC Speed Dial Control

The action items in ASP.NET MVC Speed Dial can be displayed in a circular patter like a radial menu by setting [Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property. You can customize the `Direction`, `StartAngle`, `EndAngle` and `Offset` by setting [SpeedDialRadialSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html).

## Radial Menu direction

You can open the action items in either clockwise or anticlockwise by setting [Direction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_Direction) property. The default value is `Auto` where the action items are displayed based on the `Position` property of the Speed Dial.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/direction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/speeddial/radial-menu/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial Radial Mode](images/SpeedDial-RadialMenu.png)

## Start and end angle

You can modify the start and end angle of action items by setting [StartAngle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_EndAngle) properties. If the angle is not defined, the action items are displayed based on the `Position` property of the Speed Dial.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/angles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Angles.cs" %}
{% include code-snippet/speeddial/radial-menu/angles/angles.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial Angles](images/SpeedDial-Angle.png)

## Offset

You can modify the offset distance between action items and Speed Dial button using [Offset](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_Offset) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/offset/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offset.cs" %}
{% include code-snippet/speeddial/radial-menu/offset/offset.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial Offset](images/SpeedDial-Offset.png)