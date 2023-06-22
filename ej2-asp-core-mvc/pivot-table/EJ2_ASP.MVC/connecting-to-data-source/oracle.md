---
layout: post
title: Oracle Data Binding in MVC Pivotview component | Syncfusion
description: Learn how to bind Oracle Database data in the Syncfusion MVC Pivotview component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Oracle Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Oracle Data Binding

This section describes how to retrieve data from Oracle database using [Oracle Managed Data Access](https://www.nuget.org/packages/Oracle.ManagedDataAccess) library and bind it to the Pivot Table via a Web API controller.

## Steps to connect the Oracle database via Web API application

**1.** Download the ASP.NET Core Web Application from [this](https://github.com/SyncfusionExamples/how-to-bind-Oracle-database-to-pivot-table) GitHub repository.

**2.** The application named as **PivotController** (server-side) that is downloaded from the above GitHub repository includes the **PivotController.cs** file under **Controllers** folder, which is helps to do data communication with Pivot Table.

**3.** In the Web API controller (aka, PivotController), **OracleConnection** helps to connect the Oracle database. Next, using **OracleCommand** and **OracleDataAdapter** you can process the desired Oracle query string and retrieve data from the database. The **Fill** method of the **OracleDataAdapter** is used to populate the retrieved data into a **DataTable** as shown in the following code snippet.

```csharp
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PivotController.Controllers
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

**4.** In the **Get()** method of the **PivotController.cs** file, the **FetchOracleResult()** method is used to retrieve the Oracle data, which is then serialized into JSON using **JsonConvert.SerializeObject()**.

```csharp
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PivotController.Controllers
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

**5.** Run the web application (aka, PivotController) and it will be hosted within the URL `https://localhost:7029`.

**6.** Finally, the retrieved data from Oracle database which is in the form of JSON can be found in the Web API controller available in the URL link `https://localhost:7029/pivot`, as shown in the browser page below.

![Hosted Web API URL](../images/oracle-code-web-app.png)

## Connecting the Pivot Table to the hosted Web API URL

**1.** Download the ASP.NET MVC Pivot Table sample from [this](https://github.com/SyncfusionExamples/how-to-bind-Oracle-database-to-pivot-table) GitHub repository.

**2.** Next, map the hosted Web API's URL link `https://localhost:7029/pivot` to the Pivot Table component in **index.cshtml** by using the [Url](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) under [PivotViewDataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) property.

```csharp
@Html.EJS().PivotView("PivotView").Height("300").DataSourceSettings(
     dataSource => dataSource.Url("https://localhost:7029/pivot"
     )
     //Other codes here...
     ).Render()

```

**3.** Frame and set the report based on the data retrieved from the Oracle database.

```csharp
@Html.EJS().PivotView("PivotView").Height("300").DataSourceSettings(
        dataSource => dataSource.Url("https://localhost:7029/Pivot"
        ).ExpandAll(false).EnableSorting(true)
    .Rows(rows =>
    {
        rows.Name("JOB").Caption("Job").Add(); rows.Name("SALARY").Caption("Salary").Add();
    }).Columns(columns =>
    {
        columns.Name("DEPARTMENT_ID").Caption("Department ID").Add(); columns.Name("EMPLOYEE_NAME").Caption("Employee Name").Add();
    }).Values(values =>
    {
        values.Name("EMPLOYEE_ID").Caption("Employee ID").Add(); values.Name("CC_EMPLOYEES").Caption("Employees").Add();
        values.Name("CC_TAX_PERCENTAGE").Caption("Percentage").Add();
    })).ShowFieldList(true).Render()

```

**4.** Run the sample to get the following result.

![PivotTable bound with Oracle database](../images/oracle-data-binding.png)