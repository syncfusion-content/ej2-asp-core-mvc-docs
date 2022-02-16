---
layout: post
title: Style in ##Platform_Name## Listview Component
description: Learn here all about Style in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---


# CSS Structure

The following content provides the exact CSS structure that can be used to modify the control’s appearance based on  user preference.

## Customizing ListView

Use the following CSS to customize the ListView.

```CSS

.e-listview {
    border: 5px solid rgb(173, 255, 47);
}

```

## Customizing the list items

Use the following CSS to customize the items of ListView.

```CSS

.e-listview .e-list-item {
    text-align: center;
    color: pink;
    background-color: #2fa1ff;
}

```

## Customizing ListView's header

Use the following CSS to customize the header of ListView control.

```CSS

.e-listview .e-list-header{
    color: #2fa1ff;
    justify-content: center;
}

```

## Customizing group header of ListView

Use the following CSS to customize the category of the group items.

```CSS

.e-listview .e-list-group-item {
    color: rgb(173, 255, 47);
    background-color: maroon;
    text-align: end;
}

```

## Customizing the hover state of ListView control

Use the following CSS to customize the list item when hovering.

### Customizing ListView hover state with the checkbox checked

```CSS

.e-listview .e-list-item.e-hover.e-active.e-checklist {
    color: rgb(83, 5, 79);
    background-color: rgb(173, 255, 47);
}

```

### Customizing ListView hover state

```CSS

.e-listview .e-list-item.e-hover {
    color:red;
    background-color: rgb(173, 255, 47);
}

```

## Customizing selected item of ListView control

Use the following CSS to customize the selected list item.

### Customizing ListView's selected item with the checkbox checked

```CSS

.e-listview .e-list-item.e-checklist.e-focused.e-active {
    color: rgb(83, 5, 79);
    background-color: rgb(0, 15, 100);
}

```

### Customizing ListView's selected item

```CSS

.e-listview .e-list-item.e-focused {
    color: #2fa1ff;
    background-color: rgb(0, 15, 100);
}

```