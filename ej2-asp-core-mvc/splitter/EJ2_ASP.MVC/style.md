---
layout: post
title: Style in ##Platform_Name## Splitter Component
description: Learn here all about Style in Syncfusion ##Platform_Name## Splitter component and more.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---


# CSS structures

The following content provides the exact CSS structure that can be used to modify the control's appearance based on the user preference.

## Customizing the split bar

Use the following CSS to customize the split bar properties.

### Horizontal split bar

```CSS
/* default split bar color */
.e-splitter .e-split-bar.e-split-bar-horizontal{
   background: blue;
}

/* split bar color in hover and active state */
.e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-hover,
.e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-active {
   background: green;
}
```

### Vertical split bar

```CSS
/* default split bar color */
.e-splitter .e-split-bar.e-split-bar-vertical {
    background: blue;
}

/* split bar color in hover and active state */
.e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-hover,
.e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-active {
    background: green;
}
```

## Customizing the split bar resize handle

Use the following CSS to customize the split bar resize handle.

### Horizontal split bar resize handle

```CSS
/* default split bar resize handle color */
.e-splitter .e-split-bar.e-split-bar-horizontal .e-resize-handler {
    color: rgba(20, 27, 233, 0.54);
}

/* default split bar resize handle color in hover and active state */
.e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-hover .e-resize-handler,
.e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-active .e-resize-handler{
    color: green;
}
```

### Vertical split bar resize handle

```CSS
/* default split bar resize handle color */
.e-splitter .e-split-bar.e-split-bar-vertical .e-resize-handler {
    color: rgba(20, 27, 233, 0.54);
}

/* default split bar resize handle color in hover and active state */
.e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-hover .e-resize-handler,
.e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-active .e-resize-handler{
    color: green;
}
```

## Customizing the split bar arrows

Use the following CSS to customize the split bar arrows.

### Horizontal split bar resize arrows

```CSS
/* split bar arrows */
.e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-hover .e-navigate-arrow.e-arrow-left::before, .e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-active .e-navigate-arrow.e-arrow-left::before, .e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-hover .e-navigate-arrow.e-arrow-left::after, .e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-active .e-navigate-arrow.e-arrow-left::after, .e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-hover .e-navigate-arrow.e-arrow-right::before, .e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-active .e-navigate-arrow.e-arrow-right::before, .e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-hover .e-navigate-arrow.e-arrow-right::after, .e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-active .e-navigate-arrow.e-arrow-right::after {
    background-color: green;
}

/* split bar arrows - circular border */
.e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-hover .e-navigate-arrow.e-arrow-left, .e-splitter .e-split-bar.e-split-bar-horizontal.e-split-bar-hover .e-navigate-arrow.e-arrow-right {
    border-color: rgba(33, 227, 22, 0.5);
}
```

### Vertical split bar resize arrows

```CSS
/* split bar arrows */
.e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-hover .e-navigate-arrow.e-arrow-up::before, .e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-active .e-navigate-arrow.e-arrow-up::before, .e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-hover .e-navigate-arrow.e-arrow-up::after, .e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-active .e-navigate-arrow.e-arrow-up::after, .e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-hover .e-navigate-arrow.e-arrow-down::before, .e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-active .e-navigate-arrow.e-arrow-down::before, .e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-hover .e-navigate-arrow.e-arrow-down::after, .e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-active .e-navigate-arrow.e-arrow-down::after {
    background-color: green;
}

/* split bar arrows - circular border */
.e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-hover .e-navigate-arrow.e-arrow-up, .e-splitter .e-split-bar.e-split-bar-vertical.e-split-bar-hover .e-navigate-arrow.e-arrow-down {
    border-color: rgba(33, 227, 22, 0.5);
}
```
