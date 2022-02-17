---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Split Button Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Split Button component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of SplitButton component from Essential JS 1 to Essential JS 2.

## Properties

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Specifies the text of the splitbutton | **Property:** *text* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("login")` | **Property:** *content* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("Paste").Render()` |
| Popup content | **Property:** *target* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target")` | **Property:** *target* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("Paste").Target("#target").Render()` |
| Popup items | Not applicable | **Property:** *items* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("Paste").Items("ViewBag.items").Render()` |
| Arrow position | **Property:** *arrowPosition* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("login").Target("#target").ArrowPosition("@ArrowPosition.Left")` | Not applicable |
| Button mode | **Property:** *buttonMode* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("login").Target("#target").ButtonMode("@ButtonMode.Dropdown")` | Not applicable |
| Content type | **Property:** *contentType* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("login").Target("#target").ContentType("TextOnly")` | Not applicable |
| Icons | **Property:** *prefixIcon* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("login").Target("#target").ContentType("TextAndImage").PrefixIcon("e-icon e-handup")` | **Property:** *iconCss* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("Paste").Target("#target").IconCss("e-icons e-paste").Render()` |
| Icon position | **Property:** *imagePosition* <br/><br/>  `@Html.EJ().SplitButton("splitbutton").Text("login").Target("#target").ContentType("TextAndImage").PrefixIcon("e-icon e-handup").ImagePosition("@ImagePosition.ImageTop")` | **Property:** *iconPosition* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("Paste").Item("ViewBag.items").IconCss("e-icons e-paste").IconPosition(Syncfusion.EJ2.SplitButtons.SplitButtonIconPosition.Top).Render()` |
| Secondary icon | **Property:** *suffixIcon* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("login").Target("#target").ContentType("TextAndImage").PrefixIcon("e-icon e-handup").SuffixIcon("e-icon e-palette")` | Not applicable |
| Adding custom class | **Property:** *cssClass* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").CssClass("custom-class")` | **Property:** *cssClass* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").CssClass("custom-class").Render()` |
| Disabled state | **Property:** *enabled* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Enabled(false)` | **Property:** *disabled* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Target("#target").Disabled(true).Render()` |
| RTL | **Property:** *enableRTL* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").EnableRTL(true)` | **Property:** *enableRtl* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").EnableRtl(true).Render()` |
| Height | **Property:** *height* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Height(30)` | Not applicable |
| Width | **Property:** *width* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Width(100)` | Not applicable |
| HTML attributes | **Property:** *htmlAttributes* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").HtmlAttributes("")` | Not applicable |
| Show rounded corner | **Property:** *showRoundedCorner* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").ShowRoundedCorner(true)` | Not applicable |
| Size | **Property:** *size* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("Small").Target("#target").Size(ButtonSize.Small)` | **Property:** *cssClass* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("Small").Item("ViewBag.items").IconCss("e-small").Render()` |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Destroy method | **Method:** *destroy* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target")`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.destroy(); | **Method:** *destroy* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").Render()`<br/>var splitButton = document.getElementById("splitbutton").ej2_instances[0];<br/> splitButton.destroy(); |
| Disable method | **Method:** *disable* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target")`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.disable(); | Not applicable |
| Enable method | **Method:** *enable* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target")`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.enable(); | Not applicable |
| Hide popup | **Method:** *hide* <br/><br/> `<@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target")`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.hide(); | **Method:** *toggle* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").Render()`<br/>var splitButton = document.getElementById("splitbutton").ej2_instances[0];<br/> splitButton.toggle(); |
| Show popup | **Method:** *show* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target")`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.show(); | **Method:** *toggle* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").Render()`<br/>var splitButton = document.getElementById("splitbutton").ej2_instances[0];<br/> splitButton.toggle(); |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| BeforeOpen event | **Event:** *beforeOpen* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").BeforeOpen("beforeOpen")` <br/>function beforeOpen(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *beforeOpen* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").BeforeOpen("beforeOpen").Render()`<br/>function beforeOpen(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| Click event | **Event:** *click* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Click("click")` <br/>function click(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *click* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").Click("click").Render()`<br/>function click(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| Close event | **Event:** *close* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Close("close")` <br/>function close(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *close* <br/><br/> `@Html.EJs().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").Close("close")`<br/>function close(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| Create event | **Event:** *create* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Create("create")` <br/>function create(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *created* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").Created("created").Render()`<br/>function created() {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>}|
| Destroy event | **Event:** *destroy* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Destroy("destroy")` <br/>function destroy(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | Not applicable |
| ItemMouseOut event | **Event:** *itemMouseOut* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").ItemMouseOut("itemMouseOut")` <br/>function itemMouseOut(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | Not applicable |
| ItemMouseOver event | **Event:** *itemMouseOver* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").ItemMouseOver("itemMouseOver")` <br/>function itemMouseOver(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | Not applicable |
| Item select event | **Event:** *itemSelected* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Item-selected("itemSelected")` <br/>function itemSelected(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *select* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").Select("select").Render()` <br/>function select(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| Open event | **Event:** *open* <br/><br/> `@Html.EJ().SplitButton("splitbutton").Text("SplitButton").Target("#target").Open("open")` <br/>function open(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *open* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").Open("open").Render()`<br/>function open(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| BeforeClose event | Not applicable | **Event:** *beforeClose* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").Item("ViewBag.items").BeforeClose("beforeClose").Render()`<br/>function beforeClose(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| BeforeItemRender event | Not applicable | **Event:** *beforeItemRender* <br/><br/> `@Html.EJS().SplitButton("splitbutton").Content("SplitButton").BeforeItemRender("beforeItemRender").Item("ViewBag.items").Render()`<br/>function beforeItemRender(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |