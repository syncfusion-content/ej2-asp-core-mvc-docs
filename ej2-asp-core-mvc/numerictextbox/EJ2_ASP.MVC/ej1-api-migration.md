---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Numerictextbox Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Numerictextbox component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Migration from Essential JS 1

This article describes the API migration process of NumericTextBox component from Essential JS 1 to Essential JS 2.

## Common

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Triggers on creation | **Event** *Create*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(120).ClientSideEvents(s => s.Create("onCreate"))<br />**Script**<br />function onCreate(){} | **Event:** *Created*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(120).Created("onCreate").Render()<br />**Script**<br />function onCreate(){} |
| Adding custom classes | **Property** *CssClass*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).CssClass("custom")| **Property:** *CssClass*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).CssClass("custom").Render() |
| Triggers when editor is destroyed | **Event** *Destroy*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(120).ClientSideEvents(s => s.Destroy("onDestroy"))<br />**Script**<br />function onDestroy(){} | **Event:** *Destroyed*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(120).Destroyed("onDestroy").Render()<br />**Script**<br />function onDestroy(){} |
| Destroys textbox | **Method** *destroy*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100)<br />**Script**<br /><br />var numericObj = $(“#numeric).data("ejNumericTextbox");<br />numericObj.destroy(); | **Method:** *destroy*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Render()<br /><br />**Script**<br /><br />var numeric = document.getElementById('numeric').ej2_instances[0]<br />numeric.destroy(); |
| Control state | **Property** *Enabled*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).Enabled(false) | **Property:** *Enabled*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Enabled(false).Render() |
| Persistence | **Property** *EnablePersistence*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).EnablePersistence(true) | **Property:** *EnablePersistence*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).EnablePersistence(true).Render() |
| Right To Left | **Property** *EnableRTL*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).EnableRTL(true) | **Property:** *EnableRtl*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).EnableRtl(true).Render() |
| Triggers when editor is focused in | **Event** *FocusIn*<br /><br />@Html.EJ().NumericTextbox("numeric").<br/>Value(20).ClientSideEvents(s => s.FocusIn("focusIn"))<br />**Script**<br />function focusIn(){} | **Event:** *Focus*<br/><br/>@Html.EJS().NumericTextBox("numeric").Value(100).InputMode(InputMode.Text).Focus("onFocus")<br/>**Script**<br />function onFocus(){} |
| Triggers when editor is focused out | **Event** *FocusOut*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).<br/>ClientSideEvents(s => s.FocusOut("focusOut"))<br />**Script**<br />function focusOut(){} |   **Event:** *Blur*<br/><br/>@Html.EJS().NumericTextBox("numeric").Value(100).InputMode(InputMode.Text).Blur("onBlur")<br/>**Script**<br />function onBlur(){} |
| Sets Height | **Property** *Height*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).Height("40px") | **Can be achieved using,** <br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).CssClass("custom").Render()<br />**Css**<br />.e-numerictextbox.custom{<br />height: 40px;<br />} |
| HTML Attributes | **Property** *HtmlAttributes*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).HtmlAttributes(htmlAttr)<br /><br />**Script**<br /><br />@{<br />Dictionary<string, object> htmlAttr = new Dictionary<string, object>();<br />htmlAttr.Add("disabled", "disabled");<br />} | **Can be achieved using**<br/>@Html.EJS().NumericTextBox("numeric").Min(10).Max(100).Created("onCreate").Render()<br/>**Script**<br/>function onCreate() {<br/>document.getElementById(this.element.id).setAttribute("name", "numericRange");<br/>} |
| Name of editor | **Property** *name*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).Name("Textbox") | **Can be achieved using**<br/> @Html.EJS().NumericTextBox("numeric").Min(10).Max(100).Created("onCreate").Render()<br/>**Script**<br/>function onCreate() {<br/>document.getElementById(this.element.id).setAttribute("name", "numericRange");<br/>} |
| Read only | **Property** *ReadOnly*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(80).ReadOnly(true) | **Property:** *ReadOnly*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(80).ReadOnly(true).Render() |
| Rounded corners | **Property** *ShowRoundedCorner*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).ShowRoundedCorner(true) | **Can be achieved using**<br/>@Html.EJS().NumericTextBox("numeric").Created("onCreate").FloatLabelType(Syncfusion.EJ2.Inputs.FloatLabelType.Always).CssClass("e-style").Render()<br/>**Css**<br/> .e-control-wrapper.e-numeric.e-input-group.e-style {<br/> border: solid 2.5px;<br/> border-radius: 1rem;<br/>padding-left: 12px;<br/>}<br/>  .e-control-wrapper.e-numeric.e-input-group.e-style.e-input-focus {<br/>border: solid grey 2.5px !important;<br/>border-radius: 1rem;<br/>  }<br/>.e-control-wrapper.e-numeric.e-float-input.e-style .e-float-line::before,.e-control-wrapper.e-numeric.e-float-input.e-style .e-float-line::after {<br/>background: none;<br/>}<br/><br/>.e-control-wrapper.e-numeric.e-input-group.e-style.e-input-focus{<br/>border: solid grey  !important; <br/>} |
| Spin Button | **Property** *ShowSpinButton*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(20).ShowSpinButton(true) | **Property:** *ShowSpinButton*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(20).ShowSpinButton(false).Render() |
| Width | **Property** *Width*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(20).width("220px") | **Property:** *Width*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(20).Width("220px").Render() |
| Clear Button | Not Applicable | **Property:** *ShowClearButton*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).ShowClearButton(true).Render() |

