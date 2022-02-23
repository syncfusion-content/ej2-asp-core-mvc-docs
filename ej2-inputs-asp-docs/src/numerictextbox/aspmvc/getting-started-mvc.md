---
title: "Getting Started"
component: "NumericTextBox"
description: "Rendering numeric textbox using asp.net mvc"
---

# Getting Started

This section briefly explains about how to include a simple NumericTextBox in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started/) page for introduction part part of the system requirements and configure the common specifications.

## Initialize NumericTextBox control to the Application

NumericTextBox component can be rendered by using the `EJS().NumericTextBox()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the NumericTextBox.

The following example shows a basic NumericTextBox component.

{% aspTab template="numeric-textbox/getting-started/getting-started", sourceFiles="demo.cs" %}

{% endaspTab %}

> Running the above code will display the basic NumericTextBox on the browser.

Output be like the below.

![NumericTextBox Sample](./images/gettingStarted.png)

## Range validation

You can set the minimum and maximum range of values in the NumericTextBox using the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Min) and
[max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Max) properties, so the numeric value should be in the min and max range.

The validation behavior depends on the [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_StrictMode) property.

The below example demonstrates range validation.

{% aspTab template="numeric-textbox/getting-started/range", sourceFiles="range.cs" %}

{% endaspTab %}

## Formatting the value

User can set the format of the NumericTextBox component using [format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Format)
property. The value will be displayed in the specified format, when the component is in focused out state. For more information about
formatting the value, refer to this [link](./formats/).

The below example demonstrates format the value by using currency format value `c2`.

{% aspTab template="numeric-textbox/getting-started/format", sourceFiles="format.cs" %}

{% endaspTab %}

Output be like the below.

![NumericTextBox Sample](./images/format.png)

## Precision of numbers

You can restrict the number of decimals to be entered in the NumericTextBox by using the [decimals](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Decimals)
and [validateDecimalOnType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_ValidateDecimalOnType) properties.
So, you can't enter the number whose precision is greater than the mentioned decimals.

* If `validateDecimalOnType` is false, number of decimals will not be restricted.
Else, number of decimals will be restricted while typing in the NumericTextBox.

{% aspTab template="numeric-textbox/getting-started/precision", sourceFiles="precision.cs" %}

{% endaspTab %}

Output be like the below.

![NumericTextBox Sample](./images/precision.png)

## See Also

* [How to perform custom validation using FormValidator](./how-to/perform-custom-validation-using-form-validator/)
* [How to customize the UI appearance of the control](./how-to/customize-the-ui-appearance-of-the-control/)
* [How to customize the spin button’s up and down arrow](./how-to/customize-the-spin-buttons-up-and-down-arrow/)
* [How to customize the step value and hide spin buttons](./how-to/customize-the-step-value-and-hide-spin-buttons/)
* [How to prevent nullable input in NumericTextBox](./how-to/prevent-nullable-input-in-numerictextbox/)
* [How to maintain trailing zeros in NumericTextBox](./how-to/maintain-trailing-zeros-in-numerictextbox/)