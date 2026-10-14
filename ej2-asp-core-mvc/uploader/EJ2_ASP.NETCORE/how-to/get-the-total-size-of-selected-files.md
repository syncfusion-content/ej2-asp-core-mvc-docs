---
layout: post
title: How to get total size of selected files in ##Platform_Name## | Syncfusion
description: Get the total size of selected files in the Syncfusion ASP.NET Core File Upload by summing file sizes inside the selected event before upload.
platform: ej2-asp-core-mvc
control: Get The Total Size Of Selected Files
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to get the total size of selected files in File Upload

You can get the total size of selected files before uploading them to the designated server. This can be achieved by handling the [`selected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Selected) event. Refer to the following example to calculate the total file size.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/file-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/file-size/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/file-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/file-size/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}


N> Explore the [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.