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

This section briefly explains about how to include [ASP.NET MVC Gantt](https://www.syncfusion.com/aspnet-mvc-ui-controls/gantt-chart) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it.

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
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion script manager

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

## Add ASP.NET MVC Gantt Control

Now, add the Syncfusion ASP.NET MVC Gantt control in `~/Views/Home/Index.cshtml` page.

Bind the data with Gantt control by using the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_DataSource) property. It accepts an array of JavaScript object or the DataManager instance. The data source fields that are required to render the tasks are mapped to the Gantt control using the [TaskFields](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/gantt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(ganttData());
    }
    public static List<GanttDataSource> ganttData()
    {
        List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

        GanttDataSource Record1 = new GanttDataSource()
        {
            TaskId = 1,
            TaskName = "Project initiation",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 21),
            SubTasks = new List<GanttDataSource>(),
        };
        GanttDataSource Child1 = new GanttDataSource()
        {
            TaskId = 2,
            TaskName = "Identify site location",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 70,

        };
        GanttDataSource Child2 = new GanttDataSource()
        {
            TaskId = 3,
            TaskName = "Perform soil test",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 50

        };
        GanttDataSource Child3 = new GanttDataSource()
        {
            TaskId = 4,
            TaskName = "Soil test approval",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 50
        };
        Record1.SubTasks.Add(Child1);
        Record1.SubTasks.Add(Child2);
        Record1.SubTasks.Add(Child3);

        GanttDataSource Record2 = new GanttDataSource()
        {
            TaskId = 5,
            TaskName = "Project estimation",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 21),
            SubTasks = new List<GanttDataSource>()
        };
        GanttDataSource Child4 = new GanttDataSource()
        {
            TaskId = 6,
            TaskName = "Develop floor plan for estimation",
            StartDate = new DateTime(2019, 04, 04),
            Duration = 3,
            Progress = 70
        };
        GanttDataSource Child5 = new GanttDataSource()
        {
            TaskId = 7,
            TaskName = "List materials",
            StartDate = new DateTime(2019, 04, 04),
            Duration = 3,
            Progress = 50
        };
        Record2.SubTasks.Add(Child4);
        Record2.SubTasks.Add(Child5);

        GanttDataSourceCollection.Add(Record1);
        GanttDataSourceCollection.Add(Record2);

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
    public List<GanttDataSource> SubTasks { get; set; }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Gantt control will be rendered in the default web browser.

![ASP.NET MVC Gantt Control](images/gantt-control.png)

## Defining columns

Gantt has an option to define columns as an array. You can customize the Gantt columns using the following properties:

* [Field](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Field) : Maps the data source fields to the columns.
* [HeaderText](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HeaderText) : Changes the title of columns.
* [TextAlign](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_TextAlign) : Changes the alignment of columns. By default, columns will be left aligned. To change the columns to right align, set `TextAlign` to right.
* [Format](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Format) : Formats the number and date values to standard or custom formats. Here, it is defined for the conversion of numeric values to currency.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/definingColumns/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Gantt with Column Values](images/gantt-column.png)

## Enable editing

The editing feature enables you to edit the tasks in the Gantt control. It can be enabled by using the [EditSettings.AllowEditing](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowEditing) and [EditSettings.AllowTaskbarEditing](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) properties.

The following editing options are available to update the tasks in Gantt:

* Cell
* Dialog
* Taskbar
* Connector line

### Cell editing

Modify the task details through cell editing by setting the edit mode to `Auto`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/cellEditing/razor %}
{% endhighlight %}
{% endtabs %}

![Cell Editing in ASP.NET MVC Gantt Control](images/gantt-cell-editing.png)

N> When the edit mode is set to `Auto`, you can change the cells to editable mode by double-clicking anywhere at the TreeGrid and edit the task details in the edit dialog by double-clicking anywhere at the chart.

### Dialog editing

Modify the task details through dialog by setting the edit mode to `Dialog`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dialogEditing/razor %}
{% endhighlight %}
{% endtabs %}

