---
layout: post
title: Radial Menu with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about Radial Menu with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Radial Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Radial Menu in ASP.NET MVC Speed Dial Control

## Direction

Types of Radial Menu directions
*Clockwise
*AntiClockwise
*Auto

In SpeedDialRadialSettings use [Direction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialAnimationSettings.html#Syncfusion_EJ2_Buttons_SpeedDialAnimationSettings_Duration) property to display the Items in any one of the above direction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/direction/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/direction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/speeddial/radial-menu/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial Radial Mode](images/Radial.png)

## Start and End Angle

Use SpeedDialRadialSettings to modify the Start and End Angles. It is available only when the [Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property is `Radial`. Use [StartAngle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_StartAngle) property and [EndAngle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_EndAngle) property to change the angles.

| Angles | Definition | Range  | Default value|
| --- | --- | --- | ---|
| Start Angle | The Start angle indicates the Start angle of speed dial item placement | 0 to 360 | -1 | 
| End Angle | The End angle indicates the End angle of speed dial items placement | 0 to 360 | -1 |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/angles/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/angles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Angles.cs" %}
{% include code-snippet/speeddial/radial-menu/angles/angles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial Angles](images/Angle.png)

## Offset

Use [Offset](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialRadialSettings.html#Syncfusion_EJ2_Buttons_SpeedDialRadialSettings_Offset) property to set the offset distance of speed dial items placement from the button of Speed Dial. It accepts the string values. The default value is 100px. It is available only when the [Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Mode) property is `Radial`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/offset/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/radial-menu/offset/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offset.cs" %}
{% include code-snippet/speeddial/radial-menu/offset/offset.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Speed Dial Offset](images/Offset.png)