---
title: "PDF Export"
component: "Gantt"
description: "Learn how to export Gantt data to PDF document in the Essential JS 2 Gantt control."
---

# PDF Export

PDF export allows exporting Gantt data to PDF document. You need to use the `pdfExport` method for exporting. To enable PDF export in the Gantt, set the [`allowPdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowPdfExport) to true.

To export data to PDF document, inject the `PdfExport` module in Gantt.

>Note: Currently, we don't have support for exporting the manually scheduled tasks.

{% aspTab template="gantt/pdf-export/pdfexport", sourceFiles="pdfexport.cs" %}

{% endaspTab %}

## Multiple exporting

PDF export provides an option for exporting multiple Gantt to same file. In this exported document, each Gantt will be exported to a new page of the document in same file.

{% aspTab template="gantt/pdfmultipleexport", sourceFiles="pdfmultipleexport.cs" %}

{% endaspTab %}

## To customize PDF export

PDF export provides an option to customize the mapping of Gantt to exported PDF document.

### File name for exported document

You can assign a file name for the exported document by defining the `fileName` property in `pdfExportProperties`.

{% aspTab template="gantt/pdf-export/filename", sourceFiles="file-name.cs" %}

{% endaspTab %}

### How to change page orientation

Page orientation can be changed to `Portrait` (Default Landscape) for the exported document using the property `pdfExportProperties.pageOrientation`.

{% aspTab template="gantt/pdf-export/pageorientation", sourceFiles="page-orientation.cs" %}

{% endaspTab %}

### How to change page size

Page size can be customized for the exported document using the property `pdfExportProperties.pageSize`.
The supported page sizes are:

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

{% aspTab template="gantt/pdf-export/page-size", sourceFiles="page-size.cs" %}

{% endaspTab %}

### Export current view data

PDF export provides an option to export the current view data into PDF. To export current view data alone, define the `exportType` to `CurrentViewData`.

{% aspTab template="gantt/pdf-export/currentviewdata", sourceFiles="current-view-data.cs" %}

{% endaspTab %}

### Enable footer

By default, we render the default footer for a PDF file, this can be enabled or disabled by using the `enableFooter` property.

{% aspTab template="gantt/pdf-export/footer", sourceFiles="footer.cs" %}

{% endaspTab %}

### Export hidden columns

PDF export provides an option to export hidden columns of Gantt by defining the `includeHiddenColumn` to `true`.

{% aspTab template="gantt/pdf-export/hiddencolumns", sourceFiles="hidden-columns.cs" %}

{% endaspTab %}

### Export predecessor lines

By using `showPredecessorLines`, you can hide or show predecessor lines in the exported PDF document.

{% aspTab template="gantt/pdf-export/connectorlines", sourceFiles="connector-lines.cs" %}

{% endaspTab %}

### Show or hide columns on exported PDF

You can show a hidden column or hide a visible column while exporting the Gantt using the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ToolbarClick) and [`beforePdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_BeforePdfExport) events.

You can show or hide columns by setting the `column.visible` property to `true` or `false` respectively.

In the following example, there is a hidden column `Duration` in the Gantt. While exporting, we have changed `Duration` to visible column and `StartDate` to hidden column.

{% aspTab template="gantt/pdf-export/showhidecolumns", sourceFiles="showhide-columns.cs" %}

{% endaspTab %}

### Conditional cell formatting

TreeGrid cells in the exported PDF can be customized or formatted using the [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_PdfQueryCellInfo) event. In this event, you can format the treegrid cells of exported PDF document based on the column cell value.

In the following sample, the background color is set for `Progress` column in the exported document by using the `args.style` and `backgroundColor` properties.

{% aspTab template="gantt/pdf-export/cellcustomization", sourceFiles="cell-customization.cs" %}

{% endaspTab %}

### Timeline cell formatting

Timeline cells in the exported PDF document can be customized or formatted using the [`pdfQueryTimelineCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_PdfQueryTimelineCellInfo) event.

In the following sample, the header background color is set for timeline cells in the exported document by using the `args.headerBackgroundColor` property.

{% aspTab template="gantt/pdf-export/timelinecustomization", sourceFiles="timeline-customization.cs" %}

{% endaspTab %}

### Taskbar formatting

Taskbars in the exported PDF document can be customized or formatted using the [`pdfQueryTaskbarInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_PdfQueryTaskbarInfo) event.

In the following sample, the taskbar background color is customized in the chart side of the exported document by using the `args.taskbar` property.

{% aspTab template="gantt/pdf-export/taskbarcustomization", sourceFiles="taskbar-customization.cs" %}

{% endaspTab %}

### Theme

PDF export provides an option to include theme for the exported PDF document.
To apply theme in exported PDF, define the `theme` in `pdfExportProperties`.
The available themes are:

* Material
* Fabric
* Bootstrap
* Bootstrap 4

{% aspTab template="gantt/pdf-export/themes", sourceFiles="themes.cs" %}

{% endaspTab %}

### Customized Theme

PDF export provides an option to customize the Gantt style for the exported PDF document.
To customize Gantt style in exported PDF, define the `ganttStyle` in `pdfExportProperties`.

{% aspTab template="gantt/pdf-export/customtheme", sourceFiles="custom-themes.cs" %}

{% endaspTab %}