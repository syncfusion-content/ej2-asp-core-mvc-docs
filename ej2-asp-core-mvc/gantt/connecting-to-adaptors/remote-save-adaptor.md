---
layout: post
title: RemoteSave Adaptor in Syncfusion ##Platform_Name## Gantt Component
description: ##Platform_Name## Gantt Remote Save adaptor explains the hybrid workflow where the full task set is fetched once and CRUD is persisted via a batch endpoint.
platform: ej2-asp-core-mvc
control: RemoteSave Adaptor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Binding with RemoteSaveAdaptor in Syncfusion ##Platform_Name## Gantt Chart

The `RemoteSaveAdaptor` in the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt chart provides a hybrid data workflow. Use this adaptor when want to fetch the complete task set once, perform client-side operations for responsiveness, and persist edits back to the server via batch CRUD requests. Choose RemoteSaveAdaptor when fast client-side interaction is required while maintaining server-side data persistence. Unlike fully remote adaptors, it combines local data operations with remote synchronization.

This guide describes the conceptual project layout and patterns for wiring the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt chart to a backend that implements a batch CRUD endpoint.

**Project structure:**

- Frontend: A ##Platform_Name## application that hosts the Gantt and loads the full task dataset into a `DataManager` configured with `RemoteSaveAdaptor`.
- Backend: A web API that serves the complete task list and exposes a batch endpoint that accepts added/changed/deleted records in a single payload.

```
RemoteSaveAdaptor/
└── RemoteSaveAdaptor.Server/        # ASP.NET Core / ASP.NET MVC backend (API).
    ├── Controllers/                 # API controllers (will be created here).
    ├── Models/                      # Data models (will be created here).
    └── Program.cs                   # Server configuration.
```

## Gantt frontend setup using RemoteSaveAdaptor

This section describes at a conceptual level, how the Gantt consumes task data from remote save and submits task changes. Implementation and package installation steps are covered in platform-specific setup guides and are intentionally omitted here.

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

### Step 2: Configure DataManager with RemoteSaveAdaptor

- Configure a DataManager instance that loads the full task dataset from the server and specifies the `RemoteSaveAdaptor`. The Gantt then uses that DataManager as its source for task records and related datasets, and persists CRUD changes via a batch endpoint.

Conceptually, the adaptor fetches all data once, enables fast client-side operations, and synchronizes changes back to the server in batches.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<ejs-gantt id="Gantt" height="450px">
     <e-gantt-taskfields id="taskId" name="taskName" startDate="startDate" endDate="endDate" duration="duration"
                         progress="progress" parentID="parentId">
     </e-gantt-taskfields>
     <e-gantt-editsettings allowAdding="true" allowEditing="true" allowDeleting="true" allowTaskbarEditing="true">
     </e-gantt-editsettings>
     <e-gantt-columns>
         <e-gantt-column field="taskId" headerText="Task ID" isPrimaryKey="true" width="90">
         </e-gantt-column>
         <e-gantt-column field="taskName" headerText="Task Name" width="250">
         </e-gantt-column>
         <e-gantt-column field="startDate" headerText="Start Date" format="yMd">
         </e-gantt-column>
         <e-gantt-column field="endDate" headerText="End Date" format="dd/MM/yyyy hh:mm">
         </e-gantt-column>
         <e-gantt-column field="duration" headerText="Duration" editType="numericedit" type="number">
         </e-gantt-column>
         <e-gantt-column field="progress" headerText="Progress">
         </e-gantt-column>
     </e-gantt-columns>
</ejs-gantt>
@section Scripts
{
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            loadGantt();
        });
        function loadGantt() {
            fetch('https://localhost:xxxx/api/gantt') // Here xxxx represents the port number.
                .then(response => response.json())
                .then(result => {
                    let data = new ej.data.DataManager({
                        json: result,
                        adaptor: new ej.data.RemoteSaveAdaptor(),
                        batchUrl: 'https://localhost:xxxx/api/gantt/Batch', // Here xxxx represents the port number.
                    });
                    createGantt(data);
                })
                .catch(error => {
                    console.error(error);
                });
        }
        function createGantt(data) {
            var gantt = document.querySelector('#Gantt')?.ej2_instances?.[0];
            if (!gantt) {
                console.error("Gantt instance not found");
                return;
            }
            gantt.dataSource = data;
        }
    </script>
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    var serviceUrl = 'https://localhost:xxxx/api/gantt'; // Here xxxx represents the port number.
    var dataManager;

    // Fetch the full task dataset once and configure DataManager with RemoteSaveAdaptor.
    fetch(serviceUrl)
        .then(function (response) { return response.json(); })
        .then(function (result) {
            dataManager = new ej.data.DataManager({
                json: result,
                adaptor: new ej.data.RemoteSaveAdaptor(),
                batchUrl: serviceUrl + '/Batch',
                enableOffline: true
            });
        });
