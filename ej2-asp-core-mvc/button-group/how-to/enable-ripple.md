---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Enable Ripple of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Enable Ripple
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable ripple

Ripple can be enabled by importing `rippleEffect` method from `ej2-base` and initialize rippleEffect with `.e-btn-group`
element, and selector as `e-btn`.

The following example illustrates how to enable ripple for ButtonGroup.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/ripple/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/ripple/demo/default.cs %}
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