## Globalization

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Localization culture | **Property** *Locale*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(80).Locale("de-DE") | **Property:** *Locale*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(80).Locale("de-DE").Render() |

## Group

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Group digits in editor | **Property** *GroupSize*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).GroupSize("2") | Not Applicable |
| Group Separator | **Property** *GroupSeparator*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).GroupSeparator("-") | Not Applicable |

## Numeric configuration

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Triggers on value change | **Event** *Change*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(120).<br/>ClientSideEvents(s => s.Change("onChange"))<br />**Script**<br />function onChange(){} | **Event:** *Change*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(120).Change("onChange").Render()<br />**Script**<br />function onChange(){} |
| Sets digits allowed after decimal point | **Property** *DecimalPlaces*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).DecimalPlaces(2) | **Property:** *Decimals*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Format("n2").Decimals("2").Render() |
| Decrement value | Not Applicable | **Method:** *decrement*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Render()<br /><br />**Script**<br /><br />var numeric = document.getElementById('numeric').ej2_instances[0]<br />numeric.decrement(); |
| Disable the textbox | **Method** *disable*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(200)<br />**Script**<br /><br />var numericObj = $(“#numeric).data("ejNumericTextbox");<br />numericObj.disable(); |  **Can be achieved using**<br/>@Html.EJS().NumericTextBox("numeric").Min(10).Max(100).Created("onCreate").Render()<br/>**Script**<br/>function onCreate() {<br/>var numeric = this;<br/>numeric.enabled = false;<br/>}<br/> |
| Enable the textbox | **Method** *enable*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(200)<br />**Script**<br /><br />var numericObj = $(“#numeric).data("ejNumericTextbox");<br />numericObj.enable(); | **Can be achieved using**<br/>@Html.EJS().NumericTextBox("numeric").Min(10).Max(100).Created("onCreate").Render()<br/>**Script**<br/>function onCreate() {<br/>var numeric = this;<br/>numeric.enabled = true;<br/>}<br/> |
| Gets value of editor | **Method** *getValue*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100)<br />**Script**<br /><br />var numericObj = $(“#numeric).data("ejNumericTextbox");<br />numericObj.getValue(); | **Method:** *getText*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Render()<br /><br />**Script**<br /><br />var numeric = document.getElementById('numeric').ej2_instances[0]<br />numeric.getText(); |
| Increment value | Not Applicable | **Method:** *increment*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(80).Render()<br /><br />**Script**<br /><br />var numeric = document.getElementById('numeric').ej2_instances[0]<br />numeric.increment(); |
| Step value | **Property** *IncrementStep*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).IncrementStep(2) | **Property:** *Step*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Step(2).Render() |
| Sets Maximum value | **Property** *MaxValue<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).MaxValue(200) | **Property:** *Max*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Max(200).Render() |
| Sets Minimum value | **Property** *MinValue*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).MinValue(20) | **Property:** *Min*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Min(20).Render() |
| Negative pattern for formatting values | **Property** *NegativePattern*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(-20).NegativePattern("( n)") | Not Applicable |
| Positive pattern for formatting values | **Property** *PositivePattern*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(20).PositivePattern("n kg") | Not Applicable |
| Specifies value | **Property** *Value*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100) | **Property:** *value*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Render() |
| Displays hint on editor | **Property** *WatermarkText*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(80).WatermarkText("Enter value") | **Property:** *Placeholder*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(100).Placeholder("Enter value").Render() |
| Placeholder float type | Not Applicable | **Property:** *FloatLabelType*<br /><br />@Html.EJS().NumericTextBox("numeric").Value(200).Placeholder("Enter value").FloatLabelType("Auto").Render() |

