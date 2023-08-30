---
layout: post
title: Styles in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn here all about styles and icons in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Styles
publishingplatform: ##Platform_Name##
documentation: ug
---

# Styles in ASP.NET Core SpeedDial Control

This section briefs different ways to style SpeedDial Control.

## SpeedDial button

You can customize the icon and text of ASP.NET Core SpeedDial using [openIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpenIconCss), [closeIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CloseIconCss) and [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Content) properties.

### SpeedDial with Icon

You can use the [openIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpenIconCss) and [closeIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CloseIconCss) property to show icons in speed dial button. You can also show tooltip on hover to show additional details to end-user by setting `title` attribute.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/icononly/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SpeedDial with Icon](images/SpeedDial-IconOnly.png)

### SpeedDial with Text

You can show text only in SpeedDial button by setting [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Content) property without setting icon properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/textonly/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SpeedDial with Text](images/SpeedDial-TextOnly.png)

### SpeedDial with Icon and Text

You can show the icon and text of ASP.NET Core Speed Dial Button using [openIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpenIconCss), [closeIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CloseIconCss) and [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Content) properties together.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/texticon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SpeedDial with Icon and Text](images/SpeedDial-IconText.png)

## Disabled

You can enable or disable the Speed Dial Control using [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Disabled) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SpeedDial Disabled](images/SpeedDial-Disabled.png)

## CssClass

The ASP.NET Core Speed Dial supports the following predefined styles that can be defined using the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_CssClass) property. You can customize by setting the `cssClass` property with the below defined class.

| CssClass | Description |
| -------- | -------- |
| e-primary | Used to represent a primary action. |
| e-outline |  Used to represent an appearance of button with outline. |
| e-info |  Used to represent an informative action. |
| e-success | Used to represent a positive action. |
| e-warning | Used to represent an action with caution. |
| e-danger | Used to represent a negative action. |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/cssclass/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SpeedDial with CssClass](images/SpeedDial-Cssclass.png)

## Visible

You can set the Speed Dial Control to visible/hidden state using `visible` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/visible/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Tooltip

You can show tooltip on hover to show additional details to end-user by setting [Title](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Title) property to speed dial items.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Opens on hover

You can use [opensOnHover](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OpensOnHover) property to open actions items on hover itself. By default action items displayed only when clicking the speed dial button.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/opens-on-hover/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SpeedDial with Opens on hover](images/SpeedDial-OpensOnHover.png)