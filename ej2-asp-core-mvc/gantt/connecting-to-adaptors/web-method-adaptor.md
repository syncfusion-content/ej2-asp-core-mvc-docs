---
layout: post
title: WebMethod Adaptor in Syncfusion ##Platform_Name## Gantt Component
description: ##Platform_Name## Gantt Web Method adaptor explains how the adaptor conveys task-related requests and task modification payloads to server web methods.
platform: ej2-asp-core-mvc
control: WebMethod Adaptor
publishingplatform: ##Platform_Name##
documentation: ug
---

# WebMethodAdaptor in Syncfusion ##Platform_Name## Gantt Chart

The [WebMethodAdaptor](https://ej2.syncfusion.com/aspnetcore/documentation/data/adaptors/web-method-adaptor) enables the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt to communicate with server web methods and legacy endpoints by packaging task data requests and task modification payloads into a structured request envelope the server can deserialize. Use this adaptor when backend exposes web methods that handle task requests and updates via HTTP POST operations, especially if need to integrate with legacy systems or custom endpoints. Unlike other adaptors, `WebMethodAdaptor` is designed for scenarios where standard REST or OData endpoints are not available.

For backend configuration and expected request/response shapes, consult the WebMethod adaptor backend setup documentation for platform. After the backend is prepared, configure the DataManager in the ##Platform_Name## application to use the WebMethod adaptor as the Gantt data source.

For detailed server-side configuration and further implementation details, refer to the [DataManager WebMethod Adaptor documentation](https://ej2.syncfusion.com/aspnetcore/documentation/data/adaptors/web-method-adaptor), which covers endpoint setup, query processing, and best practices for integrating WebMethod-based services.

**Project structure (conceptual):**

- Frontend: A ##Platform_Name## application hosting the Gantt and a DataManager configured for WebMethod endpoints.
- Backend: A web methods service that receives the adaptor's request envelope, processes task queries and mutation payloads, and returns JSON task records and related metadata.

```
WebMethodAdaptor/
└── WebMethodAdaptor.Server/        # ASP.NET Core / ASP.NET MVC backend (API).
    ├── Controllers/                 # API controllers (will be created here).
    ├── Models/                      # Data models (will be created here).
    └── Program.cs                   # Server configuration.
```

## Gantt frontend setup using WebMethod adaptor

This section describes at a conceptual level, how the Gantt consumes task data from web methods and submits task changes. Implementation and package installation steps are covered in platform-specific setup guides and are intentionally omitted here.

### Step 1: CSS and component styling

- Include the required Syncfusion theme and component styles so the Gantt and its input controls render correctly. The theme is referenced in `~/Pages/Shared/_Layout.cshtml` for **ASP.NET Core** and in `~/Views/Shared/_Layout.cshtml` for **ASP.NET MVC**.

```cshtml
<head>
    <!-- Syncfusion ##Platform_Name## controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/tailwind3.css" />
    <!-- Syncfusion ##Platform_Name## controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>
```

### Step 2: Configure DataManager with WebMethodAdaptor

- Configure a DataManager instance that targets web method endpoints and specifies the WebMethodAdaptor. The Gantt uses that DataManager to fetch tasks, request related datasets, and submit task create/update/delete payloads wrapped in the expected envelope.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@{
    // Configure DataManager with WebMethodAdaptor.
    var dataManager = new DataManager(){
        Url = "https://localhost:xxxx/api/Gantt", // Here xxxx represents the port number.
        Adaptor = "WebMethodAdaptor", // Handles all WebMethodAdaptor communication
        CrossDomain = true, // Enables cross-domain requests
    };
}

<ejs-gantt id="Gantt" dataSource="@dataManager" height="400px">
    <e-gantt-taskfields id="TaskID" name="TaskName" startDate="StartDate" endDate="EndDate"
                        duration="Duration" progress="Progress" dependency="Dependency"
                        parentID="ParentID">
    </e-gantt-taskfields>
    <e-gantt-editsettings allowEditing="true" allowAdding="true" allowDeleting="true"
                          allowTaskbarEditing="true"></e-gantt-editsettings>
    <e-gantt-columns>
        <e-gantt-column field="TaskID" headerText="Task ID" textAlign="Right" width="90" type="number" isPrimaryKey="true"></e-gantt-column>
        <e-gantt-column field="TaskName" headerText="Task Name" textAlign="Left" width="270" type="string"></e-gantt-column>
        <e-gantt-column field="StartDate" headerText="Start Date" textAlign="Right" width="150" format="yMd" type="dateTime"></e-gantt-column>
        <e-gantt-column field="EndDate" headerText="End Date" textAlign="Right" width="150" format="dd/MM/yyyy hh:mm" type="dateTime"></e-gantt-column>
        <e-gantt-column field="Duration" headerText="Duration" textAlign="Right" width="90" type="number"></e-gantt-column>
        <e-gantt-column field="Progress" headerText="Progress" textAlign="Right" width="120" type="number"></e-gantt-column>
    </e-gantt-columns>
</ejs-gantt>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    // Configure DataManager with WebMethodAdaptor pointing to the web method endpoint.
    var dataManager = new ej.data.DataManager({
        url: 'https://localhost:xxxx/api/Gantt', // Here xxxx represents the port number.
        adaptor: new ej.data.WebMethodAdaptor(),
        crossDomain: true
    });
</script>

@(Html.EJS().Gantt("Gantt").DataSource(dataManager)
    .Height("400px")
    .TaskFields(ts => ts.Id("TaskID").Name("TaskName").StartDate("StartDate").EndDate("EndDate")
        .Duration("Duration").Progress("Progress").Dependency("Dependency").ParentID("ParentID"))
    .Columns(col =>
    {
        col.Field("TaskID").HeaderText("Task ID").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("90").Type("number").IsPrimaryKey(true).Add();
        col.Field("TaskName").HeaderText("Task Name").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Left).Width("270").Type("string").Add();
        col.Field("StartDate").HeaderText("Start Date").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("150").Format("yMd").Type("dateTime").Add();
        col.Field("EndDate").HeaderText("End Date").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("150").Format("dd/MM/yyyy hh:mm").Type("dateTime").Add();
        col.Field("Duration").HeaderText("Duration").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("90").Type("number").Add();
        col.Field("Progress").HeaderText("Progress").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("120").Type("number").Add();
    })
    .Render()
)
{% endhighlight %}
{% endtabs %}

{% endif %}

**Server-side data operations**

When task sets are large or when scheduling rules must be applied consistently, the server receives responsibility for processing task queries and task modifications. Using web methods, the server applies scheduling rules, dependency validation, and any project-specific business logic before returning task records or acknowledging changes. The `Syncfusion.EJ2.AspNet.Core` package supports this approach by providing built-in methods that efficiently handle these operations on the server, ensuring smooth performance even with heavy data loads.

## CRUD operations

The DataManager with WebMethodAdaptor supports Create, Read, Update, and Delete workflows for task entities. In Gantt usage, these operations cover task creation, task edits (including taskbar edits and resulting scheduling recalculations), dependency creation or modification, and task deletion.

**Mapping CRUD operations to service endpoints**

CRUD operations are conveyed to the service using standard WebMethod conventions. The WebMethodAdaptor works with a single task endpoint for task operations:

| Operation | HTTP Method | URL Example | Description |
|-----------|-------------|-------------|-------------|
| **Read** | POST | `/api/Gantt` | Get all records. |
| **Create** | POST | `/api/Gantt` | Add a new record. |
| **Update** | POST | `/api/Gantt` | Update record. |
| **Delete** | POST | `/api/Gantt` | Delete record. |

### Step 1: Server-side controller

Add the required controller method to **GanttController.cs**. Replace the entire controller with this complete version:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cs tabtitle="GanttController.cs - Complete CRUD Implementation" %}
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;
using WebMethodAdaptorDemo.Server.Models;

