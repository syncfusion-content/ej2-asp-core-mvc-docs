---
layout: post
title: Bind data & perform CRUD with UrlAdaptor in Syncfusion Grid
description: Learn here all about Bind data and perform CRUD action with UrlAdaptor in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: grid
keywords: Adaptors, UrlAdaptor, url method adaptor, remotedata 
publishingplatform: ##Platform_Name##
documentation: ug
---

# UrlAdaptor in Syncfusion ASP.NET MVC Grid Control

The UrlAdaptor serves as the base adaptor for facilitating communication between remote data services and an UI control. It enables seamless data binding and interaction with custom API services or any remote service through URLs. The UrlAdaptor is particularly useful for the scenarios where a custom API service with unique logic for handling data and CRUD operations is in place. This approach allows for custom handling of data and CRUD operations, and the resultant data returned in the `result` and `count` format for display in the Syncfusion ASP.NET MVC Grid control.

This section describes a step-by-step process for retrieving data using UrlAdaptor, then binding it to the ASP.NET MVC Grid control to facilitate data and CRUD operations.

## Creating an API Service

To configure a server with Syncfusion ASP.NET MVC Grid, you need to follow the below steps:

**1. Project Creation:**

Open Visual Studio and create an ASP.NET MVC project named **UrlAdaptor**. To create an ASP.NET MVC application, follow the documentation [link](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app) for detailed steps.

**2. Model Class Creation:**

Create a model class named **Orders.cs** in the server-side **Models** folder to represent the order data.

{% tabs %}
{% highlight cs tabtitle="Orders.cs" %}

 namespace UrlAdaptor_MVC.Models
{
    public class Orders
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
        public decimal Freight { get; set; }

        // Sample Data
        public static List<Orders> GetAllRecords()
        {
            return new List<Orders>()
            {
                new Orders() { OrderID = 10248, CustomerID = "VINET", EmployeeID = 5, OrderDate = DateTime.Now.AddDays(-10), ShipCity = "Reims", Freight = 32.38M },
                new Orders() { OrderID = 10249, CustomerID = "TOMSP", EmployeeID = 6, OrderDate = DateTime.Now.AddDays(-8), ShipCity = "Münster", Freight = 11.61M },
                new Orders() { OrderID = 10250, CustomerID = "HANAR", EmployeeID = 4, OrderDate = DateTime.Now.AddDays(-6), ShipCity = "Rio de Janeiro", Freight = 65.83M }
            };
        }
    }
}
{% endhighlight %}
{% endtabs %}

**3. API Controller Creation:**

Create a file named `GridController.cs` under the **Controllers** folder. This controller will handle data communication with the ASP.NET MVC Grid component.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

using System.Web.Mvc;
using Syncfusion.EJ2.Base;
using UrlAdaptor_MVC.Models;

namespace UrlAdaptor_MVC.Controllers
{
   
    public class GridController : Controller
    {
        private static List<Orders> order = Orders.GetAllRecords();

        [HttpPost]
        public ActionResult UrlDatasource(DataManagerRequest dm)
        {
            IEnumerable<Orders> DataSource = order;
            DataOperations operation = new DataOperations();
            int count = DataSource.Count();
            return dm.RequiresCounts ? Json(new { result = DataSource, count }) : Json(DataSource);
        }
    }}

{% endhighlight %}
{% endtabs %}

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
@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
    col.Field("ShipCity").HeaderText("ShipCity").Width("140").Add();
}).Render()
{% endhighlight %}
{% endtabs %}


**Step 7:** Run the Project

Now, run the project to see the Syncfusion Grid connected to the API service in action.

> * The Syncfusion Grid control provides built-in support for handling various data operations such as searching, sorting, filtering, aggregate and paging on the server-side. These operations can be handled using methods such as `PerformSearching`, `PerformFiltering`, `PerformSorting`, `PerformTake` and `PerformSkip` available in the `Syncfusion.EJ2.MVC5` package. Let’s explore how to manage these data operations using the `UrlAdaptor`.
> * In an API service project, add `Syncfusion.EJ2.MVC5 ` by opening the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search and install it.
> * To access `DataManagerRequest`, import `Syncfusion.EJ2.Base` in `GridController.cs` file.

## Handling Searching Operation

To handle searching operation, ensure that your API endpoint supports custom searching criteria. Implement the searching logic on the server-side using the `PerformSearching`. This allows the custom data source to undergo searching based on the criteria specified in the incoming `DataManagerRequest` object.

