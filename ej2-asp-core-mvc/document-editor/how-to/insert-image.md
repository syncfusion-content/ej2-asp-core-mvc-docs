---
layout: post
title: Insert an image in ##Platform_Name## Document Editor Component | Syncfusion
description: Learn here all about how to Insert an image in Syncfusion ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Insert an image
publishingplatform: ##Platform_Name##
documentation: ug
---

# Insert an image in ##Platform_Name## Document editor

In this article, we are going to see how to insert an image in DocumentEditor.

Document Editor supports common raster format images like PNG, BMP, JPEG, SVG and GIF. You can insert image with base64 string, browse an image file and insert or online image in the document using the `insertImage()` method.

## Insert an image from a base64 string

The following example code illustrates how to insert an image with base64 string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/insert-image-base64/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-image-base64.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/insert-image-base64/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-image-base64.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

## Browse and insert an image in document editor

The following example code illustrates how to browse and insert an image.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/insert-image-browse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-image-browse.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/insert-image-browse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-image-browse.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

## Insert an image from a URL

The following example code illustrates how to insert an image from a URL.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/insert-image-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-image-url.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/insert-image-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-image-url.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}