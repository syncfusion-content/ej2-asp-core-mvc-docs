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

This article describes the API migration process of Tooltip component from Essential JS 1 to Essential JS 2

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Position | **Property:**  *position*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content">`<br/>`<e-tooltip-position>`<br/>`<e-target horizontal="center" vertical="top" />`<br/>`<e-stem horizontal="center" vertical="bottom" />`<br/>`</e-tooltip-position>`<br/>`</ej-tooltip>` | **Property:**  *position*  <br/> `<ejs-tooltip position="TopCenter" />` |
| Animation | **Property:**  *animation*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content" >`<br/>`<e-tooltip-animation effect="Fade" speed="1000"/>`<br/>`</ej-tooltip>` | **Property:**  *animation*  <br/> `List<Object> animation = new List<Object>();` <br/> `animation.Add(new { open = new { effect = "FadeIn" }, close = new { effect = "fadeOut" } });` <br/> `ViewBag.animation = animation;` <br/><br/>`<ejs-tooltip id="tooltip" animation="ViewBag.animation" />`|
| Close Time Out | **Property:**  *autoCloseTimeout*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content" auto-close-timeout="200" close-mode="Auto" />` | **Property:**  *closeDelay, openDelay*  <br/> `<ejs-tooltip id="tooltip" closeDelay="500" />` |
| Sticky Mode |**Property :**  *closeMode*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content"  close-mode="Sticky" />` |**Property:**  *isSticky*  <br/> `<ejs-tooltip id="tooltip" isSticky="true" position="TopCenter" />`|
| Offset from target |**Not Applicable**  | **Property:**  *offsetX/ offsetY*  <br/> `<ejs-tooltip id="tooltip" offsetX="10" offsetY="10" />`; |
| Open mode of tooltip | **Not Applicable** | **Property:**  *opensOn*  <br/> `<ejs-tooltip id="tooltip" opensOn="Click" />` |
| Enable disable the tip of tooltip | **Not Applicable** | **Property:**  *showTipPointer*  <br/> `<ejs-tooltip id="tooltip" showTipPointer="true" />` |
| Hide | **Method:**  *hide()*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content" />` <br/><br/> `var tooltipObj = $("#tooltip").ejTooltip("instance");` <br/> `tooltipObj.hide();`| **Method:**  *close()*  <br/> `<ejs-tooltip id="tooltip" opensOn="Custom" content="Tooltip Content" />` <br/> <br/> `var tooltipObj = document.getElementById('tooltip').ej2_instances[0];` <br/> `tooltipObj.close();`|
| Show | **Method:**  *show()*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content" />` <br/><br/> `var tooltipObj = $("#tooltip").ejTooltip("instance");` <br/> `tooltipObj.show();` | **Method:**  *open()*  <br/> `<ejs-tooltip id="tooltip" opensOn="Custom" content="Tooltip Content" />` <br/> <br/> `var tooltipObj = document.getElementById('tooltip').ej2_instances[0];` <br/> `tooltipObj.open();`|
| Enable | **Method:**  *enable()*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content" />` <br/><br/> `var tooltipObj = $("#tooltip").ejTooltip("instance");` <br/> `tooltipObj.enable();` | **Method:**  *destroy()*  <br/> `<ejs-tooltip id="tooltip" content="Tooltip Content" />` <br/> <br/> `var tooltipObj = document.getElementById('tooltip').ej2_instances[0];` <br/> `tooltipObj.destroy();` |
| Close | **Event:**  *close*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content" close="onClose" />` <br/> <br/> `function onClose(args) { }` | **Event:**  *afterClose*  <br/> `<ejs-tooltip id="tooltip" content="Tooltip Content" afterClose="onAfterClose" />` <br/> <br/> `function onAfterClose() { }` |
| Open | **Event:**  *open*  <br/>  `<ej-tooltip id="tooltip" content="Tooltip Content" open="onOpen" />` <br/> <br/> `function onOpen(args) { }`  | **Event:**  *afterOpen*  <br/> `<ejs-tooltip id="tooltip" content="Tooltip Content" afterOpen="onAfterOpen" />` <br/> <br/> `function onAfterOpen() { }`
| Before Collision | **Not Applicable** | **Event:**  *beforeCollision*  <br/> `<ejs-tooltip id="tooltip" content="Tooltip Content" beforeCollision="onBeforeCollision" />` <br/> <br/> `function onBeforeCollision() { }` |
| Tracking| **Event:**  *tracking*  <br/> `<ej-tooltip id="tooltip" content="Tooltip Content" tracking="onTracking" associate="mouse" />` <br/> <br/> `function onTracking(args) { }`  | **Method:**  *mouseTrail*  <br/> `<ejs-tooltip id="tooltip" mouseTrail="true" />` |