![UrlAdaptor searching](../images/adaptors/url-adaptors/url-adaptor-searching.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}
 [HttpPost]
 public ActionResult UrlDatasource(DataManagerRequest DataManagerRequest)
 {
     IEnumerable<Orders> DataSource = order;
     DataOperations operation = new DataOperations();

     if (DataManagerRequest.Search != null && DataManagerRequest.Search.Count > 0)
     {
         DataSource = operation.PerformSearching(DataSource, DataManagerRequest.Search);
     }
    
     int count = DataSource.Count();

     return DataManagerRequest.RequiresCounts ? Json(new { result = DataSource, count }) : Json(DataSource);
 }
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
    col.Field("ShipCity").HeaderText("ShipCity").Width("140").Add();
}).Toolbar(new List<string>() { "Search" }).Render()

{% endhighlight %}
{% endtabs %}

## Handling Filtering Operation

To handle filtering operation, ensure that your API endpoint supports custom filtering criteria. Implement the filtering logic on the server-side using the `PerformFiltering`. This allows the custom data source to undergo filtering based on the criteria specified in the incoming `DataManagerRequest` object.

**Single column filtering**
![Single column filtering](../images/adaptors/url-adaptors/url-adaptor-filtering.png)

**Multi column filtering**
![Multi column filtering](../images/adaptors/url-adaptors/url-adaptor-multi-filtering.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}
 [HttpPost]
 public ActionResult UrlDatasource(DataManagerRequest DataManagerRequest)
 {
     IEnumerable<Orders> DataSource = order;
     DataOperations operation = new DataOperations();

     if (DataManagerRequest.Where != null && DataManagerRequest.Where.Count > 0)
     {
         DataSource = operation.PerformFiltering(DataSource, DataManagerRequest.Where, DataManagerRequest.Where[0].Operator);
     }

     int count = DataSource.Count();

     return DataManagerRequest.RequiresCounts ? Json(new { result = DataSource, count }) : Json(DataSource);
 }
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
    col.Field("ShipCity").HeaderText("ShipCity").Width("140").Add();
}).AllowFiltering().Render()

{% endhighlight %}
{% endtabs %}

## Handling Sorting Operation

To handle sorting operation, ensure that your API endpoint supports custom sorting criteria. Implement the sorting logic on the server-side using the `PerformSorting`. This allows the custom data source to undergo sorting based on the criteria specified in the incoming `DataManagerRequest` object.

**Single column sorting**
![Single column sorting](../images/adaptors/url-adaptors/url-adaptor-sorting.png)

**Multi column sorting**
![Multi column sorting](../images/adaptors/url-adaptors/url-adaptor-multi-sorting.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}
        public ActionResult UrlDatasource(DataManagerRequest DataManagerRequest)
        {
            IEnumerable<Orders> DataSource = order;
            DataOperations operation = new DataOperations();
            if (DataManagerRequest.Sorted != null && DataManagerRequest.Sorted.Count > 0)
            {
                DataSource = operation.PerformSorting(DataSource, DataManagerRequest.Sorted);
            }
           
            int count = DataSource.Count();
           
            return DataManagerRequest.RequiresCounts ? Json(new { result = DataSource, count }) : Json(DataSource);
        }
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
    col.Field("ShipCity").HeaderText("ShipCity").Width("140").Add();
}).AllowSorting().Render()

{% endhighlight %}
{% endtabs %}

## Handling Paging Operation

To handle paging operation, ensure that your API endpoint supports custom paging criteria. Implement the paging logic on the server-side using the `PerformTake` and `PerformSkip`. This allows the custom data source to undergo paging based on the criteria specified in the incoming `DataManagerRequest` object.

![UrlAdaptor paging](../images/adaptors/url-adaptors/url-adaptor-paging.png)

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}
 [HttpPost]
 public ActionResult UrlDatasource(DataManagerRequest DataManagerRequest)
 {
     IEnumerable<Orders> DataSource = order;
     DataOperations operation = new DataOperations();
     int count = DataSource.Count();
     if (DataManagerRequest.Skip != 0)
     {
         DataSource = operation.PerformSkip(DataSource, DataManagerRequest.Skip);
     }
     if (DataManagerRequest.Take != 0)
     {
         DataSource = operation.PerformTake(DataSource, DataManagerRequest.Take);
     }

     return DataManagerRequest.RequiresCounts ? Json(new { result = DataSource, count }) : Json(DataSource);
 }
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("/Grid/UrlDatasource").Adaptor("UrlAdaptor")).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
    col.Field("ShipCity").HeaderText("ShipCity").Width("140").Add();
}).AllowPaging().Render()

