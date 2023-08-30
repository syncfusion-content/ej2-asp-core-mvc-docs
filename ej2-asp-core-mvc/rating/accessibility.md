---
layout: post
title: Accessibility in ##Platform_Name## Rating Control | Syncfusion
description: Checkout and learn here all about accessibility and keyboard interaction in ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ##Platform_Name## Rating Control

Accessibility is achieved in the rating control through `WAI-ARIA` standard and keyboard navigations. The Rating control can be effectively accessed through assistive technologies such as screen readers.

## Keyboard interaction

The rating control is interactive with below keyboard shortcuts.

| Keyboard shortcuts | Actions |
|------------|-------------------|
| <kbd>Space</kbd> | If a **Reset Button** is focused, resets the value to `Min` value. |
| <kbd>ArrowUp</kbd> | Increases the value. | 
| <kbd>ArrowLeft</kbd> | Decreases the value and in RTL mode, increases the value. |
| <kbd>ArrowDown</kbd> | Decreases the value. |
| <kbd>ArrowRight</kbd> | Increases the value and in RTL mode, decreases the value.  |

## ARIA attribute

The following ARIA attributes are used in rating control based on its state.

| Properties | Functionality |
| ------------ | ----------------------- |
| role | This attribute is added to the div element to describe the actual role. |
| aria-label | Attribute provides the text label with some default description for the Rating and its items. |
| aria-valuemin | It defines the minimum value of rating. |
| aria-valuemax | It defines the maximum value of rating. |
| aria-valuenow | It defines the current value of rating. |