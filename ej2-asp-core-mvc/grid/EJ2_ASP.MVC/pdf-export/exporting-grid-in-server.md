---
layout: post
title: Exporting Grid in Server in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Exporting Grid in Server in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting Grid in Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting Grid in Server

The Grid have an option to export the data to PDF in server side using Grid server export library.

## Server dependencies

The Server side export functionality is shipped in the Syncfusion.EJ2.GridExport package, which is available in Essential Studio and [nuget.org](https://www.nuget.org/).The following list of dependencies is required for Grid server side PDF exporting action.

* Syncfusion.EJ2
* Syncfusion.EJ2.GridExport
* Syncfusion.Compression.Base
* Syncfusion.Pdf.Base

## Server configuration

The following code snippets shows server configuration using ASP.NET MVC Controller Action.

To Export the Grid in server side, You need to call the [`serverPdfExport`](https://ej2.syncfusion.com/documentation/api/grid/#serverpdfexport) method for passing the Grid properties to server exporting action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export/server-exportMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export/server-exportMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> Refer to the GitHub sample for quick implementation and testing from [here](https://github.com/SyncfusionExamples/MVC-EJ2-Grid-server-side-exporting).

## Export grid as memory stream

The Grid offers an option to export the data as a memory stream instead of downloading it as a file in the browser. To obtain the memory stream of the exported grid, set the `AsMemoryStream` parameter to **true** in the [PdfExport](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.GridExport.GridPdfExport.html#Syncfusion_EJ2_GridExport_GridPdfExport_PdfExport__1_Syncfusion_EJ2_Grids_Grid_System_Collections_IEnumerable_System_Boolean_Syncfusion_EJ2_GridExport_PdfExportProperties_) method.

The following code demonstrates how to get the memory stream of exported grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-ms/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-ms/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-ms/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-ms/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Merge grid's memory stream

The [Essential PDF](https://help.syncfusion.com/file-formats/pdf/overview) library is used to merge multiple memory streams into a single stream. To learn more about the merge option, please refer to this [documentation](https://help.syncfusion.com/file-formats/pdf/merge-documents).

You can merge a memory stream, a file stream, and a local file with the Grid's memory stream in the following ways:

### Merging with an existing memory stream

If you already have a memory stream, you can directly use it to merge with the Grid's memory stream.

In the following code, the [Merge](https://help.syncfusion.com/cr/file-formats/Syncfusion.Pdf.PdfDocumentBase.html#Syncfusion_Pdf_PdfDocumentBase_Merge_Syncfusion_Pdf_PdfDocumentBase_Syncfusion_Pdf_Parsing_PdfLoadedDocument_) method of the [PdfDocumentBase](https://help.syncfusion.com/cr/file-formats/Syncfusion.Pdf.PdfDocumentBase.html) class is used to merge the grid's memory stream with an existing memory stream.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-ms-merge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-ms-merge/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-ms-merge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-ms-merge/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Merging with an existing file stream

If you already have a file stream, you can directly use it to merge with the Grid's memory stream. In the following code, the existing file stream is merged with the Grid's memory stream.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-fs-merge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-fs-merge/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-fs-merge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-fs-merge/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Merging with a local file

To merge a local file with the Grid's memory stream, you need to convert it into a file stream before merging. In the following code, the existing local file is merged with the Grid's memory stream.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-file-merge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-file-merge/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-file-merge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-file-merge/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Downloading the merged memory stream

You can download the merged memory stream by converting it into a `FileStreamResult`. In the following code, the merged memory stream is downloaded to the browser.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-ms-download/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-ms-download/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export-ms-download/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export-ms-download/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Rotate a header text to a certain degree in the exported grid on the server side

The Grid has support to customize the column header styles such as changing text orientation, the font color, and so on in the exported PDF file. To achieve this requirement, define the `BeginCellLayout` event of the `PdfExportProperties` with an event handler to perform the required action.

The `PdfHeaderQueryCellInfoEvent` will be triggered when creating a column header for the pdf document to be exported. Collect the column header details in this event and handle the custom in the BeginCellLayout event handler.

In the following demo, the `DrawString` method from the `Graphics` is used to rotate the header text of the column header inside the `BeginCellLayout` event handler.

N> A PDF exporting is not supported to rotate the column header on the client side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/rotate-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate-Header.cs" %}
{% include code-snippet/grid/pdf-export/rotate-header/rotate-header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/rotate-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate-Header.cs" %}
{% include code-snippet/grid/pdf-export/rotate-header/rotate-header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Limitations

* The export feature for detail and caption templates is not supported in server-side exporting.
* Multiple grids exporting feature is not supported with server side exporting.