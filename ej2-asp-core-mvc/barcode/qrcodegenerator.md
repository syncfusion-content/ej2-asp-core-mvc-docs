---
layout: post
title: Qrcodegenerator in ##Platform_Name## Barcode Control | Syncfusion®
description: Learn here all about Qrcodegenerator in Syncfusion® ##Platform_Name## Barcode control of Syncfusion Essential® JS 2 and more.
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


## Enhancing QR Codes with Icons

The EJ2 Barcode Generator allows you to add a [`logo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BarcodeGenerator.QRCodeGenerator.html#Syncfusion_EJ2_BarcodeGenerator_QRCodeGenerator_Logo) or icon to your QR codes, enhancing their visual appeal, clarity, and even security. Adding a recognizable icon can make it easier for users to identify the source and help prevent tampering.

### Supported Image Sources
 
The `imageSource` property of the `QRCodeLogo` class supports the following image sources:
 
- **Local image path**: Specify the path to the image file relative to your project's root directory (e.g., `images/syncfusion.png`) or as an absolute path (e.g., `/assets/icons/logo.svg`).
- **Remote image URL**: Provide the web address of the image file (e.g., `https://example.com/image.jpg`).
- **Base64 encoded image data**: Embed the image data directly in the code using a Base64-encoded string (e.g., `data:image/png;base64,iVBORw0KGgoAAAANSUhEUg...`).

### Logo Dimensions
 
The `width` and `height` properties of the `QRCodeLogo` class define the dimensions of the logo in pixels. If not specified, both default to 30% of the QR code’s size. The maximum allowed size is 30% of the QR code’s dimensions to ensure optimal readability.

**Note:** Always test the readability of your QR code after adding a logo. Depending on the logo size and QR code content, you might need to adjust the [`errorCorrectionLevel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BarcodeGenerator.ErrorCorrectionLevel.html) property of the `QRCodeGenerator` to `"Medium"` or `"High"` for better reliability.

The following image illustrates QR code with logo:

![logo](images/logo.png)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/logo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/qrcode/logo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Logo.cs" %}
{% include code-snippet/barcode/qrcode/logo/logo.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Barcode/QRCodeandDataMatrixSample).
