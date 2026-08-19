---
layout: post
title: How to validate dropped images in ASP.NET MVC File Upload | Syncfusion
description: Validate image files on drop in the Syncfusion ASP.NET MVC File Upload by setting image/* in allowedExtensions or accept attribute and filtering in events.
platform: ej2-asp-core-mvc
control: Validate Image On Drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to validate dropped images in ASP.NET MVC File Upload

The uploader control allows you to select all types of images using the *image/ ** to [allowedExtensions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_AllowedExtensions) property. You can directly set it to accept the attribute of uploader element.

By default, it is working fine when you select a file by clicking the browse button. But, this behavior is not supported to drag and drop the files for selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/validate-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/validate-image/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/validate-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/validate-image/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to understand how to browse the files which you want to upload to the server.