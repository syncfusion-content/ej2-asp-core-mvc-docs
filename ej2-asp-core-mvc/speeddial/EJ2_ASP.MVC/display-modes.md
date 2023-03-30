---
layout: post
title: Display Modes in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about linear and radial display modes in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: SpeedDial
publishingplatform: ##Platform_Name##
documentation: ug
---

# Display Options in ASP.NET MVC SpeedDial Control

The action items in ASP.NET MVC Speed Dial can be displayed in `Linear` and `Radial` display modes by setting [Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property.

## Open option

By default, action items are displayed only on clicking the speed dial button. You can use the [OpensOnHover](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpensOnHover) property to open the action items by hovering the speed dial button.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/display-modes/opensOnHover/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/speeddial/display-modes/opensOnHover/opensOnHover.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial OpensOnHover](images/SpeedDial-OpensOnHover.png)

## Animation

The Speed Dial items can be animated during the opening and closing of the popup action items. You can customize the animation's `Effect`, `Delay`, and `Duration` by setting [Animation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Animation) property. By default, Speed Dial animates with a `Fade` effect and supports all [SpeedDialAnimationEffect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialAnimationEffect.html) effects.

Below example demonstrates the Speed Dial items with applied Zoom effect.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/display-modes/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/speeddial/display-modes/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial Animation](images/SpeedDial-Animation.png)

## Modes

You can use the [`Mode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property to either display the menu in linear order like a list or like a radial menu in radial (circular) direction.

## Linear mode

In `Linear` display mode, Speed Dial action items are displayed in a list-like format either horizontally or vertically. By default, Speed Dial items are displayed in `Linear` mode.

### Direction

You can open the action items on the top, left, up, and down direction of the Speed Dial button by setting [Direction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Direction) property. The default value is `Auto`.

The `Linear` directions of Speed Dial are as follows:

* Left - Action items are displayed on the left side of the button.
* Right - Action items are displayed on the right side of the button.
* Up - Action items are displayed on the top of the button.
* Down - Action items are displayed on the bottom of the button.
* Auto - Action items display direction auto calculated based on `Position` of the Speed Dial. If Speed Dial is position at bottom right, then action items displayed at top.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/display-modes/mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LinearMode.cs" %}
{% include code-snippet/speeddial/display-modes/mode/linear.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial component with linear mode](images/SpeedDial-LinearMode.png)

## Radial mode

The action items in ASP.NET MVC Speed Dial can be displayed in a circular patter like a radial menu by setting [Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property. You can customize the `Direction`, `StartAngle`, `EndAngle` and `Offset` by setting [SpeedDialRadialSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html).

### Direction

You can open the action items in either clockwise or anticlockwise by setting [Direction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_Direction) property. The default value is `Auto` where the action items are displayed based on the `Position` property of the Speed Dial.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/display-modes/direction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/speeddial/display-modes/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial Radial Mode](images/SpeedDial-RadialMenu.png)

## Start and end angle

You can modify the start and end angle of action items by setting [StartAngle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_EndAngle) properties. If the angle is not defined, the action items are displayed based on the `Position` property of the Speed Dial.

The SpeedDial angle starts with `0` degree in the right side and increases in the clockwise direction.

![ASP.NET MVC Speed Dial component with radial angle](images/SpeedDial-RadialAngle.png)

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/display-modes/angles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Angles.cs" %}
{% include code-snippet/speeddial/display-modes/angles/angles.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial component with angles](images/SpeedDial-Angle.png)

## Offset

You can modify the offset distance between action items and Speed Dial button using [Offset](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_Offset) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/display-modes/offset/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offset.cs" %}
{% include code-snippet/speeddial/display-modes/offset/offset.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial component with Offset](images/SpeedDial-Offset.png)