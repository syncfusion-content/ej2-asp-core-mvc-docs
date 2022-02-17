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
| Max value | **Property:**  *MaxValue*  <br/><br/>  `Html.EJ().Slider("slider").MaxValue(50)` | **Property:**  *Max*  <br/><br/>  `@Html.EJS().Slider("slider").Max(50)` |
| Min value | **Property:**  *MinValue*  <br/><br/>  `Html.EJ().Slider("slider").MinValue(50)`| **Property:**  *Min*  <br/><br/>  `@Html.EJS().Slider("slider").Min(50)` |
| Step | **Property:**  *IncrementStep, LargeStep, SmallStep, ShowSmallTicks*  <br/><br/>  `Html.EJ().Slider("slider").IncrementStep(20).LargeStep(20)`<br/>`.SmallStep(10).ShowSmallTicks(true).ShowScale(true)`| **Property:**  *Ticks*  <br/><br/>  `@Html.EJS().Slider("slider").Ticks(new SliderTicksData { ShowSmallTicks = true, LargeStep = 20, SmallStep = 5, Placement = Placement.After })` |
| Type | **Property:**  *SliderType*  <br/><br/>  `Html.EJ().Slider("slider").SliderType(SlideType.Range)` | **Property:**  *Type*  <br/><br/>  `@Html.EJS().Slider("slider").Type(SliderType.Range)` |
| Tooltip | **Property:**  *ShowTooltip*  <br/><br/>  `Html.EJ().Slider("slider").ShowTooltip(true)` | **Property:**  *Tooltip*  <br/><br/>  `@Html.EJS().Slider("slider").Tooltip(new SliderTooltipData { Placement = TooltipPlacement.After, IsVisible = true })` |
| RTL | **Property:**  *EnableRTL*  <br/><br/>  `Html.EJ().Slider("slider").EnableRTL(true)` | **Property:**  *EnableRtl*  <br/><br/>  `@Html.EJS().Slider("slider").EnableRtl(true)` |
| Custom values | **Not Applicable** | **Property:**  *CustomValues*  <br/><br/>  `String[] values = { "Mon", "Tue", "Wed" };`  <br/>  `ViewBag.customValues = values;`  <br/>  <br/>  `@Html.EJS().Slider("slider").CustomValues(ViewBag.customValue)` |
| Limit the slider movement | **Not Applicable** | **Property:**  *Limits*  <br/><br/>  `@Html.EJS().Slider("slider").Limits(new SliderLimitData { Enabled = true, MinStart = 20, MinEnd = 40 })` |
| Disable | **Method:**  *disable*  <br/><br/>  `@Html.EJ().Slider("slider")`  <br/><br/>  `var sliderObj = $("#slider").ejSlider("instance");`  <br/>  `sliderObj.disable();` | **Property:**  *Enabled*  <br/><br/>  `@Html.EJS().Slider("slider")`  <br/>  <br/>  `var sliderObj = document.getElementById('slider').ej2_instances[0];`  <br/>  `sliderObj.enabled = false;` |
| Enable | **Method:**  *enable*  <br/><br/>  `@Html.EJ().Slider("slider")`  <br/><br/>  `var sliderObj = $("#slider").ejSlider("instance");`  <br/>  `sliderObj.enable();` | **Property:**  *Enabled*  <br/><br/>  `@Html.EJ().Slider("slider").Enabled(false)`  <br/>  <br/>  `var sliderObj = document.getElementById('slider').ej2_instances[0];`  <br/>  `sliderObj.enabled = true;` |
| Set Value | **Method:**  *setValue(value ,[enableAnimation])*  <br/><br/>  `@Html.EJ().Slider("slider")`<br/><br/>  `var sliderObj = $("#slider").ejSlider("instance");`  <br/>  `sliderObj.setValue(50);` | **Property:**  *value*  <br/><br/>  `@Html.EJS().Slider("slider").Enabled(false)`  <br/>  <br/>  `var sliderObj = document.getElementById('slider').ej2_instances[0];`  <br/>  `sliderObj.value = 30;` |
| Get Value | **Method:**  *getValue()*  <br/><br/>  `@Html.EJ().Slider("slider")`<br/><br/>  `var sliderObj = $("#slider").ejSlider("instance");`  <br/>  `sliderObj.getValue();` | **Property:**  *value*  <br/><br/>  `@Html.EJS().Slider("slider").Value(50)`  <br/><br/>  `var sliderObj = document.getElementById('slider').ej2_instances[0];`  <br/>  `var value = sliderObj.value;` |
| Destroy | **Not Applicable** | **Method:**  *destroy()*  <br/><br/>  `@Html.EJS().Slider("slider").Value(50)`<br/><br/>  `var sliderObj = document.getElementById('slider').ej2_instances[0];`  <br/>  `sliderObj.destroy();` |
| Change | **Event:**  *Change*  <br/><br/>  `@Html.EJ().Slider("slider").ClientSideEvents(e => e.Change("onChange"))`  <br/><br/>  `function onChange(args) { }` | **Event:**  *Changed*  <br/><br/>  `@Html.EJS().Slider("slider").Changed("onChanged")`  <br/><br/>  `function onChanged(args) { }` |
| Create | **Event:**  *Create*  <br/><br/>  `@Html.EJ().Slider("slider").ClientSideEvents(e => e.Create("onCreate"))`  <br/><br/>  `function onCreate(args) { }` | **Event:**  *Created*  <br/><br/>  `@Html.EJS().Slider("slider").Created("onCreated")`  <br/><br/>  `function onCreated(args) { }` |
| Slide | **Event:**  *Slide*  <br/><br/>  `@Html.EJ().Slider("slider").ClientSideEvents(e => e.Slide("onSlide"))`  <br/><br/>  `function onSlide(args) { }` | **Event:**  *Change*  <br/><br/>  `@Html.EJS().Slider("slider").Change("onChange")`  <br/><br/>  `function onChange(args) { }` |
| Start | **Event:**  *Start*  <br/><br/>  `@Html.EJ().Slider("slider").ClientSideEvents(e => e.Start("onStart"))`  <br/><br/>  `function onStart(args) { }` | **Event:**  *Created*  <br/><br/>  `@Html.EJS().Slider("slider").Created("onCreated")`  <br/><br/>  `function onCreated(args) { }` |
| Stop | **Event:**  *Stop*  <br/><br/>  `@Html.EJ().Slider("slider").ClientSideEvents(e => e.Stop("onStop"))`  <br/><br/>  `function onStop(args) { }` | **Event:**  *Changed*  <br/><br/>  `@Html.EJS().Slider("slider").Changed("onCreated")`  <br/><br/>  `function onChanged(args) { }`|
| Rendered Ticks | **Not Applicable** | **Event:**  *RenderedTicks*  <br/><br/>  `@Html.EJS().Slider("slider").RenderedTicks("onRenderedTicks")`  <br/><br/>  `function onRenderedTicks(args) { }` |
