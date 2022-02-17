---
layout: post
title: Open And Edit The Uploaded Files in ##Platform_Name## Uploader Component
description: Learn here all about Open And Edit The Uploaded Files in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Open And Edit The Uploaded Files
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open and edit the uploaded files

The uploader control allows you to modify the file after uploading to the server, which can be achieved using [success](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Success) event of the uploader.

You can retrieve the saved file path in the uploader success event and assign it to custom attribute (data-file-name) value of the respective file list element to open the uploaded file. Click the respective file element to create a new request along with saved file path using http header. In the server-side, get the file path from the header and open the file using `process.start` method.

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



> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.