---
title: "Perform aggregation in Foreign Key Column"
component: "Grid"
description: "Learn how to perform aggregation in Foreign Key Column."
---

# Perform aggregation in Foreign Key Column

Default aggregations are not supported in a foreign key column. You can achieve aggregation for the foreign key column by using the custom aggregates. The following example demonstrates the way to achieve aggregation in foreign key column.

In the following example, The **Employee Name** is a foreign key column and the aggregation for the foreign column was calculated in customAggregateFn.

{% aspTab template="grid/how-to/aggregate-foreign", sourceFiles="aggregate-foreign.cs" %}

{% endaspTab %}
