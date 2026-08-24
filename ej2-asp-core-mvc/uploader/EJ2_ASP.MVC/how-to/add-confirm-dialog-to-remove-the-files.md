---
layout: post
title: How to add a confirmation dialog in ##Platform_Name## Uploader | Syncfusion
description: Add a confirmation dialog to the Syncfusion ASP.NET MVC File Upload before removing files by integrating the EJ2 Dialog component on the click event.
platform: ej2-asp-core-mvc
control: Add Confirm Dialog To Remove The Files
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add a confirmation dialog when removing files in ASP.NET MVC

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



N> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to understand how to browse the files which you want to upload to the server.