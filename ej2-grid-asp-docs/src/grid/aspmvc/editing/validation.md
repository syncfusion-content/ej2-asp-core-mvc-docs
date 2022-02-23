# Validation

## Column validation

Column validation allows you to validate the edited or added row data and it display errors for invalid fields before saving data. Grid uses **Form Validator** component for column validation.
You can set validation rules by defining the [`ValidationRules`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ValidationRules).

{% aspTab template="grid/edit/columnvalid", sourceFiles="columnvalid.cs" %}

{% endaspTab %}

## Custom validation

You can define your own custom validation rules for the specific columns by using **Form Validator custom rules**.

In the below demo, custom validation applied for **CustomerID** column.

{% aspTab template="grid/edit/customvalidation", sourceFiles="customvalidation.cs" %}

{% endaspTab %}