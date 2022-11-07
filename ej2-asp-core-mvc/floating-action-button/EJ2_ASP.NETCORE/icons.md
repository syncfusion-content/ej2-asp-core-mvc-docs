---
layout: post
title: Icons in ##Platform_Name## Floating Action Button Control | Syncfusion
description: Learn here all about Icons in Syncfusion ##Platform_Name## Floating Action Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Icons
publishingplatform: ##Platform_Name##
documentation: ug
---

# Icons in Asp.Net Core Floating Action Button Control

You can customize the icon and text of Asp.Net Core Floating Action Button(FAB) using [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_IconCss) and [Content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Content) properties.

## FAB with Icon

You can show icon only in Floating Action Button by setting [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_IconCss) property. You can show tooltip on hover to show additional details to end-user by setting `Title` attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/iconsonly/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Floating Action Button with Icon](images/FabWithIcon.png)

## FAB with Icon and Text

You can show icon along with text in Floating Action Button by setting [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_IconCss) and [Content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Content) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/iconswithtext/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Floating Action Button with Text and Icon](images/IconandText.png)

### Icon Position

You can change the position of icon when showing along with content by setting [IconPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_IconPosition ) property. By default, the icon is positioned on the left side together with text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/icon-position/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Floating Action Button with Icon Position](images/IconPosition.png)