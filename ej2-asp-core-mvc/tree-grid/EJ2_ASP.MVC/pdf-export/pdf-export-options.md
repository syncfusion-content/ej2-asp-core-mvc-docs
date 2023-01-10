---
layout: post
title: PDF Export Options in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about PDF Export Options in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Export Options
publishingplatform: ##Platform_Name##
documentation: ug
---


# PDF Export Options

## To customize PDF export

PDF export provides an option to customize mapping of treegrid to exported PDF document.

### File name for exported document

You can assign the file name for the exported document by defining [`fileName`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#filename) property in [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#properties).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/file-name/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="File-name.cs" %}
{% include code-snippet/tree-grid/pdf-export/file-name/file-name.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/file-name/razor %}
{% endhighlight %}
{% highlight c# tabtitle="File-name.cs" %}
{% include code-snippet/tree-grid/pdf-export/file-name/file-name.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Default fonts for PDF exporting

By default, treegrid uses **Helvetica** font in the exported document. You can change the default font by using [`theme`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#theme) property in [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#properties).
The available default fonts are,

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

### Add custom font for PDF exporting

You can change the default font of TreeGrid header, content and caption cells in the exported document by using [`theme`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#theme) property in [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#properties).

In the following example, we have used Advent Pro font to export the treegrid with Hungarian fonts.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/custom-font/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-font.cs" %}
{% include code-snippet/tree-grid/pdf-export/custom-font/custom-font.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/custom-font/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-font.cs" %}
{% include code-snippet/tree-grid/pdf-export/custom-font/custom-font.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> **PdfTrueTypeFont** accepts base 64 format of the Custom Font.



### How to change page orientation

Page orientation can be changed Landscape(Default Portrait) for the exported document using the [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/page-orientation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page-orientation.cs" %}
{% include code-snippet/tree-grid/pdf-export/page-orientation/page-orientation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/page-orientation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Page-orientation.cs" %}
{% include code-snippet/tree-grid/pdf-export/page-orientation/page-orientation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### How to change page size

Page size can be customized for the exported document using the [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties).
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
{% include code-snippet/tree-grid/pdf-export/page-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page-size.cs" %}
{% include code-snippet/tree-grid/pdf-export/page-size/page-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/page-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Page-size.cs" %}
{% include code-snippet/tree-grid/pdf-export/page-size/page-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Export hidden columns

PDF export provides an option to export hidden columns of TreeGrid by defining the [`includeHiddenColumn`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#includehiddencolumn) as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/hidden-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hidden-column.cs" %}
{% include code-snippet/tree-grid/pdf-export/hidden-column/hidden-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/hidden-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hidden-column.cs" %}
{% include code-snippet/tree-grid/pdf-export/hidden-column/hidden-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Show or hide columns on exported PDF

You can show a hidden column or hide a visible column while exporting the treegrid using [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) and [`PdfExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~PdfExportComplete.html) events.

In [`ToolbarClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ToolbarClick.html) event, based on **args.item.text** as **PDF Export**. We can show or hide columns by setting [`Visible`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Visible.html) property to **true** or **false** respectively.

In [`PdfExportComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~PdfExportComplete.html) event, We have reversed the state back to the previous state.

In the below example, we have **Duration** as a hidden column in the treegrid. While exporting, we have changed **Duration** to visible column and **StartDate** as hidden column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/show-hide-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide-column.cs" %}
{% include code-snippet/tree-grid/pdf-export/show-hide-column/show-hide-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/show-hide-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide-column.cs" %}
{% include code-snippet/tree-grid/pdf-export/show-hide-column/show-hide-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.