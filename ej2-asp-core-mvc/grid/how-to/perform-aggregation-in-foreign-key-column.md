---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Perform Aggregation In Foreign Key Column of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Perform Aggregation In Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---


# Perform aggregation in Foreign Key Column

Default aggregations are not supported in a foreign key column. You can achieve aggregation for the foreign key column by using the custom aggregates. The following example demonstrates the way to achieve aggregation in foreign key column.

In the following example, The `Employee Name` is a foreign key column and the aggregation for the foreign column was calculated in customAggregateFn.

{% aspTab template="grid/how-to/aggregate-foreign", sourceFiles="aggregate-foreign.cs" %}

{% endaspTab %}
