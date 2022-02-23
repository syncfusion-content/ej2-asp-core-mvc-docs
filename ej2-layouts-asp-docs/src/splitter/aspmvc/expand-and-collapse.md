---
title: "Expand and Collapse"
component: "Splitter"
description: "This section explains about how to configure collapsible splitter panes, which helps to do expand and collapse action dynamically."
---

# Expand and Collapse

## Collapsible panes

The Splitter panes can be configured with built-in expand and collapse functionalities. By default, the `Collapsible` behavior is disabled. Enable the `Collapsible` behavior in the [`PaneSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings) property to show or hide the expand or collapse icons in the panes. You can dynamically expand and collapse the panes by the corresponding icons.

The following code shows how to enable collapsible behavior.

{% aspTab template="splitter/expand-collapse", sourceFiles="controller.cs" %}

{% endaspTab %}

Execution of above code's output will be as given below,

![Expand Collaspe](./images/expand-collapse.png)

## Programmatically control the expand and collapse action

The Splitter provides public method to control the expand and collapse behavior programmatically using the `expand` and `collapse` methods. Refer to the following code sample.

{% aspTab template="splitter/expand-collapse-method", sourceFiles="controller.cs" %}

{% endaspTab %}

## Specify initial state to panes

You can render specific panes with collapsed state on page load. Specify a Boolean value to the [`collapsed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings) property to control this behavior. The following code explains how to collapse panes on rendering (the second panes renders with collapsed state).

{% aspTab template="splitter/collapsed", sourceFiles="controller.cs" %}

{% endaspTab %}

Execution of above code's output will be as given below,

![Collapsed](./images/collapsed.png)

## See Also

* [Resizable split panes](./resizing)