---
layout: post
title: Position with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about Position with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positions in ASP.NET MVC Speed Dial Control

## OpensOnHover

[OpensOnHover](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpensOnHover) property indicates whether to open the popup when the button of SpeedDial is hovered. By default, SpeedDial opens popup on click action. By default the OpensOnHover is false. Opens popup on mouse hover action is achieved by [OpensOnHover](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpensOnHover) property when the value is true.

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

![Asp.Net MVC Speed Dial OpensOnHover](images/Hover.png)

## Programmatically Show/Hide

Speed Dial component can show and hide the items programmatically by using `show` and `hide` methods.

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

![Asp.Net MVC Speed Dial Show Items](images/ShowItems.png)
![Asp.Net MVC Speed Dial Hide Items](images/HideItems.png)

## Programmatically Refresh the Position

Refreshes the speed dial button position. Use `refreshPosition` method to re-position button when the `target` is resized.

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

![Asp.Net MVC Speed Dial Refresh](images/Refresh.png)