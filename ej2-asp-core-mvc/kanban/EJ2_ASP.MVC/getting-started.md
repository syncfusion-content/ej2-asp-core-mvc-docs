---
layout: post
title: Getting Started with ##Platform_Name## Kanban Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Kanban control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Kanban Control

This section briefly explains about how to include [ASP.NET MVC Kanban](https://www.syncfusion.com/aspnet-mvc-ui-controls/kanban-board) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager `EJS().ScriptManager()` at the end of `<body>` in the ASP.NET MVC application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Kanban control

Now, add the Syncfusion ASP.NET MVC Kanban control in `~/Views/Home/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/getting-started/default/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/default/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Kanban control will be rendered in the default web browser.

![ASP.NET MVC Kanban Control](images/default.PNG)

## Populating cards

To populate the empty Kanban with cards, define the list or remote data using the `DataSource` property. To define `DataSource`, the mandatory fields in the list should be relevant to `KeyField`. In the following example, you can see the cards defined with default fields such as ID, Summary, and Status.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/populating-cards/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/getting-started/populating-cards/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/populating-cards/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(KanbanDataModels.KanbanTasks());
    }
}
public class KanbanDataModels
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Status { get; set; }
    public string Summary { get; set; }
    public string Type { get; set; }
    public string Priority { get; set; }
    public string Tags { get; set; }
    public Double Estimate { get; set; }
    public string Assignee { get; set; }
    public int RankId { get; set; }
    public string Color { get; set; }

    public static List<KanbanDataModels> KanbanTasks()
    {
        List<KanbanDataModels> TaskDetails = new List<KanbanDataModels>();
        TaskDetails.Add(new KanbanDataModels { Id = "Task 1", Title = "Task  - 29001", Status = "Open", Summary = "Analyze the new requirements gathered from the customer.", Type = "Story", Priority = "Low", Tags = "Analyze,Customer", Estimate = 3.5, Assignee = "Nancy Davloio", RankId = 1, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 2", Title = "Task  - 29002", Status = "InProgress", Summary = "Improve application performance", Type = "Improvement", Priority = "Normal", Tags = "Improvement", Estimate = 6, Assignee = "Andrew Fuller", RankId = 1, Color = "#7d7297" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 3", Title = "Task  - 29003", Status = "Open", Summary = "Arrange a web meeting with the customer to get new requirements.", Type = "Others", Priority = "Critical", Tags = "Meeting", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 2, Color = "#27AE60" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 4", Title = "Task  - 29004", Status = "InProgress", Summary = "Fix the issues reported in the IE browser.", Type = "Bug", Priority = "Release Breaker", Tags = "IE", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 2, Color = "#cc0000" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 5", Title = "Task  - 29005", Status = "Review", Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Low", Tags = "Customer", Estimate = 3.5, Assignee = "Steven walker", RankId = 1, Color = "#cc0000" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 6", Title = "Task  - 29007", Status = "Validate", Summary = "Validate new requirements", Type = "Improvement", Priority = "Low", Tags = "Validation", Estimate = 1.5, Assignee = "Robert King", RankId = 1, Color = "#7d7297" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 7", Title = "Task  - 29009", Status = "Review", Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker", Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Nancy Davloio", RankId = 2, Color = "#cc0000" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 8", Title = "Task  - 29010", Status = "Close", Summary = "Test the application in the IE browser.", Type = "Story", Priority = "Low", Tags = "Review,IE", Estimate = 5.5, Assignee = "Margaret hamilt", RankId = 3, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 9", Title = "Task  - 29011", Status = "Validate", Summary = "Validate the issues reported by the customer.", Type = "Story", Priority = "High", Tags = "Validation,Fix", Estimate = 1, Assignee = "Steven walker", RankId = 1, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 10", Title = "Task  - 29015", Status = "Open", Summary = "Show the retrieved data from the server in grid control.", Type = "Story", Priority = "High", Tags = "Database,SQL", Estimate = 5.5, Assignee = "Margaret hamilt", RankId = 4, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 11", Title = "Task  - 29016", Status = "InProgress", Summary = "Fix cannot open user’s default database SQL error.", Priority = "Critical", Type = "Bug", Tags = "Database,Sql2008", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 4, Color = "#cc0000" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 12", Title = "Task  - 29017", Status = "Review", Summary = "Fix the issues reported in data binding.", Type = "Story", Priority = "Normal", Tags = "Databinding", Estimate = 3.5, Assignee = "Janet Leverling", RankId = 4, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 13", Title = "Task  - 29018", Status = "Close", Summary = "Analyze SQL server 2008 connection.", Type = "Story", Priority = "Release Breaker", Tags = "Grid,Sql", Estimate = 2, Assignee = "Andrew Fuller", RankId = 4, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 14", Title = "Task  - 29019", Status = "Validate", Summary = "Validate databinding issues.", Type = "Story", Priority = "Low", Tags = "Validation", Estimate = 1.5, Assignee = "Margaret hamilt", RankId = 1, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 15", Title = "Task  - 29020", Status = "Close", Summary = "Analyze grid control.", Type = "Story", Priority = "High", Tags = "Analyze", Estimate = 2.5, Assignee = "Margaret hamilt", RankId = 5, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 16", Title = "Task  - 29021", Status = "Close", Summary = "Stored procedure for initial data binding of the grid.", Type = "Others", Priority = "Release Breaker", Tags = "Databinding", Estimate = 1.5, Assignee = "Steven walker", RankId = 6, Color = "#27AE60" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 17", Title = "Task  - 29022", Status = "Close", Summary = "Analyze stored procedures.", Type = "Story", Priority = "Release Breaker", Tags = "Procedures", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 7, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 18", Title = "Task  - 29023", Status = "Validate", Summary = "Validate editing issues.", Type = "Story", Priority = "Critical", Tags = "Editing", Estimate = 1, Assignee = "Nancy Davloio", RankId = 1, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 19", Title = "Task  - 29024", Status = "Review", Summary = "Test editing functionality.", Type = "Story", Priority = "Normal", Tags = "Editing,Test", Estimate = 0.5, Assignee = "Nancy Davloio", RankId = 5, Color = "#8b447a" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 20", Title = "Task  - 29025", Status = "Open", Summary = "Enhance editing functionality.", Type = "Improvement", Priority = "Low", Tags = "Editing", Estimate = 3.5, Assignee = "Andrew Fuller", RankId = 5, Color = "#7d7297" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 21", Title = "Task  - 29026", Status = "InProgress", Summary = "Improve the performance of the editing functionality.", Type = "Epic", Priority = "High", Tags = "Performance", Estimate = 6, Assignee = "Nancy Davloio", RankId = 5, Color = "#6d7492" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 22", Title = "Task  - 29027", Status = "Open", Summary = "Arrange web meeting with the customer to show editing demo.", Type = "Others", Priority = "High", Tags = "Meeting,Editing", Estimate = 5.5, Assignee = "Steven walker", RankId = 6, Color = "#27AE60" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 23", Title = "Task  - 29029", Status = "Review", Summary = "Fix the editing issues reported by the customer.", Type = "Bug", Priority = "Low", Tags = "Editing,Fix", Estimate = 3.5, Assignee = "Janet Leverling", RankId = 6, Color = "#cc0000" });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 24", Title = "Task  - 29030", Status = "Testing", Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Critical", Tags = "Customer", Estimate = 3.5, Assignee = "Steven walker", RankId = 1 });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 25", Title = "Task  - 29031", Status = "Testing", Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker", Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Nancy Davloio", RankId = 2 });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 26", Title = "Task  - 29032", Status = "Testing", Summary = "Check Login page validation.", Type = "Story", Priority = "Release Breaker", Tags = "Testing", Estimate = 0.5, Assignee = "Michael Suyama", RankId = 3 });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 27", Title = "Task  - 29033", Status = "Testing", Summary = "Fix the issues reported in data binding.", Type = "Story", Priority = "Normal", Tags = "Databinding", Estimate = 3.5, Assignee = "Janet Leverling", RankId = 4 });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 28", Title = "Task  - 29034", Status = "Testing", Summary = "Test editing functionality.", Type = "Story", Priority = "Normal", Tags = "Editing,Test", Estimate = 0.5, Assignee = "Nancy Davloio", RankId = 5 });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 29", Title = "Task  - 29035", Status = "Testing", Summary = "Fix editing issues reported in Firefox.", Type = "Bug", Priority = "Critical", Tags = "Editing,Fix", Estimate = 1.5, Assignee = "Robert King", RankId = 7 });
        TaskDetails.Add(new KanbanDataModels { Id = "Task 30", Title = "Task  - 29036", Status = "Testing", Summary = "Test editing feature in the IE browser.", Type = "Story", Priority = "Normal", Tags = "Testing", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 10 });
        return TaskDetails;
    }
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Kanban with Cards](images/populating-cards.PNG)

## Enable swimlane

`Swimlane` can be enabled by mapping the tags `SwimlaneSettings.KeyField` to appropriate column name in dataSource. This enables the grouping of the cards based on the mapped column values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/enable-swimlane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/getting-started/enable-swimlane/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/enable-swimlane/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Kanban with Swimlane](images/enable-swimlane.PNG)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Kanban/ASP.NET%20MVC%20Razor%20Examples).

## See also

* [Real time example using Kanban](https://ej2.syncfusion.com/aspnetmvc/Kanban/Workflow#/material)