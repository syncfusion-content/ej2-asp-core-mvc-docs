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
| Checkbox label | **Property:** *text* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox")` | **Property:** *label* <br/><br/> `@Html.EJS().CheckBox("checkbox").Label("Checkbox").Render()` |
| Checked state | **Property:** *enableTriState and checkState* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checked state").EnableTriState(true).CheckState(CheckState.Check)` | **Property:** *checked* <br/><br/> `@Html.EJS().CheckBox("checkbox").Checked(true).Label("Checked state").Render()` |
| Indeterminate state | **Property:** *enableTriState and checkState* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Indeterminate state").EnableTriState(true).CheckState(CheckState.Indeterminate)` | **Property:** *indeterminate* <br/><br/> `@Html.EJS().CheckBox("checkbox").Indeterminate(true).Label("Indeterminate state").Render()` |
| Adding custom css class | **Property:** *cssClass* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").CssClass("custom-class")` | **Property:** *cssClass* <br/><br/> `@Html.EJS().CheckBox("checkbox").CssClass("custom-class").Label("Checkbox").Render()` |
| Label position | Not applicable | **Property:** *labelPosition* <br/><br/> `@Html.EJS().CheckBox("checkbox").Label("Checkbox").LabelPosition(Syncfusion.EJ2.Buttons.LabelPosition.Before).Render()` |
| Disabled state | **Property:** *enabled* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").Enabled(false)` | **Property:** *disabled* <br/><br/> `@Html.EJS().CheckBox("checkbox").Disabled(true).Label("Checkbox").Render()` |
| State persistence | **Property:** *enablePersistence* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").EnablePersistence(true)` | **Property:** *enablePersistence* <br/><br/> `@Html.EJS().CheckBox("checkbox").EnablePersistence(true).Label("Checkbox").Render()` |
| RTL | **Property:** *enableRTL* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").EnableRTL(true)` | **Property:** *enableRtl* <br/><br/> `@Html.EJS().CheckBox("checkbox").EnableRtl(true).Label("Checkbox").Render()` |
| HTML Attributes | **Property:** *htmlAttributes* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").HtmlAttributes("")` | Not applicable |
| Id property | **Property:** *id* <br/><br/>`@Html.EJ().CheckBox("checkbox").Id("sync")` | Not applicable |
| Prefix value of Id | **Property:** *idPrefix* <br/><br/> `@Html.EJ().CheckBox("checkbox").IdPrefix("JS")` | Not applicable |
| Name attribute | **Property:** *name* <br/><br/> `@Html.EJ().CheckBox("checkbox").Name("Conformation"` | **Property:** *name* <br/><br/> `@Html.EJS().CheckBox("checkbox").Name("Conformation").Render()` |
| Value attribute | **Property:** *value* <br/><br/> `@Html.EJ().CheckBox("checkbox").Name("Conformation").Value("received")` | **Property:** *value* <br/><br/> `@Html.EJS().CheckBox("checkbox").Name("Conformation").Value("received").Render()` |
| Show rounded corner | **Property:** *showRoundedCorner* <br/><br/>`@Html.EJ().CheckBox("checkbox")..ShowRoundedCorner(true).Text("Checkbox")` | Not applicable |
| Size | **Property:** *size* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Small").Size(Size.Small)` | **Property:** *cssClass* <br/><br/> `@Html.EJS().CheckBox("checkbox").CssClass("e-small").Label("Checkbox").Render()` |
| Validation rules | **Property:** *validationRules* <br/><br/> `@Html.EJ().CheckBox("checkbox").ValidationRules(ViewBag.rules)` | Not applicable |
| Validation message | **Property:** *validationMessage* <br/><br/> `@Html.EJ().CheckBox("checkbox").ValidationRules(ViewBag.rules).ValidationMessage(ViewBag.message)` | Not applicable |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Destroy | **Method:** *destroy* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox")` <br/> var checkbox = $("#checkbox").data("ejCheckBox"); <br/> checkbox.destroy(); | **Method:** *destroy* <br/><br/> `@Html.EJS().CheckBox("checkbox").Label("Checkbox").Render()` <br/>var checkbox = document.getElementById('checkbox').ej2_instances[0]; <br/>checkbox.destroy(); |
| Disable the Checkbox | **Method:** *disable* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox")` <br/> var checkbox = $("#checkbox").data("ejCheckBox"); <br/>checkbox.disable(); | Not applicable |
| Enable the Checkbox | **Method:** *enable* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox")` <br/> var checkbox = $("#checkbox").data("ejCheckBox"); <br/>checkbox.enable(); | Not applicable |
| Check state of the Checkbox | **Method:** *isChecked* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox")` <br/> var checkbox = $("#checkbox").data("ejCheckBox"); <br/>checkbox.isChecked(); | Not applicable |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| BeforeChange Event | **Events:** *beforeChange* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").BeforeChange("beforeChange")`* <br/><br/>function beforeChange(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | Not applicable |
| Change Event | **Events:** *change* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").Change("change")`* <br/><br/>function change(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | **Events:** *change* <br/><br/> `@Html.EJS().CheckBox("checkbox").Label("Checkbox").Change("change").Render()`* <br/><br/>function change(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} |
| created Event | **Events:** *create* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").Create("create")`* <br/><br/>function create(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | **Events:** *created* <br/><br/> `@Html.EJS().CheckBox("checkbox").Label("Checkbox").Created("created").Render()`* <br/><br/>function created() {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} |
| Destroy Event | **Events:** *destroy* <br/><br/> `@Html.EJ().CheckBox("checkbox").Text("Checkbox").Destroy("destroy")`* <br/><br/>function destroy(args) {<br/>&nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | Not applicable |