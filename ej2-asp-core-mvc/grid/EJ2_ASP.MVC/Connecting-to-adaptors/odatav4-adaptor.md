---
layout: post
title: Bind data & perform CRUD with ODataV4Adaptor in Syncfusion Grid
description: Learn here all about Bind data and perform CRUD action with ODataV4Adaptor in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: grid
keywords: Adaptors, ODataV4Adaptor, url method adaptor, remotedata 
publishingplatform: ##Platform_Name##
documentation: ug
---

# ODataV4Adaptor in Syncfusion ASP.NET MVC Grid Control

The `ODataV4Adaptor` in Syncfusion ASP.NET MVC Grid allows seamless integration with OData v4 services, enabling efficient data fetching and manipulation. This guide provides step-by-step instructions for binding data and performing CRUD (Create, Read, Update, Delete) operations using the `ODataV4Adaptor`.

## Creating an OData Service

To configure a server with Syncfusion ASP.NET MVC Grid, you need to follow the below steps:

**1. Project Creation:**

1. Open **Visual Studio**.
2. Select **Create a new project** → Choose **ASP.NET Web Application (.NET Framework)**.
3. Name the project **ODataV4Adaptor** and select **MVC** as the project template.
4. Ensure that the **Web API** option is selected (this is crucial for enabling OData).

For detailned information, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app).

**2. Install NuGet Packages:**

Using the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), install the `Microsoft.AspNet.OData` NuGet package for OData support and `Newtonsoft.Json` for JSON serialization support.

**3. Model Class Creation:**

Create a model class named `OrdersDetails.cs` inside the **Models** folder.

{% tabs %}
{% highlight cs tabtitle="OrdersDetails.cs" %}

 namespace ODataV4Adaptor_MVC.Models
{
  public class OrdersDetails
  {
      public static List<OrdersDetails> order = new List<OrdersDetails>();
      public OrdersDetails()
      {

      }
      public OrdersDetails(
      int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified,
      DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry,
      DateTime ShippedDate, string ShipAddress)
      {
          this.OrderID = OrderID;
          this.CustomerID = CustomerId;
          this.EmployeeID = EmployeeId;
          this.Freight = Freight;
          this.ShipCity = ShipCity;
          this.Verified = Verified;
          this.OrderDate = OrderDate;
          this.ShipName = ShipName;
          this.ShipCountry = ShipCountry;
          this.ShippedDate = ShippedDate;
          this.ShipAddress = ShipAddress;
      }

