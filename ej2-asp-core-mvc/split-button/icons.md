---
layout: post
title: Icons in ##Platform_Name## Split Button Component
description: Learn here all about Icons in Syncfusion ##Platform_Name## Split Button component and more.
platform: ej2-asp-core-mvc
control: Icons
publishingplatform: ##Platform_Name##
documentation: ug
---


# Icons

## SplitButton Icons

SplitButton can have an icon to provide the visual representation of the action. To place the icon on a SplitButton,
set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_IconCss) property to `e-icons` with the required icon CSS. By default, the icon is positioned to the left side of the SplitButton. You can customize the icon's position by using the [`iconPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_IconPosition) property

The following example illustrates how to place icon in SplitButton component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/icons/icon-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Iconbutton.cs" %}
{% include code-snippet/split-button/icons/icon-btn/iconbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/icons/icon-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Iconbutton.cs" %}
{% include code-snippet/split-button/icons/icon-btn/iconbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The Essential JS 2 provides a set of icons that can be loaded by applying `e-icons` class name to the element.
You can also use third party icons on the SplitButton using the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_IconCss) property.

## Vertical Button

Vertical Button in SplitButton can be achieved by adding `e-vertical` class using [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_CssClass) property.

The following example illustrates how to vertical support in SplitButton component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/icons/vertical-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Verticalbutton.cs" %}
{% include code-snippet/split-button/icons/vertical-btn/verticalbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/icons/vertical-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Verticalbutton.cs" %}
{% include code-snippet/split-button/icons/vertical-btn/verticalbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [SplitButton popup with icons](./popup-items#icons)
