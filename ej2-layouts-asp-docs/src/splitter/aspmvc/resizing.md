---
title: "Resize"
component: "Splitter"
description: "This section explain about split panes resizing behaviors."
---

# Resize

By default, resizing will be enable for split panes. Resizing gripper element will be add to the separator to makes the resize easy.

> Horizontal splitter will allows to resize in horizontal directions.
> Vertical splitter will allows to resize in vertical directions.

While resizing, previous and next panes will be adjust its dimensions automatically.

## Min and Max validation

Splitter allows you to set the minimum and maximum sizes for each pane. Resizing will not be occur over the minimum and maximum values.

{% aspTab template="splitter/resize-min-max", sourceFiles="controller.cs" %}

{% endaspTab %}

## Prevent resizing

You can disable the resizing for the pane by setting `false` to the [`Resizable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.SplitterPaneBuilder.html#Syncfusion_EJ2_Layouts_SplitterPaneBuilder_Resizable_System_Boolean_) API within [`PaneSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings).

{% aspTab template="splitter/disable-resize", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Prevent resizing](./images/disable-resize.png)

## Refresh content on resizing

While resizing the panes, you can refresh the pane contents by using either [`ResizeStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_ResizeStart) , [`Resizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_Resizing) or [`ResizeStop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_ResizeStop) events.

## Customize the resize grip and cursor

You can customize the resize gripper icon and cursor in css level.

{% aspTab template="splitter/resize-icon", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Customize the resize grip and cursor](./images/resize-icon.png)

## See Also

* [Resizable split panes](./expand-and-collapse)