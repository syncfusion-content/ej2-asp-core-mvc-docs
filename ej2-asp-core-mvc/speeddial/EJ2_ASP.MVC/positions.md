---
layout: post
title: Position in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about different built in positions in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positions in ASP.NET MVC Speed Dial Control

The Speed dial control can be positioned anywhere on the [Target](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Target) using the [Position](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Position) property. If the `Target` is not defined, then Speed Dial is positioned based on the browser viewport.

The position values of Speed Dial are as follows:
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
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/bottom-left-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/speeddial/positions/bottom-left-position/position.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Speed Dial Position](./images/SpeedDial-Position.png)

## Opens on hover

You can open the Speed Dial action items on mouse hover by setting the [OpensOnHover](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpensOnHover) property as true.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/opens-on-hover/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hover.cs" %}
{% include code-snippet/speeddial/positions/opens-on-hover/hover.cs %}
{% endhighlight %}
{% endtabs %}

![Asp.Net MVC Speed Dial OpensOnHover](images/SpeedDial-Icon.png)

## Programmatically show/hide

You can open/close the Speed Dial action items programmatially using `show` and 
`hide` methods.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/show-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Display.cs" %}
{% include code-snippet/speeddial/positions/show-hide/display.cs %}
{% endhighlight %}
{% endtabs %}

![Asp.Net MVC Speed Dial Show Items](images/SpeedDial-ShowItem.png)
![Asp.Net MVC Speed Dial Hide Items](images/SpeedDial-HideItem.png)

## Programmatically refresh the position

You can refresh the position of the Speed Dial using `refreshPosition` method when the `Target`position is changed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/refresh/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Refresh.cs" %}
{% include code-snippet/speeddial/positions/refresh/refresh.cs %}
{% endhighlight %}
{% endtabs %}