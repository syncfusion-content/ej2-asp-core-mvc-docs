---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Button Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Button component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Button component from Essential JS 1 to Essential JS 2.

## Properties

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Specifies the text of the button | **Property:** *text* <br/><br/> `<ej-button id="btn" text="Button" />` | **Property:** *content* <br/><br/> `<ejs-button id="btn" content="Button"></ejs-button>` |
| Specifies the content type of the button | **Property:** *ContentType* <br/><br/>  `<ej-button id="btn" text="Save" content-type="@ContentType.TextAndImage" prefix-icon="e-icon e-save" />`| Not applicable |
| Specifies icon for the button | **Property:** *prefixIcon* <br/><br/> `<ej-button id="btn" content-type="@ContentType.ImageOnly" prefix-icon="e-icon e-save" />` | **Property:** *iconCss* <br/><br/> `<ejs-button id="btn" iconCss="e-icons e-save"></ejs-button>` |
| Positioning icon in the button | **Property:** *imagePosition* <br/><br/> `<ej-button id="btn" content-type="@ContentType.TextAndImage" text="Save" prefix-icon="e-icon e-save" image-position="@ImagePosition.ImageRight" />`| **Property:** *iconPosition* <br/><br/> `<ejs-button id="btn" content="Save" iconCss="e-icons e-save" iconPosition="Right"></ejs-button>` |
| Specifies secondary icon for the button | **Property:** *suffixIcon* <br/><br/> `<ej-button id="btn" text="FileSearch" content-type="@ContentType.ImageTextImage" prefix-icon="e-icon e-search" suffix-icon="e-icon e-file-html" />` | Not applicable |
| Adding custom class | **Property:** *cssClass* <br/><br/> `<ej-button id="btn" text="Button" css-class="custom-class" />` | **Property:** *cssClass* <br/><br/> `<ejs-button id="btn" cssClass="custom-class" content="Button"></ejs-button>` |
| Specifies the size of the button | **Property:** *size* <br/><br/> `<ej-button id="btn" text="Button" size="@ButtonSize.Small" />` | **Property:** *cssClass* <br/><br/> `<ejs-button id="btn" cssClass="e-small" content="Button"></ejs-button>` |
| Triggers click event repeatedly while pressing the button | **Property:** *repeatButton* <br/><br/> `<ej-button id="btn" text="Click" repeat-button="true" />` | Not applicable |
| Sets time interval between two consecutive click event on the repeat button | **Property:** *timeInterval* <br/><br/> `<ej-button id="btn" text="Click" repeat-button="true" time-interval="100" />` | Not applicable |
| Specifies the type of the button | **Property:** *type* <br/><br/> `<ej-button id="btn" text="Submit" button-type="@ButtonType.Submit" />` | Not applicable |
| Changes normal button into rounded corner | **Property:** *showRoundedCorner* <br/><br/>  `<ej-button id="btn" text="Button" show-rounded-corner="true" />` | Not applicable |
| Specifies the width of the button | **Property:** *width* <br/><br/> `<ej-button id="btn" text="Button" width="150px" />` | Not applicable |
| Specifies the height of the button | **Property:** *height* <br/><br/> `<ej-button id="btn" text="Button" height="50px" />` | Not applicable |
| Adds HTML attributes to the button | **Property:** *htmlAttributes* <br/><br/> `<ej-button id="btn" text="Button" html-attributes="" />` | Not applicable |
| Allows the appearance of the Button to be enhanced and visually appealing | Not applicable | **Property:** *isPrimary* <br/><br/> `<ejs-button id="btn" isPrimary="true" content="Button"></ejs-button>` |
| Makes the button toggle from normal to active state | **Property:** *isToggle* <br/><br/> Not applicable | **Property:** *isToggle* <br/><br/> `<ejs-button id="btn" isToggle="true" content="Play"></ejs-button>`  |
| Specifies the disabled state of the button | **Property:** *enabled* <br/><br/> `<ej-button id="btn" text="Button" enabled="false" />` | **Property:** *disabled* <br/><br/> `<ejs-button id="btn" disabled="true" content="Button"></ejs-button>` |
| Enable or disable rendering component in right to left direction | **Property:** *enableRTL* <br/><br/>  `<ej-button id="btn" content-type="@ContentType.TextAndImage" text="Save" prefix-icon="e-icon e-save" enable-rtl="true" />` | **Property:** *enableRtl* <br/><br/> `<ejs-button id="btn" enableRtl="true" content="Save" iconCss="e-icons e-save"></ejs-button>` |

## Methods

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Destroys the control | **Methods:** *destroy* <br/><br/> `<ej-button id="btn" text="Button" />` <br/> var btnObj = $("#btn").data("ejButton");<br/>btnObj.destroy(); | **Methods:** *destroy* <br/><br/> `<ejs-button id="btn" content="Button"></ejs-button>` <br/> var btnObj = document.getElementById("btn").ej2_instances[0];<br/>btnObj.destroy(); |
| Disables the button | **Methods:** *disable* <br/><br/> `<ej-button id="btn" text="Button" />` <br/> var btnObj = $("#btn").data("ejButton");<br/>btnObj.disable(); | Not applicable |
| Enables the button | **Methods:** *enable* <br/><br/> `<ej-button id="btn" text="Button" />` <br/> var btnObj = $("#btn").data("ejButton");<br/>btnObj.enable(); | Not applicable |

## Events

| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| Triggers while clicking the button | **Events:** *click* <br/><br/> `<ej-button id="btn" text="Button" click="btnClick" />` <br/>function btnClick(args) {<br/>/** code block */<br/>} | Not applicable |
| Triggers once the component rendering is completed | **Events:** *create* <br/><br/> `<ej-button id="btn" text="Button" click="create" />` <br/>function create(args) {<br/>/** code block */<br/>} | **Events:** *created* <br/><br/> `<ejs-button id="btn" content="Button" created="created"></ejs-button>`<br/>function created() {<br/>/** code block */<br/>} |
| Triggers once the component is destroyed | **Events:** *destroy* <br/><br/> `<ej-button id="btn" text="Button" destroy="destroy" />` <br/>function destroy(args) {<br/>/** code block */<br/>} | Not applicable |