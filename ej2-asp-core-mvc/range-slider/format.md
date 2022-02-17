---
layout: post
title: Format in ##Platform_Name## Range Slider Component
description: Learn here all about Format in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Formatting

The `format` feature used to customize the units of Slider values to desired format. The formatted values will also be applied to the ARIA attributes of the slider. There are two ways of achieving formatting in slider.

* Use the [format](https://ej2.syncfusion.com/documentation/slider/api-tooltipData.html?lang=es5#format) API of slider which utilizes our [Internationalization](https://ej2.syncfusion.com/16.1.37/documentation/base/intl.html?lang=es5#loading-culture-data) to format values.

* Customize using the events namely `renderingTicks` and `tooltipChange`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/slider/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/slider/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Format](./images/slider-format.png)

## Using format API

In this method, we have different predefined formatting styles like Numeric (N), Percentage (P), Currency (C) and # specifiers. In this below example we have formatted the ticks and tooltip values into percentage.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/format-api/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format-api.cs" %}
{% include code-snippet/slider/format-api/format-api.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/format-api/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format-api.cs" %}
{% include code-snippet/slider/format-api/format-api.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Format API](./images/slider-format-api.png)

## Using Events

In this method, we will be retrieving the values from the slider events then process them to desired formatted the values. In this sample we have customized the ticks values into weekdays as one formatting and tooltip values into day of the week as another formatting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/events/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Events.cs" %}
{% include code-snippet/slider/events/events.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Events.cs" %}
{% include code-snippet/slider/events/events.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Events](./images/slider-events.png)