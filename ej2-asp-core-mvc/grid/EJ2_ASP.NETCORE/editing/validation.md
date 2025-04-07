---
layout: post
title: Validation in ##Platform_Name## Grid Control | Syncfusion
description: Learn here all about Validation in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validation in ASP.NET Core Syncfusion Grid component

Validation is a crucial aspect of data integrity in any application. The ASP.NET Core  Grid component in Syncfusion<sup style="font-size:70%">&reg;</sup> provides built-in support for easy and effective data validation. This feature ensures that the data entered or modified adheres to predefined rules, preventing errors and guaranteeing the accuracy of the displayed information.

## Column validation

Column validation allows you to validate the edited or added row data before saving it. This feature is particularly useful when you need to enforce specific rules or constraints on individual columns to ensure data integrity. By applying validation rules to columns, you can display error messages for invalid fields and prevent the saving of erroneous data. This feature leverages the **Form Validator** component to perform the validation. You can define validation rules using the `columns.validationRules` property to specify the criteria for validating column values.

The following code example demonstrates how to define a validation rule for grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-columnvalid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-columnvalid/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Column validation](../images/editing/validation.png)

## Custom validation

The Custom validation feature is used to define and enforce your own validation rules for specific columns in the Grid. This is achieved by leveraging the utilizing the **Form Validator custom rules**, you can enforce your desired validation logic and display error messages for invalid fields.

In the below demo, custom validation applied for **CustomerID** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-customvalidation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="customvalidation.cs" %}
{% include code-snippet/grid/edit/validation-customvalidation/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation](../images/editing/validation-custom.png)

### Custom validation based on dropdown change

The Custom validation feature in the Grid allows you to apply validation rules and messages to a column based on the value of another column in edit mode. This feature is particularly useful when you need to enforce specific validation criteria that depend on the selection made in a dropdown column.

In the following sample, dropdownlist edit type is used for the **Role** and **Salary** columns. Here, you can apply the custom validation in the **Salary** column based on the value selected in the **Role** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-dropdown-change/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-dropdown-change/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation based on dropdown change](../images/editing/validation-dropdown.gif)

### Custom validation for numeric column

Custom validation for a numeric column Grid is useful when you want to enforce specific validation rules on numeric values in a column. This allows you to define your own validation logic and display custom error messages when the you enters invalid data.

In the following example, custom validation functions, namely **customFunction** and **customFunctionOne**, are defined to check the entered numeric value against your validation criteria. Then, the grid column is configured with the appropriate validation settings using the **freightRules** object, specifying the custom validation functions along with corresponding error messages. Additionally, the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Change) event of the numeric column is bound to the `validate` method of the form element through the edit params. This enables you to trigger validation and display error messages whenever the you modifies the value in the [NumericTextBox](https://ej2.syncfusion.com/aspnetcore/documentation/numerictextbox/getting-started).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-numericcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-numericcolumn/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation for numeric column](../images/editing/validation-numeric.png)

### Custom validation for particular column externally

In Syncfusion ASP.NET Core Grid, you can dynamically apply custom validation rules to specific columns using external UI elements such as a **DropdownList** and a **Checkbox**.

To achieve this follow these steps:

1. Define the **columnsConfig** array with fields, validation rules, and edit types and assign **columnsConfig** to the `grid.columns` property.

2. Use a DropdownList to select the target column and a Checkbox to enable or disable custom validation.

3. When the Checkbox is checked, call the private `addValidation()` method to apply the custom validation rule and retrieve the selected column and update its `validationRules` with a custom function.

4. Use `formObj.addRules()` to apply rules and `formObj.removeRules()` to reset them dynamically.

5. Always apply the default required rule to the primary key **OrderID** regardless of the custom selection.

6. Use the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) method to manage validation before saving data.

These custom validation rules can be linked to specific columns using the `validationRules` property. The rules can be defined externally as functions and applied dynamically to the corresponding column settings in the Grid. By default, the default validation rules will be applied to the columns. Upon enabling the Custom Validation from checkbox, the custom validation will be applied.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/custom-validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/custom-validation/custom-validation.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation for particular column externally](../images/editing/custom-validation.gif)

## Dynamically add or remove validation rules from the form

You can dynamically add or remove validation rules from input elements within a form. This feature is particularly useful when you need to adjust the validation rules based on different scenarios or dynamically changing data.

To add validation rules dynamically to an input element, you can use the `addRules` method. This method enables you to add validation rules to the corresponding input element based on the name attribute.

The following example to demonstrates how to dynamically add or remove a required validation rule for an input field based on a **CheckBox** selection:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-add-remove/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-add-remove/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Dynamically add or remove validation rules from the form](../images/editing/validation-add-remove.png)

> * To remove an existing validation rule from an input element, you can use the `removeRules` method. 