N> In dialog editing mode, the edit dialog will appear while performing double-click action in both TreeGrid and chart sides.

### Taskbar editing

Modify the task details through user interaction such as resizing and dragging the taskbar by enabling the [AllowTaskbarEditing](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/taskbarEditing/razor %}
{% endhighlight %}
{% endtabs %}

![Taskbar Editing in ASP.NET MVC Gantt Control](images/gantt-taskbar-editing.png)

### Dependency editing

Modify the task dependencies using mouse interactions by enabling the [AllowTaskbarEditing](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property along with mapping the task dependency data source field to the [Dependency](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dependencyEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DependencyEditing.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(ganttData());
    }

    public static List<GanttDataSource> ganttData()
    {
        List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

        GanttDataSource Record1 = new GanttDataSource()
        {
            TaskId = 1,
            TaskName = "Project initiation",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 21),
            SubTasks = new List<GanttDataSource>(),
        };
        GanttDataSource Child1 = new GanttDataSource()
        {
            TaskId = 2,
            TaskName = "Identify site location",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 70,

        };
        GanttDataSource Child2 = new GanttDataSource()
        {
            TaskId = 3,
            TaskName = "Perform soil test",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 50,
            Predecessor = "2FS"

        };
        GanttDataSource Child3 = new GanttDataSource()
        {
            TaskId = 4,
            TaskName = "Soil test approval",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 50,
            Predecessor = "3FS"
        };
        Record1.SubTasks.Add(Child1);
        Record1.SubTasks.Add(Child2);
        Record1.SubTasks.Add(Child3);

        GanttDataSource Record2 = new GanttDataSource()
        {
            TaskId = 5,
            TaskName = "Project estimation",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 21),
            SubTasks = new List<GanttDataSource>()
        };
        GanttDataSource Child4 = new GanttDataSource()
        {
            TaskId = 6,
            TaskName = "Develop floor plan for estimation",
            StartDate = new DateTime(2019, 04, 04),
            Duration = 3,
            Progress = 70
        };
        GanttDataSource Child5 = new GanttDataSource()
        {
            TaskId = 7,
            TaskName = "List materials",
            StartDate = new DateTime(2019, 04, 04),
            Duration = 3,
            Progress = 50,
            Predecessor = "6SS"
        };
        Record2.SubTasks.Add(Child4);
        Record2.SubTasks.Add(Child5);

        GanttDataSourceCollection.Add(Record1);
        GanttDataSourceCollection.Add(Record2);

        return GanttDataSourceCollection;
    }
}
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

## Enable filtering

The filtering feature enables you to view the reduced amount of records based on filter criteria. Gantt provides the menu filtering support for each column. It can be enabled by setting the [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowFiltering) property to `true`. Filtering feature can also be customized using the [FilterSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_FilterSettings) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/filtering/razor %}
{% endhighlight %}
{% endtabs %}

![Filtering in ASP.NET MVC Gantt Control](images/filtering.png)

## Enable sorting

The sorting feature enables you to order the records. It can be enabled by setting the [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowSorting) property to `true`. The sorting feature can be customized using the [SortSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SortSettings) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/sorting/razor %}
{% endhighlight %}
{% endtabs %}

[Sorting in ASP.NET MVC Gantt Control](images/sorting.png)

## Enabling predecessors or task relationships

Predecessor or task dependency in the Gantt control is used to depict the relationship between the tasks.

* Start to Start (SS): You cannot start a task until the dependent task starts.
* Start to Finish (SF): You cannot finish a task until the dependent task finishes.
* Finish to Start (FS): You cannot start a task until the dependent task completes.
* Finish to Finish (FF): You cannot finish a task until the dependent task completes.

You can show the relationship in tasks by using the [Dependency](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property as shown in the following code example.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/enableDependency/razor %}
{% endhighlight %}
{% endtabs %}

## Assigning Resources

