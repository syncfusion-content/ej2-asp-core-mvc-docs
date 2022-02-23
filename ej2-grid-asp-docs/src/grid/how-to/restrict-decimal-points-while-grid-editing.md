---
title: "Restrict to type decimal points in a NumericTextBox while editing the numeric column"
component: "Grid"
description: "Learn how restrict to type decimal points in a NumericTextBox while editing the numeric column"
---

# Restrict to type decimal points in a NumericTextBox while editing the numeric column

By default, the number of decimal places will be restricted to two in the NumericTextBox while editing the numeric column. We can restrict to type the decimal points in a NumericTextBox by using the **validateDecimalOnType** and **decimals** properties of NumericTextBox.

In the below demo, while editing the row we have restricted to type the decimal point value in the NumericTextBox of **Freight** column

{% aspTab template="grid/how-to/prevent-decimal-point", sourceFiles="prevent-decimal-point.cs" %}

{% endaspTab %}