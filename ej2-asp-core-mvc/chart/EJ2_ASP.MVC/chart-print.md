---
layout: post
title: Chart Print in Syncfusion ##Platform_Name## Chart Component
description: Learn here all about Chart Print in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chart print
publishingplatform: ##Platform_Name##
documentation: ug
---

# Print and Export in ASP.NET Core Chart component

## Print

The rendered chart can be printed directly from the browser by calling the public method print. You can pass array of ID of elements or element to this method. By default it take element of the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/chart/getting-started/print/print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/chart/getting-started/print/print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export

The rendered chart can be exported to `JPEG`, `PNG`, `SVG`, `PDF`, `XLSX`, or `CSV` format using the export method in chart. The input parameters for this method are `Type` for format and `FileName` for result.

The optional parameters for this method are,
* `Orientation` - either portrait or landscape mode during PDF export,
* `Controls` - pass collections of controls for multiple export,
* `Width` - width of chart export,
* `Height` - height of chart export,
* `IsVertical` -  decides the chart export in vertical or horizontal direction,
* `Header` - header for the exported chart,
* `Footer` - footer for the exported chart, and
* `ExportToMultiplePages` - decides to export multiple charts on separate pages for PDF export.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/chart/getting-started/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/chart/getting-started/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Adding header and footer in PDF export

In the export method, specify the following parameters to add a header and footer text to the exported PDF document:

* `Header` - Specify the text that should appear at the top of the exported PDF document.
* `Footer` - Specify the text that should appear at the bottom of the exported PDF document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/header-footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header-footer.cs" %}
{% include code-snippet/chart/getting-started/header-footer/header-footer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/header-footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header-footer.cs" %}
{% include code-snippet/chart/getting-started/header-footer/header-footer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Exporting charts into separate page during the PDF export

During PDF export, set the `ExportToMultiplePage` parameter to **true** to export each chart as a separate page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/multi-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-page.cs" %}
{% include code-snippet/chart/getting-started/multi-page/multi-page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/multi-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-page.cs" %}
{% include code-snippet/chart/getting-started/multi-page/multi-page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->
**Export with optional parameters**
<!-- markdownlint-disable MD036 -->
The rendered chart can be exported to specific orientation, width and height by passing it as optional parameters in the export method of chart

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/export-optionalParameter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/chart/getting-started/export-optionalParameter/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/export-optionalParameter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/chart/getting-started/export-optionalParameter/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple chart export

You can export the multiple charts in single page by passing the multiple chart objects in the export method of chart. To export multiple charts in a single page, follow the given steps:

Initially, render more than one chart to export, and then add button to export the multiple charts. In button click, call the export method in charts, and then pass the multiple chart objects in the export method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/multi-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-export.cs" %}
{% include code-snippet/chart/getting-started/multi-export/multi-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/multi-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-export.cs" %}
{% include code-snippet/chart/getting-started/multi-export/multi-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Exporting chart using base64 string

The chart can be exported as an image in the form of a base64 string by utilizing HTML canvas. This process involves rendering the chart onto a canvas element and then converting the canvas content to a base64 string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/base64-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Base64-export.cs" %}
{% include code-snippet/chart/getting-started/base64-export/base64-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/base64-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Base64-export.cs" %}
{% include code-snippet/chart/getting-started/base64-export/base64-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Excel export

You can export the rendered chart data to Excel in either `XLSX` or `CSV` format. The `ExcelProperties` property in the `beforeExport` event allows users to customize the exported Excel sheet by modifying row, column, and cell properties before the file is generated. You can customize row titles, column titles, cell values, as well as row and column widths.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/excel-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-export.cs" %}
{% include code-snippet/chart/getting-started/excel-export/excel-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/excel-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-export.cs" %}
{% include code-snippet/chart/getting-started/excel-export/excel-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


