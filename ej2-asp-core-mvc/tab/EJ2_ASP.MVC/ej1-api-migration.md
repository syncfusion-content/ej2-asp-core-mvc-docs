---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Tab Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Tab component from Essential JS 1 to Essential JS 2.

## Accessibility

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Keyboard Navigation | **Property:** *AllowKeyboardNavigation* <br /><br /> @Html.EJ().Tab("ejTab").AllowKeyboardNavigation(true).Render() <br /> | **Not Applicable** |
| Localization | **Not Applicable** | **Property:** *Locale* <br /><br /> @Html.EJS().Tab("ej2Tab").Locale("en-US").Render() <br /> |
| RTL | **Property:** *EnableRTL* <br /><br /> @Html.EJ().Tab("ejTab").EnableRTL(true).Render() <br /> | **Property:** *EnableRtl* <br /><br /> @Html.EJS().Tab("ej2Tab").EnableRtl(true).Render() <br /> |

## AjaxSettings

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Property:** *AjaxSettings* <br /><br /> @Html.EJ().Tab("ejTab").AjaxSettings(ajax  =>  { <br /> &nbsp; ajax.Type("GET"); <br /> }).Render() <br /> | **Not Applicable** |
| Asynchronous | **Property:** *AjaxSettings.Async* <br /><br /> @Html.EJ().Tab("ejTab").AjaxSettings(ajax  =>  { <br /> &nbsp; ajax.Async(true); <br /> }).Render() <br /> | **Not Applicable** |
| Browser Cache | **Property:** *AjaxSettings.Cache* <br /><br /> @Html.EJ().Tab("ejTab").AjaxSettings(ajax  =>  { <br /> &nbsp; ajax.Cache(false); <br /> }).Render() <br /> | **Not Applicable** |
| Request type | **Property:** *AjaxSettings.ContentType* <br /><br /> @Html.EJ().Tab("ejTab").AjaxSettings(ajax  =>  { <br /> &nbsp; ajax.ContentType("html"); <br /> }).Render() <br /> | **Not Applicable** |
| Data | **Property:** *AjaxSettings.Data* <br /><br /> @Html.EJ().Tab("ejTab").AjaxSettings(ajax  =>  { <br /> &nbsp; ajax.Data(""); <br /> }).Render() <br /> | **Not Applicable** |
| Response type | **Property:** *AjaxSettings.DataType* <br /><br />@Html.EJ().Tab("ejTab").AjaxSettings(ajax  =>  { <br /> &nbsp; ajax.DataType("html"); <br /> }).Render() <br /> | **Not Applicable** |
| HTTP request type | **Property:** *AjaxSettings.Type* <br /><br /> @Html.EJ().Tab("ejTab").AjaxSettings(ajax  =>  { <br /> &nbsp; ajax.Type("GET"); <br /> }).Render() <br /> | **Not Applicable** |
| AjaxBeforeLoad | **Event:** *AjaxBeforeLoad* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.AjaxBeforeLoad("onAjaxBeforeLoad")).Render() <br /> | **Not Applicable** |
| AjaxError | **Event:** *AjaxError* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.AjaxError("onAjaxError")).Render() <br /> | **Not Applicable** |
| AjaxLoad | **Event:** *AjaxLoad* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.AjaxLoad("onAjaxLoad")).Render() <br /> | **Not Applicable** |
| AjaxSuccess | **Event:** *AjaxSuccess* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.AjaxSuccess("onAjaxSuccess")).Render() <br /> | **Not Applicable** |

