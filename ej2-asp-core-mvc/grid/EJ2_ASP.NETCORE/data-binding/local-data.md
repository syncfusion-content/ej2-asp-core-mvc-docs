---
layout: post
title: ##Platform_Name## Grid Local Data Binding | Syncfusion
description: Learn how to bind local data sources and in-memory datasets in ##Platform_Name## Data Grid, enable dynamic updates, and efficiently manage displayed data.
platform: ej2-asp-core-mvc
control: Local Data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Local Data Binding in ASP.NET Core Data Grid

The Data Grid provides a straightforward way to bind local data, such as arrays or JSON objects, to the grid component. This feature allows data to be displayed and manipulated within the grid without the need for external server calls, making it particularly useful for scenarios involving static or locally stored data.

Assign an IEnumerable object to the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. Additionally, an option is available to provide the local data source using an instance of the `DataManager`.

The following example demonstrates the local data binding feature in the Data Grid component:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/localcore.cs %}
{% endhighlight %}
{% endtabs %}

![Local data](../images/data-binding/local-data.png)

> By default, `DataManager` uses `JsonAdaptor` for list data-binding.

## Binding data from Excel file

The Data Grid supports importing data from Excel files for display and manipulation within the grid. This enables transferring Excel data into a web-based environment. Use the [Uploader](https://ej2.syncfusion.com/aspnetcore/documentation/uploader/getting-started) [Change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Change) event.

To import excel data into the Grid, follow these steps:

1. Import excel file using `Uploader`. 
2. Parse the excel file data using **`XLSX`** library.
3. Bind the JSON to the Grid. 

The following example demonstrates importing Excel data into the Grid by utilizing the `Uploader` `Change` event along with the `XLSX` library:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata-upload/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indicator" %}
{% include code-snippet/grid/data-binding/localdata-upload/localcore.cs %}
{% endhighlight %}
{% endtabs %}

## CRUD operations using Fetch requests

The Data Grid provides a seamless way to bind data from external sources using Fetch requests, facilitating CRUD (Create, Read, Update, Delete) operations with data retrieved from a server. This feature is particularly valuable for sending data to a server for database updates and for asynchronously retrieving data without refreshing the entire web page.

To achieve data binding and perform CRUD actions using Fetch requests in the Grid, follow these steps:

**Step 1:** To create a new ASP.NET Core Web App(Razor Pages) project named FetchRequest, follow these steps:

* Open Visual Studio.
* Select “Create a new project”
* Choose ASP.NET Core Web App(Razor Pages) project template.
* Name the project **FetchRequest**.
* Click “Create”

**Step 2:**  Create a simple Grid by following the [Getting Started documentation link](https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core).

**Step 3:**  In the **Pages/Index.cshtml** file, follow the steps below.

A. To bind data from an external Fetch request, utilize the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property of the Grid. Fetch data from the server and provide it to the `dataSource` property using the `onSuccess` event of the Fetch request.

B. To perform CRUD actions, leverage the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event. The default CRUD operations can be cancelled by utilizing the **cancel** argument provided by this event. This allows dynamic calling of the server-side method using Fetch, along with the relevant data received from the `actionBegin` event, to update the server data accordingly.

C. In the Fetch success event, there is flexibility to utilize the Grid `endEdit` and `deleteRecord` methods to handle the addition, editing, and deletion of corresponding data in the Grid. However, invoking these methods triggers the `actionBegin` event once again to save the changes in the Grid. To prevent this behavior and maintain control over the execution flow, a flag variable can be employed and managed within the `actionComplete` and Fetch failure events: The following code snippet demonstrates this approach:

```ts
@{
    string fullUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}{Request.Path}";
}
@Html.AntiForgeryToken()
<div style="padding: 10px 0px 20px 0px">
    <ejs-button id="sample" cssClass="e-success" content="Bind data via Fetch"></ejs-button>
</div>
<ejs-grid id="grid" height="348px" actionComplete="actionComplete" actionBegin="actionBegin" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Cancel", "Update" })">
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" isPrimaryKey="true" textAlign="Right" width="120"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer Name" width="150"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="ShipCountry" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
    let flag = false;
    document.getElementById('sample').onclick = function () {
        var grid = document.getElementById("grid").ej2_instances[0];
        const fetchRequest = new ej.base.Fetch({
            url: '@fullUrl?handler=Getdata',
            type: "POST",
            beforeSend: function (args) {
                args.fetchRequest.headers.set('XSRF-TOKEN', document.querySelector('input[type = "hidden"][name = "__RequestVerificationToken"]').value);
            },
        });
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
                    url: '@fullUrl?handler=Insert',
                    type: 'POST',
                    beforeSend: function (args) {
                        args.fetchRequest.headers.set('XSRF-TOKEN', document.querySelector('input[type = "hidden"][name = "__RequestVerificationToken"]').value);
                    },
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
                    url: '@fullUrl?handler=Update',
                    type: 'POST',
                    beforeSend: function (args) {
                        args.fetchRequest.headers.set('XSRF-TOKEN', document.querySelector('input[type = "hidden"][name = "__RequestVerificationToken"]').value);
                    },
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
                    url: '@fullUrl?handler=Delete',
                    type: 'POST',
                    beforeSend: function (args) {
                        args.fetchRequest.headers.set('XSRF-TOKEN', document.querySelector('input[type = "hidden"][name = "__RequestVerificationToken"]').value);
                    },
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

**Step 4:**  In the **Index.cshtml.cs** file, there is a method named **OnPostGetdata** that provides the data source for the Grid. When the button is clicked, a Fetch request is sent to retrieve the data from the server and bind it to the Grid. Additionally, implement server-side logic to perform add, edit, and delete operations. Add the following code:

```cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using FetchRequest.Models;

namespace FetchRequest.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {

        }

        public ActionResult OnPostGetdata()
        {
            IEnumerable DataSource = OrdersDetails.GetAllRecords();
            return new JsonResult(DataSource);
        }

        public ActionResult OnPostUpdate([FromBody] CRUDModel<OrdersDetails> value)
        {
            var ord = value.value;
            OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.Freight = ord.Freight;
            val.OrderDate = ord.OrderDate;
            val.ShipCity = ord.ShipCity;
            val.ShipCountry = ord.ShipCountry;
            return new JsonResult(value.value);
        }

        //Insert the record.
        public ActionResult OnPostInsert([FromBody] CRUDModel<OrdersDetails> value)
        {
            OrdersDetails.GetAllRecords().Insert(0, value.value);
            return new JsonResult(value.value);
        }

        //Delete the record.
        public ActionResult OnPostDelete(int key)
        {
            OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == key).FirstOrDefault());
            var data = OrdersDetails.GetAllRecords();
            return new JsonResult(data);
        }

        public class CRUDModel<T> where T : class
        {
            public string action { get; set; }
            public string table { get; set; }
            public string keyColumn { get; set; }
            public object key { get; set; }
            public T value { get; set; }
            public List<T> added { get; set; }
            public List<T> changed { get; set; }
            public List<T> deleted { get; set; }
            public IDictionary<string, object> @params { get; set; }
        }
    }
}