## Change the position of validation error message

By default, the validation error message in Grid is displayed below the input field. However, you have an option to customize its position and display it in a different location. This feature is particularly useful when you want to align the error message according to your application's design and layout.

To change the position of the validation error message in Grid, you can utilize the `customPlacement` event. This event allows you to define a custom logic to position the error message at the desired location.

Here's an example that demonstrates how to change the position of the validation error message to the top of the input field:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="validation.cs" %}
{% include code-snippet/grid/edit/validation-position/validation.cs %}
{% endhighlight %}
{% endtabs %}

![Change the position of validation error message](../images/editing/validation-position.png)

## Show custom error message while performing CRUD actions

While performing CRUD actions in the Syncfusion ASP.NET Core Grid, errors may occur due to various reasons such as validation failures, network issues, or server-side exceptions. Handling these errors effectively is essential for providing meaningful error messages when an operation fails.

To achieve this, you can use the [ActionFailure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event, which is triggered when an action (such as update, delete, or insert) fails. This event allows you to retrieve the error message from the server response and display it in the UI.

The following sample demonstrates how to retrieve and display error messages in the Syncfusion ASP.NET Core Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@page
@model IndexModel

<div><p style="color: red; text-align: center" id="errorMessage"></p></div>
<ejs-grid id="Grid" allowFiltering="true" actionFailure="actionFailure" allowSorting="true" allowPaging="true" toolbar="@(new List<string>() { "Add", "Edit", "Delete", "Update", "Cancel","Search" })">
   //Replace xxxx with your actual port number
    <e-data-manager url='https://localhost:xxxx/api/Grid' insertUrl='https://localhost:xxxx/api/Grid/Insert' updateUrl='https://localhost:xxxx/api/Grid/Update' removeUrl='https://localhost:xxxx/api/Grid/Remove' adaptor="UrlAdaptor">
    </e-data-manager>
    <e-grid-editSettings allowAdding="true" allowDeleting="true" allowEditing="true" mode="Normal"></e-grid-editSettings>
    <e-grid-columns>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="150" type="string"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="Ship City" width="150"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="Ship Country" width="150"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

<script>
let errorMessage = document.getElementById("errorMessage");
function actionFailure(args) {
    if (args.error && Array.isArray(args.error) && args.error.length > 0 && args.error[0].error){
        args.error[0].error.json().then(function (data) {
            errorMessage.innerHTML = data.message || "An unknown error occurred.";
        }).catch(function () {
            errorMessage.innerHTML = "Error occurred, but message could not be retrieved.";
        });
    }
    else{
        errorMessage.innerHTML = "An unexpected error occurred.";
    }
}
</script>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;
using UrlAdaptor.Models;

namespace UrlAdaptor.Controllers
{
    [ApiController]
    public class GridController : Controller
    {
        [HttpPost]
        [Route("api/[controller]")]
        public object Post([FromBody] DataManagerRequest DataManagerRequest)
        {
            // Retrieve data from the data source (e.g., database).
            IQueryable<OrdersDetails> DataSource = GetOrderData().AsQueryable();
            
            // Initialize DataOperations instance.
            QueryableOperation queryableOperation = new QueryableOperation();

            // Handling searching operation.
            if (DataManagerRequest.Search != null && DataManagerRequest.Search.Count > 0)
            {
                DataSource = queryableOperation.PerformSearching(DataSource, DataManagerRequest.Search);
            }

            // Handling filtering operation.
            if (DataManagerRequest.Where != null && DataManagerRequest.Where.Count > 0)
            {
                foreach (var condition in DataManagerRequest.Where)
                {
                    foreach (var predicate in condition.predicates)
                    {
                        DataSource = queryableOperation.PerformFiltering(DataSource, DataManagerRequest.Where, predicate.Operator);
                    }
                }
            }

            // Handling sorting operation.
            if (DataManagerRequest.Sorted != null && DataManagerRequest.Sorted.Count > 0)
            {
                DataSource = queryableOperation.PerformSorting(DataSource, DataManagerRequest.Sorted);
            }

            // Get the total count of records.
            int totalRecordsCount = DataSource.Count();

            // Handling paging operation.
            if (DataManagerRequest.Skip != 0)
            {
                DataSource = queryableOperation.PerformSkip(DataSource, DataManagerRequest.Skip);
            }
            if (DataManagerRequest.Take != 0)
            {
                DataSource = queryableOperation.PerformTake(DataSource, DataManagerRequest.Take);
            }

            // Return data based on the request.
            return new { result = DataSource, count = totalRecordsCount };
        }

        [HttpGet]
        [Route("api/[controller]")]
        public List<OrdersDetails> GetOrderData()
        {
            var data = OrdersDetails.GetAllRecords().ToList();
            return data;
        }

        /// <summary>
        /// Inserts a new data item into the data collection.
        /// </summary>
        /// <param name="addRecord">The order to be inserted.</param>
        /// <returns>It returns the newly inserted record detail.</returns>
        [HttpPost]
        [Route("api/[controller]/Insert")]
        public IActionResult Insert([FromBody] CRUDModel<OrdersDetails> value)
        {
            if (value == null)
            {
                return BadRequest(new { message = "Invalid data received." });
            }
            var existingOrder = OrdersDetails.order.FirstOrDefault(or => or.OrderID == value.value.OrderID);
            if (existingOrder == null)
            {
                OrdersDetails.order.Insert(0, value.value);
                return Ok(new { success = true, message = "Order added successfully.", data = value });
            }
            else
            {
                return BadRequest(new { success = false, message = "Duplicate values cannot be inserted." });
            }
        }

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="updateRecord">The updated order details.</param>
        /// <returns>It returns the updated order details.</returns>
        [HttpPost]
        [Route("api/[controller]/Update")]
        public IActionResult Update([FromBody] CRUDModel<OrdersDetails> Order)
        {
            var updatedOrder = Order.value;

            if (updatedOrder.OrderID < 10010 || updatedOrder.OrderID > 10030)
            {
                return BadRequest(new { message = "OrderID must be between 10010 and 10030 to update." });
            }

            var data = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == updatedOrder.OrderID);
            if (data == null)
            {
                return NotFound(new { message = "Order not found." });
            }

            // Update the existing record.
            data.CustomerID = updatedOrder.CustomerID;
            data.ShipCity = updatedOrder.ShipCity;
            data.ShipCountry = updatedOrder.ShipCountry;
            return Ok(new { success = true, message = "Order updated successfully." });
        }

        /// <summary>
        /// Deletes an order.
        /// </summary>
        /// <param name="deletedRecord">It contains the specific record detail which is need to be removed.</param>
        /// <returns>It returns the deleted record detail.</returns>
        [HttpPost]
        [Route("api/[controller]/Remove")]
        public IActionResult Remove([FromBody] CRUDModel<OrdersDetails> value)
        {
            int orderId;
            if (!int.TryParse(value.key.ToString(), out orderId))
            {
                return BadRequest(new { message = "Invalid OrderID format." });
            }

            if (orderId < 10031 || orderId > 10045)
            {
                return BadRequest(new { message = "OrderID must be between 10031 and 10045 to delete." });
            }

            var data = OrdersDetails.GetAllRecords().FirstOrDefault(orderData => orderData.OrderID == orderId);
            if (data == null)
            {
                return NotFound(new { message = "Order not found." });
            }

            OrdersDetails.GetAllRecords().Remove(data);
            return Ok(new { success = true, message = "Order deleted successfully." });
        }

        public class CRUDModel<T> where T : class
        {
            public string? action { get; set; }
            public string? keyColumn { get; set; }
            public object? key { get; set; }
            public T? value { get; set; }
            public List<T>? added { get; set; }
            public List<T>? changed { get; set; }
            public List<T>? deleted { get; set; }
            public IDictionary<string, object>? @params { get; set; }
        }
    }
}

