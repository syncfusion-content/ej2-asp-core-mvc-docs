---
layout: post
title: Validation in ##Platform_Name## Grid Control | Syncfusion
description: Learn here all about Validation in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validation in ASP.NET MVC Syncfusion Grid component

Validation is a crucial aspect of data integrity in any application. The ASP.NET MVC Grid component in Syncfusion<sup style="font-size:70%">&reg;</sup> provides built-in support for easy and effective data validation. This feature ensures that the data entered or modified adheres to predefined rules, preventing errors and guaranteeing the accuracy of the displayed information.

## Column validation

Column validation allows you to validate the edited or added row data before saving it. This feature is particularly useful when you need to enforce specific rules or constraints on individual columns to ensure data integrity. By applying validation rules to columns, you can display error messages for invalid fields and prevent the saving of erroneous data. This feature leverages the **Form Validator** component to perform the validation. You can define validation rules using the `Columns.ValidationRules` property to specify the criteria for validating column values.

The following code example demonstrates how to define a validation rule for grid column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-columnvalid/razor %}
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
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-customvalidation/razor %}
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
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-dropdown-change/razor %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-dropdown-change/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation based on dropdown change](../images/editing/validation-dropdown.gif)

### Custom validation for numeric column

Custom validation for a numeric column Grid is useful when you want to enforce specific validation rules on numeric values in a column. This allows you to define your own validation logic and display custom error messages when the you enters invalid data.

In the following example, custom validation functions, namely **customFunction** and **customFunctionOne**, are defined to check the entered numeric value against your validation criteria. Then, the grid column is configured with the appropriate validation settings using the **freightRules** object, specifying the custom validation functions along with corresponding error messages. Additionally, the [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Change) event of the numeric column is bound to the `validate` method of the form element through the edit params. This enables you to trigger validation and display error messages whenever the you modifies the value in the [NumericTextBox](https://ej2.syncfusion.com/aspnetmvc/documentation/numerictextbox/getting-started).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-numericcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-numericcolumn/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Custom validation for numeric column](../images/editing/validation-numeric.png)

## Dynamically add or remove validation rules from the form

You can dynamically add or remove validation rules from input elements within a form. This feature is particularly useful when you need to adjust the validation rules based on different scenarios or dynamically changing data.

To add validation rules dynamically to an input element, you can use the `addRules` method. This method enables you to add validation rules to the corresponding input element based on the name attribute.

The following example to demonstrates how to dynamically add or remove a required validation rule for an input field based on a **CheckBox** selection:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-add-remove/razor %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-add-remove/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Dynamically add or remove validation rules from the form](../images/editing/validation-add-remove.png)

>To remove an existing validation rule from an input element, you can use the `removeRules` method. 

## Change the position of validation error message

By default, the validation error message in Grid is displayed below the input field. However, you have an option to customize its position and display it in a different location. This feature is particularly useful when you want to align the error message according to your application's design and layout.

To change the position of the validation error message in Grid, you can utilize the `CustomPlacement` event. This event allows you to define a custom logic to position the error message at the desired location.

Here's an example that demonstrates how to change the position of the validation error message to the top of the input field:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="validation.cs" %}
{% include code-snippet/grid/edit/validation-position/validation.cs %}
{% endhighlight %}
{% endtabs %}

![Change the position of validation error message](../images/editing/validation-position.png)

## Show custom error message while performing CRUD actions

While performing CRUD actions in the Syncfusion ASP.NET MVC Grid, errors may occur due to various reasons such as validation failures, network issues, or server-side exceptions. Handling these errors effectively is essential for providing meaningful error messages when an operation fails.

