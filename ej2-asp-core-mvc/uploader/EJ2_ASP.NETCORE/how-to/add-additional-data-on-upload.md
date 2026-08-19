---
layout: post
title: How to add additional data on upload in ASP.NET Core File Upload | Syncfusion
description: Add additional form data to the Syncfusion ASP.NET Core File Upload by using the uploading event's customFormData argument sent to the server.
platform: ej2-asp-core-mvc
control: Add Additional Data On Upload
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add additional data on upload in ASP.NET Core File Upload

The uploader control allows you to add additional data on file upload, which is used to get in the server-side. By using [uploading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Uploading) event and its customFormData argument, you can achieve this behavior. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/additional-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/additional-data/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/additional-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/additional-data/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to understand how to browse the files which you want to upload to the server.