---
layout: post
title: How to customize the browse button in ##Platform_Name## Uploader | Syncfusion
description: Customize the Syncfusion ASP.NET Core File Upload browse button with an HTML element using the buttons property to render user-defined browse markup.
platform: ej2-asp-core-mvc
control: Customize Button With Html Element
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize the browse button with an HTML element in ASP.NET Core

The uploader control allows you to customize the action buttons by using [buttons](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Buttons) &nbsp;property. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/buttons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/buttons/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/buttons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/buttons/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![uploader](../images/uploader-custom-button.png)

N> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to understand how to browse the files which you want to upload to the server.