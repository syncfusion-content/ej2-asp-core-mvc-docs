---
layout: post
title: Custom aggregation menu in ASP.NET MVC Pivot Table | Syncfusion
description: Step-by-step example showing how to add a custom aggregation type to the menu in the ASP.NET MVC Pivot Table.
platform: ej2-asp-core-mvc
control: Add custom aggregation type to the menu
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD009 -->

# How to add a custom aggregation in ASP.NET MVC Pivot Table

The ASP.NET MVC Pivot Table component allows you to extend its functionality by adding custom aggregation types to the built-in aggregation menu. This lets you perform calculations beyond the built-in aggregations, such as Sum, Average, Min, and Max. (Other built-in options include Count, DistinctCount, Product, Median, Percentage, and more; the custom mechanism described here is fully compatible with all of them.)

## Prerequisites

Before adding custom aggregation types, ensure the following are in place:

- The `Syncfusion.EJ2.PivotView` namespace is imported in the code-behind file (`using Syncfusion.EJ2.PivotView;`).
- The Pivot Table's value fields expose the aggregate menu to end users. This is enabled by default; if it has been disabled in your configuration, re-enable it from the value-field settings.
- Your Syncfusion ASP.NET MVC version is recent enough to expose both the `DataBound` and `AggregateCellInfo` events. See the [Syncfusion ASP.NET MVC PivotView CR reference](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) for the version matrix.

## Adding custom aggregation types

You can use the [`DataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event to add your own custom aggregation types to the Pivot Table's aggregate menu. This event fires after the Pivot Table has been fully rendered, making it the perfect spot to modify the component's UI elements.

In the following example, two custom aggregation types **CustomAggregateType 1** (which calculates a weighted average) and **CustomAggregateType 2** (which calculates the percentage of total) are added to the aggregate menu.

The calculation logic for these custom aggregation types is implemented using the [`AggregateCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event.

### Wiring a custom aggregation type to a measure

After registering the custom type in the aggregate menu (via the `DataBound` event), assign it to a measure field by setting that field's `type` property in the Pivot Table's data-source settings to the registered name (for example, **CustomAggregateType 1**). The custom type then appears as a selectable option in that field's aggregate menu and is used to compute its values.

### Removing or updating a custom aggregation type

To remove or replace a registered custom type, re-run the same `DataBound` registration block with the updated list (and call any cleanup needed for previously bound types) so the aggregate menu is rebuilt with the new set of options. Avoid keeping stale custom-type names bound to value fields after they are removed, otherwise the Pivot Table will fall back to its default aggregation for the affected cells.

### AggregateCellInfo event parameters

This event provides parameters including:

- `fieldName` - Holds the current cell's field name.
- `row` - Holds the current cell's row value.
- `column` - Holds the current cell's column value.
- `value` - Holds the value of the current cell.
- `cellSets` - Holds raw data for the aggregated value cell.
- `rowCellType` - Holds the row cell type.
- `columnCellType` - Holds the column cell type.
- `aggregateType` - Holds the aggregate type of the cell.
- `skipFormatting` - Boolean property that allows skipping formatting if applied.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/add-custom-aggregation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregation.cs" %}
{% include code-snippet/pivot-table/add-custom-aggregation/CustomAggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/add-custom-aggregation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregation.cs" %}
{% include code-snippet/pivot-table/add-custom-aggregation/CustomAggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Add custom aggregation type to the menu](../images/add-custom-aggregation-type-in-menu.png)