</script>

@(Html.EJS().Gantt("Gantt").DataSource("dataManager")
    .Height("400px")
    .TaskFields(ts => ts.Id("TaskID").Name("TaskName").StartDate("StartDate").EndDate("EndDate")
        .Duration("Duration").Progress("Progress").ParentID("ParentID"))
    .EditSettings(es => es.AllowEditing(true).AllowAdding(true).AllowDeleting(true).AllowTaskbarEditing(true))
    .Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" })
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

**Server-side batch endpoint**

The server receives a batch payload that contains `added`, `changed`, and `deleted` arrays. The batch endpoint applies each section in turn—assigning identifiers for new tasks if required, updating existing records, and removing deleted items—then returns a response the client can reconcile against its local state.

### Step 1: Server-side controller

Add the required controller method to **GanttController.cs**. Replace the entire controller with this complete version:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cs tabtitle="GanttController.cs - Batch Handler" %}
using GanttServerSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace GanttServerSample.Controllers
{
    [Route("api/[controller]")]
    public class GanttController : ControllerBase
    {
        /// <summary>
        /// GET endpoint – returns all Gantt tasks.
        /// Used by ##Platform_Name## Gantt for initial data load.
        /// </summary>
        [HttpGet]
        public List<GanttTask> GetGanttData()
        {
            return GanttData.GetAllTasks().ToList();
        }

        [HttpPost("Batch")]
        public IActionResult BatchUpdate([FromBody] CRUDModel<GanttTask> crud)
        {
            // INSERT
            if (crud.added != null && crud.added.Count > 0)
            {
                foreach (var task in crud.added)
                {
                    task.TaskId = GanttData.GetAllTasks().Max(x => x.TaskId) + 1;
                    GanttData.GetAllTasks().Add(task);
                }
            }
            // UPDATE
            if (crud.changed != null && crud.changed.Count > 0)
            {
                foreach (var task in crud.changed)
                {
                    var data = GanttData.GetAllTasks()
                        .FirstOrDefault(x => x.TaskId == task.TaskId);
                    if (data != null)
                    {
                        data.TaskName = task.TaskName;
                        data.StartDate = task.StartDate;
                        data.EndDate = task.EndDate;
                        data.Duration = task.Duration;
                        data.Progress = task.Progress;
                        data.ParentId = task.ParentId;
                    }
                }
            }
            // DELETE
            if (crud.deleted != null && crud.deleted.Count > 0)
            {
                foreach (var task in crud.deleted)
                {
                    var data = GanttData.GetAllTasks()
                        .FirstOrDefault(x => x.TaskId == task.TaskId);

                    if (data != null)
                    {
                        GanttData.GetAllTasks().Remove(data);
                    }
                }
            }
            return Ok(crud);
        }
    }
    public class CRUDModel<T> where T : class
    {
        public string? action { get; set; }
        public string? key { get; set; }
        public string? table { get; set; }
        public List<T>? added { get; set; }
        public List<T>? changed { get; set; }
        public List<T>? deleted { get; set; }
    }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="GanttController.cs - Batch Handler" %}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using GanttServerSample.Models;

namespace GanttServerSample.Controllers
{
    [RoutePrefix("api/gantt")]
    public class GanttController : ApiController
    {
        /// <summary>
        /// GET endpoint – returns all Gantt tasks.
        /// Used by ##Platform_Name## Gantt for initial data load.
        /// </summary>
        [HttpGet]
        public List<GanttTask> GetGanttData()
        {
            return GanttData.GetAllTasks().ToList();
        }

