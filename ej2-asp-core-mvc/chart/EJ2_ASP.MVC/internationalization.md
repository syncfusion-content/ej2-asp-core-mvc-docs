---
layout: post
title: Internationalization in ##Platform_Name## Chart Component
description: Learn here all about Internationalization in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Internationalization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Internationalization

Chart provides support for internationalization for the following elements:

- Data label
- Axis label
- Tooltip

For more information about number and date formatting, see the internationalization guide: [`internationalization`](http://ej2.syncfusion.com/documentation/base/intl.html).

<!-- markdownlint-disable MD036 -->
**Globalization**

Globalization is the process of designing and developing a component that works in different cultures/locales. Use the internationalization library to localize numbers, dates, and times in the Chart component, for example by using the axis `LabelFormat` property.

**Numeric Format**

The example below globalizes axis, point, and tooltip labels to the EUR currency format.

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

