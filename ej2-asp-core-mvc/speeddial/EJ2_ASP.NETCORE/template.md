---
layout: post
title: Template with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about template with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template in ASP.NET Core SpeedDial

This section has a detailed explanation on the available templates in Speed Dial Control.

## Item Template

You can use the [`itemTemplate`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_ItemTemplate) property which defines the template value that can be used to customize each item in the SpeedDial.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/template/itemtemplate/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Popup Template

You can use the [`popupTemplate`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_PopupTemplate) property which defines the template value that can be displayed in the popup when the Speed Dial is clicked.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/template/popuptemplate/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}