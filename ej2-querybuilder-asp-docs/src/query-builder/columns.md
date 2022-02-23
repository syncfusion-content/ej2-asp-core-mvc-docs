---
title: "Columns"
component: "QueryBuilder"
description: "Documentation on column  step, format in the Essential JS 2 QueryBuilder control."
---

# Column Binding

The column definitions are used as the `DataSource` schema in the Query Builder. This plays a vital role in rendering column values. The query builder operations such as create or delete conditions and create or delete groups are performed based on the column definitions. The `Field` property of the `Columns` is necessary to map the data source values in the query builder columns.

> If the column field is not specified in the data source, the column values will be empty.

## Auto generation

The `Columns` are automatically generated when the `Columns` declaration is empty or undefined while initializing the query builder. All the columns in the `DataSource` are bound as the query builder columns.

{% aspTab template="query-builder/columns/auto-generation", sourceFiles="default.cs" %}

{% endaspTab %}

> When columns are auto-generated, the column type will be determined from the first record of the data source.

## Labels

By default, the column label is displayed from the column `Field` value. To override the default label, you have to define the `Label` value.

> If both the field and headerText are not defined in the column, the column renders with “empty” header text.

## Operators

The operator for a column can be defined in the columns property.
The available operators and its supported data types are:

| Operators | Description | Supported Types |
| ------------ | ----------------------- | ------------------ |
| startswith  | Checks whether the value begins with the specified value. | String |
| endswith  | Checks whether the value ends with the specified value. | String |
| contains | Checks whether the value contains the specified value. | String |
| equal | Checks whether the value is equal to the specified value. | String|Number/Date/Boolean |
| notequal | Checks for values not equal to the specified value. | String/Number| Date| Boolean |
| greaterthan | Checks whether the value is greater than the specified value. | Date/Number |
| greaterthanorequal | Checks whether a value is greater than or equal to the specified value. | Date/Number |
| lessthan | Checks whether the value is less than the specified value.| Date/Number |
| lessthanorequal | Checks whether the value is less than or equal to the specified value. | Date/Number |
| between | Checks whether the value is between the two-specific value. | Date/Number |
| notbetween | Checks whether the value is not between the two-specific value. | Date/Number |
| in | Checks whether the value is one of the specific values. | String/Number |
| notin | Checks whether the value is not in the specific values. | String/Number |

## Step

The Query Builder allows you to set the step values to the number fields. So that, you can easily access the numeric textbox. Use the `Step` property, to set the step value for number values.

## Format

The Query Builder formats date and number values. Use the `Format`   property, to format date and number values.

{% aspTab template="query-builder/columns/format", sourceFiles="default.cs" %}

{% endaspTab %}

## Validations

Validation allows you to validate the conditions and it display errors for invalid fields while using the `validateFields` method. To enable validation in the query builder, set `AllowValidation` to true. Column fields are validated after setting `AllowValidation` to true. So, you should manually configure the validation for Operator and Value fields through `Validation`.

> Set `isRequired` validation for Operator and Value fields.
> Set `min`, `max` values for number values.

{% aspTab template="query-builder/columns/validations", sourceFiles="default.cs" %}

{% endaspTab %}

## Template

Template allows you to define your own input widgets for columns. To implement the template, you can define the following functions.

* `create`: Creates the custom component.
* `write`: Wire events for the custom component.
* `destroy`: Destroy the custom component.

In the following sample, dropdown is used as the custom component in Payment Mode column.

{% aspTab template="query-builder/columns/template", sourceFiles="default.cs" %}

{% endaspTab %}