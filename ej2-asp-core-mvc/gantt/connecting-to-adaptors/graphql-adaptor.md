---
layout: post
title: GraphQL Adaptor in Syncfusion ##Platform_Name## Gantt Component
description: ##Platform_Name## Gantt Chart GraphQL adaptor explains using GraphQL services to fetch and mutate task data and related datasets for timeline rendering.
platform: ej2-asp-core-mvc
control: GraphQL Adaptor
publishingplatform: ##Platform_Name##
documentation: ug
---

# GraphQL Remote Data Binding in Syncfusion ##Platform_Name## Gantt Chart

The `GraphQLAdaptor` in the Syncfusion<sup style="font-size:70%">&reg;</sup> DataManager enables the ##Platform_Name## Gantt to interact with GraphQL services by translating the Gantt's data requests and task update actions into GraphQL queries and mutations. Use this adaptor when backend exposes a GraphQL API and want flexible, efficient data fetching and mutation for Gantt tasks. `GraphQLAdaptor` is best for scenarios requiring precise data selection and real-time updates, offering capabilities not present in REST or OData adaptors.

For server configuration and schema expectations (queries, mutations, and response shapes), consult the GraphQL backend documentation appropriate for stack. After the GraphQL service is available, configure the Gantt's DataManager to use the GraphQL adaptor as its task data source.

