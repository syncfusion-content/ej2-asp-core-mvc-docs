---
layout: post
title: Number Formatting in ASP.NET MVC Pivot Table | Syncfusion
description: Learn how the ASP.NET MVC Pivot Table pplies number formats such as currency, percentage, and decimal places to value cells through FormatSettings.
platform: ej2-asp-core-mvc
control: Number Formatting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Number formatting in ASP.NET MVC Pivot Table

The Pivot Table component lets you display numeric values in standard number, currency, percentage, or custom formats to match the reporting needs of your application.

## Supported format types

The Pivot Table component supports the following display formats for numeric values:

* **Number** - Standard numeric formatting with optional grouping separators and configurable decimal places.
* **Currency** - Formats currency values with appropriate symbols, optional grouping separators, and customizable decimal places.
* **Percentage** - Values displayed as percentages with the % symbol.
* **Custom** - User-defined formatting patterns for specific display requirements.

## Defining number format settings

To configure number formats for numeric values, use the [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) property in the [`DataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataSourceSettings).

The following properties are available inside each `formatSettings` entry:

### Essential formatting properties

| Property | Type | Description |
|----------|------|-------------|
| [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) | `string` | The field name to which the formatting should be applied. |
| [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) | `string` | The format pattern for the field. |

### Format type codes

Use these standard format codes as the value of the `format` property. You can also append a digit to set the number of decimal places (e.g., `N2` for two decimal places).

1. **N** - Numeric formatting (e.g., `N` produces `1,234.56`; `N2` produces `1,234.56`).
2. **C** - Currency formatting (e.g., `C0` produces `$1,234`; the symbol is taken from the `currency` property).
3. **P** - Percentage formatting (e.g., `P1` produces `12.3%` for the value `0.1234`).

> **Note:** When no format is specified, the component applies numeric formatting by default.

### Additional formatting options

* [`UseGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_UseGrouping) (`boolean`, default `true`): Controls the display of grouping separators. When `true` (default), values display with separators (for example, `$100,000,000`); when `false`, they display without separators (for example, `$100000000`).
* [`Currency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Currency) (`string`): The currency code to be considered for currency formatting (for example, `USD`, `EUR`, `GBP`).

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

> **Important:** To use the runtime formatting dialog (and the toolbar option), include the `NumberFormatting` module in the Pivot Table:

## Custom format

Custom format lets you display numbers in your preferred pattern by setting the [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) property within the [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html). You can use one or more format specifiers (shown in the table below) to control how values appear in the Pivot Table.

| Specifier | Description | Input | Format Output |
| ------- |--------------- | ---------------- | --------------- |
| 0 | Replaces the zero with the corresponding digit if one is present. Otherwise, zero appears in the result string. | `{ format: '0000' }` | `'0123'` |
| # | Replaces the `#` symbol with the corresponding digit if one is present. Otherwise, no digit appears in the result string. | `{ format: '####' }` | `'1234'` |
| . | Denotes the number of digits permitted after the decimal point. | `{ format: '###0.##0#' }` | `'546321.000'` (value `546321`) |
| % | Percent specifier; multiplies the value by 100 and appends the `%` symbol. | `{ format: '0000 %' }` | `'0100 %'` (value `1`) |
| $ | Denotes currency formatting based on the global currency code specified in `currency`. | `{ format: '$ ###.00' }` | `'$ 13.00'` (value `13`) |
| ; | Denotes separate formats for positive, negative, and zero values. | `{ format: '###.##;(###.00);-0' }` | `'(120.00)'` (value `-120`) |
| `,` | Grouping separator (thousands). | `{ format: '###,###' }` | `'1,234,567'` (value `1234567`) |
| `'String'` | Characters enclosed in single quotes are included literally in the result string. | `{ format: "####.00 '@'" }` | `'123.00 @'` (value `123`) |

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

Number formatting can be applied at runtime through the built-in dialog, accessible from the toolbar. To enable this, set both the [`AllowNumberFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowNumberFormatting) and [`ShowToolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowToolbar) properties to **true**, include the `NumberFormatting` module, and add the `'NumberFormatting'` option to the  [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Toolbar) property. The toolbar then displays the **Number Formatting** icon. Clicking this icon opens the dialog, where you can specify number formats for value fields directly within the Pivot Table.

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

The number formatting dialog can be opened programmatically by clicking an external button, using the `ShowNumberFormattingDialog` method.

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
| `FormatName` | `string` | Represents the name of the value field to which number formatting is applied in the dialog. |
| `FormatSettings` | `IFormatSettings` | Contains the user-defined formatting options, such as decimal places (`MinimumFractionDigits`, `MaximumFractionDigits`), currency symbols (`Currency`), or grouping separators (`UseGrouping`), applied to the field. |
| `Cancel` | `boolean` | It is a boolean property, and when set to **true**, the customization made in the number formatting dialog will not be applied. |

The following sample demonstrates how to prevent number formatting changes for the 'Amount' field by setting the `Cancel` property to **true** in the [`NumberFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_NumberFormatting) event.

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

* [Customize number, date, and time values](./how-to/customize-number-date-and-time-values)
* [NumberFormatOptions](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization#manipulating-numbers)
* [Toolbar](./tool-bar)