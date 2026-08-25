---
layout: post
title: Style in ##Platform_Name## Tabs | Syncfusion
description: Customize the Syncfusion ##Platform_Name## Tabs appearance using CSS to modify the tab root, header items, content items, and header background.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---


# Style in ##Platform_Name## Tabs

The following CSS structures can be used to modify the Tab's appearance.

## Customizing Tab

Use the following CSS to customize the Tab.

```CSS

.e-tab {
    border: 5px solid rgb(173, 255, 47);
}

```

## Customizing the Tab items

Use the following CSS to customize the header items of Tab.

```CSS

.e-tab .e-tab-header .e-toolbar-items {
    background: #9faed8;
    border: 2px solid blue;
}

```

Use the following CSS to customize the content items of Tab.

```CSS

.e-tab .e-content .e-item {
    color: #a78515;
    font-size: 14px;
}

```

## Customizing Tab's header

Use the following CSS to customize the header of Tabs control.

```CSS

.e-tab .e-tab-header {
    background: #badfba !important;
}

```

## Customizing Tab's header icon

Use the following CSS to customize the header item icon of Tabs control.

```CSS

.e-tab .e-tab-header .e-toolbar-item .e-tab-icon {
    color: #badfba !important;
}

```

## Customizing Tab's content

Use the following CSS to customize the content of Tabs control.

```CSS

.e-tab .e-content {
    background: #d1f6d1 !important;
}

```

## Customizing the hover state of Tabs control

Use the following CSS to customize the tab item when hovering.

```CSS

.e-tab .e-tab-header .e-toolbar-item .e-tab-wrap:hover {
    background: #d1f6d1 !important;
}

```

Use the following CSS to customize the tab item popup icon when hovering.

```CSS

.e-tab .e-tab-header .e-hor-nav .e-popup-up-icon:hover,
.e-tab .e-tab-header .e-hor-nav .e-popup-down-icon:hover {
    background: #d1f6d1 !important;
}

```

## Customizing selected item of Tabs control

Use the following CSS to customize the selected tab item.

```CSS

.e-tab .e-tab-header .e-toolbar-item.e-active {
    background: #d1f4d1;
}

```

Use the following CSS to customize the selected tab item text and icon.

```CSS

.e-tab .e-tab-header .e-toolbar-item.e-active .e-tab-text,
.e-tab .e-tab-header .e-toolbar-item.e-active .e-tab-icon {
    color: green !important;
}

```