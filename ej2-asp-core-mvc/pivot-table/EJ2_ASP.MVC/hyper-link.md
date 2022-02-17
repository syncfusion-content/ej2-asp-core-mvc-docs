---
layout: post
title: Hyper Link in ##Platform_Name## Pivot Table Component
description: Learn here all about Hyper Link in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Hyper Link
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hyperlink

The pivot table supports to show hyperlink option to link data for individual cells that are displayed in the component. Also, the hyperlink can be enabled separately for row headers, column headers, value cells, and summary cells using the [`HyperlinkSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html) class. It can be configured through code behind, during initial rendering and the settings available to show hyperlink are:

* [`ShowHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowHyperlink): It allows to set the visibility of hyperlink in all cells.
* [`ShowRowHeaderHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowRowHeaderHyperlink): It allows to set the visibility of hyperlink in row headers.
* [`ShowColumnHeaderHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowColumnHeaderHyperlink): It allows to set the visibility of hyperlink in column headers.
* [`ShowValueCellHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowValueCellHyperlink): It allows to set the visibility of hyperlink in value cells.
* [`ShowSummaryCellHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowSummaryCellHyperlink): It allows to set the visibility of hyperlink in summary cells.
* [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_HeaderText): It allows to set the visibility of hyperlink based on header text.
* [`ConditionalSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html): It allows to set the visibility of hyperlink based on specific condition.

<!-- markdownlint-disable MD028 -->
> By default, the hyperlink options are disabled for all cells in the pivot table.

> User defined style can be applied to hyperlink using [`CssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_CssClass) property in [`HyperlinkSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html) class.

## Hyperlink for all cells

The pivot table has an option to show hyperlink option for all cells that are currently in display. To do so, user need to set [`ShowHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowHyperlink) to **true**.

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



![output](images/hyperlink.png)

## Hyperlink for row headers

The pivot table has an option to show hyperlink option for row header cells alone that are currently in display. To do so, user need to set [`ShowRowHeaderHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowRowHeaderHyperlink) to **true**.

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



![output](images/hyperlink-rowheader.png)

## Hyperlink for column headers

The pivot table has an option to show hyperlink option for column header cells alone that are currently in display. To do so, user need to set [`ShowColumnHeaderHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowColumnHeaderHyperlink) to **true**.

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



![output](images/hyperlink-columnheader.png)

## Hyperlink for value cells

The pivot table has an option to show hyperlink option for value cells alone that are currently in display. To do so, user need to set [`ShowValueCellHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowValueCellHyperlink) to **true**.

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



![output](images/hyperlink-value.png)

## Hyperlink for summary cells

The pivot table has an option to show hyperlink option for summary cells alone that are currently in display. To do so, user need to set [`ShowSummaryCellHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_ShowSummaryCellHyperlink) to **true**.

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



![output](images/hyperlink-summary.png)

## Condition based hyperlink

The pivot table has an option to show hyperlink in the cells based on specific conditions. It can be configured using the [`ConditionalSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html) class through code behind, during initial rendering. The settings required are:

* [`Measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Measure): Specifies the value field name, in-order to set the visibility of hyperlink for the same when condition is met.
* [`Conditions`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Conditions): Specifies the operator type such as [**Condition.Equals**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Condition.html), [**Condition.GreaterThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Condition.html), [**Condition.LessThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Condition.html), etc.
* [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Value1): Specifies the start value.
* [`Value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalSetting_Value2): Specifies the end value.

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



![output](images/hyperlink-condition.png)

## Header based hyperlink

The pivot table has an option to show hyperlink in the cells based on specific row or column header. It can be configured using the [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewHyperlinkSettings.html#Syncfusion_EJ2_PivotView_PivotViewHyperlinkSettings_HeaderText) option through code behind, during initial rendering.

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



![output](images/hyperlink-header.png)

## Event

The event [`HyperlinkCellClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_HyperlinkCellClick) fires on every hyperlink cell click.

It has following parameters - `cancel` and `currentCell`. The parameter `currentCell` is used to customize the host cell element by any means. Meanwhile, when the parameter `cancel` is set to **true**, applied customization will not be updated to the host cell element.

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



## See Also

* [Apply condition based hyperlink for specific row or column](./how-to/apply-condition-based-hyper-link-for-specific-row-or-column)