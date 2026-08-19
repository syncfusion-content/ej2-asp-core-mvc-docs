---
layout: post
title: How to hide the default drop area in ASP.NET MVC File Upload | Syncfusion
description: Hide the default drop area in the Syncfusion ASP.NET MVC File Upload by overriding .e-upload, .e-file-select, and .e-file-drop styles with CSS.
platform: ej2-asp-core-mvc
control: Hide Default Drop Area
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to hide the default drop area in ASP.NET MVC File Upload

You can achieve this behavior by overriding the corresponding uploader styles. Override the following styles to hide the default drop area behavior.

    * .e-upload.e-control
    * .e-upload .e-file-select
    * .e-upload .e-file-drop

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/hide-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/hide-drop/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/hide-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/hide-drop/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to understand how to browse the files which you want to upload to the server.