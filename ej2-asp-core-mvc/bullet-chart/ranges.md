---
layout: post
title: Ranges in ##Platform_Name## Bullet Chart Component
description: Learn here all about Ranges in Syncfusion ##Platform_Name## Bullet Chart component and more.
platform: ej2-asp-core-mvc
control: Ranges
publishingplatform: ##Platform_Name##
documentation: ug
---


# Ranges

Ranges represent the quality of a specific range such as **Good**, **Bad** and **Satisfactory** in the Bullet Chart scale. The ending point of a qualitative range is specified in the `end` property in `ranges`. The `minimum` value of a quantitative scale is considered the starting point of the first range or the previous range end point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/ranges/ranges/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/bullet-chart/ranges/ranges/ranges.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/ranges/ranges/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/bullet-chart/ranges/ranges/ranges.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Ranges in Bullet Chart](images/blazor-bullet-chart-range.png)

## Color Customization

Enhance the readability of ranges with color and opacity. It can be applied using the `color` and `opacity` properties in `ranges`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/ranges/ranges-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges-custom.cs" %}
{% include code-snippet/bullet-chart/ranges/ranges-custom/ranges-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/ranges/ranges-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges-custom.cs" %}
{% include code-snippet/bullet-chart/ranges/ranges-custom/ranges-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Customizing Ranges with Color in Bullet Chart](images/blazor-bullet-chart-range-customization.png)