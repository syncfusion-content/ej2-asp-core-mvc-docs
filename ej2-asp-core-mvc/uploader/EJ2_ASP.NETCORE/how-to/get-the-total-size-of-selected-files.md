---
layout: post
title: Get The Total Size Of Selected Files in ##Platform_Name## Uploader Component
description: Learn here all about Get The Total Size Of Selected Files in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Get The Total Size Of Selected Files
publishingplatform: ##Platform_Name##
documentation: ug
---


# Get the total size of selected files

You can get the total size of selected files before uploading it to the designated server. This can be achieved by using the [selected](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Selected) event. Refer to the following example to calculate the total file size.

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



> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.