---
layout: post
title: Accessibility in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Accessibility in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ##Platform_Name## AI AssistView Control

The AI AssistView control followed the accessibility guidelines and standards, including [ADA](https://www.ada.gov/), [Section 508](https://www.section508.gov/), [WCAG 2.2](https://www.w3.org/TR/WCAG22/) standards, and [WCAG roles](https://www.w3.org/TR/wai-aria/#roles) that are commonly used to evaluate accessibility.

The accessibility compliance for the AI AssistView control is outlined below.

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

<div><img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> - All features of the component meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> - Some features of the component do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/not-supported.png" alt="No"> - The component does not meet the requirement.</div>

## WAI-ARIA attributes

The following ARIA attributes are used in the AI AssistView control:

| Attributes | Purpose |
| ------------ | ----------------------- |
| `role="toolbar"` | Attribute is set to the ToolBar element describes the actual role of the element. |
| `aria-orientation` |  Attribute is set to the ToolBar element to indicates the ToolBar orientation. Default value is `horizontal`. |
| `aria-label` | Attribute is set to ToolBar element describes the purpose of the set of toolbar. |
| `aria-expanded` | Attribute is set to the ToolBar Popup  element to indicates the expanded state of the popup.|
| `aria-haspopup` | Attribute is set to the popup element to indicates the popup mode of the Toolbar. Default value is false. When popup mode is enabled, attribute value has to be changed to `true`. |
| `aria-disabled` | Attribute set to the ToolBar element to indicates the disabled state of the ToolBar. |

## Keyboard interaction

The following keyboard shortcuts are supported by the AI AssistView control.

| **Press** | **To do this** |
| --- | --- |
| <kbd>Enter</kbd> | Appropriate view should be moved.  |
| <kbd>Tab</kbd> | Focuses on the next view item within the toolbar items. Further pressing tab, move focusing on the order of last response toolbar items and then move focus to text area element, then send button. |
| <kbd>Shift + Tab</kbd> | Focuses on the previous view item within the toolbar items. Further pressing shift + tab will move the focus in reverse order |

## Ensuring accessibility

The AI AssistView control's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

## See also

* [Accessibility in Syncfusion controls](../common/accessibility)
