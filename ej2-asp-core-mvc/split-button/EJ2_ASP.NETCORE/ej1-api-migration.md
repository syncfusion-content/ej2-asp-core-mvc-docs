---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Split Button Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Split Button component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of SplitButton component from Essential JS 1 to Essential JS 2.

## Properties

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Specifies the text of the splitbutton | **Property:** *text* <br/><br/> `<ej-split-button id="splitbutton" text="login"></ej-split-button>` | **Property:** *content* <br/><br/> `<ejs-splitbutton id="splitbutton" content="Paste"></ejs-splitbutton>` |
| Popup content | **Property:** *target* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target"></ej-split-button>` | **Property:** *target* <br/><br/> `<ejs-splitbutton id="splitbutton" target="#target" content="SplitButton" ></ejs-splitbutton>` |
| Popup items | Not applicable | **Property:** *items* <br/><br/> `<ejs-splitbutton id="splitbutton" content="Paste" items="ViewBag.items"></ejs-splitbutton>` |
| Arrow position | **Property:** *arrowPosition* <br/><br/> `<ej-split-button id="splitbutton" text="login" target="#target" arrow-position="@ArrowPosition.Left"></ej-split-button>` | Not applicable |
| Button mode | **Property:** *buttonMode* <br/><br/> `<ej-split-button id="splitbutton" text="login" target="#target" button-mode="@ButtonMode.Dropdown"></ej-split-button>` | Not applicable |
| Content type | **Property:** *contentType* <br/><br/> `<ej-split-button id="splitbutton" text="login" content-type="TextOnly" target="#target"></ej-split-button>` | Not applicable |
| Icons | **Property:** *prefixIcon* <br/><br/> `<ej-split-button id="splitbutton" text="login" content-type="TextAndImage" prefix-icon="e-icon e-handup" target="#target"></ej-split-button>` | **Property:** *iconCss* <br/><br/> `<ejs-splitbutton id="splitbutton" content="Paste" items="ViewBag.items" iconCss="e-icons e-paste"></ejs-splitbutton>` |
| Icon position | **Property:** *imagePosition* <br/><br/>  `<ej-split-button id="splitbutton" text="login" content-type="TextAndImage" prefix-icon="e-icon e-handup" target="#target" image-position="@ImagePosition.ImageTop"></ej-split-button>` | **Property:** *iconPosition* <br/><br/> `<ejs-splitbutton id="splitbutton" content="Paste" items="ViewBag.items" iconCss="e-icons e-paste" iconPosition="Top"></ejs-splitbutton>` |
| Secondary icon | **Property:** *suffixIcon* <br/><br/> `<ej-split-button id="splitbutton" text="login" content-type="ImageTextImage" prefix-icon="e-icon e-handup" suffix-icon="e-icon e-palette" target="#target"></ej-split-button>` | Not applicable |
| Adding custom class | **Property:** *cssClass* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" css-class="custom-class"></ej-split-button>` | **Property:** *cssClass* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" cssClass="custom-class"></ejs-splitbutton>` |
| Disabled state | **Property:** *enabled* <br/><br/> `<ej-split-button id="splitbutton" text="login" target="#target" enabled="false"></ej-split-button>` | **Property:** *disabled* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" disabled="true"></ejs-splitbutton>` |
| RTL | **Property:** *enableRTL* <br/><br/> `<ej-split-button id="splitbutton" text="login" target="#target" content-type="TextAndImage" prefix-icon="e-icon e-handup" enable-rtl="true"></ej-split-button>` | **Property:** *enableRtl* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="Paste" enableRtl="true" iconCss="e-icons e-paste"></ejs-splitbutton>` |
| Height | **Property:** *height* <br/><br/> `<ej-split-button id="splitbutton" text="login" target="#target" height="30"></ej-split-button>` | Not applicable |
| Width | **Property:** *width* <br/><br/> `<ej-split-button id="splitbutton" text="login" target="#target" width="100"></ej-split-button>` | Not applicable |
| HTML attributes | **Property:** *htmlAttributes* <br/><br/> `<ej-split-button id="splitbutton" text="login" target="#target" html-attributes=""></ej-split-button>` | Not applicable |
| Show rounded corner | **Property:** *showRoundedCorner* <br/><br/> `<ej-split-button id="splitbutton" text="login" target="#target" show-rounded-corner="true"></ej-split-button>` | Not applicable |
| Size | **Property:** *size* <br/><br/> `<ej-split-button id="splitbutton" size="@ButtonSize.Small" text="Small" target="#target"></ej-split-button>` | **Property:** *cssClass* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="Small" cssClass="e-small"></ejs-splitbutton>` |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Destroy method | **Method:** *destroy* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target"></ej-split-button>`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.destroy(); | **Method:** *destroy* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton"></ejs-splitbutton>`<br/>var splitButton = document.getElementById("splitbutton").ej2_instances[0];<br/> splitButton.destroy(); |
| Disable method | **Method:** *disable* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target"></ej-split-button>`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.disable(); | Not applicable |
| Enable method | **Method:** *enable* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target"></ej-split-button>`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.enable(); | Not applicable |
| Hide popup | **Method:** *hide* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target"></ej-split-button>`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.hide(); | **Method:** *toggle* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton"></ejs-splitbutton>`<br/>var splitButton = document.getElementById("splitbutton").ej2_instances[0];<br/> splitButton.toggle(); |
| Show popup | **Method:** *show* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target"></ej-split-button>`<br/>var splitButton = $("#splitbutton").data("ejSplitButton");<br/> splitButton.show(); | **Method:** *toggle* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton"></ejs-splitbutton>`<br/>var splitButton = document.getElementById("splitbutton").ej2_instances[0];<br/> splitButton.toggle(); |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| BeforeOpen event | **Event:** *beforeOpen* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" before-open="beforeOpen"></ej-split-button>`<br/>function beforeOpen(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *beforeOpen* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton" beforeOpen="beforeOpen"></ejs-splitbutton>`<br/>function beforeOpen(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| Click event | **Event:** *click* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" click="click"></ej-split-button>` <br/>function click(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *click* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton" click="click"></ejs-splitbutton>`<br/>function click(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| Close event | **Event:** *close* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" close="close"></ej-split-button>` <br/>function close(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *close* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton" close="close"></ejs-splitbutton>`<br/>function close(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| Create event | **Event:** *create* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" create="create"></ej-split-button>` <br/>function create(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *created* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton" created="created"></ejs-splitbutton>`<br/>function created() {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>}|
| Destroy event | **Event:** *destroy* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" destroy="destroy"></ej-split-button>` <br/>function destroy(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | Not applicable |
| ItemMouseOut event | **Event:** *itemMouseOut* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" item-mouse-out="itemMouseOut"></ej-split-button>` <br/>function itemMouseOut(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | Not applicable |
| ItemMouseOver event | **Event:** *itemMouseOver* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" item-mouse-over="itemMouseOver"></ej-split-button>` <br/>function itemMouseOver(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | Not applicable |
| Item select event | **Event:** *itemSelected* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" item-selected="itemSelected"></ej-split-button>` <br/>function itemSelected(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *select* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton" select="select"></ejs-splitbutton>` <br/>function select(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| Open event | **Event:** *open* <br/><br/> `<ej-split-button id="splitbutton" text="SplitButton" target="#target" open="open"></ej-split-button>` <br/>function open(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} | **Event:** *open* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton" open="open"></ejs-splitbutton>`<br/>function open(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| BeforeClose event | Not applicable | **Event:** *beforeClose* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton" beforeClose="beforeClose"></ejs-splitbutton>`<br/>function beforeClose(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |
| BeforeItemRender event | Not applicable | **Event:** *beforeItemRender* <br/><br/> `<ejs-splitbutton id="splitbutton" items="ViewBag.items" content="SplitButton" beforeItemRender="beforeItemRender"></ejs-splitbutton>`<br/>function beforeItemRender(args) {<br/> &nbsp;&nbsp;&nbsp;&nbsp; /** code block */ <br/>} |