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
| Localization | **Not Applicable** | **Property:** *locale* <br /><br /> `<ejs-toolbar locale="en-US" />` <br /> |
| RTL | **Property:** *enable-rtl* <br /><br /> `<ej-toolbar enable-rtl="true" />` <br /> | **Property:** *enableRtl* <br /><br /> `<ejs-toolbar enableRtl="true" />` <br /> |

## DataSource

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| DataSource | **Property:** *data-source* <br /><br /> `<ej-toolbar data-source="@ViewBag.items" />` <br /> | **Not Applicable** |
| Query | **Property:** *query* <br /><br /> `<ej-toolbar query="query" />` <br /> | **Not Applicable** |
| Fields | **Property:** *fields* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| Group | **Property:** *group* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields group="" />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| HtmlAttributes | **Property:** *html-attributes* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields html-attributes="" />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| Id | **Property:** *id* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields id="tbField" />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| ImageAttributes | **Property:** *image-attributes* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields image-attributes="" />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| ImageUrl | **Property:** *image-url* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields image-url="" />` <br /> `</ej-toolbar>`  <br /> | **Not Applicable** |
| SpriteCssClass | **Property:** *sprite-css-class* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields sprite-css-class="e-split" />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| Text | **Property:** *text* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields text="Cut" />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| TooltipText | **Property:** *tooltip-text* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields tooltip-text="Cut" />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| Template | **Property:** *template* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-fields template="" />` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |

## Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Property:** *items* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items />` <br /> `</ej-toolbar>` <br /> | **Property:** *items* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items />` <br /> `</ejs-toolbar>` <br /> |
| Align | **Not Applicable** | **Property:** *items[0].align* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item align="left" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Custom Class | **Not Applicable** | **Property:** *items[0].cssClass* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item cssClass="e-custom-class" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Group Name | **Property:** *items[0].group* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item group="" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| Html Attributes | **Property:** *items[0].html-attributes* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item html-attributes="" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Property:** *items[0].htmlAttributes* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item htmlAttributes="ViewBag.attributes" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Id | **Property:** *items[0].id* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item id="item1" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Property:** *items[0].id* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item id="item1" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| ImageAttributes | **Property:** *items[0].image-attributes* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item image-attributes="" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| ImageUrl | **Property:** *items[0].image-url* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item image-url="" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| Overflow | **Not Applicable** | **Property:** *items[0].overflow* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item overflow="popup" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| PrefixIcon | **Not Applicable** | **Property:** *items[0].prefixIcon* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item prefixIcon="e-icon" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| ShowAlwaysInPopup | **Not Applicable** | **Property:** *items[0].showAlwaysInPopup* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item showAlwaysInPopup="true" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| ShowTextOn | **Not Applicable** | **Property:** *items[0].showTextOn* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item showTextOn="popup" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Sprite CssClass | **Property:** *items[0].sprite-css-class* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item sprite-css-class="e-class" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Not Applicable** |
| SuffixIcon | **Not Applicable** | **Property:** *items[0].suffixIcon* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item suffixIcon="e-icon" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Template | **Property:** *items[0].template* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item template="" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Property:** *items[0].template* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item template="" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Text | **Property:** *items[0].text* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item text="Cut" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Property:** *items[0].text* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item text="cut" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| TooltipText | **Property:** *items[0].tooltip-text* <br /><br /> `<ej-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item tooltip-text="Cut" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ej-toolbar>` <br /> | **Property:** *items[0].tooltipText* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item tooltipText="Cut" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Type | **Not Applicable** | **Property:** *items[0].type* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp;&nbsp; `<e-toolbar-item type="Button" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Width | **Not Applicable** | **Property:** *items[0].width* <br /><br /> `<ejs-toolbar>` <br /> &nbsp; `<e-toolbar-items>` <br /> &nbsp; &nbsp; `<e-toolbar-item width="50" />` <br /> &nbsp; `</e-toolbar-items>` <br /> `</ejs-toolbar>` <br /> |
| Disable Items | **Property:** *disabled-item-indices* <br /><br /> `<ej-toolbar disabled-item-indices="" />` <br /> | **Method:** *enableItems(items, false)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.enableItems([], false); <br /> |
| Add Items | **Not Applicable** | **Method:** *addItems(items, index)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0];<br /> toolbar.addItems([], 0); <br /> |
| RemoveItem | **Method:** *removeItem(element)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.removeItem(ele); <br /> | **Method:** *removeItems(args)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.removeItems(0); <br /> |
| RemoveItemById | **Method:** *removeItemById(id)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.removeItemById('left'); <br /> | **Not Applicable** |
| Enable Item | **Method:** *enableItem(element)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.enableItem(ele); <br /> | **Method:** *enableItems(items, true)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.enableItems(items, true); <br /> |
| EnableItemById | **Method:** *enableItemById(id)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.enableItemById('left'); <br /> | **Not Applicable** |
| Disable Item | **Method:** *disableItem(element)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.disableItem(ele); <br /> | **Method:** *enableItems(items, false)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.enableItems([], false); <br /> |
| DisableItemById | **Method:** *disableItemById(id)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.disableItemById('left'); <br /> | **Not Applicable** |
| Show Item | **Not Applicable** | **Method:** *hideItem(index, false)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.hideItem(0, false); <br /> |
| Hide Item | **Not Applicable** | **Method:** *hideItem(index, true)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0]; <br /> toolbar.hideItem(0, true); <br /> |
| SelectItem | **Method:** *selectItem(element)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.selectItem(ele); <br /> | **Not Applicable** |
| SelectItemById | **Method:** *selectItemById(id)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.selectItemById('left'); <br /> | **Not Applicable** |
| Deselect Item | **Method:** *deselectItem(element)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.deselectItem(ele); <br /> | **Not Applicable** |
| DeselectItemById | **Method:** *deselectItemById(id)* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.deselectItemById('left'); <br /> | **Not Applicable** |
| Clicked | **Not Applicable** | **Event:** *clicked* <br /><br /> `<ejs-toolbar clicked="onClicked" />` <br /> |
| itemHover | **Event:** *item-hover* <br /><br /> `<ej-toolbar item-hover="onItemHover" />` <br /> | **Not Applicable** |
| itemLeave | **Event:** *item-leave* <br /><br /> `<ej-toolbar item-leave="onItemLeave" />` <br /> | **Not Applicable** |

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Custom class | **Property:** *css-class* <br /><br /> `<ej-toolbar css-class="customClass" />` <br /> | **Not Applicable** |
| Enabled | **Property:** *enabled* <br /><br /> `<ej-toolbar enabled="false" />` <br /> | **Not Applicable** |
| EnableSeparator | **Property:** *enable-separator* <br /><br /> `<ej-toolbar enable-separator="false" />` <br /> | **Not Applicable** |
| Height | **Property:** *height* <br /><br /> `<ej-toolbar height="400" />` <br /> | **Property:** *height* <br /><br /> `<ejs-toolbar height="70" />` <br /> |
| HtmlAttributes | **Property:** *html-attributes* <br /><br /> `<ej-toolbar html-attributes="" />` <br /> | **Not Applicable** |
| Hide | **Property:** *hide* <br /><br /> `<ej-toolbar hide="true" />` <br /> | **Not Applicable** |
| Orientation | **Property:** *orientation* <br /><br /> `<ej-toolbar orientation="Horizontal" />` <br /> | **Not Applicable** |
| OverflowModes | **Property:** *responsive-type* <br /><br /> `<ej-toolbar responsive-type="popup" />` <br /> | **Property:** *overflowMode* <br /><br /> `<ejs-toolbar overflowMode="Popup" />` <br /> |
| Persistence | **Not Applicable** | **Property:** *enablePersistence*  <br /><br /> `<ejs-toolbar enablePersistence="true" />` <br /> |
| Responsive | **Property:** *is-responsive* <br /><br /> `<ej-toolbar is-responsive="true" />` <br /> | **Not Applicable** |
| ShowRounderCorner | **Property:** *show-rounded-corner* <br /><br /> `<ej-toolbar show-rounded-corner="false" />` <br /> | **Not Applicable** |
| Width | **Property:** *width* <br /><br /> `<ej-toolbar width="600" />` <br /> | **Property:** *width* <br /><br /> `<ejs-toolbar width="500" />` <br /> |
| Enable | **Method:** *enable()* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.enable(); <br /> | **Method:** *disable(false)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0];<br /> toolbar.disable(false); <br /> |
| Disable | **Method:** *disable()* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.disable(); <br /> | **Method:** *disable(true)* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0];<br /> toolbar.disable(true); <br /> |
| Show | **Method:** *show()* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.show(); <br /> | **Not Applicable** |
| Hide | **Method:** *hide()* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.hide(); <br /> | **Not Applicable** |
| Refresh | **Not Applicable** | **Method:** *refresh()* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0];<br /> toolbar.refresh(); <br /> |
| Destroy | **Method:** *destroy()* <br /><br /> var tbObj = $("#toolbar").data("ejToolbar"); <br /> tbObj.destroy(); <br /> | **Method:** *destroy()* <br /><br /> var toolbar = document.getElementById('ej2Toolbar').ej2_instances[0];<br /> toolbar.destroy(); <br /> |
| Click | **Event:** *click* <br /><br /> `<ej-toolbar click="onClick" />` <br /> | **Not Applicable** |
| BeforeCreate | **Not Applicable** | **Event:** *beforeCreate* <br /><br /> `<ejs-toolbar beforeCreate="onBeforeCreate" />` <br /> |
| Created | **Event:** *create* <br /><br /> `<ej-toolbar create="onCreate" />` <br /> | **Event:** *created* <br /><br /> `<ejs-toolbar created="onCreated" />` <br /> |
| Destroyed | **Event:** *destroy* <br /><br /> `<ej-toolbar destroy="onDestroy" />` <br /> | **Event:** *destroyed* <br /><br /> `<ejs-toolbar destroyed="onDestroyed" />` <br /> |
| FocusOut | **Event:** *focus-out* <br /><br /> `<ej-toolbar focus-out="onFocusOut" />` <br /> | **Not Applicable** |
| overflowOpen | **Event:** *overflow-open* <br /><br /> `<ej-toolbar overflow-open="onOverflowOpen" />` <br /> | **Not Applicable** |
| overflowClose | **Event:** *overflow-close* <br /><br /> `<ej-toolbar overflow-close="onOverflowClose" />` <br /> | **Not Applicable** |