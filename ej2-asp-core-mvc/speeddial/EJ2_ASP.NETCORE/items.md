---
layout: post
title: Items in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about action items and its customization in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Items in ASP.NET Core Speed Dial Control

The action items in ASP.NET Core Speed Dial can be added by using [items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Items) property.

| Fields | Type | Description |
|------|------|-------------|
| [Text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Text) | `string` | Defines the text content of SpeedDialItem. |
| [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_IconCss) | `string` | Defines one or more CSS classes to include an icon or image in speed dial item. |
| [Disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Disabled) | `boolean` | Defines whether to enable or disable the SpeedDialItem. |
| [Id](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Id) | `string` | Defines a unique value for the SpeedDialItem which can be used to identify the item in event args. |
| [Title](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Title) | `string` | Defines the title of SpeedDialItem to display tooltip. |

## Icons in Speed Dial items

You can customize the icon and text of Speed Dial action items using [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_IconCss) and [Text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Text) properties.

### Icon only

You can show icon only in SpeedDial items by setting [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_IconCss) property. You can show tooltip on hover to show additional details to end-user by setting [Title](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Title) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/icon-only/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial with Icon](images/SpeedDial-Icon.png)

### Text Only

You can show only text in Speed Dial items by setting [Text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Text) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/text-only/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial with Text](images/SpeedDial-Text.png)

### Icon with Text

You can show icon along with text in Speed Dial items by setting [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_IconCss) and [Text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Text) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/customization/icon-with-text/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial with Icon and Text](images/SpeedDial-Itemwithtext.png)

### Disabled

You can disable Speed Dial items by setting [Disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialItem.html#Syncfusion_EJ2_Buttons_SpeedDialItem_Disabled) property as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial with Disabled](./images/SpeedDial-DisabledItem.png)

## Animation

The Speed Dial items can be animated during the opening and closing of the popup action items. You can customize the animation's `Effect`, `Delay`, and `Duration` by setting [animation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Animation) property. By default, Speed Dial animates with a `Fade` effect and supports all [SpeedDialAnimationEffect](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDialAnimationSettings.html#Syncfusion_EJ2_Buttons_SpeedDialAnimationSettings_Effect) effects.

Below example demonstrates the Speed Dial items with applied Zoom effect.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/items/animation/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET Core Speed Dial Animation](images/SpeedDial-Animation.png)

## Template

The Speed Dial supports to customize the action items and entire pop-up container by setting [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_ItemTemplate) and [popupTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_PopupTemplate) property. For more details about templates, check out the link [here](https://ej2.syncfusion.com/aspnetcore/documentation/speeddial/template).