[GraphQL](https://graphql.org/learn/introduction/) provides a single, flexible endpoint where clients specify the exact data shape required. For the Gantt this means requesting task fields, parent/child relationships, resource assignments, and any server-computed scheduling values in one query. Mutations allow the client to create, update, or delete tasks and dependencies while the server enforces scheduling rules and returns reconciled task states.

**Key GraphQL concepts relevant to Gantt:**
- Queries: request task data and related entities; useful for timeline windowing and resolving related resources in a single request.
- Mutations: perform create, update, and delete operations for tasks and dependencies; the server performs validation and scheduling recalculation.
- Schema and resolvers: define how task queries and mutations are resolved and which fields (for example, start/end, duration, parentId, resources) are available.

## Prerequisites

| Software / Package          | Recommended version          | Purpose                                 |
|-----------------------------|------------------------------|--------------------------------------   |
| Visual Studio / VS Code     | Latest                       | IDE for ##Platform_Name## development   |
| .NET SDK                    | 6.0 or later                 | Build and run the ##Platform_Name## application |
| Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## package | Latest | Render the Gantt Chart component       |

## Key topics

| # | Topics | Link |
|---|--------|-------|
| 1 | Configure the DataManager with GraphQLAdaptor | [View](#configuring-the-graphql-adaptor) |
| 2 | Integrate the Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## Gantt chart with the GraphQL API | [View](#integrating-syncfusion-platform_name-gantt-with-graphql) |
| 3 | Perform CRUD operations | [View](#step-3-perform-crud-operations) |
| 4 | Run the GraphQL application | [View](#running-the-application) |
| 5 | Explore a complete working sample available on GitHub | [View](#complete-sample-repository) |

### GraphQL vs REST comparison

Understanding the key differences between GraphQL and REST helps appreciate the benefits of using GraphQL with Syncfusion<sup style="font-size:70%">&reg;</sup> Gantt chart:

| Aspect | REST API | GraphQL |
|--------|----------|---------|
| **Endpoints** | Multiple endpoints (/api/orders, /api/customers). | Single endpoint (/graphql). |
| **Data fetching** | Fixed data structure per endpoint. | Flexible, client specifies exact data needs. |
| **Over-fetching** | Common (gets unnecessary data). | Eliminated (requests only needed fields). |
| **Under-fetching** | Requires multiple requests. | Single request for complex data. |
| **Versioning** | Requires API versioning (v1, v2). | Schema evolution without versioning. |
| **Type system** | Not built-in | Strongly typed schema. |
| **Query format** | URL parameters | Structured query language. |
| **Real-time** | Requires separate solution. | Built-in subscriptions support. |

**GraphQL Query example:**

```ts
query {
  getTasks {
    result {
      TaskID
      TaskName
      StartDate
    }
    count
  }
}
```

## Configuring the GraphQL Adaptor

The `GraphQLAdaptor` needs to be configured on the Syncfusion<sup style="font-size:70%">&reg;</sup> `DataManager` so that Gantt interactions are translated into GraphQL-compatible requests. Configure the `DataManager` with the adaptor, map the server's response paths (`result` and `count`), and assign the instance to the Gantt's `dataSource`.

**Instructions:**
1. Open the ##Platform_Name## view (for example, `~/Pages/Index.cshtml` for **ASP.NET Core** or `~/Views/Home/Index.cshtml` for **ASP.NET MVC**).
2. Configure `DataManager` with `GraphQLAdaptor` and map the response (`result` and `count`).
3. Ensure the GraphQL schema exposes a query (for example, `getTasks`) that returns `{ count, result }`.
4. Render the Gantt component with `dataSource` and define columns matching the fields returned by the query.

## Integrating Syncfusion ##Platform_Name## Gantt with GraphQL

This section describes conceptually how the Gantt consumes data through GraphQL. Implementation and installation steps are covered in platform-specific setup guides and are intentionally excluded here.

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

### Step 2: Configure GraphQL Adaptor in the Gantt

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<script>
    // Configure DataManager with GraphQLAdaptor.
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new ej.data.GraphQLAdaptor({
            // Map to { result, count } in GraphQL payload
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            // READ: fetch flat tasks (no DataManagerInput)
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            }
        }),
        crossDomain: true
    });
    document.addEventListener("DOMContentLoaded", function () {
        var gantt = document.getElementById('Gantt').ej2_instances[0];
        if (gantt)
            gantt.dataSource = ganttDataManager;
    });
</script>

<ejs-gantt id="Gantt" height="400px">
    <e-gantt-taskfields id="TaskID" name="TaskName" startDate="StartDate" endDate="EndDate"
                        duration="Duration" progress="Progress">
    </e-gantt-taskfields>
    <e-gantt-columns>
        <e-gantt-column field="TaskID" headerText="Task ID" width="80" type="number" isPrimaryKey="true"></e-gantt-column>
        <!-- Include additional columns here -->
    </e-gantt-columns>
</ejs-gantt>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    // Configure DataManager with GraphQLAdaptor.
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new ej.data.GraphQLAdaptor({
            // Map to { result, count } in GraphQL payload
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            // READ: fetch flat tasks (no DataManagerInput)
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            }
        }),
        crossDomain: true
    });
    document.addEventListener("DOMContentLoaded", function () {
        var gantt = document.getElementById('Gantt').ej2_instances[0];
        if (gantt)
            gantt.dataSource = ganttDataManager;
    });
</script>

@(Html.EJS().Gantt("Gantt").DataSource("ganttDataManager")
    .Height("400px")
    .TaskFields(ts => ts.Id("TaskID").Name("TaskName").StartDate("StartDate").EndDate("EndDate")
        .Duration("Duration").Progress("Progress"))
    .Columns(col =>
    {
        col.Field("TaskID").HeaderText("Task ID").Width("80").Type("number").IsPrimaryKey(true).Add();
        // Include additional columns here
    })
    .Render()
)
{% endhighlight %}
{% endtabs %}

{% endif %}

**GraphQL Query structure explained in detail**

The Query property is critical for understanding the data flows. Let's break down each component:

```
query getTasks {}
```

**Line breakdown:**
- `query` - GraphQL keyword indicating a read operation.
- `getTasks` - Name of the query (must match resolver name with camelCase).


```
getTasks{}
```

**Line breakdown:**
- `getTasks` - Calls the backend resolver to fetch task data.
- The resolver returns the requested `count` and `result` fields.


```
count
    result {
    TaskID
    TaskName
    }
```

