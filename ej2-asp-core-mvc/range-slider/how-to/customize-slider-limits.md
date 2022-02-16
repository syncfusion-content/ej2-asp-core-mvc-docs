---
layout: post
title: Customize Slider Limits in ##Platform_Name## Range Slider Component
description: Learn here all about Customize Slider Limits in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Customize Slider Limits
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize Slider Limits

Slider appearance can be customized via CSS. By overriding the slider CSS classes, the slider limit bar can be customized.
Here, the limit bar is customized with different background color. By default, the slider has class `e-limits` for limits bar.
You can override the class with our own color values as given in the following code snippet.

```css
.e-slider-container.e-horizontal .e-limits {
    background-color: rgba(69, 100, 233, 0.46);
}
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/custom-limits/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-limits.cs" %}
{% include code-snippet/slider/custom-limits/custom-limits.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/custom-limits/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-limits.cs" %}
{% include code-snippet/slider/custom-limits/custom-limits.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Limit Customization](../images/limit-customization.png)