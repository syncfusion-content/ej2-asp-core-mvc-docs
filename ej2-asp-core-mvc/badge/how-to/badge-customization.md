---
layout: post
title: Badge Customization in ##Platform_Name## Badge control | Syncfusion
description: Learn here all about Badge Customization in Syncfusion ##Platform_Name## Badge control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Badge Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customization in ##Platform_Name## Badge Control

## Color customization

Even though Badges come with `8 predefined colors`, you can also customize the color of the Badge as desired.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/color/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/color/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Color Customization](../images/colorcustom.PNG)

## Customize Badge size

Badges are designed to change its size based on the content. To change the size of a Badge, adjust the `font size` of the Badge.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/size/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/size/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Size Customization](../images/badgecustom.PNG)

## Custom position

Even though the Badges support the conventional `top` and `bottom` positions, the position of the Badges can be changed as desired. This can be done by adding a custom class to the Badge element to override the default position applied from the source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/custom-position/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/custom-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/custom-position/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Badge Position](../images/custompos.PNG)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Badge/BadgeCustomSample).