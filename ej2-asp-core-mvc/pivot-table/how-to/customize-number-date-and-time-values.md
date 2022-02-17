---
layout: post
title: Customize Number Date And Time Values in ##Platform_Name## Pivot Table Component
description: Learn here all about Customize Number Date And Time Values in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Customize Number Date And Time Values
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize number, date, and time values

You can format the number, date, and time values for each field using `formatSettings` option under `dataSourceSettings`. It can be configured through code behind, during initial rendering.

## Number formatting

For numbers, the formatting settings required to apply through code behind are:

* `name`: It allows to set the field name.
* `format`: It allows to set the format of the respective field.

> Also, you can customize the applied number format by setting the [`NumberFormatOptions`](https://ej2.syncfusion.com/documentation/common/intl.html?lang=typescript#manipulating-numbers) options in `formatSettings` itself.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/formatting/number/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Number.cs" %}
{% include code-snippet/pivot-table/formatting/number/Number.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/formatting/number/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Number.cs" %}
{% include code-snippet/pivot-table/formatting/number/Number.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Date and time formatting

> This property is applicable only for relational data source.

For date and time, the formatting settings required to apply through code behind are:

* `name`: It allows to set the field name.
* `format`: It allows to set the format of the respective field.
* `type`: It allows to set the type of format to be used for the respective field.

> Also, you can customize the applied date format by setting [`DateFormatOptions`](https://ej2.syncfusion.com/documentation/common/intl.html?lang=typescript#manipulating-datetime) options in `formatSettings` itself.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/formatting/date/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date.cs" %}
{% include code-snippet/pivot-table/formatting/date/Date.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/formatting/date/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date.cs" %}
{% include code-snippet/pivot-table/formatting/date/Date.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations of date formatting

As per Firefox and Edge browsers standards, most of the date and time formats used in data source aren’t supported. For example: Apr-2000, Apr-01-2000, 01-03-2000, 2000-Apr-01 etc... are not supported. Meanwhile [`ISO formats`](http://www.ecma-international.org/ecma-262/5.1/#sec-15.9.1.15) will be supported across all browsers.