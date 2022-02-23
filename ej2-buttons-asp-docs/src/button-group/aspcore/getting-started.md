---
title: "ButtonGroup Getting Started"
component: "ButtonGroup"
description: "This section helps to learn how to create the buttongroup in ASP.NET Core application with its basic features in step-by-step procedure."
---

# Getting Started

This section briefly explains about how to create a simple ButtonGroup in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add ButtonGroup to the project

To create simple ButtonGroup add the div tag with class name as `e-btn-group` and add `ejs-button` elements should group
inside the `div` element in your **Index.cshtml** page.

{% aspTab template="button-group/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![ButtonGroup Sample](./images/button-group.png)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of ButtonGroup.

{% aspTab template="button-group/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Orientation

ButtonGroup can be arranged in a vertical and horizontal orientation. By default, it is horizontally aligned.

### Vertical Orientation

ButtonGroup can be aligned vertically by using the built-in CSS class `e-vertical` to the target element.

The following example illustrates how to achieve vertical orientation in ButtonGroup.

{% aspTab template="button-group/orientation/demo", sourceFiles="default.cs" %}

{% endaspTab %}

> ButtonGroup does not support SplitButton component nesting in a vertical orientation.