{% endhighlight %}
{% endtabs %}

## Handling CRUD Operations

The Syncfusion ASP.NET MVC Grid Component seamlessly integrates CRUD (Create, Read, Update, Delete) operations with server-side controller actions through specific properties: `InsertUrl`, `RemoveUrl`, `UpdateUrl`,`CrudUrl`, and `BatchUrl`. These properties enable the Grid to communicate with the data service for every Grid action, facilitating server-side operations.

**CRUD Operations Mapping**

CRUD operations within the Grid can be mapped to server-side controller actions using specific properties:

1. **InsertUrl**: Specifies the URL for inserting new data.
2. **RemoveUrl**: Specifies the URL for removing existing data.
3. **UpdateUrl**: Specifies the URL for updating existing data.
4. **CrudUrl**: Specifies a single URL for all CRUD operations.
5. **BatchUrl**: Specifies the URL for batch editing.

To enable editing in ASP.NET MVC Grid component, refer to the editing [Documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/editing/edit). In the below example, the inline edit mode` is enabled and [Toolbar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property is configured to display toolbar items for editing purposes.

{% tabs %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("/Grid/UrlDatasource")
         .UpdateUrl("/Grid/Update")
        .InsertUrl("/Grid/Insert")
        .RemoveUrl("/Grid/Remove").Adaptor("UrlAdaptor")).Columns(col =>
         {
             col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
             col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
             col.Field("ShipCity").HeaderText("ShipCity").Width("140").Add();
         }).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()
{% endhighlight %}
{% endtabs %}

> Normal/Inline editing is the default edit `Mode` for the Grid component. To enable CRUD operations, ensure that the `isPrimaryKey` property is set to **true** for a specific Grid column, ensuring that its value is unique.

The below class is used to structure data sent during CRUD operations.

```cs
  public class CRUDModel<T>
  {
      public string action { get; set; }
      public string keyColumn { get; set; }
      public object key { get; set; }
      public T value { get; set; }
      public List<T> Added { get; set; }
      public List<T> Changed { get; set; }
      public List<T> Deleted { get; set; }
      public IDictionary<string, object> @params { get; set; }
  }
```

**Insert Operation:**

To insert a new record, utilize the `InsertUrl` property to specify the controller action mapping URL for the insert operation.

![Insert record](../images/adaptors/url-adaptors/url-adaptor-insert-record.png)

```cs

/// <summary>
/// Inserts a new data item into the data collection.
/// </summary>
/// <returns>Returns void</returns>
      public ActionResult Insert(Orders value)
      {
          if (value != null)
          {
              // Assign a new OrderID if missing
              value.OrderID = order.Count > 0 ? order.Max(o => o.OrderID) + 1 : 1;
              order.Insert(0, value);
          }

          // Ensure returning the expected format
          return Json(new { result = value, count = order.Count });
      }
```

**Update Operation:**

For updating existing records, utilize the `UpdateUrl` property to specify the controller action mapping URL for the update operation.

![Update record](../images/adaptors/url-adaptors/url-adaptor-update-record.png)

```cs

/// <summary>
/// Update a existing data item from the data collection.
/// </summary>
/// <returns>Returns void</returns>

