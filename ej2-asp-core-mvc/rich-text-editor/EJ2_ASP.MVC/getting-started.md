---
layout: post
title: Getting Started with ##Platform_Name## Rich Text Editor | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Rich Text Editor Control

The Syncfusion ASP .NET MVC Rich Text Editor is a WYSIWYG (What You See Is What You Get) editor that enables users to create, edit, and format rich text content with features like multimedia insertion, lists, and links. This section briefly explains about how to include [ASP.NET MVC Rich Text Editor](https://www.syncfusion.com/rich-text-editor-sdk/asp-net-mvc-wysiwyg-rich-text-editor) control in your ASP.NET MVC application using Visual Studio.

> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetmvc/documentation/ai-coding-assistant/overview)

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application

You can create the the ASP.NET MVC web application by two types they are mentioned below along with the steps. follow one of these types and follow it to create a ASP .NET MVC project 

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

W> **Important:** Syncfusion® ASP.NET MVC controls require `System.Web.Mvc` version **5.3.0**. Using earlier versions may result in runtime or build errors. For more information, refer to the [release notes](https://ej2.syncfusion.com/aspnetmvc/documentation/release-notes/30.1.37?type=all).

## Install Syncfusion ASP.NET MVC package in the application

You can add the Syncfusion Rich Text Editor to your ASP.NET MVC application by installing the Syncfusion ASP.NET MVC package. This can be done in two ways, they are mentioned below

### 1. Using NuGet Package Manager  

Open Visual Studio and navigate to Tools → NuGet Package Manager → Manage NuGet Packages for Solution. Search for search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it directly.

### 2. Using Package Manager Console  

Run the following command in the Package Manager Console:

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

I> Ensure you’re running the command inside Visual Studio’s Package Manager Console (Tools → NuGet Package Manager → Package Manager Console), not in a terminal like CMD or PowerShell.


N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> script manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Views/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Rich Text Editor control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Rich Text Editor control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
@Html.EJS().RichTextEditor("editor").Render()
{% endhighlight %}
{% endtabs %}

I> Replace the existing content in the Index.cshtml file by pasting the above code snippet.

I> When the Rich Text Editor control is rendered, the id attribute must be present. If the id is not provided, the control will fail to render.


## Run the application


Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Rich Text Editor control will be rendered in the default web browser.

![ASP.NET MVC Rich Text Editor Control](images/richtexteditor-control.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/RichTextEditor/ASP.NET%20MVC%20Razor%20Examples).

## See also

* [Real time example using Rich Text Editor](https://ej2.syncfusion.com/aspnetmvc/RichTextEditor/Forums#/bootstrap5)
* [How to insert Emoticons](https://ej2.syncfusion.com/aspnetmvc/RichTextEditor/InsertEmoticons#/material)
* [How to change the editor type](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/editor-types/editor-mode)
* [How to render the iframe](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/editor-types/iframe)
* [How to render the toolbar in inline mode](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/editor-types/inline-editing)
* [Accessibility in Rich text editor](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/accessibility)
* [Keyboard support in Rich text editor](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/keyboard-support)
* [Globalization in Rich text editor](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/globalization)

N> You can refer to our [ASP.NET MVC Rich Text Editor](https://www.syncfusion.com/rich-text-editor-sdk/asp-net-mvc-wysiwyg-rich-text-editor) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Rich Text Editor example](https://ej2.syncfusion.com/aspnetmvc/RichTextEditor/DefaultFunctionalities#/material) that shows how to render the rich text editor tools.