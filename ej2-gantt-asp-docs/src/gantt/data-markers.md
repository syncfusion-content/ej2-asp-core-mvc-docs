---
title: "Data Markers"
component: "Gantt"
description: "Learn how to provide information about data point in the Essential JS 2 Gantt control."
---

# Data markers

Data markers are a set of events used to represent the schedule events for a task. Data markers are defined in data source as array of objects, and this value is mapped to the Gantt control using the [`taskFields.indicators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Indicators) property. You can represent more than one data marker in a task.

Data markers can be defined using the following properties:

* `date`: Defines the date of indicator.
* `iconClass`: Defines the icon class of indicator.
* `name`: Defines the name of indicator.
* `tooltip`: Defines the tooltip of indicator.

>Note: Data Marker `tooltip` will be rendered only if tooltip property has value.

The following code example demonstrates how to implement data markers in the Gantt chart.

{% aspTab template="gantt/datamarkers/datamarkers", sourceFiles="datamarkers.cs" %}

{% endaspTab %}

![Alt text](images/indicators.PNG)