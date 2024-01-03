---
layout: post
title: Accessibility in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Accessibility in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ##Platform_Name## Stepper control

Accessibility is achieved in the Stepper control through `WAI-ARIA` standard and keyboard navigations. The Stepper control can be effectively accessed through assistive technologies such as screen readers.

## Keyboard interaction

The Stepper control is interactive with the below keyboard shortcuts.

| **Keyboard shortcuts** | **Actions** |
| --- | --- |
| <kbd>Up Arrow</kbd> | Focuses the previous step in a vertical Stepper. |
| <kbd>Down Arrow</kbd> | Focuses the next step in a vertical Stepper. |
| <kbd>Left Arrow</kbd> | Focuses the previous step in a horizontal Stepper. |
| <kbd>Right Arrow</kbd> | Focuses the next step in a horizontal Stepper. |
| <kbd>Home</kbd> | Focuses on the first step of the Stepper. |
| <kbd>End</kbd> | Focuses on the last step of the Stepper. |
| <kbd>Enter / Space</kbd> | Activates the currently focused step. |

## ARIA attribute

The following ARIA attributes are used in Stepper control based on its state.

| Properties | Functionality |
| ------------ | ----------------------- |
| `aria-label` | Attribute provide a descriptive text that labels the interactive element for accessibility. |
| `aria-current` | Attribute denotes the currently active step in the Stepper. |
| `aria-disabled`| Indicates when the step is disabled and cannot be interacted. |