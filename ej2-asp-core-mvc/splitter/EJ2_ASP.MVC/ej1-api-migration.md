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
| Adding custom class | **Property:** *cssClass* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.CssClass(“customClass”)`<br/>`.Render();}` <br /> | **Property:** *cssClass* <br /><br /> `@Html.EJS().Splitter(“splitter”)`<br/>`.CssClass(“customClass”)`<br/>`.Render();`<br/> |
| Adjusting Height | **Property:** *height* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.Height(“100%”).Render();}` <br /> | **Property:** *height* <br /> <br />`@Html.EJS().Splitter(“splitter”)`<br/>`.Height(“100%”).Render();` <br/> |
| Adjusting Width | **Property:** *width* <br /><br /> `@{Html.EJ().Splitter(“splitter”)`<br/>`.Width(“600”).Render();}`<br /> | **Property:** *width* <br /><br /> `@Html.EJS().Splitter(“splitter”)`<br/>`.Width(“100%”).Render();`<br/> |
| Orientation | **Property:** *orientation* <br /><br /> `@{Html.EJ().Splitter(“splitter”)`<br/>`.Orientation(Orientation.Vertical)`<br/>`.Render();}`<br/> | **Property:** *orientation* <br /> <br /> `@Html.EJS().Splitter(“splitter”)`<br/>`.Orientation`<br/>`(Syncfusion.EJ2.Layouts`<br/>`.Orientation.Vertical)`<br/>`.Render();`<br/> |
| Separator Size | Not Available | **Property:** *separatorSize* <br /> <br /> `@Html.EJS().Splitter(“splitter”)`<br/>`.SeparatorSize(4).Render();`<br/> |
| Adding HTML attributes | **Property:** `*htmlAttributes*` <br /><br /> `@{`<br />`IDictionary<string, object>`<br /> `htmlAttribute = new Dictionary`<br />`<string, object>();` <br />`htmlAttribute.Add(“class”,`<br/>`“my-class”)`<br />`}`<br /><br /> `@{Html.EJ().Splitter(“splitter”)`<br/>`.HtmlAttributes(htmlAttribute)`<br/>`.Render();}`<br /> | Not Available |
| Customize expand/collapse icons | **Property:** <br /> *expanderTemplate* <br /><br /> `@{Html.EJ().Splitter(“splitter”)`<br/>`.ExpanderTemplate(`<br/>`<img class=”eimg”`<br/>`src=”expander.png”`<br/>`alt=”employee”/>).Render();}`<br/> | Not Available |
| Make control flexible for mobile view | **Property:** *isResponsive* <br /><br /> `@{Html.EJ().Splitter(“splitter”)`<br/>`.IsResponsive(true).Render();}`<br/> | By default, Splitter works with mobile mode.|
| Refresh the Splitter | **Method:** *refresh()* <br /><br /> `@{Html.EJ().Splitter(“splitter”)`<br/>`.Render();}`<br/>`$(“#splitter”).ejSplitter(“refresh”)`<br/> | **Method:** *refresh()* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.Render();`<br/>`$(“#splitter”).ejSplitter(“refresh”);`<br />|
| Destroy the Control | **Method:** *destroy()* <br /><br />`@{Html.EJ()`<br/>`.Splitter(“splitter”)`<br/>`.Render();}`<br/>`$(“#splitter”).ejSplitter(“destroy”)`<br />| **Method:** *destroy()* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.Render();`<br/>`$(“#splitter”).ejSplitter(“destroy”);`<br /> |
| Event triggers after the Splitter created successfully | **Event:** *create* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.Create(“onCreate”))`<br/>`.Render();}`<br/>`function onCreate(args) {}`<br/>| **Event:** *created* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.Create(“onCreate”)).Render();`<br/>`function onCreate(args) { }`<br/>|
| Event triggers when Splitter has been destroyed | **Event:**  *destroy* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.Destroy(“onDestroy”))`<br/>`.Render();}`<br/>`function onDestroy(args) {}`<br /> `});` | Not Available |

## Accessibility and Localization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Keyboard Navigation | **Property:** *allowKeyboardNavigation* <br /><br /> `@{Html.EJ().Splitter(“splitter”)`<br/>`.AllowKeyboardNavigation(true)`<br/>`.Render();}` <br/>| No separate property for enable/disable keyboard navigation.  Its enabled by default. |
| Right to Left | **Property:** *enableRTL* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.EnableRTL(false).Render();}`<br/> | **Property:** *enableRtl*<br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.EnableRtl(true).Render();`<br/> |

## Control State

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Enable/Disable the control | Not Available | **Property:** *enabled* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.Enabled(true).Render();`<br/> |

