---
layout: post
title: Getting Started with ##Platform_Name## Gantt Control
description: Checkout and learn about getting started with ##Platform_Name## Gantt control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Gantt Control

This section briefly explains about how to include [ASP.NET Core Gantt](https://www.syncfusion.com/aspnet-core-ui-controls/gantt-chart) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls. Here, the theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
    ....
    ....
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Gantt control

Now, add the Syncfusion ASP.NET Core Gantt tag helper in `~/Pages/Index.cshtml` page. Bind data with the Gantt control by using the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_DataSource) property. It accepts an array of JavaScript object or the DataManager instance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/gantt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class GanttDataSource
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int? Duration { get; set; }
    public int Progress { get; set; }
    public List<GanttDataSource> SubTasks { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/gantt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gantt.cs" %}
{% include code-snippet/gantt/getting-started/gantt/gantt.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Gantt control will be rendered in the default web browser.

![ASP.NET Core Gantt Control](images/gantt-control.png)

## Mapping task fields

The data source fields that are required to render the tasks are mapped to the Gantt control using the [`TaskFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/mappingFields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class GanttDataSource
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int? Duration { get; set; }
    public int Progress { get; set; }
    public List<GanttDataSource> SubTasks { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/mappingFields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MappingFields.cs" %}
{% include code-snippet/gantt/getting-started/mappingFields/mappingFields.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Defining columns

Gantt has an option to define columns as an array. You can customize the Gantt columns using the following properties:

* `Field`: Maps the data source fields to the columns.
* `HeaderText`: Changes the title of columns.
* `TextAlign`: Changes the alignment of columns. By default, columns will be left aligned. To change the columns to right align, set `TextAlign` to right.
* `Format`: Formats the number and date values to standard or custom formats. Here, it is defined for the conversion of numeric values to currency.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/definingColumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class GanttDataSource
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int? Duration { get; set; }
    public int Progress { get; set; }
    public List<GanttDataSource> SubTasks { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/definingColumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefiningColumns.cs" %}
{% include code-snippet/gantt/getting-started/definingColumns/definingColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core Gantt Columns](images/gantt-column.png)

## Enable editing

The editing feature enables you to edit the tasks in the Gantt control. It can be enabled by using the [`EditSettings.AllowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowEditing) and [`EditSettings.AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) properties.

The following editing options are available to update the tasks in Gantt:

* Cell
* Dialog
* Taskbar
* Connector line

### Cell editing

Modify the task details through cell editing by setting the edit mode to `Auto`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/cellEditing/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/cellEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellEditing.cs" %}
{% include code-snippet/gantt/getting-started/cellEditing/cellEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Cell Editing in ASP.NET Core Gantt](images/gantt-cell-editing.png)

> When the edit mode is set to `Auto`, you can change the cells to editable mode by double-clicking anywhere at the TreeGrid and edit the task details in the edit dialog by double-clicking anywhere at the chart.

### Dialog editing

Modify the task details through dialog by setting the edit mode to `Dialog`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dialogEditing/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dialogEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DialogEditing.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



> In dialog editing mode, the edit dialog will appear while performing double-click action in both TreeGrid and chart sides.

### Taskbar editing

Modify the task details through user interaction such as resizing and dragging the taskbar by enabling the [`AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/taskbarEditing/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/taskbarEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarEditing.cs" %}
{% include code-snippet/gantt/getting-started/taskbarEditing/taskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Taskbar Editing in ASP.NET Core Gantt](images/gantt-taskbar-editing.png)

### Dependency Editing

Modify the task dependencies using mouse interactions by enabling the [`AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property along with mapping the task dependency data source field to the [`Dependency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dependencyEditing/tagHelper %}
{% endhighlight %}
{% highlight cshtml tabtitle="CSHTML.cs" %}
public class GanttDataSource
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string Predecessor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int? Duration { get; set; }
    public int Progress { get; set; }
    public List<GanttDataSource> SubTasks { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dependencyEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DependencyEditing.cs" %}
{% include code-snippet/gantt/getting-started/dependencyEditing/dependencyEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable filtering

The filtering feature enables you to view the reduced amount of records based on filter criteria. Gantt provides the menu filtering support for each column. It can be enabled by setting the [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowFiltering) property to `true`. Filtering feature can also be customized using the [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_FilterSettings) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/filtering/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/gantt/getting-started/filtering/filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Filtering in ASP.NET Core Gantt](images/gantt-filter.png)

## Enable sorting

The sorting feature enables you to order the records. It can be enabled by setting the [`AllowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowSorting) property to `true`. The sorting feature can be customized using the [`SortSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SortSettings) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/sorting/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/gantt/getting-started/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Sorting in ASP.NET Core Gantt](images/gantt-sort.png)

## Enabling predecessors or task relationships

Predecessor or task dependency in the Gantt control is used to depict the relationship between the tasks.

* Start to Start (SS): You cannot start a task until the dependent task starts.
* Start to Finish (SF): You cannot finish a task until the dependent task finishes.
* Finish to Start (FS): You cannot start a task until the dependent task completes.
* Finish to Finish (FF): You cannot finish a task until the dependent task completes.

You can show the relationship in tasks by using the [`Dependency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/enableDependency/tagHelper %}
{% endhighlight %}
{% highlight cshtml tabtitle="CSHTML.cs" %}
public class GanttDataSource
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string Predecessor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int? Duration { get; set; }
    public int Progress { get; set; }
    public List<GanttDataSource> SubTasks { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/enableDependency/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDependency.cs" %}
{% include code-snippet/gantt/predecessor/enableDependency/enableDependency.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Assigning resources

You can display and assign the resource for each task in the Gantt control. Create a collection of JSON object, which contains id, name, unit and group of the resources and assign it to the [`Resources`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Resources) property. Map these fields to the Gantt control using the [`ResourceFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ResourceFields) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/resources/assignResource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class GanttDataSource
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public int[] ResourceId { get; set; }
    public string Predecessor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int? Duration { get; set; }
    public int Progress { get; set; }
    public List<GanttDataSource> SubTasks { get; set; }
}
public class GanttResources
{
    public int ResourceId { get; set; }
    public string ResourceName { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/resources/assignResource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AssignResource.cs" %}
{% include code-snippet/gantt/resources/assignResource/assignResource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core Gantt with Resources](./images/gantt-resources.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Gantt/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)