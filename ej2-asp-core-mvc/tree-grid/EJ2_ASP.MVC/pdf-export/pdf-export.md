---
layout: post
title: Pdf Export in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Pdf Export in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# PDF Export in ##Platform_Name## Tree Grid Component

PDF export allows exporting TreeGrid data to PDF document. You need to use the [`pdfExport`](https://ej2.syncfusion.com/documentation/api/grid/#pdfexport) method for exporting. To enable PDF export in the treegrid, set the [`AllowPdfExport`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowPdfExport.html) as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/tree-grid/pdf-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/tree-grid/pdf-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Exporting custom aggregates in TreeGrid
 
The TreeGrid enables exporting custom aggregates, which summarize column data, to an PDF document using the `PdfAggregateQueryCellInfo` event.
 
In the provided example, the `CustomAggregateFn` function computes the item count for a selected category, while the `PdfAggregateQueryCellInfo` event customizes the exported cell values in the PDF document.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/custom-aggregate-pdf/razor %}
{% endhighlight %}
{% highlight c# tabtitle="empty-record-template.cs" %}
{% include code-snippet/tree-grid/pdf-export/custom-aggregate-pdf/custom-aggregate-pdf.cs %}
{% endhighlight %}
{% endtabs %}

![Exporting Custom Aggregates](../images/pdf-custom-aggregate.jpg)

N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.