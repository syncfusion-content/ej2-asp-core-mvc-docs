---
layout: post
title: Styles in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn here all about styles and icons in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Styles
publishingplatform: ##Platform_Name##
documentation: ug
---

# Styles in ASP.NET MVC SpeedDial Control

This section briefs different ways to style SpeedDial Control.

## SpeedDial button

You can customize the icon and text of ASP.NET MVC SpeedDial using [OpenIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpenIconCss), [CloseIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CloseIconCss) and [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Content) properties.

### SpeedDial with Icon

You can use the [OpenIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpenIconCss) and [CloseIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CloseIconCss) property to show icons in speed dial button. You can also show tooltip on hover to show additional details to end-user by setting `title` attribute.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/icononly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/speeddial/styles/icononly/icon.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial Icon](images/SpeedDial-IconOnly.png)

### SpeedDial with Text

You can show text only in SpeedDial button by setting [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Content) property without setting icon properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/textonly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/speeddial/styles/textonly/text.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial Text](images/SpeedDial-TextOnly.png)

### SpeedDial with Icon and Text

You can show the icon and text of ASP.NET MVC Speed Dial Button using [OpenIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpenIconCss), [CloseIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CloseIconCss) and [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Content) properties together.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/texticon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="IconText.cs" %}
{% include code-snippet/speeddial/styles/texticon/texticon.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial Icon and Text](images/SpeedDial-IconText.png)

## Disabled

You can enable or disable the Speed Dial Control using [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Disabled) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/speeddial/styles/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial Disabled](images/SpeedDial-Disabled.png)

## CssClass

The ASP.NET MVC Speed Dial supports the following predefined styles that can be defined using the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CssClass) property. You can customize by setting the `CssClass` property with the below defined class.

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
{% include code-snippet/speeddial/styles/cssclass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/speeddial/styles/cssclass/cssclass.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial CssClass](images/SpeedDial-Cssclass.png)

## Visible

You can set the Speed Dial Control to visible/hidden state using `Visible` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/visible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Visible.cs" %}
{% include code-snippet/speeddial/styles/visible/visible.cs %}
{% endhighlight %}
{% endtabs %}

## Tooltip

You can show tooltip on hover to show additional details to end-user by setting [Title](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Title) property to speed dial items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/speeddial/styles/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

## Opens on hover

You can use [OpensOnHover](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpensOnHover) property to open actions items on hover itself. By default action items displayed only when clicking the speed dial button.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/opens-on-hover/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hover.cs" %}
{% include code-snippet/speeddial/styles/opens-on-hover/hover.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial Opens on hover](images/SpeedDial-OpensOnHover.png)