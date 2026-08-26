---
layout: post
title: Template in ##Platform_Name## Dialog | Syncfusion
description: Add custom HTML or text to the Syncfusion ##Platform_Name## Dialog header and footer using the Header, Buttons, and FooterTemplate properties.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template in ASP.NET MVC Dialog

The Dialog component allows you to customize the header, footer, and content sections using templates. This enables you to add custom HTML, text, or dynamic content to these areas.

## Header

The Dialog header content can be customized through the [`Header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property, which accepts both text and HTML content as a string. You can also enable the built-in close button using the [`ShowCloseIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_ShowCloseIcon) property.

## Footer

The Dialog footer can be configured in two ways:

1. **Using built-in buttons** — Add predefined action buttons through the [`Buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) property
2. **Using footer template** — Provide custom HTML through the [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) property

N> The [`Buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) and [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) properties can't be used at the same time.

## Content

The Dialog content can be customized through the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Content) property, and it accepts both text and HTML string as content.

The below example demonstrates the usage of header, footer and content template in the Dialog

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/template/footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/template/footer/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/template/footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/template/footer/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![dialog](./images/dialog-template.png)

## See Also

* [How to add an icon to Dialog buttons](./how-to/add-an-icons-to-dialog-buttons)
* [How to customize the Dialog appearance](./how-to/customize-the-dialog-appearance)
