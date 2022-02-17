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
| ------------ | ------------------------- | ------------------------- |
| Keyboard Navigation | **Property** : allowKeyboardNavigation<br/> <br/>`<ej-dialog id="dialog" allow-keyboard-navigation="true"></ej-dialog>`  | No separate Property for enable/disable keyboard navigation.  Its enabled by default. |
| Localization | **Property** : locale<br/> <br/>`<ej-dialog id="dialog" locale="es-ES"></ej-dialog>` | **Property** : locale<br/> <br/>`<ejs-dialog id="dialog" locale="es-ES"></ejs-dialog>`  |
| Right to left | **Property:** enableRTL<br/> <br/>`<ej-dialog id="dialog" enable-rtl="true"></ej-dialog>` | **Property:** enableRTL<br/> <br/>`<ejs-dialog id="dialog" enableRtl="true"></ejs-dialog>`  |

## Header

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Header Content | **Property** : title<br/> <br/>`<ej-dialog id="dialog" title="EJ1 Dialog header"></ej-dialog>`<br/>   **Method** : setTitle<br/> $('#dialog').ejDialog('setTitle', 'EJ1 Dialog Header');   | **Property** : header<br/> <br/>`<ejs-dialog id="dialog" header="EJ2 Dialog"></ejs-dialog>`  |
| close button | **Property** : actionButtons<br/> <br/> `@{List<string> icon = new List<string>() { "close" }; }`<br/><br/>`<ej-dialog id="dialog" action-buttons="icon">`<br/> | **Property** : showCloseIcon<br/> <br/>`<ejs-dialog id="dialog" showCloseIcon="true"></ejs-dialog>` |
| Event triggers when click on action buttons | **Event:** actionButtonClick<br/><br/> `<ej-dialog id="dialog" action-button-click="playMedia"></ej-dialog>`<br/><br/>`function playMedia(args) {}`<br/> | Not Applicable |
| Minimize | **Property** : actionButtons<br/><br/> `@{List<string> icon = new List<string>() { "minimize" }; }`<br/><br/>`<ej-dialog id="dialog" action-buttons="icon">`<br/> | Not Applicable |
| Maximize | **Property** : actionButtons<br/> <br/>`@{List<string> icon = new List<string>() { "maximize" }; }`<br/><br/>`<ej-dialog id="dialog" action-buttons="icon">`<br/>  | Not Applicable |
| Collapse /Expand | **Property** : actionButtons <br/>  **Method** : collapse(), expand ()<br/> <br/>`@{List<string> icon = new List<string>() { "collapsible" }; }`<br/><br/>`<ej-dialog id="dialog" action-buttons="icon">`<br/>$('#dialog').ejDialog('collapse'); <br/>$('#dialog').ejDialog('expand')  | Not Applicable |
| Event triggers when expanding the collapsed dialog | **Event:** expand<br/> <br/>`<ej-dialog id="dialog" expand="expandAction"></ej-dialog>`<br/><br/>`function expandAction(args) {}`<br/>| Not Applicable |
| Event triggers when collapsing the expanded dialog | **Event:** collapse<br/> <br/>`<ej-dialog id="dialog" collapse="collapseAction"></ej-dialog>`<br/><br/>`function collapseAction(args) {}`<br/> | Not Applicable |
| Pin | **Property** : actionButtons<br/> <br/>`@{List<string> icon = new List<string>() { "pin" }; }`<br/><br/>`<ej-dialog id="dialog" action-buttons="icon">`<br/> | Not Applicable |
| Header visibility | **Property:** showHeader<br/> <br/>`<ej-dialog id="dialog" show-header="true"></ej-dialog>` | Not Applicable |
| Close on escape key press | **Property** : closeOnEscape<br/> <br/>`<ej-dialog id="dialog" closeOnEscape="true"></ej-dialog>`| **Property** : closeOnEscape<br/> <br/>`<ejs-dialog id="dialog" closeOnEscape="true"></ejs-dialog>` |

