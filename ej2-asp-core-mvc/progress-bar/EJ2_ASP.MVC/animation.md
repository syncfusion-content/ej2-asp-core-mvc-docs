---
layout: post
title: Animation in ##Platform_Name## Progress Bar Component
description: Learn here all about Animation in Syncfusion ##Platform_Name## Progress Bar component and more.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Animation

<!-- markdownlint-disable MD033 -->

Progress Bar support to animate the progress by using `Animation` property. Enable the animation by setting **Enable** property and also you can control the speed by using **Duration** property.

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

