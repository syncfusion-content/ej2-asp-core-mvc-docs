---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Date Range Slider of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Date Range Slider
publishingplatform: ##Platform_Name##
documentation: ug
---

# Date Range Slider

The Date formatting can be achieved in `ticks` and `tooltip` using `renderingTicks` and `tooltipChange` events respectively. The process of formatting is explained in the below sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/date-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/slider/date-format/date-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/date-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/slider/date-format/date-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Date - Format](../images/slider-date-format.png)
