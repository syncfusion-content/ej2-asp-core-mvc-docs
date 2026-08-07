---
layout: post
title: ##Platform_Name## Grid Toolbar Style | Syncfusion
description: Learn how to customize toolbar styles in ##Platform_Name## Data Grid with toolbar items, templates, layout options, and CSS-based styling.
platform: ej2-asp-core-mvc
control: Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Toolbar Style in ##Platform_Name## Data Grid

You can customize the appearance of the toolbar in the Syncfusion ##Platform_Name## Grid component using CSS. Here are examples of how to customize the toolbar root element and toolbar button element.

## Customizing the toolbar root element

To customize the appearance of toolbar root element, you can use the following CSS code:

```css
.e-grid .e-toolbar-items {
    background-color: #deecf9;
}
```

In this example, the **.e-toolbar-items** class targets the background color of the toolbar root element. You can modify the `background-color` property to change the background color of the toolbar.

![Grid toolbar root element](../images/style-and-appearance/grid-toolbar-root-element.png)

## Customizing the toolbar button element

To customize the appearance of toolbar buttons, you can use the following CSS code:

```css
.e-grid .e-toolbar .e-btn {
    background-color: #deecf9;
}
```
In this example, the **.e-toolbar .e-btn** selector targets the background color of the toolbar button elements. You can modify the `background-color` property to change the background color of the toolbar buttons.

![Grid toolbar button element](../images/style-and-appearance/grid-toolbar-button-element.png)