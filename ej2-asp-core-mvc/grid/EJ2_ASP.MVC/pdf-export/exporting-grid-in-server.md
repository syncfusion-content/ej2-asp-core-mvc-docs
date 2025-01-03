---
layout: post
title: Exporting Grid in Server in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Exporting Grid in Server in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting Grid in Server
publishingplatform: ##Platform_Name##
documentation: ug
---

# Exporting Grid in Server in ASP.NET MVC Grid Component

The Grid component provides an option to export grid data to a PDF document on the server side using the Grid server export library. This allows you to perform PDF export operations on the server, providing additional security and flexibility. To enable server-side PDF exporting, you need to configure the server dependencies and implement the necessary server configuration.

## Server dependencies

To enable server-side PDF exporting in the Syncfusion ASP.NET MVC Grid component, you need to include the following dependencies:

* Syncfusion.EJ2
* Syncfusion.EJ2.GridExport

These dependencies are available in the Essential Studio package and can also be obtained from [nuget.org](https://www.nuget.org/).

## Server configuration

To export the grid data to a PDF document on the server side, you need to perform the following server configuration using an ASP.NET MVC Controller Action:

1. Set up the necessary dependencies and imports in your server-side code.

2. Define a controller action that handles the server-side PDF export. This action should receive the Grid properties from the client-side and initiate the PDF export operation on the server.

3. Use the `ServerPdfExport` method to pass the Grid properties to the server exporting action. This method allows you to specify the server action URL and other export options.

The following code snippet shows server configuration using ASP.NET MVC Controller Action.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMVC.cs" %}
{% include code-snippet/grid/pdf-export/server-export/server-exportMVC.cs %}
{% endhighlight %}
{% endtabs %}

N> Refer to the GitHub sample for quick implementation and testing from [here](https://github.com/SyncfusionExamples/MVC-EJ2-Grid-server-side-exporting).

## Export grid as memory stream

The Grid offers an option to export the data as a memory stream instead of downloading it as a file in the browser. To obtain the memory stream of the exported grid, set the `AsMemoryStream` parameter to **true** in the `PdfExport` method.

The following code demonstrates how to get the memory stream of exported grid.

```ts
public object PdfExport(string gridModel)
{
    GridPdfExport exp = new GridPdfExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    // pass third parameter as true to get the Memory Stream of exported grid data
    return (MemoryStream)exp.PdfExport<OrdersDetails>(gridProperty, OrdersDetails.GetAllRecords(), true);
}

```

## Merge grid's memory stream

The [Essential PDF](https://help.syncfusion.com/file-formats/pdf/overview) library is used to merge multiple memory streams into a single stream. To learn more about the merge option, please refer to this [Documentation](https://help.syncfusion.com/file-formats/pdf/merge-documents).

You can merge a memory stream, a file stream, and a local file with the Grid's memory stream in the following ways:

### Merging with an existing memory stream

If you already have a memory stream, you can directly use it to merge with the Grid's memory stream.

In the following code, the [Merge](https://help.syncfusion.com/cr/file-formats/Syncfusion.Pdf.PdfDocumentBase.html#Syncfusion_Pdf_PdfDocumentBase_Merge_Syncfusion_Pdf_PdfDocumentBase_Syncfusion_Pdf_Parsing_PdfLoadedDocument_) method of the [PdfDocumentBase](https://help.syncfusion.com/cr/file-formats/Syncfusion.Pdf.PdfDocumentBase.html) class is used to merge the grid's memory stream with an existing memory stream.

```ts
using Syncfusion.Pdf;

public MemoryStream ms1; // defines existing memory stream

public object PdfExport(string gridModel)
{
    GridPdfExport exp = new GridPdfExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    // get the memory stream of exported grid data
    MemoryStream ms2 = (MemoryStream)exp.PdfExport<OrdersDetails>(gridProperty, OrdersDetails.GetAllRecords(), true);
    //Creates a PDF document.
    PdfDocument finalDoc = new PdfDocument();
    //Creates a PDF stream for merging. ms1 and ms2 represents the existing stream and grid's stream.
    Stream[] streams = { ms1, ms2 };
    //Merges PDFDocument.
    PdfDocumentBase.Merge(finalDoc, streams);
    //Save the document into stream.
    MemoryStream ms3 = new MemoryStream();
    finalDoc.Save(ms3);    
    ms3.Position = 0;
    //Close the document.
    finalDoc.Close(true);
    //Dispose the streams.
    ms1.Dispose();
    ms2.Dispose();
    return ms3;
}

```

### Merging with an existing file stream

If you already have a file stream, you can directly use it to merge with the Grid's memory stream. In the following code, the existing file stream is merged with the Grid's memory stream.

```ts
using Syncfusion.Pdf;

public FileStream fs1; // defines existing file stream

public ActionResult PdfExport(string gridModel)
{
    GridPdfExport exp = new GridPdfExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    MemoryStream ms1 = (MemoryStream)exp.PdfExport<OrdersDetails>(gridProperty, OrdersDetails.GetAllRecords(), true);
    PdfDocument finalDoc = new PdfDocument();
    //fs1 and ms1 represents the existing stream and grid's stream.
    Stream[] streams = { fs1, ms1 };
    PdfDocumentBase.Merge(finalDoc, streams);
    MemoryStream ms3 = new MemoryStream();
    finalDoc.Save(ms3);    
    ms3.Position = 0;
    return ms3;
}

```

### Merging with a local file

To merge a local file with the Grid's memory stream, you need to convert it into a file stream before merging. In the following code, the existing local file is merged with the Grid's memory stream.

```ts
using Syncfusion.Pdf;

// get the file stream of local file
public FileStream fs1 = new FileStream("D:/PdfDoc.pdf", FileMode.Open, FileAccess.Read); // PdfDoc.pdf is a local file which is located in local disk D.

public ActionResult PdfExport(string gridModel)
{
    GridPdfExport exp = new GridPdfExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    MemoryStream ms1 = (MemoryStream)exp.PdfExport<OrdersDetails>(gridProperty, OrdersDetails.GetAllRecords(), true);
    PdfDocument finalDoc = new PdfDocument();
    //fs1 and ms1 represents the local file's stream and grid's stream.
    Stream[] streams = { fs1, ms1 };
    PdfDocumentBase.Merge(finalDoc, streams);
    MemoryStream ms3 = new MemoryStream();
    finalDoc.Save(ms3);    
    ms3.Position = 0;
    return ms3;
}

```

### Downloading the merged memory stream

You can download the merged memory stream by converting it into a `FileStreamResult`. In the following code, the merged memory stream is downloaded to the browser.

```ts
using Syncfusion.Pdf;

public ActionResult PdfExport(string gridModel)
{
    PdfDocument finalDoc = new PdfDocument();
    //ms1 and ms2 represents the streams needs to merge.
    Stream[] streams = { ms1, ms2 };
    PdfDocumentBase.Merge(finalDoc, streams);
    MemoryStream ms3 = new MemoryStream();
    finalDoc.Save(ms3);
    ms3.Position = 0;
    // Save the MemoryStream into FileStreamResult
    FileStreamResult fileStreamResult = new FileStreamResult(ms3, "application/pdf");
    fileStreamResult.FileDownloadName = "Export.pdf";
    //Close the document.
    finalDoc.Close(true);
    //Disposes the streams.
    ms1.Dispose();
    ms2.Dispose();
    // return the file
    return fileStreamResult;
}

```

## Rotate a header text in the exported grid

Grid component provides support for customizing column header styles, including rotating the header text to a certain degree in the exported PDF file on the server side. To achieve this requirement, you can use the `BeginCellLayout` event of the `PdfExportProperties` class along with a custom event handler.

1. The [PdfHeaderQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfHeaderQueryCellInfo) event is triggered when creating a column header for the PDF document to be exported. In this event, you can collect the column header details and handle customizations.

9. In the `BeginCellLayout` event handler, you can use the `Graphics.DrawString` method to rotate the header text to the desired degree, will be triggered when creating a column header for the PDF document to be exported. Collect the column header details in this event and handle the custom in the `BeginCellLayout` event handler.

In the following demo, the `DrawString` method from the `Graphics` is used to rotate the header text of the column header inside the `BeginCellLayout` event handler.

> A PDF exporting is not supported to rotate the column header on the client side.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/rotate-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate-Header.cs" %}
{% include code-snippet/grid/pdf-export/rotate-header/rotate-header.cs %}
{% endhighlight %}
{% endtabs %}


## Passing additional parameters to the server while exporting

Passing additional parameters to the server when exporting data in the Syncfusion ASP.NET MVC Grid involves providing flexibility to include extra information or customize the export process based on specific requirements.

You can achieve this by utilizing the `Query` property and the `ToolbarClick` event. Within the `Query` property, you can invoke the `AddParams` method to add parameters to the request.

The following example demonstrates how to pass additional parameters to the server when PDF exporting within the `ToolbarClick` event. Within the event, the additional parameters, specifically **recordcount** as **15**, are passed using the addParams method and displayed as a message.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/additonal-parameter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate-Header.cs" %}
{% include code-snippet/grid/pdf-export/additonal-parameter/additional-parameter.cs %}
{% endhighlight %}
{% endtabs %}

![PDF-Export-Passing-Parameter](../images/pdf-export/passing-parameter.png)

## Limitations

* The export feature for detail and caption templates is not supported in server-side exporting.
* Multiple grids exporting feature is not supported with server side exporting.