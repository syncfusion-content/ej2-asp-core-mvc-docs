---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Range Slider Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Slider component from Essential JS 1 to Essential JS 2.

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Max value | **Property:**  *maxValue*  <br  /> `<ej-slider id="slider" max-value="100" />` | **Property:**  *max*  <br  /> `<ejs-slider id="slider" max="100" />` |
| Min value | **Property:**  *minValue*  <br  /> `<ej-slider id="slider" min-value="30" />`| **Property:**  *min*  <br  /> `<ejs-slider id="slider" min="10" />` |
| Step | **Property:**  *incrementStep, largeStep, smallStep, showSmallTicks*  <br  /> `<ej-slider id="slider" increment-step="20" small-step="5" large-step="40" show-small-ticks="true" show-scale="true" />`| **Property:**  *ticks*  <br  /> `<ejs-slider id="slider" ticks="new Syncfusion.EJ2.Inputs.SliderTicksData { Placement=Syncfusion.EJ2.Inputs.Placement.After, LargeStep=20, SmallStep=10, ShowSmallTicks=true }" />` |
| Type | **Property:**  *sliderType*  <br  /> `<ej-slider id="slider" slider-type="Range" />` | **Property:**  *type*  <br  /> `<ejs-slider id="slider" type="Range" />` |
| Tooltip | **Property:**  *showTooltip*  <br  /> `<ej-slider id="slider" show-tooltip="true" />` | **Property:**  *tooltip*  <br  /> `<ejs-slider id="slider" tooltip="new Syncfusion.EJ2.Inputs.SliderTooltipData { Placement=Syncfusion.EJ2.Inputs.TooltipPlacement.After, IsVisible=true, ShowOn=Syncfusion.EJ2.Inputs.TooltipShowOn.Always }" />` |
| RTL | **Property:**  *enableRTL*  <br  /> `<ej-slider id="slider" enable-rtl="true" />` | **Property:**  *enableRtl*  <br  /> `<ejs-slider id="slider" enableRtl="true" />` |
| Custom values | **Not Applicable** | **Property:**  *customValues*  <br  /> `String[] values = { "Mon", "Tue", "Wed" };` <br/> `ViewBag.customValues = values;` <br/> <br/> `<ejs-slider id="slider" customValues="@ViewBag.customValues" />` |
| Limit the slider movement | **Not Applicable** | **Property:**  *limits*  <br  /> `<ejs-slider id="slider" limits="new Syncfusion.EJ2.Inputs.SliderLimitData {Enabled=true, MinEnd=30, MinStart=10 }" />` |
| Disable | **Method:**  *disable*  <br  /> `<ej-slider id="slider" />` <br/><br/> `var sliderObj = $("#slider").ejSlider("instance");` <br/> `sliderObj.disable();` | **Property:**  *enabled*  <br  /> `<ejs-slider id="slider" />` <br/> <br/> `var sliderObj = document.getElementById('slider').ej2_instances[0];` <br/> `sliderObj.enabled = false;` |
| Enable | **Method:**  *enable*  <br  /> `<ej-slider id="slider" />` <br/><br/> `var sliderObj = $("#slider").ejSlider("instance");` <br/> `sliderObj.enable();` | **Property:**  *enabled*  <br  /> `<ejs-slider id="slider" enabled="false" />` <br/> <br/> `var sliderObj = document.getElementById('slider').ej2_instances[0];` <br/> `sliderObj.enabled = true;` |
| Set Value | **Method:**  *setValue(value ,[enableAnimation])*  <br  /> `<ej-slider id="slider" />`<br/><br/> `var sliderObj = $("#slider").ejSlider("instance");` <br/> `sliderObj.setValue(50);` | **Property:**  *value*  <br  /> `<ejs-slider id="slider" />` <br/> <br/> `var sliderObj = document.getElementById('slider').ej2_instances[0];` <br/> `sliderObj.value = 30;` |
| Get Value | **Method:**  *getValue()*  <br  /> `<ej-slider id="slider" />`<br/><br/> `var sliderObj = $("#slider").ejSlider("instance");` <br/> `sliderObj.getValue();` | **Property:**  *value*  <br  /> `<ejs-slider id="slider" value="50" />` <br/><br/> `var sliderObj = document.getElementById('slider').ej2_instances[0];` <br/> `var value = sliderObj.value;` |
| Destroy | **Not Applicable** | **Method:**  *destroy()*  <br  /> `<ejs-slider id="slider" value="50" />`<br/><br/> `var sliderObj = document.getElementById('slider').ej2_instances[0];` <br/> `sliderObj.destroy();` |
| Change | **Event:**  *change*  <br  /> `<ej-slider id="slider" change="onChange" />` <br/><br/> `function onChange(args) { }` | **Event:**  *changed*  <br  /> `<ejs-slider id="slider" changed="onChanged" />` <br/><br/> `function onChanged(args) { }` |
| Create | **Event:**  *create*  <br  /> `<ej-slider id="slider" create="onCreate" />` <br/><br/> `function onCreate(args) { }` | **Event:**  *created*  <br  /> `<ejs-slider id="slider" created="onCreated" />` <br/><br/> `function onCreated(args) { }` |
| Slide | **Event:**  *slide*  <br  /> `<ej-slider id="slider" slide="onSlide" />` <br/><br/> `function onSlide(args) { }` | **Event:**  *change*  <br  /> `<ejs-slider id="slider" change="onChange" />` <br/><br/> `function onChange(args) { }` |
| Start | **Event:**  *start*  <br  /> `<ej-slider id="slider" start="onStart" />` <br/><br/> `function onStart(args) { }` | **Event:**  *created*  <br  /> `<ejs-slider id="slider" created="onCreated" />` <br/><br/> `function onCreated(args) { }` |
| Stop | **Event:**  *stop*  <br  /> `<ej-slider id="slider" stop="onStop" />` <br/><br/> `function onStop(args) { }` | **Event:**  *changed*  <br  /> `<ejs-slider id="slider" changed="onChanged" />` <br/><br/> `function onChanged(args) { }`|
| Rendered Ticks | **Not Applicable** | **Event:**  *renderedTicks*  <br  /> `<ejs-slider id="slider" renderedTicks="onRenderedTicks" />` <br/><br/> `function onRenderedTicks(args) { }` |