```

**Step 6:** Create a model class named **OrdersDetails.cs** under the Models folder in the server-side project to represent the order data. Add the following code:

```cs

namespace FetchRequest.Models
{
    public class OrdersDetails
    {
        public static List<OrdersDetails> order = new List<OrdersDetails>();
        public OrdersDetails()
        {

        }

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
            if (order.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 5; i++)
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
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCountry { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}

```

**Step 5:** In the **Program.cs** file, add the following code:

```cs
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();

```

## Display the loading indicator with local data

The Data Grid allows displaying a loading indicator while loading local data. This is useful when data loading from a local source is delayed and a visual indication is required to show that data is being fetched.

To display the loading indicator when using local data, invoke the `showSpinner` method. This method controls the visibility of the loading indicator.

The following example demonstrates displaying the loading indicator in the grid using the [load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) and [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) events:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata-loading-indicator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/grid/data-binding/localdata-loading-indicator/databindcore.cs %}
{% endhighlight %}
{% endtabs %}

## CRUD Operations using AJAX requests

The Data Grid provides a seamless way to bind data from external sources using AJAX requests, facilitating CRUD (Create, Read, Update, Delete) operations with data retrieved from a server. This feature is particularly valuable for sending data to a server for database updates and asynchronously retrieving data without refreshing the entire web page.

To achieve data binding and perform CRUD actions using Ajax requests in the Data Grid, follow these steps:

**Step 1:** To create a new ASP.NET Core Web App(Razor Pages) project named AJAX Request, follow these steps:

* Open Visual Studio.
* Select “Create a new project”
* Choose ASP.NET Core Web App(Razor Pages) project template.
* Name the project **AJAXRequest**.
* Click “Create”
**Step 2:**  Create a simple Grid by following the [Getting Started documentation link](https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core).

**Step 3:**  In the **Pages/Index.cshtml** file, follow the steps below.

A. To bind data from an external AJAX request, utilize the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property of the Grid. Get data from the server and provide it to the `dataSource` property using the `onSuccess` event of the AJAX request.

B. To perform CRUD actions, leverage the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event. The default CRUD operations can be cancelled by utilizing the **cancel** argument provided by this event. This allows dynamic calling of the server-side method using AJAX, along with the relevant data received from the `actionBegin` event, to update the server data accordingly.

C. In the AJAX success event, there is flexibility to utilize the Grid `endEdit` and `deleteRecord` methods to handle the addition, editing, and deletion of corresponding data in the Grid. However, invoking these methods triggers the `actionBegin` event once again to save the changes in the Grid. To prevent this behavior and maintain control over the execution flow, a flag variable can be employed and managed within the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) and AJAX failure events: The following code snippet demonstrates this approach:

```ts
@{
    string fullUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}{Request.Path}";
}
@Html.AntiForgeryToken()
<div style="padding: 10px 0px 20px 0px">
    <ejs-button id="sample" cssClass="e-success" content="Bind data via ajax"></ejs-button>
</div>
<ejs-grid id="grid" height="348px" actionComplete="actionComplete" actionBegin="actionBegin" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Cancel", "Update" })">
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" isPrimaryKey="true" textAlign="Right" width="120"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="ShipCountry" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
    let flag = false;
    document.getElementById('sample').onclick = function () {
        var grid = document.getElementById("grid").ej2_instances[0];
        const ajax = new ej.base.Ajax({
            url: '@fullUrl?handler=Getdata',
            type: "POST",
            beforeSend: function (xhr) {
                ajax.httpRequest.setRequestHeader("XSRF-TOKEN",document.querySelector('input[type="hidden"][name="__RequestVerificationToken"]').value);
            },
            contentType: "application/json",
        });
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
                    url: '@fullUrl?handler=Insert',
                    type: 'POST',
                    beforeSend: function (xhr) {
                        ajax.httpRequest.setRequestHeader("XSRF-TOKEN",document.querySelector('input[type="hidden"][name="__RequestVerificationToken"]').value);
                    },
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
                    url: '@fullUrl?handler=Update',
                    type: 'POST',
                    beforeSend: function (xhr) {
                        ajax.httpRequest.setRequestHeader("XSRF-TOKEN",document.querySelector('input[type="hidden"][name="__RequestVerificationToken"]').value);
                    },
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
                    url: '@fullUrl?handler=Delete',
                    beforeSend: function (xhr) {
                        ajax.httpRequest.setRequestHeader("XSRF-TOKEN",document.querySelector('input[type="hidden"][name="__RequestVerificationToken"]').value);
                    },
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

**Step 4:**  In the **Index.cshtml.cs** file, there is a method named **OnPostGetdata** that provides the data source for the Grid. When the button is clicked, an AJAX request is sent to retrieve the data from the server and bind it to the Grid. Additionally, implement server-side logic to perform add, edit, and delete operations. Add the following code:

```cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using AJAXRequest.Models;

namespace AJAXRequest.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {

        }

        public ActionResult OnPostGetdata()
        {
            IEnumerable DataSource = OrdersDetails.GetAllRecords();
            return new JsonResult(DataSource);
        }

        public ActionResult OnPostUpdate([FromBody] CRUDModel<OrdersDetails> value)
        {
            var ord = value.value;
            OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.Freight = ord.Freight;
            val.OrderDate = ord.OrderDate;
            val.ShipCity = ord.ShipCity;
            val.ShipCountry = ord.ShipCountry;
            return new JsonResult(value.value);
        }

        //Insert the record.
        public ActionResult OnPostInsert([FromBody] CRUDModel<OrdersDetails> value)
        {
            OrdersDetails.GetAllRecords().Insert(0, value.value);
            return new JsonResult(value.value);
        }

        //Delete the record.
        public ActionResult OnPostDelete(int key)
        {
            OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == key).FirstOrDefault());
            var data = OrdersDetails.GetAllRecords();
            return new JsonResult(data);
        }

        public class CRUDModel<T> where T : class
        {
            public string action { get; set; }
            public string table { get; set; }
            public string keyColumn { get; set; }
            public object key { get; set; }
            public T value { get; set; }
            public List<T> added { get; set; }
            public List<T> changed { get; set; }
            public List<T> deleted { get; set; }
            public IDictionary<string, object> @params { get; set; }
        }
    }
}

```

**Step 5:** Create a model class named **OrdersDetails.cs** under the Models folder in the server-side project to represent the order data. Add the following code:

```cs

namespace AJAXRequest.Models
{
    public class OrdersDetails
    {
        public static List<OrdersDetails> order = new List<OrdersDetails>();
        public OrdersDetails()
        {
        }

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
            if (order.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 5; i++)
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
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCountry { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}

```

**Step 6:** In the **Program.cs** file, add the following code:

```cs
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();

```

## Display the loading indicator using AJAX

The Syncfusion ASP.NET Core Grid allows displaying a loading indicator while loading data using AJAX. This feature is useful when there is a delay in loading data, to indicate that the data is being fetched. This is particularly beneficial when working with large datasets or under conditions of slower internet connections.

To display the loading indicator with local data, set the `showSpinner` property to **true**. This property controls the visibility of the loading indicator.

The following example demonstrates displaying the loading indicator in the Grid using the [load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) and [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) events:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata-indicator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/grid/data-binding/localdata-indicator/databindcore.cs %}
{% endhighlight %}
{% endtabs %}

## Managing spinner visibility during data loading

Showing a spinner during data loading in the Data Grid enhances the experience by providing a visual indication of the loading progress. This feature helps to understand that data is being fetched or processed.

To show or hide a spinner during data loading in the Grid, use the `showSpinner` and `hideSpinner` methods provided by the Data Grid component.

The following example demonstrates showing and hiding the spinner during data loading using external buttons in a grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata-spinner/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata-spinner/localcore.cs %}
{% endhighlight %}
{% endtabs %}

