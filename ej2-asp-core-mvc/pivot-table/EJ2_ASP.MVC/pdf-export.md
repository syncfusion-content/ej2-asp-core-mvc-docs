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

The ASP.NET Core Pivot Table lets users easily export their pivot table data as a PDF document. By setting the [`AllowPdfExport`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowPdfExport) property to **true** in the Pivot Table configuration, users can enable PDF export. Once enabled, you can use the `pdfExport` method to generate and download the PDF file.

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

## Multiple Pivot Table exporting

Multiple Pivot Tables can be exported to the same or different pages in a single PDF file for easy comparison. Each Pivot Table requires a unique HTML element ID, such as **PivotTable1** and **PivotTable2**. To export multiple Pivot Tables, provide their IDs in the `pivotTableIds` property of the [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html), then pass the configured [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html) to the `pdfExport` method with `isMultipleExport` set to **true** to enable multiple Pivot Table export mode.

> Note: PivotView PDF export uses Grid's PdfExportProperties model for configuration.

### Same page

To export multiple Pivot Tables on the same page, set the `multipleExport.type` property to **AppendToPage** in [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html). Blank space between the Pivot Tables can be added by using the `multipleExport.blankSpace` property.

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

### New page

To export each Pivot Table on a separate page, set the `multipleExport.type` property to **NewPage** in [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/multiple-export-with-new-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleExportNewPage.cs" %}
{% include code-snippet/pivot-table/pdf-export/multiple-export-with-new-page/MultipleExportNewPage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/multiple-export-with-new-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleExportNewPage.cs" %}
{% include code-snippet/pivot-table/pdf-export/multiple-export-with-new-page/MultipleExportNewPage.cs %}
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

To do this, you can use the `header` or `footer` options in the [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html). These options allow you to specify what content to display at the top or bottom of each PDF page when exporting.

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
let pdfExportProperties: PdfExportProperties = {
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

### Changing the file name while exporting

The PDF export provides an option to change the file name of the document before exporting. To change the file name, define the `fileName` property in the [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html) object and pass it as a parameter to the `pdfExport` method.

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

When exporting the Pivot Table as a PDF, users can choose the page orientation of the document. By default, the PDF is exported in **Portrait** orientation. If you want to change the orientation to **Landscape**, set the `pageOrientation` property in the [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html) object. Then, pass this object as a parameter to the `pdfExport` method. This lets you select either Portrait or Landscape orientation based on your needs before saving the exported PDF.

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

When exporting Pivot Table data to PDF, users can select a specific page size for the PDF document. To set the page size, define the `pageSize` property within the [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html) object, and pass this object as a parameter to the `pdfExport` method.

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

The column width and row height in the PDF document can be adjusted when exporting data from the Pivot Table by handling the [`pdfHeaderQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfHeaderQueryCellInfo) and [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) events. These changes apply only to the exported PDF and do not affect the on-screen Pivot Table display.

#### Adjusting column width

To set the width of specific columns during export, use the [`pdfHeaderQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfHeaderQueryCellInfo) event. This event triggers for each header cell during PDF export. Check if the current header cell matches the target column by comparing the level name using `args.gridCell.valueSort.levelName`, which contains the exact row and column level name of the current cell. If it matches, use the column index (`args.gridCell.colIndex`) to locate the column in the `pdfGrid` columns collection, which holds the current PDF grid and allows adjustment of specific column widths during export. Then set the **width** property with the desired value in **points**.

For example, the **"Units Sold"** column under **"FY 2015"** can be set to a width of **250 points**:

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

#### Adjusting row height

To change the height of a particular row in the PDF document, use the [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event. Check if the current row matches the target row by comparing the row headers using `args.data.rowHeaders`, which holds the string value of the row header level names. If it matches, set the `args.cell.gridRow.height` property with the desired value in **points**.

For example, the **"Mountain Bikes"** row under **"France"** can be set to a height of **100 points**:

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

### Customize the pivot report during export

The Pivot Table report can be modified before exporting by applying filters, adding formatting, or performing drill operations. These modifications apply only to the Pivot Table exported to the PDF file and do not affect the Pivot Table displayed on the screen. To modify the export behavior, use the [`BeforeExport`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeforeExport) event. This event is triggered right before the export operation begins.

In the following example, the [`BeforeExport`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeforeExport) event is used to expand all Pivot Table headers by setting the [`ExpandAll`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) property to **true**. The `generateGridData` method is then called to obtain the updated [`pivotValues`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PivotValues). The updated [`pivotValues`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PivotValues) are assigned to `args.dataCollections` for the export. Finally, [`expandAll`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) is set to **false** again to restore the original state of the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/customizing-pivot-report/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizingPivotReport.cs" %}
{% include code-snippet/pivot-table/pdf-export/customizing-pivot-report/CustomizingPivotReport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/customizing-pivot-report/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizingPivotReport.cs" %}
{% include code-snippet/pivot-table/pdf-export/customizing-pivot-report/CustomizingPivotReport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Exporting with row and column cells spanning

Exporting data from the Pivot Table with cell spanning preserves the row and column cell layout in the exported PDF. The [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event allows customization of cell span properties during the PDF export process to match the Pivot Table UI layout.

In the [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event, customize the following cell span properties:

- `args.cell.rowSpan` - Defines the number of rows a cell should span in the exported PDF.
- `args.cell.colSpan` - Defines the number of columns a cell should span in the exported PDF.

In the following code example, the row and column spans are adjusted for empty cells in the Pivot Table and during PDF export.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/export-row-column-spanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExportWithCellSpanning.cs" %}
{% include code-snippet/pivot-table/pdf-export/export-row-column-spanning/ExportWithCellSpanning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/export-row-column-spanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExportWithCellSpanning.cs" %}
{% include code-snippet/pivot-table/pdf-export/export-row-column-spanning/ExportWithCellSpanning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Exporting with hyperlinks and images

The Pivot Table allows adding hyperlinks and images to cells during PDF export. The [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event handles row and value cells, while the [`pdfHeaderQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfHeaderQueryCellInfo) event handles header cells. Both events provide access to the `hyperlink` property to set URLs in cells and the `image` property to add images to cells.

> PDF export supports base64 strings for exporting images.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/export-hyperlinks-images/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExportHyperlinksImages.cs" %}
{% include code-snippet/pivot-table/pdf-export/export-hyperlinks-images/ExportHyperlinksImages.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/export-hyperlinks-images/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExportHyperlinksImages.cs" %}
{% include code-snippet/pivot-table/pdf-export/export-hyperlinks-images/ExportHyperlinksImages.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Exporting with custom aggregates

The Pivot Table supports exporting data with custom calculations beyond the default options such as **Sum**, **Count**, or **Average**. Custom aggregates allow for advanced analytical scenarios where standard calculations are not sufficient.

To export with custom aggregates, follow these steps:

1. Define custom aggregate names using the [localization](https://ej2.syncfusion.com/aspnetmvc/documentation/pivot-table/globalization-and-localization#localization) option. These names appear in the Pivot Table's aggregation menu.
2. Add custom aggregation types to the aggregate menu during Pivot Table initialization using the [`DataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event.
3. Use the [`aggregateCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pivotview.pivotview.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event to define the calculation logic for each custom type. This event triggers for every aggregate cell, allowing custom calculations to be applied.
4. Once the calculations are defined, call the `pdfExport` method to export the Pivot Table with all custom aggregations applied.

For more information about adding custom aggregation types, see the [custom aggregation documentation](./how-to/add-custom-aggregation-type-in-menu).

The following example shows how to add two custom aggregate types to the aggregate menu: **CustomAggregateType 1**, which calculates a weighted average, and **CustomAggregateType 2**, which calculates the percentage of the total.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/custom-aggregate-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregateExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/custom-aggregate-export/CustomAggregateExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/custom-aggregate-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAggregateExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/custom-aggregate-export/CustomAggregateExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Exporting with custom date format

The Pivot Table component allows applying custom date formatting to date-type fields added to the row and column axes. This formatting maintains consistency between the rendered pivot table and the exported PDF file. Configure custom date formatting through the [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) property by following these steps:

1. Set the [`Name`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) property to the target date field.
2. Set the [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Type) property to **date** to identify the field as a date type.
3. Set the [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) property to the desired date format pattern (for example, `"EEE, MMM d, ''yy"`).

After configuration, call the `pdfExport` method to export the Pivot Table with the applied formatting.

The following example demonstrates exporting a Pivot Table with a custom date format. The date field uses the pattern `"EEE, MMM d, ''yy"` to display dates in the format: weekday abbreviation, month abbreviation, day, and two-digit year (for example, Sun, May 8, '23).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/custom-date-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDateExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/custom-date-export/CustomDateExport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/custom-date-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDateExport.cs" %}
{% include code-snippet/pivot-table/pdf-export/custom-date-export/CustomDateExport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Changing the pivot table style while exporting

When you export the Pivot Table as a PDF document, you can change the colors used for headers, captions, and records. To do this, use the `theme` property inside the [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html) object. Pass this object to the `pdfExport` method. This allows you to adjust how the Pivot Table looks in the exported PDF.

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

### Changing default font while exporting 

By default, the Pivot Table uses the "Helvetica" font in the exported PDF. You can change this font by setting the `theme` property in [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html). The available built-in font options are:

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

### Apply custom styles based on specific conditions

When exporting Pivot Table data to PDF, custom styles can be applied to cells based on their values or other criteria. To apply custom styles, use the [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event. In this event, the cell information can be accessed through the `args.data` property, and its style properties, such as `backgroundColor`, `fontFamily`, and `textPenColor`, can be customized. These changes apply only to the exported PDF and do not affect the on-screen Pivot Table display

The following example demonstrates how to apply conditional formatting to the **Sold** field values in the exported PDF document. Values below **700** units are highlighted in **red**, while values of **700** units or more are highlighted in **green**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/apply-custom-styles/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ApplyCustomStyles.cs" %}
{% include code-snippet/pivot-table/pdf-export/apply-custom-styles/ApplyCustomStyles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/apply-custom-styles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ApplyCustomStyles.cs" %}
{% include code-snippet/pivot-table/pdf-export/apply-custom-styles/ApplyCustomStyles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Enabling horizontal overflow

The Pivot Table component supports exporting all columns on a single page in the exported PDF document, even if the number of columns exceeds the maximum page limits. This functionality ensures readability and comprehensiveness of the exported PDF. To enable this option, set the [AllowHorizontalOverflow](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html#Syncfusion_EJ2_GridExport_PdfExportProperties_AllowHorizontalOverflow) property in the [`pdfExportProperties`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.GridExport.PdfExportProperties.html) object to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/horizontal-overflow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HorizontalOverflow.cs" %}
{% include code-snippet/pivot-table/pdf-export/horizontal-overflow/HorizontalOverflow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/horizontal-overflow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HorizontalOverflow.cs" %}
{% include code-snippet/pivot-table/pdf-export/horizontal-overflow/HorizontalOverflow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Export only the current page

By default, the Pivot Table exports all data records. When working with large datasets, this can result in larger file sizes. To optimize file size and performance, only the data records currently visible in the viewport can be exported by setting the [`ExportAllPages`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ExportAllPages) property to **false**.

> This option is applicable only when the virtualization or paging functionality is enabled.

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

## Repeat row headers

By default, row headers are repeated on each page when exporting the Pivot Table as a PDF. This allows easy identification of rows in larger tables that extend across multiple pages. To turn off repeated row headers, set the `allowRepeatHeader` property to **false** within the [`BeforeExport`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeforeExport) event.

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

## Repeat column headers on every page

By default, column headers are repeated on each page when exporting the Pivot Table as a PDF. This ensures consistent column identification across multi-page documents. To prevent column headers from repeating on each page, use the [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event. In this event, access the `pdfGrid` object through `args.cell.row.pdfGrid`, which holds the current PDF grid and allows component over the repeat header behavior. Then set its `repeatHeader` property to **false** to disable the repetition.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/repeat-column-headers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RepeatColumnHeaders.cs" %}
{% include code-snippet/pivot-table/pdf-export/repeat-column-headers/RepeatColumnHeaders.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/repeat-column-headers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RepeatColumnHeaders.cs" %}
{% include code-snippet/pivot-table/pdf-export/repeat-column-headers/RepeatColumnHeaders.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Show spinner during export

When exporting data, displaying a spinner provides visual feedback to users that the export process is in progress. To show a spinner, invoke the `showWaitingPopup` method in the button's click event before calling the `pdfExport` method. After the export is complete, use the [`ExportComplete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ExportComplete) event to trigger the `hideWaitingPopup` method, which hides the spinner and indicates that the export has finished.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/show-spinner/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowSpinner.cs" %}
{% include code-snippet/pivot-table/pdf-export/show-spinner/ShowSpinner.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pdf-export/show-spinner/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowSpinner.cs" %}
{% include code-snippet/pivot-table/pdf-export/show-spinner/ShowSpinner.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### PdfQueryCellInfo

The `pdfQueryCellInfo` event occurs for each row and value cell while exporting the Pivot Table to a PDF. This event allows users to change the value, appearance, or other details of the current cell in the PDF file. The following parameters are available in this event:

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

The `pdfHeaderQueryCellInfo` event is triggered for each column header cell when exporting the Pivot Table to a PDF document. This event allows users to easily change values or apply styles to the column header cells in the exported PDF file.

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