---
layout: post
title: Accessibility in ##Platform_Name## Carousel Control
description: Checkout and learn about accessibility in ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility

The Carousel component has been designed, keeping in mind the [WAI-ARIA](https://www.w3.org/TR/wai-aria-practices/) specifications, and applying the WAI-ARIA roles, states and properties along with keyboard support for people who use assistive devices. WAI-ARIA accessibility support is achieved through attributes like `aria-roledescription`, `aria-label`, `aria-current`, `aria-live`, `aria-role` and `aria-hidden`. It provides information about elements in a document for assistive technology. The component implements keyboard navigation support by following the [WAI-ARIA practices](https://www.w3.org/TR/wai-aria-practices/) and has been tested in major screen readers.

## ARIA attributes

The carousel component is designed by considering [WAI-ARIA](https://www.w3.org/TR/wai-aria-practices/) standard. Carousel is supported with ARIA Accessibility which is accessible by on-screen readers and other assistive technology devices. The following list of attributes is added to the Carousel.

| **Roles and Attributes** | **Functionalities**                                                                                                                         |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------- |
| `aria-roledescription`   | The role description attribute should be added for the root element (carousel) and each carousel slide item (slide).                        |
| `aria-label`             | Previous, next and play/pause buttons and all indicator elements.                                                                           |
| `aria-current`           | For the active item indicator element, `aria-current` is set to `true`.                                                                     |
| `aria-hidden`            | For all carousel elements except the currently visible item, `aria-hidden` is set to `true`.                                                |
| `aria-live`              | For carousel items element, when autoPlay is true, `aria-live` is set to `off`; when `autoPlay` is `false`, `aria-live` is set to `polite`. |
| `aria-role`              | For carousel slide item, `aria-role` should be group.                                                                                       |

## Keyboard interaction

By default, keyboard navigation is enabled. This component implements keyboard navigation support by following the WAI-ARIA practices. Once focused on the active Carousel element, you can use the following key combination for interacting with the Carousel.

| Key                | Description                                                     |
| ------------------ | --------------------------------------------------------------- |
| <kbd>Alt + J</kbd> | Keys to focus the carousel component (done at application end). |
| <kbd>Arrows</kbd>  | Keys to navigate between slides.                                |
| <kbd>Home</kbd>    | To navigate to the first slide.                                 |
| <kbd>End</kbd>     | To navigate to the last slide.                                  |
| <kbd>Space</kbd>   | To play/pause the slide transitions.                            |
| <kbd>Enter</kbd>   | To perform the respective action on its focus.                  |
