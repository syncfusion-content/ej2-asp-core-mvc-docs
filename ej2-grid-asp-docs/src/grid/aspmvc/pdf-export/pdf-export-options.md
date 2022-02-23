# PDF Export Options

## Export current page

PDF export provides an option to export the current page into PDF. To export current page, define the [`exportType`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#exporttype) of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties) to **currentpage**.

{% aspTab template="grid/pdf-export/export-current", sourceFiles="export-current.cs" %}

{% endaspTab %}

## Export the selected records only

You can export the selected records data by passing it to [`dataSource`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#datasource) of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties) in the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

In the below exporting demo, We can get the selected records using **getSelectedRecords** method and pass the selected data to **PdfExport** or **excelExport** property.

{% aspTab template="grid/how-to/export-selected-data", sourceFiles="selected-data.cs" %}

{% endaspTab %}

## Export filtered data only

You can export the filtered data by defining the resulted data in [`dataSource`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#datasource) property of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties) before export.

In the below Pdf exporting demo, We have gotten the filtered data by applying filter query to the grid data and then defines the resulted data in [`dataSource`](https://ej2.syncfusion.com/documentation/api/grid/excelExportProperties/#datasource) property and pass it to [`PdfExport`](https://ej2.syncfusion.com/documentation/api/grid/#pdfexport) method.

{% aspTab template="grid/how-to/export-filtered-data", sourceFiles="export-filtered-data.cs" %}

{% endaspTab %}

## Export hidden columns

PDF export provides an option to export hidden columns of Grid by defining the [`includeHiddenColumn`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#includehiddencolumn) of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties) as **true**.

{% aspTab template="grid/pdf-export/export-hidden", sourceFiles="export-hidden.cs" %}

{% endaspTab %}

## Show or hide columns

You can show a hidden column or hide a visible column while exporting the grid using [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) and [`pdfExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfExportComplete) events.

In the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, based on **args.item.id** as **Grid_pdfexport**. We can show or hide columns by setting [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Visible) property to **true** or **false** respectively.

In the [`pdfExportComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfExportComplete) event, We have reversed the state back to the previous state.

In the below example, we have **CustomerID** as a hidden column in the grid. While exporting, we have changed **CustomerID** to visible column and **ShipCity** as hidden column.

{% aspTab template="grid/pdf-export/show-hide", sourceFiles="show-hide.cs" %}

{% endaspTab %}

## Change page orientation

Page orientation can be changed Landscape(Default Portrait) for the exported document using the [`pageOrientation`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pageorientation)of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties).

{% aspTab template="grid/pdf-export/orientation", sourceFiles="orientation.cs" %}

{% endaspTab %}

## Change page size

Page size can be customized for the exported document using the [`pageSize`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pagesize) property of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties).
Supported page sizes are:
* Letter
* Note
* Legal
* A0
* A1
* A2
* A3
* A5
* A6
* A7
* A8
* A9
* B0
* B1
* B2
* B3
* B4
* B5
* Archa
* Archb
* Archc
* Archd
* Arche
* Flsa
* HalfLetter
* Letter11x17
* Ledger

{% aspTab template="grid/pdf-export/page-size", sourceFiles="page-size.cs" %}

{% endaspTab %}

## Define file name

You can assign the file name for the exported document by defining [`fileName`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#filename) property in [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties).

{% aspTab template="grid/pdf-export/export-filename", sourceFiles="export-filename.cs" %}

{% endaspTab %}

## Font customization

### Default fonts

By default, grid uses **Helvetica** font in the exported document. You can change the default font by using [`theme`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#theme) property of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties). The available default fonts are,

* Helvetica
* TimesRoman
* Courier
* Symbol
* ZapfDingbats

The code example for changing default font,

```typescript

    let pdfExportProperties = {
        theme: {
            header: {font:  new ej.pdfexport.PdfStandardFont(ej.pdfexport.PdfFontFamily.TimesRoman, 11, PdfFontStyle.Bold),
            caption: { font: new ej.pdfexport.PdfStandardFont(ej.pdfexport.PdfFontFamily.TimesRoman, 9) },
            record: { font: new ej.pdfexport.PdfStandardFont(ej.pdfexport.PdfFontFamily.TimesRoman, 10) }
        }
    };

```

### Add custom font

You can change the default font of Grid header, content and caption cells in the exported document by using [`theme`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#theme) property of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties) property.

In the following example, we have used Advent Pro font to export the grid with Hungarian fonts.

{% aspTab template="grid/pdf-export/customfont", sourceFiles="customfont.cs" %}

{% endaspTab %}

> **ej.pdfexport.PdfTrueTypeFont** accepts base 64 format of the Custom Font.