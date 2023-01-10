---
layout: post
title: Enable Ripple in ##Platform_Name## Button Group Control | Syncfusion
description: Learn here all about how to enable Ripple in Syncfusion ##Platform_Name## Button Group control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Enable Ripple
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable ripple in Button Group Control

Ripple can be enabled by importing `rippleEffect` method from `ej2-base` and initialize rippleEffect with `.e-btn-group` element, and selector as `e-btn`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/ripple/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/ripple/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/ripple/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ButtonGroup/ButtonGroupHowToSample).