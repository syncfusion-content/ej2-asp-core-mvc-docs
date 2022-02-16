---
layout: post
title: Internationalization in ##Platform_Name## Linear Gauge Component
description: Learn here all about Internationalization in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Internationalization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Internationalization in ASP.NET MVC Linear Gauge

Globalization is the process of designing and developing a component that works in different cultures. Internationalization is used to globalize the number content in Linear Gauge component using [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGauge.html#Syncfusion_EJ2_LinearGauge_LinearGauge_Format) property in Linear Gauge. It has static text on some features such as

* Axis label
* Tooltip

The static text on above features can be changed to any culture such as Arabic, Deutsch and French. To know more about the globalization in ASP.NET MVC components, refer [here](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization/).

## Numeric Format

The text in axis labels and tooltip can be displayed in the numeric format such as currency, percentage and so on. To know more about the numeric formats in axis labels, refer [here](axis/#displaying-numeric-format-in-labels). In the below example, the axis label is displayed in the currency format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/internationalization/internationalization/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/internationalization/internationalization/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Linear Gauge with currency label format](../linear-gauge/images/custom-label.png)