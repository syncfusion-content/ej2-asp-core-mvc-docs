---
layout: post
title: Check The Mime Type Of File Before Upload It in ##Platform_Name## Uploader Component
description: Learn here all about Check The Mime Type Of File Before Upload It in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Check The Mime Type Of File Before Upload It
publishingplatform: ##Platform_Name##
documentation: ug
---


# Check the MIME type of file before upload it

By using [uploading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Uploading) event, you can get the file MIME type before uploading it to server.
In the below sample, file MIME type is shown in the alert box before file start to upload.

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


> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.