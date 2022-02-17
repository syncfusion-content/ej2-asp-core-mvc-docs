---
layout: post
title: Getting Started with ##Platform_Name## Gantt Component
description: Checkout and learn about getting started with ##Platform_Name## Gantt component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get started with the ASP.NET Core application, ensure that the following software are installed on the machine:

* Visual Studio 2017
* DotNet Core 2.0

## Setup ASP.NET Core application with Essential JS 2 for ASP.NET Core

The following steps to create ASP.NET Core Application.

**Step 1:** Create ASP.NET Core Web Application with default template project in Visual Studio 2017.

![Alt text](./images/default-template.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using Nugget Package Manager.

Open the `nuGet` package manager.

![Alt text](./images/solution-explorer-core.png)

Install the **Syncfusion.EJ2** package to the application

![Alt text](./images/nuget-demo.png)

After Installation complete this will included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as dependency since it **Syncfusion.EJ2** dependent to NewtonSoft.JSON package.

**Step 3:** Open the **Views/_ViewImports.cshtml** to import Syncfusion.EJ2 package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

**Step 4:** Add client-side resource through [`CDN`](https://ej2.syncfusion.com/documentation/deployment/#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **Views/Shared/_Layout.cshtml.**

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>
```

**Step 5:** Adding Script Manager in layout page **Views/Shared/_Layout.cshtml.**

```cs

<ejs-scripts></ejs-scripts>

```

**Step 6:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/gantt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gantt.cs" %}
{% include code-snippet/gantt/getting-started/gantt/gantt.cs %}
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



## Binding Gantt with data

Bind data with the Gantt control by using the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_DataSource) property. It accepts an array of JavaScript object or the DataManager instance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/bindingData/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="BindingData.cs" %}
{% include code-snippet/gantt/getting-started/bindingData/bindingData.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/bindingData/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BindingData.cs" %}
{% include code-snippet/gantt/getting-started/bindingData/bindingData.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Mapping task fields

The data source fields that are required to render the tasks are mapped to the Gantt control using the [`TaskFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/mappingFields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MappingFields.cs" %}
{% include code-snippet/gantt/getting-started/mappingFields/mappingFields.cs %}
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
{% highlight c# tabtitle="DefiningColumns.cs" %}
{% include code-snippet/gantt/getting-started/definingColumns/definingColumns.cs %}
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
{% highlight c# tabtitle="CellEditing.cs" %}
{% include code-snippet/gantt/getting-started/cellEditing/cellEditing.cs %}
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



`Note:` When the edit mode is set to `Auto`, you can change the cells to editable mode by double-clicking anywhere at the TreeGrid and edit the task details in the edit dialog by double-clicking anywhere at the chart.

### Dialog editing

Modify the task details through dialog by setting the edit mode to `Dialog`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dialogEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DialogEditing.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dialogEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DialogEditing.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



`Note:` In dialog editing mode, the edit dialog will appear while performing double-click action in both TreeGrid and chart sides.

### Taskbar editing

Modify the task details through user interaction such as resizing and dragging the taskbar by enabling the [`AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/taskbarEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TaskbarEditing.cs" %}
{% include code-snippet/gantt/getting-started/taskbarEditing/taskbarEditing.cs %}
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



### Dependency Editing

Modify the task dependencies using mouse interactions by enabling the [`AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property along with mapping the task dependency data source field to the [`Dependency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/dependencyEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DependencyEditing.cs" %}
{% include code-snippet/gantt/getting-started/dependencyEditing/dependencyEditing.cs %}
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
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/gantt/getting-started/filtering/filtering.cs %}
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



## Enable sorting

The sorting feature enables you to order the records. It can be enabled by setting the [`AllowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowSorting) property to `true`.The sorting feature can be customized using the [`SortSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SortSettings) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/getting-started/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/gantt/getting-started/sorting/sorting.cs %}
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



## Enabling predecessors or task relationships

Predecessor or task dependency in the Gantt control is used to depict the relationship between the tasks.

* Start to Start (SS): You cannot start a task until the dependent task starts.
* Start to Finish (SF): You cannot finish a task until the dependent task finishes.
* Finish to Start (FS): You cannot start a task until the dependent task completes.
* Finish to Finish (FF): You cannot finish a task until the dependent task completes.
You can show the relationship in tasks by using the [`Dependency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property as shown in the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/enableDependency/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDependency.cs" %}
{% include code-snippet/gantt/predecessor/enableDependency/enableDependency.cs %}
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

You can display and assign the resource for each task in the Gantt control.
Create a collection of JSON object, which contains id, name, unit and group of the resources and assign it to the [`Resources`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Resources) property.
Map these fields to the Gantt control using the [`ResourceFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ResourceFields) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/resources/assignResource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AssignResource.cs" %}
{% include code-snippet/gantt/resources/assignResource/assignResource.cs %}
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



Output be like the below.

![Alt text](./images/gantt-output.png)

> You can refer to our [ASP.NET Core Gantt Chart](https://www.syncfusion.com/aspnet-core-ui-controls/gantt-chart) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Gantt Chart example](https://ej2.syncfusion.com/aspnetcore/Gantt/Default#/material) that shows how to render the Gantt Chart in ASP.NET Core.