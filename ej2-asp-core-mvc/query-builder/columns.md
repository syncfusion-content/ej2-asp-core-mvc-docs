---
layout: post
title: Columns in ##Platform_Name## Query Builder Component
description: Learn here all about Columns in Syncfusion ##Platform_Name## Query Builder component and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Column Binding

The column definitions are used as the `DataSource` schema in the Query Builder. This plays a vital role in rendering column values. The query builder operations such as create or delete conditions and create or delete groups are performed based on the column definitions. The `Field` property of the `Columns` is necessary to map the data source values in the query builder columns.

> If the column field is not specified in the data source, the column values will be empty.

## Auto generation

The `Columns` are automatically generated when the `Columns` declaration is empty or undefined while initializing the query builder. All the columns in the `DataSource` are bound as the query builder columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/columns/auto-generation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/columns/auto-generation/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/columns/auto-generation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/columns/auto-generation/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/columns/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/columns/format/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/columns/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/columns/format/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Validations

Validation allows you to validate the conditions and it display errors for invalid fields while using the `validateFields` method. To enable validation in the query builder, set `AllowValidation` to true. Column fields are validated after setting `AllowValidation` to true. So, you should manually configure the validation for Operator and Value fields through `Validation`.

> Set `isRequired` validation for Operator and Value fields.
> Set `min`, `max` values for number values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/columns/validations/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/columns/validations/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/columns/validations/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/columns/validations/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Template

Template allows you to define your own input widgets for columns. To implement the template, you can define the following functions.

* `create`: Creates the custom component.
* `write`: Wire events for the custom component.
* `destroy`: Destroy the custom component.

In the following sample, dropdown is used as the custom component in Payment Mode column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/columns/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/columns/template/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/columns/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/columns/template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

