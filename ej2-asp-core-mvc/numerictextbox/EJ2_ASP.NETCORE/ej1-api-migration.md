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
| Triggers on creation | **Event:** *create*<br /><br />`<ej-numeric-text-box id="numeric" value="120" create="onCreate" />`<br />**Script**<br />`function onCreate(){}` | **Event:** *created*<br /><br />`<ejs-numerictextbox id="numeric" created="onCreate" value="120"></ejs-numerictextbox>`<br />**Script**<br />`function onCreate(){}` |
| Adding custom classes | **Property:** *css-class*<br /><br />`<ej-numeric-text-box id="numeric" value="100" css-class="custom" />` | **Property:** *cssClass*<br /><br />`<ejs-numerictextbox id="numeric" cssClass="custom" value="100"></ejs-numerictextbox>` |
| Triggers when editor is destroyed | **Event:** *destroy*<br /><br />`<ej-numeric-text-box id="numeric" value="120" destroy="onDestroy" />`<br />**Script**<br />`function onDestroy(){}` | **Event:** *destroyed*<br /><br />`<ejs-numerictextbox id="numeric" destroyed="onDestroy" value="120"></ejs-numerictextbox>`<br />**Script**<br />`function onDestroy(){}` |
| Destroys textbox | **Method:** *destroy*<br /><br />`<ej-numeric-text-box id="numeric" value="100"/>`<br />**Script**<br /><br />`var numericObj = $(“#numeric).data("ejNumericTextbox");`<br />`numericObj.destroy();` | **Method:** *destroy*<br /><br />`<ejs-numerictextbox id="numeric" created="onCreate" value="100"></ejs-numerictextbox>`<br /><br />**Script**<br /><br />`function onCreate(){`<br />`var numeric = this;`<br />}<br />`numeric.destroy();` |
| Control state | **Property:** *enabled*<br /><br />`<ej-numeric-text-box id="numeric" value="100" enabled=false />` | **Property:** *enabled*<br /><br />`<ejs-numerictextbox id="numeric" enabled=false value="100"></ejs-numerictextbox>` |
| Persistence | **Property:** *enable-persistence*<br /><br />`<ej-numeric-text-box id="numeric" value="100" enable-persistence=true />` | **Property:** *enablePersistence*<br /><br />`<ejs-numerictextbox id="numeric" enablePersistence=true value="100"></ejs-numerictextbox>` |
| Right To Left | **Property:** *enable-rtl*<br /><br />`<ej-numeric-text-box id="numeric" value="100" enable-rtl=true />` | **Property:** *enableRtl*<br /><br />`<ejs-numerictextbox id="numeric" enableRtl=true value="100"></ejs-numerictextbox>` |
| Triggers when editor is focused in | **Event:** *focus-in*<br /><br />`<ej-numeric-text-box id="numeric" value="20" focus-in="focusIn" />`<br />**Script**<br />`function focusIn(){}` |**Event:** *focus*<br/><br/>`<ejs-numerictextbox id="numeric" value="100" focus="onFocus" ></ejs-numerictextbox>`<br/><br/>**Script**<br/><br/>`function onFocus(){}` |
| Triggers when editor is focused out | **Event:** *focusOut*<br /><br />`<ej-numeric-text-box id="numeric" value="100" focus-out="focusOut" />`<br />**Script**<br />`function focusOut(){}` | **Event:** *blur*<br/><br/>`<ejs-numerictextbox id="numeric" value="100" blur="onBlur" ></ejs-numerictextbox>`<br /><br />**Script**<br /><br />`function onBlur(){}` |
| Sets Height | **Property:** *height*<br /><br />`<ej-numeric-text-box id="numeric" value="100" height="40px" />` | **Can be achieved using,** <br /><br />`<ejs-numerictextbox id="numeric" cssClass="custom" value="100"></ejs-numerictextbox>`<br />**Css**<br />.e-numerictextbox.custom{<br />height: 40px;<br />} |
| HTML Attributes | **Property:** *html-attributes*<br /><br />`<ej-numeric-text-box id="numeric" value="100" html-attributes="htmlAttr"/>`<br /><br />**Script**<br /><br />`@{`<br />`Dictionary<string, object> htmlAttr = new Dictionary<string, object>();`<br />`htmlAttr.Add("disabled", "disabled");`<br />} |  **Can be achieved using**<br/>`<ejs-numerictextbox id="numeric" created="onCreate" value="100"></ejs-numerictextbox>`<br/>**Script**<br/>`function onCreate{`<br/>`this.element.setAttribute{"name","textbox'}`<br/>`}`  |
| Name of editor | **Property:** *name*<br /><br />`<ej-numeric-text-box id="numeric" value="100" name="Textbox"/>` | **Can be achieved using**<br/>`<ejs-numerictextbox id="numeric" name="numerictextbox" value="100"></ejs-numerictextbox>` |
| Read only | **Property:** *read-only*<br /><br />`<ej-numeric-text-box id="numeric" value="80" read-only=true />` | **Property:** *readonly*<br /><br />`<ejs-numerictextbox id="numeric" readonly=true value="80"></ejs-numerictextbox>` |
| Rounded corners | **Property:** *show-rounded-corner*<br /><br />`<ej-numeric-text-box id="numeric" value="100" show-rounded-corner=true />` |**Can be achieved using**<br/>`<ejs-numerictextbox id="numeric" cssClass="e-style" floatLabelType="Always" value="100"></ejs-numerictextbox>`<br/>**CSS**<br/>`.e-control-wrapper.e-numeric.e-input-group.e-style {`<br/>`border: 2.5px solid;`<br/>`border-radius: 1rem;`<br/> `padding-left: 12px;` <br/>`}`<br/>`.e-control-wrapper.e-numeric.e-float-input.e-style .e-float-line::before, .e-control-wrapper.e-numeric.e-float-input.e-style  .e-float-line::after{`<br/>`background: none ;`<br/>`}`<br/>`.e-control-wrapper.e-numeric.e-input-group.e-style.e-input-focus{`<br/> `border: solid grey  !important;`<br/>`}` |
| Spin Button | **Property:** *show-spin-button*<br /><br />`<ej-numeric-text-box id="numeric" value="20" show-spin-button=false />` | **Property:** *showSpinButton*<br /><br />`<ejs-numerictextbox id="numeric" showSpinButton=false value="20"></ejs-numerictextbox>` |
| Width | **Property:** *width*<br /><br />`<ej-numeric-text-box id="numeric" value="20" width="220px" />` | **Property:** *width*<br /><br />`<ejs-numerictextbox id="numeric" width="220px" value="20"></ejs-numerictextbox>` |
| Clear Button | Not Applicable | **Property:** *showClearButton*<br /><br />`<ejs-numerictextbox id="numeric" showClearButton=true value="100"></ejs-numerictextbox>` |

