---
layout: post
title: Hyperlink in ASP.NET Core Pivot Table | Syncfusion
description: Learn how the ASP.NET Core Pivot Table adds Hyperlinks to row, column, and value cells through HyperlinkSettings for interactive navigation and drill-through.
platform: ej2-asp-core-mvc
control: Hyper Link
publishingplatform: ##Platform_Name##
documentation: ug
---

# Hyperlink in ASP.NET Core Pivot Table

The Pivot Table component provides built-in support for displaying hyperlinks within individual cells. This feature allows users to link data in specific cells, enhancing interactivity and navigation. Common use cases include linking a value cell to a related detail report, opening an external resource from a row header, or highlighting summary cells that match a business rule.

Hyperlinks can be selectively enabled for various cell types, including:

- Row headers
- Column headers
- Value cells
- Summary cells

You can control hyperlink behavior using the [`e-hyperlinkSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html) property, which can be defined during the initial rendering through the code-behind.

## Available hyperlink settings

The following properties are available in `HyperlinkSettings`. Each property is optional; combine them to control which cells display hyperlinks.

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| [`ShowHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowHyperlink) | `boolean` | `false` | Shows or hides hyperlinks in all cells. |
| [`ShowRowHeaderHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowRowHeaderHyperlink) | `boolean` | `false` | Shows or hides hyperlinks in row headers. |
| [`ShowColumnHeaderHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowColumnHeaderHyperlink) | `boolean` | `false` | Shows or hides hyperlinks in column headers. |
| [`ShowValueCellHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowValueCellHyperlink) | `boolean` | `false` | Shows or hides hyperlinks in value cells. |
| [`ShowSummaryCellHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowSummaryCellHyperlink) | `boolean` | `false` | Shows or hides hyperlinks in summary cells. |
| [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_HeaderText) | `string` | `''` | Shows hyperlinks for cells whose header text matches the specified value. |
| [`ConditionalSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html) | `ConditionalSettings[]` | `[]` | Shows hyperlinks for cells whose values match the specified conditions. |
| [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_CssClass) | `string` | `''` | Applies a custom CSS class to hyperlink elements for user-defined styling. |

> **Precedence:** When `ShowHyperlink` is `true`, individual `Show*Hyperlink` flags are ignored. `HeaderText` and `ConditionalSettings` are evaluated after the cell-type filters.

> By default, the hyperlink options are disabled for all cells in the pivot table.

> User defined style can be applied to hyperlink using [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_CssClass) property in [`e-hyperlinkSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html).

## Hyperlink for all cells

The pivot table provides an option to display hyperlinks for **all cells** in the table. To enable this functionality, set the [`ShowHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowHyperlink) property to **true** within the [`e-hyperlinkSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html).

> **Prerequisite:** The Pivot Table must have at least one row, column, and value field configured so that all cell types render with content.

