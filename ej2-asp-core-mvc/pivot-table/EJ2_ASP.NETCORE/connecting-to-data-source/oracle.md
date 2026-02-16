---
layout: post
title: "Oracle Data Binding in ASP.NET Core Pivotview component | Syncfusion"
description: "Learn how to bind data from a Oracle database in the Syncfusion ASP.NET Core Pivot Table of Syncfusion Essential JS 2 and more."
platform: ej2-asp-core-mvc
documentation: ug
---

# Oracle in EJ2 ASP.NET Core Pivotview Component

This section describes how to retrieve data from Oracle database using [Oracle Managed Data Access](https://www.nuget.org/packages/Oracle.ManagedDataAccess) and bind it to the Pivot Table via a Web API controller.

## Creating a Web API Service to Fetch Oracle Data

Follow these steps to create a Web API service that retrieves data from an Oracle database and prepares it for the Pivot Table.

### Step 1: Create an ASP.NET Core Web Application
1. Open Visual Studio and create a new **ASP.NET Core Web App** project named **MyWebService**.
2. Follow the official [Microsoft documentation](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022) for detailed instructions on creating an ASP.NET Core Web application.

![Creating an ASP.NET Core Web App project](../images/azure-asp-core-web-service-create.png)

### Step 2: Install the Oracle NuGet Package
To enable Oracle database connectivity:
1. Open the **NuGet Package Manager** in your project solution and search for [Oracle.ManagedDataAccess.Core](https://www.nuget.org/packages/Oracle.ManagedDataAccess.Core/).
2. Install the [Oracle.ManagedDataAccess.Core](https://www.nuget.org/packages/Oracle.ManagedDataAccess.Core/) package to add Oracle support.

![Installing the Oracle.ManagedDataAccess.Core NuGet package](../images/oracle-data-nuget-package-install.png)

### Step 3: Create a Web API Controller
1. Under the **Controllers** folder, create a new Web API controller named **PivotController.cs**.
2. This controller facilitates data communication between the Oracle database and the Pivot Table.

### Step 4: Connect to Oracle and Retrieve Data
In the **PivotController.cs** file, use the [Oracle Managed Data Access](https://www.nuget.org/packages/Oracle.ManagedDataAccess) library to connect to an Oracle database and retrieve data for the Pivot Table.

1. **Establish Connection**: Use **OracleConnection** with a valid connection string (e.g., `Data Source=localhost;User Id=myuser;Password=mypassword;`) to connect to the Oracle database.
2. **Query and Fetch Data**: Execute a SQL query (e.g., `SELECT * FROM EMPLOYEES`) using **OracleCommand** to retrieve data for the Pivot Table.
3. **Structure the Data**: Use **OracleDataAdapter**'s **Fill** method to populate query results into a **DataTable** for JSON serialization.

```csharp
     using Microsoft.AspNetCore.Core;
     using Newtonsoft.Json;
     using Oracle.ManagedDataAccess.Client;
     using System.Data;

     namespace MyWebService.Controllers
     {
          [ApiController]
          [Route("[controller]")]
          public class PivotController : ControllerBase
          {
               private static DataTable FetchOracleResult()
               {
                    // Replace with your own connection string.
                    string connectionString = "<Enter your valid connection string here>";
                    OracleConnection oracleConnection = new OracleConnection(connectionString);
                    oracleConnection.Open();
                    OracleCommand command = new OracleCommand("SELECT * FROM EMPLOYEES", oracleConnection);
                    OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    oracleConnection.Close();
                    return dataTable;
               }
          }
     }

```

### Step 5: Serialize Data to JSON
In the **PivotController.cs** file, define a **Get** method that calls **FetchOracleResult** to retrieve data from the Oracle database as a **DataTable**. Then, use **JsonConvert.SerializeObject** from the **Newtonsoft.Json** library to convert the **DataTable** into JSON format. This JSON data will be used by the Pivot Table component.

> Ensure the **Newtonsoft.Json** NuGet package is installed in your project to use **JsonConvert**.

```csharp
     using Microsoft.AspNetCore.Core;
     using Newtonsoft.Json;
     using Oracle.ManagedDataAccess.Client;
     using System.Data;

     namespace MyWebService.Controllers
     {
          [ApiController]
          [Route("[controller]")]
          public class PivotController : ControllerBase
          {
               [HttpGet(Name = "GetOracleResult")]
               public object Get()
               {
                    return JsonConvert.SerializeObject(FetchOracleResult());
               }

               private static DataTable FetchOracleResult()
               {
                    // Replace with your own connection string.
                    string connectionString = "<Enter your valid connection string here>";
                    OracleConnection oracleConnection = new OracleConnection(connectionString);
                    oracleConnection.Open();
                    OracleCommand command = new OracleCommand("SELECT * FROM EMPLOYEES", oracleConnection);
                    OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    oracleConnection.Close();
                    return dataTable;
               }
          }
     }

```

### Step 6: Run the Web API Service
1. Build and run the application.
2. The application will be hosted at `https://localhost:44346/` (the port number may vary based on your configuration).

### Step 7: Access the JSON Data
1. Access the Web API endpoint at `https://localhost:44346/Pivot` to view the JSON data retrieved from the Oracle database.
2. The browser will display the JSON data, as shown below.

![JSON data from the Web API endpoint](../images/oracle-code-web-app.png)

## Connecting the Pivot Table to an Oracle Database Using the Web API Service

This section explains how to connect the Pivot Table component to an Oracle database by retrieving data from the Web API service created in the previous section.

### Step 1: Create a Pivot Table in ASP.NET Core
1. Set up a basic ASP.NET Core Pivot Table by following the [Getting Started](../getting-started) documentation.
2. Ensure your ASP.NET Core project is configured with the necessary EJ2 Pivot Table dependencies.

### Step 2: Configure the Web API URL in the Pivot Table
1. In the **~/Views/Home/Index.cshtml** file, map the Web API URL (`https://localhost:44346/Pivot`) to the Pivot Table using the [url](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property within the [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).
2. Below is the sample code to configure the Pivot Table to fetch data from the Web API:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44346/pivot" expandAll="false" enableSorting="true">
     //Other codes here...
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 3: Define the Pivot Table Report
1. Configure the Pivot Table report in the **~/Views/Home/Index.cshtml** file to structure the data retrieved from the Oracle database.
2. Add fields to the `rows`, `columns`, `values`, and `filters` properties of [e-datasourcesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to define the report structure, specifying how data fields are organized and aggregated in the Pivot Table.
3. Enable the field list by setting the [showFieldList](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true** and including the `FieldList` module in the services section. This allows users to dynamically add or rearrange fields across the columns, rows, and values axes using an interactive user interface.

Here’s the updated sample code with the report configuration and field list support:

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:44346/Pivot" expandAll="false" enableSorting="true">
        <e-rows>
            <e-field name="JOB" caption="Job"></e-field>
            <e-field name="SALARY" caption="Salary"></e-field>
        </e-rows>
        <e-columns>
            <e-field name="DEPARTMENT_ID" caption="Department ID"></e-field>
            <e-field name="EMPLOYEE_NAME" caption="Employee Name"></e-field>
        </e-columns>
        <e-values>
            <e-field name="EMPLOYEE_ID" caption="Employee ID"></e-field>
            <e-field name="CC_EMPLOYEES" caption="Employees"></e-field>
            <e-field name="CC_TAX_PERCENTAGE" caption="Percentage"></e-field>
        </e-values>
    </e-datasourcesettings>
</ejs-pivotview>

```

### Step 4: Run and Verify the Pivot Table
1. Run the ASP.NET Core application.
2. The Pivot Table will display the data fetched from the Oracle database via the Web API, structured according to the defined report.
3. The resulting Pivot Table will look like this:

![Pivot Table bound with Oracle database](../images/oracle-data-binding.png)

### Additional Resources
Explore a complete example of the ASP.NET Core Pivot Table integrated with an ASP.NET Core Web Application to fetch data from an Oracle database in this [GitHub](https://github.com/SyncfusionExamples/how-to-bind-Oracle-database-to-pivot-table) repository.