---
layout: post
title: Customization in ##Platform_Name## Chips Control | Syncfusion
description: Learn here all about Customization in Syncfusion ##Platform_Name## Chips control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Chips Customization in Chips Control

This section explains the customization of styles, leading icons, avatars, and trailing icons in the Chips control.

## Styles

{% if page.publishingplatform == "aspnet-core" %}

The Chips control has the following predefined styles that can be defined using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_CssClass) property.

| Class | Description |
| -------- | -------- |
| e-primary | Represents a primary Chips. |
| e-success | Represents a positive Chips. |
| e-info |  Represents an informative Chips. |
| e-warning | Represents a Chips with caution. |
| e-danger | Represents a negative Chips. |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/styles/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The Chips control has the following predefined styles that can be defined using the [`cssClass`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_CssClass) property.

| Class | Description |
| -------- | -------- |
| e-primary | Represents a primary Chips. |
| e-success | Represents a positive Chips. |
| e-info |  Represents an informative Chips. |
| e-warning | Represents a Chips with caution. |
| e-danger | Represents a negative Chips. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/styles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/styles/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Styles Chips Control](images/styles.png)

## Leading Icon

{% if page.publishingplatform == "aspnet-core" %}

You can add and customize the leading icon of Chips using the [`leadingIconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_LeadingIconCss) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/leadingIcon/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can add and customize the leading icon of Chips using the [`leadingIconCss`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_LeadingIconCss) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/leadingIcon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/leadingIcon/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Leading Icon Chips Control](images/leading-icon.png)

## Avatar

{% if page.publishingplatform == "aspnet-core" %}

You can add and customize the avatar of Chips using the [`avatarIconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_AvatarIconCss) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/avatar/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can add and customize the avatar of Chips using the [`avatarIconCss`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_AvatarIconCss) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/avatar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/avatar/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Avatar Chips Control](images/avatar.png)

## Avatar Content

{% if page.publishingplatform == "aspnet-core" %}

You can add and customize the avatar content of Chips using the [`avatarText`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_AvatarText) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/avatarText/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can add and customize the avatar content of Chips using the [`avatarText`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_AvatarText) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/avatarText/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/avatarText/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Avatar content Chips Control](images/avatar-content.png)

## Trailing Icon

{% if page.publishingplatform == "aspnet-core" %}

You can add and customize the trailing icon of Chips using the [`trailingIconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_TrailingIconCss) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/trailing/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can add and customize the trailing icon of Chips using the [`trailingIconCss`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_TrailingIconCss) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/trailing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/trailing/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Outline Chips

{% if page.publishingplatform == "aspnet-core" %}

Outline Chips have a border with a transparent background. It can be set using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_CssClass) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/outline/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Outline Chips have a border with a transparent background. It can be set using the [`cssClass`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_CssClass) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/outline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/outline/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Outline Chips Control](images/outline-chip.png)

## Template

{% if page.publishingplatform == "aspnet-core" %}

The [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_Template) property of the Chips control allows users to fully customize the layout and design of each Chips. By using the `Template` property, users can include custom HTML elements such as links, icons, or additional content.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/template/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.buttons.chiplist.html#Syncfusion_EJ2_Buttons_ChipList_Template) property of the Chips control allows users to fully customize the layout and design of each Chips. By using the `Template` property, users can include custom HTML elements such as links, icons, or additional content.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET template Chips Control](images/template.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Chips/ChipsSample).
