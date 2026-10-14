---
layout: post
title: How to check the MIME type of a file in ##Platform_Name## | Syncfusion
description: Check the MIME type of a file in the Syncfusion ASP.NET MVC File Upload before upload by reading the file object inside the uploading event handler.
platform: ej2-asp-core-mvc
control: Check The Mime Type Of File Before Upload It
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to check MIME type before upload in ASP.NET MVC File Upload

By using the [`uploading`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Uploading) event, you can get the file MIME type before uploading it to the server.

In this following sample, the file MIME type is shown in an alert before the file starts uploading.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/mime-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/mime-type/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/mime-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/mime-type/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Explore the [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.