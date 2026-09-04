---
layout: post
title: ##Platform_Name## Grid Local Data Binding | Syncfusion
description: Learn how to bind local data sources and in-memory datasets in ##Platform_Name## Data Grid, enable dynamic updates, and efficiently manage displayed data.
platform: ej2-asp-core-mvc
control: Local Data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Local Data Binding in ASP.NET MVC Data Grid

The Data Grid provides a straightforward way to bind local data, such as arrays or JSON objects, to the grid component. This feature allows data to be displayed and manipulated within the grid without the need for external server calls, making it particularly useful for scenarios involving static or locally stored data.

Assign an IEnumerable object to the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. Additionally, an option is available to provide the local data source using an instance of the `DataManager`.

The following example demonstrates utilizing the local data binding feature in the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}

![Local data](../images/data-binding/local-data.png)

## Binding data from Excel file

The Syncfusion ASP.NET MVC Grid allows importing data from Excel files into the web application for display and manipulation within the Grid. This feature streamlines the process of transferring Excel data to a web-based environment. This can be achieved by using the [Uploader](https://ej2.syncfusion.com/aspnetmvc/documentation/uploader/getting-started) [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Change) event.

To import excel data into the Grid, follow these steps:

1. Import excel file using Uploader. 
2. Parse the excel file data using `XLSX` library.
3. Bind the JSON to the Grid. 

The following example demonstrates importing Excel data into the Grid by utilizing the `Uploader` `Change` event along with the `XLSX` library:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata-upload/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata-upload/local.cs %}
{% endhighlight %}
{% endtabs %}

## CRUD operations using Fetch requests

The Data Grid provides a seamless way to bind data from external sources using Fetch requests, facilitating CRUD (Create, Read, Update, Delete) operations with data retrieved from a server. This feature is particularly valuable for sending data to a server for database updates and asynchronously retrieving data without refreshing the entire web page.

To achieve data binding and perform CRUD actions using Fetch requests in the Grid, follow these steps:

**Step 1:** To create a new ASP.NET Web Application(.NET Framework) project named FetchRequest, follow these steps:

* Open Visual Studio.
* Select “Create a new project”
* Choose ASP.NET Web Application(.NET Framework) project template.
* Name the project **FetchRequest**.
* Click “Create”

**Step 2:**  Create a simple Grid by following the [Getting Started documentation link](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/getting-started-mvc).

**Step 3:**  In the **Views/Home/Index.cshtml** file, follow the steps below.

A. To bind data from an external Fetch request, utilize the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property of the Grid. Fetch data from the server and provide it to the `DataSource` property using the `onSuccess` event of the Fetch request.

