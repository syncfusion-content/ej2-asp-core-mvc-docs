---
layout: post
title: Print in ##Platform_Name## Maps Component
description: Learn here all about Print in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Print
publishingplatform: ##Platform_Name##
documentation: ug
---

# Print and Export in ASP.NET Core Maps component

## Print

The rendered Maps can be printed directly from the browser by calling the [`print`](https://ej2.syncfusion.com/documentation/api/maps/#print) method. To use the print functionality, set the [`AllowPrint`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_AllowPrint) property to "**true**".

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/maps/print-export/print/print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/maps/print-export/print/print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Print](../maps/images/Print/print.png)

## Export

### Image Export

To use the image export functionality in Maps, set the `AllowImageExport` property to **true**. The rendered map can be exported as an image using the `export` method. This method requires two parameters: image type and file name. The Maps can be exported as an image in the following formats.

* JPEG
* PNG
* SVG

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/maps/print-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/maps/print-export/export/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Image export](../maps/images/Print/export.png)

### Exporting Maps as base 64 string of the file

The image can be exported as base64 string for the JPEG and PNG formats. The rendered Maps can be exported to image as a base64 string using the `export` method. There are four parameters required: image type, file name, orientation of the exported PDF document which must be set as **null** for image export and finally **allowDownload** which should be set as **false** to return base64 string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/base64/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/maps/print-export/base64/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/base64/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/maps/print-export/base64/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### PDF Export

To use the PDF export functionality, set the `AllowPdfExport` property to **true**. The rendered Maps can be exported as PDF using the `export` method. The `export`  method requires three parameters: file type, file name and orientation of the PDF document. The orientation setting is optional and **0** indicates portrait and **1** indicates landscape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/exportPdf/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/maps/print-export/exportPdf/export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/exportPdf/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/maps/print-export/exportPdf/export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![PDF export](../maps/images/Print/export.png)

### Export the tile Maps

The rendered Maps with providers such as OSM, Bing and Google static Maps can be exported using the `export` method. It supports the following export formats.

* JPEG
* PNG
* PDF

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/export-tile/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-tile.cs" %}
{% include code-snippet/maps/print-export/export-tile/export-tile.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/print-export/export-tile/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-tile.cs" %}
{% include code-snippet/maps/print-export/export-tile/export-tile.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Tile export](../maps/images/Print/osm-export.png)