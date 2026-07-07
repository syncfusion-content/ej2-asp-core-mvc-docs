---
layout: post
title: ODataV4 Adaptor in Syncfusion ##Platform_Name## Gantt Component
description: ##Platform_Name## Gantt Chart OData v4 adaptor explains integration with OData v4 services and how the adaptor conveys task-related requests and updates.
platform: ej2-asp-core-mvc
control: ODataV4 Adaptor
publishingplatform: ##Platform_Name##
documentation: ug
---

# OData Remote Data Binding in Syncfusion ##Platform_Name## Gantt Chart

The [ODataV4Adaptor](https://ej2.syncfusion.com/aspnetcore/documentation/data/adaptors/odatav4-adaptor) in the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## DataManager enables seamless integration between the ##Platform_Name## Gantt chart and OData v4 services by translating the Gantt's task data requests and update actions into OData-formatted requests and by interpreting OData responses. Use this adaptor when backend exposes OData v4 endpoints and require standardized query capabilities with server-side processing. ODataV4Adaptor is intended specifically for OData-compliant services and is not required for standard REST or custom web-method endpoints.

For detailed server-side configuration and further implementation details, refer to the [DataManager ODataV4Adaptor documentation](https://ej2.syncfusion.com/aspnetcore/documentation/data/adaptors/odatav4-adaptor), which covers endpoint setup, query processing, and best practices for integrating OData V4 services.

Once the project creation and backend setup are complete, the next step is to render the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt chart component on the client side.

**Project structure:**

- Frontend: A ##Platform_Name## application that hosts the Gantt component and configures the DataManager with an ODataV4Adaptor.
- Backend: An OData v4 service that exposes task entities and supports the query options the client will use.

```
ODataV4Adaptor/
└── ODataV4Adaptor.Server/        # ASP.NET Core / ASP.NET MVC backend (API).
    ├── Controllers/                 # API controllers (will be created here).
    ├── Models/                      # Data models (will be created here).
    └── Program.cs                   # Server configuration.
```

## Gantt frontend setup using Syncfusion ODataV4Adaptor

This section explains how the Gantt interacts with an OData v4 service. Implementation and package installation steps are covered in platform-specific setup guides and are intentionally omitted here.

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

### Step 2: Configure DataManager with ODataV4Adaptor

- Configure a DataManager instance that points to the OData v4 task endpoint and specifies the ODataV4Adaptor. The Gantt then uses that DataManager as its source for task records and related datasets.

Conceptually, the adaptor formats timeline and task-related requests (for example, requests scoped to a taskbar edit, requests to fetch related resources, or requests that convey task modifications) as OData v4 queries the server can process.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@using Syncfusion.EJ2
@using Syncfusion.EJ2.Gantt

@{
    // Configure DataManager with ODataV4Adaptor pointing to the OData endpoint.
    var dataManager = new DataManager(){
        Url = "https://localhost:xxxx/odata/GanttTasks", // Here xxxx represents the port number.
        Adaptor = "ODataV4Adaptor", // Handles all ODataV4 communication
        CrossDomain = true, // Enables cross-domain requests
        Key = "TaskID"
    };
}
<ejs-gantt id="Gantt" dataSource="@dataManager" height="400px">
    <e-gantt-taskfields id="TaskID" name="TaskName" startDate="StartDate" endDate="EndDate"
                        duration="Duration" progress="Progress" dependency="Dependency"
                        parentID="ParentID">
    </e-gantt-taskfields>
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
@using Syncfusion.EJ2
@using Syncfusion.EJ2.Gantt

@{
    // Configure DataManager with ODataV4Adaptor pointing to the OData endpoint.
    var dataManager = new DataManager(){
        Url = "https://localhost:xxxx/odata/GanttTasks", // Here xxxx represents the port number.
        Adaptor = "ODataV4Adaptor", // Handles all ODataV4 communication
        CrossDomain = true, // Enables cross-domain requests
        Key = "TaskID"
    };
}
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

When tasks, dependencies or resource assignments are numerous or governed by centralized business rules, the server commonly performs processing that would be costly or inconsistent on the client. For Gantt scenarios, server responsibilities typically include selecting tasks for a requested timeline range, applying visibility rules, resolving dependencies, and producing any roll-up or hierarchical values required by the client. The `Syncfusion.EJ2.AspNet.Core` package supports this approach by providing built-in methods that efficiently handle these operations on the server, ensuring smooth performance even with heavy data loads.

## CRUD operations

The DataManager with ODataV4Adaptor supports **Create** (add records), **Read** (view records), **Update** (modify records), and **Delete** (remove records) workflows for task entities. In Gantt usage, these operations cover task creation, task edits (including taskbar edits and resulting scheduling recalculations), dependency creation or modification, and task deletion.

**Mapping CRUD operations to service endpoints**

CRUD operations are conveyed to the service using standard OData conventions. The ODataV4Adaptor works with a single task endpoint and standard HTTP methods:

| Operation | HTTP Method | URL Example | Description |
|-----------|-------------|-------------|-------------|
| **Read** | GET | `/odata/GanttTasks` | Get all records. |
| **Create** | POST | `/odata/GanttTasks` | Add a new record. |
| **Update** | PATCH | `/odata/GanttTasks(1)` | Update record with key "1". |
| **Delete** | DELETE | `/odata/GanttTasks(1)` | Delete record with key "1". |

### Step 1: Complete server-side controller

Add the required controller method **GanttTasksController.cs**. Replace the entire controller with this complete version:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cs tabtitle="GanttTasksController.cs - Complete CRUD Implementation" %}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataV4Adaptor.Server.Models;

[Route("[controller]")]
public class GanttTasksController : ODataController
{
    [EnableQuery]
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(GanttDataAdaptor.GetAllRecords().AsQueryable());
    }

    [HttpPost]
    [EnableQuery]
    public IActionResult Post([FromBody] GanttDataAdaptor task)
    {
        if (task == null)
            return BadRequest();

        GanttDataAdaptor.GetAllRecords().Add(task);
        return Created(task);
    }

    [HttpPatch("{key}")]
    [EnableQuery]
    public IActionResult Patch([FromODataUri] int key, [FromBody] GanttDataAdaptor updateRecord)
    {
        var task = GanttDataAdaptor.GetAllRecords()
            .FirstOrDefault(t => t.TaskID == key);

        if (task == null || task.TaskID != updateRecord.TaskID)
            return NotFound();
        task = updateRecord;

        return Ok(task);
    }

    [HttpDelete("{key}")]
    [EnableQuery]
    public IActionResult Delete(int key)
    {
        var task = GanttDataAdaptor.GetAllRecords()
            .FirstOrDefault(t => t.TaskID == key);

        if (task == null)
            return NotFound();

        GanttDataAdaptor.GetAllRecords().Remove(task);
        return NoContent();
    }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="GanttTasksController.cs - Complete CRUD Implementation" %}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData;