namespace WebMethodAdaptorDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GanttController : ControllerBase
    {
        [HttpGet]
        public List<GanttTask> GetOrderData()
        {
            return GanttDataAdaptor.GetGanttTasks().ToList();
        }

        [HttpPost]
        public object Post([FromBody] DataManager data)
        {
            if (data == null)
                return BadRequest();

            // Work against the single backing list once
            var tasks = GanttDataAdaptor.GetGanttTasks(); // assume List<GanttTask>

            if (data.Value.Action == "batch")
            {
                var crud = (DataManagerRequest)data.Value;

                // Added: assign TaskID if missing and add to backing list
                if (crud.Added != null)
                {
                    int nextId = tasks.Any() ? tasks.Max(t => t.TaskID) + 1 : 1;
                    foreach (var task in crud.Added)
                    {
                        if (task.TaskID == 0)
                            task.TaskID = nextId++;
                        tasks.Add(task);
                    }
                }

                // Changed: update existing items safely (check for null)
                if (crud.Changed != null)
                {
                    foreach (var task in crud.Changed)
                    {
                        var existing = tasks.FirstOrDefault(t => t.TaskID == task.TaskID);
                        if (existing == null) continue;

                        existing.TaskName = task.TaskName;
                        existing.StartDate = task.StartDate;
                        existing.EndDate = task.EndDate;
                        existing.Duration = task.Duration;
                        existing.Progress = task.Progress;
                        existing.Dependency = task.Dependency;
                        existing.ParentID = task.ParentID;
                    }
                }

                // Deleted: remove by TaskID
                if (crud.Deleted != null)
                {
                    foreach (var task in crud.Deleted)
                    {
                        var existing = tasks.FirstOrDefault(t => t.TaskID == task.TaskID);
                        if (existing != null)
                            tasks.Remove(existing);
                    }
                }
            }

            // Return the updated data and count
            var dataSource = tasks.AsQueryable();
            int totalRecordsCount = tasks.Count;
            return Ok(new { result = dataSource, count = totalRecordsCount });
        }
    }

    /// <summary>
    /// Wrapper class for WebMethodAdaptor requests.
    /// WebMethodAdaptor wraps DataManagerRequest inside a 'value' property.
    /// </summary>
    public class DataManager
    {
        public required DataManagerRequest Value { get; set; }
    }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="GanttController.cs - Complete CRUD Implementation" %}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Syncfusion.EJ2.Base;
