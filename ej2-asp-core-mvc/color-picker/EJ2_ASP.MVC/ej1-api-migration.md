---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Color Picker Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Color Picker component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---

﻿
# Migration from Essential JS 1

This article describes the API migration process of ColorPicker component from Essential JS 1 to Essential JS 2.

## Properties

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Default |**property:** *value* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Value("#278787")` | **property:** *value* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Value("#278787").Render()` |
| Inline mode color picker | **property:** *displayInline* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").DisplayInline(true).TagName("div")` | **property:** *inline* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Inline(true).Render()` |
| Adding custom class | **property:** *cssClass* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").CssClass ("e-custom")` | **property:** *cssClass* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").CssClass.("e-custom").Render()` |
| Disable the ColorPicker component | **property:** *enabled* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Enabled(false)` | **property:** *disabled* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Disabled(true).Render()` |
| To display custom text in button elements | **property:** *buttonText* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ColorPickerButtonText(color=>` <br/> &nbsp; `color.Apply("Apply").Cancel("Cancel"))` | Not Applicable |
 |To display customized text or content when mouse over the color picker elements | **property:** *tooltipText* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ColorPickerTooltipText(tooltip=>` <br/> &nbsp; `tooltip.Switcher("Switch").Sandy("arenoso"))` | Not Applicable |
| Disable / hide opacity | **property:** *enableOpacity* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").EnableOpacity(false)` | **property:** *enableOpacity* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").enableOpacity(false).Render()` |
| ColorPicker Button mode | **property:** *buttonMode* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ButtonMode(ButtonMode.Dropdown)` | Not Applicable |
| To show / hide the control (apply /  cancel) buttons | **property:** *showApplyCancel* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ShowApplyCancel(false)` | **property:** *showButtons* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").ShowButtons(false).Render()` |
| To show / hide the clear button | **property:** *showClearButton* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ShowClearButton(false)` | Not Applicable |
| Show / hide the mode (picker / palette) switcher | **property:** *showSwitcher* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ShowSwitcher(false)` | **property:** *modeSwitcher* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").ModeSwitcher(false).Render()` |
| To show / hide the preview area | **property:** *showPreview* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ShowPreview(false)` | Not Applicable |
| To show / hide the recent selected color list | **property:** *showRecentColors* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ShowRecentColors(true)` | Not Applicable |
| To show / hide the color picker slider tooltip | **property:** *showTooltip* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ShowTooltip(false)` | Not Applicable |
| Custom icon in dropdown control color area | **property:** *toolIcon* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ToolIcon("e-font-icon")` | Not Applicable |
| ColorPicker mode | **property:** *modelType* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").(ModelType.Picker)` | **property:** *mode* <br/><br/> `@Html.EJS().ColorPicker("colorpicker")` <br/> &nbsp; `.Mode(Syncfusion.EJ2.Inputs.ColorPickerMode.Palette)).Render()` |
| Opacity value | **property:** *opacityValue* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").OpacityValue(80)` | Not Applicable |
| Number of columns in color palette | **property:** *columns* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Columns(10)` | **property:** *columns* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Columns(15).Render()` |
| Custom colors | **property:** *palette* <br/><br/>  `@Html.EJ().ColorPicker("colorpicker").Palette(PaletteType.CustomPalette)` <br/> &nbsp; `.ModelType(ModelType.Palette).Custom(@ViewBag.colors)` <br/> List<*String*> colors = new List<*string*> { "ffffff", "ffccff",  "ff99ff", "ff66ff", "ff33ff", "ff00ff", "ccffff", "ccccff", "cc99ff", "cc66ff", "cc33ff", "cc00ff", "99ffff", "99ccff", "9999ff", "9966ff", "9933ff", "9900ff", "ffffcc", "ffcccc" }; <br/> ViewBag.colors = colors; | **property:** *presetColors* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").PresetColors(@ViewBag.colors)` <br/> &nbsp; `.Render()` <br/> List<*object*> custom = new List<*object*>() { <br/> Custom = new *string[]* { "ffffff", "ffccff",  "ff99ff", "ff66ff", "ff33ff", "ff00ff", "ccffff", "ccccff", "cc99ff", "cc66ff", "cc33ff", "cc00ff", "99ffff", "99ccff", "9999ff", "9966ff", "9933ff", "9900ff", "ffffcc", "ffcccc" } <br/> }; <br/> ViewBag.colors = colors[0]; |
| Rendering palette from the predefined set of palettes |**property:** *presetType* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").ModelType(ModelType.Palette)` <br/> &nbsp; `.PresetType(PresetsType.FlatColors)` | Not Applicable |
| No color option in color palette | Not Applicable | **property:** *noColor* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").NoColor(true).ModeSwitcher(false)` <br/> &nbsp; `.Mode(Syncfusion.EJ2.Inputs.ColorPickerMode.Palette)).Render()` |
| Localization | **property:** *locale* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Locale("zh-CN")` <br/> **scripts:** <br/> ej.ColorPicker.Locale["zh-CN"] = { <br/> &nbsp; buttonText: { <br/> &nbsp;  &nbsp; apply: "应用", <br/> &nbsp;  &nbsp; cancel: "取消", <br/> &nbsp;  &nbsp; swatches: "色板" <br/> &nbsp; }, <br/> &nbsp; tooltipText: { <br/> &nbsp;  &nbsp; switcher: "切换器, <br/> &nbsp;  &nbsp; addButton: "添加颜色", <br/> &nbsp;  &nbsp; basic: "基本"<br/> &nbsp; } <br/> } | **property:** *locale* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Locale("ar").Render()` <br/> **scripts:** <br/> ej.base.L10n.load({ <br/> &nbsp; 'ar': { <br/> &nbsp;  &nbsp; "colorpicker": { <br/> &nbsp;  &nbsp;  &nbsp; "Apply":"تطبيق", <br/> &nbsp;  &nbsp;  &nbsp; "Cancel":"إلغاء", <br/> &nbsp;  &nbsp;  &nbsp; "ModeSwitcher": "مفتاح كهربائي الوضع" <br/> &nbsp;  &nbsp; } <br/> &nbsp; } <br/> }); |
| Right to left | **property:** *enableRTL* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").EnableRTL(true)` |**property:** *enableRtl* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").EnableRtl(true).Render()` |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Method to open color picker popup | **Method:** *show* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")` <br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.show(); | **Method:** *toggle* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Render()` <br/> var colorPickerObj = document.getElementById("colorpicker").ej2_instances[0]; <br/> colorPickerObj.toggle();|
| Method to close color picker popup | **Method:** *hide* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")` <br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.hide(); | **Method:** *toggle* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Render()` <br/> var colorPickerObj = document.getElementById("colorpicker").ej2_instances[0]; <br/>colorPickerObj.toggle(); |
| Enable the color picker control | **Method:** *enable* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")` <br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.enable(); | Not Applicable |
| Disables the color picker control | **Method:** *disable* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")` <br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.disable(); | Not Applicable |
| Method returns the selected color value as hex code | **Method:** *getValue* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")` <br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.getValue(); | **Method:** *getValue* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Render()` <br/> var colorPickerObj = document.getElementById("colorpicker").ej2_instances[0]; <br/>colorPickerObj.getValue(); |
| Method returns the selected color value in RGB format | **Method:** *getColor* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")` <br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.getColor(); | **Method:** *getValue* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Render()` <br/> var colorPickerObj = document.getElementById("colorpicker").ej2_instances[0]; <br/>colorPickerObj.getValue(null, 'RGB'); |
| Method convert the color value from hexCode to RGB  | **Method:** *hexCodeToRGB*  <br/><br/> `@Html.EJ().ColorPicker("colorpicker")` <br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/>colorPickerObj.hexCodeToRGB("#278787"); | **Method:** *getValue* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Render()` <br/> var colorPickerObj = document.getElementById("colorpicker").ej2_instances[0]; <br/>colorPickerObj.getValue("#278787", 'RGB'); |
| Method convert the color value from RGB to Hex code | **Method:** *RGBToHEX* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")` <br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.RGBToHEX({r:38,g:133,b:133}); | **Method:** *getValue* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Render()` <br/> var colorPickerObj = document.getElementById("colorpicker").ej2_instances[0]; <br/>colorPickerObj.getValue("rgb(38,133,133)", 'Hex'); |
| Method convert the color value from RGB to HSV | **Method:** *RGBToHSV* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")`<br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.RGBToHSV({h:230,s:98,v:98}); | **Method:** *getValue* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Render()` <br/> var colorPickerObj = document.getElementById("colorpicker").ej2_instances[0]; <br/>colorPickerObj.getValue("rgb(180,71.1,52.9)", 'HSV'); |
| Method convert the color value from HSV to RGB | **Method:** *HSVToRGB* <br/><br/> `@Html.EJ().ColorPicker("colorpicker")`<br/> var colorPickerObj = $("#colorpicker").data("ejColorPicker"); <br/> colorPickerObj.HSVToRGB({h:230,s:98,v:98}); | **Method:** *getValue* <br/><br/>  `@Html.EJS().ColorPicker("colorpicker").Render()` <br/> var colorPickerObj = document.getElementById("colorpicker").ej2_instances[0]; <br/>colorPickerObj.getValue("hsv(180,71.1,52.9)", 'RGB'); |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Event triggers before opening the ColorPicker popup | Not Applicable | **Event:** *beforeOpen* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").BeforeOpen("beforeOpen").Render()` <br/> function beforeOpen(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } |
| Event triggers before closing the ColorPicker popup | Not Applicable | **Event:** *beforeClose* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").BeforeClose("beforeClose").Render()` <br/> function beforeClose(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } |
| Event triggers after opening the ColorPicker popup |**Event:** *open*<br/><br/> `@Html.EJ().ColorPicker("colorpicker").Open("open")` <br/> function open(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } | **Event:** *open* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Open("open").Render()` <br/> function open(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } |
| Event triggers after closing the ColorPicker popup | **Event:** *close* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Close("close")` <br/> function close(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } | Not Applicable |
| Event triggers once the component rendering is completed | **Event:** *create* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Create("create")` <br/> function create(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } | **Event:** *created* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Created("created").Render()` <br/> function created() { <br/> &nbsp; &nbsp; /** code block */ <br/> } |
| Event triggers once the color picker control is destroyed | **Event:** *destroy* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Destroy("destroy")` <br/> function destroy(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } | Not Applicable |
| Event triggers before Switching between Picker / Palette mode | Not Applicable | **Event:** *beforeModeSwitch* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").BeforeModeSwitch("beforeModeSwitch").Render()` <br/> function beforeModeSwitch(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } |
| Event triggers after color value has been selected | **Event:** *select* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Select("select")` <br/> function select(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } | **Event:** *select* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Select("select").Render()` <br/> function select(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } |
|Event triggers after color value has been changed| **Event:** *change* <br/><br/> `@Html.EJ().ColorPicker("colorpicker").Change("change")` <br/> function change(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } | **Event:** *change* <br/><br/> `@Html.EJS().ColorPicker("colorpicker").Change("change").Render()` <br/> function change(args) { <br/> &nbsp; &nbsp; /** code block */ <br/> } |
