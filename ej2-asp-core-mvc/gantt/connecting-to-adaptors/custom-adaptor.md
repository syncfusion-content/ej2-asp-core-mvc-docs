---
layout: post
title: Custom Adaptor in Syncfusion ##Platform_Name## Gantt Component
description: ##Platform_Name## Gantt Chart CustomAdaptor explains creating a custom data adaptor to transform requests and responses, enabling custom backends and behaviors.
platform: ej2-asp-core-mvc
control: Custom Adaptor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom Remote Data Binding in Syncfusion ##Platform_Name## Gantt Chart

The `CustomAdaptor` in the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt Chart is a powerful extension mechanism that customizes any existing adaptor ([RemoteSaveAdaptor](./remote-save-adaptor), [WebMethodAdaptor](./web-method-adaptor), [ODataV4Adaptor](./odatav4-adaptor), [GraphQLAdaptor](./graphql-adaptor)) to meet specific application requirements. Use this adaptor when the built-in adaptors do not fully match backend requirements and need to customize request or response pipeline. Instead of creating an adaptor from scratch, `CustomAdaptor` intercepts and customizes the HTTP request/response pipeline used by the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt Chart.

Once the project creation and backend setup are complete, the next step is to render the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt Chart component on the client side.

**Project structure:**

- Frontend: A ##Platform_Name## application that hosts the Gantt Chart component and configures the Custom DataManager by extending ODataV4Adaptor.
- Backend: An OData v4 service that exposes task entities and supports the query options that client will use.

```
CustomAdaptor/
└── CustomAdaptor.Server/        # ASP.NET Core / ASP.NET MVC backend (API).
    ├── Controllers/                 # API controllers (will be created here).
    ├── Models/                      # Data models (will be created here).
    └── Program.cs                   # Server configuration.
```

## Gantt Chart setup and client-side configuration

This section explains how the Gantt Chart interacts with a `CustomAdaptor` for extending OData v4 services. Implementation and package installation steps are covered in platform-specific setup guides and are intentionally omitted here.

### Step 1: CSS and component styling

- Include the required Syncfusion theme and component styles so the Gantt Chart and its input controls render correctly. The theme is referenced in `~/Pages/Shared/_Layout.cshtml` for **ASP.NET Core** and in `~/Views/Shared/_Layout.cshtml` for **ASP.NET MVC**.

```cshtml
<head>
    <!-- Syncfusion ##Platform_Name## controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/tailwind3.css" />
    <!-- Syncfusion ##Platform_Name## controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>
```

### Step 2: Create ##Platform_Name## Gantt Chart component with CustomAdaptor

Integrating a `CustomAdaptor` with the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt Chart requires configuring the `DataManager` as the communication bridge between the Gantt Chart component and the backend data source. The `CustomAdaptor` serves as a powerful customization layer that provides complete control over how data operations are transmitted to the server.

#### Step 2.1: Creating an Extended ODataV4Adaptor

The first step involves creating a `CustomAdaptor` by extending the existing `ODataV4Adaptor` class. This extension allows modification of the default behavior to meet specific application requirements.

**Understanding the CustomAdaptor implementation:**

The example below demonstrates a `CustomAdaptor` class that extends `ODataV4Adaptor`.

| Method            | Execution Phase                          | Purpose & Key Actions                                                                 |
|-------------------|------------------------------------------|---------------------------------------------------------------------------------------|
| `processResponse` | After receiving server response, before Gantt Chart rendering | |
| `processQuery`    | Before sending request to server         | Sets custom OData endpoint URL and adds extra query parameters → enables dynamic URLs and request tracking/identification |
| `beforeSend`      | Immediately before the HTTP request is sent  | Adds `Authorization: Bearer` header using token from `window` → automatically authenticates every API request |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@page
@model IndexModel
@{
    ViewData["Title"] = "Gantt Sample";
}
<script>
    // Define the CustomAdaptor class by extending ODataV4Adaptor.
    class CustomAdaptor extends ej.data.ODataV4Adaptor {
        processResponse() {
            const original = super.processResponse.apply(this, arguments);
            return original;
        }
        processQuery(dm, query) {
            dm.dataSource.url = 'https://localhost:xxxx/odata/GanttTasks'; // Here xxxx represents the port number.
            query.addParams('Syncfusion in ASP.NET Core Gantt Chart', 'true');
            const result = super.processQuery.apply(this, arguments);
            return result;
        }
        beforeSend(dm, request, settings) {
            request.headers.set('Authorization', `Bearer ${window.token}`);
            super.beforeSend(dm, request, settings);
        }
    }
    // Create the DataManager instance with CustomAdaptor.
    var dataManager = new ej.data.DataManager({
        url: 'https://localhost:xxxx/odata/GanttTasks', // Here xxxx represents the port number.
        adaptor: new CustomAdaptor(),
        key: 'TaskID',
        crossDomain: true
    });
    document.addEventListener("DOMContentLoaded", function () {
        var gantt = document.getElementById('Gantt').ej2_instances[0];
        if (gantt)
            gantt.dataSource = dataManager;
    });