## Globalization

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Localization culture | **Property:** *locale*<br /><br />`<ej-numeric-text-box id="numeric" value="80" locale="de-DE" />` | **Property:** *locale*<br /><br />`<ejs-numerictextbox id="numeric" locale="de-DE" value="80"></ejs-numerictextbox>` |

## Group

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Group digits in editor | **Property:** *group-size*<br /><br />`<ej-numeric-text-box id="numeric" value="100" group-size="2" />` | Not Applicable |
| Group Separator | **Property:** *group-separator*<br /><br />`<ej-numeric-text-box id="numeric" value="100" group-separator="-" />` | Not Applicable |

## Numeric configuration

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Triggers on value change | **Event:** *change*<br /><br />`<ej-numeric-text-box id="numeric" value="120" change="onChange" />`<br />**Script**<br />`function onChange(){}` | **Event:** *change*<br /><br />`<ejs-numerictextbox id="numeric" change="onChange" value="120"></ejs-numerictextbox>`<br />**Script**<br />`function onChange(){}` |
| Sets digits allowed after decimal point | **Property:** *decimal-places*<br /><br />`<ej-numeric-text-box id="numeric" value="100" decimal-places=2 />` | **Property:** *decimals*<br /><br />`<ejs-numerictextbox id="numeric" format="n2" decimals="2" value="100"></ejs-numerictextbox>` |
| Decrement value | Not Applicable | **Method:** *decrement*<br /><br />`<ejs-numerictextbox id="numeric" created="onCreate" value="100"></ejs-numerictextbox>`<br /><br />**Script**<br /><br />`function onCreate(){`<br />`var numeric = this;`<br />}<br />`numeric.decrement();` |
| Disable the textbox | **Method:** *disable*<br /><br />`<ej-numeric-text-box id="numeric" value="200"/>`<br />**Script**<br /><br />`var numericObj = $(“#numeric).data("ejNumericTextbox");`<br />`numericObj.disable();` | **Can be achieved using**<br/>`<ejs-numerictextbox id="numeric" created="onCreate" value="100"></ejs-numerictextbox>`<br/>**Script**<br>`function onCreate(){`<br />`var numeric = this;`<br />}<br />`numeric.enabled = false;` |
| Enable the textbox | **Method:** *enable*<br /><br />`<ej-numeric-text-box id="numeric" value="200"/>`<br />**Script**<br /><br />`var numericObj = $(“#numeric).data("ejNumericTextbox");`<br />`numericObj.enable();` | **Can be achieved using**<br/>`<ejs-numerictextbox id="numeric" created="onCreate" value="100"></ejs-numerictextbox>`<br/>**Script**<br>`function onCreate(){`<br />`var numeric = this;`<br />}<br />`numeric.enabled = true;` |
| Gets value of editor | **Method:** *getValue*<br /><br />`<ej-numeric-text-box id="numeric" value="100"/>`<br />**Script**<br /><br />`var numericObj = $(“#numeric).data("ejNumericTextbox");`<br />`numericObj.getValue();` | **Method:** *getText*<br /><br />`<ejs-numerictextbox id="numeric" created="onCreate" value="100"></ejs-numerictextbox>`<br /><br />**Script**<br /><br />`function onCreate(){`<br />`var numeric = this;`<br />}<br />`numeric.getText();` |
| Increment value | Not Applicable | **Method:** *increment*<br /><br />`<ejs-numerictextbox id="numeric" created="onCreate" value="80"></ejs-numerictextbox>`<br /><br />**Script**<br /><br />`function onCreate(){`<br />`var numeric = this;`<br />}<br />`numeric.increment();` |
| Step value | **Property:** *increment-step*<br /><br />`<ej-numeric-text-box id="numeric" value="100" increment-step=2 />` | **Property:** *step*<br /><br />`<ejs-numerictextbox id="numeric" decimals="2" value="100" step="2"></ejs-numerictextbox>` |
| Sets Maximum value | **Property:** *max-value*<br /><br />`<ej-numeric-text-box id="numeric" value="100" max-value="200" />` | **Property:** *max*<br /><br />`<ejs-numerictextbox id="numeric" max="200" value="100"></ejs-numerictextbox>` |
| Sets Minimum value | **Property:** *min-value*<br /><br />`<ej-numeric-text-box id="numeric" value="100" min-value="200" />` | **Property:** *min*<br /><br />`<ejs-numerictextbox id="numeric" min="20" value="100"></ejs-numerictextbox>` |
| Negative pattern for formatting values | **Property:** *negative-pattern*<br /><br />`<ej-numeric-text-box id="numeric" value="-20" negative-pattern="( n)" />` | Not Applicable |
| Positive pattern for formatting values | **Property:** *positive-pattern*<br /><br />`<ej-numeric-text-box id="numeric" value="20" positive-pattern="n kg" />` | Not Applicable |
| Specifies value | **Property:** *value*<br /><br />`<ej-numeric-text-box id="numeric" value="100" />` | **Property:** *value*<br /><br />`<ejs-numerictextbox id="numeric" value="100"></ejs-numerictextbox>` |
| Displays hint on editor | **Property:** *watermark-text*<br /><br />`<ej-numeric-text-box id="numeric" value="80" watermark-text="Enter value" />` | **Property:** *placeholder*<br /><br />`<ejs-numerictextbox id="numeric" placeholder="Enter value" value="100"></ejs-numerictextbox>` |
| Placeholder float type | Not Applicable | **Property:** *floatLabelType*<br /><br />`<ejs-numerictextbox id="numeric" placeholder="Enter value" value="200" floatLabelType="Auto">` |

