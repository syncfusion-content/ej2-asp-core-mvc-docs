---
layout: post
title: Microsoft SQL Server Data Binding in ASP.NET Core Pivotview component | Syncfusion
description: Learn how to bind Microsoft SQL Server Database data in the Syncfusion ASP.NET Core Pivotview component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Microsoft SQL Server Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# SQL Server Data Binding

This section describes how to retrieve data from SQL Server database using Microsoft SqlClient and bind it to the Pivot Table via a Web API controller.

## Steps to connect the SQL Server database via Web API application

**1.** Download the ASP.NET Core Web Application from [`this`](https://github.com/SyncfusionExamples/how-to-bind-SQL-database-to-pivot-table) GitHub repository.

**2.** The application named as **PivotController** (server-side) that is downloaded from the above GitHub repository includes the following files.

* **ProductController.cs** file under **Controllers** folder – This helps to do data communication with Pivot Table.
* **Database1.mdf** file under **App_Data** folder – This MDF (Master Database File) file contains example data.

**3.** In the Web API controller (aka, ProductController), **SqlConnection** helps to connect the SQL database (that is, Database1.mdf). Next, using **SqlCommand** and **SqlDataAdapter** you can process the desired SQL query string and retrieve data from the database. The **Fill** method of the DataAdapter is used to populate the SQL data into a **DataTable** as shown in the following code snippet.

```csharp
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace PivotController.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class ProductController : ControllerBase
     {
          private static DataTable FetchSQLResult()
          {
               // Replace with your own connection string.
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

**4.** In the **Get()** method of the **ProductController.cs** file, the **FetchSQLResult** method is used to retrieve the SQL data as a **DataTable**, which is then serialized into JSON using **JsonConvert.SerializeObject()**.

```csharp
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace PivotController.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class ProductController : ControllerBase
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

**5.** Run the web application (aka, PivotController) and it will be hosted within the URL `https://localhost:7139`.

**6.** Finally, the retrieved data from SQL Server which is in the form of JSON can be found in the Web API controller available in the URL link `https://localhost:7139/product`, as shown in the browser page below.

![Hosted Web API URL](images/code-web-app.png)

## Connecting the Pivot Table to the hosted Web API URL

**1.** Download the ASP.NET Core Pivot Table sample from [`this`](https://github.com/SyncfusionExamples/how-to-bind-SQL-database-to-pivot-table) GitHub repository.

**2.** Next, map the hosted Web API's URL link `https://localhost:7139/product` to the Pivot Table component in `app.ts` by using the [`url`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) property.

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:7139/product" expandAll="false" enableSorting="true">
     //Other codes here...
    </e-datasourcesettings>
</ejs-pivotview>

```

**3.** Frame and set the report based on the data retrieved from the SQL database.

```csharp
<ejs-pivotview id="PivotView" height="300" showFieldList="true">
    <e-datasourcesettings Url="https://localhost:7139/product" expandAll="false" enableSorting="true">
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

**4.** Run the sample to get the following result.

![PivotTable bound with SQL database](images/sql-data-binding.png)

> The sample for connecting the Pivot Table to a SQL Server database via an ASP.NET Web application can be found in [`this`](https://github.com/SyncfusionExamples/how-to-bind-SQL-database-to-pivot-table) GitHub repository.
