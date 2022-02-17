---
layout: post
title: Getting Started with ##Platform_Name## Uploader Component
description: Checkout and learn about getting started with ##Platform_Name## Uploader component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include a simple Uploader in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part part of the system requirements and configure the common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our controls.

## Initialize Uploader control to the Application

Uploader control can be rendered by using the `ejs-uploader` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the Uploader.

The following example shows a basic Uploader control.

> From v16.2.41 version, the `Essential JS2 AJAX` library has been integrated for uploader server requests.
Hence, use the third party `promise` library like blue-bird to use the uploader in Internet Explorer.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% include code-snippet/uploader/getting-started/getting-started.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% include code-snippet/uploader/getting-started/getting-started.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Running the above code will display the basic Uploader on the browser.

Output be like the below.

![uploader](./images/uploader-getting.png)

## Adding drop area

By default, the uploader control allows to upload files by drag the files from file explorer, and drop into the drop area.  You can configure any other external element as drop target using [dropArea](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_DropArea) property.

In the following sample, drop target is configured.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/drop-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drop-area.cs" %}
{% include code-snippet/uploader/drop-area/drop-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/drop-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drop-area.cs" %}
{% include code-snippet/uploader/drop-area/drop-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Configure asynchronous settings

The uploader control process the files to upload in Asynchronous mode by default. Define the properties [saveUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_SaveUrl) and [removeUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_RemoveUrl) to handle the save and remove action as follows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/async-settings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Async-settings.cs" %}
{% include code-snippet/uploader/async-settings/async-settings.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/async-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Async-settings.cs" %}
{% include code-snippet/uploader/async-settings/async-settings.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Handle success and failed upload

You can handle the success and failure actions using the [success](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Success) and [failure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Failure) events. To handle these events, define the function and assign it to the corresponding event as follows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/success-failed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Success_failed.cs" %}
{% include code-snippet/uploader/success-failed/success-failed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/success-failed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Success_failed.cs" %}
{% include code-snippet/uploader/success-failed/success-failed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![uploader](./images/uploader-auto-01.png)

> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) that shows how to render the file upload and browse the files which you want to upload to the server.

## See Also

* [How to add additional data on upload](./how-to/add-additional-data-on-upload)
* [Achieve file upload programmatically](./how-to/achieve-file-upload-programmatically)
* [Achieve invisible upload](./how-to/achieve-invisible-upload)
