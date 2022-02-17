---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Button Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Button component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Button component from Essential JS 1 to Essential JS 2.

## Properties

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Specifies the text of the button | **Property:** *text* <br/><br/> `@Html.EJ().Button("btn").Text("Button")` | **Property:** *content* <br/><br/> `@Html.EJS().Button("btn").Content("Button").Render()` |
| Specifies the content type of the button | **Property:** *ContentType* <br/><br/>  `@Html.EJ().Button("btn").Text("Save").ContentType(ContentType.TextAndImage).PrefixIcon("e-icon e-save")`| Not applicable |
| Specifies icon for the button | **Property:** *prefixIcon* <br/><br/> `@Html.EJ().Button("btn").ContentType(ContentType.ImageOnly).PrefixIcon("e-icon e-save")` | **Property:** *iconCss* <br/><br/> `@Html.EJS().Button("btn").IconCss("e-icons e-save").Render()` |
| Positioning icon in the button | **Property:** *imagePosition* <br/><br/> `@Html.EJ().Button("btn").Text("Save").ContentType(ContentType.TextAndImage).PrefixIcon("e-icon e-save").ImagePosition(ImagePosition.ImageRight)`| **Property:** *iconPosition* <br/><br/> `@Html.EJS().Button("btn").Content("Save").IconCss("e-icons e-save").IconPosition(Syncfusion.EJ2.Buttons.IconPosition.Right).Render()` |
| Specifies secondary icon for the button | **Property:** *suffixIcon* <br/><br/> `@Html.EJ().Button("btn").Text("Save").ContentType(ContentType.TextAndImage).PrefixIcon("e-icon e-save").SuffixIcon("e-icon e-file-html")` | Not applicable |
| Adding custom class | **Property:** *cssClass* <br/><br/> `@Html.EJ().Button("btn").Text("Button").Size(ButtonSize.Small).CssClass("custom-class")` | **Property:** *cssClass* <br/><br/> `@Html.EJS().Button("btn").Content("Button").CssClass("custom-class").Render()` |
| Specifies the size of the button | **Property:** *size* <br/><br/> `@Html.EJ().Button("btn").Text("Button").Size(ButtonSize.Small)` | **Property:** *cssClass* <br/><br/> `@Html.EJS().Button("btn").Content("Button").CssClass("e-small").Render()` |
| Triggers click event repeatedly while pressing the button | **Property:** *repeatButton* <br/><br/> `@Html.EJ().Button("btn").Text("Click").RepeatButton(true)` | Not applicable |
| Sets time interval between two consecutive click event on the repeat button | **Property:** *timeInterval* <br/><br/> `@Html.EJ().Button("btn").Text("Click").RepeatButton(true).TimeInterval("100")` | Not applicable |
| Specifies the type of the button | **Property:** *type* <br/><br/> `@Html.EJ().Button("btn").Text("Submit").Type(ButtonType.Submit)` | Not applicable |
| Changes normal button into rounded corner | **Property:** *showRoundedCorner* <br/><br/>  `@Html.EJ().Button("btn").Text("Button").ShowRoundedCorner(true)` | Not applicable |
| Specifies the width of the button | **Property:** *width* <br/><br/> `@Html.EJ().Button("btn").Text("Button").Width("150px")` | Not applicable |
| Specifies the height of the button | **Property:** *height* <br/><br/> `@Html.EJ().Button("btn").Text("Button").Height("50px")` | Not applicable |
| Adds HTML attributes to the button | **Property:** *htmlAttributes* <br/><br/> `@Html.EJ().Button("btn").Text("Button").HtmlAttributes("")` | Not applicable |
| Allows the appearance of the Button to be enhanced and visually appealing | Not applicable | **Property:** *isPrimary* <br/><br/> `@Html.EJS().Button("btn").Content("Button").IsPrimary(true).Render()` |
| Makes the button toggle from normal to active state | **Property:** *isToggle* <br/><br/> Not applicable | **Property:** *isToggle* <br/><br/> `@Html.EJS().Button("btn").Content("Button").IsToggle(true).Render()`  |
| Specifies the disabled state of the button | **Property:** *enabled* <br/><br/> `@Html.EJ().Button("btn").Text("Button").Enabled(false)` | **Property:** *disabled* <br/><br/> `@Html.EJS().Button("btn").Content("Button").Disabled(true).Render()` |
| Enable or disable rendering component in right to left direction | **Property:** *enableRTL* <br/><br/>  `@Html.EJ().Button("btn").Text("Save").ContentType(ContentType.TextAndImage).PrefixIcon("e-icon e-save").EnableRtl(true)` | **Property:** *enableRtl* <br/><br/> `@Html.EJS().Button("btn").Content("Save")IconCss("e-icon e-save").EnableRtl(true).Render()` |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Destroys the control | **Methods:** *destroy* <br/><br/> `@Html.EJ().Button("btn").Text("Button")` <br/> var btnObj = $("#btn").data("ejButton");<br/>btnObj.destroy(); | **Methods:** *destroy* <br/><br/> `@Html.EJS().Button("btn").Content("Button").Render()` <br/> var btnObj = document.getElementById("btn").ej2_instances[0];<br/>btnObj.destroy(); |
| Disables the button | **Methods:** *disable* <br/><br/> `@Html.EJ().Button("btn").Text("Button")`<br/> var btnObj = $("#btn").data("ejButton");<br/>btnObj.disable(); | Not applicable |
| Enables the button | **Methods:** *enable* <br/><br/> `@Html.EJ().Button("btn").Text("Button")`<br/> var btnObj = $("#btn").data("ejButton");<br/>btnObj.enable(); | Not applicable |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Triggers while clicking the button | **Events:** *click* <br/><br/> `@Html.EJ().Button("btn").Text("Button").Click("btnClick")` <br/>function btnClick(args) {<br/>/** code block */<br/>} | Not applicable |
| Triggers once the component rendering is completed | **Events:** *create* <br/><br/> `@Html.EJ().Button("btn").Text("Button").ClientSideEvents(e => e.Create("create")` <br/>function create(args) {<br/>/** code block */<br/>} | **Events:** *created* <br/><br/> `@Html.EJS().Button("btn").Content("Button").Created("created").Render()`<br/>function created() {<br/>/** code block */<br/>} |
| Triggers once the component is destroyed | **Events:** *destroy* <br/><br/> `@Html.EJ().Button("btn").Text("Button").Destroy("destroy")` <br/>function destroy(args) {<br/>/** code block */<br/>} | Not applicable |