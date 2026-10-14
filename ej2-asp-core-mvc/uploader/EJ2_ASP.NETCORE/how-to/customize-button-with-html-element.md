---
layout: post
title: How to customize browse button in ASP.NET Core Uploader | Syncfusion
description: Customize the Syncfusion ASP.NET Core File Upload browse button with an HTML element using the buttons property to render user-defined browse markup.
platform: ej2-asp-core-mvc
control: Customize Button With Html Element
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize the browse button with an HTML element

The Uploader control allows you to customize the action buttons by using the [`buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Buttons) property. Refer to the following example.

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



The output is shown below.

![uploader](../images/uploader-custom-button.png)

N> Explore the [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.