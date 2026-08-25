---
layout: post
title: Template in ##Platform_Name## Dialog | Syncfusion
description: Add custom HTML or text to the Syncfusion ##Platform_Name## Dialog header, footer, and content sections using the Header, Buttons, and FooterTemplate properties.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Template in ##Platform_Name## Dialog

The Dialog component allows you to customize the header, footer, and content sections using templates. This enables you to add custom HTML, text, or dynamic content to these areas.

## Header

The Dialog header content can be customized through the [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property, which accepts both text and HTML content as a string. You can also enable the built-in close button using the [`showCloseIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_ShowCloseIcon) property.

## Footer

The Dialog footer can be configured in two ways:

1. **Using built-in buttons** — Add predefined action buttons through the [`buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) property
2. **Using footer template** — Provide custom HTML through the [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) property

N> The [`buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) and [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) properties can't be used at the same time.

## Content

The Dialog content can be customized through the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Content) property, which accepts both text and HTML strings. Use the `e-content-template` tag helper to define dynamic content with server-side data binding.

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

![dialog](./images/dialog-template.png)

## See Also

* [How to add an icon to dialog buttons](./how-to/add-an-icons-to-dialog-buttons)
* [How to customize the dialog appearance](./how-to/customize-the-dialog-appearance)