## Animation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Not Applicable** | **Property:** *Animation* <br /><br /> @Html.EJS().Tab("ej2Tab").Animation(anim  =>  { <br /> &nbsp; anim.Previous("").Next(""); <br /> }).Render() <br /> |
| EnableAnimation | **Property:** *EnableAnimation* <br /><br /> @Html.EJ().Tab("ejTab").EnableAnimation(false).Render() <br /> | **Not Applicable** |
| Previous animation | **Not Applicable** | **Property:** *Animation.Prev* <br /><br /> @Html.EJS().Tab("ej2Tab").Animation(anim  =>  { <br /> &nbsp; anim.Previous(new List`<TabTabActionSettings>`() { <br /> &nbsp; &nbsp; new TabTabActionSettings() { Effect = "SlideRight" } <br /> &nbsp; }); <br /> }).Render() <br /> |
| Next animation | **Not Applicable** | **Property:** *Animation.Next* <br /><br /> @Html.EJS().Tab("ej2Tab").Animation(anim  =>  { <br /> &nbsp; anim.Next(new List`<TabTabActionSettings>`() { <br /> &nbsp; &nbsp; new TabTabActionSettings() { Effect = "SlideLeft" } <br /> &nbsp; }); <br /> }).Render() <br /> |
| Duration <br /> [prev / next] | **Not Applicable** | **Property:** *Animation.Next.Duration* <br /><br /> @Html.EJS().Tab("ej2Tab").Animation(anim  =>  { <br /> &nbsp; anim.Next(new List`<TabTabActionSettings>`() { <br /> &nbsp; &nbsp; new TabTabActionSettings() { Duration = 400 } <br /> &nbsp; }); <br /> }).Render() <br /> |
| Easing <br /> [prev / next] | **Not Applicable** | **Property:** *Animation.Next.Easing* <br /><br /> @Html.EJS().Tab("ej2Tab").Animation(anim  =>  { <br /> &nbsp; anim.Next(new List`<TabTabActionSettings>`() { <br /> &nbsp; &nbsp; new TabTabActionSettings() { Easing = "ease-in" } <br /> &nbsp; }); <br /> }).Render() <br /> |
| Effect <br /> [prev / next] | **Not Applicable** | **Property:** *Animation.Next.Effect* <br /><br /> @Html.EJS().Tab("ej2Tab").Animation(anim  =>  { <br /> &nbsp; anim.Next(new List`<TabTabActionSettings>`() { <br /> &nbsp; &nbsp; new TabTabActionSettings() { Effect = "SlideRight" } <br /> &nbsp; }); <br /> }).Render() <br /> |

## Header

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Header position | **Property:** *HeaderPosition* <br /><br /> @Html.EJ().Tab("ejTab").HeaderPosition(HeaderPosition.Top).Render() <br /> | **Property:** *HeaderPlacement* <br /><br /> @Html.EJS().Tab("ej2Tab").HeaderPlacement(Syncfusion.EJ2.Navigations.HeaderPosition.Bottom).Render() <br /> |
| Header size | **Property:** *HeaderSize* <br /><br /> @Html.EJ().Tab("ejTab").HeaderSize("50px").Render() <br /> | **Not Applicable** |
| OverflowModes | **Not Applicable** | **Property:** *OverflowMode* <br /><br /> @Html.EJS().Tab("ej2Tab").OverflowMode(Syncfusion.EJ2.Navigations.OverflowMode.Popup).Render() <br /> |
| TabScroll | **Property:** *EnableTabScroll* <br /><br /> @Html.EJ().Tab("ejTab").EnableTabScroll(false).Render() <br /> | **Not Applicable** |

## Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Not Applicable** | **Property:** *Items* <br /><br /> @Html.EJS().Tab("ej2Tab").Items(item  =>  { <br /> &nbsp; item.Header(h  =>  { h.Text("Tab1"); }).Content("contents").Add(); <br /> }).Render() <br /> |
| Content | **Not Applicable** | **Property:** *Items[0].Content* <br /><br /> @Html.EJS().Tab("ej2Tab").Items(item  =>  { <br /> &nbsp; item.Content("contents").Add(); <br /> }).Render() <br /> |
| Custom Class | **Not Applicable** | **Property:** *Items[0].CssClass* <br /><br /> @Html.EJS().Tab("ej2Tab").Items(item  =>  { <br /> &nbsp; item.CssClass("customClass").Add(); <br /> }).Render() <br /> |
| Header | **Not Applicable** | **Property:** *Items[0].Header* <br /><br /> @Html.EJS().Tab("ej2Tab").Items(item  =>  { <br /> &nbsp; item.Header(h  =>  { h.Text("Tab1"); }).Add(); <br /> }).Render() <br /> |
| Icon class | **Not Applicable** | **Property:** *Items[0].Header.IconCss* <br /><br /> @Html.EJS().Tab("ej2Tab").Items(item  =>  { <br /> &nbsp; item.Header(h  =>  { h.IconCss("e-icon"); }).Add(); <br /> }).Render() <br /> |
| Icon position | **Not Applicable** | **Property:** *Items[0].Header.IconPosition* <br /><br /> @Html.EJS().Tab("ej2Tab").Items(item  =>  { <br /> &nbsp; item.Header(h  =>  { h.IconPosition("Left"); }).Add(); <br /> }).Render() <br /> |
| Header text | **Not Applicable** | **Property:** *Items[0].Header.Text* <br /><br /> @Html.EJS().Tab("ej2Tab").Items(item  =>  { <br /> &nbsp; item.Header(h  =>  { h.Text("Tab1"); }).Add(); <br /> }).Render() <br /> |
| Get items length | **Method:** *getItemsCount()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.getItemsCount(); <br /> | **Not Applicable** |
| Add Items | **Method:** *addItem(url, displayLabel, index, cssClass, id)* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.addItem("#new", "New Item", 3, "myClass", "newItem"); <br /> | **Method:** *addTab(items, index)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.addTab([{ <br /> &nbsp; header: { text: 'Tab1' }, <br /> &nbsp; content: 'contents' }], 1 <br /> ); <br /> |
|  BeforeAdd | **Not Applicable** | **Event:** *Adding* <br /><br /> @Html.EJS().Tab("ej2Tab").Adding("onAdding").Render() <br /> |
| AfterAdd | **Event:** *ItemAdd* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.ItemAdd("itemAdd")).Render() <br /> | **Event:** *Added* <br /><br /> @Html.EJS().Tab("ej2Tab").Added("onAdded").Render() <br /> |
| Remove item | **Method:** *removeItem(index)* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.removeItem(1); <br /> | **Method:** *removeTab(index)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.removeTab(1); <br /> |
| BeforeRemove | **Event:** *BeforeItemRemove* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.BeforeItemRemove("beforeItemRemove")).Render() <br /> }); <br /> | **Event:** *Removing* <br /><br /> @Html.EJS().Tab("ej2Tab").Removing("onRemoving").Render() <br /> |
| AfterRemove | **Event:** *ItemRemove* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.ItemRemove("itemRemove")).Render() <br /> | **Event:** *Removed* <br /><br /> @Html.EJS().Tab("ej2Tab").Removed("onRemoved").Render() <br /> |
| SelectedItemIndex | **Property:** *SelectedItemIndex* <br /><br /> @Html.EJ().Tab("ejTab").SelectedItemIndex("1").Render() <br /> | **Property:** *SelectedItem* <br /><br /> @Html.EJS().Tab("ej2Tab").SelectedItem("0").Render() <br /> |
| Select item | **Not Applicable** | **Method:** *select(index)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.select(1); <br /> |
| BeforeActive | **Event:** *BeforeActive* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.BeforeActive("beforeActive")).Render() <br /> | **Event:** *Selecting* <br /><br /> @Html.EJS().Tab("ej2Tab").Selecting("onSelecting").Render() <br /> |
| AfterActive | **Event:** *ItemActive* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.ItemActive("itemActive")).Render() <br /> | **Event:** *Selected* <br /><br /> @Html.EJS().Tab("ej2Tab").Selected("onSelected").Render() <br /> |
| Disable items | **Property:** *DisabledItemIndex* <br /><br /> @Html.EJ().Tab("ejTab").DisabledItemIndex(new List`<int>`() { 0, 1 }).Render() <br /> | **Not Applicable** |
| Enable items | **Property:** *EnabledItemIndex* <br /><br /> @Html.EJ().Tab("ejTab").EnabledItemIndex(new List`<int>`() { 0, 1 }).Render() <br /> | **Not Applicable** |
| Enable/Disable item | **Not Applicable** | **Property:** *Items[0].Disabled* <br /><br /> @Html.EJS().Tab("ej2Tab").Items(item  =>  { <br /> &nbsp; item.Disabled(true).Add(); <br /> }).Render()  <br /> |
| Hide items | **Property:** *HiddenItemIndex* <br /><br /> @Html.EJ().Tab("ejTab").HiddenItemIndex(new List`<int>`() { 0, 1 }).Render() <br /> | **Not Applicable** |
| Hide item | **Method:** *hideItem(index)* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.hideItem(1); <br /> | **Method:** *hideTab(index, true)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.hideTab(1, true); <br /> |
| Show item | **Method:** *showItem(index)* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.showItem(1); <br /> | **Method:** *hideTab(index, false)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.hideTab(1, false); <br /> |

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Collapse active item | **Property:** *Collapsible* <br /><br /> @Html.EJ().Tab("ejTab").Collapsible(true).Render() <br /> | **Not Applicable** |
| Custom class | **Property:** *CssClass* <br /><br /> @Html.EJ().Tab("ejTab").CssClass("cutomClass").Render() <br /> | **Property:** *CssClass* <br /><br /> @Html.EJS().Tab("ej2Tab").CssClass("cutomClass").Render() <br /> |
| Enabled | **Property:** *Enabled* <br /><br /> @Html.EJ().Tab("ejTab").Enabled(true).Render() <br /> | **Method:** *disable(false)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.disable(false); <br /> |
| Persistence | **Property:** *EnablePersistence* <br /><br /> @Html.EJ().Tab("ejTab").EnablePersistence(true).Render() <br /> | **Property:** *EnablePersistence* <br /><br /> @Html.EJS().Tab("ej2Tab").EnablePersistence(true).Render() <br /> |
| Events | **Property:** *Events* <br /><br /> @Html.EJ().Tab("ejTab").Events("click").Render() <br /> | **Not Applicable** |
| Height | **Property:** *Height* <br /><br /> @Html.EJ().Tab("ejTab").Height("500px").Render() <br /> | **Property:** *Height* <br /><br /> @Html.EJS().Tab("ej2Tab").Height("500px").Render() <br /> |
| HeightAdjustMode | **Property:** *HeightAdjustMode* <br /><br /> @Html.EJ().Tab("ejTab").HeightAdjustMode(HeightAdjustMode.Fill).Render() <br /> | **Property:** *HeightAdjustMode* <br /><br /> @Html.EJS().Tab("ej2Tab").HeightAdjustMode(Syncfusion.EJ2.Navigations.HeightStyles.Fill).Render() <br /> |
| HTML Attributes | **Property:** *HtmlAttributes* <br /><br /> @Html.EJ().Tab("ejTab").HtmlAttributes("").Render() <br /> | **Not Applicable** |
| ID prefix | **Property:** *IdPrefix* <br /><br /> @Html.EJ().Tab("ejTab").IdPrefix("e-tab").Render() <br /> | **Not Applicable** |
| ShowCloseButton | **Property:** *ShowCloseButton* <br /><br /> @Html.EJ().Tab("ejTab").ShowCloseButton(true).Render() <br /> | **Property:** *ShowCloseButton* <br /><br /> @Html.EJS().Tab("ej2Tab").ShowCloseButton(true).Render() <br /> |
| ShowReloadIcon | **Property:** *ShowReloadIcon* <br /><br /> @Html.EJ().Tab("ejTab").ShowReloadIcon(true).Render() <br /> | **Not Applicable** |
| ShowRoundedCorner | **Property:** *ShowRoundedCorner* <br /><br /> @Html.EJ().Tab("ejTab").ShowRoundedCorner(true).Render() <br /> | **Not Applicable** |
| Width | **Property:** *Width* <br /><br /> @Html.EJ().Tab("ejTab").Width("500px").Render() <br /> | **Property:** *Width* <br /><br /> @Html.EJS().Tab("ej2Tab").Width("500px").Render() <br /> |
| Destroy | **Not Applicable** | **Method:** *destroy()* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0];<br /> tab.destroy(); <br /> |
| Disable Tab | **Method:** *disable()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.disable(); <br /> | **Method:** *disable(true)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.disable(true); <br /> |
| Enable Tab | **Method:** *enable()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.enable(); <br /> | **Method:** *disable(false)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.disable(false); <br /> |
| Hide Tab | **Method:** *hide()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.hide(); <br /> | **Not Applicable** |
| Show Tab | **Method:** *show()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.show(); <br /> | **Not Applicable** |
| Refresh | **Not Applicable** | **Method:** *refresh()* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.refresh(); <br /> |
| Created | **Event:** *Create* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.Create("onCreate")).Render() <br /> | **Event:** *Created* <br /><br /> @Html.EJS().Tab("ej2Tab").Created("onCreated").Render() <br /> |
| Destroyed | **Event:** *Destroy* <br /><br /> @Html.EJ().Tab("ejTab").ClientSideEvents(e => e.Destroy("onDestroy")).Render() <br /> | **Event:** *Destroyed* <br /><br /> @Html.EJS().Tab("ej2Tab").Destroyed("onDestroyed").Render() <br /> |