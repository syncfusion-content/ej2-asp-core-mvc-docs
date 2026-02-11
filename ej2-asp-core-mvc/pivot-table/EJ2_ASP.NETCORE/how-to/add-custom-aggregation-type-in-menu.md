---
layout: post
title: Add custom aggregation type to ASP.NET Core | Syncfusion
description: Learn here all about how to add custom aggregation type to the menu in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Add custom aggregation type to the menu
publishingplatform: ##Platform_Name## 
documentation: ug
---

<!-- markdownlint-disable MD009 -->

# Add custom aggregation type to ##Platform_Name## Pivotview component

The ASP.NET Core Pivot Table component allows you to extend its functionality by adding custom aggregation types to the built-in aggregation menu. This enables you to implement specific calculation methods beyond the standard options like Sum, Average, Min, and Max.

## Adding custom aggregation types

You can use the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event to add your own custom aggregate types to the pivot table's aggregate menu. This event fires after the pivot table has been fully rendered, making it the perfect spot to modify the component's UI elements.

In the following example, we have added two custom aggregation types **CustomAggregateType 1** (which calculates a weighted average) and **CustomAggregateType 2** (which calculates the percentage of total) to the aggregate menu.

The calculation logic for these custom aggregation types is implemented using the [`aggregateCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event. This event provides parameters including:
- `fieldName` - Holds the current cell's field name.
- `row` - Holds the current cell's row value.
- `column` - Holds the current cell's column value.
- `value` - Holds the value of the current cell.
- `cellSets` - Holds raw data for the aggregated value cell.
- `rowCellType` - Holds the row cell type value.
- `columnCellType` - Holds the column cell type value.
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