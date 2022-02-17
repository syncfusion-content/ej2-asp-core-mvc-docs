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
| Keyboard Navigation | **Property:** *allow-keyboard-navigation* <br /><br /> `<ej-accordion allow-keyboard-navigation="true" />` <br /> | **Not Applicable** |
| Localization | **Not Applicable** | **Property:** *locale* <br /><br /> `<ejs-accordion locale="en-US" />` <br /> |
| RTL | **Property:** *enable-rtl* <br /><br /> `<ej-accordion enable-rtl="true" />` <br /> | **Property:** *enableRtl* <br /><br /> `<ejs-accordion enableRtl="true" />` <br /> |

## AjaxSettings

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Property:** *ajax-settings* <br /><br /> `<ej-accordion>` <br /> &nbsp; `<e-ajax-settings type="GET" />` <br /> `</ej-accordion>` <br /> | **Not Applicable** |
| Asynchronous | **Property:** *async* <br /><br /> `<ej-accordion>` <br /> &nbsp; `<e-ajax-settings async="true" />` <br /> `</ej-accordion>` <br /> | **Not Applicable** |
| Browser Cache | **Property:** *cache* <br /><br /> `<ej-accordion>` <br /> &nbsp; `<e-ajax-settings cache="false" />` <br /> `</ej-accordion>` <br /> | **Not Applicable** |
| Request type | **Property:** *contentType* <br /><br /> `<ej-accordion>` <br /> &nbsp; `<e-ajax-settings content-type="html" />` <br /> `</ej-accordion>` <br /> | **Not Applicable** |
| Data | **Property:** *data* <br /><br /> `<ej-accordion>` <br /> &nbsp; `<e-ajax-settings data="" />` <br /> `</ej-accordion>` <br /> | **Not Applicable** |
| Response type | **Property:** *dataType* <br /><br /> `<ej-accordion>` <br /> &nbsp; `<e-ajax-settings data-type="html" />` <br /> `</ej-accordion>` <br /> | **Not Applicable** |
| HTTP request type | **Property:** *type* <br /><br /> `<ej-accordion>` <br /> &nbsp; `<e-ajax-settings type="GET" />` <br /> `</ej-accordion>` <br /> | **Not Applicable** |
| AjaxBeforeLoad | **Event:** *ajax-before-load* <br /><br /> `<ej-accordion ajax-before-load="beforeLoad" />` <br /> | **Not Applicable** |
| AjaxError | **Event:** *ajax-error* <br /><br /> `<ej-accordion ajax-error="onError" />` <br /> | **Not Applicable** |
| AjaxLoad | **Event:** *ajax-load* <br /><br /> `<ej-accordion ajax-load="onLoad" />` <br /> | **Not Applicable** |
| AjaxSuccess | **Event:** *ajax-success* <br /><br /> `<ej-accordion ajax-success="onSuccess" />` <br /> | **Not Applicable** |