using WebMethodAdaptorDemo.Server.Models;

namespace WebMethodAdaptorDemo.Server.Controllers
{
    [RoutePrefix("api/Gantt")]
    public class GanttController : ApiController
    {
        [HttpGet]
        public List<GanttTask> GetOrderData()
        {
            return GanttDataAdaptor.GetGanttTasks().ToList();
        }

        [HttpPost]
        public object Post(DataManager data)
        {
            if (data == null)
                return BadRequest();

            // Work against the single backing list once
            var tasks = GanttDataAdaptor.GetGanttTasks(); // assume List<GanttTask>

            if (data.Value.Action == "batch")
            {
                var crud = (DataManagerRequest)data.Value;

                // Added: assign TaskID if missing and add to backing list
                if (crud.Added != null)
                {
                    int nextId = tasks.Any() ? tasks.Max(t => t.TaskID) + 1 : 1;
                    foreach (var task in crud.Added)
                    {
                        if (task.TaskID == 0)
                            task.TaskID = nextId++;
                        tasks.Add(task);
                    }
                }

                // Changed: update existing items safely (check for null)
                if (crud.Changed != null)
                {
                    foreach (var task in crud.Changed)
                    {
                        var existing = tasks.FirstOrDefault(t => t.TaskID == task.TaskID);
                        if (existing == null) continue;

                        existing.TaskName = task.TaskName;
                        existing.StartDate = task.StartDate;
                        existing.EndDate = task.EndDate;
                        existing.Duration = task.Duration;
                        existing.Progress = task.Progress;
                        existing.Dependency = task.Dependency;
                        existing.ParentID = task.ParentID;
                    }
                }

                // Deleted: remove by TaskID
                if (crud.Deleted != null)
                {
                    foreach (var task in crud.Deleted)
                    {
                        var existing = tasks.FirstOrDefault(t => t.TaskID == task.TaskID);
                        if (existing != null)
                            tasks.Remove(existing);
                    }
                }
            }

            // Return the updated data and count
            var dataSource = tasks.AsQueryable();
            int totalRecordsCount = tasks.Count;
            return Ok(new { result = dataSource, count = totalRecordsCount });
        }
    }

    /// <summary>
    /// Wrapper class for WebMethodAdaptor requests.
    /// WebMethodAdaptor wraps DataManagerRequest inside a 'value' property.
    /// </summary>
    public class DataManager
    {
        public required DataManagerRequest Value { get; set; }
    }
}
{% endhighlight %}
{% endtabs %}

{% endif %}

### Step 2: Client-side gantt configuration

The Gantt enables full CRUD functionality by configuring the required [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) buttons (`Add`, `Edit`, `Update`, `Delete`, and `Cancel`) and enabling adding, editing, updating, and deleting through the `EditSettings` property. This setup allows the Gantt to handle all basic data operations directly from the UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@{
    // Configure DataManager with WebMethodAdaptor.
    var dataManager = new DataManager(){
        Url = "https://localhost:xxxx/api/Gantt", // Here xxxx represents the port number.
        Adaptor = "WebMethodAdaptor", // Handles all WebMethodAdaptor communication
        CrossDomain = true, // Enables cross-domain requests
    };
}

