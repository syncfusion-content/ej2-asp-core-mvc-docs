---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Radio Button Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Radio Button component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of RadioButton component from Essential JS 1 to Essential JS 2.

## Properties

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Label | **Property:** *text* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" />` | **Property:** *label* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton"></ejs-radiobutton>` |
| Checked state | **Property:** *checked* <br/><br/> `<ej-radio-button id="radio" text="RadioButton" checked="true" />` | **Property:** *checked* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton" checked="true"></ejs-radiobutton>` |
| Adding custom css class | **Property:** *cssClass* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" css-class="custom-class" />` | **Property:** *cssClass* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton" cssClass="custom-class"></ejs-radiobutton>` |
| Disabled state | **Property:** *enabled* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" enabled="false"/ />` | **Property:** *disabled* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton" disabled="true"></ejs-radiobutton>` |
| State persistence | **Property:** *enablePersistence* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" enable-persistence="true"/ />` | **Property:** *enablePersistence* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton" enablePersistence="true"></ejs-radiobutton>` |
| RTL | **Property:** *enableRTL* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" enable-rtl="true"/ />` | **Property:** *enableRtl* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton" enableRtl="true"></ejs-radiobutton>` |
| HTML Attributes | **Property:** *htmlAttributes* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" html-attributes="" />` | Not applicable |
| Id property | **Property:** *id* <br/><br/>`<ej-radio-button  id="sync" />` | Not applicable |
| Prefix value of Id | **Property:** *idPrefix* <br/><br/> `<ej-radio-button  id-prefix="ej" />` | Not applicable |
| Name attribute | **Property:** *name* <br/><br/> `<ej-radio-button id="radio"  name="gender" checked="true" text="Male" />` | **Property:** *name* <br/><br/> `<ejs-radiobutton id="radio" name="gender" checked="true" label="Male"></ejs-radiobutton>` |
| Value attribute | **Property:** *value* <br/><br/> `<ej-radio-button id="radio"  name="gender" checked="true"  value="male" text="Male" />` | **Property:** *value* <br/><br/> `<ejs-radiobutton id="radio" name="gender" checked="true"  value="male" label="Male"></ejs-radiobutton>` |
| Size | **Property:** *size* <br/><br/> `<ej-radio-button id="radio" size="@RadioButtonSize.Small" text="RadioButton" />` | **Property:** *cssClass* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton" cssClass="e-small"></ejs-radiobutton>` |
| Validation rules | **Property:** *validationRules* <br/><br/> `<ej-radio-button id="radio" text="RadioButton" validation-rules="ViewBag.rules" />` | Not applicable |
| Validation message | **Property:** *validationMessage* <br/><br/> `<ej-radio-button id="radio" text="RadioButton" validation-rules="ViewBag.rules" validation-message="ViewBag.message" />` | Not applicable |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Destroy | **Method:** *destroy* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" />` <br/> var radioButton = $("#radio").data("ejRadioButton");<br/>radioButton.destroy(); | **Method:** *destroy* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton"></ejs-radiobutton>` <br/> var radioButton = document.getElementById('radio').ej2_instances[0]; <br/>radioButton.destroy(); |
| Disable the RadioButton | **Method:** *disable* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" />` <br/> var radioButton = $("#radio").data("ejRadioButton");<br/>radioButton.disable(); | Not applicable |
| Enable the RadioButton | **Method:** *enable* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" />` <br/> var radioButton = $("#radio").data("ejRadioButton");<br/>radioButton.enable(); | Not applicable |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| BeforeChange Event | **Event:** *beforeChange* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" before-change="beforeChange" />` <br/>function beforeChange(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | Not applicable |
| Change Event | **Event:** *change* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" change="change" />` <br/>function change(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | **Event:** *change* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton" change="change"></ejs-radiobutton>` <br/>function change(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} |
| Create Event | **Event:** *create* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" create="create" />` <br/>function create(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | **Event:** *created* <br/><br/> `<ejs-radiobutton id="radio" label="RadioButton" created="created"></ejs-radiobutton>` <br/> function created() {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} |
| Destroy Event | **Event:** *destroy* <br/><br/> `<ej-radio-button  id="radio" text="RadioButton" destroy="destroy" />` <br/> function destroy(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | Not applicable |