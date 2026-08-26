---
layout: post
title: How to open and edit uploaded files in ##Platform_Name## | Syncfusion
description: Open and edit uploaded files in the Syncfusion ASP.NET MVC File Upload by storing the path in the success event and serving it from the server.
platform: ej2-asp-core-mvc
control: Open And Edit The Uploaded Files
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to open and edit uploaded files in ASP.NET MVC File Upload

The Uploader control allows you to open the file after uploading it to the server. You can achieve this using the [`success`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Success) event of the Uploader.

In the success event, retrieve the saved file path and assign it to the custom attribute (data-file-name) of the corresponding file list element. When you click the file element, a new request is sent along with the saved file path using an HTTP header. On the server-side, get the file path from the header and open the file using the `Process.Start` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/server-side/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-side.cs" %}
{% include code-snippet/uploader/server-side/server-side.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/server-side/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-side.cs" %}
{% include code-snippet/uploader/server-side/server-side.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Explore the [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.