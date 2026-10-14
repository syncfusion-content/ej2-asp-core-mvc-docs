---
layout: post
title: Load webp format images in ##Platform_Name## Carousel | Syncfusion
description: Serve smaller webp images in the Syncfusion ##Platform_Name## Carousel for faster page loads without losing visual quality.
platform: ej2-asp-core-mvc
control: Load images in webp format  
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load webp format images in ##Platform_Name## Carousel

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