To achieve this, you can use the [ActionFailure](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event, which is triggered when an action (such as update, delete, or insert) fails. This event allows you to retrieve the error message from the server response and display it in the UI.

The following sample demonstrates how to retrieve and display error messages in the Syncfusion ASP.NET MVC Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
<div id="errorMessage" class="error-message" style="display:none; color: red; text-align: center"></div>
@*Replace xxxx with your actual port number*@
@Html.EJS().Grid("grid").DataSource(ds => ds.Url("https://localhost:xxxx/Grid/UrlDatasource")
	.InsertUrl("https://localhost:xxxx/Grid/Insert")
	.UpdateUrl("https://localhost:xxxx/Grid/Update")
	.RemoveUrl("https://localhost:xxxx/Grid/Remove")
	.Adaptor("UrlAdaptor")).Columns(col =>
{
	col.Field("OrderID").HeaderText("Order ID").IsPrimaryKey(true).Width("150")
		.TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
	col.Field("CustomerID").HeaderText("Customer Name").Width("150").Add();
	col.Field("Freight").HeaderText("Freight").Width("150").Format("C2")
		.TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
	col.Field("ShipCity").HeaderText("Ship City").Width("150").Add();
}).EditSettings(edit => edit.AllowAdding(true).AllowEditing(true).AllowDeleting(true)).Toolbar(new List<string>
{ "Add", "Edit", "Delete", "Update", "Cancel" }).Height(320).ActionFailure("actionFailure").AllowPaging(true).Render()

<script>
function actionFailure(args) {
	let errorDiv = document.getElementById("errorMessage");
	if (args.error && args.error[0] && args.error[0].error) {
		let response = args.error[0].error;
		response.text().then(errorMessage => {
			// Extract meaningful error message.
			let match = errorMessage.match(/<h3>HTTP Error 400.*? - (.*?)<\/h3>/);
			if (match && match[1]) {
				errorDiv.innerText = match[1]; // Display only the relevant error message.
			} else {
				errorDiv.innerText = "An unexpected error occurred.";
			}
		}).catch(() => {
			errorDiv.innerText = "An unexpected error occurred.";
		});
	} else {
		errorDiv.innerText = "An unexpected error occurred.";
	}
}
</script>

{% endhighlight %}

{% highlight c# tabtitle="GridController.cs" %}

using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Syncfusion.EJ2.Base;
using UrlAdaptor.Models;

namespace UrlAdaptor.Controllers
{
    public class GridController : Controller
    {
        private static List<OrdersDetails> order = OrdersDetails.GetAllRecords();
        /// <summary>
        /// Handles the HTTP POST request to retrieve data from the data source based on the DataManagerRequest.
        /// Supports filtering,searching, sorting, and paging operations (skip and take).
        /// </summary>
        /// <param name="dataManager">Contains the filtering, sorting, and paging options requested by the client.</param>
        /// <returns>Returns the filtered,searched, sorted, and paginated data along with the total record count.</returns>
        [HttpPost]
        public ActionResult UrlDatasource(DataManagerRequest dataManager)
        { 
            // Retrieve data source and convert to queryable.
            IEnumerable<OrdersDetails> DataSource = order;

            // Initialize DataOperations instance.
            DataOperations queryableOperation = new DataOperations();

            // Handling searching operation.
            if (dataManager.Search != null && dataManager.Search.Count > 0)
            {
                DataSource = queryableOperation.PerformSearching(DataSource, dataManager.Search);
            }

            // Handling filtering operation.
            if (dataManager.Where != null && dataManager.Where.Count > 0)
            {
                foreach (var condition in dataManager.Where)
                {
                    foreach (var predicate in condition.predicates)
                    {
                        DataSource = queryableOperation.PerformFiltering(DataSource, dataManager.Where, predicate.Operator);
                    }
                }
            }

            // Handling sorting operation.
            if (dataManager.Sorted != null && dataManager.Sorted.Count > 0)
            {
                DataSource = queryableOperation.PerformSorting(DataSource, dataManager.Sorted);
            }

            // Get the total count of records.
            int totalRecordsCount = DataSource.Count();

            // Handling paging operation.
            if (dataManager.Skip != 0)
            {
                DataSource = queryableOperation.PerformSkip(DataSource, dataManager.Skip);
            }
            if (dataManager.Take != 0)
            {
                DataSource = queryableOperation.PerformTake(DataSource, dataManager.Take);
            }

            // Return result and total record count.
            return dataManager.RequiresCounts ? Json(new { result = DataSource, count = totalRecordsCount }) : Json(DataSource);
        }

        /// <summary>
        /// Inserts a new data item into the data collection.
        /// </summary>
        /// <param name="newRecord">It contains the new record detail which is need to be inserted.</param>
        /// <returns>Returns void.</returns>
        [HttpPost]
        [Route("Grid/Insert")]
        public ActionResult Insert(CRUDModel<OrdersDetails> newRecord)
        {
            if (newRecord != null)
            {
                var existingOrder = order.FirstOrDefault(or => or.OrderID == newRecord.value.OrderID);
                if (existingOrder == null)
                {
                    order.Insert(0, newRecord.value);
                    return Json(new { success = true, message = "Order added successfully.", data = newRecord });
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Duplicate values cannot be inserted.");
                }
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Invalid data received.");
        }

        /// <summary>
        /// Update a existing data item from the data collection.
        /// </summary>
        /// <param name="updateRecord">It contains the updated record detail which is need to be updated.</param>
        /// <returns>Returns void.</returns>
        [HttpPost]
        [Route("Grid/Update")]
        public ActionResult Update(CRUDModel<OrdersDetails> updateRecord)
        {
            if (updateRecord.value == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Invalid data received.");
            }

            // Corrected condition to validate OrderID range.
            if (updateRecord.value.OrderID < 10010 || updateRecord.value.OrderID > 10030)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "OrderID must be between 10010 and 10030 to update.");
            }
            var data = OrdersDetails.GetAllRecords().FirstOrDefault(or => or.OrderID == updateRecord.value.OrderID);
            if (data == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Order not found.");
            }

            // Update the existing record.
            data.CustomerID = updateRecord.value.CustomerID;
            data.Freight = updateRecord.value.Freight;
            data.ShipCity = updateRecord.value.ShipCity;
            data.ShipCountry = updateRecord.value.ShipCountry;
            return Json(new { success = true, message = "Order updated successfully.", data = updateRecord });
        }
        /// <summary>
        /// Remove a specific data item from the data collection.
        /// </summary>
        /// <param name="value">It contains the specific record detail which is need to be removed.</param>
        /// <return>Returns void.</return>
        [HttpPost]
        [Route("Grid/Remove")]
        public ActionResult Remove(CRUDModel<OrdersDetails> value)
        {
            int orderId = int.Parse(value.key.ToString());
            if (orderId < 10031 || orderId > 10045)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "OrderID must be between 10031 and 10045 to delete.");
            }
            var data = OrdersDetails.GetAllRecords().FirstOrDefault(orderData => orderData.OrderID == orderId);
            OrdersDetails.GetAllRecords().Remove(data);
            return Json(new { success = true, message = "Order deleted successfully." });
        }
    }
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
}

