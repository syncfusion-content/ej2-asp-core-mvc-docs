---
layout: post
title: Getting started with ##Platform_Name## Sankey Chart Control | Syncfusion
description: Check out and learn about Getting started with ##Platform_Name## Sankey Chart control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sankey Diagram
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Getting started with ASP.NET Core Sankey Diagram Control

This section briefly explains how to include the ASP.NET Core Sankey Chart control in your ASP.NET Core application using Visual Studio.

> **Ready to streamline your ASP.NET Core development?** Discover the full potential of ASP.NET Core controls with AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, CodeStudio and more. [Explore AI Coding Assistant](https://ej2.syncfusion.com/aspnetcore/documentation/ai-coding-assistant/overview)

## Create an ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core package

To add [ASP.NET Core Sankey Diagram](https://www.syncfusion.com/aspnet-core-ui-controls/sankey) control in the app, open the NuGet package manager in Visual Studio *(Tools → NuGet Package Manager → Manage NuGet Packages for Solution)*, search for and install the [Syncfusion.AspNetCore.Sankey](https://www.nuget.org/packages/Syncfusion.AspNetCore.Sankey/) package. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it. Alternatively, you can run the following command in the **Package Manager Console**.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Sankey -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helpers

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.Sankey` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.Sankey

{% endhighlight %}
{% endtabs %}

## Add script resources

Include the [script reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.Sankey/scripts/sf-sankey.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the script manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Sankey Diagram control

Add the [ASP.NET Core Sankey Diagram](https://www.syncfusion.com/aspnet-core-ui-controls/sankey) control in the **~/Pages/Index.cshtml** file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sankey/getting-started/initialize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/sankey/getting-started/initialize/initialize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sankey/getting-started/initialize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initialize.cs" %}
{% include code-snippet/sankey/getting-started/initialize/initialize.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Add data to Sankey Diagram

Define the nodes and links to bind data to the Sankey Chart. Each node must have a unique `Id`, and each link must reference a `SourceId`, `TargetId`, and a numeric `Value`. Nodes represent the categories, and links represent the flow between them.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sankey/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/sankey/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sankey/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/sankey/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Sankey Chart control will be rendered in the default web browser.

## Troubleshooting

If the Sankey Chart does not render or you run into build/runtime issues, try the following:

* **Sankey Chart is not visible on the page** — Ensure the `ejs-scripts` tag helper is registered at the end of `<body>` in `~/Pages/Shared/_Layout.cshtml`. Missing this registration prevents Syncfusion client-side scripts from initializing the control.
* **Build error: `TagHelper is not registered`** — Verify that `~/Pages/_ViewImports.cshtml` contains `@addTagHelper *, Syncfusion.EJ2` and rebuild the solution.
* **NuGet restore failures** — Confirm the project targets a supported .NET version and that the NuGet feed is reachable. Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic.
* **Chart renders with the default theme but data does not appear** — Check that every `Link.SourceId` and `Link.TargetId` matches an existing `Node.Id`, and that the `Value` is a positive number.

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
