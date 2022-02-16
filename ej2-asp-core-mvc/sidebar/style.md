---
layout: post
title: Style in ##Platform_Name## Sidebar Component
description: Learn here all about Style in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---


# Styles and Appearance

The following content provides the exact CSS structure that can be used to modify the control's appearance based on the user's preference.

## Customizing the sidebar

Use the below CSS to customize the sidebar root element.

```css

.e-sidebar {
    background: #898b2b
}

```

## Customizing the sidebar based on the positions

Use the below CSS to customize the left positioned sidebar.

```css

.e-sidebar.e-left {
    border-right: 2px solid red;
}

```

Use the below CSS to customize the right positioned sidebar.

```css

.e-sidebar.e-right {
    border-left: 2px solid red;
}

```

## Customizing the sidebar based on the active state

Use the below CSS to customize the open state of the left positioned sidebar.

```css

.e-sidebar.e-left.e-open {
    transition: transform 2.5s ease;
}

```

Use the below CSS to customize the open state of the right positioned sidebar.

```css

.e-sidebar.e-right.e-open {
     transition: transform 2.5s ease;
}

```

Use the below CSS to customize the closed state of the left positioned sidebar.

```css

.e-sidebar.e-left.e-transition.e-close {
    transition: transform 2.5s ease, visibility 1200ms;
}

```

Use the below CSS to customize the closed state of the right positioned sidebar.

```css

.e-sidebar.e-right.e-transition.e-close {
    transition: transform 2.5s ease, visibility 1200ms;
}

```

## Customizing the sidebar with dock state

When you enable the Dock support, the "e-dock" class will be added to the root element. Based on that class, you can also customize all the above stated customization. Use the following CSS to customize the sidebar element with a dock state.

```css

.e-sidebar.e-dock {
    background: #2d323e;
}

```

## Customizing the different types of sidebar

Use the below CSS to customize the auto type sidebar.

```css

.e-sidebar.e-left.e-auto {
    background-color: pink;
}

```

Use the below CSS to customize the push type sidebar.

```css

.e-sidebar.e-left.e-push {
    background-color: beige;
}

```

Use the below CSS to customize the over type sidebar.

```css

.e-sidebar.e-left.e-over {
    background-color: aqua;
}

```

Use the below CSS to customize the slide type sidebar.

```css

.e-sidebar.e-left.e-slide {
    background-color: green;
}

```

## Customizing the backdrop of the sidebar

Use the below CSS to customize the backdrop of the sidebar.

```css

.e-sidebar-overlay {
    background-color: aqua;
}

```

## Customizing the sidebar in the RTL direction

When you enable the RTL (right to left direction) support, the "e-rtl" class will be added to the root element. Based on that class, you can also customize all the above stated customization. Use the following CSS to customize the sidebar element in the RTL (right to left direction) mode.

```css

.e-sidebar.e-left.e-rtl {
    background-color: antiquewhite;
}

```