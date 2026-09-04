---
layout: post
title: ##Platform_Name## Grid Custom Binding | Syncfusion
description: Learn how to perform custom binding in ##Platform_Name## Data Grid with remote data sources, delegate operations, and manage data flow efficiently.
platform: ej2-asp-core-mvc
control: Custom Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom Data Binding in ##Platform_Name## Data Grid

The custom binding feature in the Data Grid enables managing a custom API for handling data processing externally and then binding the resulting data to the Grid. When using custom binding, the Data Grid expects the result to be an object with `result` (array of records to display) and `count` (total number of records) properties. 

The Data Grid component offers a range of powerful features such as **paging**, **grouping**, **sorting**, and **filtering**. These actions trigger the [dataStateChange](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange)  event. CRUD actions such as **Create**, **Read**, **Update**, and **Delete** trigger the [dataSourceChanged](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSourceChanged) event. These events provide an opportunity to manage and manipulate data according to interactions.

**Using the `DataStateChange` event**

The `dataStateChange` event triggers whenever actions modify the grid's data state, such as changing pages, applying sorting, or grouping. This event provides detailed information about the performed action and current grid state, including parameters like page number, sorting details, and filtering criteria.

To implement the `dataStateChange` event effectively:

1. **Subscribe to the event:** In the component code, subscribe to the `dataStateChange` event using the appropriate event handler function. This function is executed whenever the grid is interacted with.

2. **Handle data state:** Inside the event handler function, the event arguments can be accessed to determine the specific actions and intentions. The action property of the event arguments indicates the type of action performed (e.g., paging, sorting, grouping).

> The `dataStateChange` event will not be triggered during the initial rendering.

## Handling searching

