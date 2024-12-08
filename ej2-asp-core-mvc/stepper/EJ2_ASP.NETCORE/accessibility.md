---
layout: post
title: Accessibility in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Accessibility in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ##Platform_Name## Stepper control

The Stepper control followed the accessibility guidelines and standards, including [ADA](https://www.ada.gov/), [Section 508](https://www.section508.gov/), [WCAG 2.2](https://www.w3.org/TR/WCAG22/) standards, and [WCAG roles](https://www.w3.org/TR/wai-aria/#roles) that are commonly used to evaluate accessibility.

The accessibility compliance for the Stepper control is outlined below.

| Accessibility Criteria | Compatibility |
| -- | -- |
| [WCAG 2.2](https://www.w3.org/TR/WCAG22/) Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| [Section 508](https://www.section508.gov/) Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Screen Reader Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Right-To-Left Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Color Contrast | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Mobile Device Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Keyboard Navigation Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| [Accessibility Checker](https://www.npmjs.com/package/accessibility-checker) Validation | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| [Axe-core](https://www.npmjs.com/package/axe-core) Accessibility Validation | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |

<style>
    .post .post-content img {
        display: inline-block;
        margin: 0.5em 0;
    }
</style>
<div><img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> - All features of the control meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/landing-page/intermediate.png" alt="Intermediate"> - Some features of the control do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/landing-page/no.png" alt="No"> - The control does not meet the requirement.</div>

## WAI-ARIA attributes

The following ARIA attributes are used in the Stepper control:

| Attributes | Purpose |
| --- | --- |
| `aria-label` | Attribute provide a descriptive text that labels the interactive element for accessibility. |
| `aria-current` | Attribute denotes the currently active step in the Stepper. |
| `aria-disabled`| Indicates when the step is disabled and cannot be interacted. |

## Keyboard interaction

The following keyboard shortcuts are supported by the Stepper control.

| **Press** | **To do this** |
| --- | --- |
| <kbd>Up Arrow</kbd> | Focuses the previous step in a vertical Stepper. |
| <kbd>Down Arrow</kbd> | Focuses the next step in a vertical Stepper. |
| <kbd>Left Arrow</kbd> | Focuses the previous step in a horizontal Stepper. |
| <kbd>Right Arrow</kbd> | Focuses the next step in a horizontal Stepper. |
| <kbd>Home</kbd> | Focuses on the first step of the Stepper. |
| <kbd>End</kbd> | Focuses on the last step of the Stepper. |
| <kbd>Enter / Space</kbd> | Activates the currently focused step. |

## Ensuring accessibility

The Stepper control's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Stepper control is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/stepper.html) in a new window to evaluate the accessibility of the Stepper control with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/stepper.html" %}

## See also

* [Accessibility in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls](../common/accessibility)