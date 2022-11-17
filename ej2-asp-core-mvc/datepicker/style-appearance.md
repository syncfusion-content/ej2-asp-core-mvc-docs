---
layout: post
title: Style and appearance in ##Platform_Name## Syncfusion DatePicker Component
description: Learn here all about style and appearance in Syncfusion ##Platform_Name## DatePicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: datepicker
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style and appearance in DatePicker Component

The following content provides the exact CSS structure that can be used to modify the control's appearance based on the user preference.

## Customizing the appearance of DatePicker wrapper element

Use the following CSS to customize the appearance of wrapper element.

```css
/* To specify height and font size */
.e-input-group input.e-input, .e-input-group.e-control-wrapper input.e-input {
        height: 40px;
        font-size: 20px;
}
```

## Customizing the DatePicker icon element

Use the following CSS to customize the DatePicker icon element.

```css
/* To specify background color and font size */
.e-input-group .e-input-group-icon:last-child, .e-input-group.e-control-wrapper .e-input-group-icon:last-child {
        font-size: 12px;
        background-color: darkgray;
}
```

## Customizing the placeholder color in the datepicker

Use the following CSS to customize the placeholder font color of the datepicker

```css
/* To specify the color of the placeholder */
::placeholder {
        /* Chrome, Firefox, Opera, Safari 10.1+ */
        color: red !important;
        opacity: 1; /* Firefox */
}
:-ms-input-placeholder {
        /* Internet Explorer 10-11 */
        color: red !important;
}
::-ms-input-placeholder {
        /* Microsoft Edge */
        color: red !important;
}
```

## Customizing the Calendar popup of the DatePicker

Check the below section, to customize the style and appearance of the Calendar component.

[Customizing Calendar's style and appearance](../calendar/style-appearance/)
