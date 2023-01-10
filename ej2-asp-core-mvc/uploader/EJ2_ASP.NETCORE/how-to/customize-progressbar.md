---
layout: post
title: Customize Progressbar in ##Platform_Name## Uploader Component
description: Learn here all about Customize Progressbar in Syncfusion ##Platform_Name## Uploader component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize Progressbar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize progressbar

You can customize the progress bar’s size, color, and background by overriding  the styles in uploader control. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/progress-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/progress-customize/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/progress-customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/progress-customize/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.