<ejs-gantt id="Gantt" dataSource="@dataManager" height="400px">
    <e-gantt-taskfields id="TaskID" name="TaskName" startDate="StartDate" endDate="EndDate"
                        duration="Duration" progress="Progress" dependency="Dependency"
                        parentID="ParentID">
    </e-gantt-taskfields>
    <e-gantt-editsettings allowEditing="true" allowAdding="true" allowDeleting="true"
                          allowTaskbarEditing="true"></e-gantt-editsettings>
    <e-gantt-columns>
        <e-gantt-column field="TaskID" headerText="Task ID" textAlign="Right" width="90" type="number" isPrimaryKey="true"></e-gantt-column>
        <e-gantt-column field="TaskName" headerText="Task Name" textAlign="Left" width="270" type="string"></e-gantt-column>
        <e-gantt-column field="StartDate" headerText="Start Date" textAlign="Right" width="150" format="yMd" type="dateTime"></e-gantt-column>
        <e-gantt-column field="EndDate" headerText="End Date" textAlign="Right" width="150" format="dd/MM/yyyy hh:mm" type="dateTime"></e-gantt-column>
        <e-gantt-column field="Duration" headerText="Duration" textAlign="Right" width="90" type="number"></e-gantt-column>
        <e-gantt-column field="Progress" headerText="Progress" textAlign="Right" width="120" type="number"></e-gantt-column>
    </e-gantt-columns>
</ejs-gantt>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    var dataManager = new ej.data.DataManager({
        url: 'https://localhost:xxxx/api/Gantt', // Here xxxx represents the port number.
        adaptor: new ej.data.WebMethodAdaptor(),
        crossDomain: true
    });
</script>

@(Html.EJS().Gantt("Gantt").DataSource(dataManager)
    .Height("400px")
    .TaskFields(ts => ts.Id("TaskID").Name("TaskName").StartDate("StartDate").EndDate("EndDate")
        .Duration("Duration").Progress("Progress").Dependency("Dependency").ParentID("ParentID"))
    .EditSettings(es => es.AllowEditing(true).AllowAdding(true).AllowDeleting(true).AllowTaskbarEditing(true))
    .Toolbar(new List<string>() { "Add", "Edit", "Update", "Delete", "Cancel", "ExpandAll", "CollapseAll", "Indent", "Outdent" })
    .Columns(col =>
    {
        col.Field("TaskID").HeaderText("Task ID").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("90").Type("number").IsPrimaryKey(true).Add();
        col.Field("TaskName").HeaderText("Task Name").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Left).Width("270").Type("string").Add();
        col.Field("StartDate").HeaderText("Start Date").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("150").Format("yMd").Type("dateTime").Add();
        col.Field("EndDate").HeaderText("End Date").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("150").Format("dd/MM/yyyy hh:mm").Type("dateTime").Add();
        col.Field("Duration").HeaderText("Duration").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("90").Type("number").Add();
        col.Field("Progress").HeaderText("Progress").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("120").Type("number").Add();
    })
    .Render()
)
{% endhighlight %}
{% endtabs %}

{% endif %}

> For detailed editing setup, refer to the [editing documentation](../managing-tasks/editing-tasks).

## Run the application

Run the application in ##Platform_Name## development environment, accessible on a URL like **https://localhost:xxxx**. Verify the API returns data at **https://localhost:xxxx/api/Gantt**, where **xxxx** is the port. Gantt displays data fetched from the backend API.

## Troubleshooting

| Issue                     | Cause                                                                                   | Solution                                                                                                              |
|---------------------------|-----------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------|
| Empty response            | Web method not returning task records or required metadata                              | Verify method returns records with parent ids, resource assignments, and start/end dates for the timeline range     |
| 404 responses             | Incorrect web method route or endpoint configuration                                     | Confirm DataManager URLs and routes are correctly configured and accessible                                          |
| 500 or server errors      | Server-side exceptions or improper request parameter handling                            | Check server logs, validate parameter parsing, and ensure scheduling/dependency logic is error-free                  |
| CORS errors               | Cross-origin requests blocked or not configured                                          | Ensure CORS is enabled when frontend and backend are hosted on different origins                                     |
| Related data mismatches   | Remote datasets not returning expected values for relationships and dependencies         | Confirm related endpoints return correct data required for display and dependency resolution                         |

## Complete sample repository

For the complete working implementation of this example, refer to the repository.

## See also
- [Connect to OdataV4 services](./odatav4-adaptor)
- [Hybrid data binding](./remote-save-adaptor)
- [Data binding](../data-binding)
