---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Dialog Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Dialog control from Essential JS 1 to Essential JS 2.

## Accessibility and localization

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|--------------|--------------------------------|-------------------------|
| Keyboard Navigation | **Property** : allowKeyboardNavigation<br/> <br/>`@Html.EJ().Dialog("dialog").AllowKeyboardNavigation(true)` | No separate Property for enable/disable keyboard navigation.  Its enabled by default. |
| Localization | **Property** : locale<br/> <br/>`@Html.EJ().Dialog("dialog").Locale("es-ES")` | **Property** : locale<br/> <br/>`@Html.EJS().Dialog("dialog").Locale("es-ES").Render()` |
| Right to left | **Property:** enableRTL<br/> <br/>`@Html.EJ().Dialog("dialog").EnableRtl(true)` | **Property:** enableRTL<br/> <br/>`@Html.EJS().Dialog("dialog").EnableRtl(true).Render()` |

## Header

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|--------------|---------------------------|-------------------------|
| Header Content | **Property** : title<br/> <br/>`@Html.EJ().Dialog("dialog").Title("EJ1 Dialog header")`<br/>   **Method** : setTitle<br/> $('#dialog').ejDialog('setTitle', 'EJ1 Dialog Header'); | **Property** : header<br/> <br/>`@Html.EJS().Dialog("dialog").Header("EJ2 Dialog").Render()` |
| close button | **Property** : actionButtons<br/> <br/> `@{ List<string> actionButtons = new List<string>(); actionButtons.Add("close"); }`<br/><br/>`@Html.EJ().Dialog("dialog").ActionButtons(actionButtons)`<br/> | **Property** : showCloseIcon<br/> <br/>`@Html.EJS().Dialog("dialog").ShowCloseIcon(true).Render()` |
| Event triggers when click on action buttons | **Event:** actionButtonClick<br/><br/> `@{List<string> actionButtons = new List<string>(); actionButtons.Add("close"); }`<br/><br/>`@Html.EJ().Dialog("dialog").ActionButtons(actionButtons).ClientSideEvents(event =>event.ActionButtonClick("playMedia"))`<br/><br/>`function playMedia(args) {}`<br/> | Not Applicable |
| Minimize | **Property** : actionButtons<br/><br/> `@{ List<string> actionButtons = new List<string>(); actionButtons.Add("minimize"); }`<br/><br/>`@Html.EJ().Dialog("dialog").ActionButtons(actionButtons)`<br/> | Not Applicable |
| Maximize | **Property** : actionButtons<br/> <br/>`@{ List<string> actionButtons = new List<string>(); actionButtons.Add("maximize"); }`<br/><br/>`@Html.EJ().Dialog("dialog").ActionButtons(actionButtons)`<br/> | Not Applicable |
| Collapse /Expand | **Property** : actionButtons <br/>  **Method** : collapse(), expand ()<br/> <br/>`@{ List<string> actionButtons = new List<string>(); actionButtons.Add("collapsible"); }`<br/><br/>`@Html.EJ().Dialog("dialog").ActionButtons(actionButtons)`<br/>$('#dialog').ejDialog('collapse'); <br/>$('#dialog').ejDialog('expand') | Not Applicable |
| Event triggers when expanding the collapsed dialog | **Event:** expand<br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Expand("expandAction"))`<br/><br/>`function expandAction(args) {}`<br/> | Not Applicable |
| Event triggers when collapsing the expanded dialog | **Event:** collapse<br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Collapse("collapseAction"))`<br/><br/>`function collapseAction(args) {}`<br/> | Not Applicable |
| Pin | **Property** : actionButtons<br/> <br/>`@{ List<string> actionButtons = new List<string>(); actionButtons.Add("pin"); }`<br/><br/>`@Html.EJ().Dialog("dialog").ActionButtons(actionButtons)`<br/> | Not Applicable |
| Header visibility | **Property:** showHeader<br/> <br/>`@Html.EJ().Dialog("dialog").ShowHeader(true)` | Not Applicable |
| Close on escape key press | **Property** : closeOnEscape<br/> <br/>`@Html.EJ().Dialog("dialog").CloseOnEscape(true)` | **Property** : closeOnEscape<br/> <br/>`@Html.EJS().Dialog("dialog").CloseOnEscape(true).Render()` |