## State Maintenance

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Save the model value in local storage or cookies | Not Available | **Property:** *enablePersistence* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.EnablePersistence(true).Render();`<br/> |

## Pane Properties

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Default | **Property:** *properties* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.PaneProperties().Render();}`<br /> | **Property:** *paneSettings* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.PaneSettings().Render();`<br/> |
| Pane Content | Not Available | **Property:** *content* <br /><br /> `@Html.EJS().Splitter(“splitter”)`<br/>`.PaneSettings(item=>{item.Content(”<div>First Pane Content</div>”)})`<br/>`.Render();`<br/> |
| Change the size of the pane | **Property:** *paneSize* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.PaneProperties(p=>`<br/>`{p.Add().PaneSize(“30px”)})`<br/>`.Render();}`<br /> | **Property:** *size* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.PaneSettings(item=>`<br/>`{item.Size(”25%”)})`<br/>`.Render();`<br/> |
| Minimum pane size | **Property:** *minSize* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.PaneProperties(p=>{p.Add()`<br/>`.MinSize(30)})`<br/>`.Render();}`<br/> | **Property:** *min* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.PaneSettings(item=>`<br/>`{item.Min(”60px”)})`<br/>`.Render();`<br/> |
| Maximum pane size | **Property:** *maxSize* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.PaneProperties(p=>`<br/>`{p.Add().MaxSize(30)})`<br/>`.Render();}`<br />| **Property:** *max* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.PaneSettings(item=>`<br/>`{item.Max(”60px”)})`<br/>`.Render();`<br/> |
| Enable/Disable the Pane Resizable behavior | **Property:** *resizable* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.PaneProperties(p=>`<br/>`{p.Add().Resizable(false)})`<br/>`.Render();}`<br /> | **Property:** *resizable* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.PaneSettings(item=>`<br/>`{item.Resizable(false)})`<br/>`.Render();`<br/> |
| Collapsible |**Property:** *collapsible* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.PaneProperties(p`<br/>`=>{p.Add().Collapsible(true)})`<br/>.Render();}<br /> | **Property:** *collapsible* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.PaneSettings(item=>`<br/>`{item.Collapsible(true)})`<br/>`.Render();`<br/> |
| Expandable | **Property:** *expandable* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.PaneProperties(p=>`<br/>`{p.Add().Expandable(true)})`<br/>`.Render();}`<br /> | Not Available |
| Collapsed | Not Available | **Property:** *collapsed* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.PaneSettings(item=>`<br/>`{item.Collapsed(true)})`<br/>`.Render();`<br/> |
| Add Pane | **Method:** *addItem()* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.Render();}`<br/>`$(“#splitter”).ejSplitter`<br/>`(“addItem”, “New Pane 0”,`<br/>`{paneSize:20, minSize:20,`<br/>`maxSize: 100}, 0);`<br/>|**Method:** *addPane()* <br /> <br />`@Html.EJS().Splitter(“splitter”)`<br/>`.Render();`<br/>`$(“#splitter”).ejSplitter`<br/>`(“addPane”, “New Pane 0”,`<br/>`{ size: “25%”,`<br/>`content: “Pane”}, 0);`<br/>|
| Remove Pane | **Method:** *removeItem()* <br /><br />`@{Html.EJ()`<br/>`.Splitter(“splitter”)`<br/>`.Render();}`<br/>`$(“#splitter”).ejSplitter`<br/>`(“removeItem”, 0);`<br /> | **Method:** *removePane()* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.Render();`<br/>`$(“#splitter”)`<br/>`.ejSplitter(“removePane”, 0);`<br/> |
| Collapse Pane | **Method:** *collapse()* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.Render();}`<br/>`$(“#splitter”)`<br/>`.ejSplitter(“collapse”, 0);`<br /> | **Method:** *collapse()* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.Render();`<br/>`$(“#splitter”)`<br/>`.ejSplitter(“collapse”, 0);`<br/> |
| Expand Pane | **Method:** *expand()* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.Render();}`<br/>`$(“#splitter”)`<br/>`.ejSplitter(“expand”, 0);`<br /> | **Method:** *expand()* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.Render();`<br/>`$(“#splitter”).ejSplitter`<br/>`(“expand”, 0);`<br/> |
| Event triggers when before panes get expanded/collapsed | **Event:** *beforeExpandCollapse* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.BeforeExpandCollapse`<br/>`(“onBeforeExpandCollapse”))`<br/>`.Render();}`<br/>`function`<br/>`onBeforeExpandCollapse (args)`<br/>`{}`<br />| **Event:** *beforeExpand* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.BeforeExpand(“onBeforeExpand”))`<br/>`.Render();`<br/>`function onBeforeExpand(args) {}`<br />Event: beforeCollapse <br />`@Html.EJS().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.BeforeCollapse(“onBeforeCollapse”))`<br/>`.Render();`<br/>function onBeforeCollapse(args) {}<br/> |
| Event triggers when after panes get expanded/collapsed | **Event:** *expandCollapse* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.ExpandCollapse`<br/>`(“onExpandCollapse”))`<br/>`.Render();}`<br/>function onExpandCollapse (args) {}<br /> | **Event:** *expand* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.Expand(“onExpand”))`<br/>`.Render();`<br/>function onExpand(args) {}<br /> Event: collapse <br /> `@Html.EJS().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.Collapse(“onCollapse”))`<br/>`.Render();`<br/>function onCollapse(args) {}<br/> |
|  Event triggers when Resizing the pane | **Event:** *resize* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.Resize(“onResize”))`<br/>`.Render();}`<br />function onResize (args) {}<br/> | **Event:** *resizing* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.Resizing(“onResizing”))`<br/>`.Render();`<br/>function onResizing(args) {}<br/> |
| Event triggers when pane is started to resize | Not Available | **Event:** *resizeStart* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.ResizeStart(“onResizeStart”))`<br/>`.Render();`<br/>function onResizeStart(args) {}<br/> |
| Event triggers when pane is stopped to resize | Not Available | **Event:** *resizeStop* <br /><br />`@Html.EJS().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>`<br/>`e.ResizeStop(“onResizeStop”))`<br/>`.Render();`<br/>function onResizeStop(args) {}<br/> |
| Event triggers when click template icon | **Event:** *clickOnExpander* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.ClientSideEvents(e=>e`<br/>`.ClickOnExpander`<br/>`(“onClickOnExpander”))`<br/>`.Render();}`<br/>function clickOnExpander (args) {}<br /> | Not Available |

## Animation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| EnableAnimation | **Property:** *enableAnimation* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.EnableAnimation(true)`<br/>`.Render();}`<br/> | Not Available |
| AnimationSpeed | **Property:** *animationSpeed* <br /><br />`@{Html.EJ().Splitter(“splitter”)`<br/>`.AnimationSpeed(150)`<br/>`.Render();}`<br/> | Not Available |