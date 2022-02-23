---
title: "RadioButton Getting Started"
component: "RadioButton"
description: "This section helps to learn how to create the radiobutton in ASP.NET MVC application with its basic features in step-by-step procedure."
---

# Getting Started

This section briefly explains about how to include a simple RadioButton in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add RadioButton to the project

We are going to render `RadioButton` component in **Index.cshtml** page.

{% aspTab template="radio-button/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![RadioButton Sample](./images/radio-button.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of RadioButton.

{% aspTab template="radio-button/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Change the RadioButton state

The Essential JS 2 RadioButton contains 2 states visually, they are as follows:
* Checked
* Unchecked

The RadioButton [`checked`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_Checked) property is used to handle the checked and unchecked state.
In the checked state an inner circle will be added to the visualization of RadioButton.

{% aspTab template="radio-button/getting-started/state", sourceFiles="state.cs" %}

{% endaspTab %}