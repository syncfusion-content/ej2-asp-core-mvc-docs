---
layout: post
title: Export in ##Platform_Name## Diagram Component
description: Learn here all about Export in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting

Diagram provides support to export its content as image/svg files.
The client-side method [`exportDiagram`](https://ej2.syncfusion.com/documentation/api/diagram/#exportDiagram) helps to export the diagram. The following code illustrates how to export the diagram as image.

> To use Print and Export, you need to inject `PrintAndExport` in the diagram.

<!-- markdownlint-disable MD033 -->

```javascript
var diagram = new Diagram({
    width: 1500, height: 1500
});
diagram.appendTo('#element');
var options = {};
options.mode = 'Data';
diagram.exportDiagram(options);
```

## Exporting options

Diagram provides support to export the desired region of the diagram to desired formats.

## File Name

[`FileName`](https://ej2.syncfusion.com/documentation/api/diagram/iExportOptions/) is the name of the file to be downloaded. By default, the file name is set to **Diagram**.

## Format

[`Format`](https://ej2.syncfusion.com/documentation/api/diagram/iExportOptions/) is to specify the type/format of the exported file. By default, the diagram is exported as .jpg format. You can export diagram to the following formats:

* JPG
* PNG
* BMP
* SVG

```javascript
var diagram = new Diagram({
    width: 1500, height: 1500
});
diagram.appendTo('#element');
var options = {};
options.mode = 'Data';
options.format = 'SVG';
diagram.exportDiagram(options);
```

## Margin

[`Margin`](https://ej2.syncfusion.com/documentation/api/diagram/iExportOptions/#margin) specifies the amount of space that has to be left around the diagram.

<!-- markdownlint-disable MD033 -->

```javascript
var diagram = new Diagram({
    width: 1500, height: 1500
});
diagram.appendTo('#element');
var options = {};
options.mode = 'Data';
options.margin = { left: 10, right: 10, top: 10, bottom: 10};
options.fileName = 'format';
options.format = 'SVG';
diagram.exportDiagram(options);

```

## Mode

[`Mode`](https://ej2.syncfusion.com/documentation/api/diagram/iExportOptions/#mode) specifies whether the diagram is to be exported as files or as data (ImageURL/SVG). The exporting options are as follows:

* Data: Exports and downloads the diagram as image.
* Download: Exports the diagram as data of formats ImageURL/SVG.

For more information about the exporting modes, refer to Exporting Modes.

The following code example illustrates how to export the diagram as raw data.

```javascript
var diagram = new Diagram({
    width: 1500, height: 1500
});
diagram.appendTo('#element');
var options = {};
options.mode = 'Data';
options.margin = { left: 10, right: 10, top: 10, bottom: 10};
options.fileName = 'format';
options.format = 'SVG';
diagram.exportDiagram(options);

```

## Region

You can export any particular [`region`](https://ej2.syncfusion.com/documentation/api/diagram/iExportOptions/#region) of the diagram and the region is categorized as follows.

* Region that fits all nodes and connectors that are added to model.
* Region that fits all pages (single or multiple pages based on page settings).

For more information about region, refer to Regions.

The following code example illustrates how to export the region occupied by the diagram elements.

```javascript

var diagram = new Diagram({
    width: 1500, height: 1500
});
diagram.appendTo('#element');
var options = {};
options.mode = 'Data';
options.margin = { left: 10, right: 10, top: 10, bottom: 10};
options.fileName = 'format';
options.format = 'SVG';
options.region = 'Content';
diagram.exportDiagram(options);

```

## Custom bounds

Diagram provides support to export any specific region of the diagram by using [`bounds`](https://ej2.syncfusion.com/documentation/api/diagram/iExportOptions/#region).

The following code example illustrates how to export the region occupied by the diagram elements.

```javascript

var diagram = new Diagram({
    width: 1500, height: 1500
});
diagram.appendTo('#element');
var options = {};
options.mode = 'Data';
options.margin = { left: 10, right: 10, top: 10, bottom: 10};
options.fileName = 'region';
options.format = 'SVG';
options.region = 'CustomBounds';
options.bounds.x = 10;
options.bounds.y = 10;
options.bounds.height = 100;
options.bounds.width = 100;
diagram.exportDiagram(options);
```

## Export diagram with stretch option

Diagram provides support to export the diagram as image for [`stretch`](https://ej2.syncfusion.com/documentation/api/diagram/iExportOptions/#stretch) option. The exported images will be clearer but larger in file size.

The following code example illustrates how to export the region occupied by the diagram elements.

```javascript

var diagram = new Diagram({
    width: 1500, height: 1500
});
diagram.appendTo('#element');
var options = {};
options.mode = 'Data';
options.margin = { left: 10, right: 10, top: 10, bottom: 10};
options.fileName = 'region';
options.format = 'SVG';
options.region = 'Content';
options.stretch = 'Stretch';
diagram.exportDiagram(options);
```

## Print

The client-side method [`print`](https://ej2.syncfusion.com/documentation/api/diagram/#print) helps to print the diagram as image.

| Name | Type | Description|
|-------- | -------- | -------- |
| region | enum | Sets the region of the diagram to be printed. |
| bounds | object | Prints any custom region of diagram. |
| stretch| enum | Resizes the diagram content to fill its allocated space and printed.|
| multiplePage | boolean | Prints the diagram into multiple pages. |
| pageWidth | number | Sets the page width of the diagram while printing the diagram into multiple pages. |
| pageHeight| number | Sets the page height of the diagram while printing the diagram into multiple pages.|
| pageOrientation | enum | Sets the orientation of the page. |

The following code example illustrates how to export the region occupied by the diagram elements.

```javascript

var diagram = new Diagram({
    width: 1500, height: 1500
});
diagram.appendTo('#element'););
var options = {};
options.mode = 'Data';
options.region = 'PageSettings';
options.multiplePage = true;
options.pageHeight = 300;
options.pageWidth = 300;
diagram.print(options);
```
