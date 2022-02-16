---
layout: post
title: Show Slider From Hidden State in ##Platform_Name## Range Slider Component
description: Learn here all about Show Slider From Hidden State in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Show Slider From Hidden State
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show Slider from Hidden State

This section demonstrates how-to render the Slider component in hidden state and make it visible in button click. We can initialize Slider in hidden state by setting display as none to it.

In the sample, by clicking on the button, we can make the Slider visible from hidden state, and we must also call the `refresh` method of the Slider to render it properly based on its original dimensions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/hidden-slider/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hidden-slider.cs" %}
{% include code-snippet/slider/hidden-slider/hidden-slider.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/hidden-slider/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hidden-slider.cs" %}
{% include code-snippet/slider/hidden-slider/hidden-slider.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Hidden - Slider](../images/hidden-slider.png)