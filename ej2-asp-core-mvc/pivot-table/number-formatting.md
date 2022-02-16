---
layout: post
title: Number Formatting in ##Platform_Name## Pivot Table Component
description: Learn here all about Number Formatting in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Number Formatting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Number Formatting

Allows you to specify the required display format that should be used in values of the pivot table. Supported display formats are:

* Number
* Currency
* Percentage
* Custom

You can apply format for the numeric values using the following properties in the [`formatSettings`](https://ej2.syncfusion.com/documentation/api/pivotview/dataSourceSettings/#formatsettings).

* [`name`](https://ej2.syncfusion.com/documentation/api/pivotview/formatSettingsModel/#name): It allows to specify the field name.
* [`format`](https://ej2.syncfusion.com/documentation/api/pivotview/formatSettingsModel/#format): It allows to specify the format of the respective field.

Possible formatting values are:

1. N - denotes numeric type.
2. C - denotes currency type.
3. P - denotes percentage type.

> If no format is specified it takes number as default format type.

Other properties include:

* [`useGrouping`](https://ej2.syncfusion.com/documentation/api/pivotview/formatSettingsModel/#usegrouping): It allows to enable or disable the separator, for example, $100,000,000 or $100000000 respectively. By default, it will be set as **true**.
* [`currency`](https://ej2.syncfusion.com/documentation/api/pivotview/formatSettingsModel/#currency): It allows to set the currency code which needs to considered for the currency formatting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/code-behind/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/code-behind/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/code-behind/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/code-behind/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



You can also format the values at runtime using the formatting dialog. This option can be enabled by setting the [`allowNumberFormatting`](https://ej2.syncfusion.com/documentation/api/pivotview/#allownumberformatting) property to **true**. The same has been discussed in some of the upcoming topics.

> To use the formatting dialog, inject the `NumberFormatting` module into the pivot table.

## Custom format

You can add any custom format directly to the [`format`](https://ej2.syncfusion.com/documentation/api/pivotview/formatSettingsModel/#format) property in the [`formatSettings`](https://ej2.syncfusion.com/documentation/api/pivotview/dataSourceSettings/#formatsettings). Custom format can be achieved by using one or more format specifiers listed in the below table.

| Specifier | Description | Input | Format Output |
| ------- |--------------- | ---------------- | --------------- |
| 0 | Replaces the zero with the corresponding digit if it is present. Otherwise, zero will appear in the result string. | { format: '0000' } | '0123' |
| # | Replaces the ' # ' symbol with the corresponding digit if it is present. Otherwise, no digits will appear in the result string.| { format: '####' } | '1234' |
| . | Denotes the number of digits permitted after the decimal point. | { format: '###0.##0#' } | '546321.000' |
| % | Percent specifier denotes the percentage type format. | { format: '0000 %' } | '0100 %' |
| $ | Denotes the currency type format that is based on the global currency code specified. | { format: '$ ###.00' } | '$ 13.00' |
| ; | Denotes separate formats for positive, negative and zero values. | { format: '###.##;(###.00);-0' } | '(120.00)'    |
| 'String' (single Quotes) | Denotes the characters that are enclosed in the single quote (') to be replaced in the resulting string. | { format: "####.00 '@'" } | "123.00 @"    |

> If custom format is defined, certain properties such as [`useGrouping`](https://ej2.syncfusion.com/documentation/api/pivotview/formatSettingsModel/#usegrouping) and [`currency`](https://ej2.syncfusion.com/documentation/api/pivotview/formatSettingsModel/#currency) will not be considered.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/custom/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/custom/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Toolbar

You can enable formatting dialog option in the toolbar by adding `NumberFormatting` in the [`toolbar`](../../api/pivotview/#toolbar). After that, you can see the option to invoke the formatting dialog in the toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/toolbar/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/toolbar/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Invoking formatting dialog through external button

You can invoke the formatting dialog by clicking an external button using the `ShowNumberFormattingDialog` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/button/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/button/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/button/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/button/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Customize number, date, and time values](./how-to/customize-number-date-and-time-values.md)
* [NumberFormatOptions](https://ej2.syncfusion.com/documentation/common/intl.html?lang=typescript#manipulating-numbers)
* [Toolbar](./tool-bar)