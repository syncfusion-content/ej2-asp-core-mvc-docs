---
layout: post
title: Excel Export in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Excel Export in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export in ##Platform_Name## Tree Grid Component

The excel export allows exporting TreeGrid data to Excel document. You need to use the [`excelExport`](https://ej2.syncfusion.com/documentation/api/grid/#excelexport) method for exporting. To enable Excel export in the treegrid, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowExcelExport.html) as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/tree-grid/excel-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/tree-grid/excel-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Persist collapsed state

You can persist the collapsed state in the exported document by defining `isCollapsedStatePersist` property as true in `TreeGridExcelExportProperties` parameter of [`excelExport`](https://ej2.syncfusion.com/documentation/api/grid/#excelexport) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/is-collapsed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Is-collapsed.cs" %}
{% include code-snippet/tree-grid/excel-export/is-collapsed/is-collapsed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/is-collapsed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Is-collapsed.cs" %}
{% include code-snippet/tree-grid/excel-export/is-collapsed/is-collapsed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Exporting custom aggregates in TreeGrid  

The TreeGrid enables exporting custom aggregates, which summarize column data, to an Excel document using the `ExcelAggregateQueryCellInfo` event.  
 
In the provided example, the `CustomAggregateFn` function computes the item count for a selected category, while the `ExcelAggregateQueryCellInfo` event customizes the exported cell values in the Excel document.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/custom-aggregate-excel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="empty-record-template.cs" %}
{% include code-snippet/tree-grid/excel-export/custom-aggregate-excel/custom-aggregate-excel.cs %}
{% endhighlight %}
{% endtabs %}

![Excel Custom Aggregates ](../images/custom-aggregate-excel.png)

N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.