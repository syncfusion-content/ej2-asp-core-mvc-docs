---
layout: post
title: Appearance of ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn here all about appearance and icons in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: SpeedDial
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance of ASP.NET MVC SpeedDial Control

This section briefly explains about Appearance of Speed dial.

## Disabled

You can enable or disable the Speed Dial Control using [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Disabled) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/appearance/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/speeddial/appearance/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial Disabled](images/SpeedDial-Disabled.png)

## Visibility

You can use the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Visible) property to show or hide the SpeedDial component.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/appearance/visible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Visible.cs" %}
{% include code-snippet/speeddial/appearance/visible/visible.cs %}
{% endhighlight %}
{% endtabs %}

# Modal

You can use the [Modal](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Modal) property to open the Speed Dial items as modal which adds an overlay to prevent the background interaction.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/modal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Modal.cs" %}
{% include code-snippet/speeddial/modal/modal.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial Modal](images/SpeedDial-ModalProperty.png)

## Tooltip

You can show tooltip on hover to show additional details to end-user by setting [Title](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Title) property to speed dial items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/appearance/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/speeddial/appearance/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

## CssClass

The ASP.NET MVC Speed Dial supports the following predefined styles that can be defined using the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CssClass) property. You can customize by setting the `CssClass` property with the below defined class.
You can also customize the Speed dial item, by override the default CSS of Speed dial component by using the `CssClass` property.


| CssClass | Description |
| -------- | -------- |
| e-primary | Used to represent a primary action. |
| e-outline |  Used to represent an appearance of button with outline. |
| e-info |  Used to represent an informative action. |
| e-success | Used to represent a positive action. |
| e-warning | Used to represent an action with caution. |
| e-danger | Used to represent a negative action. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/appearance/cssclass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/speeddial/appearance/cssclass/cssclass.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial CssClass](images/SpeedDial-Cssclass.png)
