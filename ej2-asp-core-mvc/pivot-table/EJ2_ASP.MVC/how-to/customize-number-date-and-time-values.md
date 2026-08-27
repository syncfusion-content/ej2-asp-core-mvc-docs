---
layout: post
title: How to customize number and date values in Pivot Table | Syncfusion
description: Step-by-step example showing how to customize number and date values in the ASP.NET MVC Pivot Table using FormatSettings and culture.

platform: ej2-asp-core-mvc
control: Customize Number Date And Time Values
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize number and date values in ASP.NET MVC Pivot Table

You can format the number, date, and time values for each field using the [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSettings.html) option under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html). This configuration is applied during component initialization to ensure consistent data presentation across the pivot table.

## Number formatting

For numeric fields, the formatting settings include the following properties:

* `name`: Specifies the field name to which the formatting should be applied.
* `format`: Defines the number format pattern for the respective field (e.g., 'N2' for two decimal places, 'C' for currency).

> Also, you can customize the applied number format by setting the [`NumberFormatOptions`](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization#number-formatting) options in [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSettings.html) itself.

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



## Date and Time formatting

For date and time fields, the formatting settings include these properties:

* `name`: Specifies the field name to which the formatting should be applied.
* `format`: Defines the date/time format pattern for the respective field (e.g., 'dd/MM/yyyy', 'MMM yyyy').
* `type`: Specifies the format type to be used for the respective field (Date, Time, or DateTime).

> Also, you can customize the applied date format by setting [`DateFormatOptions`](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization#manipulating-datetime) options in [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSettings.html) itself.

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

According to Firefox and Edge browser standards, most date and time formats used in data sources are not supported. For example: Apr-2000, Apr-01-2000, 01-03-2000, 2000-Apr-01 and similar formats are not recognized. However, [`ISO formats`](https://262.ecma-international.org/5.1/#sec-15.9.1.15) are supported across all browsers for consistent date handling.