---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started

This section briefly explains about how to create a default ColorPicker in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add ColorPicker to the project

To create default ColorPicker add the `ejs-colorpicker` tag with id attribute as `element` in your **Index.cshtml** page.

{% aspTab template="color-picker/getting-started/demo", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![ColorPicker Sample](./images/color-picker.PNG)

## Run the application

After successful compilation of your application, simply press `F5` to run the application.

The following example shows a default rendering of ColorPicker.

{% aspTab template="color-picker/getting-started/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Inline type

By default, the ColorPicker will be rendered using SplitButton and open the pop-up to access the ColorPicker. To
render the ColorPicker container alone and to access it directly, render it as inline. It can be achieved by setting the [`inline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Inline) property to `true`.

The following sample shows the inline type rendering of ColorPicker.

{% aspTab template="color-picker/getting-started/inline", sourceFiles="inline.cs" %}

{% endaspTab %}

>> The `showButtons` property is disabled in this sample because the control buttons are not needed for inline type. To know about the control buttons functionality, refer to the [`showButtons`](./how-to/hide-control-buttons) sample.
