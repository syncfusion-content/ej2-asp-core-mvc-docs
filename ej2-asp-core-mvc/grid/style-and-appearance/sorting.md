---
layout: post
title: Sorting in ##Platform_Name## Grid Component
description: Learn here all about Sorting in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Sorting in ##Platform_Name## Grid component

You can customize the appearance of the sorting icons and multi sorting icons in the Syncfusion ##Platform_Name## Grid component using CSS. You can use the available Syncfusion [icons](../../appearance/icons/#material) based on your theme. Here's how to do it:

## Customizing the grid sorting icon

To customize the sorting icon that appears in the Grid header when sorting is applied, you can use the following CSS code:

```css
.e-grid .e-icon-ascending::before {
    content: '\e7a3'; /* Icon code for ascending order */
}
.e-grid .e-icon-descending::before {
    content: '\e7b6'; /* Icon code for descending order */
}
```
In this example, the **.e-icon-ascending::before** class targets the sorting icon for ascending order, and the **.e-icon-descending::before** class targets the sorting icon for descending order.

![Grid sorting icon](../images/style-and-appearance/grid-sorting-icons.png)

## Customizing the grid multi sorting icon

To customize the multi sorting icon that appears in the grid header when multiple columns are sorted, you can use the following CSS code:

```css
.e-grid .e-sortnumber {
    background-color: #deecf9;
    font-family: cursive;
}
```

In this example, the **.e-sortnumber** class targets the background color and font family of the multi sorting icon. You can modify the `background-color` and `font-family` properties to customize the appearance of the multi sorting icon.

![Grid multi sorting icon](../images/style-and-appearance/grid-multi-sorting-icon.png)