---
layout: post
title: Internationalization in ##Platform_Name## Treemap Component
description: Learn here all about Internationalization in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: Internationalization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Internationalization

The TreeMap control supports internationalization for the following elements:

* Data label
* Tooltip

For more information about number and date formatter, refer to [`internationalization`](http://ej2.syncfusion.com/documentation/base/intl.html).

<!-- markdownlint-disable MD036 -->

## Globalization

Globalization is the process of designing and developing a component that works in different cultures/locales. Internationalization library is used to globalize number, date, and time values in the tree map control using the `format` property in the Treemap.

**Numeric format**

In the following code example, tooltip is globalized to Deutsch culture.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/internationalization/internationalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Internationlization.cs" %}
{% include code-snippet/treemap/internationalization/internationalization/internationalization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/internationalization/internationalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Internationlization.cs" %}
{% include code-snippet/treemap/internationalization/internationalization/internationalization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