{% endhighlight %}
{% endtabs %}

![Show custom error message](../images/editing/custom-message.png)

## Prevent adding duplicate rows with custom validation

The Syncfusion ASP.NET Core Grid allows you to enforce constraints to prevent duplicate rows by customizing the validation logic within the Grid setup. This ensures data integrity by restricting duplicate entries in the **OrderID** column.

To prevent adding duplicate rows in the Grid, follow these steps:

1. Implement Custom Validation: Define the `orderIdCustomValidation` function to check whether the entered **OrderID** already exists in the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource). This allows editing an existing row without triggering a duplicate error.

2. Add Dynamic Validation Rules: Create the `orderIDRules` object to enforce unique **OrderID** values. Dynamically add this rule to the form during the **save** action.

3. Handle Validation in the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event: In the `actionBegin` event, check if the **requestType** is **save**. Apply the validation rule before saving and cancel the action `args.cancel = true` if the validation fails.

For server-side validation to prevent adding duplicate rows, you can refer to the detailed guidance provided in our [knowledge base](https://support.syncfusion.com/kb/article/11608/how-to-do-server-side-validation-for-grid-in-asp-net-mvc-application). If you want to display the Grid's validation tooltip instead of the alert used in our knowledge base, you can call the `grid.editModule.formObj.validate()` method in the `Ajax/Fetch` success function to display the Grid's tooltip validation for the server side.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/prevent-add-duplicate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-temp.cs" %}
{% include code-snippet/grid/edit/prevent-add-duplicate/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}

![Prevent Duplicate row](../images/editing/prevent-duplicate-row.png)