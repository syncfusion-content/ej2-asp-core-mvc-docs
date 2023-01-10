---
layout: post
title: Add Confirm Dialog To Remove The Files in ##Platform_Name## Uploader Component
description: Learn here all about Add Confirm Dialog To Remove The Files in Syncfusion ##Platform_Name## Uploader component of Syncfusion Essential JS 2 and more.
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
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/dialog-confirm/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/dialog-confirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/dialog-confirm/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.