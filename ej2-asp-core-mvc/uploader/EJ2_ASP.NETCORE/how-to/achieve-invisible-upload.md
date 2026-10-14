---
layout: post
title: How to achieve invisible upload in ##Platform_Name## | Syncfusion
description: Achieve an invisible upload in the Syncfusion ASP.NET Core File Upload by handling the selected event to process files without showing the UI.
platform: ej2-asp-core-mvc
control: Achieve Invisible Upload
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to achieve invisible upload in ASP.NET Core File Upload

You can achieve the invisible upload in the Uploader control by handling the [`selected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Selected) event.

Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/invisible/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/invisible/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/invisible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/invisible/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> Explore the [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.