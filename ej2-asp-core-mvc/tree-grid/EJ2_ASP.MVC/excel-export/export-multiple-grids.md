---
layout: post
title: Export Multiple Tree Grids in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Export Multiple Tree Grids in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Export Multiple Tree Grids
publishingplatform: ##Platform_Name##
documentation: ug
---

# Export Multiple Tree Grids

The excel export provides an option to export multiple Tree grid data in the same excel file.

## Same sheet

The excel export provides support to export multiple Tree Grids in same sheet. To export in same sheet, define [`multipleExport`](https://ej2.syncfusion.com/documentation/api/treegrid/treeGridExcelExportProperties/#multipleexport) type as **AppendToSheet** in [`exportProperties`](https://ej2.syncfusion.com/documentation/api/treegrid/treeGridExcelExportProperties/). It have an option to provide blank rows between Tree Grids. These blank rows count can be defined by using the `multipleExport` as blankRows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/same-sheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Same-sheet.cs" %}
{% include code-snippet/tree-grid/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/same-sheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Same-sheet.cs" %}
{% include code-snippet/tree-grid/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> By default, `multipleExport` blankRows value is 5.

