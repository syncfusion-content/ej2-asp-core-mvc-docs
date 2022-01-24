---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Ejfor of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Ejfor
publishingplatform: ##Platform_Name##
documentation: ug
---


# MultiSelectFor

The MultiSelectFor control can be rendered by passing values and data from the model. The selected values can be retrieved during form submit using the post method.

In the following sample, MultiSelectFor control is rendered.

{% aspTab template="multiselect/how-to/For", sourceFiles="Countries.cs,For.cs" %}

{% endaspTab %}

## Data Annotation

Data Annotations help us to define the rules to the model classes or properties for data validation and displaying suitable messages to end users.

Data Annotations includes built-in validation attributes for different validation rules, which can be applied to the properties of model class. ASP.NET Framework will automatically enforce these validation rules and display validation messages in the view.

Using `value` property gets or sets the value of the selected item in the control.

{% aspTab template="multiselect/how-to/data-model", sourceFiles="For.cs" %}

{% endaspTab %}