</script>

<ejs-gantt id="Gantt"
           height="400px">
    <e-gantt-taskfields id="TaskID" name="TaskName" startDate="StartDate" endDate="EndDate"
                        duration="Duration" progress="Progress" dependency="Dependency"
                        parentID="ParentID" segments="Segments" resourceInfo="ResourceInfos">
    </e-gantt-taskfields>
    <e-gantt-resourcefields id="resourceId" name="resourceName" unit="resourceUnit" group="resourceGroup">
    </e-gantt-resourcefields>
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
    // Define the CustomAdaptor class by extending ODataV4Adaptor.
    class CustomAdaptor extends ej.data.ODataV4Adaptor {
        processResponse() {
            const original = super.processResponse.apply(this, arguments);
            return original;
        }
        processQuery(dm, query) {
            dm.dataSource.url = 'https://localhost:xxxx/odata/GanttTasks'; // Here xxxx represents the port number.
            query.addParams('Syncfusion in ASP.NET MVC Gantt Chart', 'true');
            const result = super.processQuery.apply(this, arguments);
            return result;
        }
        beforeSend(dm, request, settings) {
            request.headers.set('Authorization', `Bearer ${window.token}`);
            super.beforeSend(dm, request, settings);
        }
    }
    // Create the DataManager instance with CustomAdaptor.
    var dataManager = new ej.data.DataManager({
        url: 'https://localhost:xxxx/odata/GanttTasks', // Here xxxx represents the port number.
        adaptor: new CustomAdaptor(),
        key: 'TaskID',
        crossDomain: true
    });
    document.addEventListener("DOMContentLoaded", function () {
        var gantt = document.getElementById('Gantt').ej2_instances[0];
        if (gantt)
            gantt.dataSource = dataManager;
    });
</script>