**Line breakdown:**
- `count` - Returns total number of records.
- Example: If "150" total "task" records exist, count = 150.
- `result` - Contains the array of "task" records.
- `{ ... }` - List of fields to return for each record.
- Only requested fields are returned (no over-fetching).

**Response structure example**

When the backend executes the query, it returns a JSON response in this structure (example):

```json
{
  "data": {
    "getTasks": {
      "count": 1,
      "result": [
        {
          "TaskID": 1,
          "TaskName": "Planning and Permits",
          "StartDate": "2025-04-02",
          "EndDate": "2025-04-10",
          "Duration": 7,
          "Progress": 100,
          "ParentId": null,
          "Predecessor": null
        }
      ]
    }
  }
}
```

**Response structure explanation:**

| Part | Purpose | Example |
|------|---------|--------|
| `data` | Root object returned for every successful GraphQL query. | Always present in successful response. |
| `getTasks` | Matches the GraphQL query name; contains task data | Contains **count** and **result**. |
| `count` | Total number of records available. | 1 (in this example). |
| `result` | Array of "tasks" objects. | [ {...}, {...} ] |
| Each `field` in result | Matches GraphQL query field names. | Field values from database. |

### Step 3: Perform CRUD operations

CRUD operations (Create, Read, Update, Delete) are supported in the Gantt chart for managing data. The Gantt chart provides built-in dialogs and buttons to perform these operations, while the backend resolvers handle the actual data modifications.

Enable editing operations in the Gantt chart by configuring `EditSettings` and setting `AllowEditing`, `AllowAdding`, and `AllowDeleting` to `true`.

The "getMutation" function in the `GraphQLAdaptor` handles the Gantt chart CRUD actions by sending the appropriate mutation for each action (insert, update, or delete) to the GraphQL server.

**Insert:**

The Insert operation enables adding new "task" records to the task list. When the Add button in the toolbar is selected, the Gantt chart opens a dialog that displays input fields for entering task details.

After the required data is submitted, the GraphQL mutation sends the new "task" record to the backend for processing and storage.

Configure the `getMutation` function in the `GraphQLAdaptor` to return the GraphQL mutation for the insert action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<script>
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new ej.data.GraphQLAdaptor({
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            },
            // mutation for perform insert.
            getMutation: function (action) {
                if (action === 'insert') {
                    return `
                    mutation AddTask($value: GanttTaskInput!) {
                        addTask(value: $value) {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                        }
                    }`;
                }
            }
        }),
        crossDomain: true
    });
</script>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new ej.data.GraphQLAdaptor({
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            },
            // mutation for perform insert.
            getMutation: function (action) {
                if (action === 'insert') {
                    return `
                    mutation AddTask($value: GanttTaskInput!) {
                        addTask(value: $value) {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                        }
                    }`;
                }
            }
        }),
        crossDomain: true
    });
</script>
{% endhighlight %}
{% endtabs %}

{% endif %}

**Update:**

The Update operation enables editing of existing records. When the Edit option in the toolbar is selected and a row is chosen, the Gantt chart opens a dialog displaying the current values of the selected record.

After the required modifications are submitted, a GraphQL mutation sends the updated record to the backend for processing.

Configure the `getMutation` function in the `GraphQLAdaptor` to return the appropriate GraphQL mutation for the update action (for example, `updateTask`).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<script>
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new ej.data.GraphQLAdaptor({
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            },
            // mutation for perform update.
            getMutation: function (action) {
                if (action === 'update') {
                    return `
                    mutation UpdateTask($value: GanttTaskInput!) {
                        updateTask(value: $value) {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                        }
                    }`;
                }
            }
        }),
        crossDomain: true
    });
</script>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new ej.data.GraphQLAdaptor({
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            },
            // mutation for perform update.
            getMutation: function (action) {
                if (action === 'update') {
                    return `
                    mutation UpdateTask($value: GanttTaskInput!) {
                        updateTask(value: $value) {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                        }
                    }`;
                }
            }
        }),
        crossDomain: true
    });
