---
layout: post
title: Pdf Export in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Pdf Export in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---

# Export

## PDF Export

PDF export allows exporting Gantt data to PDF document. You need to use the `pdfExport` method for exporting. To enable PDF export in the Gantt, set the [`allowPdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowPdfExport) to true.

To export data to PDF document, inject the `PdfExport` module in Gantt.

N> Currently, we don't have support for exporting the manually scheduled tasks.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdf-columnTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfexport.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport/pdfexport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfexport.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport/pdfexport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Indicators in PDF exporting 

The PDF export functionality allows users to export Gantt charts enriched with dynamic indicators and accompanying images.
These indicators, represented by images,can be effortlessly defined using the `base64` encoding value in the data object of datasource.This data object field should be mapped to indiactor property of [`task fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Indicators).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexportindicator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfexport.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexportindicator/pdfexport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexportindicator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfexport.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexportindicator/pdfexport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Exporting Gantt data as a blob object

In Gantt, you can export the Gantt chart data as a blob object, which allows you to preview or modify the data before exporting it.

To export the Gantt chart data as a blob object, follow these steps:

step 1: pdfExport fourth argument set as `true`.

step 2: Then , `pdfExpComplete` return as blob object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/blobdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="blob-data.cs" %}
{% include code-snippet/gantt/pdf-export/blobdata/blob-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/blobdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="blob-data.cs" %}
{% include code-snippet/gantt/pdf-export/blobdata/blob-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Single page exporting in gantt

In Gantt, we have provided support to export the Gantt component where each rows are auto-fit to the PDF document page width by setting <code>IsFitToWidth</code> as true in <code>FitToWidthSettings</code> of <code>PdfExportProperties</code>.

Also, we can customize the chart width and grid width in exported file using <code>ChartWidth</code> and <code>GridWidth</code> by defining it as percentage in string. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/singlepage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Single-Page-Export.cs" %}
{% include code-snippet/gantt/pdf-export/singlepage/single-page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/singlepage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Single-Page-Export.cs" %}
{% include code-snippet/gantt/pdf-export/singlepage/single-page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Multiple exporting action in gantt control

PDF export provides an option for exporting multiple Gantt to same file. In this exported document, each Gantt will be exported to a new page of the document in same file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdfmultipleexport/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfmultipleexport.cs" %}
{% include code-snippet/gantt/pdfmultipleexport/pdfmultipleexport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdfmultipleexport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfmultipleexport.cs" %}
{% include code-snippet/gantt/pdfmultipleexport/pdfmultipleexport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Applying Themes in PDF Export

PDF export provides an option to include theme for the exported PDF document. To apply theme in exported PDF, define the `theme` in `pdfExportProperties`. The available themes are:

* Material
* Fabric
* Bootstrap
* Bootstrap 4

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/themes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Themes.cs" %}
{% include code-snippet/gantt/pdf-export/themes/themes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/themes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Themes.cs" %}
{% include code-snippet/gantt/pdf-export/themes/themes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
