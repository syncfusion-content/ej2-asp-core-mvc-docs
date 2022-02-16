---
layout: post
title: Template in ##Platform_Name## Dialog Component
description: Learn here all about Template in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Template

In Dialog the template support is provided to the header and footer sections. So any text or HTML content can be appending in these sections.

## Header

The Dialog header content can be provided through the
[`Header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property, and it will allow both text and any HTML content as a string.
Also in header, close button is provided as built-in support, and this can be enabled through
the [`ShowCloseIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_ShowCloseIcon) property.

## Footer

The Dialog footer can be enabled by adding built-in [`Buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) or providing any HTML string through the [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate).

> The [`Buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) and [`FooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) properties can't be used at the same time.

## Content

The Dialog content can be provided through the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Content) property, and it accepts both text and HTML string as content.

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

* [How to add an icon to dialog buttons](./how-to/add-an-icons-to-dialog-buttons)
* [How to customize the dialog appearance](./how-to/customize-the-dialog-appearance)
