---
layout: post
title: "Oracle Data Binding in MVC Pivotview component | Syncfusion"
description: "Learn how to bind data from a Oracle database in the Syncfusion ASP.NET MVC Pivot Table of Syncfusion Essential JS 2 and more."
platform: ej2-asp-core-mvc
documentation: ug
---

# Oracle in EJ2 ASP.NET MVC Pivotview Component

This section describes how to retrieve data from Oracle database using [Oracle Managed Data Access](https://www.nuget.org/packages/Oracle.ManagedDataAccess) and bind it to the Pivot Table via a Web API controller.

## Create a Web API service to fetch Oracle data

**1.** Open Visual Studio and create an ASP.NET Core Web App project type, naming it **MyWebService**. To create an ASP.NET Core Web application, follow the document [link](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022).

![Create ASP.NET Core Web App project](../images/azure-asp-core-web-service-create.png)

**2.** To connect a Oracle Server using the **Oracle.ManagedDataAccess.Client** in our application, we need to install the [Oracle.ManagedDataAccess.Core](https://www.nuget.org/packages/Oracle.ManagedDataAccess.Core/) NuGet package. To do so, open the NuGet package manager of the project solution, search for the package **Oracle.ManagedDataAccess.Core** and install it.

![Add the NuGet package "Oracle.ManagedDataAccess.Core" to the project](../images/oracle-data-nuget-package-install.png)

**3.** Create a Web API controller (aka, PivotController.cs) file under **Controllers** folder that helps to establish data communication with the Pivot Table.

**4.** In the Web API controller (aka, PivotController), **OracleConnection** helps to connect the Oracle database. Next, using **OracleCommand** and **OracleDataAdapter** you can process the desired Oracle query string and retrieve data from the database. The **Fill** method of the **OracleDataAdapter** is used to populate the retrieved data into a **DataTable** as shown in the following code snippet.

```csharp
     using Microsoft.AspNetCore.Mvc;
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

**5.** In the **Get()** method of the **PivotController.cs** file, the **FetchOracleResult()** method is used to retrieve the Oracle data, which is then serialized into JSON using **JsonConvert.SerializeObject()**.

```csharp
     using Microsoft.AspNetCore.Mvc;
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

**6.** Run the application and it will be hosted within the URL `https://localhost:44346/`.

**7.** Finally, the retrieved data from Oracle database which is in the form of JSON can be found in the Web API controller available in the URL link `https://localhost:44346/Pivot`, as shown in the browser page below.

![Hosted Web API URL](../images/oracle-code-web-app.png)

## Connecting the Pivot Table to a Oracle database using the Web API service

**1.** Create a simple ASP.NET MVC Pivot Table by following the **"Getting Started"** documentation [link](../getting-started).

**2.** Map the hosted Web API's URL link `https://localhost:44346/pivot` to the Pivot Table component in **~/Views/Home/Index.cshtml** by using the [Url](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) under [PivotViewDataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) property.

```csharp
@Html.EJS().PivotView("PivotView").Height("300").DataSourceSettings(
     dataSource => dataSource.Url("https://localhost:44346/pivot"
     )
     //Other codes here...
     ).Render()

```

**3.** Frame and set the report based on the data retrieved from the Oracle database.

```csharp
@Html.EJS().PivotView("PivotView").Height("300").DataSourceSettings(
        dataSource => dataSource.Url("https://localhost:44346/Pivot"
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

When you run the sample, the resulting pivot table will look like this:

![PivotTable bound with Oracle database](../images/oracle-data-binding.png)

> Explore our ASP.NET MVC Pivot Table sample and ASP.NET Core Web Application to extract data from a Oracle database and bind to the Pivot Table in [this](https://github.com/SyncfusionExamples/how-to-bind-Oracle-database-to-pivot-table) GitHub repository.