{% endhighlight %}
{% endtabs %}

![Show custom error message](../images/editing/custom-message.png)

## Prevent adding duplicate rows with custom validation

The Syncfusion ASP.NET MVC Grid allows you to enforce constraints to prevent duplicate rows by customizing the validation logic within the Grid setup. This ensures data integrity by restricting duplicate entries in the **OrderID** column.

To prevent adding duplicate rows in the Grid, follow these steps:

1. Implement Custom Validation: Define the `orderIdCustomValidation` function to check whether the entered **OrderID** already exists in the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource). This allows editing an existing row without triggering a duplicate error.

2. Add Dynamic Validation Rules: Create the `orderIDRules` object to enforce unique **OrderID** values. Dynamically add this rule to the form during the **save** action.

3. Handle Validation in the [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event: In the `ActionBegin` event, check if the **requestType** is **save**. Apply the validation rule before saving and cancel the action `args.cancel = true` if the validation fails.

For server-side validation to prevent adding duplicate rows, you can refer to the detailed guidance provided in our [knowledge base](https://support.syncfusion.com/kb/article/11608/how-to-do-server-side-validation-for-grid-in-asp-net-mvc-application). If you want to display the Grid's validation tooltip instead of the alert used in our knowledge base, you can call the `grid.editModule.formObj.validate()` method in the `Ajax/Fetch` success function to display the Grid's tooltip validation for the server side.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/prevent-add-duplicate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-temp.cs" %}
{% include code-snippet/grid/edit/prevent-add-duplicate/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}

![Prevent Duplicate row](../images/editing/prevent-duplicate-row.png)