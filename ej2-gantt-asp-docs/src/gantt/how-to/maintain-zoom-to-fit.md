---
title: "How To"
component: "Gantt"
description: "Learn how to maintain zoomtofit."
---

# Maintain zoomToFit

In the Gantt control, While performing edit actions or dynamically change dataSource, the timeline gets refreshed. When zoomToFit toolbar item is clicked and perform editing actions or dynamically change dataSource, the timeline gets refreshed. So that, the timeline will not fit to the project any more.

## Maintain zoomToFit after edit actions

We can maintain `zoomToFit` after editing actions(cell edit,dialog edit,taskbar edit) by using `fitToProject` method in `actionComplete` and `taskbarEdited` event.

{% aspTab template="gantt/how-to/maintainzoomtofit", sourceFiles="maintainzoomtofit.cs" %}

{% endaspTab %}

## Maintain zoomToFit after change dataSource dynamically

We can maintain `zoomToFit` after change dataSource dynamically, by calling `fitToProject` method in dataBound event.

{% aspTab template="gantt/how-to/maintainzoomtofitdatasource", sourceFiles="maintainzoomtofitdatasource.cs" %}

{% endaspTab %}