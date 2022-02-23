---
title: "Switch Getting Started"
component: "Switch"
description: "This section helps to learn how to create the switch in ASP.NET Core application with its basic features in step-by-step procedure."
---

# Getting Started

This section briefly explains about how to create a simple Switch in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add Switch to the project

To create simple Switch add the `ejs-switch` tag with id attribute as `element` in your **Index.cshtml** page.

{% aspTab template="switch/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of Switch.

{% aspTab template="switch/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Set text on Switch

This section explains how to set [`onLabel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_OnLabel) and [`offLabel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_OffLabel) texts on Switch. In the following example, `onLabel` is set as `ON` and `offLabel` is set as `OFF`.

{% aspTab template="switch/text/demo", sourceFiles="default.cs" %}

{% endaspTab %}

> Switch does not have text support for material themes, and does not support long custom text.
