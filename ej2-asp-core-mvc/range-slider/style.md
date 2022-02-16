---
layout: post
title: Style in ##Platform_Name## Range Slider Component
description: Learn here all about Style in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---


# CSS structures

The following content provides the exact CSS structure that can be used to modify the control's appearance based on the user preference.

## Customizing the slider track

Use the following CSS to customize the slider track.

```css
.e-control-wrapper.e-slider-container.e-horizontal .e-slider-track {
    background: #007bff;
    height: 3px;
}
```

## Customizing the slider handle

Use the following CSS to customize the slider handle properties.

```css
.e-control-wrapper.e-slider-container .e-slider .e-handle {
    background-color: #f9920b;
    border-radius: 50%;
    border: 0;
}
```

## Customizing the slider limits

Use the following CSS to customize the slider limits.

```css
.e-control-wrapper.e-slider-container.e-horizontal .e-limits {
    background-color: rgba(69, 100, 233, 0.46);
}
```

## Customizing the slider ticks

Use the following CSS to customize the slider ticks.

```css
.e-scale .e-tick.e-custom::before {
    content: '\e967';
    position: absolute;
}
```

## Customizing the slider buttons

Use the following CSS to customize the slider buttons.

```css
.e-control-wrapper.e-slider-container .e-slider-button {
    background: #007bff;
    height: 25px;
    width: 25px;
}
```
