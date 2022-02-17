---
layout: post
title: Resize Images Before Uploading It To The Server in ##Platform_Name## Uploader Component
description: Learn here all about Resize Images Before Uploading It To The Server in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Resize Images Before Uploading It To The Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Resize images before uploading it to the server

You can customize the dimension of the images before uploading it to the server.
By using selected event, you can get the selected file information as type of an object. From the obtained image file information, create a new canvas and render an image with the custom dimensions. Refer the corresponding code snippet as follows.

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



> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.