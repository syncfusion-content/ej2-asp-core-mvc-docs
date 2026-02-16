---
layout: post
title: Pdf Export in ##Platform_Name## Syncfusion Pivot Table Component
description: Learn here all about Pdf Export in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# PDF Export in ##Platform_Name## Pivot Table Component

he ASP.NET MVC Pivot Table lets users easily export their pivot table data as a PDF document. By setting the [`AllowPdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowPdfExport) property to **true** in the Pivot Table configuration, users can enable PDF export. Once enabled, you can use the `pdfExport` method to generate and download the PDF file.

In the following example, an external button is used to start the PDF export process. When the user clicks the button, the `pdfExport` method is called so that the Pivot Table data can be saved as a PDF file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/pdf-export/export/Export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/pdf-export/export/Export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Multiple pivot table exporting

The PDF export option allows users to save data from multiple Pivot Tables into a single PDF file. Each Pivot Table appears on a separate page in the exported document, making it easy to review and share information from multiple tables at once.

To export multiple Pivot Tables into a single PDF document, use the `pdfExport` method. This method accepts the following parameters:

- `pdfExportProperties` (optional): Configures export export options for the table and chart. See the `pdfExportProperties` API reference for details.
- `isMultipleExport` (optional): Set to **true** for the first Pivot Table to create a new multi-page PDF file. For additional tables, set to **false** to add them to the same file.
- `pdfDoc` (optional): The PDF document object returned from the previous export. Use this to add more Pivot Tables to the same PDF.
- `isBlob` (optional): Set to **true** to save the PDF document as blob data.
- `exportBothTableAndChart` (optional): When the [`PivotViewDisplayOption`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html) property is set to **Both** this exports both table and chart data into a single PDF document.

**Steps to export multiple Pivot Tables:**

1. Call `pdfExport` on the first Pivot Table with `isMultipleExport` set to **true** to start the export process.
2. Once the PDF data for the first table is ready, pass it as the `pdfDoc` parameter to the next Pivot Table's `pdfExport` call with `isMultipleExport` set to **false**.
3. Repeat this process for each additional Pivot Table you want to include.

The following code example shows how clicking the Export button exports both tables to a single PDF file, with each table on its own page:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/multiple-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/multiple-export/MultipleExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/multiple-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/multiple-export/MultipleExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Export table and chart into the same document

If you want to export both the table and the chart from the Pivot Table into a single PDF file, set the [`PivotViewDisplayOption`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html) property to **Both**. Then, when you use the `pdfExport` method, make sure to set the `exportBothTableAndChart` option to **true**. This will include both the data table and its chart in one PDF document when you export.

The following example shows how you can set this up in your application:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/export-tableAndChart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="exportTableAndChart.cs" %}
{% include code-snippet/pivot-table/pdf-export/export-tableAndChart/exportTableAndChart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/export-tableAndChart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="exportTableAndChart.cs" %}
{% include code-snippet/pivot-table/pdf-export/export-tableAndChart/exportTableAndChart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customization during PDF export

PDF export provides option to customize mapping of pivot table to the exported PDF document.

### To add header and footer while exporting

When exporting data from the Pivot Table to a PDF document, you can include additional information in the header or footer. You can add text, lines, page numbers, or images to ensure your exported document includes important details, such as your organization's name or branding, and to improve readability.

To do this, you can use the `header` or `footer` options in the `PdfExportProperties`. These options allow you to specify what content to display at the top or bottom of each PDF page when exporting.

#### To add a text in header/footer

You can include custom text in the header or footer of the exported PDF document. Set the `type` property to **Text** in the contents array to add text. The following example shows how to add the text "Northwind Traders" to the header:

```javascript

var pdfExportProperties = {
    header: {
        fromTop: 0,
        height: 130,
        contents: [
            {
                type: 'Text',
                value: "Northwind Traders",
                position: { x: 0, y: 50 },
                style: { textBrushColor: '#000000', fontSize: 13 }
            },

        ]
    }
}

```

#### To draw a line in header/footer

You can draw lines in the header or footer to create visual separators or decorative elements. Set the `type` property to **Line** in the contents array to add line elements. The line can be styled with different dash patterns and colors.

**Supported line styles:**
* `solid` - Continuous line
* `dash` - Dashed line
* `dot` - Dotted line
* `dashdot` - Alternating dash and dot pattern
* `dashdotdot` - Dash followed by two dots pattern

The following example demonstrates how to add a solid line in the header:

```javascript

var pdfExportProperties = {
    header: {
        fromTop: 0,
        height: 130,
        contents: [
            {
                type: 'Line',
                style: { penColor: '#000080', penSize: 2, dashStyle: 'Solid' },
                points: { x1: 0, y1: 4, x2: 685, y2: 4 }
            }
        ]
    }
}

```

#### Add page number in header/footer

You can display page numbers in the header or footer using various numbering formats. Set the `type` property to **PageNumber** in the contents array to add page number elements. This helps users navigate through multi-page PDF documents easily.

**Supported page number types:**
* `LowerLatin` - Lowercase letters (a, b, c)
* `UpperLatin` - Uppercase letters (A, B, C)
* `LowerRoman` - Lowercase Roman numerals (i, ii, iii)
* `UpperRoman` - Uppercase Roman numerals (I, II, III)
* `Arabic` - Numbers (1, 2, 3)

The following example shows how to add page numbers with Arabic format in the header:

```javascript

 var pdfExportProperties = {
    header: {
        fromTop: 0,
        height: 130,
        contents: [
            {
                type: 'PageNumber',
                pageNumberType: 'Arabic',
                format: 'Page {$current} of {$total}', //optional
                position: { x: 0, y: 25 },
                style: { textBrushColor: '#ffff80', fontSize: 15, hAlign: 'Center' }
            }
        ]
    }
}

```

The below code illustrates the PDF export customization options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/header-footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/header-footer/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/header-footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/header-footer/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

#### Add an image in header/footer

You can include images in the header or footer by providing a Base64 encoded string. Set the `type` property to **Image** in the contents array to add image elements. This allows you to add logos, watermarks, or other visual elements to your PDF documents.

The following example demonstrates how to add an image to the header:

```typescript
var pdfExportProperties = {
    header: {
        fromTop: 0,
        height: 130,
        contents: [
            {
                type: 'Image',
                src: image,
                position: { x: 20, y: 10 },
                size: { height: 100, width: 100 },
            }
        ]
    }
}
```

The below code illustrates the PDF export customization options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/image-header-footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/image-header-footer/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/image-header-footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/image-header-footer/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Changing the file name while exporting

The PDF export provides an option to change the file name of the document before exporting. To change the file name, define the `fileName` property in the `pdfExportProperties` object and pass it as a parameter to the `pdfExport` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/file-name/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FileName.cs" %}
{% include code-snippet/pivot-table/pdf-export/file-name/FileName.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/file-name/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FileName.cs" %}
{% include code-snippet/pivot-table/pdf-export/file-name/FileName.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Changing page orientation while exporting

When exporting the Pivot Table as a PDF, users can choose the page orientation of the document. By default, the PDF is exported in **Portrait** orientation. If you want to change the orientation to **Landscape**, set the `pageOrientation` property in the `pdfExportProperties` object. Then, pass this object as a parameter to the `pdfExport` method. This lets you select either Portrait or Landscape orientation based on your needs before saving the exported PDF.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/page-layout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PageLayout.cs" %}
{% include code-snippet/pivot-table/pdf-export/page-layout/PageLayout.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/page-layout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PageLayout.cs" %}
{% include code-snippet/pivot-table/pdf-export/page-layout/PageLayout.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Changing page size while exporting

When exporting Pivot Table data to PDF, users can select a specific page size for the PDF document. To set the page size, define the `pageSize` property within the `pdfExportProperties` object, and pass this object as a parameter to the `pdfExport` method.

You can choose from various page sizes, such as Letter, Note, Legal, A0, A1, A2, A3, A5, A6, A7, A8, A9, B0, B1, B2, B3, B4, B5, Archa, Archb, Archc, Archd, Arche, Flsa, HalfLetter, Letter11x17, and Ledger.

This option lets users easily adjust the PDF layout to fit their specific needs before exporting the data from the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/page-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PageSize.cs" %}
{% include code-snippet/pivot-table/pdf-export/page-size/PageSize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/page-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PageSize.cs" %}
{% include code-snippet/pivot-table/pdf-export/page-size/PageSize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Changing document width and height while exporting

You can adjust the size of the exported PDF document by setting the `height` and `width` options in the [`BeforeExport`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeforeExport) event. This allows you to specify the dimensions of the PDF before creating it.

> Note: This option is available only when [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) is set to **true**. Also, make sure that both the `VirtualScroll` and `PDFExport` modules are added to the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exporting-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="exporting-customization.cs" %}
{% include code-snippet/pivot-table/pdf-export/exporting-customization/exporting-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exporting-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="exporting-customization.cs" %}
{% include code-snippet/pivot-table/pdf-export/exporting-customization/exporting-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Customize the table column count while exporting

Users can control how many Pivot Table columns appear on each page of the exported PDF by setting the `columnSize` option in the [`BeforeExport`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeforeExport) event. This allows users to split Pivot Table columns across multiple pages when exporting large tables to PDF, making the output easier to read.

> Note: This option works only when [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) is enabled in the Pivot Table settings. Also, make sure that both `VirtualScroll` and `PDFExport` modules are injected into the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exporting-columnCustomization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="exporting-columnCustomization.cs" %}
{% include code-snippet/pivot-table/pdf-export/exporting-columnCustomization/exporting-columnCustomization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exporting-columnCustomization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="exporting-columnCustomization.cs" %}
{% include code-snippet/pivot-table/pdf-export/exporting-columnCustomization/exporting-columnCustomization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Changing the table's column width and row height while exporting

You can adjust column width and row height in the PDF document when exporting data from the Pivot Table by handling the [OnPdfCellRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnPdfCellRender) event. To set the width of specific columns during export, use the `args.column.width` property inside this event.

For example, the **"Unit Sold"** column under **"FY 2015"** can be set to a width of **60** pixels as shown in the example below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exporting-columnWidthCustomization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="exporting-columnWidthCustomization.cs" %}
{% include code-snippet/pivot-table/pdf-export/exporting-columnWidthCustomization/exporting-columnWidthCustomization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exporting-columnWidthCustomization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="exporting-columnWidthCustomization.cs" %}
{% include code-snippet/pivot-table/pdf-export/exporting-columnWidthCustomization/exporting-columnWidthCustomization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Similarly, if you want to change the height of a particular row in the PDF document, you can use the `args.cell.height` property inside the same [OnPdfCellRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnPdfCellRender) event. For instance, the **"Mountain Bikes"** row under **"France"** can be set to a height of **30** pixels as shown below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exporting-rowHeightCustomization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="exporting-rowHeightCustomization.cs" %}
{% include code-snippet/pivot-table/pdf-export/exporting-rowHeightCustomization/exporting-rowHeightCustomization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exporting-rowHeightCustomization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="exporting-rowHeightCustomization.cs" %}
{% include code-snippet/pivot-table/pdf-export/exporting-rowHeightCustomization/exporting-rowHeightCustomization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> Note: To use this option, make sure that [EnableVirtualization](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) is set to **true**. Additionally, both `VirtualScroll` and `PDFExport` must be injected into the Pivot Table.

## Changing the pivot table style while exporting

When you export the Pivot Table as a PDF document, you can change the colors used for headers, captions, and records. To do this, use the `theme` property inside the `pdfExportProperties` object. Pass this object to the `pdfExport` method. This allows you to adjust how the Pivot Table looks in the exported PDF.

> By default, the Material theme is applied to the exported PDF document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/theme-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/theme-export/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/theme-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ThemeExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/theme-export/ThemeExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD009 -->

### Changing default font while exporting 

By default, the Pivot Table uses the "Helvetica" font in the exported PDF. You can change this font by setting the `theme` property in `pdfExportProperties`. The available built-in font options are:

- Helvetica
- TimesRoman
- Courier
- Symbol
- ZapfDingbats

```javascript

var pdfExportProperties = {
    theme: { 
                header: {font:  new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Bold) }, 
                caption: { font: new PdfStandardFont(PdfFontFamily.TimesRoman, 9) }, 
                record: { font: new PdfStandardFont(PdfFontFamily.TimesRoman, 10) } 
            } 
}