</script>
{% endhighlight %}
{% endtabs %}

{% endif %}

**Delete:**

The Delete operation enables removal of records from the application. When the `Delete` option in the `toolbar` is selected and a row is marked for removal, a confirmation prompt appears. After confirmation, a GraphQL mutation sends a delete request to the backend containing only the primary key value.

Configure the `getMutation` function in the `GraphQLAdaptor` to return the delete mutation that matches the `deleteTask` mutation defined in the schema.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<script>
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new ej.data.GraphQLAdaptor({
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            },
            // mutation for perform delete.
            getMutation: function (action) {
                if (action === 'remove') {
                    return `
                    mutation DeleteTask($key: ID!) {
                        deleteTask(key: $key)
                    }`;
                }
            }
        }),
        crossDomain: true
    });
</script>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new ej.data.GraphQLAdaptor({
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            },
            // mutation for perform delete.
            getMutation: function (action) {
                if (action === 'remove') {
                    return `
                    mutation DeleteTask($key: ID!) {
                        deleteTask(key: $key)
                    }`;
                }
            }
        }),
        crossDomain: true
    });
</script>
{% endhighlight %}
{% endtabs %}

{% endif %}

## Overriding processResponse to handle mutation responses

By default the `GraphQLAdaptor` maps read queries that return `{ result, count }`. For CRUD actions the server often returns a single object (insert/update), a boolean (delete) or a different wrapper. To ensure the Gantt's `DataManager` correctly updates after mutations, override `processResponse` to normalize server responses into the shapes the adaptor expects.

Key points:
- Normalize single-item mutation responses into arrays when the client expects an array.
- Preserve the `{ result, count }` structure for reads so paging and counts continue to work.
- Fall back to `super.processResponse(...)` for any unhandled payloads.

Create a separate script block to define the extended adaptor class, then instantiate and use it on the Gantt's DataManager.

