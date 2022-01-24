---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Filtering of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

startsWith |Checks whether a value begins with the specified value.
endsWith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notEqual |Checks for the values that are not equal to the specified value.

> By default, the [`SearchSettings.Operator`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSearchSettings~Operator.html) value is `contains`.

### Search by external button

To search the Gantt records from an external button, invoke the `search` method.

{% aspTab template="gantt/searching/externalSearch", sourceFiles="externalSearch.cs" %}

{% endaspTab %}

### Search specific columns

By default, the Gantt control searches all the columns. You can search specific columns by defining the specific column's field names in the [`SearchSettings.Fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSearchSettings~Fields.html) property.

{% aspTab template="gantt/searching/specificColumnSearch", sourceFiles="specificColumnSearch.cs" %}

{% endaspTab %}

> In above sample, you can search only `TaskName` and `Duration` column values.

### Clear search by external button

You can set [`searchSettings.key`](../api/gantt/searchSettings/#key) property as `empty` string, to clear the searched Gantt records from external button.

{% aspTab template="gantt/searching/clearSearch", sourceFiles="clearSearch.cs" %}

{% endaspTab %}