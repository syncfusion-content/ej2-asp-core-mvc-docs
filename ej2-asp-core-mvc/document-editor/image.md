---
layout: post
title: Image in ##Platform_Name## Document Editor Component
description: Learn here all about Image in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Image
publishingplatform: ##Platform_Name##
documentation: ug
---


# Images

Document editor supports common raster format images like PNG, BMP, JPEG, and GIF. You can insert an image file or online image in the document using the `insertImage()` method. Refer to the following sample code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



Image files will be internally converted to base64 string. Whereas, online images are preserved as URL.

## Image resizing

Document editor provides built-in image resizer that can be injected into your application based on the requirements. This allows you to resize the image by dragging the resizing points using mouse or touch interactions. This resizer appears as follows.

![Image](images/image.JPG)

## Changing size

Document editor expose API to get or set the size of the selected image. Refer to the following sample code.

```typescript
documenteditor.selection.imageFormat.width = 800;
documenteditor.selection.imageFormat.height = 800;
```

> Images are stored and processed(read/write) as base64 string in DocumentEditor. The online image URL is preserved as a URL in DocumentEditor upon saving.

## Text wrapping style

Text wrapping refers to how images fit with surrounding text in a document. Please [refer to this page](../document-editor/text-wrapping-style) for more information about text wrapping styles available in Word documents.

## Positioning the image

DocumentEditor preserves the position properties of the image and displays the image based on position properties. It does not support modifying the position properties. Whereas the image will be automatically moved along with text edited if it is positioned relative to the line or paragraph.

## See Also

* [Feature modules](../../document-editor/feature-module/)
