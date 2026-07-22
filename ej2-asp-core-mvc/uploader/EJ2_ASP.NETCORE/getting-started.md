---
layout: post
title: Getting Started with ASP.NET Core Uploader Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Uploader control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Uploader
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Uploader Control

This section briefly explains how to include the [ASP.NET Core Uploader](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core packages

To add **ASP.NET Core Uploader** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetCore.Inputs](https://www.nuget.org/packages/Syncfusion.AspNetCore.Inputs/) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes/) packages. All Syncfusion ASP.NET Core packages are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same packages using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Inputs -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Tag Helpers

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.Inputs` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.Inputs

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    @* ASP.NET Core controls styles *@
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    @* ASP.NET Core controls scripts *@
    <script src="_content/Syncfusion.AspNetCore.Inputs/scripts/sf-uploader.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    @* ASP.NET Core Script Manager *@
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Uploader control

Add the [ASP.NET Core Uploader](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) control in the **~/Pages/Index.cshtml** file.

N> From v16.2.41 version, the `Essential JS2 AJAX` library has been integrated for Uploader server requests.
Hence, use the third party `promise` library like blue-bird to use the Uploader in Internet Explorer.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/uploader/getting-started/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Uploader](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) control will render in your default web browser.

![ASP.NET Core Uploader Control](images/uploader-getting.webp)

## Adding Drop Area

By default, the Uploader control allows to upload files by dragging files from File Explorer and dropping them into the Drop Area. You can configure any other external element as drop target using [Drop Area](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_DropArea) property.

In the following sample, drop target is configured.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/uploader/drop-area/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Configure Asynchronous settings

The Uploader control processes the files to upload in Asynchronous mode by default. Define the properties [saveUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_SaveUrl) and [removeUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_RemoveUrl) to handle the save and remove actions as follows.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/uploader/async-settings/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Handle Success and Failure Events

You can handle the Success and Failure events using the [Success](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Success) and [Failure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Failure) events. To handle these events, define the function and assign it to the corresponding event as follows.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/uploader/success-failed/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Uploader](images/uploader-auto-01.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Uploader/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
3. [How to add additional data on upload](./how-to/add-additional-data-on-upload)
4. [Achieve file upload programmatically](./how-to/achieve-file-upload-programmatically)
5. [Achieve invisible upload](./how-to/achieve-invisible-upload)