```

### Adding custom font while exporting

You can also use custom fonts when exporting if you need support for languages or styles that are not available in the built-in fonts. The custom font should be in **Base64** format and applied using the **PdfTrueTypeFont** class. In the example below, the **Advent Pro** font is used, which supports the Hungarian language.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/non-english-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Non-english-export.cs" %}
{% include code-snippet/pivot-table/pdf-export/non-english-export/non-english-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/non-english-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Non-english-export.cs" %}
{% include code-snippet/pivot-table/pdf-export/non-english-export/non-english-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> Non-English alphabets can also be exported correctly when you specify a suitable font.

## Virtual Scroll Data

When working with large amounts of data in the Pivot Table, the virtual scroll option allows users to efficiently export all the table data as a complete PDF document, without any slowdown or performance issues. This method uses PivotEngine export to manage and export extensive datasets smoothly. To use this option, make sure to enable the [`AllowPdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowPdfExport) property and use the `pdfExport` method in the Pivot Table.

> To use PivotEngine export, inject the `PDFExport` module into the Pivot Table.
> When virtual scrolling is enabled, PivotEngine export is used automatically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/engine-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/pdf-export/engine-export/Export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/engine-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/pdf-export/engine-export/Export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Repeat row headers

When exporting the Pivot Table as a PDF using the PivotEngine export option, the row headers are repeated on each page by default. This helps users easily identify rows when viewing larger tables split across multiple PDF pages.

