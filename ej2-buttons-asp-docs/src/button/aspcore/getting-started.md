---
title: "Buttons Getting Started"
component: "Button"
description: "This section helps to learn how to create the button in ASP.NET Core application with its basic features in step-by-step procedure."
---

# Getting Started

This section briefly explains about how to create a simple Button in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add Button to the project

To create simple Button add the `ejs-button` tag with id attribute as `element` in your **Index.cshtml** page.

{% aspTab template="button/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Button Sample](./images/button.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of Button.

{% aspTab template="button/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Change Button type

To change the default Button to flat Button, set the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_CssClass) property to `e-flat`.

{% aspTab template="button/getting-started/flat-btn", sourceFiles="flatbutton.cs" %}

{% endaspTab %}
