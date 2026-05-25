---
layout: post
title: Getting Started with ##Platform_Name## Gantt Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Gantt control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Gantt Control

This guide walks you through setting up and integrating the [ASP.NET MVC Gantt](https://www.syncfusion.com/aspnet-mvc-ui-controls/gantt-chart) control in your application using Visual Studio. You’ll learn how to configure the component, bind task data, map fields, and quickly visualize project timelines in just a few steps.

> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetmvc/documentation/ai-coding-assistant/overview)

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

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

## Create sample data

Define a simple task list with hierarchical relationships. Each task must have a `StartDate` and either a `Duration` or `EndDate` to render properly.

```csharp
List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>()
{
    new GanttDataSource() { TaskId = 1, TaskName = "Project initiation", StartDate = new DateTime(2019, 04, 02), EndDate = new DateTime(2019, 04, 21) },
    new GanttDataSource() { TaskId = 2, TaskName = "Identify site location", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 70, ParentID = 1 },
    new GanttDataSource() { TaskId = 3, TaskName = "Perform soil test", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 50, ParentID = 1 },
    new GanttDataSource() { TaskId = 4, TaskName = "Soil test approval", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 50, ParentID = 1 },
    new GanttDataSource() { TaskId = 5, TaskName = "Project estimation", StartDate = new DateTime(2019, 04, 02), EndDate = new DateTime(2019, 04, 21) },
    new GanttDataSource() { TaskId = 6, TaskName = "Develop floor plan for estimation", StartDate = new DateTime(2019, 04, 04), Duration = 3, Progress = 70, ParentID = 5 },
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
TaskFields(ts => ts.Id("TaskId").Name(
    "TaskName").StartDate("StartDate").EndDate("EndDate").Duration("Duration").Progress("Progress").ParentID("ParentID"))
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

## Add ASP.NET MVC Gantt Control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Gantt control to the `~/Views/Home/Index.cshtml` page and configure the controller in `~/Controllers\HomeController.cs`. The following code snippet initializes a basic Gantt component with default settings.

Bind the data with Gantt control by using the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_DataSource) property. It accepts an array of JavaScript object or the DataManager instance. The data source fields that are required to render the tasks are mapped to the Gantt control using the [TaskFields](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/gantt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
using System;
using System.Collections.Generic;
using System.Web.Mvc;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(ganttData());
    }
    public static List<GanttDataSource> ganttData()
    {
        List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>()
        {
            new GanttDataSource() { TaskId = 1, TaskName = "Project initiation", StartDate = new DateTime(2019, 04, 02), EndDate = new DateTime(2019, 04, 21) },
            new GanttDataSource() { TaskId = 2, TaskName = "Identify site location", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 70, ParentID = 1 },
            new GanttDataSource() { TaskId = 3, TaskName = "Perform soil test", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 50, ParentID = 1 },
            new GanttDataSource() { TaskId = 4, TaskName = "Soil test approval", StartDate = new DateTime(2019, 04, 02), Duration = 4, Progress = 50, ParentID = 1 },
            new GanttDataSource() { TaskId = 5, TaskName = "Project estimation", StartDate = new DateTime(2019, 04, 02), EndDate = new DateTime(2019, 04, 21) },
            new GanttDataSource() { TaskId = 6, TaskName = "Develop floor plan for estimation", StartDate = new DateTime(2019, 04, 04), Duration = 3, Progress = 70, ParentID = 5 },
            new GanttDataSource() { TaskId = 7, TaskName = "List materials", StartDate = new DateTime(2019, 04, 04), Duration = 3, Progress = 50, ParentID = 5 }
        };

        return GanttDataSourceCollection;
    }
}
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
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Gantt control will be rendered in the default web browser.

## Output

You will see a Gantt Chart with:

- Task hierarchy with parent-child relationships
- Timeline view showing task bars
- Progress indicators on each task
- Automatically calculated dates based on duration

![ASP.NET MVC Gantt Control](images/gantt-control.png)

## See also

- **[Key Elements](https://ej2.syncfusion.com/aspnetmvc/documentation/gantt/key-elements)** - Learn about UI components and interactions
- **[Overview](https://ej2.syncfusion.com/aspnetmvc/documentation/gantt/overview)** - Explore all available features

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Gantt/ASP.NET%20MVC%20Razor%20Examples).