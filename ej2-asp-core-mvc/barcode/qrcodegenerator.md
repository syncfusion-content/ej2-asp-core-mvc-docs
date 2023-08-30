---
layout: post
title: Qrcodegenerator in ##Platform_Name## Barcode Control | Syncfusion
description: Learn here all about Qrcodegenerator in Syncfusion ##Platform_Name## Barcode control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Qrcodegenerator
publishingplatform: ##Platform_Name##
documentation: ug
---


# ##Platform_Name## QR Code generator Control

## QR Code

A QR Code is a two-dimensional barcode that consists of a grid of dark and light dots or blocks that form a square. The data encoded in the barcode can be numeric, alphanumeric, or Shift Japanese Industrial Standards (JIS8) characters. The QR Code uses version from 1 to 40. Version 1 measures 21 modules x 21 modules, Version 2 measures 25 modules x 25 modules, and so on. The number of modules increases in steps of 4 modules per side up to Version 40 that measures 177 modules x 177 modules. Each version has its own capacity. By default, the barcode control automatically sets the version according to the length of the input text. The QR Barcodes are designed for industrial uses and also commonly used in consumer advertising.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/qrcode/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/qrcode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Qrcode.cs" %}
{% include code-snippet/barcode/qrcode/qrcode/qrcode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing the QR Code color

A page or printed media with QR Code often appears colorful in the background and surrounding region with other contents. In such cases, the QR Code can also be customized to suit the needs. You can achieve this by using for forecolor property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/color/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Color.cs" %}
{% include code-snippet/barcode/qrcode/color/color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing the QR Code dimension

The dimension of the QR Code can be changed using the height and width properties of the QR Code Generator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/dimension/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/dimension/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dimension.cs" %}
{% include code-snippet/barcode/qrcode/dimension/dimension.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing the text

In QR Code generators, you can customize the QR Code text by using display text property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/text/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/barcode/qrcode/text/text.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Barcode/QRCodeandDataMatrixSample).