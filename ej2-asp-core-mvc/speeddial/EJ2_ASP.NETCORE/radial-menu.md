---
layout: post
title: Radial Menu with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about Radial Menu with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Radial Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Radial Menu in ASP.NET Core Speed Dial

The ASP.NET Core Speed Dial action items can be displayed in a circular patter like a radial menu by setting [mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property. You can customize the `Direction`, `StartAngle`, `EndAngle` and `Offset` by setting [SpeedDialRadialSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html).

## Radial Menu Direction

You can open the action items in either clockwise or anticlockwise by setting [Direction](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_Direction) property. The default value is `Auto` where the action items are displayed based on the `Position` property of the Speed Dial.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/direction/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial Radial Mode](images/SDRadial.png)

## Start and End Angle

You can modify the start and end angle of action items by setting [StartAngle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_EndAngle) properties. If the angle is not defined, the action items are displayed based on the `position` property of the Speed Dial.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/angles/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial Angles](images/SDAngle.png)

## Offset

You can modify the offset distance between action items and Speed Dial button using [Offset](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_Offset) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/offset/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial Offset](images/SDOffset.png)