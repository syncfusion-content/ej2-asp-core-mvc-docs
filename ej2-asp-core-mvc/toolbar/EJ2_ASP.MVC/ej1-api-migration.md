---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Toolbar Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Toolbar component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Toolbar component from Essential JS 1 to Essential JS 2.

## Accessibility

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Localization | **Not Applicable** | **Property:** *Locale* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Locale("en-US").Render() <br /> |
| RTL | **Property:** *EnableRTL* <br /><br /> @Html.EJ().Toolbar("ejToolbar").EnableRTL(true) <br /> | **Property:** *EnableRtl* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").EnableRtl(true).Render() <br /> |

## DataSource

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| DataSource | **Property:** *DataSource* <br /><br /> @Html.EJ().Toolbar("ejToolbar").DataSource(@ViewBag.items) <br /> | **Not Applicable** |
| Query | **Property:** *Query* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Query("ej.Query().from('Orders').take(6)") <br /> | **Not Applicable** |
| Fields | **Property:** *Fields* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.Text("")) <br /> | **Not Applicable** |
| Group | **Property:** *Group* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.Group("")) <br /> | **Not Applicable** |
| HtmlAttributes | **Property:** *HtmlAttributes* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.HtmlAttributes("")) <br /> | **Not Applicable** |
| Id | **Property:** *Id* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.Id("")).Render() <br /> | **Not Applicable** |
| ImageAttributes | **Property:** *ImageAttributes* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.ImageAttributes("")) <br /> | **Not Applicable** |
| ImageUrl | **Property:** *ImageUrl* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.ImageUrl("")) <br /> | **Not Applicable** |
| SpriteCssClass | **Property:** *SpriteCssClass* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.SpriteCssClass("e-split")) <br /> | **Not Applicable** |
| Text | **Property:** *Text* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.Text("Cut")) <br /> | **Not Applicable** |
| TooltipText | **Property:** *TooltipText* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.TooltipText("Cut")) <br /> | **Not Applicable** |
| Template | **Property:** *Template* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ToolbarFields(f => f.Template("")) <br /> | **Not Applicable** |

## Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Property:** *Items* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().Text("Cut"); <br /> }) <br /> | **Property:** *Items* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.Text("Cut").Add(); <br /> }).Render() <br /> |
| Align | **Not Applicable** | **Property:** *Items[0].Align* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.Align(Syncfusion.EJ2.Navigationi.ItemAlign.Left).Add(); <br /> }).Render() <br /> |
| Custom Class | **Not Applicable** | **Property:** *Items[0].CssClass* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.CssClass("e-class").Add(); <br /> }).Render() <br /> |
| Group Name | **Property:** *Items[0].Group* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().Group(""); <br /> }) <br /> | **Not Applicable** |
| Html Attributes | **Property:** *Items[0].HtmlAttributes* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().HtmlAttributes(""); <br /> }) <br /> | **Property:** *Items[0].HtmlAttributes* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.HtmlAttributes("").Add(); <br /> }).Render() <br /> |
| Id | **Property:** *Items[0].Id* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().Id("ej-toolbar"); <br /> }) <br /> | **Property:** *Items[0].Id* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.Id("ej-toolbar").Add(); <br /> }).Render() <br /> |
| ImageAttributes | **Property:** *Items[0].ImageAttributes* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().ImageAttributes(""); <br /> }) <br /> | **Not Applicable** |
| ImageUrl | **Property:** *Items[0].ImageUrl* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().ImageUrl(""); <br /> }) <br /> | **Not Applicable** |
| Overflow | **Not Applicable** | **Property:** *Items[0].Overflow* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.Overflow(Syncfusion.EJ2.Navigationi.OverflowOption.Show).Add(); <br /> }).Render() <br /> |
| PrefixIcon | **Not Applicable** | **Property:** *Items[0].PrefixIcon* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.PrefixIcon("e-icon").Add(); <br /> }).Render() <br /> |
| ShowAlwaysInPopup | **Not Applicable** | **Property:** *Items[0].ShowAlwaysInPopup* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.ShowAlwaysInPopup(true).Add(); <br /> }).Render() <br /> |
| ShowTextOn | **Not Applicable** | **Property:** *Items[0].ShowTextOn* <br /><br />@Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.ShowTextOn(Syncfusion.EJ2.Navigationi.DisplayMode.Overflow).Add(); <br /> }).Render() <br /> |
| Sprite CssClass | **Property:** *Items[0].SpriteCssClass* <br /><br />@Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().SpriteCssClass("e-split"); <br /> }) <br /> | **Not Applicable** |
| SuffixIcon | **Not Applicable** | **Property:** *Items[0].SuffixIcon* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.SuffixIcon("e-icon").Add(); <br /> }).Render() <br /> |
| Template | **Property:** *Items[0].Template* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().Template(""); <br /> }) <br /> | **Property:** *Items[0].Template* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.Template("").Add(); <br /> }).Render() <br /> |
| Text | **Property:** *Items[0].Text* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().Text("Cut"); <br /> }) <br /> | **Property:** *Items[0].Text* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.Text("Cut").Add(); <br /> }).Render() <br /> |
| TooltipText | **Property:** *Items[0].TooltipText* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Items(i => { <br /> &nbsp; i.Add().TooltipText("Cut"); <br /> }) <br /> | **Property:** *Items[0].TooltipText* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.TooltipText("Cut").Add(); <br /> }).Render() <br /> |
| Type | **Not Applicable** | **Property:** *Items[0].Type* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.Type(Syncfusion.EJ2.Navigationi.ItemType.Button).Add(); <br /> }).Render() <br /> |
| Width | **Not Applicable** | **Property:** *Items[0].Width* <br /><br />@Html.EJS().Toolbar("ej2Toolbar").Items(i => { <br /> &nbsp; i.Width("50px").Add(); <br /> }).Render() <br /> |
| Disable Items | **Property:** *DisabledItemIndices* <br /><br /> @Html.EJ().Toolbar("ejToolbar").DisabledItemIndices(@{[0, 1]}) <br /> | **Method:** *enableItems(items, false)* <br /><br />  var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.enableItems([], false); <br /> |
| Add Items | **Not Applicable** | **Method:** *addItems(items, index)* <br /><br />  var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.addItems([], 0); <br /> |
| RemoveItem | **Method:** *removeItem(element)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.removeItem(ele); <br /> | **Method:** *removeItems(args)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.removeItems(0); <br /> |
| RemoveItemById | **Method:** *removeItemById(id)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.removeItemById('left'); <br /> | **Not Applicable** |
| Enable Item | **Method:** *enableItem(element)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.enableItem(ele); <br /> | **Method:** *enableItems(items, true)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.enableItems(items, true); <br /> |
| EnableItemById | **Method:** *enableItemById(id)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.enableItemById('left'); <br /> | **Not Applicable** |
| Disable Item | **Method:** *disableItem(element)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.disableItem(ele); <br /> | **Method:** *enableItems(items, false)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.enableItems([], false); <br /> |
| DisableItemById | **Method:** *disableItemById(id)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.disableItemById('left'); <br /> | **Not Applicable** |
| Show Item | **Not Applicable** | **Method:** *hideItem(index, false)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.hideItem(0, false); <br /> |
| Hide Item | **Not Applicable** | **Method:** *hideItem(index, true)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.hideItem(0, true); <br /> |
| SelectItem | **Method:** *selectItem(element)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.selectItem(ele); <br /> | **Not Applicable** |
| SelectItemById | **Method:** *selectItemById(id)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.selectItemById('left'); <br /> | **Not Applicable** |
| Deselect Item | **Method:** *deselectItem(element)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.deselectItem(ele); <br /> | **Not Applicable** |
| DeselectItemById | **Method:** *deselectItemById(id)* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.deselectItemById('left'); <br /> | **Not Applicable** |
| Clicked | **Not Applicable** | **Event:** *Clicked* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Clicked("onClicked").Render() <br /> |
| itemHover | **Event:** *ItemHover* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ClientSideEvents(e => e.ItemHover("itemHover")) <br /> | **Not Applicable** |
| itemLeave | **Event:** *ItemLeave* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ClientSideEvents(e => e.ItemLeave("itemLeave")) <br /> | **Not Applicable** |

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Custom class | **Property:** *CssClass* <br /><br /> @Html.EJ().Toolbar("ejToolbar").CssClass("customClass") <br /> | **Not Applicable** |
| Enabled | **Property:** *Enabled* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Enabled(false) <br /> | **Not Applicable** |
| EnableSeparator | **Property:** *EnableSeparator* <br /><br /> @Html.EJ().Toolbar("ejToolbar").EnableSeparator(true) <br /> | **Not Applicable** |
| Height | **Property:** *Height* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Height("50px") <br /> | **Property:** *Height* <br /><br />  @Html.EJS().Toolbar("ej2Toolbar").Height("50px").Render() <br /> |
| HtmlAttributes | **Property:** *HtmlAttributes* <br /><br /> @Html.EJ().Toolbar("ejToolbar").HtmlAttributes("") <br /> | **Not Applicable** |
| Hide | **Property:** *Hide* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Hide(true) <br /> | **Not Applicable** |
| Orientation | **Property:** *Orientation* <br /><br />  @Html.EJ().Toolbar("ejToolbar").Orientation(Orientation.Vertical) <br /> | **Not Applicable** |
| OverflowModes | **Property:** *ResponsiveType* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ResponsiveType(ResponsiveType.Popup)  <br /> | **Property:** *OverflowMode* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").OverflowMode(Syncfusion.EJ2.Navigations.OverflowMode.Popup).Render() <br /> |
| Persistence | **Not Applicable** | **Property:** *EnablePersistence*  <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").EnablePersistence(true).Render() <br /> |
| Responsive | **Property:** *IsResponsive* <br /><br /> @Html.EJ().Toolbar("ejToolbar").IsResponsive(true) <br /> | **Not Applicable** |
| ShowRounderCorner | **Property:** *ShowRoundedCorner* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ShowRoundedCorner(true) <br /> | **Not Applicable** |
| Width | **Property:** *Width* <br /><br /> @Html.EJ().Toolbar("ejToolbar").Width("400px") <br /> | **Property:** *Width* <br /><br />  @Html.EJS().Toolbar("ej2Toolbar").Width("400px").Render() <br /> |
| Enable | **Method:** *enable()* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.enable(); <br /> | **Method:** *disable(false)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.disable(false); <br /> |
| Disable | **Method:** *disable()* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.disable(); <br /> | **Method:** *disable(true)* <br /><br />  var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.disable(true); <br /> |
| Show | **Method:** *show()* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.show(); <br /> | **Not Applicable** |
| Hide | **Method:** *hide()* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.hide(); <br /> | **Not Applicable** |
| Refresh | **Not Applicable** | **Method:** *refresh()* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.refresh(); <br /> |
| Destroy | **Method:** *destroy()* <br /><br /> var toolbar = $("#toolbar").data("ejToolbar"); <br /> toolbar.destroy(); <br /> | **Method:** *destroy()* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.destroy(); <br /> |
| Click | **Event:** *Click* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ClientSideEvents(e => e.Click("onClick")) <br /> | **Not Applicable** |
| BeforeCreate | **Not Applicable** | **Event:** *BeforeCreate* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").BeforeCreate("beforeCreate").Render() <br /> |
| Created | **Event:** *Create* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ClientSideEvents(e => e.Create("onCreate")) <br /> | **Event:** *Created* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Created("onCreated").Render() <br /> |
| Destroyed | **Event:** *Destroy* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ClientSideEvents(e => e.Destroy("onDestroy")) <br /> | **Event:** *Destroyed* <br /><br /> @Html.EJS().Toolbar("ej2Toolbar").Destroyed("onDestroyed").Render() <br /> |
| FocusOut | **Event:** *FocusOut* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ClientSideEvents(e => e.FocusOut("focusOut")) <br /> | **Not Applicable** |
| OverflowOpen | **Event:** *OverflowOpen* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ClientSideEvents(e => e.OverflowOpen("overflowOpen")) <br /> | **Not Applicable** |
| OverflowClose | **Event:** *OverflowClose* <br /><br /> @Html.EJ().Toolbar("ejToolbar").ClientSideEvents(e => e.OverflowClose("overflowClose")) <br /> | **Not Applicable** |