You can display and assign the resource for each task in the Gantt control. Create a collection of JSON object, which contains id, name, unit and group of the resources and assign it to the [Resources](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Resources) property. Map these fields to the Gantt control using the [ResourceFields](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ResourceFields) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/resources/assignResource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.projectResources = projectResources();
        return View(ganttData());
    }
    public static List<GanttResources> projectResources()
    {
        List<GanttResources> GanttResourcesCollection = new List<GanttResources>();

        GanttResources Record1 = new GanttResources()
        {
            ResourceId = 1,
            ResourceName = "Martin Tamer"
        };
        GanttResources Record2 = new GanttResources()
        {
            ResourceId = 2,
            ResourceName = "Rose Fuller"
        };
        GanttResources Record3 = new GanttResources()
        {
            ResourceId = 3,
            ResourceName = "Margaret Buchanan"
        };
        GanttResources Record4 = new GanttResources()
        {
            ResourceId = 4,
            ResourceName = "Fuller King"
        };
        GanttResources Record5 = new GanttResources()
        {
            ResourceId = 5,
            ResourceName = "Davolio Fuller"
        };
        GanttResources Record6 = new GanttResources()
        {
            ResourceId = 6,
            ResourceName = "Van Jack"
        };
        GanttResources Record7 = new GanttResources()
        {
            ResourceId = 7,
            ResourceName = "Fuller Buchanan"
        };
        GanttResources Record8 = new GanttResources()
        {
            ResourceId = 8,
            ResourceName = "Jack Davolio"
        };
        GanttResources Record9 = new GanttResources()
        {
            ResourceId = 9,
            ResourceName = "Tamer Vinet"
        };
        GanttResources Record10 = new GanttResources()
        {
            ResourceId = 10,
            ResourceName = "Vinet Fuller"
        };
        GanttResources Record11 = new GanttResources()
        {
            ResourceId = 11,
            ResourceName = "Bergs Anton"
        };
        GanttResources Record12 = new GanttResources()
        {
            ResourceId = 12,
            ResourceName = "Construction Supervisor"
        };
        GanttResourcesCollection.Add(Record1);
        GanttResourcesCollection.Add(Record2);
        GanttResourcesCollection.Add(Record3);
        GanttResourcesCollection.Add(Record4);
        GanttResourcesCollection.Add(Record5);
        GanttResourcesCollection.Add(Record6);
        GanttResourcesCollection.Add(Record7);
        GanttResourcesCollection.Add(Record8);
        GanttResourcesCollection.Add(Record9);
        GanttResourcesCollection.Add(Record10);
        GanttResourcesCollection.Add(Record11);
        GanttResourcesCollection.Add(Record12);
        return GanttResourcesCollection;
    }

    public static List<GanttDataSource> ganttData()
    {
        List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

        GanttDataSource Record1 = new GanttDataSource()
        {
            TaskId = 1,
            TaskName = "Project initiation",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 21),
            SubTasks = new List<GanttDataSource>(),
        };
        GanttDataSource Child1 = new GanttDataSource()
        {
            TaskId = 2,
            TaskName = "Identify site location",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 50,
            ResourceId = new int[] { 1 },
        };
        GanttDataSource Child2 = new GanttDataSource()
        {
            TaskId = 3,
            TaskName = "Perform soil test",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 50,
            Predecessor = "2FS",
            ResourceId = new int[] { 2, 3, 5 },
        };
        GanttDataSource Child3 = new GanttDataSource()
        {
            TaskId = 4,
            TaskName = "Soil test approval",
            StartDate = new DateTime(2019, 04, 02),
            Duration = 4,
            Progress = 50,
            Predecessor = "3FS"
        };
        Record1.SubTasks.Add(Child1);
        Record1.SubTasks.Add(Child2);
        Record1.SubTasks.Add(Child3);

        GanttDataSource Record2 = new GanttDataSource()
        {
            TaskId = 5,
            TaskName = "Project estimation",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 21),
            SubTasks = new List<GanttDataSource>(),
        };
        GanttDataSource Child4 = new GanttDataSource()
        {
            TaskId = 6,
            TaskName = "Develop floor plan for estimation",
            StartDate = new DateTime(2019, 04, 04),
            Duration = 3,
            Progress = 50,
            ResourceId = new int[] { 4 },

        };
        GanttDataSource Child5 = new GanttDataSource()
        {
            TaskId = 7,
            TaskName = "List materials",
            StartDate = new DateTime(2019, 04, 04),
            Duration = 3,
            Progress = 50,
            Predecessor = "6SS",
            ResourceId = new int[] { 4, 8 },

        };
        Record2.SubTasks.Add(Child4);
        Record2.SubTasks.Add(Child5);

        GanttDataSourceCollection.Add(Record1);
        GanttDataSourceCollection.Add(Record2);

        return GanttDataSourceCollection;
    }
}
public class GanttResources
{
    public int ResourceId { get; set; }
    public string ResourceName { get; set; }
}
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
    public int[] ResourceId { get; set; }
}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Gantt with Resources](images/gantt-assign-resource.png)

