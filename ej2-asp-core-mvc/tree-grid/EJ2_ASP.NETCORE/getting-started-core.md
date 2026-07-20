---
layout: post
title: Getting Started with ASP.NET Core Tree Grid Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Tree Grid control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Tree Grid
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Tree Grid Control

This section explains how to include the [ASP.NET Core Tree Grid](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/).

## Prerequisites

### .NET and Visual Studio compatibility

| .NET version | Minimum Visual Studio version |
|--------------|------------------------------|
| .NET 10.0 | Visual Studio 2026 18.0.0 or later |
| .NET 9.0 | Visual Studio 2022 17.12.0 or later |
| .NET 8.0 | Visual Studio 2022 17.8.0 or later |
| .NET Core SDK 3.1 | Visual Studio 2019 16.4 or later |
| .NET Core SDK 2.0 | Visual Studio 2017 15.7 or later |

### Browser support

| Browser | Versions |
|--------------|---------------|
| Google Chrome, including Android & iOS | Latest version |
| Mozilla Firefox | Latest version |
| Microsoft Edge | Latest version |
| Apple Safari, including iOS | Latest version |
| Opera | Latest version |
| Microsoft Internet Explorer | 11 |

> **Ready to streamline your ASP.NET Core development?** Discover the full potential of ASP.NET Core controls with the Syncfusion AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights — all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Code Studio, and more. [Explore the AI Coding Assistant](https://ej2.syncfusion.com/aspnetcore/documentation/ai-coding-assistant/overview)

To get started quickly with the ASP.NET Core Tree Grid control, watch this video.

{% youtube
"youtube:https://www.youtube.com/watch?v=-q3VoCtBvuw" %}

## Create an ASP.NET Core Web App with Razor pages

{% tabcontents %}

{% tabcontent Visual Studio %}

Create an ASP.NET Core Web App using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project).

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Run the following command to create a new ASP.NET Core Web App.

{% tabs %}
{% highlight C# tabtitle=".NET CLI" %}

dotnet new webapp -o RazorPagesTreeGrid
code -r RazorPagesTreeGrid

{% endhighlight %}
{% endtabs %}

Alternatively, create an ASP.NET Core Web App using Visual Studio Code via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio-code#create-a-razor-pages-web-app), the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-code-integration/create-project), or the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extension.

{% endtabcontent %}

{% endtabcontents %}

## Install the required ASP.NET Core package

Install the [Syncfusion.AspNetCore.TreeGrid](https://www.nuget.org/packages/Syncfusion.AspNetCore.TreeGrid/) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes/) NuGet packages. All Syncfusion ASP.NET Core packages are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

{% tabcontents %}

{% tabcontent Visual Studio %}

1. Go to *Tools → NuGet Package Manager → Manage NuGet Packages for Solution*.
2. Search for the required NuGet packages (`Syncfusion.AspNetCore.TreeGrid` and `Syncfusion.AspNetCore.Themes`) and install them.

Alternatively, install the same packages using the Package Manager Console with the following commands.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.TreeGrid -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run the following commands.

{% tabs %}
{% highlight C# tabtitle="Terminal" %}

dotnet add package Syncfusion.AspNetCore.TreeGrid -v {{ site.releaseversion }}
dotnet add package Syncfusion.AspNetCore.Themes -v {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

## Add ASP.NET Core Tag Helpers

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.TreeGrid` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.TreeGrid

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Reference the theme stylesheet and script from the [NuGet package](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) (or from the [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference)). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of the **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    @* ASP.NET Core controls styles *@
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    @* ASP.NET Core controls scripts *@
    <script src="_content/Syncfusion.AspNetCore.TreeGrid/scripts/sf-treegrid.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the Script Manager `<ejs-scripts>` at the end of the `<body>` element, as follows.

> The order matters: add the stylesheet and `<script>` reference inside `<head>`, then place `<ejs-scripts>` at the end of `<body>`.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tree Grid control

Add the [ASP.NET Core Tree Grid](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) control to the **~/Pages/Index.cshtml** page.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/tree-grid/getting-start-core/columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages;

public class IndexModel : PageModel
{
    public void OnGet() { }
}

public class Task
{
    public Task() { }
    public int? TaskID { get; set; }
    public string? TaskName { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? Duration { get; set; }
    public List<Task>? Children { get; set; }

    public Task(int taskID, string taskName, DateTime start, DateTime end, int duration)
    {
        this.TaskID = taskID;
        this.TaskName = taskName;
        this.StartDate = start;
        this.EndDate = end;
        this.Duration = duration;
    }
}

{% endhighlight %}
{% endtabs %}

## Run the application

{% tabcontents %}

{% tabcontent Visual Studio %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Tree Grid](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) control renders in your default web browser.

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run the following command.

{% tabs %}
{% highlight C# tabtitle="Terminal" %}

dotnet run

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

![ASP.NET Core Tree Grid with columns for TaskID, TaskName, StartDate, EndDate, and Duration](images/treegrid-columns.webp)

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)

