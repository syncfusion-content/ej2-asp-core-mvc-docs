---
title: "CheckBox Getting Started"
component: "CheckBox"
description: "This section helps to learn how to create the checkbox in ASP.NET MVC application with its basic features in step-by-step procedure."
---

# Getting Started

This section briefly explains about how to include a simple CheckBox in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add CheckBox to the project

We are going to render `CheckBox` component in **Index.cshtml** page.

{% aspTab template="check-box/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![CheckBox Sample](./images/check-box.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of CheckBox.

{% aspTab template="check-box/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Change the CheckBox state

The Essential JS 2 CheckBox contains 3 different states visually, they are:
* Checked
* Unchecked
* Indeterminate

The CheckBox [`checked`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_Checked) property is used to handle the checked and unchecked state.
In checked state a tick mark will be added to the visualization of CheckBox.

### Indeterminate

The CheckBox indeterminate state can be set through [`indeterminate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_Indeterminate) property.
CheckBox indeterminate state masks the real value of CheckBox visually. The Checkbox cannot be changed to indeterminate state through the user interface,
this state can be achieved only through the property.

{% aspTab template="check-box/state", sourceFiles="state.cs" %}

{% endaspTab %}