## Animation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Not Applicable** | **Property:** *animation* <br /><br /> `<ejs-accordion enableRtl="true">` <br /> &nbsp; `<e-accordion-animation expand="" collapse="" />` <br /> `</ejs-accordion>` <br /> |
| EnableAnimation | **Property:** *enable-animation* <br /><br /> `<ej-accordion enable-animation="false" />` <br /> | **Not Applicable** |
| Expand animation | **Not Applicable** | **Property:** *expand* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-animation expand="@ViewBag.animation" />` <br /> `</ejs-accordion>` <br /> |
| Collapse animation | **Not Applicable** | **Property:** *collapse* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-animation collapse="@ViewBag.animation" />` <br /> `</ejs-accordion>` <br /> |
| Duration <br /> [expand / collapse] | **Not Applicable** | **Property:** *duration* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-expand duration="400" />` <br /> &nbsp; `</ejs-accordion>` <br /> |
| Easing <br /> [expand / collapse] | **Not Applicable** | **Property:** *easing* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-expand easing="ease-in" />` <br /> &nbsp; `</ejs-accordion>` <br /> |
| Effect <br /> [expand / collapse] | **Not Applicable** | **Property:** *effect* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-expand effect="SlideLeft" />` <br /> &nbsp; `</ejs-accordion>` <br /> |

## Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Not Applicable** | **Property:** *items* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-accordionitems />` <br /> `</ejs-accordion>` <br /> |
| Content | **Not Applicable** | **Property:** *items[0].content* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-accordionitems>` <br /> &nbsp; &nbsp; `<e-accordion-accordionitem content="Welcome" />` <br /> &nbsp; `</e-accordion-accordionitems>` <br /> `</ejs-accordion>` <br /> |
| Custom class | **Not Applicable** | **Property:** *items[0].cssClass* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-accordionitems>` <br /> &nbsp;&nbsp; `<e-accordion-accordionitem cssClass="custom-style" />` <br /> &nbsp; `</e-accordion-accordionitems>` <br /> `</ejs-accordion>` <br /> |
| Header | **Not Applicable** | **Property:** *items[0].header* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-accordionitems>` <br /> &nbsp;&nbsp; `<e-accordion-accordionitem header="Syncfusion" />` <br /> &nbsp; `</e-accordion-accordionitems>` <br /> `</ejs-accordion>` <br /> |
| HeaderSize | **Property:** *header-size* <br /><br /> `<ej-accordion header-size="50px" />` <br /> | **Not Applicable** |
| Icon class | **Not Applicable** | **Property:** *items[0].iconCss* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-accordionitems>` <br /> &nbsp;&nbsp; `<e-accordion-accordionitem iconCss="e-pause" />` <br /> &nbsp; `</e-accordion-accordionitems>` <br /> `</ejs-accordion>` <br /> |
| IsExpand | **Not Applicable** | **Property:** *items[0].expanded* <br /><br /> `<ejs-accordion>` <br /> &nbsp; `<e-accordion-accordionitems>` <br /> &nbsp;&nbsp; `<e-accordion-accordionitem expanded="true" />` <br /> &nbsp; `</e-accordion-accordionitems>` <br /> `</ejs-accordion>` <br /> |
| Collapse Item | **Method:** *collapsePanel(index)* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.collapsePanel(0); <br /> | **Method:** *expandItem(index, false)* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.expandItem(0, false); <br /> |
| Expand Item | **Method:** *expandPanel(index)* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.expandPanel(0); <br /> | **Method:** *expandItem(index, true)* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.expandItem(0, true); <br /> |
| CollapseAll | **Method:** *collapseAll()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.collapseAll(); <br /> | **Not Applicable** |
| ExpandAll | **Method:** *expandAll()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.expandAll(); <br /> | **Not Applicable** |
| Get ItemsCount | **Method:** *getItemsCount()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.getItemsCount(); <br /> | **Not Applicable** |
| AddItem | **Method:** *addItem(text, content, index)* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.addItem("New item", "The accordion content", 2); <br /> | **Method:** *addItem(items, index)* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.addItem([{ header: 'App', content: 'text' }], 0) <br /> |
| Remove Item | **Method:** *removeItem(index)* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.removeItem(0); <br /> | **Method:** *removeItem(index)* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.removeItem(0) <br /> |
| Disable Items | **Property:** *disabled-items* <br /><br /> `<ej-accordion disabled-items="@ViewBag.disableItems" />` <br /> | **Not Applicable** |
| Enable Items | **Property:** *enabled-items* <br /><br /> `<ej-accordion enabled-items="@ViewBag.enableItems" />` <br /> | **Not Applicable** |
| Disable Item | **Method:** *disableItems([index])* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.disableItems([1]); <br /> | **Method:** *enableItem(index, false)* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.enableItem(0, false) <br /> |
| Enable Item | **Method:** *enableItems([index])* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.enableItems([1]); <br /> | **Method:** *enableItem(index, true)* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.enableItem(0, true) <br /> |
| Hide Item | **Not Applicable** | **Method:** *hideItem(index, true)* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.hideItem(0, true) <br /> |
| SelectedItemIndex | **Property:** *selected-item-index* <br /><br /> `<ej-accordion selected-item-index="0" />` <br /> | **Not Applicable** |
| Select | **Not Applicable** | **Method:** *select(index)* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.select(0) <br /> |
| BeforeActivate | **Event:** *before-activate* <br /><br /> `<ej-accordion before-activate="beforeActive" />` <br /> | **Event:** *expanding* <br /><br /> `<ejs-accordion expanding="onExpanding" />` <br /> |
| Activate | **Event:** *activate* <br /><br /> `<ej-accordion activate="onActivate" />` <br /> | **Event:** *expanded* <br /><br /> `<ejs-accordion expanded="onExpanded" />` <br /> |
| beforeInActivate | **Event:** *before-in-activate* <br /><br /> `<ej-accordion before-in-activate="beforeInActive" />` <br /> | **Not Applicable** |
| InActive | **Event:** *in-activate* <br /><br /> `<ej-accordion in-activate="inActivate" />` <br /> | **Not Applicable** |
| Clicked | **Not Applicable** | **Event:** *clicked* <br /><br /> `<ejs-accordion clicked="onClicked" />` <br /> |

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Collapsible | **Property:** *collapsible* <br /><br /> `<ej-accordion collapsible="false" />` <br /> | **Not Applicable** |
| Collapse speed | **Property:** *collapse-speed* <br /><br /> `<ej-accordion collapse-speed="500" />` <br /> | **Not Applicable** |
| Custom class | **Property:** *css-class* <br /><br /> `<ej-accordion css-class="e-icon" />` <br /> | **Not Applicable** |
| CustomIcon class | **Property:** *custom-icon* <br /><br /> `<ej-accordion custom-icon="@ViewBag.customIcon" />` <br /> | **Not Applicable** |
| Enabled | **Property:** *enabled* <br /><br /> `<ej-accordion enabled="false" />` <br /> | **Not Applicable** |
| Events | **Property:** *events* <br /><br /> `<ej-accordion events="mouseover" />` <br /> | **Not Applicable** |
| Expand speed | **Property:** *expand-speed* <br /><br /> `<ej-accordion expand-speed="300" />` <br /> | **Not Applicable** |
| Height | **Property:** *height* <br /><br /> `<ej-accordion height="700px" />` <br /> | **Property:** *height* <br /><br /> `<ejs-accordion height="700px" />` <br /> |
| HeightAdjustMode | **Property:** *height-adjust-mode* <br /><br /> `<ej-accordion height-adjust-mode="Content" />` <br /> | **Not Applicable** |
| HtmlAttributes | **Property:** *html-attributes* <br /><br /> `<ej-accordion html-attributes="@ViewBag.attributes" />` <br /> | **Not Applicable** |
| MultipleOpen | **Property:** *enable-multiple-open* <br /><br /> `<ej-accordion enable-multiple-open="true" />` <br /> | **Property:** *expandMode* <br /><br /> `<ejs-accordion expandMode="Multiple" />` <br /> |
| Persistence | **Property:** *enable-persistence* <br /><br /> `<ej-accordion enable-persistence="true" />` <br /> | **Property:** *enablePersistence* <br /><br /> `<ejs-accordion enablePersistence="true" />` <br /> |
| ShowRounderCorner | **Property:** *show-rounded-corner* <br /><br /> `<ej-accordion show-rounded-corner="true" />` <br /> | **Not Applicable** |
| Width | **Property:** *width* <br /><br /> `<ej-accordion width="500px" />` <br /> | **Property:** *width* <br /><br /> `<ejs-accordion width="500px" />` <br /> |
| Enable | **Method:** *enable()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.enable(); <br /> | **Not Applicable** |
| Disable | **Method:** *disable()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.disable(); <br /> | **Not Applicable** |
| Show | **Method:** *show()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.show(); <br /> | **Not Applicable** |
| Hide | **Method:** *hide()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.hide(); <br /> | **Not Applicable** |
| Destroy | **Method:** *destroy()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.destroy(); <br /> | **Method:** *destroy()* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.destroy(); <br /> |
| Refresh | **Method:** *refresh()* <br /><br /> var accordion = $("#accordion").data("ejAccordion"); <br /> accordion.refresh(); <br /> | **Method:** *refresh()* <br /><br /> var accordion = document.getElementById('accordion').ej2_instances[0]; <br /> accordion.refresh(); <br /> |
| Created | **Event:** *create* <br /><br /> `<ej-accordion create="onCreate" />` <br /> | **Event:** *created* <br /><br /> `<ejs-accordion created="onCreated" />` <br /> |
| Destroyed | **Event:** *destroy* <br /><br /> `<ej-accordion destroy="onDestroy" />` <br /> | **Event:** *destroyed* <br /><br /> `<ejs-accordion destroyed="onDestroyed" />` <br /> |