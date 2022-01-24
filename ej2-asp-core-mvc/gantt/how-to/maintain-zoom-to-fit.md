---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Maintain Zoom To Fit of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Maintain Zoom To Fit
publishingplatform: ##Platform_Name##
documentation: ug
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