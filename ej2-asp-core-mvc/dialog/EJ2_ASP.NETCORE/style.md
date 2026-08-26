---
layout: post
title: Style in ##Platform_Name## Dialog | Syncfusion
description: Override Syncfusion ##Platform_Name## Dialog CSS classes to customize the header, content, footer, and overlay appearance to match your application design.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style in ASP.NET CORE Dialog

The following content provides the exact CSS structure that can be used to modify the control's appearance based on the user preference.

## Customizing the Dialog header

Use the following CSS to customize the Dialog header properties.

```CSS
.e-dialog .e-dlg-header {
    color: green;
    font-size: 20px;
    font-weight: normal;
}
```

## Customizing the Dialog content

Use the following CSS to customize the Dialog content properties.

```CSS
.e-dialog .e-dlg-content {
    color: red;
    font-size: 10px;
    font-weight: normal;
    line-height: normal;
}
```

## Customizing the modal dialog overlay

Use the following CSS to customize the modal Dialog overlay.

```CSS
.e-dlg-overlay {
    background-color: slategray;
    opacity: 0.6;
}
```

## Customizing the Dialog resize icon

Use the following CSS to customize the Dialog resize icon.

```CSS
/* To change the icon content */
.e-dialog .e-south-east::before, .e-dialog .e-south-west::before {
    content: '\f047';
}

/* To set the icon pack */
.e-dialog .e-resize-handle {
    font: normal normal normal 14px/1 FontAwesome;
}
```

The CSS above uses the Font Awesome icon.

## Customizing the Dialog close button

Use the following CSS to customize the Dialog close button.

```CSS
/* To specify font size and color */
.e-dialog .e-btn .e-btn-icon.e-icon-dlg-close {
    font-size: 12px;
    color: red;
}
```

## Customizing the Dialog footer button

Use the following CSS to customize the Dialog footer button.

```CSS
/* To specify font color, background color and border color */
.e-btn.e-flat.e-primary, .e-css.e-btn.e-flat.e-primary {
    background-color: transparent;
    border-color: transparent;
    color: blue;
}
```
