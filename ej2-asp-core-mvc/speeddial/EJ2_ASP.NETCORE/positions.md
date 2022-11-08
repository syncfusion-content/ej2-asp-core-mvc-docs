---
layout: post
title: Position with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about Position with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positions in ASP.NET Core Speed Dial

The Speed dial Component can be positioned anywhere on the [target](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Target) using the [position](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Position) property. If the `target` is not defined, then Speed Dial is positioned based on the browser viewport.

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/opens-on-hover/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/opens-on-hover/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hover.cs" %}
{% include code-snippet/speeddial/positions/opens-on-hover/hover.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net Core Speed Dial OpensOnHover](images/Hover.png)

## OpensOnHover

You can open the Speed Dial action items on mouse hover by setting the [opensOnHover](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpensOnHover) property as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/opens-on-hover/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/opens-on-hover/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hover.cs" %}
{% include code-snippet/speeddial/positions/opens-on-hover/hover.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net Core Speed Dial OpensOnHover](images/Hover.png)

## Programmatically Show/Hide

You can open/close the Speed Dial action items programmatially using `show` and 
`hide` methods.

Below example demonstrates open/close action items on button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/show-hide/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/show-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Display.cs" %}
{% include code-snippet/speeddial/positions/show-hide/display.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net Core Speed Dial Show Items](images/ShowItems.png)
![Asp.Net Core Speed Dial Hide Items](images/HideItems.png)

## Programmatically Refresh the Position

You can refresh the position of the Speed Dial using `refreshPosition` method when the `Target`position is changed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/refresh/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/positions/refresh/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Refresh.cs" %}
{% include code-snippet/speeddial/positions/refresh/refresh.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net Core Speed Dial Refresh](images/Refresh.png)