---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Show Field List When Pivot Table Empty of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Show Field List When Pivot Table Empty
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show field list when pivot table is empty

When there are no fields in a pivot table's row, column, value, and filter axes, a field list can still be displayed. To do so, use the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event and call the `onShowFieldList` method as shown below.

{% aspTab template="pivot-table/summary-customization/edit-type", sourceFiles="EditType.cs" %}

{% endaspTab %}

![output](images/empty-report-all-axes.png)