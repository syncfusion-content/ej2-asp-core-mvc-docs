---
layout: post
title: Style and Appearance in ##Platform_Name## MaskedTextBox | Syncfusion
description: Customize Syncfusion ##Platform_Name## MaskedTextBox appearance using CSS classes for input wrapper, focus, error, success, and disabled states via custom theme.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style and Appearance in ##Platform_Name## MaskedTextBox

The following content provides the exact CSS structure that can be used to modify the control’s appearance based on the user preference.

## Customizing the appearance of MaskedTextBox wrapper element

Use the following CSS to customize the appearance of wrapper element.

```css
/* To specify height, font size, and border */
.e-input-group input.e-input, .e-input-group.e-control-wrapper input.e-input, .e-input-group textarea.e-input, .e-input-group.e-control-wrapper textarea.e-input {
        font-size: 20px;
        border-color: red;
        height: 40px;
        border: 2px solid;
  }
```

## Customizing the MaskedTextBox element on hovering

Use the following CSS to customize the Input Mask element on hovering

```css
/* To specify border */
.e-input-group input.e-input, .e-input-group input.e-input:hover:not(.e-success):not(.e-warning):not(.e-error):not([disabled]):not(:focus), .e-input-group.e-control-wrapper input.e-input,.e-input-group.e-control-wrapper input.e-input:hover:not(.e-success):not(.e-warning):not(.e-error):not([disabled]):no(:focus){
      border: 3px solid red;
}
```