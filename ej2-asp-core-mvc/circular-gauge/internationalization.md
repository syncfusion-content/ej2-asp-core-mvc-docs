---
layout: post
title: Internationalization in ##Platform_Name## Circular Gauge Control | Syncfusion
description: Learn here all about Internationalization in Syncfusion ##Platform_Name## Circular Gauge control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Internationalization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Internationalization in Circular Gauge Control

Circular Gauge provides support for internationalization for the following gauge elements.

* Axis Labels
* Tooltip

For more information about number formatter, you can refer [internationalization](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization).
## Globalization

{% if page.publishingplatform == "aspnet-core" %}

Globalization is the process of designing and developing a component that works in different cultures/locales. Internationalization library is used to globalize number in CircularGauge component using [format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Format) property in [labelStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html).

<!-- markdownlint-disable MD036 -->
**Numeric Format**

In the below example axis labels are `globalized` to **EUR**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/internationalization/tagHelper %}
{% endhighlight %}
{% endtabs %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/CircularGauge/PrintandExportSample).

{% elsif page.publishingplatform == "aspnet-mvc" %}

Globalization is the process of designing and developing a component that works in different cultures/locales. Internationalization library is used to globalize number in CircularGauge component using [Format](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Format) property in [LabelStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html).

<!-- markdownlint-disable MD036 -->
**Numeric Format**

In the below example axis labels are `globalized` to **EUR**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/internationalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Internationalization.cs" %}
{% include code-snippet/circulargauge/internationalization/internationalization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Right-to-left

{% if page.publishingplatform == "aspnet-core" %}

Circular Gauge can render its elements from right to left, which improves the user experience for certain language users. To do so, set the [enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_EnableRtl) property to **true**. When this property is enabled, elements such as the tooltip and legend will be rendered from right to left. Meanwhile, the axis can be rendered from right to left by setting the [direction](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Direction) property to **AntiClockWise**. For more information on axis, click [here](https://ej2.syncfusion.com/aspnetcore/documentation/circular-gauge/gauge-axes#angles-and-direction).

The following example illustrates the right to left rendering of the Circular Gauge.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/rtl/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Circular Gauge can render its elements from right to left, which improves the user experience for certain language users. To do so, set the [EnableRtl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_EnableRtl) property to **true**. When this property is enabled, elements such as the tooltip and legend will be rendered from right to left. Meanwhile, the axis can be rendered from right to left by setting the [Direction](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Direction) property to **AntiClockWise**. For more information on axis, click [here](https://ej2.syncfusion.com/aspnetmvc/documentation/circular-gauge/gauge-axes#angles-and-direction).

The following example illustrates the right to left rendering of the Circular Gauge.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/circulargauge/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}