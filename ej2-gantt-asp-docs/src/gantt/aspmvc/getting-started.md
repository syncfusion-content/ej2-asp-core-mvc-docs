---
title: "Getting Started"
component: "Gantt"
description: "Learn how to create an Essential JS 2 Gantt control and enable features like Editing, filtering, sorting in ASP.NET MVC."
---

# Getting Started with ASP.NET MVC

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our components.

## Prerequisites

To get started with the ASP.NET MVC application, ensure that the following software are installed on the machine:

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Preparing ASP.NET MVC application

The following steps to create ASP.NET MVC Application.

**Step 1:** Choose File > New > Project… in the Visual Studio menu bar.

**Step 2:** Select Installed > Visual C# > Web and choose the required .NET Framework in the drop-down.

**Step 3:** Select **ASP.NET Web Application (.NET Framework)** and change the application name, and then click **OK.**

**Step 4:** Choose **MVC** and then click **OK**. Now, the MVC web application project is created with default ASP.NET MVC template.

![Default Template](./images/default-template.png)

**Step 5:** Once your project created. We need to add Syncfusion EJ2 package into your application by using `NuGet Package Manager`.

Open the `NuGet` package manager.

![Solution Explorer](./images/solution-explorer-mvc.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo.png)

After installation complete, this will be included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as a dependency, since **Syncfusion.EJ2** dependent to `NewtonSoft.JSON` package.

**Step 6:** Open ~/Views/Web.config file and add the **Syncfusion.EJ2** namespace reference to the <system.web.webPages.razor> element and **Syncfusion.EJ2** assembly reference to <system.web> element.

```html
<configuration>
    ....
    ....
    <system.web.webPages.razor>
        ....
        ....
        <pages pageBaseType="System.Web.Mvc.WebViewPage">
            <namespaces>
                ....
                ....
                <add namespace="Syncfusion.EJ2"/>
            </namespaces>
        </pages>
    </system.web.webPages.razor>
    ....
    ....
    <system.web>
        <compilation>
            <assemblies>
                ....
                ....
                <add assembly="Syncfusion.EJ2, Culture=neutral" />
            </assemblies>
        </compilation>
    </system.web>
</configuration>
```

**Step 7:** Add client side resource through [`CDN`](https://ej2.syncfusion.com/documentation/deployment/#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page `_Layout.cshtml`.

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>
```

**Step 8:** Adding Script Manager in the layout page `_Layout.cshtml`.

```html
<body>
    ....
    ....
    <!-- Syncfusion Essential JS 2 ScriptManager -->
    @Html.EJS().ScriptManager()
</body>
```

**Step 9:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the Gantt.

{% aspTab template="gantt/getting-started/gantt", sourceFiles="gantt.cs" %}

{% endaspTab %}

## Binding Gantt with data

Bind data with the Gantt control by using the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_DataSource) property. It accepts an array of JavaScript object or the DataManager instance.

{% aspTab template="gantt/getting-started/bindingData", sourceFiles="bindingData.cs" %}

{% endaspTab %}

## Mapping task fields

The data source fields that are required to render the tasks are mapped to the Gantt control using the [`TaskFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) property.

{% aspTab template="gantt/getting-started/mappingFields", sourceFiles="mappingFields.cs" %}

{% endaspTab %}

## Defining columns

Gantt has an option to define columns as an array. You can customize the Gantt columns using the following properties:

* `Field`: Maps the data source fields to the columns.
* `HeaderText`: Changes the title of columns.
* `TextAlign`: Changes the alignment of columns. By default, columns will be left aligned. To change the columns to right align, set `TextAlign` to right.
* `Format`: Formats the number and date values to standard or custom formats. Here, it is defined for the conversion of numeric values to currency.

{% aspTab template="gantt/getting-started/definingColumns", sourceFiles="definingColumns.cs" %}

{% endaspTab %}

## Enable editing

The editing feature enables you to edit the tasks in the Gantt control. It can be enabled by using the [`EditSettings.AllowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowEditing) and [`EditSettings.AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) properties.

The following editing options are available to update the tasks in Gantt:

* Cell
* Dialog
* Taskbar
* Connector line

### Cell editing

Modify the task details through cell editing by setting the edit mode to `Auto`.

{% aspTab template="gantt/getting-started/cellEditing", sourceFiles="cellEditing.cs" %}

{% endaspTab %}

`Note:` When the edit mode is set to `Auto`, you can change the cells to editable mode by double-clicking anywhere at the TreeGrid and edit the task details in the edit dialog by double-clicking anywhere at the chart.

### Dialog editing

Modify the task details through dialog by setting the edit mode to `Dialog`.

{% aspTab template="gantt/getting-started/dialogEditing", sourceFiles="dialogEditing.cs" %}

{% endaspTab %}

`Note:` In dialog editing mode, the edit dialog will appear while performing double-click action in both TreeGrid and chart sides.

### Taskbar editing

Modify the task details through user interaction such as resizing and dragging the taskbar by enabling the [`AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property.

{% aspTab template="gantt/getting-started/taskbarEditing", sourceFiles="taskbarEditing.cs" %}

{% endaspTab %}

### Dependency editing

Modify the task dependencies using mouse interactions by enabling the [`AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property along with mapping the task dependency data source field to the [`Dependency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property.

{% aspTab template="gantt/getting-started/dependencyEditing", sourceFiles="dependencyEditing.cs" %}

{% endaspTab %}

## Enable filtering

The filtering feature enables you to view the reduced amount of records based on filter criteria. Gantt provides the menu filtering support for each column. It can be enabled by setting the [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowFiltering) property to `true`. Filtering feature can also be customized using the [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_FilterSettings) property.

{% aspTab template="gantt/getting-started/filtering", sourceFiles="filtering.cs" %}

{% endaspTab %}

## Enable sorting

The sorting feature enables you to order the records. It can be enabled by setting the [`AllowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowSorting) property to `true`. The sorting feature can be customized using the [`SortSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SortSettings) property.

{% aspTab template="gantt/getting-started/sorting", sourceFiles="sorting.cs" %}

{% endaspTab %}

## Enabling predecessors or task relationships

Predecessor or task dependency in the Gantt control is used to depict the relationship between the tasks.

* Start to Start (SS): You cannot start a task until the dependent task starts.
* Start to Finish (SF): You cannot finish a task until the dependent task finishes.
* Finish to Start (FS): You cannot start a task until the dependent task completes.
* Finish to Finish (FF): You cannot finish a task until the dependent task completes.
You can show the relationship in tasks by using the [`Dependency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property as shown in the following code example.

{% aspTab template="gantt/predecessor/enableDependency", sourceFiles="enableDependency.cs" %}

{% endaspTab %}

## Assigning Resources

You can display and assign the resource for each task in the Gantt control.
Create a collection of JSON object, which contains id, name, unit and group of the resources and assign it to the [`Resources`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Resources) property.
Map these fields to the Gantt control using the [`ResourceFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ResourceFields) property.

{% aspTab template="gantt/resources/assignResource", sourceFiles="assignResource.cs" %}

{% endaspTab %}

Output be like the below.

![Alt text](./images/gantt-output.png)

> You can refer to our [ASP.NET MVC Gantt Chart](https://www.syncfusion.com/aspnet-mvc-ui-controls/gantt-chart) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Gantt Chart example](https://ej2.syncfusion.com/aspnetmvc/Gantt/DefaultFunctionalities#/material) that shows how to render the Gantt Chart in ASP.NET MVC.