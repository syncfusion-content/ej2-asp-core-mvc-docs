---
layout: post
title: Globalization in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Globalization in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Globalization in ##Platform_Name## Stepper control

## Localization

The Localization library allows you to localize `optional` property of the Stepper. Optional property of the Stepper control can be changed to other cultures (Arabic, Deutsch, French, etc.) by defining the `locale` value and translation object. In the below sample, `French` culture is set to Stepper and changed the optional property text.

Locale key |en-US (default)
-----|-----
optional | Optional

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/localization/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Localization](images/stepper-locale.jpg)

## RTL

RTL provides an option to switch the text direction and layout of the Stepper control from right to left by setting the [enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_EnableRtl) property to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/rtl/razor %}
{% endhighlight %}
{% endtabs %}