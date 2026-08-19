---
layout: post
title: How to determine whether the File Upload has an input file in ASP.NET MVC File Upload | Syncfusion
description: Validate the Syncfusion ASP.NET MVC File Upload has a selected file by adding the required attribute and data-required-message on the input element.
platform: ej2-asp-core-mvc
control: Determine Whether The Uploader Has Input File
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to determine whether the File Upload has an input file in ASP.NET MVC File Upload

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



N> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to understand how to browse the files which you want to upload to the server.