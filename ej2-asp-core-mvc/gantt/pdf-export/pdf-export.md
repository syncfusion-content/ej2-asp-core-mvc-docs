---
layout: post
title: Pdf Export in ##Platform_Name## Gantt Component
description: Learn here all about Pdf Export in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# PDF Export

PDF export allows exporting Gantt data to PDF document. You need to use the `pdfExport` method for exporting. To enable PDF export in the Gantt, set the [`allowPdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowPdfExport) to true.

To export data to PDF document, inject the `PdfExport` module in Gantt.

> Currently, we don't have support for exporting the manually scheduled tasks.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport/tagHelper %}
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