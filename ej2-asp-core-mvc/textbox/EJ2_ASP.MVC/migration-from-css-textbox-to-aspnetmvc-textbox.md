---
layout: post
title: Migration From Css Textbox To Aspnetmvc Textbox in ##Platform_Name## Textbox Component
description: Learn here all about Migration From Css Textbox To Aspnetmvc Textbox in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Migration From Css Textbox To Aspnetmvc Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# ASP.NET MVC textbox control

> From v16.3.21 version, the textbox is provided as ASP.NET MVC control to achieve the floating label textbox with minimal code. You can find the available textbox properties, methods, and events in the [API reference](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.TextBox.html).

The following table describes the migration from CSS textbox to ASP.NET MVC textbox control.

## Normal textbox

<!-- markdownlint-disable MD038 -->
| **Rendering mode** | **CSS textbox** | **ASP.NET MVC textbox control** |
| -----------------------| -----------------------------------| ------------------------------------------- |
| Default rendering |  `<div class='e-input-group'>`<br/>`<input class='e-input' type='text' placeholder='Enter Value'/>`<br/>`</div>` |  `@Html.EJS().TextBox("default").`<br/>`Placeholder("Enter Value").`<br/>`FloatLabelType`<br/>`(FloatLabelType.Never).`<br/>`Render()` |
| Textbox with clear button |  `<div class='e-input-group'>`<br/>`<input class='e-input' placeholder='Enter Value' required='true'>`<br/>`<span class='e-clear-icon'></span>`<br/>`</div>`<br/><br/> Note: You have to write action for clear button. |  `@Html.EJS().TextBox("clear-input").Placeholder("Enter Value").ShowClearButton(true).`<br/>`FloatLabelType(FloatLabelType`<br/>`.Never).Render()` |
| Validation states |  `<div class='e-input-group e-error'>`<br/>`<input class='e-input' type='text' placeholder='Enter Value' />`<br/>`</div>`<br/><br/> Note: Textbox control consists of three types of validation rules such as success, warning, and error. |  `@Html.EJS().TextBox("clear-input").Placeholder("Enter Value").CssClass("e-error").FloatLabelType`<br/>`(FloatLabelType.Never).`<br/>`Render()` |

## Floating label textbox

<!-- markdownlint-disable MD038 -->
| **Rendering mode** | **CSS textbox** | **ASP.NET MVC textbox control** |
| -----------------------| -----------------------------------| ------------------------------------------- |
| Default rendering |  `<div class='e-float-input'>`<br/>`<input type='text' required />`<br/>`<span class='e-float-line'></span>`<br/>`<label class='e-float-text'>Enter Value</label>`<br/>`</div>` |  `@Html.EJS().TextBox("default").`<br/>`Placeholder("Enter Value").`<br/>`FloatLabelType`<br/>`(FloatLabelType.Auto).`<br/>`Render()` |
| Textbox with clear button |  `<div class='e-float-input e-input-group'>`<br/>`<input type='text' required  value= 'Clear Input' />`<br/>`<span class='e-float-line'></span>`<br/>`<label class='e-float-text'>Enter Value</label>`<br/>`<span class='e-clear-icon'></span>`<br/>`</div>`<br/><br/> Note: You have to write action for clear button. |  `@Html.EJS().TextBox("clear-input").Placeholder("Enter Value").ShowClearButton(true).`<br/>`FloatLabelType(FloatLabelType`<br/>`.Auto).Render()` |
| Validation states |  `<div class='e-float-input e-error'>`<br/>`<input type='text' required  />`<br/>`<span class='e-float-line'></span>`<br/>`<label class='e-float-text'>Enter Value</label>`<br/>`</div>`<br/><br/> Note: Textbox control consists of three types of validation rules such as success, warning, and error. |  `@Html.EJS().TextBox("clear-input").Placeholder("Enter Value").CssClass("e-error").FloatLabelType`<br/>`(FloatLabelType.Auto).`<br/>`Render()` |