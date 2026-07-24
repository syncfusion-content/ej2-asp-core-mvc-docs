---
layout: post
title: Getting Started with ##Platform_Name## Rich Text Editor | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more details.
canonical_url: "https://www.syncfusion.com/rich-text-editor-sdk/aspnet-core-rich-text-editor"
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Rich Text Editor Control

The Syncfusion ASP.NET Core Rich Text Editor is a WYSIWYG (What You See Is What You Get) editor that enables users to create, edit, and format rich text content with features like multimedia insertion, lists, and links. This section briefly explains how to include [ASP.NET Core Rich Text Editor](https://www.syncfusion.com/rich-text-editor-sdk/aspnet-core-rich-text-editor) control in your ASP.NET Core application using Visual Studio.

> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetcore/documentation/ai-coding-assistant/overview)

To get start quickly with the ASP.NET Core Rich Text Editor, refer to this video:

{% youtube "youtube:https://www.youtube.com/watch?v=lEyINv1RGu8"%}

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create an ASP.NET Core Web Application with Razor pages

You can add the Syncfusion Rich Text Editor to your ASP.NET Core application by installing the Syncfusion ASP.NET Core package. This can be done in two ways described below:

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

## Install Syncfusion ASP.NET Core Rich Text Editor and Theme Packages in the Application

You can add the Syncfusion Rich Text Editor to your ASP.NET Core application by installing the Syncfusion ASP.NET Core Rich Text Editor package. This can be done in two ways, as mentioned below:

### 1. Using NuGet Package Manager  

Open Visual Studio and navigate to Tools → NuGet Package Manager → Manage NuGet Packages for Solution. Search for [Syncfusion.ASP.NET Core.Rich Text Editor](https://www.nuget.org/packages/Syncfusion.AspNetCore.RichTextEditor) and install it directly.

### 2. Using Package Manager Console  

Run the following commands in the Package Manager Console:

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.AspNetCore.RichTextEditor --version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes --version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

I> Ensure you’re running the command inside Visual Studio’s Package Manager Console (Tools → NuGet Package Manager → Package Manager Console), not in a terminal like CMD or PowerShell.

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper
Open the `~/Pages/_ViewImports.cshtml` file and add the following tag helper imports.
{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.RichTextEditor

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Here, the theme and script are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.RichTextEditor/scripts/sf-rich-text-editor.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Check out the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

N> Check out the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the Script Manager `<ejs-script>` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Rich Text Editor control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Rich Text Editor tag helper to `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<ejs-richtexteditor id="editor"></ejs-richtexteditor>

{% endhighlight %}
{% endtabs %}

I> When the Rich Text Editor control is rendered, the `id` attribute must be provided; otherwise, the control will fail to render.

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Rich Text Editor control will be rendered in the default web browser.

![ASP.NET Core Rich Text Editor Control](images/richtexteditor-control.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/RichTextEditor/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

**Documentation**

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
* [How to change the editor type](./editor-types/editor-mode.md)
* [How to render the iframe](./editor-types/iframe.md)
* [How to render the toolbar in inline mode](./editor-types/inline-editing.md)
* [Accessibility in Rich Text Editor](./accessibility.md)
* [Keyboard support in Rich Text Editor](./keyboard-support.md)
* [Globalization in Rich Text Editor](./globalization.md)

**Live samples**

* [How to insert Emoticons](https://ej2.syncfusion.com/aspnetcore/richtexteditor/insertemoticons#/fluent2)
* [Blog posting using Rich Text Editor](https://ej2.syncfusion.com/aspnetcore/richtexteditor/forums#/fluent2)
