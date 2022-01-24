---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Maintainrecordindex of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Maintainrecordindex
publishingplatform: ##Platform_Name##
documentation: ug
---


# Updating row drag and dropped index position on server side

Row dropped record's index position can be maintained in the Gantt chart by changing the database table index position using the `rowDrop` event. In this event, the `fromIndex` and `dropIndex` values can be passed to the server side using Ajax request. On the server side, the `insert` and `insertAtTop` methods are used to update the row index position. The following code snippets explain the solution.

{% aspTab template="gantt/how-to/maintainrecordindex", sourceFiles="maintainrecordindex.cs" %}

{% endaspTab %}