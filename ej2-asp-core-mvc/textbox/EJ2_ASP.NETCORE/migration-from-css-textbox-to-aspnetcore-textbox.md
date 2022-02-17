---
layout: post
title: Migration From Css Textbox To Aspnetcore Textbox in ##Platform_Name## Textbox Component
description: Learn here all about Migration From Css Textbox To Aspnetcore Textbox in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Migration From Css Textbox To Aspnetcore Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# ASP.NET Core textbox control

> From v16.3.21 version, the textbox is provided as ASP.NET Core control to achieve the floating label textbox with minimal code. You can find the available textbox properties, methods, and events in the [API reference](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html).

The following table describes the migration from CSS textbox to ASP.NET Core textbox control.

## Normal textbox

<!-- markdownlint-disable MD038 -->
| **Rendering mode** | **CSS textbox** | **ASP.NET Core textbox control** |
| -----------------------| -----------------------------------| ------------------------------------------- |
| Default rendering |  `<div class='e-input-group'>`<br/>`<input class='e-input' type='text' placeholder='Enter Value'/>`<br/>`</div>` |  `<ejs-textbox id="default" placeholder="Enter Value" floatLabelType="Never" ></ejs-textbox>` |
| Textbox with clear button |  `<div class='e-input-group'>`<br/>`<input class='e-input' placeholder='Enter Value' required='true'>`<br/>`<span class='e-clear-icon'></span>`<br/>`</div>`<br/><br/> Note: You have to write action for clear button. |  `<ejs-textbox id="clear-input" placeholder="Enter Value" showClearButton="true" floatLabelType="Never" ></ejs-textbox>` |
| Validation states |  `<div class='e-input-group e-error'>`<br/>`<input class='e-input' type='text' placeholder='Enter Value' />`<br/>`</div>`<br/><br/> Note: Textbox control consists of three types of validation rules such as success, warning, and error. |  `<ejs-textbox id="validation" placeholder="Enter Value" cssClass="e-error" floatLabelType="Never" ></ejs-textbox>` |

## Floating label textbox

<!-- markdownlint-disable MD038 -->
| **Rendering mode** | **CSS textbox** | **ASP.NET Core textbox control** |
| -----------------------| -----------------------------------| ------------------------------------------- |
| Default rendering |  `<div class='e-float-input'>`<br/>`<input type='text' required />`<br/>`<span class='e-float-line'></span>`<br/>`<label class='e-float-text'>Enter Value</label>`<br/>`</div>` |  `<ejs-textbox id="default" placeholder="Enter Value" floatLabelType="Auto" ></ejs-textbox>` |
| Textbox with clear button |  `<div class='e-float-input e-input-group'>`<br/>`<input type='text' required  value= 'Clear Input' />`<br/>`<span class='e-float-line'></span>`<br/>`<label class='e-float-text'>Enter Value</label>`<br/>`<span class='e-clear-icon'></span>`<br/>`</div>`<br/><br/> Note: You have to write action for clear button. |  `<ejs-textbox id="clear-input" placeholder="Enter Value" showClearButton="true" floatLabelType="Auto" ></ejs-textbox>` |
| Validation states |  `<div class='e-float-input e-error'>`<br/>`<input type='text' required  />`<br/>`<span class='e-float-line'></span>`<br/>`<label class='e-float-text'>Enter Value</label>`<br/>`</div>`<br/><br/> Note: Textbox control consists of three types of validation rules such as success, warning, and error. |  `<ejs-textbox id="validation" placeholder="Enter Value" cssClass="e-error" floatLabelType="Auto" ></ejs-textbox>` |