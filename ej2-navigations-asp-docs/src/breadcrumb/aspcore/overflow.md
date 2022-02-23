---
title: "Breadcrumb Overflow-Mode"
component: "Breadcrumb"
description: "Typescript Breadcrumb supports "
---

# Overflow Mode in breadcrumb

## Overflow Mode

In the Breadcrumb component, `maxItems` and `overflowMode` properties were used to limit the number of breadcrumb items to be displayed.

The following overflow modes are available in the Breadcrumb component.

`Default` - Specified maxItems count will be visible and the remaining items will be hidden. While clicking on the previous item, the hidden item will become visible.

`Collapsed` - Only the first and last items will be visible, and the remaining items will be hidden in the collapsed icon. When the collapsed icon is clicked, all items will become visible.

In the following example, the maxItems is set as 3 with overflowMode as Default. To prevent breadcrumb item navigation, the `enableNavigation` property has been set to false in the Breadcrumb component.

{% aspTab template="breadcrumb/overflow", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/overflow.PNG)