using ODataV4Adaptor.Server.Models;

namespace ODataV4Adaptor.Server.Controllers
{
    [RoutePrefix("odata/GanttTasks")]
    public class GanttTasksController : ODataController
    {
        [EnableQuery]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(GanttDataAdaptor.GetAllRecords().AsQueryable());
        }

        [HttpPost]
        [EnableQuery]
        public IHttpActionResult Post(GanttDataAdaptor task)
        {
            if (task == null)
                return BadRequest();

            GanttDataAdaptor.GetAllRecords().Add(task);
            return Created(task);
        }

        [HttpPatch]
        [EnableQuery]
        public IHttpActionResult Patch([FromODataUri] int key, GanttDataAdaptor updateRecord)
        {
            var task = GanttDataAdaptor.GetAllRecords()
                .FirstOrDefault(t => t.TaskID == key);

            if (task == null || task.TaskID != updateRecord.TaskID)
                return NotFound();
            task = updateRecord;

            return Ok(task);
        }

        [HttpDelete]
        [EnableQuery]
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            var task = GanttDataAdaptor.GetAllRecords()
                .FirstOrDefault(t => t.TaskID == key);

            if (task == null)
                return NotFound();

            GanttDataAdaptor.GetAllRecords().Remove(task);
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
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
@using Syncfusion.EJ2
@using Syncfusion.EJ2.Gantt

@{
    var dataManager = new DataManager(){
        Url = "https://localhost:xxxx/odata/GanttTasks", // Here xxxx represents the port number.
        Adaptor = "ODataV4Adaptor",
        CrossDomain = true,
        Key = "TaskID"
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
@using Syncfusion.EJ2
@using Syncfusion.EJ2.Gantt

@{
    var dataManager = new DataManager(){
        Url = "https://localhost:xxxx/odata/GanttTasks", // Here xxxx represents the port number.
        Adaptor = "ODataV4Adaptor",
        CrossDomain = true,
        Key = "TaskID"
    };
}
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

Run the application in ##Platform_Name## development environment, accessible on a URL like **https://localhost:xxxx**. Verify the API returns data at **https://localhost:xxxx/odata/GanttTasks**, where **xxxx** is the port. Gantt displays data fetched from the backend API.

## Troubleshooting

| Issue                     | Cause                                                                 | Solution                                                                                                     |
|---------------------------|-----------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------|
| Empty response            | Service not returning task records or required metadata               | Verify service returns records with fields like parent ids, resources, and start/end dates                  |
| 404 responses             | Incorrect route or endpoint configuration                             | Confirm DataManager URLs are correct and endpoints exist                                                     |
| 500 or server errors      | Server-side exceptions or improper request handling                   | Check server logs, validate parameters, and ensure scheduling/dependency logic is error-free                |
| Cross-origin errors       | CORS not enabled or misconfiguration                                     | Ensure cross-origin requests are allowed when frontend and backend are on different domains                 |
| Related data mismatches   | Remote datasets not returning expected values                         | Confirm related endpoints return correct data for display and dependency mapping                            |

## Complete sample repository

For the complete working implementation of this example, refer to the repository.

## See also
- [Hybrid data binding](./remote-save-adaptor)
- [RESTful CRUD Operations in ASP.NET Web Forms](./web-method-adaptor)
- [Data binding](../data-binding)