## Footer

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|--------------|---------------------------|-------------------------|
| Footer Content | **Property** :footerTemplateId<br/> <br/>`@Html.EJ().Dialog("dialog").FooterTemplateId("sample")` | **Property:** footerTemplate<br/> <br/>`@Html.EJS().Dialog("dialog").FooterTemplate("<button>Submit</button>").Render()` |
| Footer action buttons | Not applicable | **Property** : buttons<br/> <br/>`@Html.EJS().Dialog("dialog").Buttons(ViewBag.DefaultButtons).Render()`<br/><br/>`public ActionResult DefaultFunctionalities() { List<DialogDialogButton> buttons = new List<DialogDialogButton>() { }; buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new DefaultButtonModel() { content = "Ok" } }); ViewBag.DefaultButtons = buttons; return View(); } public class DefaultButtonModel { public string content { get; set; }`<br/> |
| Footer visibility | **Property** : showFooter<br/> <br/>`@Html.EJ().Dialog("dialog").ShowFooter(true)` | Not Applicable |

## Content

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|-------------|-------------------------|------------------------|
| Dialog content | **Method** : setContent<br/> <br/>`@Html.EJ().Dialog("dialog")`<br/> $('#dialog').ejDialog('setContent', 'Dialog Content') | **Property** : content<br/> <br/>`@Html.EJS().Dialog("dialog").Content("Dialog content").Render()` |
| Loading content using AJAX request | **Property** : contentType, contentUrl<br/> <br/>`@Html.EJ().Dialog("dialog").contentType("ajax").ContentUrl('')` | Not Applicable |
| Event triggers after the dialog content loaded in DOM | **Event:** contentLoad<br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.ContentLoad("onLoad"))`<br/><br/>`function onLoad(args) {}`<br/> | Not Applicable |
| Event trigger when fails to load ajax content | **Event:** ajaxError<br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.AjaxError("onAjaxError"))`<br/><br/>`function onAjaxError(args) {}`<br/> | Not Applicable |
| Event trigger when load ajax content successfully | **Event:** ajaxSuccess<br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.AjaxSuccess("onAjaxSuccess"))`<br/><br/>`function onAjaxSuccess(args) {}`<br/> | Not Applicable |

## Animation

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|------------------------|
| Enabling Animation | **Property** : enableAnimation<br/> <br/>`@Html.EJ().Dialog("dialog").EnableAnimation(true)` | Not Applicable |
| Animation effects | **Property** : animation.show.effect<br/> <br/>`@Html.EJ().Dialog("dialog").Animation(animate => animate.Show(show => show.Effect("slide"))`<br/> | **Property** : animationSettings.effect<br/><br/> `@Html.EJS().Dialog("default_dialog").AnimationSettings(new DialogAnimationSettings() { Effect = DialogEffect.Zoom }).Render()`<br/> |
| Animation duration | **Property:** animation.show.duration<br/> <br/>`@Html.EJ().Dialog("dialog").Animation(animate => animate.Show(show => show.Duration(500).Effect("slide"))`<br/> | **Property** : animationSettings.duration<br/> <br/> `@Html.EJS().Dialog("default_dialog").AnimationSettings(new DialogAnimationSettings() { Effect = DialogEffect.Zoom, DialogEffect.Duration(500) }).Render()`<br/> |
| Animation delay | Not applicable | **Property:** animationSettings.delay<br/> <br/> `@Html.EJS().Dialog("default_dialog").AnimationSettings(new DialogAnimationSettings() { Effect = DialogEffect.Zoom, DialogEffect.Duration(500), DialogEffect.Delay(500) }).Render()`<br/> |

## Draggable and resizing

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Draggable dialog | **Property** : allowDraggable<br/> <br/>`@Html.EJ().Dialog("dialog").AllowDraggable(true)` | **Property** : allowDragging<br/> <br/>`@Html.EJS().Dialog("dialog").AllowDragging(true).Render()` |
| Event triggers when the user drags the dialog | **Event:** drag<br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Drag("onDrag"))`<br/><br/>`function onDrag(args) {}`<br/> | **Event:** drag<br/> <br/>`@Html.EJS().Dialog("dialog").Drag("onDrag").Render()`<br/><br/>`function onDrag(args) {}`<br/> |
| Event triggers when the start to drag the dialog | **Event:** dragStart <br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.DragStart("onDragStart"))`<br/><br/>`function onDragStart(args) {}`<br/> | **Event:** dragStart <br/><br/>`@Html.EJS().Dialog("dialog").DragStart("onDragStart").Render()`<br/><br/>`function onDragStart(args) {}`<br/> |
| Event triggers when the stops to drag the dialog | **Event:** dragStop<br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.DragStop("onDragStop"))`<br/><br/>`function onDragStop(args) {}`<br/> | **Event:** dragStop<br/><br/>`@Html.EJS().Dialog("dialog").DragStop("onDragStop").Render()`<br/><br/>`function onDragStop(args) {}` <br/> |
| Resizing dialog | **Property** : enableResize<br/> <br/>`@Html.EJ().Dialog("dialog").EnableResize(true)` | Not applicable |
| Event triggers when resizing the dialog | **Event:** resize <br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Resize("onReSize"))`<br/><br/>`function onReSize(args) {}`<br/> | Not Applicable |
| Event triggers when starts to resizing the dialog | **Event:** resizeStart<br/><br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.ResizeStart("onResizeStart"))`<br/><br/>`function onResizeStart(args) {}`<br/> | Not Applicable |
| Event triggers when the stops to resizing the dialog | **Event:** resizeStop<br/><br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.ResizeStop("onResizeStop"))`<br/><br/>`function onResizeStop(args) {}`<br/> | Not Applicable |

## Target

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Target element to append dialog in document | **Property** : target <br/> <br/>`@Html.EJ().Dialog("dialog").Target("#dialogTarget")` | **Property**: target<br/> <br/>`@Html.EJS().Dialog("dialog").Target("#dialogTarget").Render()` |
| Element for draggable area | **Property** : containment<br/> <br/>`@Html.EJ().Dialog("dialog").Containment("#dragArea")` | Not applicable |

## Position

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Customizing dialog position using X, Y coordinate values | **Property** : position<br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Position.X(300).Y(100))`<br/> | **Property** : position<br/><br/> `@Html.EJS().Dialog("dialog").Position(obj => obj.X("300").Y("100")).Render()`<br/> |
| positioning dialog using position values | Not Applicable | **Property**: position<br/> <br/> `@Html.EJS().Dialog("dialog").Position(obj => obj.X("center").Y("center")).Render()`<br/> |

