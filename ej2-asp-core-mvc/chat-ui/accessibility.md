---
layout: post
title: Accessibility in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Accessibility in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ##Platform_Name## Chat UI control

The Chat UI control followed the accessibility guidelines and standards, including [ADA](https://www.ada.gov/), [Section 508](https://www.section508.gov/), [WCAG 2.2](https://www.w3.org/TR/WCAG22/) standards, and [WCAG roles](https://www.w3.org/TR/wai-aria/#roles) that are commonly used to evaluate accessibility.

The accessibility compliance for the Chat UI control is outlined below.

| Accessibility Criteria | Compatibility |
| -- | -- |
| [WCAG 2.2 Support](../common/accessibility#accessibility-standards) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Section 508 Support](../common/accessibility#accessibility-standards) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Screen Reader Support](../common/accessibility#screen-reader-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Right-To-Left Support](../common/accessibility#right-to-left-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Color Contrast](../common/accessibility#color-contrast) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Mobile Device Support](../common/accessibility#mobile-device-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Keyboard Navigation Support](../common/accessibility#keyboard-navigation-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Accessibility Checker Validation](../common/accessibility#ensuring-accessibility) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Axe-core Accessibility Validation](../common/accessibility#ensuring-accessibility) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |

<style>
    .post .post-content img {
        display: inline-block;
        margin: 0.5em 0;
    }
</style>
<div><img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> - All features of the control meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> - Some features of the control do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/not-supported.png" alt="No"> - The control does not meet the requirement.</div>

## WAI-ARIA attributes

The following ARIA attributes are used in the Chat UI control:

| Attributes | Purpose |
| ------------ | ----------------------- |
| `role=button` | Indicates that the element is clickable and triggers an action when activated by the user. |
| `role=toolbar` | Specifies that the element is a toolbar. |
| `aria-label` | Defines a string value that labels an interactive element for accessibility. |
| `aria-orientation` | Specifies the orientation of the toolbar. |
| `aria-disabled` | Indicates whether the toolbar or element is currently disabled and not interactive. |
| `aria-multiline` | Indicates that a textbox accepts multiple lines of input or only a single line. |

## Keyboard interaction

The following keyboard shortcuts are supported by the Chat UI control.

| **Press** | **To do this** |
| --- | --- |
| <kbd>Enter</kbd> | Select the focused item or send a message when the input is focused. |
| <kbd>Tab</kbd> | Moves focus forward through the interactive elements. |
| <kbd>Shift + Tab</kbd> | Moves focus backward through the interactive elements. |
| <kbd>Page Up</kbd> | Scroll up through chat history. |
| <kbd>Page Down</kbd> | Scroll down through chat history. |
| <kbd>Ctrl + Home</kbd> | Scroll to the first message. |
| <kbd>Ctrl + End</kbd> | Scroll to the most recent message. |
<b>Chat UI Toolbars</b>||
| <kbd>Left Arrow</kbd> | Focuses the previous toolbar element.  |
| <kbd>Right Arrow</kbd> | Focuses the next toolbar element. |
| <kbd>Enter / Space</kbd> | Select the focused item or activate the selected option. |
| <kbd>Home</kbd> | Moves focus to the first toolbar element. |
| <kbd>End</kbd> | Moves focus to the last toolbar element. |

## Ensuring accessibility

The Chat UI control's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

## See also

* [Accessibility in Syncfusion<sup style="font-size:70%">&reg;</sup> controls](../common/accessibility)
