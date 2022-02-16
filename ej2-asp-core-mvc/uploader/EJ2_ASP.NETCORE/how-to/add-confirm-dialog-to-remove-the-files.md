---
layout: post
title: Add Confirm Dialog To Remove The Files in ##Platform_Name## Uploader Component
description: Learn here all about Add Confirm Dialog To Remove The Files in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Add Confirm Dialog To Remove The Files
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add confirm dialog to remove the files

You can customize the uploader control using confirm dialog before removing the files.
Here, ej2 dialog is used as confirm dialog. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/confirm-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/confirm-dialog/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/confirm-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/confirm-dialog/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.