        [HttpPost]
        [Route("Batch")]
        public IHttpActionResult BatchUpdate(CRUDModel<GanttTask> crud)
        {
            // INSERT
            if (crud.added != null && crud.added.Count > 0)
            {
                foreach (var task in crud.added)
                {
                    task.TaskId = GanttData.GetAllTasks().Max(x => x.TaskId) + 1;
                    GanttData.GetAllTasks().Add(task);
                }
            }
            // UPDATE
            if (crud.changed != null && crud.changed.Count > 0)
            {
                foreach (var task in crud.changed)
                {
                    var data = GanttData.GetAllTasks()
                        .FirstOrDefault(x => x.TaskId == task.TaskId);
                    if (data != null)
                    {
                        data.TaskName = task.TaskName;
                        data.StartDate = task.StartDate;
                        data.EndDate = task.EndDate;
                        data.Duration = task.Duration;
                        data.Progress = task.Progress;
                        data.ParentId = task.ParentId;
                    }
                }
            }
            // DELETE
            if (crud.deleted != null && crud.deleted.Count > 0)
            {
                foreach (var task in crud.deleted)
                {
                    var data = GanttData.GetAllTasks()
                        .FirstOrDefault(x => x.TaskId == task.TaskId);

                    if (data != null)
                    {
                        GanttData.GetAllTasks().Remove(data);
                    }
                }
            }
            return Ok(crud);
        }
    }
    public class CRUDModel<T> where T : class
    {
        public string action { get; set; }
        public string key { get; set; }
        public string table { get; set; }
        public List<T> added { get; set; }
        public List<T> changed { get; set; }
        public List<T> deleted { get; set; }
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
<ejs-gantt id="Gantt" height="450px">
     <e-gantt-taskfields id="taskId" name="taskName" startDate="startDate" endDate="endDate" duration="duration"
                         progress="progress" parentID="parentId">
     </e-gantt-taskfields>
     <e-gantt-editsettings allowAdding="true" allowEditing="true" allowDeleting="true" allowTaskbarEditing="true">
     </e-gantt-editsettings>
     <e-gantt-columns>
         <e-gantt-column field="taskId" headerText="Task ID" isPrimaryKey="true" width="90">
         </e-gantt-column>
         <e-gantt-column field="taskName" headerText="Task Name" width="250">
         </e-gantt-column>
         <e-gantt-column field="startDate" headerText="Start Date" format="yMd">
         </e-gantt-column>
         <e-gantt-column field="endDate" headerText="End Date" format="dd/MM/yyyy hh:mm">
         </e-gantt-column>
         <e-gantt-column field="duration" headerText="Duration" editType="numericedit" type="number">
         </e-gantt-column>
         <e-gantt-column field="progress" headerText="Progress">
         </e-gantt-column>
     </e-gantt-columns>
</ejs-gantt>
@section Scripts
{
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            loadGantt();
        });
        function loadGantt() {
            fetch('https://localhost:xxxx/api/gantt') // Here xxxx represents the port number.
                .then(response => response.json())
                .then(result => {
                    let data = new ej.data.DataManager({
                        json: result,
                        adaptor: new ej.data.RemoteSaveAdaptor(),
                        batchUrl: 'https://localhost:xxxx/api/gantt/Batch', // Here xxxx represents the port number.
                    });
                    createGantt(data);
                })
                .catch(error => {
                    console.error(error);
                });
        }
        function createGantt(data) {
            var gantt = document.querySelector('#Gantt')?.ej2_instances?.[0];
            if (!gantt) {
                console.error("Gantt instance not found");
                return;
            }
            gantt.dataSource = data;
        }
    </script>
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    var serviceUrl = 'https://localhost:xxxx/api/gantt'; // Here xxxx represents the port number.
    var dataManager;

    fetch(serviceUrl)
        .then(function (response) { return response.json(); })
        .then(function (result) {
            dataManager = new ej.data.DataManager({
                json: result,
                adaptor: new ej.data.RemoteSaveAdaptor(),
                batchUrl: serviceUrl + '/Batch',
                enableOffline: true
            });
        });
</script>

@(Html.EJS().Gantt("Gantt").DataSource("dataManager")
    .Height("400px")
    .TaskFields(ts => ts.Id("TaskID").Name("TaskName").StartDate("StartDate").EndDate("EndDate")
        .Duration("Duration").Progress("Progress").ParentID("ParentID"))
    .EditSettings(es => es.AllowEditing(true).AllowAdding(true).AllowDeleting(true).AllowTaskbarEditing(true))
    .Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" })
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

Run the application in ##Platform_Name## development environment, accessible on a URL like **https://localhost:xxxx**. Verify the API returns data at **https://localhost:xxxx/api/gantt/Batch**, where **xxxx** is the port. Gantt displays data fetched from the backend API.

## Troubleshooting

| Issue                     | Cause                                                      | Solution                                                                                 |
|---------------------------|------------------------------------------------------------|------------------------------------------------------------------------------------------|
| Empty initial load        | GET task endpoint not returning required task records      | Verify endpoint returns records with required fields (ids, start/end dates, parent ids) |
| Batch requests not applied| Incorrect batchUrl or unsupported server payload            | Confirm `batchUrl` is correct and server accepts expected payload format                |
| Identifier mismatches     | Server not returning stable keys for new records            | Ensure server returns assigned ids so client can replace temporary ids                  |
| CORS or network errors    | Cross-origin requests blocked or misconfiguration              | Confirm CORS is enabled when frontend and backend are hosted separately                 |

## Complete sample repository

For the complete working implementation of this example, refer to the repository.

## See also
- [Connect to OdataV4 services](./odatav4-adaptor)
- [RESTful CRUD Operations in ASP.NET Web Forms](./web-method-adaptor)
- [Data binding](../data-binding)