If you want to turn off the repeated row headers in your PDF, set the `AllowRepeatHeader` property to **false** inside the `BeforeExport` event. Make sure you are using the `pdfExport` method with the PivotEngine export.

> To use PivotEngine export, inject the `PDFExport` module in the Pivot Table.
> By default, repeating row headers is enabled in the PivotEngine export.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/repeat-headers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/pdf-export/repeat-headers/Export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/repeat-headers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/pdf-export/repeat-headers/Export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Export all pages

The Pivot Table allows users to export the entire set of virtual data—meaning all records used to create the complete table—as a PDF document. By default, when virtual scrolling is enabled, the pivot engine will export all data. If you want to export only the data currently shown in the visible area of the Pivot Table, set the [`ExportAllPages`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ExportAllPages) property to **false**. To make use of the pivot engine export, include the `PDFExport` module in your Pivot Table.

> By default, the pivot engine export is performed automatically when virtual scrolling is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exportallpages/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Exportallpages.cs" %}
{% include code-snippet/pivot-table/pdf-export/exportallpages/exportallpages.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/exportallpages/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Exportallpages.cs" %}
{% include code-snippet/pivot-table/pdf-export/exportallpages/exportallpages.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### PdfQueryCellInfo

The `PdfQueryCellInfo` event occurs for each row and value cell while exporting the Pivot Table to a PDF. This event allows users to change the value, appearance, or other details of the current cell in the PDF file. The following parameters are available in this event:

- `value`: The content displayed in the cell.
- `column`: The column information for the current cell.
- `data`: The complete row data for the cell.
- `style`: The style properties that control how the cell looks in the PDF.

By using this event, users can easily update the cell text, apply different styles such as font or background color, or adjust other settings as needed during PDF export.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/pdf-querycell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PdfQueryCell.cs" %}
{% include code-snippet/pivot-table/grid-customization/pdf-querycell/PdfQueryCell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/pdf-querycell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PdfQueryCell.cs" %}
{% include code-snippet/pivot-table/grid-customization/pdf-querycell/PdfQueryCell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### PdfHeaderQueryCellInfo

The `PdfHeaderQueryCellInfo` event is triggered for each column header cell when exporting the Pivot Table to a PDF document. This event allows users to easily change values or apply styles to the column header cells in the exported PDF file.

The event provides the following parameters:

- `cell`: Gives information about the current header cell being exported.
- `style`: Contains style properties that can be used to format the cell.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/pdf-headercell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PdfHeader.cs" %}
{% include code-snippet/pivot-table/grid-customization/pdf-headercell/PdfHeader.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/pdf-headercell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PdfHeader.cs" %}
{% include code-snippet/pivot-table/grid-customization/pdf-headercell/PdfHeader.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ExportComplete

The [`ExportComplete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ExportComplete) event is triggered after the Pivot Table data has been successfully exported to a PDF document. This event allows you to access blob stream data for further processing by setting the `isBlob` parameter to **true** when calling the `pdfExport` method.

The event provides the following parameters:

* `type` - Specifies the current export type, such as PDF, Excel, or CSV.
* `promise` - Contains the promise object that resolves with blob data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/blob-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Blob-export.cs" %}
{% include code-snippet/pivot-table/pdf-export/blob-export/blob-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/blob-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Blob-export.cs" %}
{% include code-snippet/pivot-table/pdf-export/blob-export/blob-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Excel Exporting](./excel-export)