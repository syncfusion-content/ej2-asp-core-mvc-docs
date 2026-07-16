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

This section explains how to include the [ASP.NET Core Tree Grid](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/), and [Visual Studio Code](https://code.visualstudio.com/).

## Create an new ASP.NET Core Web App with Razor pages

{% tabcontents %}

{% tabcontent Visual Studio %}

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Run the following command to create a new ASP.NET Core Web App.

{% tabs %}
{% highlight razor tabtitle="Terminal" %}

dotnet new webapp -o RazorPagesMovie
code -r RazorPagesMovie

{% endhighlight %}
{% endtabs %}

Alternatively, create an **ASP.NET Core Web App** using Visual Studio Code via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio-code#create-a-razor-pages-web-app), or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-code-integration/create-project), or the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extension.

{% endtabcontent %}

{% endtabcontents %}

## Install the required ASP.NET Core package

Install the [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package. All Syncfusion ASP.NET Core packages are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

{% tabcontents %}

{% tabcontent Visual Studio %}

1. Go to *Tools → NuGet Package Manager → Manage NuGet Packages for Solution*.
2. Search the required NuGet package (`Syncfusion.EJ2.AspNet.Core`) and install it.

Alternatively, you can install the same package using the Package Manager Console with the following commands.

{% tabs %}
{% highlight razor tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run the following commands.

{% tabs %}
{% highlight razor tabtitle="Terminal" %}

dotnet add package Syncfusion.EJ2.AspNet.Core --version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

## Add ASP.NET Core Tag Helper
 
After the package is installed, open **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.EJ2` Tag Helper.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    @* ASP.NET Core controls styles *@
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    @* ASP.NET Core controls scripts *@
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
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

## Add ASP.NET Core Tree Grid control

Add the [ASP.NET Core Tree Grid](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) control in the **~/Pages/Index.cshtml** file.

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

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Tree Grid](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) control will render in your default web browser.

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run the following command.

{% tabs %}
{% highlight razor tabtitle="Terminal" %}

dotnet run

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

![ASP.NET Core Tree Grid Columns](images/treegrid-columns.webp)

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
3. [Getting Started with JavaScript documentation](https://ej2.syncfusion.com/documentation/treegrid/getting-started)
4. [Getting Started with JavaScript (ES5) documentation](https://ej2.syncfusion.com/javascript/documentation/treegrid/getting-started)
5. [Getting Started with Angular documentation](https://ej2.syncfusion.com/angular/documentation/treegrid/getting-started)
6. [Getting Started with React documentation](https://ej2.syncfusion.com/react/documentation/treegrid/getting-started)
7. [Getting Started with Vue documentation](https://ej2.syncfusion.com/vue/documentation/treegrid/getting-started)
8. [Getting Started with Blazor documentation](https://blazor.syncfusion.com/documentation/treegrid/getting-started-webapp)
