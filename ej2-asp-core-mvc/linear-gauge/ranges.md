---
layout: post
title: Ranges in ##Platform_Name## Linear Gauge Component
description: Learn here all about Ranges in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Ranges
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ranges

You can categorize the axis values using [`start`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~Start.html) and [`end`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~End.html) property in the [`ranges`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange.html). You can add any number of range for an axis by using array of range objects.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/ranges/ranges/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/lineargauge/ranges/ranges/ranges.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/ranges/ranges/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/lineargauge/ranges/ranges/ranges.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Ranges Customization

Ranges can be customized using the following properties.

* [`startWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~StartWidth.html) - Specifies start width of the range
* [`endWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~EndWidth.html) - Specifies end width of the range
* [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeRange~Color.html) - Specifies color of the range
* `position` - Specifies the range bar position. Its possible values are 'inside' and 'outside'
* `Offset` - Specifies offset value from its default position
* `LinearGaugeRangeBorder` - Specifies range bar border color and width.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/ranges/range-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range-customization.cs" %}
{% include code-snippet/lineargauge/ranges/range-customization/range-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/ranges/range-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range-customization.cs" %}
{% include code-snippet/lineargauge/ranges/range-customization/range-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Ranges

You can add multiple ranges to an axis as demonstrated below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/ranges/multiple-ranges/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-ranges.cs" %}
{% include code-snippet/lineargauge/ranges/multiple-ranges/multiple-ranges.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/ranges/multiple-ranges/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-ranges.cs" %}
{% include code-snippet/lineargauge/ranges/multiple-ranges/multiple-ranges.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

