---
layout: post
title: Load webp format image in ##Platform_Name## Accordion Control | Syncfusion
description: Learn here all about how to load webp format image in Syncfusion ##Platform_Name## Accordion control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load images in webp format  
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load webp format image in Carousel component

You can load the carousel image in the webp format, which aims to create smaller, better-looking images. Choosing webp as your image format can significantly improve your website's performance without sacrificing visual quality. webp images are significantly smaller in file size compared to formats like JPEG and PNG. This results in faster load times and less data usage. To achieve this, you can convert your image format to webp and pass them to Carousel items. The following sample illustrates how to load a carousel image in the webp format component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/how-to/carousel-webp/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/how-to/carousel-webp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Wizard.cs" %}
{% include code-snippet/carousel/how-to/carousel-webp/carousel-webp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}