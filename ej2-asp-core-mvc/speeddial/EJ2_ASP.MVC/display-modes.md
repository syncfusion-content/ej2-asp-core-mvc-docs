---
layout: post
title: Display Modes in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about linear and radial display modes in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Display Modes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Display Modes in ASP.NET MVC Speed Dial Control

The action items in ASP.NET MVC Speed Dial can be displayed in `Linear` and `Radial` display modes by setting [Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property.


## Linear display mode

In `Linear` display mode, Speed Dial action items are displayed in a list-like format either horizontally or vertically. By default, Speed Dial items are displayed in `Linear` mode.

### Direction

You can open the action items on the top, left, up, and down side of the Speed Dial button by setting [Direction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Direction) property. The default value is `Auto` where the action items are displayed based on the [Position](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Position)of the Speed Dial.

The `Linear` directions of Speed Dial are as follows:

* Left - Action items are displayed on the left side of the button.
* Right - Action items are displayed on the right side of the button.
* Up - Action items are displayed on the top of the button.
* Down - Action items are displayed on the bottom of the button.
* Auto - Action items display direction auto calculated based on `Position` of the Speed Dial. If Speed Dial is position at bottom right, then action items displayed at top.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LinearMode.cs" %}
{% include code-snippet/speeddial/mode/linear.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial Linear Mode](images/SpeedDial-LinearMode.png)

## Radial display mode (Radial Menu)

In `Radial` mode, Speed Dial action items are displayed in a circular pattern like a radial menu. For more details about radial mode, check out the link [here](https://ej2.syncfusion.com/aspnetmvc/documentation/speeddial/radial-menu).