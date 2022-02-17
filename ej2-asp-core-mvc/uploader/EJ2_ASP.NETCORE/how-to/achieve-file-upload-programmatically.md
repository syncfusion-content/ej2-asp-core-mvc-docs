---
layout: post
title: Achieve File Upload Programmatically in ##Platform_Name## Uploader Component
description: Learn here all about Achieve File Upload Programmatically in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Achieve File Upload Programmatically
publishingplatform: ##Platform_Name##
documentation: ug
---


# Achieve file upload programmatically

You can upload a file programmatically using upload method.
The selected files data, get from getFilesData public method in uploader.

The upload method behaves differently based on its arguments.
* If this method receives any files as arguments, those files only start to upload.
* If it has no argument then all the selected files are will start to upload.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/dynamic-upload/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/dynamic-upload/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/dynamic-upload/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/dynamic-upload/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.