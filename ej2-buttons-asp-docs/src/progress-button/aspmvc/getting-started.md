---
title: "ProgressButton Getting Started"
component: "ProgressButton"
description: "This section helps to learn how to create the progressbutton in ASP.NET MVC application with its basic features in step-by-step procedure."
---

# Getting Started

This section briefly explains about how to include a simple ProgressButton in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add ProgressButton to the project

We are going to render `ProgressButton` component in **Index.cshtml** page.

{% aspTab template="progress-button/getting-started/demo" %}

{% endaspTab %}

Output be like the below.

![ProgressButton Sample](./images/progress-button.png)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a basic ProgressButton component.

{% aspTab template="progress-button/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

> ProgressButton supports different styles, types and sizes like [`Button`](https://ej2.syncfusion.com/aspnetmvc/documentation/button/). In addition, it also support `top` and `bottom` position of the icon.

## Enabling progress in button

You can enable the background filler UI by setting the [`enableProgress`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_EnableProgress) property to `true`.

{% aspTab template="progress-button/enable-progress/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## See Also

* [Spinner and Progress options](spinner-and-progress#spinner)