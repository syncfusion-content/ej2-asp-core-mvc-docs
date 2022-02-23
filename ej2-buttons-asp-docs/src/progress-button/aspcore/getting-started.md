---
title: "ProgressButton Getting Started"
component: "ProgressButton"
description: "This section helps to learn how to create the progressbutton in ASP.NET Core application with its basic features in step-by-step procedure."
---

# Getting Started

This section briefly explains about how to create a simple ProgressButton in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add ProgressButton to the project

To create simple ProgressButton add the `ejs-progressbutton` tag with id attribute as `element` in your **Index.cshtml** page.

{% aspTab template="progress-button/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![ProgressButton Sample](./images/progress-button.png)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

The following example shows a basic ProgressButton component.

{% aspTab template="progress-button/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

> ProgressButton supports different styles, types and sizes like [`Button`](https://ej2.syncfusion.com/aspnetcore/documentation/button/). In addition, it also support `top` and `bottom` position of the icon.

## Enabling progress in button

You can enable the background filler UI by setting the [`enableProgress`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_EnableProgress) property to `true`.

{% aspTab template="progress-button/enable-progress/demo", sourceFiles="default.cs" %}

{% endaspTab %}
