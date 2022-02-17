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
| Label | **Property:** *text* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton")` | **Property:** *label* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").Render()` |
| Checked state | **Property:** *checked* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").Checked(true)` | **Property:** *checked* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").Checked(true).Render()` |
| Adding custom css class | **Property:** *cssClass* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").CssClass("custom-class")` | **Property:** *cssClass* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").CssClass("custom-class").Render()` |
| Disabled state | **Property:** *enabled* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").Enabled(false)` | **Property:** *disabled* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").Disabled(true).Render()` |
| State persistence | **Property:** *enablePersistence* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").EnablePersistence(true)` | **Property:** *enablePersistence* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").EnablePersistence(true).Render()` |
| RTL | **Property:** *enableRTL* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").EnableRTL(true)` | **Property:** *enableRtl* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").EnableRtl(true).Render()` |
| HTML Attributes | **Property:** *htmlAttributes* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").HtmlAttributes("")` | Not applicable |
| Id property | **Property:** *id* <br/><br/>`@Html.EJ().RadioButton("radio").Id("sync")` | Not applicable |
| Prefix value of Id | **Property:** *idPrefix* <br/><br/> `@Html.EJ().RadioButton("radio").IdPrefix("ej")` | Not applicable |
| Name attribute | **Property:** *name* <br/><br/> `@Html.EJ().RadioButton("radio").Text("Male").Name("gender")` | **Property:** *name* <br/><br/> `@Html.EJS().RadioButton("radio").Label("Male").Name("gender").Render()` |
| Value attribute | **Property:** *value* <br/><br/> `@Html.EJ().RadioButton("radio").Text("Male").Name("gender").Value("male")` | **Property:** *value* <br/><br/> `@Html.EJS().RadioButton("radio").Label("Male").Name("gender").Value("male").Render()` |
| Size | **Property:** *size* <br/><br/> `@Html.EJ().RadioButton("radio").Text("Small").Size(RadioButtonSize.Small)` | **Property:** *size* <br/><br/> `@Html.EJS().RadioButton("radio").Label("Small").CssClass("e-small").Render()` |
| Validation rules | **Property:** *validationRules* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").ValidationRules(ViewBag.rules)` | Not applicable |
| Validation message | **Property:** *validationMessage* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").ValidationRules(ViewBag.rules).ValidationMessage(ViewBag.message)` | Not applicable |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Destroy | **Method:** *destroy* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton")` <br/> var radiobutton = $("#radio").data("ejRadioButton");<br/>radioButton.destroy(); | **Method:** *destroy* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").Render()` <br/> var radiobutton = document.getElementById('radio').ej2_instances[0]; <br/>radioButton.destroy(); |
| Disable the RadioButton | **Method:** *disable* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton")` <br/> var radiobutton = $("#radio").data("ejRadioButton");<br/>radioButton.disable(); | Not applicable |
| Enable the RadioButton | **Method:** *enable* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton")` <br/> var radiobutton = $("#radio").data("ejRadioButton");<br/>radioButton.enable(); | Not applicable |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| BeforeChange Event | **Event:** *beforeChange* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").BeforeChange("beforeChange")`* <br/><br/>function beforeChange(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | Not applicable |
| Change Event | **Event:** *change* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").Change("change")`* <br/><br/>function change(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | **Event:** *change* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").Change("change").Render()`* <br/><br/>function change(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} |
| Create Event | **Event:** *create* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").Create("create")`* <br/><br/>function create(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | **Event:** *created* <br/><br/> `@Html.EJS().RadioButton("radio").Label("RadioButton").Created("created").Render()`* <br/><br/>function created() {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} |
| Destroy Event | **Event:** *destroy* <br/><br/> `@Html.EJ().RadioButton("radio").Text("RadioButton").Destroy("destroy")`* <br/><br/>function destroy(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp;/** code block */ <br/>} | Not applicable |