---
layout: post
title: Getting Started with ASP.NET MVC BlockEditor Control | Syncfusion
description: Checkout and learn about getting started with Syncfusion Essential ASP.NET MVC BlockEditor control, its elements, and more.
canonical_url: "https://www.syncfusion.com/rich-text-editor-sdk/aspnet-mvc-block-editor"
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Block Editor control

This section briefly explains about how to include `ASP.NET MVC BlockEditor` control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application

You can create the ASP.NET MVC web application by two types they are mentioned below along with the steps. Follow one of these types and follow it to create an ASP .NET MVC project

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

W> **Important:** Syncfusion® ASP.NET MVC controls require `System.Web.Mvc` version **5.3.0**. Using earlier versions may result in runtime or build errors. For more information, refer to the [release notes](https://ej2.syncfusion.com/aspnetmvc/documentation/release-notes/30.1.37?type=all).

## Install Syncfusion ASP.NET MVC package in the application

You can add the Syncfusion BlockEditor to your ASP.NET MVC application by installing the Syncfusion ASP.NET MVC package. This can be done in two ways, they are mentioned below

### 1. Using NuGet Package Manager

Open Visual Studio and navigate to Tools → NuGet Package Manager → Manage NuGet Packages for Solution. Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it directly.

### 2. Using Package Manager Console

Run the following command in the Package Manager Console:

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

I> Ensure you're running the command inside Visual Studio's Package Manager Console (Tools → NuGet Package Manager → Package Manager Console), not in a terminal like CMD or PowerShell.

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent2.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> script manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC BlockEditor control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC BlockEditor control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/block-editor/getting-started/gettingstarted.cs %}
{% endhighlight %}
{% endtabs %}

I> Replace the existing content in the Index.cshtml file by pasting the above code snippet.

I> When the BlockEditor control is rendered, the id attribute must be present. If the id is not provided, the control will fail to render.

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC BlockEditor control will be rendered in the default web browser.

![ASP.NET MVC BlockEditor Control](images/block-editor-control.png)
