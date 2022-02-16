---
layout: post
title: Icons in ##Platform_Name## Drop Down Button Component
description: Learn here all about Icons in Syncfusion ##Platform_Name## Drop Down Button component and more.
platform: ej2-asp-core-mvc
control: Icons
publishingplatform: ##Platform_Name##
documentation: ug
---


# Icons and Styles

## DropDownButton icons

DropDownButton can have an icon to provide the visual representation of the action. To place the icon on a DropDownButton,
set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconCss) property to `e-icons` with the required icon CSS. By default,
the icon is positioned to the left side of the DropDownButton. You can customize the icon's position using
the [`iconPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconPosition) property.

In the following example, the DropDownButton with default iconPosition and iconPosition as `Top` is showcased:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/icons/icon-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Iconbutton.cs" %}
{% include code-snippet/dropdownbutton/icons/icon-btn/iconbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/icons/icon-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Iconbutton.cs" %}
{% include code-snippet/dropdownbutton/icons/icon-btn/iconbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The Essential JS 2 provides a set of icons that can be loaded by applying `e-icons` class name to the element.
You can also use third party icons on the DropDownButton using the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconCss) property.

### Vertical button

Vertical button in DropDownButton can be achieved by adding `e-vertical` class using [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_CssClass) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/icons/vertical-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Verticalbutton.cs" %}
{% include code-snippet/dropdownbutton/icons/vertical-btn/verticalbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/icons/vertical-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Verticalbutton.cs" %}
{% include code-snippet/dropdownbutton/icons/vertical-btn/verticalbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Dropdown popup with icons](./popup-items#icons)
* [Customized icon size](./how-to/customize-icon-and-width)