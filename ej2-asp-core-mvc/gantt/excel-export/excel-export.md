---
layout: post
title: Excel Export in ##Platform_Name## Gantt Component
description: Learn here all about Excel Export in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Export

Gantt supports client-side exporting, which allows you to export its data to the Excel and CSV formats. Use the `excelExport` and `csvExport` methods for exporting. To enable Excel export in the Gantt, set the [`AllowExcelExport`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~AllowExcelExport.html) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/excelExport/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExcelExport.cs" %}
{% include code-snippet/gantt/excel-export/excelExport/excelExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/excelExport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExcelExport.cs" %}
{% include code-snippet/gantt/excel-export/excelExport/excelExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}