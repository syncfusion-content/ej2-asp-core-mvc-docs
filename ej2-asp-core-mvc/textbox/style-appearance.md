---
layout: post
title: Style and Appearance in ##Platform_Name## TextBox | Syncfusion
description: Customize the Syncfusion ##Platform_Name## TextBox appearance using CSS to modify wrapper element height, font size, and floating label color.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style and Appearance in ##Platform_Name## TextBox

The following content provides the exact CSS structure that can be used to modify the control’s appearance based on the user preference.

## Customizing the appearance of TextBox wrapper element

Use the following CSS to customize the appearance of wrapper element.

```css
/* To specify height and font size */
.e-input:not(:valid), .e-input:valid, .e-float-input.e-control-wrapper input:not(:valid), .e-float-input.e-control-wrapper input:valid, .e-float-input input:not(:valid), .e-float-input input:valid, .e-input-group input:not(:valid), .e-input-group input:valid, .e-input-group.e-control-wrapper input:not(:valid), .e-input-group.e-control-wrapper input:valid, .e-float-input.e-control-wrapper textarea:not(:valid), .e-float-input.e-control-wrapper textarea:valid, .e-float-input textarea:not(:valid), .e-float-input textarea:valid, .e-input-group.e-control-wrapper textarea:not(:valid), .e-input-group.e-control-wrapper textarea:valid, .e-input-group textarea:not(:valid), .e-input-group textarea:valid {
        font-size: 30px;
        height: 40px;
}
```

## Customizing the TextBox placeholder

Use the following CSS to customize the TextBox placeholder

```css
/* To specify font size and color */
.e-float-input.e-control-wrapper:not(.e-error) input:valid ~ label.e-float-text, .e-float-input.e-control-wrapper:not(.e-error) input ~ label.e-label-top.e-float-text {
        color: pink;
        font-size: 15px;
}
```
