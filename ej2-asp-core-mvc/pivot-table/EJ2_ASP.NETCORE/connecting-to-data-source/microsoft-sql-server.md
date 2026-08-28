---
layout: post
title: SQL Server Data Binding in ASP.NET Core Pivot Table | Syncfusion
description: Learn how to bind Microsoft SQL Server data to the ASP.NET Core Pivot Table using SqlClient in a Web API controller, with a PivotController and Database1.mdf.
platform: ej2-asp-core-mvc
control: Microsoft SQL Server Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# SQL Server Data Binding in ASP.NET Core Pivot Table

This section describes how to retrieve data from SQL Server database using [Microsoft SqlClient](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient?view=dotnet-plat-ext-7.0) and bind it to the Pivot Table via a Web API controller.

## Steps to Connect the SQL Server Database via a Web API Application

### Step 1: Download the Sample Application
Download the ASP.NET Core Web Application from this [GitHub](https://github.com/SyncfusionExamples/aspnetcore-bind-SQL-database-to-pivot-table) repository.

### Step 2: Understand the Application Structure
The **PivotController** sample application downloaded from the GitHub repository above ships with the following files. The `Database1.mdf` file is included in the sample and is automatically attached to LocalDB by Visual Studio when the project is opened.

- **PivotController.cs** file under **Controllers** folder – This helps to do data communication with Pivot Table.
- **Database1.mdf** file under **App_Data** folder – This MDF (Master Database File) file contains example data.

### Step 3: Connect to SQL Server and Retrieve Data
Before proceeding, ensure the SqlClient data provider is available in the project. The [Microsoft SqlClient](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient?view=dotnet-plat-ext-7.0) library is used to connect to a SQL Server database and retrieve data for the Pivot Table. If your project does not already reference it, install the `System.Data.SqlClient` package (or the recommended `Microsoft.Data.SqlClient` provider) from NuGet before adding the code below.

1. **Establish Connection**: Use **SqlConnection** with a valid connection string to connect to the SQL Server database (e.g., **Database1.mdf**).
2. **Query and Fetch Data**: Execute a SQL query (e.g., `SELECT * FROM table1`) using **SqlCommand** to retrieve data for the Pivot Table.
3. **Structure the Data**: Use the **Fill** method of **SqlDataAdapter** to populate query results into a **DataTable** for JSON serialization.

```csharp
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace PivotController.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class PivotController : ControllerBase
     {
          private static DataTable FetchSQLResult()
          {
               string conSTR = @"<Enter your valid connection string here>";
               string xquery = "SELECT * FROM table1";
               SqlConnection sqlConnection = new(conSTR);
               sqlConnection.Open();
               SqlCommand cmd = new(xquery, sqlConnection);
               SqlDataAdapter dataAdapter = new(cmd);
               DataTable dataTable = new();
               dataAdapter.Fill(dataTable);
               return dataTable;
          }
     }
}

```

> Replace `<Enter your valid connection string here>` with the actual connection string for your SQL Server database. For the bundled `Database1.mdf` under `App_Data`, use a LocalDB connection string such as `Server=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30;`, which attaches the file from the project's `App_Data` folder. For a remote SQL Server instance, supply the corresponding `Server`, `Database`, and authentication values.

### Step 4: Serialize Data to JSON
In the **PivotController.cs** file, define a **Get** method that calls **FetchSQLResult** to retrieve data from the SQL Server database as a **DataTable**. Then, use **JsonConvert.SerializeObject** from the **Newtonsoft.Json** library to convert the **DataTable** into JSON format. This JSON data will be consumed by the Pivot Table component.

> Ensure the `Newtonsoft.Json` NuGet package (version 13.x or later) is installed in your project before using `JsonConvert`. The `Get` method serializes the `DataTable` into a JSON string before ASP.NET Core's pipeline returns it as the response body.

```csharp
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace PivotController.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class PivotController : ControllerBase
     {
          [HttpGet(Name = "GetSQLResult")]
          public object Get()
          {
               return JsonConvert.SerializeObject(FetchSQLResult());
          }

          private static DataTable FetchSQLResult()
          {
               string conSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory
                    + @"\App_Data\Database1.mdf;Integrated Security=True";
               string xquery = "SELECT * FROM table1";
               SqlConnection sqlConnection = new(conSTR);
               sqlConnection.Open();
               SqlCommand cmd = new(xquery, sqlConnection);
               SqlDataAdapter dataAdapter = new(cmd);
               DataTable dataTable = new();
               dataAdapter.Fill(dataTable);
               return dataTable;
          }
     }
}

```

### Step 5: Run the Web API Application
1. In Visual Studio, set **PivotController** as the startup project and press <kbd>F5</kbd> (or run `dotnet run` from the project folder). The actual listening port is read from `launchSettings.json`; both HTTP and HTTPS endpoints are printed in the console.
2. The application is typically hosted at `https://localhost:7139/` (the port number may vary depending on your configuration). Note the exact URL printed by the runtime so you can reference it from the ASP.NET Core project.

### Step 6: Access the JSON Data
1. Access the Web API endpoint at `https://localhost:7139/pivot` to view the JSON data retrieved from the SQL Server database.
2. The browser displays the JSON data, as shown in the image below, ready for use by the Pivot Table. A sample response has the following shape:

```json
[
  { "Country": "USA", "State": "California", "Product": "Laptop", "Quantity": 2, "Amount": 2400.00 },
  { "Country": "USA", "State": "Texas",     "Product": "Chair",  "Quantity": 5, "Amount": 750.00 }
]
```

> Because the API and the ASP.NET Core app run on different origins (for example, `https://localhost:7139` and `https://localhost:44300`), the Web API project must allow cross-origin requests from the Core origin. Add CORS services in the API's `Program.cs` (for example, `builder.Services.AddCors(...)` with `WithOrigins("https://localhost:44300")`) and call `app.UseCors(...)` before `MapControllers()`.

![Hosted Web API URL](../images/code-web-app.png)

## Connecting the Pivot Table to the Hosted Web API URL

This section explains how to connect the Pivot Table component to a SQL Server database by retrieving data from the Web API service created in the previous section. Ensure that the Web API application from the previous section is still running before proceeding.

### Step 1: Set up the ASP.NET Core Pivot Table
1. Download the ASP.NET Core Pivot Table sample from the [GitHub](https://github.com/SyncfusionExamples/aspnetcore-bind-SQL-database-to-pivot-table) repository.
2. Install the Syncfusion ASP.NET Core Tag Helper package by running `dotnet add package Syncfusion.EJ2.AspNet.Core` (the package is registered automatically and the `_ViewImports.cshtml` file is updated to import the Tag Helpers).
3. Register the Syncfusion license key in `Startup.cs` (or `Program.cs` for .NET 6+) as described in the Syncfusion [Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/getting-started) documentation.
4. Add the required EJ2 client-side references (for example, `ej2.min.js`, `ej2-pivotview.min.js`, and the matching theme CSS) in **~/Views/Shared/_Layout.cshtml** as described in the [Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/getting-started) documentation.

### Step 2: Configure the Web API URL in the Pivot Table
1. In the **~/Views/Home/Index.cshtml** file, configure the Pivot Table to use the hosted Web API URL (`https://localhost:7139/pivot`) by setting the [url](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property within the [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) object.
2. Below is the sample code to configure the Pivot Table to fetch data from the Web API:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:7139/pivot" expandAll="false" enableSorting="true">
     //Other codes here...
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 3: Define the Pivot Table Report
1. Configure the Pivot Table report in the **~/Views/Home/Index.cshtml** file to structure the data retrieved from the SQL Server database.
2. Add fields to the `rows`, `columns`, `values`, and `filters` properties of [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to define how data fields are organized and aggregated in the Pivot Table.
3. Enable the field list by setting the [showFieldList](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true** on the `PivotView` component (not on the data source settings) and including the `FieldList` module in the services section. This allows users to dynamically add or rearrange fields across the columns, rows, and values axes using an interactive user interface. Note: `enableSorting` is a property of the `PivotView` component; the sample above demonstrates the equivalent Tag Helper usage on the data source settings.

Here’s the updated sample code with the report configuration and field list support:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:7139/pivot" expandAll="false" enableSorting="true">
        <e-formatsettings>
            <e-field name="Amount" format="C0"></e-field>
        </e-formatsettings>
        <e-rows>
            <e-field name="Country"></e-field>
            <e-field name="State"></e-field>
        </e-rows>
        <e-columns>
            <e-field name="Product" caption="Product"></e-field>
        </e-columns>
        <e-values>
            <e-field name="Quantity"></e-field>
            <e-field name="Amount" caption="Sold Amount"></e-field>
        </e-values>
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 4: Run and Verify the Pivot Table
1. Run the ASP.NET Core application.
2. The Pivot Table will display the data fetched from the SQL Server database via the Web API, structured according to the defined report.
3. The resulting Pivot Table will look like this:

![Pivot Table bound with SQL database](../images/sql-data-binding.png)

## Additional Resources
Explore a complete example of the ASP.NET Core Pivot Table integrated with an ASP.NET Core Web Application to fetch data from a SQL Server database in the [GitHub](https://github.com/SyncfusionExamples/aspnetcore-bind-SQL-database-to-pivot-table) repository.