## Visibility

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Render dialog in visible/hidden state | **Property:** showOnInit<br/> <br/>`@Html.EJ().Dialog("dialog").ShowOnInit(true)` | **Property:** visible<br/> <br/>`@Html.EJS().Dialog("dialog").visible(false).Render()` |

## Dialog mode

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Render modal dialog | **Property** : enableModal<br/> <br/>`@Html.EJ().Dialog("dialog").EnableModal(true)` | **Property** : isModal<br/> <br/> `@Html.EJS().Dialog("dialog").IsModal(true).Render()` |

## Tooltip

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Sets the tooltip for dialog buttons | **Property** : tooltip<br/><br/> `@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Tooltip("tooltip"))`<br/><br/>`function tooltip: object { close: 'Exit' }`<br/> | No Separate Property for tooltip. It renders based on locale text. |

## Control state

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Enable/Disable the control | **Property** : enabled <br/><br/> `@Html.EJ().Dialog("dialog").Enabled(false)` | Not Applicable |
| Enable/ Disable page scrolling | **Property:** backgroundScroll<br/> <br/>`@Html.EJ().Dialog("dialog").BackgroundScroll(false)` | No separate Property for disabling page scroll. By default, scrolling prevented for modal dialog |

## State maintenance

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Save the model values in local storage or cookies | **Property** : enablePersistence <br/> <br/>`@Html.EJ().Dialog("dialog").EnablePersistence(true)` | **Property** : enablePersistence <br/><br/>`@Html.EJS().Dialog("dialog").EnablePersistence(true).Render()` |

