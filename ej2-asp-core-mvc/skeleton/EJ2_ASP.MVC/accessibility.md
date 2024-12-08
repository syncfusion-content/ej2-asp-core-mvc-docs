---
layout: post
title: Accessibility in ##Platform_Name## Skeleton Control | Syncfusion
description: Checkout and learn here all about Accessibility in ##Platform_Name## Skeleton control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ASP.NET MVC Skeleton control

The Skeleton control followed the accessibility guidelines and standards, including [ADA](https://www.ada.gov/), [Section 508](https://www.section508.gov/), [WCAG 2.2](https://www.w3.org/TR/WCAG22/) standards, and [WCAG roles](https://www.w3.org/TR/wai-aria/#roles) that are commonly used to evaluate accessibility.

The accessibility compliance for the Skeleton control is outlined below.

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

The Skeleton control followed the [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/patterns/alert/) patterns to meet the accessibility. The following ARIA attributes are used in the Skeleton control:

| Attributes | Purpose |
| ------------ | ----------------------- |
| `role=alert` | Used to convey important, time-sensitive or contextual message to the user. |
| `aria-label` | Attribute provides the text label for the Skeleton. |
| `aria-live` | Attributes which indicates the content changes which are not interactable are live regions. |
| `aria-busy` | Set to true until loading is complete, then set to false. |

## Ensuring accessibility

The Skeleton control's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Skeleton control is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/skeleton.html) in a new window to evaluate the accessibility of the Skeleton control with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/skeleton.html" %}

## See also

* [Accessibility in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls](../common/accessibility)
