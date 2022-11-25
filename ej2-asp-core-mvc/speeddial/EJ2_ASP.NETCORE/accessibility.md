---
layout: post
title: Accessibility in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn here all about accessibility and keyboard in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ASP.NET Core SpeedDial Control

Accessibility is achieved in the Speed Dial control through WAI-ARIA standard and keyboard navigations. The Speed Dial control can be effectively accessed through assistive technologies such as screen readers.

## Keyboard interaction

The Speed Dial control is interactive with below keyboard shortcuts. 

| Keyboard shortcuts | Actions |
|------------|-------------------|
| <kbd>Enter</kbd> | Open/close the menu. If a SpeedDial item is focused, should triggers the clicked event for the item. |
| <kbd>ArrowUp</kbd> | Navigates up or to the previous menu item. |
| <kbd>ArrowLeft</kbd> | Navigates left or to the previous menu item. |
| <kbd>ArrowDown-</kbd> | Navigates down or to the previous menu item. |
| <kbd>ArrowRight</kbd> | Navigates right or to the previous menu item. |
| <kbd>Home</kbd> | Navigates to the first menu item. |
| <kbd>End</kbd> | Navigates to the last menu item. |
| <kbd>Esc</kbd> | Closes the menu. |

## ARIA attributes

The following ARIA attributes are applicable for SpeedDial Control based on its state.

| Properties | Functionality |
| ------------ | ----------------------- |
| role | This attribute is added to the input element to describe the actual role. |
| aria-label | Attribute provides the text label with some default description for the SpeedDial and its items. |
| aria-expanded | It indicates whether the SpeedDial current state is expanded or collapsed. |
| aria-haspopup | It indicates whether the SpeedDial has popup items or not. |
| aria-controls | Attribute is set to the SpeedDial button and it points to the corresponding content. |
| aria-disabled | It indicates the disabled state of the SpeedDial and its items. |