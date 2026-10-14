---
layout: post
title: Style in ##Platform_Name## Toolbar | Syncfusion
description: Customize the Syncfusion ##Platform_Name## Toolbar appearance using CSS to modify the root element, items, and command button properties.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style in ##Platform_Name## Toolbar

The following content provides the exact CSS structure that can be used to modify the control's appearance based on user preference.

## Customizing the Toolbar

Use the following CSS to customize the Toolbar root element.

```CSS

.e-toolbar {
    border: 5px solid rgb(173, 255, 47);
}

```

## Customizing the Toolbar items

Use the following CSS to customize the items of Toolbar.

```CSS

 .e-toolbar .e-toolbar-item {
    background: #add8e6;
    border: 1px solid #5a70cc;
}

```

Use the following CSS to customize the button in the items of the Toolbar.

```CSS

.e-toolbar .e-tbar-btn {
    background: #add8e6;
    border: 1px solid #5a70cc;
}

```

## Customizing Toolbar's item icon

Use the following CSS to customize the item icon of Toolbar control.

```CSS

.e-toolbar .e-tbar-btn .e-icons {
    background: #185655;
    color: #d7f9d4;
}

```

## Customizing the hover state of the Toolbar

Use the following CSS to customize the toolbar item when hovering.

```CSS

.e-toolbar .e-tbar-btn:hover {
    background: #c0e3a1;
    border: 1px solid green;
}

```

## Customizing the selected item of the Toolbar

Use the following CSS to customize the selected toolbar item.

```CSS

.e-toolbar .e-tbar-btn:focus {
    background: #add8e6;
    border: 1px solid #5a70cc;
}

```