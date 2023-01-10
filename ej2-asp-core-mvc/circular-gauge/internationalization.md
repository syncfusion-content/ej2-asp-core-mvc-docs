---
layout: post
title: Internationalization in ASP.NET MVC Circular Gauge Control | Syncfusion
description: Learn here all about Internationalization in Syncfusion ASP.NET MVC Circular Gauge control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Internationalization
publishingplatform: ej2-asp-core-mvc
documentation: ug
---

# Internationalization in Circular Gauge Control

[ASP.NET MVC Circular Gauge](https://www.syncfusion.com/aspnet-mvc-ui-controls/circular-gauge) provides support for internationalization for the following gauge elements.

* Axis label.
* Tooltip.

For more information about number formatter, you can refer [internationalization](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization).

<!-- markdownlint-disable MD036 -->
**Globalization**

Globalization is the process of designing and developing a component that works in different cultures/locales. Internationalization library is used to globalize number in CircularGauge component using [format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Format) property in [labelStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html).

<!-- markdownlint-disable MD036 -->
**Numeric Format**

In the below example axis labels are `globalized` to EUR.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/internationalization/tagHelper %}
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

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/CircularGauge/PrintandExportSample).