---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Internationalization of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
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

{% aspTab template="chart/number-format", sourceFiles="number-format.cs" %}

{% endaspTab %}