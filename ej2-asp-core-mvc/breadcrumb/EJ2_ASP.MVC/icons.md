---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Icons of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Icons
publishingplatform: ##Platform_Name##
documentation: ug
---


# Icons

The Breadcrumb contains an icon/image to provide a visual representation of an item.

## Loading icon in BreadcrumbItem

To load the icon on the breadcrumb item, set the `iconCss` property.

### Breadcrumb with Font Icon

To place the font icon on the breadcrumb item, set the `iconCss` property to `e-icons` with the required icon CSS. By default, the icon is positioned to the left side of the item.

{% aspTab template="breadcrumb/getting-started/items" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/items.PNG)

### Breadcrumb with Image

In the Breadcrumb, images can be added for the items using the `iconCss` property. In the following example, an image was added to the breadcrumb item by using the iconCss class `e-image` and specifying height and width.

{% aspTab template="breadcrumb/icon/image", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/image.PNG)

### Breadcrumb with SVG Image

In the Breadcrumb, SVG image can be added for the items using the `iconCss` property. In the following example, SVG image was added to the breadcrumb item by using the iconCss class `e-image` and specifying height and width.

{% aspTab template="breadcrumb/icon/svg", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/svg.PNG)

## Icon Position

By default, the icon is positioned to the left side of the item in the Breadcrumb. If you need to add the icon right to the breadcrumb item, add the `e-icon-right` class to the required item. In the following example, the `e-icon-right` class was added to the breadcrumb items using the `beforeItemRender` event.

{% aspTab template="breadcrumb/icon/icon-position", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/icons-position.PNG)

## Icon Only

To display only icons for the items, add icons using the `iconCss` property. In the following example, breadcrumb items were demonstrated with only icons by providing the `iconCss` property.

{% aspTab template="breadcrumb/url/icon-only", sourceFiles="default.cs" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/icon-only.PNG)

## Show icon only for first item

To show icon only for the first item in the Breadcrumb, add icons to the first item using the `iconCss` property. In the following example, the icon was provided only for the first item by setting the `iconCss` property.

{% aspTab template="breadcrumb/getting-started/items" %}

{% endaspTab %}

Output be like the below.

![Breadcrumb Sample](./images/items.PNG)