---
layout: post
title: Validation in ##Platform_Name## Grid Component
description: Learn here all about Validation in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validation in ASP.NET MVC Grid component

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

