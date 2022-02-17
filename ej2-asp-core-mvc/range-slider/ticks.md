---
layout: post
title: Ticks in ##Platform_Name## Range Slider Component
description: Learn here all about Ticks in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Ticks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Ticks

The Ticks in Slider supports you to easily identify the current value/values of the Slider. It contains `smallStep` and `largeStep`. The value of the major ticks alone will be displayed in the slider. In order to enable/disable the small ticks, use the `showSmallTicks` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/ticks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ticks.cs" %}
{% include code-snippet/slider/ticks/ticks.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/ticks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ticks.cs" %}
{% include code-snippet/slider/ticks/ticks.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Ticks](./images/slider-ticks.png)

## Step

When the Slider is moved, it increases/decreases the value based on the step value. By default, the value is increased/decreased by 1. Use the `step` property to change the increment step value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/step/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Step.cs" %}
{% include code-snippet/slider/step/step.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/step/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Step.cs" %}
{% include code-snippet/slider/step/step.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Step](./images/slider-ticks.png)

## Min and Max

Enables the minimum/starting and maximum/ending value of the Slider, by using the `min` and `max` property. By default, the minimum value is 1 and maximum value is 100. In the following sample the slider is rendered with the min value as 100 and max value as 1000.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/min-max/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Min-max.cs" %}
{% include code-snippet/slider/min-max/min-max.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/min-max/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Min-max.cs" %}
{% include code-snippet/slider/min-max/min-max.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Min and Max](./images/slider-min-max.png)