@(Html.EJS().Gantt("Gantt")
    .Height("400px")
    .DataSource("dataManager")
    .TaskFields(ts => ts.Id("TaskID").Name("TaskName").StartDate("StartDate").EndDate("EndDate")
        .Duration("Duration").Progress("Progress").Dependency("Dependency")
        .ParentID("ParentID").Segments("Segments").ResourceInfo("ResourceInfos"))
    .ResourceFields(rs => rs.Id("resourceId").Name("resourceName").Unit("resourceUnit").Group("resourceGroup"))
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

**Server-side data operations**

When tasks, dependencies or resource assignments are numerous or governed by centralized business rules, the server commonly performs processing that would be costly or inconsistent on the client. For Gantt Chart scenarios, server responsibilities typically include selecting tasks for a requested timeline range, applying visibility rules, resolving dependencies, and producing any roll-up or hierarchical values required by the client. The `Syncfusion.EJ2.AspNet.Core` package supports this approach by providing built-in methods that efficiently handle these operations on the server, ensuring smooth performance even with heavy data loads.

## CRUD operations

The DataManager with `CustomAdaptor` supports **Create** (add records), **Read** (view records), **Update** (modify records), and **Delete** (remove records) workflows for task entities. In Gantt Chart usage, these operations cover task creation, task edits (including taskbar edits and resulting scheduling recalculations), dependency creation or modification, and task deletion.

**Mapping CRUD operations to service endpoints**

CRUD operations are conveyed to the service using standard OData conventions. The `CustomAdaptor` works with ODataV4Adaptor with a single task endpoint and standard HTTP methods:

| Operation | HTTP Method | URL Example | Description |
|-----------|-------------|-------------|-------------|
| **Read** | GET | `/odata/GanttTasks` | Get all records. |
| **Create** | POST | `/odata/GanttTasks` | Add a new record. |
| **Update** | PATCH | `/odata/GanttTasks(1)` | Update record with key "1". |
| **Delete** | DELETE | `/odata/GanttTasks(1)` | Delete record with key "1". |

### Step 1: Server-side controller

Add the required controller method to **GanttTasksController.cs**. Replace the entire controller with this complete version:

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
        var data = GanttDataAdaptor.GetAllRecords();
        return Ok(data.AsQueryable());
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
            var data = GanttDataAdaptor.GetAllRecords();
            return Ok(data.AsQueryable());
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

### Step 2: Client-side Gantt Chart configuration

The Gantt Chart enables full CRUD functionality by configuring the required [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) buttons (`Add`, `Edit`, `Update`, `Delete`, and `Cancel`) and enabling adding, editing, updating, and deleting through the `EditSettings` property. This setup allows the Gantt Chart to handle all basic data operations directly from the UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@page
@model IndexModel
@{
    ViewData["Title"] = "Gantt Sample";
}
<script>
    class CustomAdaptor extends ej.data.ODataV4Adaptor {
        processResponse() {
            const original = super.processResponse.apply(this, arguments);
            return original;
        }
        processQuery(dm, query) {
            dm.dataSource.url = 'https://localhost:xxxx/odata/GanttTasks'; // Here xxxx represents the port number.
            query.addParams('Syncfusion in ASP.NET Core Gantt Chart', 'true');
            const result = super.processQuery.apply(this, arguments);
            return result;
        }
        beforeSend(dm, request, settings) {
            request.headers.set('Authorization', `Bearer ${window.token}`);
            super.beforeSend(dm, request, settings);
        }
    }
    var dataManager = new ej.data.DataManager({
        url: 'https://localhost:xxxx/odata/GanttTasks', // Here xxxx represents the port number.
        adaptor: new CustomAdaptor(),
        key: 'TaskID',
        crossDomain: true
    });
    document.addEventListener("DOMContentLoaded", function () {
        var gantt = document.getElementById('Gantt').ej2_instances[0];
        if (gantt)
            gantt.dataSource = dataManager;
    });
</script>

<ejs-gantt id="Gantt"
           height="400px">
    <e-gantt-taskfields id="TaskID" name="TaskName" startDate="StartDate" endDate="EndDate"
                        duration="Duration" progress="Progress" dependency="Dependency"
                        parentID="ParentID" segments="Segments" resourceInfo="ResourceInfos">
    </e-gantt-taskfields>
    <e-gantt-resourcefields id="resourceId" name="resourceName" unit="resourceUnit" group="resourceGroup">
    </e-gantt-resourcefields>
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
    class CustomAdaptor extends ej.data.ODataV4Adaptor {
        processResponse() {
            const original = super.processResponse.apply(this, arguments);
            return original;
        }
        processQuery(dm, query) {
            dm.dataSource.url = 'https://localhost:xxxx/odata/GanttTasks'; // Here xxxx represents the port number.
            query.addParams('Syncfusion in ASP.NET MVC Gantt Chart', 'true');
            const result = super.processQuery.apply(this, arguments);
            return result;
        }
        beforeSend(dm, request, settings) {
            request.headers.set('Authorization', `Bearer ${window.token}`);
            super.beforeSend(dm, request, settings);
        }
    }
    var dataManager = new ej.data.DataManager({
        url: 'https://localhost:xxxx/odata/GanttTasks', // Here xxxx represents the port number.
        adaptor: new CustomAdaptor(),
        key: 'TaskID',
        crossDomain: true
    });
    document.addEventListener("DOMContentLoaded", function () {
        var gantt = document.getElementById('Gantt').ej2_instances[0];
        if (gantt)
            gantt.dataSource = dataManager;
    });
</script>

@(Html.EJS().Gantt("Gantt")
    .Height("400px")
    .DataSource("dataManager")
    .TaskFields(ts => ts.Id("TaskID").Name("TaskName").StartDate("StartDate").EndDate("EndDate")
        .Duration("Duration").Progress("Progress").Dependency("Dependency")
        .ParentID("ParentID").Segments("Segments").ResourceInfo("ResourceInfos"))
    .ResourceFields(rs => rs.Id("resourceId").Name("resourceName").Unit("resourceUnit").Group("resourceGroup"))
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

Run the application in ##Platform_Name## development environment, accessible on a URL like **https://localhost:xxxx**. Verify the API returns data at **https://localhost:xxxx/odata/GanttTasks**, where **xxxx** is the port. Gantt Chart displays data fetched from the backend API.

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
