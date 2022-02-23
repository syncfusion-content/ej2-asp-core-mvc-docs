---
title: "Button Getting Started"
component: "Button"
description: "This section helps to learn how to create the button in ASP.NET MVC application with its basic features in step-by-step procedure."
---

# Getting Started

This section briefly explains about how to include a simple Button in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add Button to the project

We are going to render `Button` component in **Index.cshtml** page.

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

## See Also

* [Types of Button](./types-and-styles#button-types)