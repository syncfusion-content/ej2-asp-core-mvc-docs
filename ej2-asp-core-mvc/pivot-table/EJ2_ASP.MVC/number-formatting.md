---
layout: post
title: Number Formatting in ##Platform_Name## Pivot Table Component
description: Learn here all about Number Formatting in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Number Formatting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Number formatting in ##Platform_Name## Pivot Table component

The Pivot Table component provides comprehensive number formatting capabilities, allowing you to display numeric values in various formats. This enhances data readability and ensures values are displayed accurately to meet your specific needs.

## Supported format types

The Pivot Table component supports the following display formats for numeric values:

* **Number** - Standard numeric formatting with optional grouping separators and configurable decimal places.
* **Currency** - Formats currency values with appropriate symbols, optional grouping separators, and customizable decimal places.
* **Percentage** - Values displayed as percentages with the % symbol.
* **Custom** - User-defined formatting patterns for specific display requirements.

## Defining number format settings

To configure number formats for numeric values, use the [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) property in the [`DataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataSourceSettings). Use the following main properties within the [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) option to define how values are formatted:

### Essential formatting properties

* [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name): Specifies the field name to which the formatting should be applied.
* [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format): Defines the format pattern for the respective field.

### Format type codes

Use these standard format codes to specify the formatting type:

1. **N** - Numeric formatting (e.g., 1,234.56)
2. **C** - Currency formatting (e.g., $1,234.56)
3. **P** - Percentage formatting (e.g., 12.34%)

> **Note:** When no format is specified, the component applies numeric formatting as the default.

### Additional formatting options

* [`UseGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_UseGrouping): Controls the display of grouping separators. When set to **true** (default), displays values like $100,000,000; when **false**, displays as $100000000.
* [`Currency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Currency): Specifies the currency code to be considered for currency formatting (e.g., USD, EUR, GBP).

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



![Number formatting example](images/formatting.png)

You can also format the values at runtime using the formatting dialog. This option can be enabled by setting the [`AllowNumberFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowNumberFormatting) property to **true**. The same has been discussed in some of the upcoming topics.

> **Important:** To use the runtime formatting dialog, include the `NumberFormatting` module in the pivot table.

## Custom format

Custom format lets you display numbers in your preferred pattern by setting the [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) property within the [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html). You can use one or more format specifiers (shown in the table below) to control how values appear in the Pivot Table.

| Specifier | Description | Input | Format Output |
| ------- |--------------- | ---------------- | --------------- |
| 0 | Replaces the zero with the corresponding digit if it is present. Otherwise, zero will appear in the result string. | { format: '0000' } | '0123' |
| # | Replaces the ' # ' symbol with the corresponding digit if it is present. Otherwise, no digits will appear in the result string.| { format: '####' } | '1234' |
| . | Denotes the number of digits permitted after the decimal point. | { format: '###0.##0#' } | '546321.000' |
| % | Percent specifier denotes the percentage type format. | { format: '0000 %' } | '0100 %' |
| $ | Denotes the currency type format that is based on the global currency code specified. | { format: '$ ###.00' } | '$ 13.00' |
| ; | Denotes separate formats for positive, negative and zero values. | { format: '###.##;(###.00);-0' } | '(120.00)'    |
| 'String' (single Quotes) | Denotes the characters that are enclosed in the single quote (') to be replaced in the resulting string. | { format: "####.00 '@'" } | "123.00 @"    |

>NOTE: When you define a custom format, certain properties such as [`UseGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_UseGrouping) and [`Currency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Currency) in the format settings will be ignored.

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



![Custom number formatting](images/formatting-custom.png)

## Toolbar

Number formatting can be applied instantly at runtime through the built-in dialog, accessible from the toolbar. To enable this, set both the [`AllowNumberFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowNumberFormatting) and [`ShowToolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowToolbar) properties to **true**, and include the **NumberFormatting** option in the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Toolbar) property. The toolbar will then automatically display the "Number Formatting" icon. Clicking this icon opens the dialog, allowing you to specify number formats for value fields directly within the Pivot Table.

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



![Number formatting toolbar](images/formatting-toolbar.png)

## Invoking formatting dialog through external button

The number formatting dialog can be opened programmatically by clicking an external button, using the `ShowNumberFormattingDialog` method of the PivotTable component.

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



![Number formatting dialog](images/formatting-dialog.png)

## Events

### NumberFormatting

The [`NumberFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_NumberFormatting) event is triggered when the user clicks the 'Apply' button in the number formatting dialog to confirm their formatting settings. This event facilitates the validation or modification of the formatting settings applied by the user. It includes the following parameters:

| Parameter | Type | Description |
|-----------|------|-------------|
| `formatName` | `string` | Represents the name of the value field to which number formatting is applied in the dialog. |
| `formatSettings` | `IFormatSettings` | Contains the user-defined formatting options, such as decimal places (`minimumFractionDigits`, `maximumFractionDigits`), currency symbols (`currency`), or grouping separators (`useGrouping`), applied to the field. |
| `cancel` | `boolean` | It is a boolean property, and when set to **true**, the customization made in the number formatting dialog will not be applied. |

The following sample demonstrates how to prevent number formatting changes for the 'Amount' field by setting the `cancel` property to **true** in the [`NumberFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_NumberFormatting) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/numberformatting-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/numberformatting-event/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/number-formatting/numberformatting-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/number-formatting/numberformatting-event/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Customize number, date, and time values](./how-to/customize-number-date-and-time-values/)
* [NumberFormatOptions](https://ej2.syncfusion.com/documentation/common/intl.html?lang=typescript#manipulating-numbers)
* [Toolbar](./tool-bar)