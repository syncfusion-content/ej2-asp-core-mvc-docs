---
layout: post
title: Snowflake Data Binding in ASP.NET Core Pivot Table | Syncfusion
description: Learn how to bind Snowflake data to the ASP.NET Core Pivot Table using the Snowflake.Data provider in a Web API controller exposed as JSON.
platform: ej2-asp-core-mvc
documentation: ug
---

# Snowflake Data Binding in ASP.NET Core Pivot Table

This section describes how to retrieve data from a Snowflake database using [Snowflake Data](https://www.nuget.org/packages/Snowflake.Data/#readme-body-tab) and bind it to the Pivot Table via a Web API controller.

## Creating a Web API Service to Fetch Snowflake Data

Follow these steps to create a Web API service that retrieves data from a Snowflake database and prepares it for the Pivot Table.

### Step 1: Create an ASP.NET Core Web Application
1. Open Visual Studio and create a new **ASP.NET Core Web App** project named **MyWebService**. Select the **Web API** project template (for example, **ASP.NET Core Web API** in Visual Studio 2022) so the project is configured with controllers and Swagger by default.
2. Follow the official [Microsoft documentation](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022) for detailed instructions on creating an ASP.NET Core Web application.
3. Before proceeding, ensure that a Snowflake account is provisioned, that a virtual warehouse exists, and that the `CALL_CENTER` table is available in the target database/schema (for example, by loading Snowflake's sample data). The connection string and table name used later in this walkthrough assume the example dataset from the walkthrough's GitHub sample.

![Creating an ASP.NET Core Web App project](../images/azure-asp-core-web-service-create.png)

### Step 2: Install the Snowflake NuGet Package
To enable Snowflake database connectivity:
1. Open the **NuGet Package Manager** in your project solution and search for [Snowflake.Data](https://www.nuget.org/packages/Snowflake.Data).
2. Install the [Snowflake.Data](https://www.nuget.org/packages/Snowflake.Data) package to add Snowflake support. Use `Snowflake.Data` version 2.x (or later) to match this walkthrough; pin the version if you want reproducible builds.

![Installing the Snowflake.Data NuGet package](../images/snowflake-data-nuget-package-install.png)

### Step 3: Create a Web API Controller
1. Under the **Controllers** folder, create a new Web API controller named **PivotController.cs**.
2. This controller facilitates data communication between the Snowflake database and the Pivot Table.

### Step 4: Connect to Snowflake and Retrieve Data
In the **PivotController.cs** file, use the [Snowflake.Data](https://www.nuget.org/packages/Snowflake.Data) library to connect to a Snowflake database and retrieve data for the Pivot Table.

1. **Establish Connection**: Use **SnowflakeDbConnection** with a valid connection string (e.g., `account=myaccount;user=myuser;password=mypassword;db=mydb;schema=myschema;`) to connect to the Snowflake database.
3. **Structure the Data**: Use **SnowflakeDbDataAdapter**'s **Fill** method to populate query results into a **DataTable** for JSON serialization.

```csharp
    using Microsoft.AspNetCore.Mvc;
    using Snowflake.Data.Client;
    using Newtonsoft.Json;
    using System.Data;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            [HttpGet(Name = "GetSnowflakeResult")]
            public object Get()
            {
                return JsonConvert.SerializeObject(FetchSnowflakeResult());
            }

            public static DataTable FetchSnowflakeResult()
            {
                using (SnowflakeDbConnection snowflakeConnection = new SnowflakeDbConnection())
                {
                    // Replace with your own connection string.
                    snowflakeConnection.ConnectionString = "<Enter your valid connection string here>";
                    snowflakeConnection.Open();
                    SnowflakeDbDataAdapter adapter = new SnowflakeDbDataAdapter("select * from CALL_CENTER", snowflakeConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    snowflakeConnection.Close();
                    return dataTable;
                }
            }
        }
    }

```

### Step 5: Serialize Data to JSON
In the **PivotController.cs** file, define a **Get** method that calls **FetchSnowflakeResult** to retrieve data from the Snowflake database as a **DataTable**. Then, use **JsonConvert.SerializeObject** from the **Newtonsoft.Json** library to convert the **DataTable** into JSON format. This JSON data will be used by the Pivot Table component.

> Ensure the `Newtonsoft.Json` NuGet package (version 13.x or later) is installed in your project before using `JsonConvert`. The `Get` method serializes the `DataTable` into a JSON string before ASP.NET Core's pipeline returns it as the response body. Note: returning a `JsonConvert.SerializeObject` of a `DataTable` produces a JSON array of row objects whose column values are mapped from the underlying Snowflake column types (for example, `NUMBER` → `number`, `VARCHAR` → `string`, `TIMESTAMP_NTZ` → ISO-8601 string, `VARIANT` → object).

```csharp
    using Microsoft.AspNetCore.Mvc;
    using Snowflake.Data.Client;
    using Newtonsoft.Json;
    using System.Data;

    namespace MyWebService.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PivotController : ControllerBase
        {
            [HttpGet(Name = "GetSnowflakeResult")]
            public object Get()
            {
                return JsonConvert.SerializeObject(FetchSnowflakeResult());
            }

            public static DataTable FetchSnowflakeResult()
            {
                using (SnowflakeDbConnection snowflakeConnection = new SnowflakeDbConnection())
                {
                    // Replace with your own connection string.
                    snowflakeConnection.ConnectionString = "<Enter your valid connection string here>";
                    snowflakeConnection.Open();
                    SnowflakeDbDataAdapter adapter = new SnowflakeDbDataAdapter("select * from CALL_CENTER", snowflakeConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    snowflakeConnection.Close();
                    return dataTable;
                }
            }
        }
    }

```

### Step 6: Run the Web API Service
1. In Visual Studio, set **MyWebService** as the startup project and press <kbd>F5</kbd> (or run `dotnet run` from the project folder). The actual listening ports are read from `launchSettings.json`; both HTTP and HTTPS endpoints are printed in the console.
2. The application will be hosted at `https://localhost:44378/` (the port number may vary based on your configuration). Note the exact URL printed by the runtime so you can reference it from the ASP.NET Core project.

### Step 7: Access the JSON Data
1. Access the Web API endpoint at `https://localhost:44378/Pivot` to view the JSON data retrieved from the Snowflake database.
2. The browser displays the JSON data, as shown in the image below, ready for use by the Pivot Table. A sample response has the following shape:

```json
[
  { "CC_COMPANY": "Company A", "CC_STATE": "CA", "CC_CITY": "Los Angeles", "CC_COUNTRY": "USA", "CC_EMPLOYEES": 100, "CC_TAX_PERCENTAGE": 7.25 },
  { "CC_COMPANY": "Company B", "CC_STATE": "NY", "CC_CITY": "New York",    "CC_COUNTRY": "USA", "CC_EMPLOYEES": 250, "CC_TAX_PERCENTAGE": 8.875 }
]
```

> Because the API and the ASP.NET Core app run on different origins (for example, `https://localhost:44378` and `https://localhost:44300`), the Web API project must allow cross-origin requests from the Core origin. Add CORS services in the API's `Program.cs` (for example, `builder.Services.AddCors(...)` with `WithOrigins("https://localhost:44300")`) and call `app.UseCors(...)` before `MapControllers()`.

![JSON data from the Web API endpoint](../images/snowflake-code-web-app.png)

## Connecting the Pivot Table to a Snowflake Database Using the Web API Service

This section explains how to connect the Pivot Table component to a Snowflake database by retrieving data from the Web API service created in the previous section. Ensure that the Web API service from the previous section is still running before proceeding.

### Step 1: Set up the ASP.NET Core Pivot Table
1. Set up a basic ASP.NET Core Pivot Table by following the [Getting Started](../getting-started) documentation.
2. Install the Syncfusion ASP.NET Core Tag Helper package by running `dotnet add package Syncfusion.EJ2.AspNet.Core` (the package is registered automatically and the `_ViewImports.cshtml` file is updated to import the Tag Helpers).
3. Register the Syncfusion license key in `Startup.cs` (or `Program.cs` for .NET 6+) as described in the Syncfusion [Getting Started](../getting-started) documentation.
4. Add the required EJ2 client-side references (for example, `ej2.min.js`, `ej2-pivotview.min.js`, and the matching theme CSS) in **~/Views/Shared/_Layout.cshtml** as described in the [Getting Started](../getting-started) documentation.

### Step 2: Configure the Web API URL in the Pivot Table
1. In the **~/Views/Home/Index.cshtml** file, map the Web API URL (`https://localhost:44378/Pivot`) to the Pivot Table using the [url](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property within the [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).
2. Below is the sample code to configure the Pivot Table to fetch data from the Web API:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44378/pivot" expandAll="false" enableSorting="true">
     //Other codes here...
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 3: Define the Pivot Table Report
1. Configure the Pivot Table report in the **~/Views/Home/Index.cshtml** file to structure the data retrieved from the Snowflake database.
2. Add fields to the `rows`, `columns`, `values`, and `filters` properties of [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to define the report structure, specifying how data fields are organized and aggregated in the Pivot Table.
3. Enable the field list by setting the [showFieldList](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true** on the `PivotView` component (not on the data source settings) and including the `FieldList` module in the services section. This allows users to dynamically add or rearrange fields across the columns, rows, and values axes using an interactive user interface. Note: `enableSorting` is a property of the `PivotView` component; the sample above demonstrates the equivalent Tag Helper usage on the data source settings.

Here’s the updated sample code with the report configuration and field list support:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44378/Pivot" expandAll="false" enableSorting="true">
        <e-rows>
            <e-field name="CC_STATE" caption="State"></e-field>
            <e-field name="CC_CITY" caption="City"></e-field>
        </e-rows>
        <e-columns>
            <e-field name="CC_COUNTRY" caption="Country"></e-field>
        </e-columns>
        <e-values>
            <e-field name="CC_COMPANY" caption="Company"></e-field>
            <e-field name="CC_EMPLOYEES" caption="Employees"></e-field>
            <e-field name="CC_TAX_PERCENTAGE" caption="Percentage"></e-field>
        </e-values>
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 4: Run and Verify the Pivot Table
1. Run the ASP.NET Core application.
2. The Pivot Table will display the data fetched from the Snowflake database via the Web API, structured according to the defined report.
3. The resulting Pivot Table will look like this:

![Pivot Table bound with Snowflake database](../images/snowflake-data-binding.png)

## Additional Resources
Explore a complete example of the ASP.NET Core Pivot Table integrated with an ASP.NET Core Web Application to fetch data from a Snowflake database in this [GitHub](https://github.com/SyncfusionExamples/web-bind-Snowflake-database-to-pivot-table) repository.