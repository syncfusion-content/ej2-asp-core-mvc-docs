---
layout: post
title: Determine Whether The Uploader Has Input File in ##Platform_Name## Uploader Component
description: Learn here all about Determine Whether The Uploader Has Input File in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Determine Whether The Uploader Has Input File
publishingplatform: ##Platform_Name##
documentation: ug
---


# Determine whether uploader has file input (required validation)

By setting **required** attribute to uploader input element, you can validate the file input has any value in it.
In the below sample, set required attribute to the uploader input element and showcase the validation failure message using `data-required-message` attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/required-field/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/required-field/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/required-field/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.