When performing a search operation in the grid, the [dataStateChange](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, allowing access to the following referenced arguments within the event.

![Searching](../images/databinding/remote-search.png)

The grid's data state during a search action can be updated using the following approach:

```typescript
// Apply searching 
const applySearching = (query, search)=> {
  // Check if a search operation is requested
  if (search && search.length > 0) {
    // Extract the search key and fields from the search array
    const { fields, key } = search[0];
    // perform search operation using the field and key on the query
    query.search(key, fields);
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // search
  if (state.search) {
    applySearching(query, state.search);
  };
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with the fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
  }
```
## Handling filtering

When filtering operation is performed in the grid, the [dataStateChange](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, providing access to the following referenced arguments within the event.

![FilterBar](../images/databinding/remote-filtering.png)

The filter action's updated data state can be applied as shown below:

```typescript
// Apply filtering
const applyFiltering = (query, filter)=> {
// Check if filter columns are specified
  if (filter.columns && filter.columns.length) {
    // Apply filtering for each specified column
    for (let i = 0; i < filter.columns.length; i++) {
      const field = filter.columns[i].field;
      const operator = filter.columns[i].operator;
      const value = filter.columns[i].value;
      query.where(field, operator, value);
    }
  }
  else {
    // Apply filtering based on direct filter conditions
    for (let i = 0; i < filter.length; i++) {
      const { fn, e } = filter[i];
      if (fn === 'onWhere') {
        query.where(e as string);
      }
    }
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // filter
  if (state.where) {
    applyFiltering(query, action.queries);
  }
  query.isCountRequired = true

  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with the fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

![Filtering Multiple Values](../images/databinding/remote-multiplefilter.png)

## Handling sorting

When sorting operation is performed in the grid, the `dataStateChange` event is triggered, and within this event, the following referenced arguments can be accessed.

![Sorting](../images/databinding/remote-sorting.png)

When performing multi-column sorting, the following referenced arguments are available in the `dataStateChange` event.

![Multi Sorting](../images/databinding/remote-multiplesort.png)

The grid's data state during a sort action can be updated using the following approach:

```typescript
// Apply sorting
const applySorting = (query, sorted) =>{
  // Check if sorting data is available
  if (sorted && sorted.length > 0) {
    // Iterate through each sorting info
    sorted.forEach(sort => {
      // Get the sort field name either by name or field
      const sortField = sort.name || sort.field;
      // Perform sort operation using the query based on the field name and direction
      query.sortBy(sortField, sort.direction);
    });
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // sort
  if (state.sorted) {
    state.sorted.length ? applySorting(query, state.sorted) :
      // initial sorting
      state.sorted.columns.length ? applySorting(query, state.sorted.columns) : null
  }
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with the fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

## Handling paging

When paging operation is performed in the grid, the [dataStateChange](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, and within this event, the following referenced arguments can be accessed.

![Paging](../images/databinding/remote-paging.png)

The grid's data state for a paging action can then be updated using the following approach:

```typescript
// Apply paging
const applyPaging = (query, state)=> {
  // Check if both 'take' and 'skip' values are available
  if (state.take && state.skip) {
    // Calculate pageSkip and pageTake values to get pageIndex and pageSize
    const pageSkip = state.skip / state.take + 1;
    const pageTake = state.take;
    query.page(pageSkip, pageTake);
  }
  // If only 'take' is available and 'skip' is 0, apply paging for the first page.
  else if (state.skip === 0 && state.take) {
    query.page(1, state.take);
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // page
  applyPaging(query, state)
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with the fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

## Handling grouping

When grouping operation is performed in the grid, the [dataStateChange](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event is triggered, providing access to the following referenced arguments within the event.

![Grouping](../images/databinding/remote-group.png)

The grid's data state during a group action can be updated using the following approach:

```typescript
// Apply grouping
const applyGrouping = (query, group) =>{
  // Check if sorting data is available
  if (group.length > 0) {
    // Iterate through each group info
    group.forEach((column: string) => {
      // perform group operation using the column on the query
      query.group(column);
    });
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // grouping
  if (state.group) {
    state.group.length ? applyGrouping(query, state.group) :
      // initial grouping
      state.group.columns.length ? applyGrouping(query, state.group.columns) : null
  }
  query.isCountRequired = true

  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with the fetched data
      const dataManager = new DataManager(data.result);

      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);

      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

> * In order to utilize group actions, it is necessary to manage the sorting query within the service.

**Lazy load grouping**

In ASP.NET Core, lazy loading refers to the technique of loading data dynamically when it is needed, instead of loading everything upfront. Lazy load grouping allows loading and displaying grouped data efficiently by fetching only the required data on demand. 

To enable this feature, set the [groupSettings.enableLazyLoading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_EnableLazyLoading) property to `true`. Also, manage the state based on the initial grid action as follows.

```typescript
const state = { skip:0, take: 12, group: { enableLazyLoading: true, columns: ['ProductName'], showGroupedColumn: true }};
```

Based on the initial state, the arguments are available as shown below.

![Lazy load group](../images/databinding/remote-lazyload.png)

The grid state can be changed as follows:

```typescript
// Apply grouping
const applyGrouping = (query, group) =>{
  // Check if sorting data is available
  if (group.length > 0) {
    // Iterate through each group info
    group.forEach((column: string) => {
      // perform group operation using the column on the query
      query.group(column);
    });
  }
}
// Apply lazy load grouping
const applyLazyLoad = (query, payload) => {
  // Configure lazy loading for the main data
  if (payload.isLazyLoad) {
    query.lazyLoad.push({ key: 'isLazyLoad', value: true });
    // If on-demand group loading is enabled, configure lazy loading for grouped data
    if (payload.onDemandGroupInfo) {
      query.lazyLoad.push({
          key: 'onDemandGroupInfo',
          value: payload.action.lazyLoadQuery,
      });
    }
  }
}
/** GET all data from the server */
export function getOrders(state, action) {
  const query = new Query();
  // grouping
  if (state.group) {
    state.group.length ? applyGrouping(query, state.group) :
      // initial grouping
      state.group.columns.length ? applyGrouping(query, state.group.columns) : null
  }
  // lazy load grouping
  if (state.group) {
    if (state.isLazyLoad) {
      applyLazyLoad(query, state)
    }
    if (state.group.enableLazyLoading) {
      query.lazyLoad.push({ key: 'isLazyLoad', value: true })
    }
  }
  query.isCountRequired = true
  // Request the data from server using fetch
  return fetch(baseUrl)
    .then(res => res.json())
    .then(data => {
      // Create a DataManager instance with the fetched data
      const dataManager = new DataManager(data.result);
      // Execute local data operations using the provided query
      const result = dataManager.executeLocal(query);
      // Return the result along with the count of total records
      return {
        result: result, // Result of the data
        count: result.count // Total record count based on fetched data length
      };
    });
}
```

> Further information can be accessed in the respective documentation for [lazy load grouping](https://ej2.syncfusion.com/aspnetcore/documentation/grid/grouping/lazy-load-grouping).

## Handling CRUD

The Data Grid component provides powerful options for dynamically inserting, deleting, and updating records, enabling data modification directly within the grid. This feature is useful for performing CRUD (**Create**, **Read**, **Update**, **Delete**) operations seamlessly.

Integrating CRUD Operations

To implement CRUD operations using Syncfusion Grid, follow these steps:

1. **Configure grid settings:** Set up the necessary grid settings, such as editing, adding, and deleting records. Define the toolbar options to facilitate interactions.

2. **Handle data state changes:** Utilize the [dataStateChange](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataStateChange) event to respond to changes in the grid’s data state. This event is triggered whenever the grid is interacted with, such as paging or sorting.

3. **Execute CRUD operations:** Within the event handler for [dataSourceChanged](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSourceChanged), implement logic to handle various CRUD actions based on the action or requestType property of the event arguments.

4. **Call endEdit method:** After performing CRUD operations (adding, editing, or deleting), call the endEdit method to signal the completion of the operation and update the grid accordingly.

**Insert operation**

When an insert operation is performed in the grid, the `dataSourceChanged` event will be triggered, allowing access to the following referenced arguments within the event.

![Insert record](../images/databinding/remote-add.png)

```ts
// add
export function addRecord(order) {
  return fetch(baseUrl , {
    method: "post",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({
      value: order
    })
  })
    .then((data) => {
      return data;
    });
}
```

**Edit operation**

When an edit operation is performed in the grid, the `dataSourceChanged` event will be triggered, providing access to the following referenced arguments within the event.

![Edit record](../images/databinding/remote-edit.png)

```ts
// update
export function updateRecord(order) {
  return fetch(`${baseUrl}/${order.OrderID}`, {
    method: "put",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({
      value: order
    })
  })
    .then(data => {
      return data;
    });
}
```

**Delete operation**

When a delete operation is performed in the grid, the `dataSourceChanged` event will be triggered, allowing access to the following referenced arguments within the event.

![Delete record](../images/databinding/remote-delete.png)

```ts
// delete
export function deleteRecord(primaryKey) {
  return fetch(`${baseUrl}/${primaryKey}`, {
    method: "delete",
    body: JSON.stringify({
      value: primaryKey
    })
  })
  .then(data => {
    return data;
  });
}
```

The following example demonstrates binding custom data to handle grid actions and CRUD operations.

{% tabs %}
{% highlight razor tabtitle="Index.cshtml" %}
{% include code-snippet/grid/data-binding/remote-custom-handle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/grid/data-binding/remote-custom-handle/custombindingcore.cs %}
{% endhighlight %}
{% highlight c# tabtitle="OrdersDetails.cs" %}
{% include code-snippet/grid/data-binding/remote-custom-handle/OrdersDetails.cs %}
{% endhighlight %}
{% endtabs %}

The following screenshot represents the grid action with custom binding
![Grid with Custom Binding](../images/databinding/remote-custom-binding.gif)

> * While working with grid edit operation, defining the `isPrimaryKey` property of column is a mandatory step. In case the primary key column is not defined, the edit or delete action will take place on the first row of the grid.
> * Need to maintain the same instance for all grid actions.

## Creating an API service

To configure a server with Syncfusion ASP.NET Core Grid, follow the below steps:

**Step 1:** To create a new ASP.NET Core Web App(Razor Pages) project named CustomBinding, follow these steps:

* Open Visual Studio.
* Select “Create a new project”
* Choose ASP.NET Core Web App(Razor Pages) project template.
* Name the project **CustomBinding**.
* Click “Create”

**Step 2:**  Create a simple ASP.NET Core Grid by following the [Getting Started documentation link](https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core).

**Step 3:**  Create a model class named **OrdersDetails.cs** under the Models folder in the server-side project to represent the order data. Add the following code.

```cs
  public class OrdersDetails
  {
    public static List<OrdersDetails> order = new List<OrdersDetails>();
    public OrdersDetails() { }
    public OrdersDetails(int orderID, string customerId, int productID, string productName)
    {
      this.OrderID = orderID;
      this.CustomerName = customerId;
      this.ProductID = productID;
      this.ProductName = productName;
    }
    public static List<OrdersDetails> GetAllRecords()
    {
      if (order.Count() == 0)
      {
        int code = 10000;
        for (int i = 1; i < 5; i++)
        {
          order.Add(new OrdersDetails(code + 1, "Maria", 1, "Chai"));
          order.Add(new OrdersDetails(code + 2, "Ana Trujillo", 2, "Chang"));
          order.Add(new OrdersDetails(code + 3, "Patricio Simpson", 3, "Aniseed Syrup"));
          order.Add(new OrdersDetails(code + 4, "Ana Trujillo", 4, "Chef Anton's Cajun Seasoning"));
          order.Add(new OrdersDetails(code + 5, "Georg Pipps", 5, "Grandma's Boysenberry Spread"));
          order.Add(new OrdersDetails(code + 6, "Peter Franken", 5, "Chef Anton's Cajun Seasoning"));
          order.Add(new OrdersDetails(code + 7, "Paul Henriot", 5, "Mishi Kobe Niku"));
          order.Add(new OrdersDetails(code + 8, "Marie Bertrand", 5, "Northwoods Cranberry Sauce"));
          order.Add(new OrdersDetails(code + 9, "Palle Ibsen", 5, "Carnarvon Tigers"));
          order.Add(new OrdersDetails(code + 10, "Rita Müller", 5, "CFlotemysost"));
          code += 10;
          }
        }
        return order;
    }
    public int? OrderID { get; set; }
    public string? CustomerName { get; set; }
    public int? ProductID { get; set; }
    public string? ProductName { get; set; }
  }
  
```

**Step 4:** In the **Index.cshtml.cs** file, add the following code to the GetOrderData method to return the result and count:

```cs
 public class IndexModel : PageModel
 {
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public JsonResult OnPostGetOrderData()
    {
      // Get all order records
      IEnumerable<OrdersDetails> dataSource = OrdersDetails.GetAllRecords();
      // Get the total count of records
      int totalCount = dataSource.Count();
      // Return a JSON object with both the result and the count
      return new JsonResult(new { result = dataSource, count = totalCount });
    }
 }
```

**Step 5:** In the **Pages/Index.cshtml** file, handle CRUD operations and grid actions using Syncfusion’s DataManager to fetch and manipulate data. Add the following code:

```ts
<ejs-grid id="grid" created="created" allowPaging="true" dataStateChange="dataStateChange">
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" isPrimaryKey="true" textAlign="Right" width="140"></e-grid-column>
        <e-grid-column field="CustomerName" headerText="Customer Name" width="150"></e-grid-column>
        <e-grid-column field="ProductID" headerText="Product ID" textAlign="Right" width="140"></e-grid-column>
        <e-grid-column field="ProductName" headerText="Product Name" textAlign="Right" width="140"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
<script>
    var gridData;
    var state = {
        skip: 0,
        take: 12
    };
    function created() {
        dataStateChange(state)
    }
    function dataStateChange(state) {
        const grid = document.getElementById("grid").ej2_instances[0];
        const query = grid.getDataModule().generateQuery();
        getOrders(state, query).then(gridData => {
            grid.dataSource = gridData.result;
        });
    }
    function getOrders(state, action) {
        const query = new ej.data.Query();
        // page
        applyPaging(query, state)
        query.isCountRequired = true

        var fetchRequest = new ej.base.Fetch({
            url: `@fullUrl?handler=GetOrderData`,
            type: 'POST',
            beforeSend: function (args) {
                args.fetchRequest.headers.set('XSRF-TOKEN', document.querySelector('input[type = "hidden"][name = "__RequestVerificationToken"]').value);
            },

        })
        return fetchRequest.send()
            .then(data => {
                // Create a DataManager instance with the fetched data
                gridData = new ej.data.DataManager(data.result);
                // Execute local data operations using the provided query
                const result = gridData.executeLocal(query);
                // Return the result along with the count of total records
                return {
                    result: result, // Result of the data
                    count: result.count // Total record count based on fetched data length
                };
            });
    }
    const applyPaging = (query, state) => {
        // Check if both 'take' and 'skip' values are available
        if (state.take && state.skip) {
            // Calculate pageSkip and pageTake values to get pageIndex and pageSize
            const pageSkip = state.skip / state.take + 1;
            const pageTake = state.take;
            query.page(pageSkip, pageTake);
        }
        // If if only 'take' is available and 'skip' is 0, apply paging for the first page.
        else if (state.skip === 0 && state.take) {
            query.page(1, state.take);
        }
    }
</script> 

```

When filtering multiple values, the predicates are available as arguments in the `dataStateChange` event. Predicate execution can be created based on the predicates values.

## Export all records on the client side

Exporting all records with async pipe proves especially beneficial when dealing with large datasets that require export for offline analysis or sharing purposes.

By default, the Syncfusion Grid component exports only the records on the current page. However, the Syncfusion ASP.NET core Grid component allows exporting all records, including those from multiple pages, by configuring the `pdfExportProperties` and `excelExportProperties`.

To export all records, including those from multiple pages, configure the `pdfExportProperties.dataSource` for PDF exporting and `excelExportProperties.dataSource` for Excel exporting within the [toolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event handler. Inside this event, set the `dataSource` property of `pdfExportProperties` and `excelExportProperties` for PDF and Excel exporting to include all records.

**Excel Exporting**

To export the complete Grid data to Excel document, utilize the `excelExportProperties.dataSource` when initiating the Excel export. Use the following code snippet to export all records within the grid:

```typescript
  const grid = document.getElementById("grid").ej2_instances[0];
  getOrders(state).then((event) => {
    let excelExportProperties = {
      dataSource: event.result.result
    };
    grid.excelExport(excelExportProperties);
  });
```

**PDF Exporting**

To export the complete Grid data to PDF document, utilize the `pdfExportProperties.dataSource` when initiating the PDF export. Use the following code snippet to export all records within the grid:

```typescript
  const grid = document.getElementById("grid").ej2_instances[0];
  getOrders(state).then((event) => {
    let pdfExportProperties = {
      dataSource: event.result.result
    };
    grid.pdfExport(pdfExportProperties);
  });
```

> For further customization on Grid export, refer to the respective documentation for [PDF exporting](https://ej2.syncfusion.com/aspnetcore/documentation/grid/pdf-export/pdf-export-options) and [Excel exporting](https://ej2.syncfusion.com/aspnetcore/documentation/grid/excel-export/excel-export-options)

The following code example demonstrates exporting all records on the client side.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/remote-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="remotedata.cs" %}
{% include code-snippet/grid/data-binding/remote-export/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

## Offline mode

On remote data binding, all grid actions such as paging, sorting, editing, grouping, filtering, etc., process on server-side. To avoid post back for every action, set the grid to load all data on initialization and make the actions process in client-side. To enable this behavior, set the `offline` property of `e-data-manager` tag helper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/offline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Offline.cs" %}
{% include code-snippet/grid/data-binding/offline/offline.cs %}
{% endhighlight %}
{% endtabs %}

## Fetch result from the DataManager query using external button 

By default, Data Grid automatically binds a remote data source using the `DataManager`. However, in some scenarios, it may be required to fetch data dynamically from the server using a query triggered by an external button. This approach allows greater control over when and in what manner data loads into the grid.

To achieve this, the `executeQuery` method of `DataManager` with a `Query` object can be used. This method allows running a custom query and retrieving results dynamically.

The following example demonstrates the process of fetching data from the server when an external button is clicked and displaying a status message indicating the data fetch status:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@page
@model IndexModel
<div id='container'>
  <ejs-button id="fetchButton" cssClass="e-primary" content="Execute Query"></ejs-button>
  <p id="statusMessage" style="text-align:center;color:blue"></p>
  <ejs-grid id="Grid">
    <e-grid-columns>
      <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right"></e-grid-column>
      <e-grid-column field="CustomerID" headerText="Customer ID" width="160"></e-grid-column>
      <e-grid-column field="EmployeeID" headerText="Employee ID" width="120" textAlign="Right"></e-grid-column>
      <e-grid-column field="Freight" headerText="Freight" width="150" format="C2" textAlign="Right"></e-grid-column>
      <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
  </ejs-grid>
</div>
<script>
  document.addEventListener("DOMContentLoaded", function () {
    let SERVICE_URL = 'https://ej2services.syncfusion.com/production/web-services/api/Orders';
    let statusMessage = document.getElementById("statusMessage");

    fetchButton.addEventListener("click", function () {
      statusMessage.textContent = "Fetching data...";
      var grid = document.getElementById("Grid")?.ej2_instances?.[0];
      let getData = new ej.data.DataManager({
        url: SERVICE_URL,
        adaptor: new ej.data.WebApiAdaptor()
      });
      getData.executeQuery(new ej.data.Query()).then(function (e) {
        grid.dataSource = e.result;
        statusMessage.textContent = "Data fetched successfully! Total Records: " + e.result.length;
        statusMessage.style.color = "green";
      }).catch(function () {
        statusMessage.textContent = "Error fetching data!";
        statusMessage.style.color = "red";
      });
    });
  });
</script>

{% endhighlight %}
{% endtabs %}

![Fetch result from DataManager Query](../images/databinding/fetch-data.png)