## Immutable mode

Immutable mode in the Data Grid is designed to optimize re-rendering performance by utilizing the object reference and deep compare concept. This mode ensures that when performing grid actions, only the modified or newly added rows are re-rendered, preventing unnecessary re-rendering of unchanged rows.

Enable immutable mode by setting [enableImmutableMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableImmutableMode) to `true`.

If immutable mode is not enabled, both newly added rows and existing rows are regenerated or reused when the datasource changes. As a result, the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) and [rowDataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) events trigger for both newly added and existing rows. 

> This feature uses the primary key value for data comparison. Therefore, the `isPrimaryKey` column must be provided.

The following example demonstrates enabling immutable mode in an Angular component. When add, delete, or update actions are performed, existing rows are not regenerated or reused, ensuring efficient rendering of only the modified or newly added rows:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/immutable-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Immutable.cs" %}
{% include code-snippet/grid/data-binding/immutable-mode/immutablecore.cs %}
{% endhighlight %}
{% endtabs %}

![Immutable mode](../images/data-binding/databinding-immutable.gif)

### Immutable mode constraints

Immutable mode updates only the rows whose data has changed to improve rendering performance. As a result, features that rely on complex layouts, advanced rendering scenarios, data processing operations, or interactive grid behaviors may not function as expected.

