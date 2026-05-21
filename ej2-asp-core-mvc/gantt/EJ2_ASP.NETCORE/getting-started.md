---
layout: post
title: Getting started with ##Platform_Name## Gantt Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Gantt control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting started with ASP.NET Core Gantt control

This guide walks you through setting up and integrating the [ASP.NET Core Gantt](https://www.syncfusion.com/aspnet-core-ui-controls/gantt-chart) control in your application using Visual Studio or Visual Studio Code. You’ll learn how to configure the component, bind task data, map fields, and quickly visualize project timelines in just a few steps.

> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetcore/documentation/ai-coding-assistant/overview)

To get started quickly with the ASP.NET Core Gantt Chart, watch the following video. It provides a step-by-step guide to project configuration and demonstrates the basic features and functionalities of the Gantt Chart:

{% youtube "https://www.youtube.com/watch?v=tILyz8PyE6A" %}

## Create ASP.NET Core web application with Razor pages

{% tabcontents %}

{% tabcontent Visual Studio %}

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create an ASP.NET Core Razor Pages project using Visual Studio:

1. Start **Visual Studio** and select **Create a new project**.

2. In the **Create a new project** window, choose **ASP.NET Core Web App (Razor Pages)** → **Next**.

3. In the **Configure your new project** dialog, specify the **project name** (and optionally change location/folder).

4. Click `Next`.

5. In the Additional information dialog:
* Select **.NET 10.0**.
* Verify: **Do not use top-level statements** is **unchecked**.

6. Click `Create`.

For alternative approaches to create the project, see [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it. Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}


{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Prerequisites

* [Visual Studio Code](https://code.visualstudio.com/download)
* [C# Dev Kit for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
* [.NET 10.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)

## Create an ASP.NET Core Razor Pages project using Visual Studio Code:

* Install the latest **.NET SDK** that supports **.NET 10.0** or later.
* Open **Visual Studio Code**.
* Press **Ctrl + `** to open the integrated terminal.
* Run the following commands:

{% tabs %}
{% highlight C# tabtitle=".NET CLI" %}

dotnet new webapp -o RazorPagesMovie

code -r RazorPagesMovie

{% endhighlight %}
{% endtabs %}

## Install ASP.NET Core package in the application

To integrate the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Gantt component, install the required [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet packages using the integrated terminal:

1. Press **Ctrl + `** to open the integrated terminal in **Visual Studio Code**.
2. Navigate to the directory containing the **.csproj** file.
3. Run the following commands to install the packages:

* [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/)

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

dotnet add package Syncfusion.EJ2.AspNet.Core --version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The `Syncfusion.EJ2.AspNet.Core` NuGet package has dependencies: [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper
Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight cs tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

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

> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-scripts>` at the end of `<body>` in `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Create sample data

Define a simple task list with hierarchical relationships. Each task must have a `StartDate` and either a `Duration` or `EndDate` to render properly.

```csharp
List<GanttDataSource> Tasks = new List<GanttDataSource>()
{
    new GanttDataSource() { TaskId = 1, TaskName = "Project initiation", StartDate = new DateTime(2019, 04, 02), EndDate = new DateTime(2019, 04, 21) },
    new GanttDataSource() { TaskId = 2, TaskName = "Identify site location", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 50, ParentID = 1 },
    new GanttDataSource() { TaskId = 3, TaskName = "Perform soil test", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 50, ParentID = 1 },
    new GanttDataSource() { TaskId = 4, TaskName = "Soil test approval", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 50, ParentID = 1 },
    new GanttDataSource() { TaskId = 5, TaskName = "Project estimation", StartDate = new DateTime(2019, 04, 02), EndDate = new DateTime(2019, 04, 21) },
    new GanttDataSource() { TaskId = 6, TaskName = "Develop floor plan for estimation", StartDate = new DateTime(2019, 04, 04), Duration = 3, Progress = 50, ParentID = 5 },
    new GanttDataSource() { TaskId = 7, TaskName = "List materials", StartDate = new DateTime(2019, 04, 04), Duration = 3, Progress = 50, ParentID = 5 }
};

public class GanttDataSource
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int? Duration { get; set; }
    public int Progress { get; set; }
    public int? ParentID { get; set; }
}
```

## Configure task fields

Map your data fields to Gantt Chart properties using `taskFields`:

```csharp
<e-gantt-taskfields id="TaskId" name="TaskName" startDate="StartDate" endDate="EndDate" duration="Duration" progress="Progress" parentID="ParentID">
</e-gantt-taskfields>
```

### Field mapping reference

| Property | Description | Required |
|----------|-------------|----------|
| `id` | Unique task identifier | Yes |
| `name` | Task display name | Yes |
| `startDate` | Task start date | Yes |
| `endDate` | Task end date | No |
| `duration` | Task duration in days | Yes |
| `progress` | Task completion percentage (0-100) | No |
| `parentID` | Parent task ID for hierarchy | No |

## Add ASP.NET Core Gantt control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Gantt tag helper in the `~/Pages/Index.cshtml` page and Razor Pages code-behind (PageModel) in the `~/Pages/Index.cshtml.cs`. Bind the data to the Gantt control by using the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_DataSource) property. It accepts an array of JavaScript objects or the `DataManager` instance.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/gantt/getting-started/gantt/tagHelper %}
{% endhighlight %}
{% highlight cs tabtitle="Index.cshtml.cs" %}
{% include code-snippet/gantt/getting-started/gantt/gantt-core.cs %}
{% endhighlight %}
{% endtabs %}

## Run the application

### Visual Studio

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Gantt control will be rendered in the default web browser.

### Visual Studio Code

Use the terminal to run the app.

1. Navigate to the folder that contains the project (.csproj) file.
2. Run `dotnet run`.
3. Open the URL shown in the terminal (for example, https://localhost:xxxx). Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Gantt control will be rendered in the browser.

## Output

You will see a Gantt Chart with:

- Task hierarchy with parent-child relationships
- Timeline view showing task bars
- Progress indicators on each task
- Automatically calculated dates based on duration

![ASP.NET Core Gantt Control](images/gantt-control.png)

## See also

- **[Key Elements](https://ej2.syncfusion.com/aspnetcore/documentation/gantt/key-elements)** - Learn about UI components and interactions
- **[Overview](https://ej2.syncfusion.com/aspnetcore/documentation/gantt/overview)** - Explore all available features

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Gantt/ASP.NET%20Core%20Tag%20Helper%20Examples).