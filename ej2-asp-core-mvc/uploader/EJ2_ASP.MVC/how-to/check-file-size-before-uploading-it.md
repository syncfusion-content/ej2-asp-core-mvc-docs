---
layout: post
title: How to check file size before upload in ##Platform_Name## | Syncfusion
description: Check the file size in the Syncfusion ASP.NET MVC File Upload before upload by reading the file size in the uploading event and converting via bytesToSize.
platform: ej2-asp-core-mvc
control: Check File Size Before Uploading It
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to check file size before upload in ASP.NET MVC File Upload

By using [uploading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Uploading) event, you can get the file size before upload it to server. 
File object contains the file size in bytes only. 
You can convert the size to standard formats (`KB` or `MB`) using **bytesToSize** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/check-file-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/check-file-size/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/check-file-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/check-file-size/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to understand how to browse the files which you want to upload to the server.