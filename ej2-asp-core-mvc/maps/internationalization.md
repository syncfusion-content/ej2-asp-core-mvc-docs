---
layout: post
title: Internationalization in ##Platform_Name## Maps Component
description: Learn here all about Internationalization in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Internationalization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Internationalization

Maps provide support for internationalization for the below elements.

* Data label
* Tooltip

For more information about number and date formatter, refer to the
[`internationalization`](http://ej2.syncfusion.com/documentation/base/intl.html) section.

<!-- markdownlint-disable MD036 -->

## Globalization

Globalization is the process of designing and developing a component that works in different
cultures/locales. Internationalization library is used to globalize number, date, time values in
Maps component using `Format` property in the `Maps`.

## Numeric format

The numeric formats such as currency, percentage and so on can be displayed in the tooltip and data labels of the Maps using the `Format` property in the `Maps`. In the below example, the tooltip is globalized to **German** culture. When setting the `UseGroupingSeparator` property as **true**, the numeric text in the Maps separates with the comma separator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/Internationalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Internationalization.cs" %}
{% include code-snippet/maps/Internationalization/internationalization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/Internationalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Internationalization.cs" %}
{% include code-snippet/maps/Internationalization/internationalization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Internationalization](./images/Internationalization/internationalization.PNG)