## ExpandoObject binding

The Syncfusion ASP.NET Core Grid is typically bound to a specific model type. However, there are scenarios where the model type is unknown during compile time. In such cases, data can be bound to the Grid using a list of ExpandoObject. This allows for dynamic data structures that can adapt to various data shapes without a predefined schema.

To bind an `ExpandoObject` to the Grid, assign it to the `dataSource` property. The Grid supports various data operations such as sorting, filtering, and editing when using `ExpandoObject`.

The following sample demonstrates ExpandoObject binding:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}

## ExpandoObject with complex column binding

This feature is useful for binding complex data structures to the Syncfusion ASP.NET Core Grid. Complex data binding can be achieved with ExpandoObject by using the dot (.) operator in the `column.field` property. This allows accessing nested properties within the ExpandoObject.

In the following example, the fields **Customer.CustomerID**, **Customer.OrderDate**, **Customer.Freight**, and **Customer.ShipCountry** represent complex data bound to the Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/expandoObjectcore.cs %}
{% endhighlight %}
{% endtabs %}

> Perform data and CRUD operations for complex ExpandoObject binding fields as well.

## DynamicObject binding

The Syncfusion ASP.NET Core Grid is typically bound to a specific model type. However, there are scenarios where the model type is unknown during compile time. In such cases, data can be bound to the Grid using a list of ExpandoObject. This allows for dynamic data structures that can adapt to various data shapes without a predefined schema.

To bind an `ExpandoObject` to the Grid, assign it to the `dataSource` property. This enables the Grid to perform various supported data operations and editing on the DynamicObject.

N> The [GetDynamicMemberNames](https://learn.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject.getdynamicmembernames?view=netcore-3.1) method of the DynamicObject class must be overridden and return the property names to perform data operation and editing while using DynamicObject.

The following example demonstrates binding a list of DynamicObject to the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/dynamicObjectcore.cs %}
{% endhighlight %}
{% endtabs %}

## DynamicObject with complex column binding

Complex data binding can be achieved with DynamicObject in the Syncfusion ASP.NET Core Grid by using the dot (.) operator in the `column.field` property. This allows accessing and binding to nested properties within the DynamicObject, enabling the display of structured data in the Grid.

In the following example, **Customer.OrderDate**, **Customer.Freight**, and **Customer.ShipCountry** are considered complex data fields that are bound to the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/dynamicObjectcore.cs %}
{% endhighlight %}
{% endtabs %}

> Perform data and CRUD operations for complex DynamicObject binding fields as well.

