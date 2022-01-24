---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Apply Condition Based Hyper Link For Specific Row Or Column of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Apply Condition Based Hyper Link For Specific Row Or Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Apply condition based hyperlink for specific row or column

You can apply conditions for specific row or column using `label` option to show hyperlink option in the pivot table. It can be configured using the `conditionalSettings` option through code behind, during initial rendering. The required settings are:

* `label`: Specifies the header name to get visibility of hyperlink option for row or column.
* `condition`: Specifies the operator type such as equals, greater than, less than, etc.
* `value1`: Specifies the start value.
* `value2`: Specifies the end value.

{% aspTab template="pivot-table/hyper-link/label-conditions", sourceFiles="LabelConditions.cs" %}

{% endaspTab %}
