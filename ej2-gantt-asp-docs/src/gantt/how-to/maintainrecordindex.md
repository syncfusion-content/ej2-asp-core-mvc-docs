---
title: "How To"
component: "Gantt"
description: "Learn how to update record index while drag and drop on server side in Gantt control."
---

# Updating row drag and dropped index position on server side

Row dropped record's index position can be maintained in the Gantt chart by changing the database table index position using the `rowDrop` event. In this event, the `fromIndex` and `dropIndex` values can be passed to the server side using Ajax request. On the server side, the `insert` and `insertAtTop` methods are used to update the row index position. The following code snippets explain the solution.

{% aspTab template="gantt/how-to/maintainrecordindex", sourceFiles="maintainrecordindex.cs" %}

{% endaspTab %}