[HttpPost]
public ActionResult Update(Orders value)
{
    var data = order.FirstOrDefault(or => or.OrderID == value.OrderID);
    if (data != null)
    {
        data.CustomerID = value.CustomerID;
        data.EmployeeID = value.EmployeeID;
        data.OrderDate = value.OrderDate;
        data.ShipCity = value.ShipCity;
        data.Freight = value.Freight;
    }
    return Json(value);
}
```

**Delete Operation**

To delete existing records, use the `RemoveUrl` property to specify the controller action mapping URL for the delete operation.

![Delete Record](../images/adaptors/url-adaptors/url-adaptor-delete-record.png)

```cs
/// <summary>
/// Remove a specific data item from the data collection.
/// </summary>
/// <return>Returns void</return>
[HttpPost]
public ActionResult Remove(CRUDModel<Orders> value)
{
    var data = order.FirstOrDefault(or => or.OrderID == int.Parse(value.key.ToString()));
    if (data != null)
    {
        order.Remove(data);
    }
    return Json(value);
}
```

![UrlAdaptor CRUD operations](../images/adaptors/url-adaptors/adaptor-crud-operation.gif)

**Single method for performing all CRUD Operations**

Using the `CrudUrl` property, the controller action mapping URL can be specified to perform all the CRUD operation at server-side using a single method instead of specifying separate controller action method for CRUD (insert, update and delete) operations.

The following code example describes the above behavior.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}

 [HttpPost]
 public JsonResult CrudUpdate(CRUDModel<Orders> request)
 {
     if (request.action == "update")
     {
         var existingRecord = order.FirstOrDefault(o => o.OrderID == request.value.OrderID);
         if (existingRecord != null)
         {
             existingRecord.CustomerID = request.value.CustomerID;
             existingRecord.ShipCity = request.value.ShipCity;
             existingRecord.Freight = request.value.Freight;
         }
     }
     else if (request.action == "insert")
     {
         var newId = order.Any() ? order.Max(o => o.OrderID) + 1 : 1;
         request.value.OrderID = newId;
         order.Add(request.value);
     }
     else if (request.action == "remove")
     {
         var key = int.Parse(request.key.ToString());
         var recordToRemove = order.FirstOrDefault(o => o.OrderID == key);
         if (recordToRemove != null)
         {
             order.Remove(recordToRemove);
         }
     }
     return Json(order);
 }
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("/Grid/UrlDatasource")
         .CrudUrl("/Grid/CrudUpdate").Adaptor("UrlAdaptor")).AllowSorting().Columns(col =>
         {
             col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
             col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
             col.Field("ShipCity").HeaderText("ShipCity").Width("140").Add();
         }).AllowPaging().EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()

{% endhighlight %}
{% endtabs %}

**Batch Operation**

To perform batch operation, define the edit `mode` as **Batch** and specify the `BatchUrl` property in the DataManager. Use the **Add** toolbar button to insert new row in batch editing mode. To edit a cell, double-click the desired cell and update the value as required. To delete a record, simply select the record and press the **Delete** toolbar button. Now, all CRUD operations will be executed in single request. Clicking the **Update** toolbar button will update the newly added, edited, or deleted records from the Orders table using a single API POST request.

{% tabs %}
{% highlight cs tabtitle="GridController.cs" %}
  [HttpPost]
  public ActionResult BatchUpdate(CRUDModel<Orders> batchModel)
  {
      if (batchModel.Added != null)
      {
          foreach (var item in batchModel.Added)
          {
              item.OrderID = order.Count > 0 ? order.Max(o => o.OrderID) + 1 : 1;
              order.Insert(0, item);
          }
      }
      if (batchModel.Changed != null)
      {
          foreach (var item in batchModel.Changed)
          {
              var data = order.FirstOrDefault(or => or.OrderID == item.OrderID);
              if (data != null)
              {
                  data.CustomerID = item.CustomerID;
                  data.EmployeeID = item.EmployeeID;
                  data.OrderDate = item.OrderDate;
                  data.ShipCity = item.ShipCity;
                  data.Freight = item.Freight;
              }
          }
      }
      if (batchModel.Deleted != null)
      {
          foreach (var item in batchModel.Deleted)
          {
              var data = order.FirstOrDefault(or => or.OrderID == item.OrderID);
              if (data != null)
              {
                  order.Remove(data);
              }
          }
      }
      return Json(order);
  }
{% endhighlight %}
{% highlight ts tabtitle="Index.cshtml" %}

@Html.EJS().Grid("Grid").DataSource(ds => ds.Url("/Grid/UrlDatasource")
         .BatchUrl("/Grid/BatchUpdate").Adaptor("UrlAdaptor")).AllowSorting().Columns(col =>
         {
             col.Field("OrderID").HeaderText("Order ID").Width("120").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).IsPrimaryKey(true).Add();
             col.Field("CustomerID").HeaderText("Customer ID").Width("140").Add();
             col.Field("ShipCity").HeaderText("ShipCity").Width("140").Add();
         }).AllowPaging().EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Batch); }).Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).Render()
{% endhighlight %}
{% endtabs %}

![UrlAdaptor Batch Editing](../images/adaptors/url-adaptors/url-adaptor-batch-editing.gif)