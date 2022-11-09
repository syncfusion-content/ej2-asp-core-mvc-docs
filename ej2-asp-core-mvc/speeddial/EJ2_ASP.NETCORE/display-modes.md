---
layout: post
title: Display Mode with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about Mode with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Display Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Display Modes in ASP.NET Core Speed Dial

The ASP.NET Core Speed Dial, the action items can be displayed in `Linear` and `Radial` display modes by setting [mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property.

## Linear Display Mode

In `Linear` display mode, Speed Dial action items are displayed in a list-like format either horizontally or vertically. By default, Speed Dial items are displayed in `Linear` mode.

### Direction

You can open the action items on the top, left, up, and down side of the Speed Dial button by setting [direction](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Direction) property. The default value is `Auto` where the action items are displayed based on the [position](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Position)of the Speed Dial.

The `Linear` directions of Speed Dial are as follows:

* Left - Action items are displayed on the left side of the button.
* Right - Action items are displayed on the right side of the button.
* Up - Action items are displayed on the top of the button.
* Down - Action items are displayed on the bottom of the button.
* Auto - Action items display direction auto calculated based on `Position` of the Speed Dial. If Speed Dial is position at bottom right, then action items displayed at top.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/mode/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial Linear Mode](images/SDLinear.png)

## Radial Display Mode (Radial Menu)

In `Radial` mode, Speed Dial action items are displayed in a circular pattern like a radial menu. For more details about radial mode, check out the link [here](https://ej2.syncfusion.com/aspnetcore/documentation/speeddial/radial-menu).

