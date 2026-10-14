---
layout: post
title: How to upload files programmatically in ##Platform_Name## | Syncfusion
description: Upload files programmatically in the Syncfusion ASP.NET MVC File Upload using the upload method and the getFilesData API to list selected files.
platform: ej2-asp-core-mvc
control: Achieve File Upload Programmatically
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to upload files programmatically in ASP.NET MVC File Upload

You can upload a file programmatically using the [`upload`](https://ej2.syncfusion.com/documentation/api/uploader/index-default#upload) method. The selected files data is obtained from the public [`getFilesData`](https://ej2.syncfusion.com/documentation/api/uploader/index-default#getfilesdata) method of the uploader.

The `upload` method behaves differently based on its arguments.
* If this method receives any files as arguments, only those files will start to upload.
* If it has no arguments, all the selected files will start to upload.

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

N> Explore the [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.