---
title: "Autocomplete For"
component: "AutoComplete"
description: "This section explains how to render AutoCompleteFor component."
---

# AutoCompleteFor

The AutoCompleteFor control can be rendered by passing values and data from the model. The selected values can be retrieved during form submit using the post method.

In the following sample, AutoCompleteFor control is rendered.

{% aspTab template="autocomplete/how-to/For", sourceFiles="Countries.cs,For.cs" %}

{% endaspTab %}

## Data Annotation

Data Annotations help us to define the rules to the model classes or properties for data validation and displaying suitable messages to end users.

Data Annotations includes built-in validation attributes for different validation rules, which can be applied to the properties of model class. ASP.NET Framework will automatically enforce these validation rules and display validation messages in the view.

Using `value` property gets or sets the value of the selected item in the control.

{% aspTab template="autocomplete/how-to/data-model", sourceFiles="For.cs" %}

{% endaspTab %}
