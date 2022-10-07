---
layout: post
title: Icons in ##Platform_Name## FloatingActionButton Component
description: Learn here all about Icons in Syncfusion ##Platform_Name## FloatingActionButton component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Icons
publishingplatform: ##Platform_Name##
documentation: ug
---

# Icons in Asp.Net MVC Floating Action Button Component

## Icon types

The types of Floating Action Button Icons are as follows:

* Icon Only
* Icon with Text
* Text Only

## Floating Action Button with Icon Only

Use iconCss property to display icon. Floating Action Button can have an icon to provide the visual representation of the action. To place the icon on a Floating Action Button, set the [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_IconCss) property to `e-icons` with the required icon CSS.

In the following example, Floating Action Button is demonstrated with only icons by providing the IconCss property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/iconsonly/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/iconsonly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabIcon.cs" %}
{% include code-snippet/floating-action-button/icons/iconsonly/fabicon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net MVC Floating Action Button with Icon only](images/text-only.png)

## Floating Action Button with Icon and Text

Use [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Content) property and [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_IconCss) property to display the icon and text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/iconswithtext/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/iconswithtext/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabTextIcon.cs" %}
{% include code-snippet/floating-action-button/icons/iconswithtext/fabtexticon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net MVC Floating Action Button with Icon and Text](images/text-only.png)

## Floating Action Button with Text Only

Use [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Fab.html#Syncfusion_EJ2_Buttons_Fab_Content) property to display the text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/textonly/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/icons/textonly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabText.cs" %}
{% include code-snippet/floating-action-button/icons/textonly/fabtext.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net MVC Floating Action Button with Text only](images/text-only.png)