Once enabled, hyperlinks are shown consistently in row headers, column headers, value cells, and summary cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/all-cells/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AllCells.cs" %}
{% include code-snippet/pivot-table/hyper-link/all-cells/AllCells.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/all-cells/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AllCells.cs" %}
{% include code-snippet/pivot-table/hyper-link/all-cells/AllCells.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Hyperlink enabled for all cells](images/hyperlink.png)

## Hyperlink for row headers

The pivot table provides a way to display hyperlinks specifically in **row header cells** that are currently visible. To enable this functionality, set the [`ShowRowHeaderHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowRowHeaderHyperlink) property to **true** within the [`e-hyperlinkSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html). This ensures that only the row headers will display hyperlinks, while other cell types remain unaffected.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/row-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeader.cs" %}
{% include code-snippet/pivot-table/hyper-link/row-header/RowHeader.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/row-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeader.cs" %}
{% include code-snippet/pivot-table/hyper-link/row-header/RowHeader.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Row header hyperlink](images/hyperlink-rowheader.png)

## Hyperlink for column headers

The pivot table provides an option to display hyperlinks specifically in column header cells that are currently visible. To enable this functionality, set the [`ShowColumnHeaderHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowColumnHeaderHyperlink) property to **true** within the [`e-hyperlinkSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html) object. This ensures that only the column headers will display hyperlinks, while other cell types remain unaffected.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/column-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnHeader.cs" %}
{% include code-snippet/pivot-table/hyper-link/column-header/ColumnHeader.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/column-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnHeader.cs" %}
{% include code-snippet/pivot-table/hyper-link/column-header/ColumnHeader.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Column header hyperlink](images/hyperlink-columnheader.png)

## Hyperlink for value cells

The pivot table provides support for displaying hyperlinks specifically in value cells that are currently visible. To enable this option, set the [`ShowValueCellHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowValueCellHyperlink) property to **true** within the [`e-hyperlinkSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html) object. This ensures that only the value cells will display hyperlinks, while other cell types remain unaffected.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/value-cells/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValueCells.cs" %}
{% include code-snippet/pivot-table/hyper-link/value-cells/ValueCells.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/value-cells/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValueCells.cs" %}
{% include code-snippet/pivot-table/hyper-link/value-cells/ValueCells.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Value cell hyperlink](images/hyperlink-value.png)

## Hyperlink for summary cells

The pivot table provides support for displaying hyperlinks specifically in summary cells that are currently visible. To enable this option, set the [`ShowSummaryCellHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowSummaryCellHyperlink) property to **true** within the [`e-hyperlinkSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html) object. This ensures that only the summary cells will display hyperlinks, while other cell types remain unaffected.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/summary-cells/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SummaryCells.cs" %}
{% include code-snippet/pivot-table/hyper-link/summary-cells/SummaryCells.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/summary-cells/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SummaryCells.cs" %}
{% include code-snippet/pivot-table/hyper-link/summary-cells/SummaryCells.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Summary cell hyperlink](images/hyperlink-summary.png)

## Header-based hyperlink

The pivot table supports displaying hyperlinks in cells that match specific row or column headers. This functionality can be enabled using the [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_HeaderText) property, which is configured through code-behind during initial rendering.

In the example below, the value **FY 2015.Q1.Units Sold** is assigned to [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_HeaderText), which means the pivot table will show hyperlinks only in cells that match this specific header combination.

N> The **dot (`.`)** character in `FY 2015.Q1.Units Sold` is the default delimiter used to identify the header levels in the row and column axes. To use a different delimiter, configure the `HeaderDelimiter` property in `ValueSortSettings` before the Pivot Table renders.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/headers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headers.cs" %}
{% include code-snippet/pivot-table/hyper-link/headers/Headers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/headers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headers.cs" %}
{% include code-snippet/pivot-table/hyper-link/headers/Headers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Header-based hyperlink](images/hyperlink-header.png)

## Condition-based hyperlink

The pivot table supports displaying hyperlinks in specific cells based on defined conditions. This functionality can be configured through code-behind during initial rendering using the [`ConditionalSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html) property.

* [`Measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Measure) (`string`): Specifies the value field name for which the hyperlink should be shown when the condition is met.
* [`Conditions`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Conditions) (`Condition`): Specifies the operator type. The supported operators include:
  * `Condition.Equals`
  * `Condition.NotEquals`
  * `Condition.GreaterThan`
  * `Condition.GreaterThanOrEqual`
  * `Condition.LessThan`
  * `Condition.LessThanOrEqual`
  * `Condition.Between` (uses both `Value1` and `Value2`)
  * `Condition.NotBetween` (uses both `Value1` and `Value2`)
* [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Value1): Sets the starting value for the condition.
* [`Value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Value2):  Sets the ending value for range-based comparisons (`Condition.Between`, `Condition.NotBetween`). Ignored for other operators.

> **URL source:** The hyperlink target for condition-based cells is taken from a column on the data source whose name matches the value field defined in `Measure`. If your data source does not contain such a column, the cell is rendered as plain text.

In the example below, the pivot table is configured to display hyperlinks only in cells where the "Units Sold" field value is between **150** and **500**. This highlights specific aggregated values that meet the given condition.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/conditions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Conditions.cs" %}
{% include code-snippet/pivot-table/hyper-link/conditions/Conditions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/conditions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Conditions.cs" %}
{% include code-snippet/pivot-table/hyper-link/conditions/Conditions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Conditional hyperlink applied](images/hyperlink-condition.png)

## Condition based hyperlink for specific row or column

You can apply conditions for specific row or column using [`Label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Label) option to show hyperlink option in the pivot table. It can be configured using the [`ConditionalSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html) tag through code behind, during initial rendering. The required settings are:

* [`Label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Label): Specifies the header name to get visibility of hyperlink option for row or column.
* [`Conditions`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Conditions): Specifies the operator type such as [**Equals**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Condition.html), [**GreaterThan**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Condition.html), [**LessThan**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Condition.html), etc.
* [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Value1): Specifies the start value.
* [`Value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Value2): Specifies the end value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/Label-conditions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LabelConditions.cs" %}
{% include code-snippet/pivot-table/hyper-link/Label-conditions/LabelConditions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/Label-conditions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelConditions.cs" %}
{% include code-snippet/pivot-table/hyper-link/Label-conditions/LabelConditions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Event

The pivot table triggers the [`hyperlinkCellClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_HyperlinkCellClick) event whenever a hyperlink cell is clicked. This event allows you to either customize the clicked cell or retrieve information about it.

> **Prerequisite:** Hyperlink cells must be enabled via `HyperlinkSettings`; the event does not fire on cells that are not hyperlinks.

It provides the following parameters:

* `currentCell`: Refers to the clicked cell element, which can be modified as needed.
* `cancel`:  If set to **true**, prevents the default click behavior from running (for example, navigation). Set to **false** to let the click proceed normally and your custom code run in addition.
* `data`: Contains detailed information about the clicked cell, including its value, row and column headers, position, and whether it is a summary cell.
* `nativeEvent`: Represents the original browser event triggered by the click, useful for advanced event handling.

In the example below, when a hyperlink cell is clicked, a custom attribute (**data-url**) is added to the cell to redirect users to the Syncfusion ASP.NET Core Pivot Table Hyperlink [Demo](https://ej2.syncfusion.com/aspnetcore/pivottable/hyperlink#/tailwind3). The `cancel` property is set to **false** to allow this interaction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Event.cs" %}
{% include code-snippet/pivot-table/hyper-link/event/Event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Event.cs" %}
{% include code-snippet/pivot-table/hyper-link/event/Event.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}