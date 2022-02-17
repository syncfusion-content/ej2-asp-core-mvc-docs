---
layout: post
title: Enable Ripple For Switch Label in ##Platform_Name## Switch Component
description: Learn here all about Enable Ripple For Switch Label in Syncfusion ##Platform_Name## Switch component and more.
platform: ej2-asp-core-mvc
control: Enable Ripple For Switch Label
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable ripple for Switch label

By default, label with ripple effect is not available in Switch. You can achieve this using `rippleMouseHandler`
method. The following example illustrates how to enable ripple effect for labels in Switch component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/switch/ripple/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/ripple/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/switch/ripple/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/ripple/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