      public static List<OrdersDetails> GetAllRecords()
      {
          if (order.Count() == 0)
          {
              int code = 10000;
              for (int i = 1; i < 10; i++)
              {
                  order.Add(new OrdersDetails(code + 1, "ALFKI", i + 0, 2.3 * i, false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                  order.Add(new OrdersDetails(code + 2, "ANATR", i + 2, 3.3 * i, true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                  order.Add(new OrdersDetails(code + 3, "ANTON", i + 1, 4.3 * i, true, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                  order.Add(new OrdersDetails(code + 4, "BLONP", i + 3, 5.3 * i, false, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                  order.Add(new OrdersDetails(code + 5, "BOLID", i + 4, 6.3 * i, true, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                  code += 5;
              }
          }
          return order;
      }
      [Key]
      public int OrderID { get; set; }
      public string CustomerID { get; set; }
      public int? EmployeeID { get; set; }
      public double Freight { get; set; }
      public string ShipCity { get; set; }
      public bool Verified { get; set; }
      public DateTime OrderDate { get; set; }
      public string ShipName { get; set; }
      public string ShipCountry { get; set; }
      public DateTime ShippedDate { get; set; }
      public string ShipAddress { get; set; }
  }
}
{% endhighlight %}
{% endtabs %}

**4. Configure OData Routing in Web API:**

Modify `WebApiConfig.cs` in the `App_Start` folder to enable OData routing.

1. Define the OData Model: Use `ODataConventionModelBuilder` to construct the Entity Data Model (EDM):

```code
        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<OrdersDetails>("Orders");  // Define OData Entity
            return builder.GetEdmModel();
        }
```

2. Register the OData routes:

```cs
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.OData.Edm;
using ODataV4Adaptor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace ODataV4Adaptor.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable OData
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "odata",
                model: GetEdmModel()
            );

            // Enable Query Support
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);


            // Web API routes
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = System.Web.Http.RouteParameter.Optional }
            );

            // Configure JSON formatting
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        }
        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<OrdersDetails>("Orders");  // Define OData Entity
            return builder.GetEdmModel();
        }
    }
}
```

**5. Add Controllers**

Finally, add controllers to expose the OData endpoints. Here’s an example:

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

using System.Linq;
using Microsoft.AspNet.OData;
using System.Web.Http;
using ODataV4Adaptor_MVC.Models;

namespace ODataV4Adaptor_MVC.Controllers
{
   
public class OrdersController : ODataController
{
    /// <summary>
    /// Retrieves all orders.
    /// </summary>
    /// <returns>The collection of orders.</returns>
    [EnableQuery]
    public IHttpActionResult Get()
    {
        var data = OrdersDetails.GetAllRecords().AsQueryable();
        return Ok(data);
    }
}
}

{% endhighlight %}
{% endtabs %}

**6. Enable OData in Global.asax.cs**

Modify Global.asax.cs to register OData routes during application startup:

```code
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
```

**7. Run the Application**

* Ensure the project is built successfully (Build → Rebuild Solution).
* Run the project (Ctrl + F5).
* Verify the OData service by opening a browser and navigating to:
    ```bash
    http://localhost:<port>/odata/Orders
    ```
* If the service is configured correctly, it should return JSON data.

## Connecting Syncfusion ASP.NET MVC Grid to an API service

To integrate the Syncfusion Grid control into your ASP.NET MVC project using Visual Studio, follow these steps:

**Step 1:** Install ASP.NET MVC package in the application:

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

**Step 2:** Add Syncfusion ASP.NET MVC namespace

Add `Syncfusion.EJ2` namespace reference in `Web.config` under `Views` folder.

```cs
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

**Step 3:** Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
    <!-- Include the necessary CSS files to style the Syncfusion ASP.NET MVC component: -->
        <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-richtexteditor/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-notifications/styles/bootstrap5.css" rel="stylesheet" />
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/styles/bootstrap5.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="https://cdn.syncfusion.com/ej2/syncfusion-helper.js" type="text/javascript"></script>
</head>

{% endhighlight %}
{% endtabs %}

**Step 4:** Register Syncfusion Script Manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

**Step 5:** Add ASP.NET MVC Grid control

Now, add the Syncfusion ASP.NET MVC Grid tag helper in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
@using Syncfusion.EJ2

@Html.EJS().Grid("Grid").DataSource(dm => dm.Url("https://localhost:xxxx/odata/orders").Adaptor("ODataV4Adaptor")).AllowFiltering().AllowSorting().AllowPaging().EditSettings(edit => edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal)).Toolbar(new List<string>
	() { "Add", "Edit", "Delete", "Update", "Cancel", "Search" }).Columns(col =>
	{
		col.Field("OrderID").HeaderText("Order ID").Width("150").IsPrimaryKey(true).Add();
		col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
		col.Field("EmployeeID").HeaderText("Employee ID").Width("150").Add();
		col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
	}).Render()
{% endhighlight %}
{% endtabs %}

> Replace https://localhost:xxxx/odata/Orders with the actual URL of your OData endpoint that provides the data in a consumable format (e.g., JSON).

**Step 7:** Run the Project

Now, run the project to see the Syncfusion Grid connected to the OData service in action.

## Handling Searching Operation

To enable search operations in your web application using OData, you first need to configure the OData support in your service collection. This involves adding the `Filter` method within the OData setup, allowing you to filter data based on specified criteria. Once enabled, clients can utilize the **$filter** query option in their requests to search for specific data entries.

![ODataV4Adaptor searching]()

{% tabs %}
{% highlight cs tabtitle="WebApiConfig.cs" %}
....
    // Enable OData
    config.MapODataServiceRoute(
        routeName: "ODataRoute",
        routePrefix: "odata",
        model: GetEdmModel()
    );

    // Enable Query Support
    config.Count().Filter(); // Handles searching operation

    ...
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/odata/orders").Adaptor("ODataV4Adaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("150").IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("150").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
}).Toolbar(new List<string>() { "Search" }).Render()

{% endhighlight %}
{% endtabs %}

![Searching query](../images/odatav4-adaptor-searching.png)

## Handling Filtering Operation

To enable filter operations in your web application using OData, you first need to configure the OData support in your service collection. This involves adding the Filter method within the OData setup, allowing you to filter data based on specified criteria. Once enabled, clients can utilize the $filter query option in your requests to filter for specific data entries.

{% tabs %}
{% highlight cs tabtitle="WebApiConfig.cs" %}
....
    // Enable OData
    config.MapODataServiceRoute(
        routeName: "ODataRoute",
        routePrefix: "odata",
        model: GetEdmModel()
    );

    // Enable Query Support
    config.Count().Filter(); // Handles filtering  operation

....
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/odata/orders").Adaptor("ODataV4Adaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("150").IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("150").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
}).AllowFiltering().Render()

{% endhighlight %}
{% endtabs %}

Single column filtering
![Filtering query](../images/odatav4-adaptor-filtering.png)
Multi column filtering
![Filtering query](../images/odatav4-adaptor-multi-column-filtering.png)

## Handling Sorting Operation

To enable sorting operations in your web application using OData, you first need to configure the OData support in your service collection. This involves adding the `OrderBy` method within the OData setup, allowing you to sort data based on specified criteria. Once enabled, clients can utilize the **$orderby** query option in their requests to sort data entries according to desired attributes.

{% tabs %}
{% highlight cs tabtitle="WebApiConfig.cs" %}
....
    // Enable OData
    config.MapODataServiceRoute(
        routeName: "ODataRoute",
        routePrefix: "odata",
        model: GetEdmModel()
    );

    // Enable Query Support
    config.Count().OrderBy(); // Handles sorting  operation

....
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/odata/orders").Adaptor("ODataV4Adaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("150").IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("150").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
}).AllowSorting().Render()

{% endhighlight %}
{% endtabs %}

*Single column sorting*

![Single column sorting query](../images/odatav4-adaptor-sorting.png)

*Multi column sorting*

![Multi column sorting query](../images/odatav4-adaptor-multi-column-sorting.png)

## Handling Paging Operation

To implement paging operations in your web application using OData, you can utilize the `SetMaxTop` method within your OData setup to limit the maximum number of records that can be returned per request. While you configure the maximum limit, clients can utilize the **$skip** and **$top** query options in their requests to specify the number of records to skip and the number of records to take, respectively.

{% tabs %}
{% highlight cs tabtitle="WebApiConfig.cs" %}
....
    // Enable OData
    config.MapODataServiceRoute(
        routeName: "ODataRoute",
        routePrefix: "odata",
        model: GetEdmModel()
    );

    // Enable Query Support
    config.Count().MaxTop(null); // Handles paging  operation

....
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/odata/orders").Adaptor("ODataV4Adaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("150").IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
    col.Field("EmployeeID").HeaderText("Employee ID").Width("150").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
}).AllowPaging().Render()

{% endhighlight %}
{% endtabs %}

![paging query](../images/odatav4-adaptor-paging.png)

## Handling CRUD Operations

To manage CRUD (Create, Read, Update, Delete) operations using the ODataV4Adaptor, follow the provided guide for configuring the Syncfusion Grid for [editing]() and utilize the sample implementation of the `OrdersController` in your MVC application. This controller handles HTTP requests for CRUD operations such as GET, POST, PATCH, and DELETE.

To enable CRUD operations in the Syncfusion Grid control within an ASP.NET MVC application, follow the below steps:

{% tabs %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("https://localhost:xxxx/odata/orders")
         .Adaptor("ODataV4Adaptor")).Columns(col =>
         {
            col.Field("OrderID").HeaderText("Order ID").Width("150").IsPrimaryKey(true).Add();
            col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
            col.Field("EmployeeID").HeaderText("Employee ID").Width("150").Add();
            col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
         }).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()
{% endhighlight %}
{% endtabs %}


> Normal/Inline editing is the default edit mode for the Grid component. To enable CRUD operations, ensure that the [isPrimaryKey]()property is set to **true** for a specific Grid column, ensuring that its value is unique.

**Insert Record**

To insert a new record into your Grid, you can utilize the HttpPost method in your application. Below is a sample implementation of inserting a record using the OrdersController:

```cs
 /// <summary>
 /// Inserts a new order to the collection.
 /// </summary>
 /// <param name="addRecord">The order to be inserted.</param>
 /// <returns>It returns the newly inserted record detail.</returns>
 [EnableQuery]
 public IHttpActionResult Post(OrdersDetails addRecord)
 {
     if (addRecord == null)
     {
         return BadRequest("Null order");
     }
     OrdersDetails.GetAllRecords().Insert(0, addRecord);
     return Ok(addRecord);
 }
```

**Update Operation:**

For updating existing records, utilize the `UpdateUrl` property to specify the controller action mapping URL for the update operation.

![Update record](../images/adaptors/url-adaptors/url-adaptor-update-record.png)

```cs
/// <summary>
/// Updates an existing order.
/// </summary>
/// <param name="key">The ID of the order to update.</param>
/// <param name="updateRecord">The updated order details.</param>
/// <returns>It returns the updated order details.</returns>
public IHttpActionResult Patch(int key, OrdersDetails updateRecord)
{
    if (updateRecord == null)
    {
        return BadRequest("No records");
    }
    var existingOrder = OrdersDetails.GetAllRecords().FirstOrDefault(order => order.OrderID == key);
    if (existingOrder != null)
    {
        // If the order exists, update its properties
        existingOrder.CustomerID = updateRecord.CustomerID ?? existingOrder.CustomerID;
        existingOrder.EmployeeID = updateRecord.EmployeeID ?? existingOrder.EmployeeID;
        existingOrder.ShipCountry = updateRecord.ShipCountry ?? existingOrder.ShipCountry;
    }
    return Ok(updateRecord);
}
```

**Delete Operation**

To delete existing records, use the `RemoveUrl` property to specify the controller action mapping URL for the delete operation.

![Delete Record](../images/adaptors/url-adaptors/url-adaptor-delete-record.png)

```cs
/// <summary>
/// Deletes an order.
/// </summary>
/// <param name="key">The ID of the order to delete.</param>
/// <returns>It returns the deleted record detail</returns>
public IHttpActionResult Delete(int key)
{
    var deleteRecord = OrdersDetails.GetAllRecords().FirstOrDefault(order => order.OrderID == key);
    if (deleteRecord != null)
    {
        OrdersDetails.GetAllRecords().Remove(deleteRecord);
    }
    return Ok(deleteRecord);
}
```

![ODataV4Adaptor CRUD operations](../images/adaptors/url-adaptors/adaptor-crud-operation.gif)