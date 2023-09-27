---
layout: post
title: Export Multiple Grids in ##Platform_Name## Grid Component
description: Learn here all about Export Multiple Grids in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Export Multiple Grids
publishingplatform: ##Platform_Name##
documentation: ug
---


# Export Multiple Grids

The Excel export provides an option to export multiple grid data in the same or different sheets of an Excel file. Each grid is identified by its unique ID. You can specify which grids to export by listing their **IDs** in the `exportGrids` property.

## Same sheet

Excel exporting provides support for exporting multiple grids on the same sheet. To export the grids in the same sheet, define **multipleExport.type** as **AppendToSheet** in **exportProperties**. It also has an option to provide blank rows between the grids. These blank rows count can be defined by using the **multipleExport.blankRows** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/same-sheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Same-sheet.cs" %}
{% include code-snippet/grid/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/same-sheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Same-sheet.cs" %}
{% include code-snippet/grid/excel-export/same-sheet/same-sheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> By default, **multipleExport.blankRows** value is 5.

## New sheet

Excel export functionality enables the exporting of multiple grids onto separate sheets (each grid in new sheet of excel) within the Excel file. To achieve this, you can specify **multipleExport.type** as **NewSheet** in **exportProperties**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/new-sheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="New-sheet.cs" %}
{% include code-snippet/grid/excel-export/new-sheet/new-sheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/new-sheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="New-sheet.cs" %}
{% include code-snippet/grid/excel-export/new-sheet/new-sheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

