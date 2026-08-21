---
layout: post
title: Accessibility in ##Platform_Name## Tab control | Syncfusion
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Tab control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tab
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ##Platform_Name## Tab control

The accessibility compliance for the Tab control is outlined below.

| Accessibility Criteria | Compatibility |
| -- | -- |
| [WCAG 2.2](https://www.w3.org/TR/WCAG22/) Support | AA |
| [Section 508](https://www.section508.gov/) Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Screen Reader Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Right-To-Left Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Color Contrast | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Mobile Device Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Keyboard Navigation Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| [Accessibility Checker](https://www.npmjs.com/package/accessibility-checker) Validation | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |

<style>
    .post .post-content img {
        display: inline-block;
        margin: 0.5em 0;
    }
</style>

<div><img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> - All features of the control meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/landing-page/intermediate.png" alt="Intermediate"> - Some features of the control do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/landing-page/no.png" alt="No"> - The control does not meet the requirement.</div>

## ARIA attributes

Tab control is designed by considering [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/patterns/tabs/) standard. Tab is supported with ARIA Accessibility which is accessible by on-screen readers, and other assistive technology devices.
The following list of attributes are added in the Tab.

| **Roles and Attributes** | **Functionalities** |
| --- | --- |
| `tablist` | Attribute is set to the Tab header element that describes actual role of the element.|
| `tab` | Attribute is set to the Tab items element to  indicate an interactive element inside a `tablist` that, when activated, displays its associated `tabpanel`.|
| `tabpanel` | Attribute is set to the Tab content that describes the role for viewing the active content.|
| aria-orientation    | Attribute is set to the Tab header element indicate the Tab header orientation. Default value of this attribute is horizontal. |
| aria-selected       | Attribute set to the Tab items to indicates the selection state for Tab items. Active Tab is set to true for this attribute. |
| aria-labelledby       | Attribute is set to the Tab content element to indicate the associated Tab header for the content. |
| aria-controls       | Attribute is set to the Tab items element to indicates the associated `tabpanel` for the header. |
| aria-haspopup       | Attribute is set to the Popup element  to indicate the popup mode in the Tab. The default value of this attribute is false. If popup mode is enabled, the attribute value is set to true. |
| aria-disabled       | Attribute set to the Tab items to It indicates the disabled state of the Tab. |

## Keyboard interaction

By default, keyboard navigation is enabled. This control implements keyboard navigation support by following the WAI-ARIA practices. Once focused on the active Tab element, you can use the following key combination for interacting with the Tab.

| Key           | Description                                                                         |
|---------------|-------------------------------------------------------------------------------------|
| <kbd>Left</kbd>    | Moves focus to the previous Tab. |
| <kbd>Right</kbd>   | Moves focus to the next Tab. |
| <kbd>Enter</kbd> or <kbd> Space</kbd>  | Selects the Tab if it is not selected. Opens the popup dropdown icon if it is focused. Select the Tab item as active when popup item is focused. |
| <kbd>Esc(Escape)</kbd>           | Closes the popup if popup is in opened state.       |
| <kbd>Down</kbd> or <kbd>Up</kbd>   | When the popup is open and focused, it will move to previous/next Tab items of the popup in the vertical direction.|
|  <kbd>Home</kbd>    | Moves focus to the first Tab. |
|  <kbd>End </kbd>   | Moves focus to the last Tab. |
|  <kbd>Shift + F10 </kbd>   | If popup mode is enabled, it opens the popup when the Tab is focused. |
|  <kbd>Delete</kbd>    | Deletes the Tab, if close button is enabled in Tab header.|
| <kbd>Tab</kbd>     | To Move focus through the interactive elements.                 |
| <kbd>Shift + Tab</kbd> | To Move focus through the interactive elements.             |

## Ensuring accessibility

The Tab control's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Tab control is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/tab.html) in a new window to evaluate the accessibility of the Tab control with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/tab.html" %}

## See also

- [Accessibility in ASP.NET Core controls](../common/accessibility)
