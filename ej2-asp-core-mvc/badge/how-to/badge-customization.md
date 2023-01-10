---
layout: post
title: Badge Customization in ##Platform_Name## Badge Component
description: Learn here all about Badge Customization in Syncfusion ##Platform_Name## Badge component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Badge Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customization in ##Platform_Name## Badge Control

## Colour customization

Even though badges come with `8 predefined colors`, you can also customize the colour of the badge as desired.

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

## Customize badge size

Badges are designed to change its size based on the content. To change the size of a badge, adjust the `font size` of the badge.

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

Even though the badges support the conventional `top` and `bottom` positions, the position of the badges can be changed as desired. This can be done by adding a custom class to the badge element to override the default position applied from the source.

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