## Number Formats

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Set Currency symbol | **Property:** *currency-symbol*<br /><br />`<ej-currency-text-box id="currency" value="100" currency-symbol="EUR" />` | **Property:** *currency*<br /><br />`<ejs-numerictextbox id="currency" format="c2" value="100" currency="EUR">` |
| Number Format | Not Applicable | **Property:** *format*<br /><br />`<ejs-numerictextbox id="numeric" format="n2" value="200">` |

## Validation

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Strict Mode | **Property:** *enable-strict-mode*<br /><br />`<ej-numeric-text-box id="numeric" value="80" enable-strict-mode=true />` | **Property:** *strictMode*<br /><br />`<ejs-numerictextbox id="numeric" strictMode=true value="80">` |
| Validation on typing | **Property:** *validate-on-type*<br /><br />`<ej-numeric-text-box id="numeric" value="100" validate-on-type=true />` | **Property:** *validateDecimalOnType*<br /><br />`<ejs-numerictextbox id="numeric" validateDecimalOnType=true value="100">` |
| Validation Message | **Property:** *validation-message*<br /><br />`<ej-numeric-text-box id="numeric" value="100" validation-rules="rule" validation-message="messages"/>`<br /><br />**Script**<br /><br />`@{`<br />`Dictionary<string, object> rule = new Dictionary<string, object>();`<br />`rule.Add("required",true);`<br />`Dictionary<string, object> messages = new Dictionary<string, object>();`<br />`messages.Add("required", "Required value");`<br />`}` |**Validation in NumericTextBox can be achieved using**<br/>`<form id="form-element">`<br/>`<div>`<br/>`<ejs-numerictextbox id="numeric" min="10" max="100" change="onChange" created="onCreate" strictMode="false" width="250px"></ejs-numerictextbox>`<br/>`</div>`<br/>`</form>`<br/>**Script**<br/>`function onCreate() {`<br/>`document.getElementById(this.element.id).setAttribute("name", "numericRange");`<br/>`}`<br/>`function onChange() {`<br/>`if (numeric.value != null) {`<br/>`formObject.validate("numericRange");`<br/>`}`<br/>`}`<br/>`var options = {`<br/>`rules: {`<br/> `'numericRange': { required: [true, "Enter valid number"] },`<br/>`},`<br/>`};`<br/> `var formObject = new ej.inputs.FormValidator('#form-element', options);`<br/>`formObject.customPlacement = function (element, errorElement) {`<br/>`element.parentNode.parentNode.appendChild(errorElement);`<br/>`};`|
| Validation Rules | **Property:** *validation-rules*<br /><br />`<ej-numeric-text-box id="numeric" value="100" validation-rules="rule" />`<br /><br />**Script**<br /><br />`@{`<br />`Dictionary<string, object> rule = new Dictionary<string, object>();`<br />`rule.Add("required",true);`<br />`}` | **Validation in NumericTextBox can be achieved using**<br/>`<form id="form-element">`<br/>`<div>`<br/>`<ejs-numerictextbox id="numeric" min="10" max="100" change="onChange" created="onCreate" strictMode="false" width="250px"></ejs-numerictextbox>`<br/>`</div>`<br/>`</form>`<br/>**Script**<br/>`function onCreate() {`<br/>`document.getElementById(this.element.id).setAttribute("name", "numericRange");`<br/>`}`<br/>`function onChange() {`<br/>`if (numeric.value != null) {`<br/>`formObject.validate("numericRange");`<br/>`}`<br/>`}`<br/>`var options = {`<br/>`rules: {`<br/> `'numericRange': { required: [true] },`<br/>`},`<br/>`};`<br/> `var formObject = new ej.inputs.FormValidator('#form-element', options);`<br/>`formObject.customPlacement = function (element, errorElement) {`<br/>`element.parentNode.parentNode.appendChild(errorElement);`<br/>`};` |