## Error handling

Error handling is used to identify errors, display them and develop recovery strategies to handle errors from gantt. In Gantt, error handling is done by using the [actionFailure](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionFailure) event. Some of the scenarios that this event handles are:
* Invalid duration : The [duration](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Duration) field accepts only numerical values with an optional decimal point. Entering non-numerical values triggers the `actionFailure` event and displays issue information in the event argument.
* Invalid dependency: The [dependency](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) field accepts only a number followed by a predecessor type (FS, FF, SS, SF).  Entering invalid values, such as special characters or incorrect predecessor types, triggers the `actionFailure` event and displays issue information in the event argument.
* Invalid offset : The `offset` accepts only numerical values or their word equivalents followed by a unit. Entering invalid values, such as special characters triggers `actionFailure` event and displays issue information in the event argument.
* Failure to map task fields : The data source fields necessary for rendering tasks should be mapped to the Gantt control using the [taskFields](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html) property. Failure to map `taskFields` in the sample triggers `actionFailure` event and displays issue information in the event argument.
* Failure to map resource fields : To assign resources to a task, resource fields should be mapped to the Gantt control using the [resourceFields](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttResourceFields.html). Failure to map `resourceFields` in the sample triggers `actionFailure` event and displays issue information in the event argument.
* Failure to map `isPrimaryKey` : `isPrimaryKey` field is crucial for CRUD operations. Failure to map [id](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Id) column in gantt column collection or `isPrimaryKey` field in one of the columns will trigger `actionFailure` event and display issue information in the event argument.
* Invalid date format : [format](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Format) property under `topTier` and `bottomTier` determines how the timelines are displayed in the top tier and bottom tier of the Gantt chart timeline. If the `format` does not contain a valid standard [date format](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTimelineTierSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineTierSettings_Format), it triggers the `actionFailure` event, displaying issue information in the event argument.
* Failure to map `hasChildMapping` : [hasChildMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_HasChildMapping) property should configured for [load-on-demand](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_LoadChildOnDemand). Ensure it properly configured in the [taskFields](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html). Failure to map `hasChildMapping` in the `load-on-demand` sample triggers `actionFailure` event and displays issue information in the event argument.
* Invalid day in event markers : `day` should configured in [eventMarkers](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EventMarkers) to render striplines in a particular day. Failure to configure the `day` in `eventMarkers` triggers `actionFailure` event and displays issue information in the event argument.

> Additionally, TreeGrid side error handling information is also displayed from the Gantt `actionFailure` event. For more details on TreeGrid side error handling, refer [here](https://ej2.syncfusion.com/aspnetmvc/documentation/tree-grid/getting-started-mvc#handling-errors).

The following code example shows how to use the [actionFailure](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionFailure) event in the Gantt control to display an exception when `isPrimaryKey` is not configured properly in the Gantt Chart column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/exception-handling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefiningColumns.cs" %}
{% include code-snippet/gantt/getting-started/exception-handling/definingColumns.cs %}
{% endhighlight %}
{% endtabs %}

The following screenshot represents the Gantt Exception handling in `actionFailure` event.

![Error Handling](images/error-handling.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Gantt/ASP.NET%20MVC%20Razor%20Examples).