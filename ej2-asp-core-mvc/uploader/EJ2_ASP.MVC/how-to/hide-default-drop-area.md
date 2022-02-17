---
layout: post
title: Hide Default Drop Area in ##Platform_Name## Uploader Component
description: Learn here all about Hide Default Drop Area in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Hide Default Drop Area
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hide default drop area

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



> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.