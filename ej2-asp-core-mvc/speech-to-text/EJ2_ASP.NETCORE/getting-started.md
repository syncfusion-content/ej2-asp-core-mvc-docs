---
layout: post
title: Getting Started with ASP.NET Core Speech To Text Control | Syncfusion
description: Check out and learn about getting started with Essential ASP.NET Core Speech To Text control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Speech To Text
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Speech To Text control

This section explains how to include the [ASP.NET Core Speech To Text](https://www.syncfusion.com/aspnet-core-ui-controls/speech-to-text) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core packages

To add [ASP.NET Core Speech To Text](https://www.syncfusion.com/aspnet-core-ui-controls/speech-to-text) control in the app, open the NuGet package manager in Visual Studio *(Tools → NuGet Package Manager → Manage NuGet Packages for Solution)*, search for and install the [Syncfusion.AspNetCore.Inputs](https://www.nuget.org/packages/Syncfusion.AspNetCore.Inputs/) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes/) packages. All Syncfusion ASP.NET Core packages are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

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
    <script src="_content/Syncfusion.AspNetCore.Inputs/scripts/sf-speech-to-text.min.js"></script>
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

## Add ASP.NET Core Speech To Text control

Add the [ASP.NET Core Speech To Text](https://www.syncfusion.com/aspnet-core-ui-controls/speech-to-text) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/speech-to-text/getting-started/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Speech To Text](https://www.syncfusion.com/aspnet-core-ui-controls/speech-to-text) control will render in your default web browser.

![ASP.NET Core Speech To Text Control](images/speech-to-text-control.webp)

## Adding button content

You can use the [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextButtonSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextButtonSettings_Content) property to display the start listening text and [stopContent](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextButtonSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextButtonSettings_StopContent) to display the stop listening text by using the e[-speechtotext-buttonSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_ButtonSettings) tag helper.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/speech-to-text/button-setting/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Speech To Text Button Content](images/speechtotext-buttonsetting.webp)
![ASP.NET Core Speech To Text Stop Content](images/speechtotext-stop.webp)