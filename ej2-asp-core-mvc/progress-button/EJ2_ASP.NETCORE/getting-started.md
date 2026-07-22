---
layout: post
title: Getting Started with ASP.NET Core Progress Button Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Progress Button Control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Progress Button
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Progress Button Control

This section briefly explains how to include the [ASP.NET Core Progress Button](https://www.syncfusion.com/aspnet-core-ui-controls/progress-button) control in an ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core packages

To add the **[ASP.NET Core Progress Button](https://www.syncfusion.com/aspnet-core-ui-controls/progress-button)** control in the app, open the NuGet package manager in Visual Studio (*Tools → NuGet Package Manager → Manage NuGet Packages for Solution*), search for and install the [Syncfusion.AspNetCore.SplitButtons](https://www.nuget.org/packages/Syncfusion.AspNetCore.SplitButtons) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes) packages. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same packages using the Package Manager Console with the following commands.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.SplitButtons -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helpers

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.SplitButtons` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.SplitButtons

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from [Static Web Assets](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#static-web-assets). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    <!-- Syncfusion ASP.NET Core Progress Button control script -->
    <script src="_content/Syncfusion.AspNetCore.SplitButtons/scripts/sf-progress-button.min.js" type="text/javascript"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Progress Button control

Add the [ASP.NET Core Progress Button](https://www.syncfusion.com/aspnet-core-ui-controls/progress-button) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/progress-button/getting-started/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Progress Button](https://www.syncfusion.com/aspnet-core-ui-controls/progress-button) will render in your default web browser.

![ASP.NET Core Progress Button Control](../images/progress-button.webp)

N> Progress Button supports different styles, types and sizes like [`Button`](https://ej2.syncfusion.com/aspnetcore/documentation/button). In addition, it also supports `top` and `bottom` positions of the icon.

## Enabling progress in button

You can enable the background filler UI by setting the [`enableProgress`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_EnableProgress) property to `true`.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/progress-button/enable-progress/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/ProgressButton/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with ASP.NET Core using Razor pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)