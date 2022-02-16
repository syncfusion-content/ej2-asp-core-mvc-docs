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
| Keyboard Navigation | **Property:** *allow-keyboard-navigation* <br /><br /> `<ej-tab allow-keyboard-navigation="true" />` <br /> | **Not Applicable** |
| Localization | **Not Applicable** | **Property:** *locale* <br /><br /> `<ejs-tab locale="en-US" />` <br /> |
| RTL | **Property:** *enable-rtl* <br /><br /> `<ej-tab enable-rtl="true" />` <br /> | **Property:** *enableRtl* <br /><br /> `<ejs-tab enableRtl="en-US" />` <br /> |

## AjaxSettings

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Property:** *ajax-settings* <br /><br /> `<ej-tab>` <br /> &nbsp; `<e-ajax-settings type="GET" />` <br /> `</ej-tab>` <br /> | **Not Applicable** |
| Asynchronous | **Property:** *async* <br /><br />`<ej-tab>` <br /> &nbsp; `<e-ajax-settings async="true" />` <br /> `</ej-tab>` <br /> | **Not Applicable** |
| Browser Cache | **Property:** *cache* <br /><br /> `<ej-tab>` <br /> &nbsp; `<e-ajax-settings cache="false" />` <br /> `</ej-tab>` <br /> | **Not Applicable** |
| Request type | **Property:** *contentType* <br /><br /> `<ej-tab>` <br /> &nbsp; `<e-ajax-settings content-type="html" />` <br /> `</ej-tab>` <br /> | **Not Applicable** |
| Data | **Property:** *data* <br /><br /> `<ej-tab>` <br /> &nbsp; `<e-ajax-settings data="" />` <br /> `</ej-tab>` <br /> | **Not Applicable** |
| Response type | **Property:** *dataType* <br /><br /> `<ej-tab>` <br /> &nbsp; `<e-ajax-settings data-type="html" />` <br /> `</ej-tab>` <br /> | **Not Applicable** |
| HTTP request type | **Property:** *type* <br /><br /> `<ej-tab>` <br /> &nbsp; `<e-ajax-settings type="GET" />` <br /> `</ej-tab>` <br /> | **Not Applicable** |
| AjaxBeforeLoad | **Event:** *ajax-before-load* <br /><br /> `<ej-tab ajax-before-load="onBeforeLoad" />` <br /> | **Not Applicable** |
| AjaxError | **Event:** *ajax-error* <br /><br /> `<ej-tab ajax-error="onError" />`<br /> | **Not Applicable** |
| AjaxLoad | **Event:** *ajax-load* <br /><br /> `<ej-tab ajax-load="onError" />` <br /> | **Not Applicable** |
| AjaxSuccess | **Event:** *ajax-success* <br /><br /> `<ej-tab ajax-success="onSuccess" />` <br /> | **Not Applicable** |

## Animation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Not Applicable** | **Property:** *animation* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-animation previous="" next="" />` <br /> `</ejs-tab>` <br /> |
| EnableAnimation | **Property:** *enable-animation* <br /><br /> `<ej-tab enable-animation="true" />` <br /> | **Not Applicable** |
| Previous animation | **Not Applicable** | **Property:** *prev* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-previous />` <br /> `</ejs-tab>` <br /> |
| Next animation | **Not Applicable** | **Property:** *next* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-next />` <br /> `</ejs-tab>` <br /> |
| Duration <br /> [prev / next] | **Not Applicable** | **Property:** *duration* <br /><br /> `<ejs-tab>` <br /> &nbsp;`<e-tab-next duration="500" />` <br /> `</ejs-tab>` <br /> |
| Easing <br /> [prev / next] | **Not Applicable** | **Property:** *easing* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-next easing="ease-in" />` <br /> `</ejs-tab>` <br /> |
| Effect <br /> [prev / next] | **Not Applicable** | **Property:** *effect* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-next effect="SlideLeft" />` <br />`</ejs-tab>` <br /> |

## Header

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Header position | **Property:** *header-position* <br /><br /> `<ej-tab header-position="Bottom" />` <br /> | **Property:** *headerPlacement* <br /><br /> `<ejs-tab headerPlacement="Bottom" />` <br /> |
| Header size | **Property:** *header-size* <br /><br />`<ej-tab header-size="50px" />` <br /> | **Not Applicable** |
| OverflowModes | **Not Applicable** | **Property:** *overflowMode* <br /><br /> `<ejs-tab overflowMode="Popup" />` <br /> |
| TabScroll | **Property:** *enable-tab-scroll* <br /><br /> `<ej-tab enable-tab-scroll="true" />` <br /> | **Not Applicable** |

## Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Not Applicable** | **Property:** *items* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-tabitems />` <br /> `</ejs-tab>` <br /> |
| Content | **Not Applicable** | **Property:** *items[0].content* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-tabitems>` <br /> &nbsp; &nbsp; `<e-tab-tabitem content="welcome" />` <br /> &nbsp; `</e-tab-tabitems>` <br /> `</ejs-tab>` <br /> |
| Custom Class | **Not Applicable** | **Property:** *items[0].cssClass* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-tabitems>` <br /> &nbsp;&nbsp; `<e-tab-tabitem cssClass="e-custom-class" />` <br /> &nbsp; `</e-tab-tabitems>` <br /> `</ejs-tab>` <br /> |
| Header | **Not Applicable** | **Property:** *items[0].header* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-tabitems>` <br /> &nbsp;&nbsp; `<e-tab-tabitem header="@ViewBag.header" />` <br /> &nbsp; `</e-tab-tabitems>` <br /> `</ejs-tab>` <br /> |
| Icon class | **Not Applicable** | **Property:** *items[0].header.iconCss* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-tabitems>` <br /> &nbsp;&nbsp; `<e-tab-tabitem>` <br /> &nbsp;&nbsp;&nbsp; `<e-tabitem-header iconCss="e-icon" />` <br /> &nbsp;&nbsp; `</e-tab-tabitem>` <br /> &nbsp; `</e-tab-tabitems>` <br /> `</ejs-tab>` <br /> |
| Icon position | **Not Applicable** | **Property:** *items[0].header.iconPosition* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-tabitems>` <br /> &nbsp;&nbsp; `<e-tab-tabitem>` <br /> &nbsp;&nbsp;&nbsp; `<e-tabitem-header iconPosition="Left" />` <br /> &nbsp;&nbsp; `</e-tab-tabitem>` <br /> &nbsp; `</e-tab-tabitems>` <br /> `</ejs-tab>` <br /> |
| Header text | **Not Applicable** | **Property:** *items[0].header.text* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-tabitems>` <br /> &nbsp;&nbsp; `<e-tab-tabitem>` <br /> &nbsp;&nbsp;&nbsp; `<e-tabitem-header text="Tab1" />` <br /> &nbsp;&nbsp; `</e-tab-tabitem>` <br /> &nbsp; `</e-tab-tabitems>` <br /> `</ejs-tab>` <br /> |
| Get items length | **Method:** *getItemsCount()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.getItemsCount(); <br /> | **Not Applicable** |
| Add Items | **Method:** *addItem(url, displayLabel, index, cssClass, id)* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.addItem("#new", "New Item", 3, "myClass", "newItem"); <br /> | **Method:** *addTab(items, index)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.addTab([{ <br /> &nbsp; header: { text: 'Tab1' }, <br /> &nbsp; content: 'contents' }], 1 <br /> ); <br /> |
|  BeforeAdd | **Not Applicable** | **Event:** *adding* <br /><br /> `<ejs-tab adding="onAdding" />` <br /> |
| AfterAdd | **Event:** *item-add* <br /><br /> `<ej-tab item-add="itemAdd" />` <br /> | **Event:** *added* <br /><br /> `<ejs-tab added="onAdded" />` <br /> |
| Remove item | **Method:** *removeItem(index)* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.removeItem(1); <br /> | **Method:** *removeTab(index)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.removeTab(1); <br /> |
| BeforeRemove | **Event:** *before-item-remove* <br /><br />`<ej-tab before-item-remove="beforeItemRemove" />` <br /> | **Event:** *removing* <br /><br /> `<ejs-tab removing="onRemoving" />` <br /> |
| AfterRemove | **Event:** *item-remove* <br /><br /> `<ej-tab item-remove="itemRemove" />` <br /> | **Event:** *removed* <br /><br /> `<ejs-tab removed="onRemoved" />` <br /> |
| SelectedItemIndex | **Property:** *selected-item-index* <br /><br /> `<ej-tab selected-item-index="0" />` <br /> | **Property:** *selectedItem* <br /><br /> `<ejs-tab selectedItem="0" />` <br /> |
| Select item | **Not Applicable** | **Method:** *select(index)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.select(1); <br /> |
| BeforeActive | **Event:** *before-active* <br /><br /> `<ej-tab before-active="beforeActive" />` <br /> | **Event:** *selecting* <br /><br /> `<ejs-tab selecting="onSelecting" />` <br /> |
| AfterActive | **Event:** *item-active* <br /><br /> `<ej-tab item-active="itemActive" />` <br /> | **Event:** *selected* <br /><br /> `<ejs-tab selected="onSelected" />` <br /> |
| Disable items | **Property:** *disabled-item-index* <br /><br /> `<ej-tab disabled-item-index="@ViewBag.itemsIndex" />` <br /> | **Not Applicable** |
| Enable items | **Property:** *enabled-item-index* <br /><br /> `<ej-tab enabled-item-index="@ViewBag.itemsIndex" />` <br /> | **Not Applicable** |
| Enable/Disable item | **Not Applicable** | **Property:** *items[0].disabled* <br /><br /> `<ejs-tab>` <br /> &nbsp; `<e-tab-tabitems>` <br /> &nbsp; &nbsp; `<e-tab-tabitem disabled="true" />` <br /> &nbsp; `</e-tab-tabitems>` <br /> `</ejs-tab>` <br /> |
| Hide items | **Property:** *hiddenItemIndex* <br /><br /> `<ej-tab hide-item-index="@ViewBag.itemsIndex" />` <br /> | **Not Applicable** |
| Hide item | **Method:** *hideItem(index)* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.hideItem(1); <br /> | **Method:** *hideTab(index, true)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.hideTab(1, true); <br /> |
| Show item | **Method:** *showItem(index)* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.showItem(1); <br /> | **Method:** *hideTab(index, false)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.hideTab(1, false); <br /> |

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Collapse active item | **Property:** *collapsible* <br /><br /> `<ej-tab collapsible="true" />` <br /> | **Not Applicable** |
| Custom class | **Property:** *css-class* <br /><br /> `<ej-tab css-class="custom-class" />` <br /> | **Property:** *cssClass* <br /><br /> `<ejs-tab cssClass="custom-class" />` <br /> |
| Enabled | **Property:** *enabled* <br /><br /> `<ej-tab enabled="false" />` <br /> | **Method:** *disable(false)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.disable(false); <br /> |
| Persistence | **Property:** *enable-persistence* <br /><br /> `<ej-tab enable-persistence="100%" />` <br /> | **Property:** *enablePersistence* <br /><br /> `<ejs-tab enablePersistence="true" />` <br /> |
| Events | **Property:** *events* <br /><br /> `<ej-tab events="click" />` <br /> | **Not Applicable** |
| Height | **Property:** *height* <br /><br /> `<ej-tab height="100%" />` <br /> | **Property:** *height* <br /><br /> `<ejs-tab height="100%" />` <br /> |
| HeightAdjustMode | **Property:** *height-adjust-mode* <br /><br /> `<ej-tab height-adjust-mode="Content" />` <br /> | **Property:** *heightAdjustMode* <br /><br /> `<ejs-tab heightAdjustMode="Content" />` <br /> |
| HTML Attributes | **Property:** *html-attributes* <br /><br /> `<ej-tab html-attributes="" />` <br /> | **Not Applicable** |
| ID prefix | **Property:** *id-prefix* <br /><br /> `<ej-tab id-prefix="ej-tab-" />` <br /> | **Not Applicable** |
| ShowCloseButton | **Property:** *show-close-button* <br /><br /> `<ej-tab show-close-button="true" />` <br /> | **Property:** *showCloseButton* <br /><br /> `<ejs-tab showCloseButton="true" />` <br /> |
| showReloadIcon | **Property:** *show-reload-icon* <br /><br /> `<ej-tab show-reload-icon="true" />` <br /> | **Not Applicable** |
| ShowRoundedCorner | **Property:** *show-rounded-corner* <br /><br /> `<ej-tab show-rounded-corner="true" />` <br /> | **Not Applicable** |
| Width | **Property:** *width* <br /><br /> `<ej-tab width="100%" />` <br /> | **Property:** *width* <br /><br /> `<ejs-tab width="100%" />` <br /> |
| Destroy | **Not Applicable** | **Method:** *destroy()* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0];<br /> tab.destroy(); <br /> |
| Disable Tab | **Method:** *disable()* <br /><br />var tabObj = $("#tab").data("ejTab"); <br /> tabObj.disable(); <br /> | **Method:** *disable(true)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.disable(true); <br /> |
| Enable Tab | **Method:** *enable()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.enable(); <br /> | **Method:** *disable(false)* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0]; <br /> tab.disable(false); <br /> |
| Hide Tab | **Method:** *hide()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.hide(); <br /> | **Not Applicable** |
| Refresh | **Not Applicable** | **Method:** *refresh()* <br /><br /> var tab = document.getElementById('ej2Tab').ej2_instances[0];<br /> tab.refresh(); <br /> |
| Show Tab | **Method:** *show()* <br /><br /> var tabObj = $("#tab").data("ejTab"); <br /> tabObj.show(); <br /> | **Not Applicable** |
| Created | **Event:** *create* <br /><br /> `<ej-tab create="onCreate" />` <br /> | **Event:** *created* <br /><br /> `<ejs-tab created="onCreated" />` <br /> |
| Destroyed | **Event:** *destroy* <br /><br /> `<ej-tab destroy="onDestroy" />` <br /> | **Event:** *destroyed* <br /><br /> `<ejs-tab destroyed="onDestroyed" />` <br /> |