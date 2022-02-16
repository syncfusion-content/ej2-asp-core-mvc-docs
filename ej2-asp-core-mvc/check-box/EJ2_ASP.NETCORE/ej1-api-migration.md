---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Check Box Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Check Box component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Checkbox component from Essential JS 1 to Essential JS 2.

## Properties

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Checkbox label | **Property:** *text* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" >` | **Property:** *label* <br/><br/> `<ejs-checkbox id="checkbox" label="Checkbox"></ejs-checkbox>` |
| Checked state | **Property:** *enableTriState and checkState* <br/><br/> `<ej-check-box id="checkbox" enable-tri-state="true" text="Checked state" check-state="@CheckState.Check"/>` | **Property:** *checked* <br/><br/> `<ejs-checkbox id="checkbox" checked="true" label="Checked state"></ejs-checkbox>` |
| Indeterminate state | **Property:** *enableTriState and checkState* <br/><br/> `<ej-check-box id="checkbox" text="Indeterminate state" enable-tri-state="true" check-state="@CheckState.Indeterminate" />` | **Property:** *indeterminate* <br/><br/> `<ejs-checkbox id="indeterminate" indeterminate="true" label="Intermediate state"></ejs-checkbox>` |
| Adding custom css class | **Property:** *cssClass* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" css-class="custom-class"/>` | **Property:** *cssClass* <br/><br/> `<ejs-checkbox id="checkbox" cssClass="custom-class" label="Checkbox"></ejs-checkbox>` |
| Label position | Not applicable | **Property:** *labelPosition* <br/><br/> `<ejs-checkbox id="checkbox" label="Checkbox" labelPosition="Before"></ejs-checkbox>` |
| Disabled state | **Property:** *enabled* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" enabled="false"/>` | **Property:** *disabled* <br/><br/> `<ejs-checkbox id="checkbox" label="Checkbox" disabled="true"></ejs-checkbox>` |
| State persistence | **Property:** *enablePersistence* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" enable-persistence="true"/>` | **Property:** *enablePersistence* <br/><br/> `<ejs-checkbox id="checkbox" label="Checkbox" enablePersistence="true"></ejs-checkbox>` |
| RTL | **Property:** *enableRTL* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" enable-rtl="true"/>` | **Property:** *enableRtl* <br/><br/> `<ejs-checkbox id="checkbox" label="Checkbox" enableRtl="true"></ejs-checkbox>` |
| HTML Attributes | **Property:** *htmlAttributes* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" html-attributes=""/>` | Not applicable |
| Id property | **Property:** *id* <br/><br/>`<ej-check-box id="checkbox" text="sync" />` | Not applicable |
| Prefix value of Id | **Property:** *idPrefix* <br/><br/> `<ej-check-box id="checkbox"  text="Checkbox" id-prefix="aspnetcore"/>` | Not applicable |
| Name attribute | **Property:** *name* <br/><br/> `<ej-check-box id="checkbox" name="conformation" />` | **Property:** *name* <br/><br/> `<ejs-checkbox id="checkbox" name="conformation"></ejs-checkbox>` |
| Value attribute | **Property:** *value* <br/><br/> `<ej-check-box id="checkbox" name="conformation" value="Received"/>` | **Property:** *value* <br/><br/> `<ejs-checkbox id="checkbox" name="conformation" value="Received"></ejs-checkbox>` |
| Show rounded corner | **Property:** *showRoundedCorner* <br/><br/>`<ej-check-box id="checkbox"  text="Checkbox" show-rounded-corner="true"/>` | Not applicable |
| Size | **Property:** *size* <br/><br/> `<ej-check-box id="checkbox"  text="Small" size="@Size.Small" />` | **Property:** *cssClass* <br/><br/> `<ejs-checkbox id="checkbox" cssClass="e-small" label="Checkbox"></ejs-checkbox>` |
| Validation rules | **Property:** *validationRules* <br/><br/> `<ej-check-box id="checkbox" validation-rules="ViewBag.rules" />` | Not applicable |
| Validation message | **Property:** *validationMessage* <br/><br/>  `<ej-check-box id="checkbox" validation-rules="ViewBag.rules" validation-message="ViewBag.message" />` | Not applicable |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Destroy | **Method:** *destroy* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" />` <br/> var checkbox = $("#checkbox").data("ejCheckBox"); <br/> checkbox.destroy(); | **Method:** *destroy* <br/><br/> `<ejs-checkbox id="checkbox" label="Checkbox"></ejs-checkbox>` <br/>var checkbox = document.getElementById('checkbox').ej2_instances[0]; <br/>checkbox.destroy(); |
| Disable the Checkbox | **Method:** *disable* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" />` <br/> var checkbox = $("#checkbox").data("ejCheckBox"); <br/>checkbox.disable(); | Not applicable |
| Enable the Checkbox | **Method:** *enable* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" />` <br/> var checkbox = $("#checkbox").data("ejCheckBox"); <br/>checkbox.enable(); | Not applicable |
| Check state of the Checkbox | **Method:** *isChecked* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" />` <br/> var checkbox = $("#checkbox").data("ejCheckBox"); <br/>checkbox.isChecked(); | Not applicable |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| BeforeChange Event | **Events:** *beforeChange* <br/><br/> `ej-check-box id="checkbox" text="Checkbox" before-change="beforeChange" />`<br/>function beforeChange(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | Not applicable |
| Change Event | **Events:** *change* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" change="change" />`<br/>function change(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | **Events:** *change* <br/><br/> `<ejs-checkbox id="checkbox" label="Checkbox" change="change"></ejs-checkbox>`<br/>function change(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} |
| created Event | **Events:** *create* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" create="create" />`<br/>function create(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | **Events:** *created* <br/><br/> `<ejs-checkbox id="checkbox" label="Checkbox" created="created"></ejs-checkbox>`<br/>function created() {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} |
| Destroy Event | **Events:** *destroy* <br/><br/> `<ej-check-box id="checkbox" text="Checkbox" destroy="destroy" />`<br/>function destroy(args) {<br/>&nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | Not applicable |