## Footer

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Footer Content | **Property** :footerTemplateId<br/> <br/>`<ej-dialog id="dialog" footer-templateId="sample"></ej-dialog>`| **Property:** footerTemplate<br/> <br/>`<ejs-dialog id="dialog" footerTemplate="<button>Submit</button>"></ejs-dialog>` |
| Footer action buttons | Not applicable | **Property** : buttons<br/> <br/>`<ejs-dialog id="dialog"><e-dialog-buttons><e-dialog-dialogbutton buttonModel="ViewBag.defaultbutton"></e-dialog-dialogbutton></e-dialog-buttons><ejs-dialog>`<br/><br/>`public IActionResult DefaultFunctionalities() { {content = "Ok"} return View(); }`<br/> |
| Footer visibility | **Property** : showFooter<br/> <br/>`<ej-dialog id="dialog" show-footer="true"></ej-dialog>` | Not Applicable |

## Content

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Dialog content | **Method** : setContent<br/> <br/>`<ej-dialog id="dialog"></ej-dialog>`<br/> $('#dialog').ejDialog('setContent', 'Dialog Content') | **Property** : content<br/> <br/>`<ejs-dialog id="dialog" content="Dialog content"></ejs-dialog>` |
| Loading content using AJAX request   | **Property** : contentType, contentUrl<br/> <br/>`<ej-dialog id="dialog" content-type="ajax" content-url=""></ej-dialog>` | Not Applicable |
| Event triggers after the dialog content loaded in DOM | **Event:** contentLoad<br/> <br/>`<ej-dialog id="dialog" content-load="onLoad"></ej-dialog>`<br/><br/>`function onLoad(args) {}`<br/> | Not Applicable |
| Event trigger when fails to load ajax content | **Event:** ajaxError<br/> <br/>`<ej-dialog id="dialog" ajax-error="onAjaxError"></ej-dialog>`<br/><br/>`function onAjaxError(args) {}`<br/> | Not Applicable |
| Event trigger when load ajax content successfully | **Event:** ajaxSuccess<br/> <br/>`<ej-dialog id="dialog" ajax-success="onAjaxSuccess"></ej-dialog>`<br/><br/>`function onAjaxSuccess(args) {}`<br/> | Not Applicable |

## Animation

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Enabling Animation | **Property** : enableAnimation<br/> <br/>`<ej-dialog id="dialog" enable-animation="true" ></ej-dialog>`| Not Applicable |
| Animation effects | **Property** : animation.show.effect<br/> <br/>`<ej-dialog id="dialog"></ej-dialog>`<br/><br/>`<e-animation><e-show effect="Slide" /></e-animation>`<br/> | **Property** : animationSettings.effect<br/><br/> `@{ var defaultanimation = new Syncfusion.EJ2.Popups.DialogAnimationSettings { Effect = Syncfusion.EJ2.Popups.DialogEffect.Zoom }; }`<br/><br/>`<ejs-dialog id="dialog" animationSettings="defaultanimation"><ejs-dialog>`<br/> |
| Animation duration | **Property:** animation.show.duration<br/> <br/>`<ej-dialog id="dialog"></ej-dialog>`<br/><br/>`<e-animation><e-show duration="500" effect="Slide" /></e-animation>`<br/> | **Property** : animationSettings.duration<br/> <br/> `@{ var defaultanimation = new Syncfusion.EJ2.Popups.DialogAnimationSettings { Effect = Syncfusion.EJ2.Popups.DialogEffect.Zoom, Duration = Syncfusion.EJ2.Popups.DialogEffect.Duration(500)}; }`<br/><br/>`<ejs-dialog id="dialog" animationSettings="defaultanimation"><ejs-dialog>`<br/> |
| Animation delay | Not applicable | **Property:** animationSettings.delay<br/> <br/> `@{ var defaultanimation = new Syncfusion.EJ2.Popups.DialogAnimationSettings { Effect = Syncfusion.EJ2.Popups.DialogEffect.Zoom, Duration = Syncfusion.EJ2.Popups.DialogEffect.Duration(500), Delay = Syncfusion.EJ2.Popups.DialogEffect.Duration(500)}; }`<br/><br/>`<ejs-dialog id="dialog" animationSettings="defaultanimation"><ejs-dialog>`<br/> |

