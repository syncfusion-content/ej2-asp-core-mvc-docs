---
layout: post
title: Bind data from from SQL server to Syncfusion ##Platform_Name## Component and perform CRUD operations
description: retrieve data from SQL server, bind it to Syncfusion ASP.NET Core Grid component using Entity Framework, and perform CRUD operations.
platform: ej2-asp-core-mvc
control: Bind data using entity framework
publishingplatform: ##Platform_Name##
documentation: ug
---

# Bind data from SQL server to Syncfusion ASP.NET Core components

In this topic, we are going to learn how to retrieve data from SQL database using [Entity Framework](https://docs.microsoft.com/en-us/ef/core/) to bind it to the Grid component and perform CRUD operations. 
Entity Framework is an open-source object-relational mapper (O/RM) from Microsoft.  Entity Framework works with many databases. But here, we are going to discuss the step-by-step procedure to create an Entity Framework using the [MS SQL Server](https://en.wikipedia.org/wiki/Microsoft_SQL_Server) database and connect it to the Syncfusion component to perform CRUD operations in a ASP.NET Core Application.

## Prerequisite software

The following software are needed
* Visual Studio 2022 v17.0 or later.
* .NET SDK 6.0 or later.

## Create the database

The first step is to create a Library database and a table named Book to hold a list of books.

* Open SQL Server 2019.
* Now, create a new database named Library.
* Right-click on the created database and select New Query.
* Use the following SQL query to create a table named Book.

```
Create Table Book(
Id BigInt Identity(1,1) Primary Key Not Null,
Name Varchar(200) Not Null,
Author Varchar(100) Not Null,
Quantity int,
Price int Not Null,
Available bit)
```

Now, the Book table design will look like below.

![Created Table](../images/create-table.png)

## Create Blazor Server Application

Open Visual Studio 2019 Preview, select Create a New Project, select Blazor Server App, then click Next.

![Create New Blazor Server Project](../images/create-new-project.png)

In the next window, provide the project name as LibraryManagement and click Next.

![Give Project name as LibraryManagement](../images/project-name.png)

Now, select Target Framework as (.NET 5.0) in the project template and click Create button to create the Blazor Server application.

![Create Project](../images/create-project.png)

## Creating DbContext and model class

Now, we are going to scaffold DbContext and model classes from the existing Library database. To perform scaffolding and work with the SQL Server database in our application, we need to install the following NuGet packages.

Run the following commands in the Package Manager Console.

* **Install-Package Microsoft.EntityFrameworkCore.Tools -Version 5.0.6**: This package creates database context and model classes from the database.
* **Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 5.0.6**: The database provider that allows Entity Framework Core to work with SQL Server.

Once the above packages are installed, we can scaffold DbContext and Model classes. Run the following command in the Package Manager Console under the LibraryManagement project.

```
Scaffold-DbContext “Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

The above scaffolding command contains the following details for creating DbContext and model classes for the existing database and its tables.

* **Connection string**: Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
* **Data provider**: Microsoft.EntityFrameworkCore.SqlServer
* **Output directory**: -OutputDir Models

After running the above command, **LibraryContext.cs** and **Book.cs** files will be created under the **LibraryManagement.Models** folder as follows.

![Created Model class](../images/model-class.png)

We can see that **LibraryContext.cs** file contains the connection string details in the OnConfiguring method.

![Created Connectionstring](../images/connection-string.png)

It is not recommended to have a connection string with sensitive information in the **LibraryContext.cs** file, so we are moving the connection string to the **app settings.json** file.

![Move connection string to appsettings.json](../images/change-connection-string.png)

Now, the **DbContext** must be configured using connection string and registered as scoped service using the **AddDbContext** method in **Startup.cs**.

![Modified appsettings.json](../images/configure-startup.png)

## Creating a Data Access Layer in controller

{% tabs %}
{% highlight c# tabtitle="HomeController.cs" %}

using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Syncfusion.EJ2.Base;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryContext _context;

        public HomeController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
        {
            IEnumerable<Book> DataSource = _context.Books.ToList();
            int count = DataSource.Cast<Book>().Count();
            return Json(new { result = DataSource, count = count });
        }


        public ActionResult Insert([FromBody] ICRUDModel<Book> value)
        {
            _context.Books.Add(value.value);
            _context.SaveChanges();
            return Json(value);
        }

        public IActionResult Update([FromBody] ICRUDModel<Book> value)
        {
            //do stuff
            var ord = value;

            Book val = _context.Books.Where(or => or.Id == ord.value.Id).FirstOrDefault();
            val.Id = ord.value.Id;
            val.Name = ord.value.Name;
            val.Author = ord.value.Author;
            val.Quantity = ord.value.Quantity;
            val.Price = ord.value.Price;
            val.Available = ord.value.Available;
            _context.SaveChanges();
            return Json(value);
        }

        public IActionResult Delete([FromBody] ICRUDModel<Book> value)
        {
            //do stuff
            Book order = _context.Books.Where(c => c.Id == (int)value.key).FirstOrDefault();
            _context.Books.Remove(order);
            _context.SaveChanges();
            return Json(order);
        }

        public class ICRUDModel<T> where T : class
        {
            public int? key { get; set; }

            public T value { get; set; }
        }

    }
}

{% endhighlight %}
{% endtabs %}

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core components are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core components in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper
Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}
    
## Add Style Sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core components. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />

    </head>
{% endhighlight %}
{% endtabs %}

## Add Script Reference
In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
    </head>
{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager
Open `~/Views/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
    <body>
        ....
        ....
        <!-- Syncfusion Script Manager -->
        <ejs-scripts></ejs-scripts>
    </body>
{% endhighlight %}
{% endtabs %}

## Add Syncfusion ASP.NET Core Grid component to an application

In previous steps, we have successfully configured the Syncfusion ASP.NET Core package in the application. Now, we can add the grid component to to your **Index.cshtml** view page which is present under `Views/Home` folder.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<ejs-grid id="Grid">

</ejs-grid>

{% endhighlight %}
{% endtabs %}

## Binding data to ASP.NET Core Grid component using UrlAdaptor

To consume data from the WebApi Controller, we need to add the **DataManager** with **UrlAdaptor**.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<ejs-grid id="Grid">
<e-data-manager url="/Home/UrlDataSource" adaptor="UrlAdaptor" insertUrl="/Home/Insert" removeUrl="/Home/Delete" updateUrl="/Home/Update" crossDomain="true"></e-data-manager>
</ejs-grid>

{% endhighlight %}
{% endtabs %}

Grid columns can be defined by using the [GridColumn](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) component. We are going to create columns using the following code.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<ejs-grid id="Grid" actionBegin="actionBegin" actionComplete="actionComplete"  toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Cancel", "Update" })">
        <e-data-manager url="/Home/UrlDataSource" adaptor="UrlAdaptor" insertUrl="/Home/Insert" removeUrl="/Home/Delete" updateUrl="/Home/Update" crossDomain="true"></e-data-manager>
        <e-grid-editSettings allowDeleting="true" allowEditing="true" allowAdding="true"></e-grid-editSettings>
        <e-grid-columns>
        <e-grid-column field="Id" headerText="Order ID" type="number" textAlign="Right" width="120" isPrimaryKey="true"></e-grid-column>
        <e-grid-column field="Name" headerText="Name" type="string" width="140"></e-grid-column>
        <e-grid-column field="Author" headerText="Author" type="string" textAlign="Right" width="120"></e-grid-column>
        <e-grid-column field="Quantity" headerText="Quantity"  type="number" textAlign="Right" width="140"></e-grid-column>
        <e-grid-column field="Price" headerText="Price"  type="number" textAlign="Right" format="C2" width="120"></e-grid-column>
        <e-grid-column field="Available" headerText="Available" editType="booleanedit" displayAsCheckBox="true" type="boolean" textAlign="Right" width="140"></e-grid-column>
    </e-grid-columns>
 </ejs-grid>

{% endhighlight %}
{% endtabs %}

When you run the application, the `UrlDatasource` method will be called in your controller to load the datasource.

using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Syncfusion.EJ2.Base;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryContext _context;

        public HomeController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
        {
            IEnumerable<Book> DataSource = _context.Books.ToList();
            int count = DataSource.Cast<Book>().Count();
            return Json(new { result = DataSource, count = count });
        }

        ...
    }
}

{% endhighlight %}
{% endtabs %}

The response object from the Web API should contain the properties, `Items` and `Count`, whose values are a collection of entities and the total count of the entities, respectively.

The sample response object should look like this:

```c#

{
    "Items": [{..}, {..}, {..}, ...],
    "Count": 830
}

```