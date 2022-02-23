# Export Multiple Grids

The excel export provides an option to export multiple grid data in the same excel file.

## Same sheet

The excel export provides support to export multiple grids in same sheet. To export in same sheet, define **multipleExport.type** as **AppendToSheet** in **exportProperties**. It have an option to provide blank rows between grids. These blank rows count can be defined by using the **multipleExport.blankRows**.

{% aspTab template="grid/excel-export/same-sheet", sourceFiles="same-sheet.cs" %}

{% endaspTab %}

> By default, **multipleExport.blankRows** value is 5.

## New sheet

Excel exporting provides support to export multiple grids in new sheet. To export in new sheet, define  **multipleExport.type** as **NewSheet** in **exportProperties**.

{% aspTab template="grid/excel-export/new-sheet", sourceFiles="new-sheet.cs" %}

{% endaspTab %}