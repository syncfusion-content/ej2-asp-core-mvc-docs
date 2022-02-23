---
title: "How To"
component: "Gantt"
description: "Learn how to change schedule start date and end date values dynamically in the JS 2 Gantt control."
---
# Change schedule start and end dates

In the Gantt control, you can change the schedule start and end dates by clicking the custom button programmatically using the `updateProjectDates` method. You can pass the start and end dates as method arguments to the `updateProjectDates` method. You can also pass the Boolean value as an additional parameter, which is used to round-off the schedule start and end dates displayed in Gantt timeline.

{% aspTab template="gantt/how-to/changeScheduleDates", sourceFiles="changeScheduleDates.cs" %}

{% endaspTab %}