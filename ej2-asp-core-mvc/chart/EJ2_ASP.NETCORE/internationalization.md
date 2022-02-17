---
layout: post
title: Internationalization in ##Platform_Name## Chart Component
description: Learn here all about Internationalization in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Internationalization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Internationalization

Chart provide supports for internationalization for below chart elements.

* Datalabel.
* Axis label.
* Tooltip.

For more information about number and date formatter you can refer
[`internationalization`](http://ej2.syncfusion.com/documentation/base/intl.html).

<!-- markdownlint-disable MD036 -->
**Globalization**

Globalization is the process of designing and developing an component that works in different
cultures/locales.  Internationalization  library is used to globalize number, date, time values in
Chart component using  `labelFormat` property in axis.

**Numeric Format**

In the below example axis, point  and tooltip labels are globalized to EUR.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/number-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Number-format.cs" %}
{% include code-snippet/chart/number-format/number-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/number-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Number-format.cs" %}
{% include code-snippet/chart/number-format/number-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