## Draggable and resizing

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Draggable dialog | **Property** : allowDraggable<br/> <br/>`<ej-dialog id="dialog" allow-draggable="true" ></ej-dialog>` | **Property** : allowDragging<br/> <br/>`<ejs-dialog id="dialog" allowDragging="true"></ejs-dialog>` |
| Event triggers when the user drags the dialog | **Event:** drag<br/> <br/>`<ej-dialog id="dialog" drag="onDrag"></ej-dialog>`<br/><br/>`function onDrag(args) {}`<br/> | **Event:** drag<br/> <br/>`<ejs-dialog id="dialog" drag="onDrag"></ejs-dialog>`<br/><br/>`function onDrag(args) {}`<br/> |
| Event triggers when the start to drag the dialog | **Event:** dragStart <br/> <br/>`<ej-dialog id="dialog" drag-start="onDragStart"></ej-dialog>`<br/><br/>`function onDragStart(args) {}`<br/> | **Event:** dragStart <br/><br/>`<ejs-dialog id="dialog" dragStart="onDragStart"></ejs-dialog>`<br/><br/>`function onDragStart(args) {}`<br/> |
| Event triggers when the stops to drag the dialog | **Event:** dragStop<br/> <br/>`<ej-dialog id="dialog" drag-stop="onDragStop"></ej-dialog>`<br/><br/>`function onDragStop(args) {}`<br/> | **Event:** dragStop<br/><br/>`<ejs-dialog id="dialog" dragStop="onDragStop"></ejs-dialog>`<br/><br/>`function onDragStop(args) {}` <br/> |
| Resizing dialog | **Property** : enableResize<br/> <br/>`<ej-dialog id="dialog" enable-resize="true" ></ej-dialog>` |  Not applicable   |
| Event triggers when resizing the dialog | **Event:** resize <br/> <br/>`<ej-dialog id="dialog" resize="onReSize"></ej-dialog>`<br/><br/>`function onReSize(args) {}`<br/> |  Not Applicable |
| Event triggers when starts to resizing the dialog | **Event:** resizeStart<br/><br/>`<ej-dialog id="dialog" resize-start="onResizeStart"></ej-dialog>`<br/><br/>`function onResizeStart(args) {}`<br/> | Not Applicable |
| Event triggers when the stops to resizing the dialog | **Event:** resizeStop<br/><br/>`<ej-dialog id="dialog" resize-stop="onResizeStop"></ej-dialog>`<br/><br/>`function onResizeStop(args) {}`<br/> | Not Applicable |

## Target

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Target element to append dialog in document | **Property** : target <br/> <br/>`<ej-dialog id="dialog" target="#dialogTarget" ></ej-dialog>` | **Property**: target<br/> <br/>`<ejs-dialog id="dialog" target="#dialogTarget"></ejs-dialog>` |
| Element for draggable area | **Property** : containment<br/> <br/>`<ej-dialog id="dialog" containment="#dragArea" ></ej-dialog>` | Not applicable |

## Position

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Customizing dialog position using X, Y coordinate values | **Property** : position<br/> <br/>`<ej-dialog id="dialog"><e-dialog-position x-value="300" y-value="100" /></ej-dialog>`<br/>| **Property** : position<br/><br/> `<ejs-dialog id="dialog">`<br/>`<e-dialog-position X="300" Y="100"></e-dialog-position></ejs-dialog>`<br/> |
| positioning dialog using position values | Not Applicable | **Property**: position<br/> <br/> `<ejs-dialog id="dialog">`<br/>`<e-dialog-position X="center" Y="center"></e-dialog-position></ejs-dialog>`<br/> |

## Visibility

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Render dialog in visible/hidden state | **Property:** showOnInit<br/> <br/>`<ej-dialog id="dialog" show-onInit="true" ></ej-dialog>` | **Property:** visible<br/> <br/>`<ejs-dialog id="dialog" visible="false"></ejs-dialog>` |

## Dialog mode

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Render modal dialog |**Property** : enableModal<br/> <br/>`<ej-dialog id="dialog" enable-modal="true" ></ej-dialog>` | **Property** : isModal<br/> <br/> `<ejs-dialog id="dialog" isModal="true"></ejs-dialog>` |

## Tooltip

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Sets the tooltip for dialog buttons | **Property** : tooltip<br/><br/> `<ej-dialog id="dialog" tooltip="tooltip"></ej-dialog>`<br/><br/>`function tooltip(): object { close: 'Exit' }`<br/> | No Separate Property for tooltip. It renders based on locale text. |

