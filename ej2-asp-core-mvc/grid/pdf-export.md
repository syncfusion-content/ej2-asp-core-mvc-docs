---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Pdf Export of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# PDF Export

PDF export allows exporting Grid data to PDF document. You need to use the
 `PdfExport` method for exporting. To enable PDF export in the grid, set the [`AllowPdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_AllowPdfExport_System_Boolean_) as true.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="pdf-export" %}
{% include_relative code-snippet/pdf-export/pdf-export/pdf-export.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="pdf-export" %}
{% include_relative code-snippet/pdf-export/pdf-export/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="pdf-export" %}
{% include_relative code-snippet/pdf-export/pdf-export/pdf-export.cs %}
{% endhighlight %}
{% highlight razor tabtitle="pdf-export" %}
{% include_relative code-snippet/pdf-export/pdf-export/razor %}
{% endhighlight %}
{% endtabs %}



## Multiple exporting

PDF export provides an option for exporting multiple grids to same file. In this exported document, each grid will be exported to new page of document in same file.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="multiple" %}
{% include_relative code-snippet/pdf-export/multiple/multiple.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="multiple" %}
{% include_relative code-snippet/pdf-export/multiple/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="multiple" %}
{% include_relative code-snippet/pdf-export/multiple/multiple.cs %}
{% endhighlight %}
{% highlight razor tabtitle="multiple" %}
{% include_relative code-snippet/pdf-export/multiple/razor %}
{% endhighlight %}
{% endtabs %}



## To customize PDF export

PDF export provides an option to customize mapping of grid to exported PDF document.

### File Name for Exported document

You can assign the file name for the exported document by defining `fileName` property in [`PdfExportProperties`](./api/grid#pdfExportProperties).

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="export-filename" %}
{% include_relative code-snippet/pdf-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="export-filename" %}
{% include_relative code-snippet/pdf-export/export-filename/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="export-filename" %}
{% include_relative code-snippet/pdf-export/export-filename/export-filename.cs %}
{% endhighlight %}
{% highlight razor tabtitle="export-filename" %}
{% include_relative code-snippet/pdf-export/export-filename/razor %}
{% endhighlight %}
{% endtabs %}



### Default Fonts for PDF exporting

By default, grid uses `Helvetica` font in the exported document. You can change the default font by using `pdfExportProperties.theme` property. The available default fonts are,

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

### Add Custom Font for PDF exporting

You can change the default font of Grid header, content and caption cells in the exported document by using `pdfExportProperties.theme` property.

In the following example, we have used Advent Pro font to export the grid with Hungarian fonts.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="customfont" %}
{% include_relative code-snippet/pdf-export/customfont/customfont.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="customfont" %}
{% include_relative code-snippet/pdf-export/customfont/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="customfont" %}
{% include_relative code-snippet/pdf-export/customfont/customfont.cs %}
{% endhighlight %}
{% highlight razor tabtitle="customfont" %}
{% include_relative code-snippet/pdf-export/customfont/razor %}
{% endhighlight %}
{% endtabs %}



> `ej.pdfexport.PdfTrueTypeFont` accepts base 64 format of the Custom Font.

### To add header and footer

You can customize text, page number, line, page size and changing orientation in header and footer.

#### How to write a text in header/footer

You can add text either in Header or Footer of exported PDF document.

```typescript

var exportProperties = {
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

```

#### How to draw a line in header/footer

you can add line either in Header or Footer of the exported PDF document.

Supported line styles:
* dash
* dot
* dashdot
* dashdotdot
* solid

```typescript

var exportProperties = {
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

you can add page number either in Header or Footer of exported PDF document.

Supported page number types:
* LowerLatin - a, b, c,
* UpperLatin - A, B, C,
* LowerRoman - i, ii, iii,
* UpperRoman - I, II, III,
* Number - 1,2,3.

```typescript

 var exportProperties = {
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

#### Insert an image in header/footer

Image (Base64 string) can be added in the exported document in header/footer using the `exportProperties`.

```typescript

var exportProperties = {
    header: {
        fromTop: 0,
        height: 130,
        contents: [
            {
                type: 'Image',
                src: image,
                position: { x: 40, y: 10 },
                size: { height: 100, width: 250 },
            }
        ]
    }
}

```

The below code illustrates the pdf export customization.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="header-footer" %}
{% include_relative code-snippet/pdf-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="header-footer" %}
{% include_relative code-snippet/pdf-export/header-footer/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="header-footer" %}
{% include_relative code-snippet/pdf-export/header-footer/header-footer.cs %}
{% endhighlight %}
{% highlight razor tabtitle="header-footer" %}
{% include_relative code-snippet/pdf-export/header-footer/razor %}
{% endhighlight %}
{% endtabs %}



### How to change page orientation

Page orientation can be changed Landscape(Default Portrait) for the exported document using the `exportProperties`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="orientation" %}
{% include_relative code-snippet/pdf-export/orientation/orientation.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="orientation" %}
{% include_relative code-snippet/pdf-export/orientation/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="orientation" %}
{% include_relative code-snippet/pdf-export/orientation/orientation.cs %}
{% endhighlight %}
{% highlight razor tabtitle="orientation" %}
{% include_relative code-snippet/pdf-export/orientation/razor %}
{% endhighlight %}
{% endtabs %}



### How to change page size

Page size can be customized for the exported document using the `exportProperties`.
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

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="page-size" %}
{% include_relative code-snippet/pdf-export/page-size/page-size.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="page-size" %}
{% include_relative code-snippet/pdf-export/page-size/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="page-size" %}
{% include_relative code-snippet/pdf-export/page-size/page-size.cs %}
{% endhighlight %}
{% highlight razor tabtitle="page-size" %}
{% include_relative code-snippet/pdf-export/page-size/razor %}
{% endhighlight %}
{% endtabs %}



### Export current page

PDF export provides an option to export the current page into PDF. To export current page, define the `exportType` to `currentpage`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="export-current" %}
{% include_relative code-snippet/pdf-export/export-current/export-current.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="export-current" %}
{% include_relative code-snippet/pdf-export/export-current/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="export-current" %}
{% include_relative code-snippet/pdf-export/export-current/export-current.cs %}
{% endhighlight %}
{% highlight razor tabtitle="export-current" %}
{% include_relative code-snippet/pdf-export/export-current/razor %}
{% endhighlight %}
{% endtabs %}



### Export hidden columns

PDF export provides an option to export hidden columns of Grid by defining the `includeHiddenColumn` as `true`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="export-hidden" %}
{% include_relative code-snippet/pdf-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="export-hidden" %}
{% include_relative code-snippet/pdf-export/export-hidden/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="export-hidden" %}
{% include_relative code-snippet/pdf-export/export-hidden/export-hidden.cs %}
{% endhighlight %}
{% highlight razor tabtitle="export-hidden" %}
{% include_relative code-snippet/pdf-export/export-hidden/razor %}
{% endhighlight %}
{% endtabs %}



### Show or Hide columns on Exported PDF

You can show a hidden column or hide a visible column while exporting the grid using [`toolbarClick`](./api/grid#toolbarclick) and [`pdfExportComplete`](./api/grid#pdfExportComplete) events.

In the `toolbarClick` event, based on `args.item.id` as `Grid_pdfexport`. We can show or hide columns by setting `column.visible` property to `true` or `false` respectively.

In the pdfExportComplete event, We have reversed the state back to the previous state.

In the below example, we have `CustomerID` as a hidden column in the grid. While exporting, we have changed `CustomerID` to visible column and `ShipCity` as hidden column.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="show-hide" %}
{% include_relative code-snippet/pdf-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="show-hide" %}
{% include_relative code-snippet/pdf-export/show-hide/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="show-hide" %}
{% include_relative code-snippet/pdf-export/show-hide/show-hide.cs %}
{% endhighlight %}
{% highlight razor tabtitle="show-hide" %}
{% include_relative code-snippet/pdf-export/show-hide/razor %}
{% endhighlight %}
{% endtabs %}



### Conditional Cell Formatting

Grid cells in the exported PDF can be customized or formatted using [`pdfQueryCellInfo`](./api/grid#pdfQueryCellInfo) event. In this event, we can format the grid cells of exported PDF document based on the column cell value.

In the below sample, we have set the `background` color for `Freight` column in the exported document by `args.cell` and `backgroundColor` property.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="pdf-export" %}
{% include_relative code-snippet/pdf-export/pdf-export/pdf-export.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="pdf-export" %}
{% include_relative code-snippet/pdf-export/pdf-export/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="pdf-export" %}
{% include_relative code-snippet/pdf-export/pdf-export/pdf-export.cs %}
{% endhighlight %}
{% highlight razor tabtitle="pdf-export" %}
{% include_relative code-snippet/pdf-export/pdf-export/razor %}
{% endhighlight %}
{% endtabs %}



### Theme

PDF export provides an option to include theme for exported PDF document.

To apply theme in exported PDF, define the `theme` in `exportProperties` .

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="theme" %}
{% include_relative code-snippet/pdf-export/theme/theme.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="theme" %}
{% include_relative code-snippet/pdf-export/theme/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="theme" %}
{% include_relative code-snippet/pdf-export/theme/theme.cs %}
{% endhighlight %}
{% highlight razor tabtitle="theme" %}
{% include_relative code-snippet/pdf-export/theme/razor %}
{% endhighlight %}
{% endtabs %}



> By default, material theme is applied to exported PDF document.

## Custom data source

PDF export provides an option to define datasource dynamically before exporting. To export data dynamically, define the `dataSource` in `exportProperties`

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="custom-data" %}
{% include_relative code-snippet/pdf-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="custom-data" %}
{% include_relative code-snippet/pdf-export/custom-data/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="custom-data" %}
{% include_relative code-snippet/pdf-export/custom-data/custom-data.cs %}
{% endhighlight %}
{% highlight razor tabtitle="custom-data" %}
{% include_relative code-snippet/pdf-export/custom-data/razor %}
{% endhighlight %}
{% endtabs %}



## Export the hierarchy grid

The grid have an option to export the hierarchy grid to pdf document. By default, grid will exports the master grid with expanded child grids alone. you can change the exporting option by using the `PdfExportProperties.hierarchyExportMode` property. The available options are,

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the master grid with expanded child grids. |
| All      | Exports the master grid with all the child grids. |
| None     | Exports the master grid alone. |

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="hierarchy" %}
{% include_relative code-snippet/pdf-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="hierarchy" %}
{% include_relative code-snippet/pdf-export/hierarchy/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="hierarchy" %}
{% include_relative code-snippet/pdf-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% highlight razor tabtitle="hierarchy" %}
{% include_relative code-snippet/pdf-export/hierarchy/razor %}
{% endhighlight %}
{% endtabs %}



## Repeat column header on every page

By default, column header will be placed on the first page of the pdf document but you can display column header on every page using `repeatHeader` property of `pdfGrid`.

In the below sample, we have enabled `repeatHeader` property in `pdfHeaderQueryCellInfo` event to show the header on every page.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight  tabtitle="repeat-header" %}
{% include_relative code-snippet/pdf-export/repeat-header/repeat-header %}
{% endhighlight %}
{% highlight cshtml tabtitle="repeat-header" %}
{% include_relative code-snippet/pdf-export/repeat-header/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight  tabtitle="repeat-header" %}
{% include_relative code-snippet/pdf-export/repeat-header/repeat-header %}
{% endhighlight %}
{% highlight razor tabtitle="repeat-header" %}
{% include_relative code-snippet/pdf-export/repeat-header/razor %}
{% endhighlight %}
{% endtabs %}


