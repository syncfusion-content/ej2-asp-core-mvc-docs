---
layout: post
title: Getting Started with ##Platform_Name## Kanban Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Kanban control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Kanban Control

This section briefly explains how to include the [ASP.NET Core Kanban](https://www.syncfusion.com/aspnet-core-ui-controls/kanban-board) control in your ASP.NET Core application using Visual Studio.

> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetcore/documentation/ai-coding-assistant/overview)

## Prerequisites

The following prerequisites are required to create an ASP.NET Core Razor Pages application with the Kanban control:

* Visual Studio 2019 or later (Visual Studio 2022 is recommended)
* .NET Core 3.1, .NET 5, .NET 6, .NET 7, .NET 8, or later
* ASP.NET Core workload installed in Visual Studio
* An active internet connection to download the NuGet package and CDN assets

Refer to the [System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements) for the complete list of supported environments.

## Create ASP.NET Core web application with Razor pages

You can create an ASP.NET Core Razor Pages project in one of two ways. Choose the option that matches your development setup:

* **Use the standard Microsoft template** if you are new to ASP.NET Core and want a plain project: [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)
* **Use the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core extension** if you want a project that is pre-configured with Syncfusion<sup style="font-size:70%">&reg;</sup> assemblies, themes, and tag-helper references: [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

After the project is created, ensure that an `Index` page exists at `~/Pages/Index.cshtml` and that the matching page model is at `~/Pages/Index.cshtml.cs`. The Kanban control will be added to the `Index` page in the later steps.

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.  Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper
Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme and scripts are referenced using the CDN inside the `<head>` of the `~/Pages/Shared/_Layout.cshtml` file as follows. This example uses the Fluent theme; see the note below for the full list of available themes.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

> Check out the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn the different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer to styles in an ASP.NET Core application, and to achieve the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

> Check out the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-scripts>` at the end of the `<body>` element in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Kanban control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Kanban tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/default/tagHelper %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) to run the app. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Kanban control will then be rendered in the default web browser with empty columns.

![ASP.NET Core Kanban control rendered with empty columns (Open, In Progress, Review, Validate, Testing, Close).](images/default.PNG)

## Populating cards

To populate the empty Kanban with cards, define the list or remote data using the `dataSource` property. To define `dataSource`, the mandatory fields in the list should be relevant to `keyField`. In the following example, you can see the cards defined with default fields such as ID, Summary, and Status.

![kanban](./images/populating-cards.PNG)

## Enable swimlane

The `Swimlane` can be enabled by mapping the `swimlaneSettings.keyField` to the appropriate column name in the dataSource. This enables the grouping of cards based on the values in the mapped swimlane column. In this example, the `Assignee` column is used to group cards by the assignee. The `Index` page and the `KanbanDataModels` class from the previous sections are reused unchanged.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/enable-swimlane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class KanbanDataModels
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Status { get; set; }
    public string Summary { get; set; }
    public string Type { get; set; }
    public string Priority { get; set; }
    public string Tags { get; set; }
    public double Estimate { get; set; }
    public string Assignee { get; set; }
    public int RankId { get; set; }
    public string Color { get; set; }
}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Kanban with cards grouped into swimlane rows by assignee.](./images/enable-swimlane.PNG)

> [View the complete sample on GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Kanban/ASP.NET%20Core%20Tag%20Helper%20Examples).

## Troubleshooting

If the Kanban control does not render or behaves unexpectedly, verify the following:

* The `Syncfusion.EJ2.AspNet.Core` NuGet package is restored and referenced by the project.
* The `@addTagHelper *, Syncfusion.EJ2` directive is present in `~/Pages/_ViewImports.cshtml`.
* The CDN links use the same `{{ site.ej2version }}` value as the `<ejs-scripts>` tag.
* The `Index` page exists at `~/Pages/Index.cshtml` and the `Index.cshtml.cs` page model is wired up correctly.
* The license key is registered in `Program.cs` (or `Startup.cs`); otherwise, a license-warning banner appears in development mode.

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
* [Kanban columns configuration](https://ej2.syncfusion.com/aspnetcore/documentation/kanban/columns)
* [Kanban data binding](https://ej2.syncfusion.com/aspnetcore/documentation/kanban/data-binding)
* [Kanban swimlane](https://ej2.syncfusion.com/aspnetcore/documentation/kanban/swimlane)
* [Syncfusion<sup style="font-size:70%">&reg;</sup> licensing documentation](https://ej2.syncfusion.com/aspnetcore/documentation/licensing)