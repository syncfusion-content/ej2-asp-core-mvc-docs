---
layout: post
title: Header and footer of PDF export in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Header and footer of PDF export in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customizing header and footer of PDF export

PDF export provides an option to specify and customize text, page number, line and image in header and footer of exported PDF document by using [pdfExportProperties](https://ej2.syncfusion.com/documentation/api/gantt/pdfExportProperties/#properties).

## Write a text in header and footer

This functionality helps to customize the text that appears in the header or footer sections of a PDF document. Text can be added to [header](https://helpej2.syncfusion.com/documentation/api/gantt/pdfHeader/) or [footer](https://helpej2.syncfusion.com/documentation/api/gantt/pdfFooter/) of exported PDF document by using [pdfExportProperties](https://helpej2.syncfusion.com/documentation/api/gantt/pdfExportProperties/).

* `type` property in the content array indicates the content type, such as 'Text'.
* `Value` property determines the text. 
* `Position` property determines the horizontal and vertical positions of the text element.
* `style` property define the visual styling properties for the text element

```ts

let exportProperties: PdfExportProperties = {
    header: {
        fromTop: 0,
        height: 130,
        contents: [
            {
                type: 'Text',
                value: 'INVOICE',
                position: { x: 380, y: 0 },
                style: { textBrushColor: '#C25050', fontSize: 25 },
            },

        ]
    }

```

## Draw a line in header and footer

This functionality helps to customize the line that appears in the header or footer sections of the PDF document. A line can be added to [header](https://helpej2.syncfusion.com/documentation/api/gantt/pdfHeader/) or [footer](https://helpej2.syncfusion.com/documentation/api/gantt/pdfFooter/) of the exported PDF document by using [pdfExportProperties](https://helpej2.syncfusion.com/documentation/api/gantt/pdfExportProperties/).

* `type` determines content type, such as 'Line'.
* `style` is used to set properties like the color (penColor), size (penSize), and style (dashStyle) of the line.
* `points` specifies the coordinates for the start and end points of the line.

Supported line styles:
* dash
* dot
* dashdot
* dashdotdot
* solid

```ts

let exportProperties: PdfExportProperties = {
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

## Add page number in header and footer

This feature allows to customize the page number that appears in the header or footer sections of the PDF document. Page numbers can be added in [header](https://helpej2.syncfusion.com/documentation/api/gantt/pdfHeader/) or [footer](https://helpej2.syncfusion.com/documentation/api/gantt/pdfFooter/) of the exported PDF document by using [pdfExportProperties](https://helpej2.syncfusion.com/documentation/api/gantt/pdfExportProperties/).

* `type` indicates that the content is a page number.
* `pageNumberType` specifies the type of numbering to be used.
* `format` is an optional attribute that allows you to customize the text format of the page number.
* `position` defines the coordinates (x, y) where the page number will be located.
* `style` sets the styling properties of the page number text, such as color (textBrushColor), font size (fontSize), and horizontal alignment (hAlign).

Supported page number types:
* LowerLatin - a, b, c,
* UpperLatin - A, B, C,
* LowerRoman - i, ii, iii,
* UpperRoman - I, II, III,
* Number - 1,2,3.

```ts

 let exportProperties: PdfExportProperties = {
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

## Insert an image in header and footer

This feature allows to customize the image that appears in the header or footer sections of the PDF document. Image (Base64 string) can be added in the exported document in [header](https://helpej2.syncfusion.com/documentation/api/gantt/pdfHeader/) or [footer](https://helpej2.syncfusion.com/documentation/api/gantt/pdfFooter/) of the exported PDF document by using [pdfExportProperties](https://helpej2.syncfusion.com/documentation/api/gantt/pdfExportProperties/).

* `type` indicates that the content is an image.
* `src` specifies the source of the image, which should be Base64 string. 
* `Position` determines the horizontal and vertical positions of the image will be located.
* `size` sets the dimensions of the image.

>Note: PDF Export supports base64 string to export the images.

```ts
// Replace it with a valid Base64-encoded image.
let image: string = "/9j/4AAQSkZJRgABAQEAeAB4AAD..." 

let exportProperties: PdfExportProperties = {
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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdf-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PDF-customization.cs" %}
{% include code-snippet/gantt/pdf-export/pdf-customization/pdf-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdf-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PDF-customization.cs" %}
{% include code-snippet/gantt/pdf-export/pdf-customization/pdf-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Disable footer 

By default, the exported PDF file includes a footer. The footer can be disabled by setting the `enableFooter` property to `false`. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Footer.cs" %}
{% include code-snippet/gantt/pdf-export/footer/footer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Footer.cs" %}
{% include code-snippet/gantt/pdf-export/footer/footer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}