---
layout: post
title: Animation in ##Platform_Name## Progress Bar Component
description: Learn here all about Animation in Syncfusion ##Platform_Name## Progress Bar component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Animation

<!-- markdownlint-disable MD033 -->

Progress Bar support to animate the progress by using `animation` property. Enable the animation by setting **enable** property and also you can control the speed by using **duration** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/animation/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/animation/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

