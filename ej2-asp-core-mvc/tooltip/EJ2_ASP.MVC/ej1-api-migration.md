---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Tooltip Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Migration from Essential JS 1

This article describes the API migration process of Tooltip component from Essential JS 1 to Essential JS 2.

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Position | **Property:**  *Position*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content").Position(e => e.Target(target => target.Horizontal("right").Vertical("center")).Stem(e => e.Horizontal("left").Vertical("center")))` | **Property:**  *Position*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").Position(Syncfusion.EJ2.Popups.Position.TopCenter)` |
| Animation | **Property:**  *Animation*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content").Animation(e => e.Effect(Effect.Fade).Speed(200))` | **Property:**  *Animation*  <br/><br/>  `List<Object> animation = new List<Object>();`  <br/>  `animation.Add(new { open = new { effect = "FadeIn" }, close = new { effect = "fadeOut" } });`  <br/>  `ViewBag.animation = animation;`  <br/><br/>`@Html.EJS().Tooltip("tooltip").Animation(ViewBag.animation)`|
| Close Time Out | **Property:**  *AutoCloseTimeout*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content").AutoCloseTimeout(2000).CloseMode(CloseMode.Auto)` | **Property:**  *CloseDelay, openDelay*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").CloseDelay(500)` |
| Sticky Mode |**Property :**  *CloseMode*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content").CloseMode(CloseMode.Sticky)` |**Property:**  *IsSticky*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").IsSticky(true)`|
| Offset from target |**Not Applicable** | **Property:**  *OffsetX/OffsetY*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").OffsetX(10).OffsetY(10)`; |
| Open mode of tooltip | **Not Applicable** | **Property:**  *OpensOn*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").OpensOn("Click")` |
| Enable disable the tip of tooltip | **Not Applicable** | **Property:**  *ShowTipPointer*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").ShowTipPointer(true)` |
| Hide | **Method:**  *hide()*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content")`  <br/><br/>  `var tooltipObj = $("#tooltip").ejTooltip("instance");`  <br/>  `tooltipObj.hide();`| **Method:**  *close()*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").OpensOn("Custom")`  <br/>  <br/>  `var tooltipObj = document.getElementById('tooltip').ej2_instances[0];`  <br/>  `tooltipObj.close();`|
| Show | **Method:**  *show()*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content")`  <br/><br/>  `var tooltipObj = $("#tooltip").ejTooltip("instance");`  <br/>  `tooltipObj.show();` | **Method:**  *open()*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").OpensOn("Custom")`  <br/>  <br/>  `var tooltipObj = document.getElementById('tooltip').ej2_instances[0];`  <br/>  `tooltipObj.open();`|
| Enable | **Method:**  *enable()*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content")`  <br/><br/>  `var tooltipObj = $("#tooltip").ejTooltip("instance");`  <br/>  `tooltipObj.enable();` | **Method:**  *destroy()*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").OpensOn("Custom")`  <br/>  <br/>  `var tooltipObj = document.getElementById('tooltip').ej2_instances[0];`  <br/>  `tooltipObj.destroy();` |
| Close | **Event:**  *close*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content").ClientSideEvents(e => e.Close("onClose"))`  <br/>  <br/>  `function onClose(args) { }` | **Event:**  *AfterClose*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").AfterClose("onAfterClose")`  <br/>  <br/>  `function onAfterClose() { }` |
| Open | **Event:**  *open*  <br/><br/>  `@Html.EJ().Tooltip("tooltip").Content("Tooltip content").ClientSideEvents(e => e.Open("onOpen"))`  <br/>  <br/>  `function onOpen(args) { }` | **Event:**  *AfterOpen*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").AfterOpen("onAfterOpen")`  <br/>  <br/>  `function onAfterOpen() { }`
| Before Collision | **Not Applicable** | **Event:**  *BeforeCollision*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").BeforeCollision("onBeforeCollision")`  <br/>  <br/>  `function onBeforeCollision() { }` |
| Tracking| **Event:**  *tracking*  <br/><br/>  `@Html.EJ().Tooltip("sample").Content("Tooltip content").ClientSideEvents(e => e.Tracking("onTracking")).Associate(Associate.MouseFollow)` <br/>  <br/>  `function onTracking(args) { }` | **Method:**  *MouseTrail*  <br/><br/>  `@Html.EJS().Tooltip("tooltip").MouseTrail(true)` |
