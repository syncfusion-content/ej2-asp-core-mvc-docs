---
layout: post
title: Styles with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about styles with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Styles
publishingplatform: ##Platform_Name##
documentation: ug
---

# Styles in ASP.NET Core SpeedDial

This section lists the available styles in SpeedDial Control.

## SpeedDial Button

You can customize the icon and text of ASP.NET Core SpeedDial using [`openIconCss`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_OpenIconCss), [`closeIconCss`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_CloseIconCss) and [`content`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_Content) properties.

### SpeedDial with Icon

You can use the [`openIconCss`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_OpenIconCss) and [`closeIconCss`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_CloseIconCss) property to represent the speed dial button with only icons. You can also show tooltip on hover to show additional details to end-user by setting `title` attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/icononly/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

### SpeedDial with Text

You can show text only in SpeedDial button by setting [`content`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_Content) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/textonly/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

### SpeedDial with Icon and Text

You can customize the icon and text of ASP.NET Core Speed Dial Button using [`openIconCss`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_OpenIconCss), [`closeIconCss`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_CloseIconCss) and [`content`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_Content) properties together.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/texticon/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Disabled

You can enabled/disabled the Speed Dial Control using [`disabled`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_Disabled) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## CssClass

The Blazor Speed Dial supports the following predefined styles that can be defined using the [`cssClass`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_CssClass) property. You can customize by replacing the `cssClass` property with the below defined class.

| CssClass | Description |
| -------- | -------- |
| e-primary | Used to represent a primary action. |
| e-outline |  Used to represent an appearance of button with outline. |
| e-info |  Used to represent an informative action. |
| e-success | Used to represent a positive action. |
| e-warning | Used to represent an action with caution. |
| e-danger | Used to represent a negative action. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/cssclass/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Visible

You can set the Speed Dial Control to visible/hidden state using [`visible`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_Visible) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/visible/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Tooltip

You can show tooltip on hover to show additional details to end-user by setting [`Title`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SpeedDialItem.html#Syncfusion_Blazor_Buttons_SpeedDialItem_Title) property to speed dial items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## OpensOnHover

You can use [`opensOnHover`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_OpensOnHover) property to hover the speeddial items without click the speeddial button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/styles/opens-on-hover/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}