## Common

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
|------------|-------------------------|-------------------------|
| Adjusting Height | **Property** : height <br/><br/>`@Html.EJ().Dialog("dialog").Height("400")` | **Property** : height <br/><br/> `@Html.EJS().Dialog("dialog").Height("50%").Render()` |
| Adjusting width | **Property:** width <br/><br/>`@Html.EJ().Dialog("dialog").Width("400")` |**Property** : width <br/><br/> `@Html.EJS().Dialog("dialog").Width("50%").Render()` |
| Adding custom class | **Property:** cssClass <br/><br/>`@Html.EJ().Dialog("dialog").cssClass("custom-class")` | **Property**: cssClass <br/><br/> `@Html.EJS().Dialog("dialog").CssClass("custom-class").Render()` |
| Adding zIndex | **Property:** zIndex <br/><br/> `@Html.EJ().Dialog("dialog").ZIndex("2000")` | **Property:** zIndex <br/><br/> `@Html.EJS().Dialog("dialog").ZIndex("2000").Render()` |
| Maximum height | **Property:** maxHeight  <br/><br/> `@Html.EJ().Dialog("dialog").MaxHeight("600")` | Not Applicable |
| Maximum width | **Property:** maxWidth <br/><br/> `@Html.EJ().Dialog("dialog").MaxWidth("600")` | Not Applicable |
| Minimum height | **Property:** minHeight <br/><br/> `@Html.EJ().Dialog("dialog").MinHeight("300")` | Not Applicable |
| Minimum width | **Property:** minWidth <br/><br/> `@Html.EJ().Dialog("dialog").MinWidth("300")` | Not Applicable |
| Adding html attributes | **Property:** htmlAttributes <br/><br/> `@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.HtmlAttributes("htmlAttributes"))`<br/><br/>`function htmlAttributes: object { class: 'my-class' }` <br/> | Not Applicable |
| Custom icon in the header | **Property:** faviconCSS <br/><br/> `@Html.EJ().Dialog("dialog").FaviconCSS("custom-icon")` | Not Applicable |
| Rounded corner appearance | **Property:** showRoundedCorner <br/><br/> `@Html.EJ().Dialog("dialog").ShowRoundedCorner(true)` | Not Applicable |
| Make control flexible for mobile view | **Property:** isResponsive <br/><br/> `@Html.EJ().Dialog("dialog").IsResponsive(true)` | Not Applicable |
| Close the Dialog | **Method:** close() <br/><br/> `@Html.EJ().Dialog("dialog")` <br/>$('#dialog').ejDialog('close') | **Method** : hide() <br/> <br/>`@Html.EJS().Dialog("dialog").Render()`<br/><br/>`var dialogObj= document.getElementById("dialog").ej2Instances[0]; dialogObj.hide();` <br/> |
| Event triggers before the dialog closes | **Event:** beforeClose <br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.BeforeClose("onBeforeClose"))`<br/><br/>`function onBeforeClose(args) {}` <br/> | **Event:** beforeClose <br/> <br/>`@Html.EJS().Dialog("dialog").BeforeClose("onBeforeClose").Render()`<br/><br/>`function onBeforeClose(args) {}`<br/> |
| Event triggers when the dialog closes | **Event:** close <br/> <br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Close("onClose"))`<br/><br/>`function onClose(args) {}` <br/> | **Event:** close <br/><br/>`@Html.EJS().Dialog("dialog").Close("onClose").Render()`<br/><br/>`function onClose(args) {}` <br/> |
| Destroy the control | **Method:** destroy() <br/> <br/> `@Html.EJ().Dialog("dialog")` <br/> $('#dialog').ejDialog('destroy') | **Method:** destroy() <br/> <br/>`@Html.EJS().Dialog("dialog").Render()`<br/><br/>`var dialogObj= document.getElementById("dialog").ej2Instances[0]; dialogObj.destroy();` <br/> |
| Focus the dialog element | **Method:** focus() <br/><br/> `@Html.EJ().Dialog("dialog")` <br/> $('#dialog').ejDialog('focus') | Not Applicable |
| Check whether the dialog is open | **Method:** isOpen() <br/> <br/> `@Html.EJ().Dialog("dialog")` <br/>$('#dialog').ejDialog('isOpen') | Not Applicable |
| Maximize the dialog | **Method:** maximize() <br/> <br/> `@Html.EJ().Dialog("dialog")` <br/>$('#dialog').ejDialog('maximize') | Not Applicable |
| Minimize the dialog | **Method:** minimize() <br/><br/> `@Html.EJ().Dialog("dialog")`  <br/>$('#dialog').ejDialog('minimize') | Not Applicable |
| Open the dialog | **Method:** open() <br/> <br/> `@Html.EJ().Dialog("dialog")` <br/>$('#dialog').ejDialog('open') | **Method** : show()  <br/> <br/>`@Html.EJS().Dialog("dialog").Render()`<br/><br/>`var dialogObj= document.getElementById("dialog").ej2Instances[0]; dialogObj.show();`<br/> |
| Event trigger before the dialog opens | **Event:** beforeOpen <br/><br/> `@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.BeforeOpen("onBeforeOpen"))`<br/><br/>`function onBeforeOpen(args) {}` <br/> | **Event:** beforeOpen <br/><br/>`@Html.EJS().Dialog("dialog").BeforeOpen("onBeforeOpen").Render()`<br/><br/>`function onBeforeOpen(args) {}` <br/> |
| Event triggers when the opens the dialog | **Event:** open <br/> <br/> `@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Open("onOpen"))`<br/><br/>`function onOpen(args) {}` <br/> | Event: open  <br/><br/>`@Html.EJS().Dialog("dialog").Open("onOpen").Render()`<br/><br/>`function onOpen(args) {}` <br/> |
| Refresh the dialog | **Method:** refresh()<br/> <br/>`@Html.EJ().Dialog("dialog")` <br/>$('#dialog').ejDialog('refresh') | **Method** : refreshPosition()  <br/> <br/>`@Html.EJS().Dialog("dialog").Render()`<br/><br/>`var dialogObj= document.getElementById("dialog").ej2Instances[0]; dialogObj.refreshPosition();` <br/> |
| Pin/ unpin the dialog | **Method:** pin <br/> <br/>`@Html.EJ().Dialog("dialog")` <br/>$('#dialog').ejDialog('pin');  <br/>$('#dialog').ejDialog('unpin'); | **Not Applicable** |
| Event triggers after the dialog created successfully | **Event:** create <br/><br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Create("onCreate"))`<br/><br/>`function onCreate(args) {}` <br/> | **Event** : created <br/> <br/>`@Html.EJS().Dialog("dialog").Created("onCreated").Render()`<br/><br/>`function onCreated(args) {}` <br/> |
| Event triggers when the control destroyed successfully | **Event:** destroy <br/><br/>`@Html.EJ().Dialog("dialog").ClientSideEvents(evt => evt.Destroy("onDestroy"))`<br/><br/>`function onDestroy(args) {}` <br/> | Not Applicable |
| Event triggers on clicking on modal dialog overlay | **Not Applicable** | **Event** : overlayClick <br/><br/>`@Html.EJS().Dialog("dialog").OverlayClick("onOverlayClick").Render()`<br/><br/>`function onOverlayClick(args) {}` <br/> |