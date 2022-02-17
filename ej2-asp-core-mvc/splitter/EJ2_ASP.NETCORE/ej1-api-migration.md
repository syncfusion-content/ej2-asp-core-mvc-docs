---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Splitter Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Splitter component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Splitter component from Essential JS 1 to Essential JS 2.

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Adding custom class | **Property:** *cssClass* <br /><br />`<ej-Splitter id=”splitter” css-class=”customClass”></ej-Splitter>`<br /> | **Property:** *cssClass* <br /><br />`<ejs-splitter id=”splitter” css-class=”customClass”></ejs-splitter>`<br/> |
| Adjusting Height | **Property:** *height* <br /><br/>`<ej-Splitter id=”splitter” height=”100%”></ej-Splitter>`<br /> | **Property:** *height* <br /> <br />`<ejs-splitter id=”splitter” height=”100%”></ejs-splitter>`<br/> |
| Adjusting Width | **Property:** *width* <br /><br />`<ej-Splitter id=”splitter” width=”600”></ej-Splitter>`<br /> | **Property:** *width* <br />`<ejs-splitter id=”splitter” width=”100%”></ejs-splitter>`<br /> |
| Orientation | **Property:** *orientation* <br />`<ej-Splitter id=”splitter” orientation=”@Orientation.Vertical”></ej-Splitter>`<br /> | **Property:** *orientation* <br />`<ejs-splitter id=”splitter” orientation=”Vertical”></ejs-splitter>`<br /> |
| Separator Size | Not Available | **Property:** *separatorSize* <br />`<ejs-splitter id=”splitter” separatorSize=”4”></ejs-splitter>`<br /> |
| Adding HTML attributes | **Property:** *htmlAttributes* <br /><br />`@{IDictionary`<br/>`<string, object> htmlAttribute =`<br/> `new Dictionary<string, object>();`<br/>`htmlAttribute.Add(“class”, “my-class”)`<br/>}<br/>`<ej-Splitter id=”splitter” html-attribute=”@htmlAttribute”></ej-Splitter>`<br /> | Not Available |
| Customize expand/collapse icons | **Property:** <br /> *expanderTemplate* <br />`<ej-Splitter id=”splitter” expander-template=”<img class=”eimg” src=”expander.png” alt=”employee”/>”></ej-Splitter>`<br /> | Not Available |
| Make control flexible for mobile view | **Property:** *isResponsive* <br />`<ej-Splitter id=”splitter” is-responsive=”true”></ej-Splitter>`<br /> | By default, Splitter works with mobile mode.|
| Refresh the Splitter | **Method:** *refresh()* <br /><br />`<ej-Splitter id=”splitter”></ej-Splitter>`<br/>$(“#splitter”).ejSplitter(“refresh”)<br /> | **Method:** *refresh()* <br />`<ejs-splitter id=”splitter”></ejs-splitter>`<br/>$(“#splitter”).ejSplitter(“refresh”);<br /> |
| Destroy the Control | **Method:** *destroy()* <br /><br />`<ej-Splitter id=”splitter”></ej-Splitter>`<br/>$(“#splitter”).ejSplitter(“destroy”)<br/>| **Method:** *destroy()* <br />`<ejs-splitter id=”splitter”></ejs-splitter>`<br/>$(“#splitter”).ejSplitter(“destroy”);<br /> |
| Event triggers after the Splitter created successfully | **Event:** *create* <br /><br />`<ej-Splitter id=”splitter” create=”onCreate”></ej-Splitter>`<br/>function onCreate(args) {}<br/> | **Event:** *created* <br /><br />`<ejs-splitter id=”splitter” create=”onCreate”></ejs-splitter>`<br/>function onCreate(args) {}<br/> |
| Event triggers when Splitter has been destroyed | **Event:**  *destroy* <br /><br />`<ej-Splitter id=”splitter” destroy=”onDestroy”></ej-Splitter>`<br/>function onDestroy(args) {}<br/> | Not Available |

## Accessibility and Localization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Keyboard Navigation | **Property:** *allowKeyboardNavigation* <br /><br />`<ej-Splitter id=”splitter” allow-keyboard-navigation=”true”></ej-Splitter>`<br/> | No separate property for enable/disable keyboard navigation.  Its enabled by default. |
| Right to Left | **Property:** *enableRTL* <br /><br />`<ej-Splitter id=”splitter” enable-rtl=”true”></ej-Splitter>`<br /> | **Property:** *enableRtl*<br /><br />`<ejs-splitter id=”splitter” enable-rtl=”true”></ejs-splitter>`<br/> |

## Control State

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Enable/Disable the control | Not Available | **Property:** *enabled* <br /><br />`<ejs-splitter id=”splitter” enabled=”true”></ejs-splitter>`<br/> |

## State Maintenance

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Save the model value in local storage or cookies | Not Available | **Property:** *enablePersistence* <br /><br />`<ejs-splitter id=”splitter” enable-persistence=”true”></ejs-splitter>`<br/> |

## Pane Properties

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Property:** *properties* <br /><br /> `<ej-Splitter id=”splitter”><br/><e-split-panes>`<br/>`<e-split-panes>`<br/>`</ej-Splitter>`<br /> | **Property:** *paneSettings* <br /><br />`<ejs-splitter id=”splitter”>`<br />`<e-splitter-panes>`<br />`<e-splitter-panes>`<br />`</ejs-splitter>`<br /> |
| Pane Content | Not Available | **Property:** *content* <br /><br />`<ejs-splitter id=”splitter”>`<br/>`<e-splitter-panes>`<br/>`<e-splitter-pane content=”<div>First pane Content</div>”>`<br/>`</e-splitter-pane>`<br/>`<e-splitter-panes>`<br/>`</ejs-splitter>` |
| Change the size of the pane | **Property:** *paneSize* <br /><br />`<ej-Splitter id=”splitter”>`<br/>`<e-split-panes>`<br/>`<e-split-pane pane-size=”35%”></e-split-pane>`<br/>`<e-split-panes>`<br/>`</ej-Splitter>`<br /> | **Property:** *size* <br /><br />`<ejs-splitter id=”splitter”>`<br />`<e-splitter-panes>`<br />`<e-splitter-pane size=”25%”>`<br />`</e-splitter-pane>`<br />`<e-splitter-panes>`<br />`</ejs-splitter>`|
| Minimum pane size | **Property:** *minSize* <br /><br />`<ej-Splitter id=”splitter”>`<br />`<e-split-panes>`<br />`<e-split-pane min-size=”35%”></e-split-pane>`<br />`<e-split-panes>`<br />`</ej-Splitter>` | **Property:** *min* <br /><br />`<ejs-splitter id=”splitter”>`<br />`<e-splitter-panes>`<br />`<e-splitter-pane min=”60px”>`<br />`</e-splitter-pane>`<br />`<e-splitter-panes>`<br />`</ejs-splitter>`|
| Maximum pane size | **Property:** *maxSize* <br />`<ej-Splitter id=”splitter”>`<br />`<e-split-panes>`<br />`<e-split-pane max-size=”30”></e-split-pane>`<br />`<e-split-panes>`<br />`</ej-Splitter>`<br />| **Property:** *max* <br /><br />`<ejs-splitter id=”splitter”>`<br />`<e-splitter-panes>`<br />`<e-splitter-pane max=”60px”>`<br />`</e-splitter-pane>`<br />`<e-splitter-panes>`<br />`</ejs-splitter>` |
| Enable/Disable the Pane Resizable behavior | **Property:** *resizable* <br /><br />`<ej-Splitter id=”splitter”>`<br />`<e-split-panes>`<br />`<e-split-pane resizable=”true”></e-split-pane>`<br />`<e-split-panes>`<br />`</ej-Splitter>`<br /> | **Property:** *resizable* <br /><br />`<ej-Splitter id=”splitter”>`<br />`<e-split-panes>`<br />`<e-split-pane resizable=”true”></e-split-pane>`<br />`<e-split-panes>`<br />`</ej-Splitter>` |
| Collapsible |**Property:** *collapsible* <br /><br />`<ej-Splitter id=”splitter”>`<br />`<e-split-panes>`<br />`<e-split-pane collapsible=”true”></e-split-pane>`<br />`<e-split-panes>`<br />`</ej-Splitter>`<br /> | **Property:** *collapsible* <br /><br />`<ejs-splitter id=”splitter”>`<br/>`<e-splitter-panes>`<br/>`<e-splitter-pane collapsible=”true”>`<br/>`</e-splitter-pane>`<br/>`<e-splitter-panes>`<br/>`</ejs-splitter>`<br/> |
| Expandable | **Property:** *expandable* <br /><br />`<ej-Splitter id=”splitter”>`<br />`<e-split-panes>`<br />`<e-split-pane expandable=”true”></e-split-pane>`<br />`<e-split-panes>`<br />`</ej-Splitter>`<br /> | Not Available |
| Collapsed | Not Available | **Property:** *collapsed* <br /><br />`<ejs-splitter id=”splitter”>`<br />`<e-splitter-panes>`<br />`<e-splitter-pane collapsed=”true”>`<br />`</e-splitter-pane>`<br />`<e-splitter-panes>`<br />`</ejs-splitter>` |
| Add Pane | **Method:** *addItem()* <br />`<ej-Splitter id=”splitter”>`<br/>`</ej-Splitter>`<br/>$(“#splitter”).ejSplitter(“addItem”, “New Pane 0”,<br/> {paneSize:20, minSize:20, maxSize: 100}, 0);<br /> |**Method:** *addPane()* <br />`<ejs-splitter id=”splitter”></ejs-splitter>`<br/>$(“#splitter”).ejSplitter(“addPane”, “New Pane 0”,<br/> { size: “25%”, content: “Pane”}, 0);<br /> |
| Remove Pane | **Method:** *removeItem()* <br /><br />`<ej-Splitter id=”splitter”></ej-Splitter>`<br/>$(“#splitter”).ejSplitter(“removeItem”, 0);<br /> | **Method:** *removePane()* <br /><br />`<ejs-splitter id=”splitter”></ejs-splitter>`<br/>$(“#splitter”).ejSplitter(“removePane”, 0);<br/> |
| Collapse Pane | **Method:** *collapse()* <br /><br />`<ej-Splitter id=”splitter”></ej-Splitter>`<br/>$(“#splitter”).ejSplitter(“collapse”, 0);<br /> | **Method:** *collapse()* <br /><br />`<ejs-splitter id=”splitter”></ejs-splitter>`<br/>$(“#splitter”).ejSplitter(“collapse”, 0);<br/> |
| Expand Pane | **Method:** *expand()* <br /><br />`<ej-Splitter id=”splitter”></ej-Splitter>`<br/>$(“#splitter”).ejSplitter(“expand”, 0);<br /> | **Method:** *expand()* <br /><br />`<ejs-splitter id=”splitter”></ejs-splitter>`<br/>$(“#splitter”).ejSplitter(“expand”, 0);<br/> |
| Event triggers when before panes get expanded/collapsed | **Event:** *beforeExpandCollapse* <br /><br />`<ej-Splitter id=”splitter”`<br />`before-expand-collapse=”onBeforeExpandCollapse”>`<br />`</ej-Splitter>`<br/>function onBeforeExpandCollapse (args) {}<br />| **Event:** *beforeExpand* <br /><br />`<ejs-splitter id=”splitter”`<br/>`before-expand=”onBeforeExpand”>`<br/>`</ejs-splitter>`<br/>function onBeforeExpand(args) {}<br /> Event: beforeCollapse <br />`<ejs-splitter id=”splitter”`<br/> `before-collapse=”onBeforeCollapse”>`<br/>`</ejs-splitter>`<br/>function onBeforeCollapse(args) {}<br/> |
| Event triggers when after panes get expanded/collapsed | **Event:** *expandCollapse* <br /><br />`<ej-Splitter id=”splitter”`<br/>`expand-collapse=”onExpandCollapse”>`<br/>`</ej-Splitter>`<br/>function onExpandCollapse (args) {}<br /> | **Event:** *expand* <br /><br />`<ejs-splitter id=”splitter” expand=”onExpand”>`<br/>`</ejs-splitter>`<br/>function onExpand(args) {}<br /> <br /> Event: collapse <br />`<ejs-splitter id=”splitter” collapse=”onCollapse”>`<br/>`</ejs-splitter>`<br/>function onCollapse(args) {}<br/> |
|  Event triggers when Resizing the pane | **Event:** *resize* <br /><br />`<ej-Splitter id=”splitter” resize=”onResize”>`<br/>`</ej-Splitter>`<br/>function onResize (args) {}<br /> | **Event:** *resizing* <br />`<ejs-splitter id=”splitter” resizing=”onResizing”>`<br/>`</ejs-splitter>`<br/>function onResizing(args) {}<br /> |
| Event triggers when pane is started to resize | Not Available | **Event:** *resizeStart* <br />`<ejs-splitter id=”splitter” resize-start=”onResizeStart”>`<br/>`</ejs-splitter>`<br/>function onResizeStart(args) {}<br /> |
| Event triggers when pane is stopped to resize | Not Available | **Event:** *resizeStop* <br /><br />`<ejs-splitter id=”splitter” resize-stop=”onResizeStop”>`<br/>`</ejs-splitter>`<br/>function onResizeStop(args) {}<br/> |
| Event triggers when click template icon | **Event:** *clickOnExpander* <br /><br />`<ej-Splitter id=”splitter”`<br/>`click-on-expander=”onClickOnExpander”>`<br/>`</ej-Splitter>`<br/>function onClickOnExpander (args) {}<br /> | Not Available |

## Animation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| EnableAnimation | **Property:** *enableAnimation* <br /><br />`<ej-Splitter id=”splitter”`<br/>`enable-animation=”true”>`<br/>
`</ej-Splitter>`<br/> | Not Available |
| AnimationSpeed | **Property:** *animationSpeed* <br /><br />`<ej-Splitter id=”splitter”`<br/>`animation-speed=”150”>`<br/>`</ej-Splitter>`<br/> | Not Available |