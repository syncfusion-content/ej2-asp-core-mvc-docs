---
layout: post
title: How to hide the default drop area in ##Platform_Name## | Syncfusion
description: Hide the default drop area in the Syncfusion ASP.NET MVC File Upload by overriding .e-upload, .e-file-select, and .e-file-drop styles with CSS.
platform: ej2-asp-core-mvc
control: Hide Default Drop Area
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to hide the default drop area in ASP.NET MVC File Upload

You can achieve this behavior by overriding the corresponding Uploader styles to hide the default drop area.

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

N> Explore the [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.