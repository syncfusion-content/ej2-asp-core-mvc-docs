---
layout: post
title: How to check if uploader has input in ##Platform_Name## | Syncfusion
description: Validate the Syncfusion ASP.NET Core File Upload has a selected file by adding the required attribute and data-required-message on the input element.
platform: ej2-asp-core-mvc
control: Determine Whether The Uploader Has Input File
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to check if ASP.NET Core File Upload has an input file

You can validate whether the file input has a value by setting the **required** attribute on the uploader input element.

The following sample sets the required attribute on the uploader input element and shows the validation error message using the `data-required-message` attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/required/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/required/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/required/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/required/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Explore the [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.