---
layout: post
title: Accessibility in Syncfusion ##Platform_Name## Carousel Control
description: Checkout and learn about accessibility in ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in Carousel control

The Carousel component has been designed, keeping in mind the [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/patterns/carousel/) specifications, and applying the WAI-ARIA roles, states and properties along with keyboard support for people who use assistive devices. WAI-ARIA accessibility support is achieved through attributes like `aria-roledescription`, `aria-label`, `aria-current`, `aria-live`, `aria-role` and `aria-hidden`. It provides information about elements in a document for assistive technology. The component implements keyboard navigation support by following the [WAI-ARIA practices](https://www.w3.org/TR/wai-aria-practices/) and has been tested in major screen readers.

The accessibility compliance for the Carousel component is outlined below.

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

<div><img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> - All features of the component meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/landing-page/intermediate.png" alt="Intermediate"> - Some features of the component do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/landing-page/no.png" alt="No"> - The component does not meet the requirement.</div>

## ARIA attributes

The carousel component is designed by considering [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/patterns/carousel/) standard. Carousel is supported with ARIA Accessibility which is accessible by on-screen readers and other assistive technology devices. The following list of attributes is added to the Carousel.

| **Roles and Attributes** | **Functionalities**                                                                                                                             |
| ------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| `aria-roledescription`   | The role description attribute has been added for the root element (carousel) and each carousel slide item (slide).                            |
| `aria-label`             | Previous, next and play/pause buttons and all indicator elements.                                                                               |
| `aria-current`           | For the active item indicator element, `aria-current` is set to `true`.                                                                         |
| `aria-hidden`            | For all carousel elements except the currently visible item, `aria-hidden` is set to `true`.                                                    |
| `aria-live`              | For carousel items element, when `autoPlay` is `true`, `aria-live` is set to `off`; when `autoPlay` is `false`, `aria-live` is set to `polite`. |
| `aria-role`              | For carousel slide item, `aria-role` has been grouped.                                                                                           |

## Keyboard interaction

All Carousel actions can be controlled via keyboard keys by using the [`allowKeyboardInteraction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Carousel.html#Syncfusion_EJ2_Navigations_Carousel_AllowKeyboardInteraction) property, which is set to `true` by default. This feature aims to improve user experience by preventing unintended navigation when users are focused on other interactive elements. For example, consider a scenario where a user is browsing a product carousel on an e-commerce website. While filling out a form adjacent to the carousel, they might accidentally press the left or right arrow keys, causing the carousel to navigate unexpectedly. By disabling keyboard interactions, the carousel remains static, allowing the user to focus on the form without disruptions. This control implements keyboard navigation support by following WAI-ARIA practices. Once focused on the active Carousel element, you can use the following key combinations to interact with the Carousel.

| Key                | Description                                                     |
| ------------------ | --------------------------------------------------------------- |
| <kbd>Alt + J</kbd> | Keys to focus the carousel component (done at application end). |
| <kbd>Arrows</kbd>  | Keys to navigate between slides.                                |
| <kbd>Home</kbd>    | To navigate to the first slide.                                 |
| <kbd>End</kbd>     | To navigate to the last slide.                                  |
| <kbd>Space</kbd>   | To play/pause the slide transitions.                            |
| <kbd>Enter</kbd>   | To perform the respective action on its focus.                  |
| <kbd>Tab</kbd>     | To Move focus through the interactive elements.                 |
| <kbd>Shift + Tab</kbd> | To Move focus through the interactive elements.             |

## Ensuring accessibility

The Carousel component's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Carousel component is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/carousel.html) in a new window to evaluate the accessibility of the carousel component with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/carousel.html" %}

## See also

- [Accessibility in Syncfusion components](../common/accessibility)