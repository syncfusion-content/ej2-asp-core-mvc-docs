---
layout: post
title: How to resize images before upload in ##Platform_Name## | Syncfusion
description: Resize images in the Syncfusion ASP.NET Core File Upload before upload by drawing the selected image on a canvas with custom dimensions in the selected event.
platform: ej2-asp-core-mvc
control: Resize Images Before Uploading It To The Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to resize images before uploading in ASP.NET Core File Upload

You can customize the dimensions of an image before uploading it to the server. Using the `selected` event, you can get the selected file information as an object. From this information, create a new canvas and render the image with custom dimensions. Refer to the following code snippet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/pre-resize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/pre-resize/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/pre-resize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/pre-resize/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Explore the [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.