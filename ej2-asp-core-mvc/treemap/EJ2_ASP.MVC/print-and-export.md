---
layout: post
title: Print And Export in ##Platform_Name## Treemap Component
description: Learn here all about Print And Export in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: Print And Export
publishingplatform: ##Platform_Name##
documentation: ug
---

# Print and Export

## Print

To use the print functionality, we should set the [`allowPrint`](https://ej2.syncfusion.com/documentation/api/treemap/#allowprint) property to **true**. The rendered treemap can be printed directly from the browser by calling the method [`print`](https://ej2.syncfusion.com/documentation/api/treemap/#print).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/print-export/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/treemap/print-export/print/print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/print-export/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/treemap/print-export/print/print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export

### Image Export

To use the image export functionality, we should set the [`allowImageExport`](https://ej2.syncfusion.com/documentation/api/treemap/#allowimageexport) property to **true**. The rendered treemap can be exported as an image using the [`export`](https://ej2.syncfusion.com/documentation/api/treemap/#export) method. The method requires two parameters: image type and file name. The treemap can be exported as an image in the following formats.

* JPEG
* PNG
* SVG

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/print-export/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/treemap/print-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/print-export/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/treemap/print-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



We can get the image file as base64 string for the JPEG and PNG formats. The treemap can be exported to image as a base64 string using the [`export`](https://ej2.syncfusion.com/documentation/api/treemap/#export) method. There are four parameters required: image type, file name, orientation of the exported PDF document which must be set as **null** for image export and finally **allowDownload** which should be set as **false** to return base64 string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/print-export/base64/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/treemap/print-export/base64/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/print-export/base64/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/treemap/print-export/base64/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### PDF Export

To use the PDF export functionality, we should set the [`allowPdfExport`](https://ej2.syncfusion.com/documentation/api/treemap/#allowpdfexport) property to **true**. The rendered treemap can be exported as PDF using the [`export`](https://ej2.syncfusion.com/documentation/api/treemap/#export) method. The [`export`](https://ej2.syncfusion.com/documentation/api/treemap/#export) method requires three parameters: file type, file name and orientation of the PDF document. The orientation setting is optional and **0** indicates portrait and **1** indicates landscape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/print-export/exportPdf/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/treemap/print-export/exportPdf/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/print-export/exportPdf/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/treemap/print-export/exportPdf/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>The exporting of the treemap as base64 string is not supported in the PDF export.