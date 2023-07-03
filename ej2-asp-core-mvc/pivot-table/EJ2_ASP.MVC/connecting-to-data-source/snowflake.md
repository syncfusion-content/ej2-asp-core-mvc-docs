---
layout: post
title: "Snowflake Data Binding in ASP.NET MVC Pivotview component | Syncfusion"
description: "Learn how to bind data from a Snowflake database in the Syncfusion ASP.NET MVC Pivot Table of Syncfusion Essential JS 2 and more."
platform: ej2-asp-core-mvc
documentation: ug
---

# Snowflake in EJ2 ASP.NET MVC Pivotview control

This section describes how to retrieve data from a Snowflake database using [Snowflake Data](https://www.nuget.org/packages/Snowflake.Data/#readme-body-tab) and bind it to the Pivot Table via a Web API controller.

## Create a Web API service to fetch Snowflake data

**1.** Open Visual Studio and create an ASP.NET Core Web App project type, naming it **MyWebService**. To create an ASP.NET Core Web application, follow the document [link](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022).

![Create ASP.NET Core Web App project](../images/azure-asp-core-web-service-create.png)

**2.** To connect a Snowflake Server using the **Snowflake.Data.Client** in our application, we need to install the [Snowflake.Data](https://www.nuget.org/packages/Snowflake.Data/) NuGet package. To do so, open the NuGet package manager of the project solution, search for the package **Snowflake.Data** and install it.

![Add the NuGet package "Snowflake.Data" to the project](../images/snowflake-data-nuget-package-install.png)

**3.** Create a Web API controller (aka, PivotController.cs) file under **Controllers** folder that helps to establish data communication with the Pivot Table.

**4.** In the Web API controller (aka, PivotController), **SnowflakeDbConnection** helps to connect the Snowflake database. Next, using **SnowflakeDbDataAdapter** you can process the desired Snowflake query string and retrieve data from the database. The **Fill** method of the **SnowflakeDbDataAdapter** is used to populate the retrieved data into a **DataTable** as shown in the following code snippet.

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

**5.** In the **Get()** method of the **PivotController.cs** file, the **FetchSnowflakeResult** method is used to retrieve the Snowflake data as a **DataTable**, which is then serialized into JSON string using **JsonConvert.SerializeObject()**.

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

**6.** Run the application and it will be hosted within the URL `https://localhost:44378/`.

**7.** Finally, the retrieved data from Snowflake database which is in the form of JSON can be found in the Web API controller available in the URL link `https://localhost:44378/Pivot`, as shown in the browser page below.

![Hosted Web API URL](../images/snowflake-code-web-app.png)

## Connecting the Pivot Table to a Snowflake database using the Web API service

**1.** Create a simple ASP.NET MVC Pivot Table by following the **"Getting Started"** documentation [link](../getting-started).

**2.** Map the hosted Web API's URL link `https://localhost:44378/Pivot` to the Pivot Table component in **~/Views/Home/Index.cshtml**  by using the [Url](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) under [PivotViewDataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) property.

```csharp
@Html.EJS().PivotView("PivotView").Height("300").DataSourceSettings(
     dataSource => dataSource.Url("https://localhost:44378/pivot"
     )
     //Other codes here...
     ).Render()

```

**3.** Frame and set the report based on the data retrieved from the Snowflake database.

```csharp
@Html.EJS().PivotView("PivotView").Height("300").DataSourceSettings(
        dataSource => dataSource.Url("https://localhost:44378/Pivot"
        ).ExpandAll(false).EnableSorting(true)
    .Rows(rows =>
    {
        rows.Name("CC_STATE").Caption("State").Add(); rows.Name("CC_CITY").Caption("City").Add();
    }).Columns(columns =>
    {
        columns.Name("CC_COUNTRY").Caption("Country").Add();
    }).Values(values =>
    {
        values.Name("CC_COMPANY").Caption("Company").Add(); values.Name("CC_EMPLOYEES").Caption("Employees").Add();
        values.Name("CC_TAX_PERCENTAGE").Caption("Percentage").Add();
    })).ShowFieldList(true).Render()

```

When you run the sample, the resulting pivot table will look like this:

![PivotTable bound with Snowflake database](../images/snowflake-data-binding.png)

> Explore our ASP.NET MVC Pivot Table sample and ASP.NET Core Web Application to extract data from a Snowflake database and bind to the Pivot Table in [this](https://github.com/SyncfusionExamples/how-to-bind-Snowflake-database-to-pivot-table) GitHub repository.