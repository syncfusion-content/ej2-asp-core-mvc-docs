---
title: "Customizing Filter Dialog by using additional Parameter"
component: "Grid"
description: "Learn how to customize the filter dialog in Grid by using an additional Parameter."
---

# Customizing Filter Dialog by using an additional Parameter

You can customize the default settings of the components which are used in Menu filter by using params of filter property in column definition.
In the below sample, OrderID and Freight Columns are numeric columns, while open the filter dialog then you can see that NumericTextBox with spin button is displayed to change/set the filter value. Now using the params option we hide the spin button in NumericTextBox for OrderID Column.

{% aspTab template="grid/how-to/add-params-for-filtering", sourceFiles="excelfilter.cs" %}

{% endaspTab %}