Recommended adaptor implementation (reviewed and improved):

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<script>
    // Define a custom GraphQLAdaptor that normalizes mutation responses.
    class GraphQLCrudAdaptor extends ej.data.GraphQLAdaptor {
        processResponse(resData, ds, query, xhr, request) {
            if (resData && resData.data) {
                var data = resData.data;

                // READ - expected shape: { result: [...], count: N }
                if (data.getTasks) {
                    return data.getTasks;
                }

                // UPDATE - normalize to array so DataManager can consume it
                if (data.updateTask) {
                    var updated = Array.isArray(data.updateTask) ? data.updateTask : [data.updateTask];
                    return { result: updated, count: updated.length };
                }

                // INSERT - normalize to array
                if (data.addTask) {
                    var added = Array.isArray(data.addTask) ? data.addTask : [data.addTask];
                    return { result: added, count: added.length };
                }

                // DELETE - server may return boolean; return as-is so calling code can handle it
                if (typeof data.deleteTask !== 'undefined') {
                    return { result: data.deleteTask };
                }
            }

            // Fallback to default behavior
            return super.processResponse(resData, ds, query, xhr, request);
        }
    }

    // Configure DataManager with the extended GraphQLCrudAdaptor.
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new GraphQLCrudAdaptor({
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            query:
                `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            }
        }),
        crossDomain: true
    });
</script>

<ejs-gantt id="Gantt" height="400px">
    <e-gantt-taskfields id="TaskID" name="TaskName" startDate="StartDate" endDate="EndDate"
                        duration="Duration" progress="Progress">
    </e-gantt-taskfields>
    <e-gantt-editsettings allowEditing="true" allowAdding="true" allowDeleting="true"
                          allowTaskbarEditing="true"></e-gantt-editsettings>
    <e-gantt-columns>
        <e-gantt-column field="TaskID" headerText="Task ID" width="80" type="number" isPrimaryKey="true"></e-gantt-column>
        <!-- Include additional columns here -->
    </e-gantt-columns>
</ejs-gantt>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<script>
    // Define a custom GraphQLAdaptor that normalizes mutation responses.
    class GraphQLCrudAdaptor extends ej.data.GraphQLAdaptor {
        processResponse(resData, ds, query, xhr, request) {
            if (resData && resData.data) {
                var data = resData.data;

                // READ - expected shape: { result: [...], count: N }
                if (data.getTasks) {
                    return data.getTasks;
                }

                // UPDATE - normalize to array so DataManager can consume it
                if (data.updateTask) {
                    var updated = Array.isArray(data.updateTask) ? data.updateTask : [data.updateTask];
                    return { result: updated, count: updated.length };
                }

                // INSERT - normalize to array
                if (data.addTask) {
                    var added = Array.isArray(data.addTask) ? data.addTask : [data.addTask];
                    return { result: added, count: added.length };
                }

                // DELETE - server may return boolean; return as-is so calling code can handle it
                if (typeof data.deleteTask !== 'undefined') {
                    return { result: data.deleteTask };
                }
            }

            // Fallback to default behavior
            return super.processResponse(resData, ds, query, xhr, request);
        }
    }

    // Configure DataManager with the extended GraphQLCrudAdaptor.
    var ganttDataManager = new ej.data.DataManager({
        url: 'http://localhost:xxxx/', // Here xxxx represents the port number.
        adaptor: new GraphQLCrudAdaptor({
            response: {
                result: 'getTasks.result',
                count: 'getTasks.count'
            },
            query:
               `query getTasks {
                getTasks {
                count
                    result {
                        TaskID
                        TaskName
                        # add additional fields to fetch initially, e.g.:StartDate
                    }
                }
            }`,
            mutation: {
                update: 'updateTask',
                insert: 'addTask',
                remove: 'deleteTask'
            }
        }),
        crossDomain: true
    });
</script>

@(Html.EJS().Gantt("Gantt").DataSource("ganttDataManager")
    .Height("400px")
    .TaskFields(ts => ts.Id("TaskID").Name("TaskName").StartDate("StartDate").EndDate("EndDate")
        .Duration("Duration").Progress("Progress"))
    .EditSettings(es => es.AllowEditing(true).AllowAdding(true).AllowDeleting(true).AllowTaskbarEditing(true))
    .Columns(col =>
    {
        col.Field("TaskID").HeaderText("Task ID").Width("80").Type("number").IsPrimaryKey(true).Add();
        // Include additional columns here
    })
    .Render()
)
{% endhighlight %}
{% endtabs %}

{% endif %}

## Running the application

Open a terminal or Command Prompt. Run the GraphQL server application first, then start the ##Platform_Name## application.

### Run the GraphQL server
- Start the GraphQL backend service that exposes the schema and resolvers. Ensure the GraphQL endpoint is reachable from the ##Platform_Name## application.
- Run the following commands to start the server:

```bash
  npm install
  npm run dev
```

### Run the client
- Press **F5** in Visual Studio or run the application from the project folder to launch the ##Platform_Name## Gantt Chart, which connects to the GraphQL service through the `GraphQLAdaptor`.

## Troubleshooting

- Empty response: Verify the GraphQL query returns the expected fields and that the server resolves the requested entities for the requested timeline range.
- 404 or endpoint issues: Confirm the GraphQL endpoint URL configured in the DataManager is correct.
- Server errors: Check server logs and ensure mutations and resolvers handle requested payloads without exceptions.
- Cross-origin errors: Ensure cross-origin requests are permitted when frontend and backend are hosted separately.
- Related data mismatches: When related datasets are fetched remotely, confirm the schema exposes the expected fields used for display and dependency resolution.

## Complete sample repository (reference)

For the complete working implementation of this example, refer to the repository.

## See also
- [Hybrid data binding](./remote-save-adaptor)
- [RESTful CRUD Operations in ASP.NET Web Forms](./web-method-adaptor)
- [Data binding](../data-binding)
