---
layout: post
title: Export table and chart into the same document using toolbar in Angular Pivotview component | Syncfusion
description: Learn here all about Export table and chart into the same document using toolbar in Syncfusion Angular Pivotview component of Syncfusion Essential JS 2 and more.
platform: ej2-angular
control: Export table and chart into the same document using toolbar 
documentation: ug
domainurl: ##DomainURL##
---

# Export table and chart into the same document using toolbar 

Even if the [`displayOption.view`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_View) property is set to **Both** in the pivot table, you can only export either the table or the chart to the PDF document based on the current value set in the [`displayOption.primary`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_Primary) property. But, to export both the table and the chart to the same PDF document, use the `pdfExport` method during the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event invoke.

In the following example, the built-in export action can be restricted by setting the `args.cancel` option to **true** in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event, and both the table and the chart can be exported by calling the `pdfExport` method and setting the `exportBothTableAndChart` argument to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/export-table-and-chart-using-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExportTableAndChartUsingToolbar.cs" %}
{% include code-snippet/pivot-table/export-table-and-chart-using-toolbar/ExportTableAndChartUsingToolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/export-table-and-chart-using-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExportTableAndChartUsingToolbar.cs" %}
{% include code-snippet/pivot-table/export-table-and-chart-using-toolbar/ExportTableAndChartUsingToolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
