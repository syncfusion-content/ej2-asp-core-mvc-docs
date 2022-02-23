---
title: "Header double click"
component: "Kanban"
description: "This article demonstrates how to bind the double click event on Kanban header cells and how to get the header information."
---

# Add header double click

You can bind the header double click event by using the [`dataBound`](../../api/kanban#dataBound) event at the initial rendering. You can get the column header text when you double click on the headers.

{% aspTab template="kanban/how-to/header-double-click", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/header-double-click.PNG)