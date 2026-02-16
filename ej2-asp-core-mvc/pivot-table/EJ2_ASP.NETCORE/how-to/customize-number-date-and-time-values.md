---
layout: post
title: Customize Number Date And Time Values in ASP.NET Core | Syncfusion
description: Learn here all about Customize Number Date And Time Values in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Customize Number Date And Time Values
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize number, date, and time values

You can format the number, date, and time values for each field using the [`e-formatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSettings.html) option under [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html). This configuration is applied during component initialization to ensure consistent data presentation across the pivot table.

## Number formatting

For numeric fields, the formatting settings include the following properties:

* `name`: Specifies the field name to which the formatting should be applied.
* `format`: Defines the number format pattern for the respective field (e.g., 'N2' for two decimal places, 'C' for currency).

> Also, you can customize the applied number format by setting the [`numberFormatOptions`](https://ej2.syncfusion.com/documentation/common/intl.html?lang=typescript#manipulating-numbers) options in [`e-formatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSettings.html) itself.

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

For date and time fields, the formatting settings include these properties:

* `name`: Specifies the field name to which the formatting should be applied.
* `format`: Defines the date/time format pattern for the respective field (e.g., 'dd/MM/yyyy', 'MMM yyyy').
* `type`: Specifies the format type to be used for the respective field (Date, Time, or DateTime).

> Also, you can customize the applied date format by setting [`DateFormatOptions`](https://ej2.syncfusion.com/documentation/common/intl.html?lang=typescript#manipulating-datetime) options in [`e-formatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSettings.html) itself.

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