## Control state

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Enable/Disable the control | **Property** : enabled <br/><br/> `<ej-dialog id="dialog" enabled="false" ></ej-dialog>` | Not Applicable |
| Enable/ Disable page scrolling | **Property:** backgroundScroll<br/> <br/>`<ej-dialog id="dialog" background-scroll="false" ></ej-dialog>` | No separate Property for disabling page scroll. By default, scrolling prevented for modal dialog  |

## State maintenance

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Save the model values in local storage or cookies |**Property** : enablePersistence <br/> <br/>`<ej-dialog id="dialog" enable-persistence="true" ></ej-dialog>` |**Property** : enablePersistence <br/><br/>`<ejs-dialog id="dialog" enablePersistence="true"></ejs-dialog>` |

## Common

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Adjusting Height | **Property** : height <br/><br/>`<ej-dialog id="dialog" height="400" ></ej-dialog>` | **Property** : height <br/><br/> `<ejs-dialog id="dialog" height="50%"></ejs-dialog>` |
| Adjusting width | **Property:** width <br/><br/>`<ej-dialog id="dialog" width="400" ></ej-dialog>` |**Property** : width <br/><br/> `<ejs-dialog id="dialog" width="50%"></ejs-dialog>` |
| Adding custom class | **Property:** cssClass <br/><br/>`<ej-dialog id="dialog" css-class="custom-class" ></ej-dialog>` | **Property**: cssClass <br/><br/> `<ejs-dialog id="dialog" cssClass="custom-class"></ejs-dialog>` |
| Adding zIndex | **Property:** zIndex <br/><br/> `<ej-dialog id="dialog" zindex="2000" ></ej-dialog>`| **Property:** zIndex <br/><br/> `<ejs-dialog id="dialog" zindex="2000"></ejs-dialog>` |
| Maximum height | **Property:** maxHeight  <br/><br/> `<ej-dialog id="dialog" max-height="600" ></ej-dialog>` | Not Applicable |
| Maximum width | **Property:** maxWidth <br/><br/> `<ej-dialog id="dialog" max-width="600" ></ej-dialog>` | Not Applicable |
| Minimum height | **Property:** minHeight <br/><br/> `<ej-dialog id="dialog" min-height="600" ></ej-dialog>` | Not Applicable |
| Minimum width | **Property:** minWidth <br/><br/> `<ej-dialog id="dialog" min-width="300" ></ej-dialog>` | Not Applicable |
| Adding html attributes | **Property:** htmlAttributes <br/><br/> `<ej-dialog id="dialog" html-attributes="htmlAttributes"></ej-dialog>`<br/><br/>`function htmlAttributes(): object { class: 'my-class' }` <br/> | Not Applicable |
| Custom icon in the header | **Property:** faviconCSS <br/><br/> `<ej-dialog id="dialog" faviconCSS="custom-icon" ></ej-dialog>` | Not Applicable |
| Rounded corner appearance | **Property:** showRoundedCorner <br/><br/> `<ej-dialog id="dialog" show-rounded-corner="true" ></ej-dialog>` | Not Applicable |
| Make control flexible for mobile view | **Property:** isResponsive <br/><br/> `<ej-dialog id="dialog" is-responsive="true" ></ej-dialog>` | Not Applicable |
| Close the Dialog | **Method:** close() <br/><br/> `<ej-dialog id="dialog"></ej-dialog>` <br/>$('#dialog').ejDialog('close') | **Method** : hide() <br/> <br/>`<ejs-dialog id="dialog"></ejs-dialog>`<br/><br/>`var dialogObj= document.getElementById("dialog").ej2Instances[0]; dialogObj.hide();` <br/> |
| Event triggers before the dialog closes | **Event:** beforeClose <br/> <br/>`<ej-dialog id="dialog" before-close="onBeforeClose"></ej-dialog>`<br/><br/>`function onBeforeClose(args) {}` <br/> | **Event:** beforeClose <br/> <br/>`<ejs-dialog id="dialog" beforeClose="onBeforeClose"></ejs-dialog>`<br/><br/>`function onBeforeClose(args) {}`  <br/>|
| Event triggers when the dialog closes | **Event:** close <br/> <br/>`<ej-dialog id="dialog" close="onClose"></ej-dialog>`<br/><br/>`function onClose(args) {}` <br/> | **Event:** close <br/><br/>`<ejs-dialog id="dialog" close="onClose"></ejs-dialog>`<br/><br/>`function onClose(args) {}` <br/> |
| Destroy the control | **Method:** destroy() <br/> <br/> `<ej-dialog id="dialog"></ej-dialog>` <br/> $('#dialog').ejDialog('destroy') | **Method:** destroy() <br/> <br/>`<ejs-dialog id="dialog"></ejs-dialog>`<br/><br/>`var dialogObj= document.getElementById("dialog").ej2Instances[0]; dialogObj.destroy();` <br/> |
| Focus the dialog element | **Method:** focus() <br/><br/> `<ej-dialog id="dialog"></ej-dialog>` <br/> $('#dialog').ejDialog('focus') | Not Applicable |
| Check whether the dialog is open | **Method:** isOpen() <br/> <br/> `<ej-dialog id="dialog"></ej-dialog>` <br/>$('#dialog').ejDialog('isOpen') | Not Applicable |
| Maximize the dialog | **Method:** maximize() <br/> <br/> `<ej-dialog id="dialog"></ej-dialog>` <br/>$('#dialog').ejDialog('maximize') | Not Applicable |
| Minimize the dialog | **Method:** minimize() <br/><br/> `<ej-dialog id="dialog"></ej-dialog>`  <br/>$('#dialog').ejDialog('minimize') | Not Applicable |
| Open the dialog | **Method:** open() <br/> <br/> `<ej-dialog id="dialog"></ej-dialog>` <br/>$('#dialog').ejDialog('open') | **Method** : show()  <br/> <br/>`<ejs-dialog id="dialog"></ejs-dialog>`<br/><br/>`var dialogObj= document.getElementById("dialog").ej2Instances[0]; dialogObj.show();` <br/> |
| Event trigger before the dialog opens | **Event:** beforeOpen <br/><br/> `<ej-dialog id="dialog" before-open="onBeforeOpen"></ej-dialog>`<br/><br/>`function onBeforeOpen(args) {}` <br/> | **Event:** beforeOpen <br/><br/>`<ejs-dialog id="dialog" beforeOpen="onBeforeOpen"></ejs-dialog>`<br/><br/>`function onBeforeOpen(args) {}` <br/> |
| Event triggers when the opens the dialog | **Event:** open <br/> <br/> `<ej-dialog id="dialog" open="onOpen"></ej-dialog>`<br/><br/>`function onOpen(args) {}` <br/> | Event: open  <br/><br/>`<ejs-dialog id="dialog" open="onOpen"></ejs-dialog>`<br/><br/>`function onOpen(args) {}` <br/> |
| Refresh the dialog | **Method:** refresh()  <br/> <br/>`<ej-dialog id="dialog"></ej-dialog>` <br/>$('#dialog').ejDialog('refresh') | **Method** : refreshPosition()  <br/> <br/>`<ejs-dialog id="dialog"></ejs-dialog>`<br/><br/>`var dialogObj= document.getElementById("dialog").ej2Instances[0]; dialogObj.refreshPosition();` <br/> |
| Pin/ unpin the dialog | **Method:** pin <br/> <br/>`<ej-dialog id="dialog"></ej-dialog>` <br/>$('#dialog').ejDialog('pin');  <br/>$('#dialog').ejDialog('unpin');  | **Not Applicable** |
| Event triggers after the dialog created successfully | **Event:** create <br/><br/>`<ej-dialog id="dialog" create="onCreate"></ej-dialog>`<br/><br/>`function onCreate(args) {}` <br/> | **Event** : created <br/> <br/>`<ejs-dialog id="dialog" created="onCreated"></ejs-dialog>`<br/><br/>`function onCreated(args) {}` <br/> |
| Event triggers when the control destroyed successfully | **Event:** destroy <br/><br/>`<ej-dialog id="dialog" destroy="onDestroy"></ej-dialog>`<br/><br/>`function onDestroy(args) {}` <br/> | Not Applicable |
| Event triggers on clicking on modal dialog overlay | **Not Applicable** | **Event** : overlayClick <br/><br/>`<ejs-dialog id="dialog" overlayClick="onOverlayClick"></ejs-dialog>`<br/><br/>`function onOverlayClick(args) {}`  <br/> |