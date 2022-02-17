---
layout: post
title: Pdf Export in ##Platform_Name## Pivot Table Component
description: Learn here all about Pdf Export in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# PDF Export

PDF export allows exporting pivot table data as PDF document. To enable PDF export in the pivot table, set the `AllowPdfExport` as true. You need to use the `pdfExport` method for PDF exporting.

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

PDF export provides an option for exporting multiple pivot tables to same file. In this exported document, each pivot table will be exported to new page of document in same file.

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



## Customization during PDF export

PDF export provides option to customize mapping of pivot table to the exported PDF document.

### To add header and footer

You can customize text, page number, line, page size and changing orientation in header and footer.

#### How to write a text in header/footer

You can add text either in header or footer of the exported PDF document like in the below code example.

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

#### How to draw a line in header/footer

You can add line either in header or footer of the exported PDF document like in the below code example.

Supported line styles:
* dash
* dot
* dashdot
* dashdotdot
* solid

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

You can add page number either in header or footer of exported PDF document like in the below code example.

Supported page number types:
* LowerLatin - a, b, c,
* UpperLatin - A, B, C,
* LowerRoman - i, ii, iii,
* UpperRoman - I, II, III,
* Number - 1,2,3.

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



### To change page orientation

Page orientation can be changed to "Landscape" (by default it's "Portrait") for the exported document using `pdfExportProperties`.

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



### To change page size

Page size can be customized for the exported document using `pdfExportProperties`.
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



### Theme

PDF export provides an option to include theme for exported PDF document.

To apply theme in exported PDF, define the `theme` in `pdfExportProperties`.

> By default, material theme is applied to exported PDF document.

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



## Virtual Scroll Data

You can export the pivot table virtual scroll data as PDF document by using PivotEngine export without any performance degradation. To enable PivotEngine export in the pivot table, set the `allowPdfExport` as true. You need to use the `exportToPDF` method for PivotEngine export.

> PivotEngine export will be performed while enabling virtual scrolling by default

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

Repeat row headers on each page can be achieved using PivotEngine export option. To disable repeat row headers, you need to set `allowRepeatHeader` to **false** in beforeExport event. You need to use the `exportToPDF` method for PivotEngine export.

> By default, repeat row headers is enabled in the PivotEngine export.

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



## See Also

* [Excel Exporting](./excel-export)