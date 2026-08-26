---
layout: post
title: Export Both Table and Chart in ASP.NET Core Pivot Table | Syncfusion
description: Learn how to export the ASP.NET Core Pivot Table's grid and chart to the same PDF via the actionBegin event and pdfExport.
platform: ej2-asp-core-mvc
control: Export table and chart into the same document using toolbar
documentation: ug
publishingplatform: ##Platform_Name##
---

# How to Export Both Table and Chart in ASP.NET Core Pivot Table

By default, when the [`e-displayOption.view`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_View) property is set to **Both** in the Pivot Table, the export functionality exports either the table or the chart to the PDF document based on the current value of the [`e-displayOption.primary`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_Primary) property. However, to export both the table and the chart into the same PDF document simultaneously, use the `pdfExport` method during the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event.

This approach is particularly useful when users need comprehensive reports that include both tabular data and visual representations in a single document.

## Implementation steps

Follow these steps to enable combined table and chart export:

1. **Configure the Pivot Table** with both table and chart display options.
2. **Handle the actionBegin event** to intercept the default export action.
3. **Call the pdfExport method** with the `exportBothTableAndChart` parameter set to **true**.

## Code example

The following example demonstrates how to restrict the built-in export action by setting the `args.cancel` option to **true** in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event, and then export both the table and the chart by calling the `pdfExport` method with the `exportBothTableAndChart` argument set to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/export-table-and-chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExportTableAndChart.cs" %}
{% include code-snippet/pivot-table/export-table-and-chart/ExportTableAndChart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/export-table-and-chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExportTableAndChart.cs" %}
{% include code-snippet/pivot-table/export-table-and-chart/ExportTableAndChart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
