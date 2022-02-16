---
layout: post
title: Internationalization in ##Platform_Name## Circular Gauge Component
description: Learn here all about Internationalization in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Internationalization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Internationalization

Circular gauge provide supports for internationalization for below gauge elements.

* Axis label.
* Tooltip.

For more information about number formatter you can refer
[`internationalization`](http://ej2.syncfusion.com/aspnet/documentation/base/intl.html).

<!-- markdownlint-disable MD036 -->
**Globalization**

Globalization is the process of designing and developing a component that works in different cultures/locales.
Internationalization library is used to globalize number in CircularGauge component
using [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Format) property in [`labelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html).

<!-- markdownlint-disable MD036 -->
**Numeric Format**

In the below example axis labels are `globalized` to EUR.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/internationalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Internationalization.cs" %}
{% include code-snippet/circulargauge/internationalization/internationalization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/internationalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Internationalization.cs" %}
{% include code-snippet/circulargauge/internationalization/internationalization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