## Number Formats

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Set Currency symbol | **Property** *CurrencySymbol*<br /><br />@Html.EJ().CurrencyTextbox("currency").Value(100).CurrencySymbol("EUR") | **Property:** *Currency*<br /><br />@Html.EJS().NumericTextBox("numeric").Format("c2").Value(100).Currency("EUR").Render() |
| Number Format | Not Applicable | **Property:** *Format*<br /><br />@Html.EJS().NumericTextBox("numeric").Format("n2").Value(200).Render() |

## Validation

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Strict Mode | **Property** *EnableStrictMode*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(80).EnableStrictMode(true) | **Property:** *StrictMode*<br /><br />@Html.EJS().NumericTextBox("numeric").StrictMode(true).Value(80).Render() |
| Validation on typing | **Property** *ValidateOnType*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).ValidateOnType(true) | **Property:** *ValidateDecimalOnType*<br /><br />@Html.EJS().NumericTextBox("numeric").ValidateDecimalOnType(true).Value(100).Render() |
| Validation Message | **Property** *ValidationMessage*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).ValidationRules(rule => rule.AddRule("required", true)).ValidationMessage(msg => msg.AddMessage("required", "Required value")) |**Can be achieved using**<br/>&lt;form id="form-element"><br/> @Html.EJS().NumericTextBox("numeric").Min(10).Max(100).Placeholder("Enter the number").Change("onChange").Created("onCreate").StrictMode(false).Render()<br/>&lt;/form><br/>function onCreate() {<br/>document.getElementById(this.element.id).setAttribute("name", "numericRange");<br/>}<br/>function onChange() {<br/>if (numeric.value != null) {<br/>formObject.validate("numericRange");<br/> }<br/>var options = {<br/> rules: {<br/> 'numericRange': { required: [true, "Number is required"] },<br/> },<br/>};<br/> var formObject = new ej.inputs.FormValidator('#form-element', options);<br/>formObject.customPlacement = function (element, errorElement) {<br/>element.parentNode.parentNode.appendChild(errorElement);<br/>}; |
| Validation Rules | **Property** *ValidationRules*<br /><br />@Html.EJ().NumericTextbox("numeric").Value(100).ValidationRules(rule => rule.AddRule("required", true)) | **Can be achieved using**<br/>&lt;form id="form-element"><br/> @Html.EJS().NumericTextBox("numeric").Min(10).Max(100).Placeholder("Enter the number").Change("onChange").Created("onCreate").StrictMode(false).Render()<br/>&lt;/form><br/>function onCreate() {<br/>document.getElementById(this.element.id).setAttribute("name", "numericRange");<br/>}<br/>function onChange(args) {<br/>if (numeric.value != null) {<br/>formObject.validate("numericRange");<br/> }<br/>var options = {<br/> rules: {<br/> 'numericRange': { required: [true] },<br/> },<br/>};<br/> var formObject = new ej.inputs.FormValidator('#form-element', options);<br/>formObject.customPlacement = function (element, errorElement) {<br/>element.parentNode.parentNode.appendChild(errorElement);<br/>}; |