B. To perform CRUD actions, leverage the [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event. The default CRUD operations can be cancelled by utilizing the **cancel** argument provided by this event. This allows dynamic calling of the server-side method using Fetch, along with the relevant data received from the `ActionBegin` event, to update the server data accordingly.

C. In the Fetch success event, there is flexibility to utilize the Grid `endEdit` and `deleteRecord` methods to handle the addition, editing, and deletion of corresponding data in the Grid. However, invoking these methods triggers the `ActionBegin` event once again to save the changes in the Grid. To prevent this behavior and maintain control over the execution flow, a flag variable can be employed and managed within the [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) and Fetch failure events: The following code snippet demonstrates this approach:

```ts
<div style="padding: 10px 0px 20px 0px">
   @Html.EJS().Button("sample").CssClass("e-success").Content("Bind data via Fetch").Render()
</div>
@Html.EJS().Grid("grid").Height("348px").Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").IsPrimaryKey(true).TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("120").Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
    col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
}).ActionBegin("actionBegin").ActionComplete("actionComplete").Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal); }).AllowPaging().Render()
<script>
   let flag = false;
   document.getElementById('sample').onclick = function () {
       var grid = document.getElementById("grid").ej2_instances[0];
       const fetchRequest = new ej.base.Fetch("/Home/Getdata", 'POST'); 
        fetchRequest.send();
        fetchRequest.onSuccess = (data) => {
            grid.dataSource = data;
        };
    };

    function actionComplete(e) {
        if (e.requestType === 'save' || e.requestType === 'delete') {
            flag = false;
        }
    }

    function actionBegin(e) {
        var grid = document.getElementById("grid").ej2_instances[0];
        if (!flag) {
            if (e.requestType == 'save' && (e.action == 'add')) {
                var editedData = e.data;
                e.cancel = true;
                var fetchRequest = new ej.base.Fetch({
                    url: '/Home/Insert',
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify({ value: editedData })
                });
                fetchRequest.onSuccess = () => {
                    flag = true;
                    grid.endEdit();
                };
                fetchRequest.onFailure = () => {
                    flag = false;
                };
                fetchRequest.send();
            }
            if (e.requestType == 'save' && (e.action == "edit")) {
                var editedData = e.data;
                e.cancel = true;
                var fetchRequest = new ej.base.Fetch({
                    url: '/Home/Update',
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify({ value: editedData })
                }); 
                fetchRequest.onSuccess = () => {
                    flag = true;
                    grid.endEdit();
                };
                fetchRequest.onFailure = () => {
                    flag = false;
                };
                fetchRequest.send();
            }
            if (e.requestType == 'delete') {
                var editedData = e.data;
                e.cancel = true;
                var fetchRequest = new ej.base.Fetch({
                    url: '/Home/Delete',
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify({ key: editedData[0][grid.getPrimaryKeyFieldNames()[0]] })
                });
                fetchRequest.onSuccess = () => {
                    flag = true;
                    grid.deleteRecord();
                };
                fetchRequest.onFailure = () => {
                    flag = false;
                };
                fetchRequest.send();
            }
        }
    }
</script>

```

**Step 4:** In the **HomeController.cs** file under the **Controllers** folder, there is a method named GetData within the HomeController that provides the data source for the Grid. When the button is clicked, a Fetch request is sent to retrieve the data from the server and bind it to the Grid. Additionally, implement server-side logic to perform add, edit, and delete operations. Add the following code:

```cs
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FetchRequest.Models;
namespace FetchRequest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            IEnumerable DataSource = OrdersDetails.GetAllRecords();
            return Json(DataSource);
        }

        public ActionResult Update(OrdersDetails value)
        {
            var ord = value;
            OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.Freight = ord.Freight;
            val.OrderDate = ord.OrderDate;
            val.ShipCity = ord.ShipCity;
            val.ShipCountry = ord.ShipCountry;
            return Json(value);
        }

        //Insert the record.
        public ActionResult Insert(OrdersDetails value)
        {
            OrdersDetails.GetAllRecords().Insert(0, value);
            return Json(value);
        }

        //Delete the record.
        public ActionResult Delete(int key)
        {
            OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == key).FirstOrDefault());
            var data = OrdersDetails.GetAllRecords();
            return Json(data);
        }
    }
}

```

**Step 5:** Create a model class named **OrdersDetails.cs** under the Models folder in the server-side project to represent the order data. Add the following code:

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FetchRequest.Models
{
    public class OrdersDetails
    {
        public OrdersDetails() { }
        public OrdersDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
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
            List<OrdersDetails> order = new List<OrdersDetails>();
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
            return order;
        }
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCountry { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}

## Display the loading indicator with local data

The Syncfusion ASP.NET MVC Grid allows displaying a loading indicator while loading local data. This feature is useful when there is a delay in loading data from a local source, to inform that the data is being fetched.

To display the loading indicator with local data, set the `ShowSpinner` property to `true`. This property controls the visibility of the loading indicator.

The following example demonstrates displaying the loading indicator in the Grid using the [Load](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) and [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) events:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata-loading-indicator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/grid/data-binding/localdata-loading-indicator/databind.cs %}
{% endhighlight %}
{% endtabs %}

## Binding data and performing CRUD actions via AJAX request

The Syncfusion ASP.NET MVC Grid provides a seamless way to bind data from external sources using AJAX requests, facilitating CRUD (Create, Read, Update, Delete) operations with data retrieved from a server. This feature is particularly valuable for sending data to a server for database updates and asynchronously retrieving data without refreshing the entire web page.

To achieve data binding and perform CRUD actions using AJAX requests in the Grid, follow these steps:

**Step 1:** To create a new ASP.NET Web Application(.NET Framework) project named AJAX Request, follow these steps:

* Open Visual Studio.
* Select “Create a new project”
* Choose ASP.NET Web Application(.NET Framework) project template.
* Name the project **AJAXRequest**.
* Click “Create”

**Step 2:**  Create a simple Grid by following the [Getting Started documentation link](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/getting-started-mvc).

**Step 3:**  In the **Views/Home/Index.cshtml** file, follow the steps below.

A. To bind data from an external AJAX request, utilize the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property of the Grid. Fetch AJAX data from the server and provide it to the `DataSource` property using the `onSuccess` event of the AJAX request.

B. To perform CRUD actions, leverage the [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event. The default CRUD operations can be cancelled by utilizing the **cancel** argument provided by this event. This allows dynamic calling of the server-side method using AJAX, along with the relevant data received from the `ActionBegin` event, to update the server data accordingly.

C. In the AJAX success event, there is flexibility to utilize the Grid `endEdit` and `deleteRecord` methods to handle the addition, editing, and deletion of corresponding data in the Grid. However, invoking these methods triggers the `ActionBegin` event once again to save the changes in the Grid. To prevent this behavior and maintain control over the execution flow, a flag variable can be employed and managed within the `ActionComplete` and AJAX failure events: The following code snippet demonstrates this approach:

```ts

<div style="padding: 10px 0px 20px 0px">
    @Html.EJS().Button("sample").CssClass("e-success").Content("Bind data via ajax").Render()
</div>
@Html.EJS().Grid("grid").Height("348px").Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").IsPrimaryKey(true).TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Width("120").Add();
    col.Field("CustomerID").HeaderText("Customer ID").Width("150").Add();
    col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
}).ActionBegin("actionBegin").ActionComplete("actionComplete").Toolbar(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel" }).EditSettings(edit => { edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true).Mode(Syncfusion.EJ2.Grids.EditMode.Normal); }).AllowPaging().Render()
<script>
   let flag = false;
   document.getElementById('sample').onclick = function () {
       var grid = document.getElementById("grid").ej2_instances[0];
       const ajax = new ej.base.Ajax("/Home/Getdata", 'POST');
       ajax.send();
        ajax.onSuccess = (data) => {
            grid.dataSource = JSON.parse(data);
        };
    };

    function actionComplete(e) {
        if (e.requestType === 'save' || e.requestType === 'delete') {
            flag = false;
        }
    }

    function actionBegin(e) {
        var grid = document.getElementById("grid").ej2_instances[0];
        if (!flag) {
            if (e.requestType == 'save' && (e.action == 'add')) {
                var editedData = e.data;
                e.cancel = true;
                var ajax = new ej.base.Ajax({
                    url: '/Home/Insert',
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify({ value: editedData })
                });
                ajax.onSuccess = () => {
                    flag = true;
                    grid.endEdit();
                };
                ajax.onFailure = () => {
                    flag = false;
                };
                ajax.send();
            }
            if (e.requestType == 'save' && (e.action == "edit")) {
                var editedData = e.data;
                e.cancel = true;
                var ajax = new ej.base.Ajax({
                    url: '/Home/Update',
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify({ value: editedData })
                });
                ajax.onSuccess = () => {
                    flag = true;
                    grid.endEdit();
                };
                ajax.onFailure = () => {
                    flag = false;
                };
                ajax.send();
            }
            if (e.requestType == 'delete') {
                var editedData = e.data;
                e.cancel = true;
                var ajax = new ej.base.Ajax({
                    url: '/Home/Delete',
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify({ key: editedData[0][grid.getPrimaryKeyFieldNames()[0]] })
                });
                ajax.onSuccess = () => {
                    flag = true;
                    grid.deleteRecord();
                };
                ajax.onFailure = () => {
                    flag = false;
                };
                ajax.send();
            }
        }
    }
</script>

```

**Step 4:** In the **HomeController.cs** file under the **Controllers** folder, there is a method named GetData within the HomeController that provides the data source for the Grid. When the button is clicked, an AJAX request is sent to retrieve the data from the server and bind it to the Grid. Additionally, implement server-side logic to perform add, edit, and delete operations. Add the following code:

```cs
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAXRequest.Models;
namespace AJAXRequest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            IEnumerable DataSource = OrdersDetails.GetAllRecords();
            return Json(DataSource);
        }

        public ActionResult Update(OrdersDetails value)
        {
            var ord = value;
            OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.Freight = ord.Freight;
            val.OrderDate = ord.OrderDate;
            val.ShipCity = ord.ShipCity;
            val.ShipCountry = ord.ShipCountry;
            return Json(value);
        }

        //Insert the record.
        public ActionResult Insert(OrdersDetails value)
        {
            OrdersDetails.GetAllRecords().Insert(0, value);
            return Json(value);
        }

        //Delete the record.
        public ActionResult Delete(int key)
        {
            OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == key).FirstOrDefault());
            var data = OrdersDetails.GetAllRecords();
            return Json(data);
        }
    }
}

```

**Step 5:** Create a model class named **OrdersDetails.cs** under the Models folder in the server-side project to represent the order data. Add the following code:

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJAXRequest.Models
{
    public class OrdersDetails
    {
        public OrdersDetails() { }
        public OrdersDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
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
            List<OrdersDetails> order = new List<OrdersDetails>();
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
            return order;
        }
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCountry { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}

```
> A complete sample for AJAX request can be found on [GitHub](https://github.com/SyncfusionExamples/Binding-data-and-perform-action-in-ej2-aspnetmvc-grid-using-Ajax-request).

## Display the loading indicator using AJAX

The Syncfusion ASP.NET MVC Grid allows displaying a loading indicator while loading data using AJAX. This feature is useful when there is a delay in loading data, to indicate that the data is being fetched. This is particularly beneficial when working with large datasets or under conditions of slower internet connections.

To display the loading indicator with local data, set the `ShowSpinner` property to **true**. This property controls the visibility of the loading indicator.

The following example demonstrates displaying the loading indicator in the Grid using the [Load](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) and [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) events:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata-indicator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/grid/data-binding/localdata-indicator/databind.cs %}
{% endhighlight %}
{% endtabs %}

## Managing spinner visibility during data loading

Showing a spinner during data loading in the Data Grid enhances the experience by providing a visual indication of the loading progress. This feature helps to understand that data is being fetched or processed.

To show or hide a spinner during data loading in the Grid, utilize the `showSpinner` and `hideSpinner` methods provided by the Data Grid.

The following example demonstrates showing and hiding the spinner during data loading using external buttons in a grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata-spinner/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata-spinner/local.cs %}
{% endhighlight %}
{% endtabs %}

## Immutable mode  

Immutable mode in the Data Grid is designed to optimize re-rendering performance by utilizing the object reference and deep compare concept. This mode ensures that when performing grid actions, only the modified or newly added rows are re-rendered, preventing unnecessary re-rendering of unchanged rows.  

To enable this feature, set the [EnableImmutableMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableImmutableMode) property as `true`.

If immutable mode is enabled, when the datasource changes, only newly added rows are regenerated or reused. Consequently, the  Grid [QueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) and [RowDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) events trigger only for newly generated rows, not for existing rows. 

If immutable mode is not enabled, both newly added rows and existing rows are regenerated or reused when the datasource changes. As a result, the `RowDataBound` and `QueryCellInfo` events trigger for both newly added and existing rows. 

> This feature uses the primary key value for data comparison. Therefore, the `IsPrimaryKey` column must be provided.

The following example demonstrates enabling immutable mode in an Angular component. When add, delete, or update actions are performed, existing rows are not regenerated or reused, ensuring efficient rendering of only the modified or newly added rows:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/immutable-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Immutable.cs" %}
{% include code-snippet/grid/data-binding/immutable-mode/immutable.cs %}
{% endhighlight %}
{% endtabs %}

![Immutable mode](../images/data-binding/databinding-immutable.gif)

### Immutable mode constraints

Immutable mode updates only the rows whose data has changed to improve rendering performance. As a result, features that rely on complex layouts, advanced rendering scenarios, data processing operations, or interactive grid behaviors may not function as expected.

## ExpandoObject binding

The Syncfusion ASP.NET MVC Grid is typically bound to a specific model type. However, there are scenarios where the model type is unknown during compile time. In such cases, data can be bound to the Grid using a list of ExpandoObject. This allows for dynamic data structures that can adapt to various data shapes without a predefined schema.

To bind an `ExpandoObject` to the Grid, assign it to the `DataSource` property. The Grid supports various data operations such as sorting, filtering, and editing when using `ExpandoObject`.

The following sample demonstrates ExpandoObject binding:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}

## ExpandoObject with complex column binding

Complex data binding can be achieved with ExpandoObject in the Syncfusion ASP.NET MVC Grid by using the dot (.) operator in the `Column.Field` property. This feature allows accessing and binding to nested properties within the ExpandoObject, enabling more structured data representation in the Grid.

In the following example, the fields **Customer.CustomerID**, **Customer.OrderDate**, **Customer.Freight**, and **Customer.ShipCountry** represent complex data that is bound to the Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}

N> Perform data and CRUD operations for complex ExpandoObject binding fields as well.

## DynamicObject binding

The Syncfusion ASP.NET MVC Grid component is typically bound to a specific model type. However, there are scenarios where the model type is unknown during compile time. In such cases, data can be bound to the Grid using a list of ExpandoObject. This allows for dynamic data structures that can adapt to various data shapes without a predefined schema.

To bind an `ExpandoObject` to the Grid, assign it to the `DataSource` property. This enables the Grid to perform various supported data operations and editing on the DynamicObject.

> The [GetDynamicMemberNames](https://learn.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject.getdynamicmembernames?view=netcore-3.1) method of the DynamicObject class must be overridden and return the property names to perform data operation and editing while using DynamicObject.

The following example demonstrates binding a list of DynamicObject to the Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}

## DynamicObject with complex column binding

Complex data binding can be achieved with DynamicObject in the Syncfusion ASP.NET MVC Grid by using the dot (.) operator in the `Column.Field` property. This allows accessing and binding to nested properties within the DynamicObject, enabling the display of structured data in the Grid.

In the following example, **Customer.OrderDate**, **Customer.Freight**, and **Customer.ShipCountry** are considered complex data fields that are bound to the Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}

> Perform data and CRUD operations for complex DynamicObject binding fields as well.

