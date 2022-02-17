---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Accordion Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Accordion component from Essential JS 1 to Essential JS 2.

## Accessibility

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Keyboard Navigation | **Property:** *AllowKeyboardNavigation* <br /><br /> @Html.EJ().Accordion("ejAccoordion").AllowKeyboardNavigation(true).Render() <br /> | **Not Applicable** |
| Localization | **Not Applicable** | **Property:** *Locale* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Locale("en-US").Render() <br /> |
| RTL | **Property:** *EnableRTL* <br /><br /> @Html.EJ().Accordion("ejAccoordion").EnableRTL(true).Render() <br /> | **Property:** *EnableRtl* <br /><br /> @Html.EJS().Accordion("ej2Accordion").EnableRtl(true).Render() <br /> |

## AjaxSettings

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Property:** *AjaxSettings* <br /><br /> @Html.EJ().Accordion("ejAccordion").AjaxSettings(ajax => { <br /> &nbsp; ajax.Type("GET"); <br /> }).Render() <br /> | **Not Applicable** |
| Asynchronous | **Property:** *AjaxSettings.Async* <br /><br /> @Html.EJ().Accordion("ejAccordion").AjaxSettings(ajax => { <br /> &nbsp; ajax.Async(true); <br /> }).Render() <br /> | **Not Applicable** |
| Browser Cache | **Property:** *AjaxSettings.Cache* <br /><br /> @Html.EJ().Accordion("ejAccordion").AjaxSettings(ajax => { <br /> &nbsp; ajax.Cache(false); <br /> }).Render() <br /> | **Not Applicable** |
| Request type | **Property:** *AjaxSettings.ContentType* <br /><br /> @Html.EJ().Accordion("ejAccordion").AjaxSettings(ajax => { <br /> &nbsp; ajax.ContentType("html"); <br /> }).Render() <br /> | **Not Applicable** |
| Data | **Property:** *AjaxSettings.Data* <br /><br /> @Html.EJ().Accordion("ejAccordion").AjaxSettings(ajax => { <br /> &nbsp; ajax.Data(""); <br /> }).Render() <br /> | **Not Applicable** |
| Response type | **Property:** *AjaxSettings.DataType* <br /><br /> @Html.EJ().Accordion("ejAccordion").AjaxSettings(ajax => { <br /> &nbsp; ajax.DataType("html"); <br /> }).Render() <br /> | **Not Applicable** |
| HTTP request type | **Property:** *AjaxSettings.Type* <br /><br /> @Html.EJ().Accordion("ejAccordion").AjaxSettings(ajax => { <br /> &nbsp; ajax.Type("GET"); <br /> }).Render() <br /> | **Not Applicable** |
| AjaxBeforeLoad | **Event:** *AjaxBeforeLoad* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e => e.AjaxBeforeLoad("onAjaxBeforeLoad")).Render() <br /> | **Not Applicable** |
| AjaxError | **Event:** *AjaxError* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e => e.AjaxError("onError")).Render() <br /> | **Not Applicable** |
| AjaxLoad | **Event:** *AjaxLoad* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e => e.AjaxLoad("onAjaxLoad")).Render() <br /> | **Not Applicable** |
| AjaxSuccess | **Event:** *AjaxSuccess* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e => e.AjaxSuccess("onAjaxSuccess")).Render() <br /> | **Not Applicable** |

## Animation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Not Applicable** | **Property:** *Animation* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Animation(anim => { <br /> &nbsp; anim.Expand("").Collapse(""); <br /> }).Render() <br /> |
| EnableAnimation | **Property:** *EnableAnimation* <br /><br /> @Html.EJ().Accordion("ejAccoordion").EnableAnimation(false).Render() <br /> | **Not Applicable** |
| Expand animation | **Not Applicable** | **Property:** *Animation.Expand* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Animation(anim => { <br /> &nbsp; anim.Expand(new List`<AccordionAccordionActionSettings>`() { <br /> &nbsp; &nbsp; new AccordionAccordionActionSettings() { Effect = "SlideDown" } <br /> &nbsp; }); <br /> }).Render() <br /> |
| Collapse animation | **Not Applicable** | **Property:** *Animation.Collapse* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Animation(anim => { <br /> &nbsp; anim.Collapse(new List`<AccordionAccordionActionSettings>`() { <br /> &nbsp; &nbsp; new AccordionAccordionActionSettings() { Effect = "SlideUp" } <br /> &nbsp; }); <br /> }).Render() <br /> |
| Duration <br /> [expand / collapse] | **Not Applicable** | **Property:** *Animation.Collapse.Duration* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Animation(anim => { <br /> &nbsp; anim.Collapse(new List`<AccordionAccordionActionSettings>`() { <br /> &nbsp; &nbsp; new AccordionAccordionActionSettings() { Duration = 400 } <br /> &nbsp; }); <br /> }).Render() <br /> |
| Easing <br /> [expand / collapse] | **Not Applicable** | **Property:** *Animation.Collapse.Easing* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Animation(anim => { <br /> &nbsp; anim.Collapse(new List`<AccordionAccordionActionSettings>`() { <br /> &nbsp; &nbsp; new AccordionAccordionActionSettings() { Easing = "ease-in" } <br /> &nbsp; }); <br /> }).Render() <br /> |
| Effect <br /> [expand / collapse] | **Not Applicable** | **Property:** *Animation.Collapse.Effect* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Animation(anim => { <br /> &nbsp; anim.Collapse(new List`<AccordionAccordionActionSettings>`() { <br /> &nbsp; &nbsp; new AccordionAccordionActionSettings() { Effect = "SlideDown" } <br /> &nbsp; }); <br /> }).Render() <br /> |

## Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Not Applicable** | **Property:** *Items* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Items(item => { <br /> &nbsp; item.Header("").Content("").Add(); <br /> }).Render() <br /> |
| Content | **Not Applicable** | **Property:** *Items[0].Content* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Items(item => { <br /> &nbsp; item.Content("contents").Add(); <br /> }).Render() <br /> |
| Custom class | **Not Applicable** | **Property:** *Items[0].CssClass* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Items(item => { <br /> &nbsp; item.CssClass("customClass").Add(); <br /> }).Render() <br /> |
| Header | **Not Applicable** | **Property:** *Items[0].Header* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Items(item => { <br /> &nbsp; item.Header("Header").Add(); <br /> }).Render() <br /> |
| HeaderSize | **Property:** *HeaderSize* <br /><br />@Html.EJ().Accordion("ejAccoordion").HeaderSize("50px").Render() <br /> | **Not Applicable** |
| Icon class | **Not Applicable** | **Property:** *Items[0].IconCss* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Items(item => { <br /> &nbsp; item.iconCss("e-icon").Add(); <br /> }).Render() <br /> |
| IsExpand | **Not Applicable** | **Property:** *Items[0].Expanded* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Items(item => { <br /> &nbsp; item.Expand(true).Add(); <br /> }).Render() <br /> |
| Collapse Item | **Method:** *collapsePanel(index)* <br /><br />var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.collapsePanel(0); <br /> | **Method:** *expandItem(index, false)* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.expandItem(0, false); <br /> |
| Expand Item | **Method:** *expandPanel(index)* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.expandPanel(0); <br /> | **Method:** *expandItem(index, true)* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.expandItem(0, true); <br /> |
| CollapseAll | **Method:** *collapseAll()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.collapseAll(); <br /> | **Not Applicable** |
| ExpandAll | **Method:** *expandAll()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.expandAll(); <br /> | **Not Applicable** |
| Get ItemsCount | **Method:** *getItemsCount()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.getItemsCount(); <br /> | **Not Applicable** |
| AddItem | **Method:** *addItem(text, content, index)* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.addItem("New item", "The accordion content", 2); <br /> | **Method:** *addItem(items, index)* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.addItem([{ header: 'App', content: 'text' }], 0) <br /> |
| Remove Item | **Method:** *removeItem(index)* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.removeItem(0); <br /> | **Method:** *removeItem(index)* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.removeItem(0) <br /> |
| Disable Items | **Property:** *DisabledItems* <br /><br /> @Html.EJ().Accordion("ejAccoordion").DisabledItems(new List`<int>`() { 0, 1 }).Render() <br /> | **Not Applicable** |
| Enable Items | **Property:** *EnabledItems* <br /><br /> @Html.EJ().Accordion("ejAccoordion").EnabledItems(new List`<int>`() { 0, 1 }).Render() <br /> | **Not Applicable** |
| Disable Item | **Method:** *disableItems([index])* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.disableItems([1]); <br /> | **Method:** *enableItem(index, false)* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.enableItem(0, false) <br /> |
| Enable Item | **Method:** *enableItems([index])* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.enableItems([1]); <br /> | **Method:** *enableItem(index, true)* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.enableItem(0, true) <br /> |
| Hide Item | **Not Applicable** | **Method:** *hideItem(index, true)* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.hideItem(0, true) <br /> |
| SelectedItemIndex | **Property:** *SelectedItemIndex* <br /><br /> @Html.EJ().Accordion("ejAccoordion").SelectedItemIndex("1").Render() <br /> | **Not Applicable** |
| Select | **Not Applicable** | **Method:** *select(index)* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.select(0) <br /> |
| BeforeActivate | **Event:** *BeforeActivate* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e=>e.BeforeActivate("beforeActivate")).Render() <br /> | **Event:** *Expanding* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Expanding("onExpanding").Render() <br /> |
| Activate | **Event:** *Activate* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e=>e.Activate("onActivate")).Render() <br /> | **Event:** *Expanded* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Expanded("onExpanded").Render() <br /> |
| beforeInActivate | **Event:** *BeforeInactivate* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e=>e.BeforeInActivate("beforeInActivate")).Render() <br /> | **Not Applicable** |
| InActive | **Event:** *InActivate* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e=>e.InActive("inActive")).Render() <br /> | **Not Applicable** |
| Clicked | **Not Applicable** | **Event:** *Clicked* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Clicked("onClicked").Render() <br /> |

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Collapsible | **Property:** *Collapsible* <br /><br /> @Html.EJ().Accordion("ejAccoordion").Collapsible(true).Render() <br /> | **Not Applicable** |
| Collapse speed | **Property:** *CollapseSpeed* <br /><br /> @Html.EJ().Accordion("ejAccoordion").CollapseSpeed("500").Render() <br /> | **Not Applicable** |
| Custom class | **Property:** *CssClass* <br /><br /> @Html.EJ().Accordion("ejAccoordion").CssClass("custom").Render() <br /> | **Not Applicable** |
| CustomIcon class | **Property:** *CustomIcon* <br /><br /> @Html.EJ().Accordion("ejAccoordion").CustomIcon(@ViewBag.CustomIcon).Render() <br /> | **Not Applicable** |
| Enabled | **Property:** *Enabled* <br /><br /> @Html.EJ().Accordion("ejAccoordion").Enabled(false).Render() <br /> | **Not Applicable** |
| Events | **Property:** *Events* <br /><br /> @Html.EJ().Accordion("ejAccoordion").Events("mouseover").Render() <br /> | **Not Applicable** |
| Expand speed | **Property:** *ExpandSpeed* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ExpandSpeed(300).Render() <br /> | **Not Applicable** |
| Height | **Property:** *Height* <br /><br /> @Html.EJ().Accordion("ejAccoordion").Height("400px").Render() <br /> | **Property:** *Height* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Height("500px").Render() <br /> |
| HeightAdjustMode | **Property:** *HeightAdjustMode* <br /><br /> @Html.EJ().Accordion("ejAccoordion").HeightAdjustMode(HeightAdjustMode.Fill).Render() <br /> | **Not Applicable** |
| HtmlAttributes | **Property:** *HtmlAttributes* <br /><br /> @Html.EJ().Accordion("ejAccoordion").HtmlAttributes("").Render() <br /> | **Not Applicable** |
| MultipleOpen | **Property:** *EnableMultipleOpen* <br /><br /> @Html.EJ().Accordion("ejAccoordion").EnableMultipleOpen(true).Render() <br /> | **Property:** *ExpandMode* <br /><br /> @Html.EJS().Accordion("ej2Accordion").ExpandMode(Syncfusion.EJ2.Navigations.ExpandMode.Single).Render() <br /> |
| Persistence | **Property:** *EnablePersistence* <br /><br /> @Html.EJ().Accordion("ejAccoordion").EnablePersistence(true).Render() <br /> | **Property:** *EnablePersistence* <br /><br /> @Html.EJS().Accordion("ej2Accordion").EnablePersistence(true).Render() <br /> |
| ShowRounderCorner | **Property:** *ShowRoundedCorner* <br /><br />@Html.EJ().Accordion("ejAccoordion").ShowRoundedCorner(true).Render() <br /> | **Not Applicable** |
| Width | **Property:** *Width* <br /><br /> @Html.EJ().Accordion("ejAccoordion").Width("500px").Render() <br /> | **Property:** *Width* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Width("500px").Render() <br /> |
| Enable | **Method:** *enable()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.enable(); <br /> | **Not Applicable** |
| Disable | **Method:** *disable()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.disable(); <br /> | **Not Applicable** |
| Show | **Method:** *show()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.show(); <br /> | **Not Applicable** |
| Hide | **Method:** *hide()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.hide(); <br /> | **Not Applicable** |
| Destroy | **Method:** *destroy()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.destroy(); <br /> | **Method:** *destroy()* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.destroy(); <br /> |
| Refresh | **Method:** *refresh()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.refresh(); <br /> | **Method:** *refresh()* <br /><br /> var accordion = document.getElementById('ej2Accordion').ej2_instances[0]; <br /> accordion.refresh(); <br /> |
| Created | **Event:** *Create* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e=>e.Create("onCreate")).Render() <br /> | **Event:** *Created* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Created("onCreated").Render() <br /> |
| Destroyed | **Event:** *Destroy* <br /><br /> @Html.EJ().Accordion("ejAccoordion").ClientSideEvents(e=>e.Destroy("onDestroy")).Render() <br /> | **Event:** *Destroyed* <br /><br /> @Html.EJS().Accordion("ej2Accordion").Destroyed("onDestroyed").Render() <br /> |