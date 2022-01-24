---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Swimlane of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Swimlane
publishingplatform: ##Platform_Name##
documentation: ug
---


# Swimlane

Swimlanes are horizontal categorizations of cards on the Kanban board.  It is used for grouping of cards, which brings transparency to the workflow process.

## Render swimlane row

Cards can be grouped based on `keyField` and displayed in rows, which are separated by columns. It is mandatory to define the `keyField` that is mapped from the datasource for rendering swimlane rows in the Kanban board.

{% aspTab template="kanban/swimlane/swimlane-row", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/swimlane-row.PNG)

## Custom row text

Customize the swimlane row header text by using the `textField` property mapped from datasource.

> It is not mandatory to define the `textField` to `swimlaneSettings`.  It will automatically consider the `keyField` to swimlane row header text.
> If the mapping `textField` key is not present in the datasource, it will consider the swimlane `keyField` as swimlane row header text.

{% aspTab template="kanban/swimlane/custom-row", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

## Template

You can customize the Kanban swimlane row by using the `template` property, which is specified within the `swimlaneSettings` property. In this demo, the swimlane header is customized with HTML element.

{% aspTab template="kanban/swimlane/template", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/template.PNG)

## Sorting

Swimlane rows are rendered on descending order when using the `sortBy` property set to `Descending` order. By default, swimlane rows are rendered by **Ascending** order.

{% aspTab template="kanban/swimlane/sorting", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/sorting.PNG)

## Drag-and-drop

By default, The Kanban does not allow dragging the cards across the swimlane rows. Enabling the `dragAndDrop` property allows you to drag the cards across the swimlane rows, which is specified inside `swimlaneSettings` property.

{% aspTab template="kanban/swimlane/drag-and-drop", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

## Create empty row

You can render the empty swimlane row by enabling the `showEmptyRow` property.  If mapping `keyField` does not have cards, empty swimlane row will be rendered.

{% aspTab template="kanban/swimlane/empty-row", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/empty-row.PNG)

## Calculate cards count

Users can show or hide the cards count by swimlane row in header when enabling the `showItemCount` property, which is enabled by default on the Kanban board.

> Provided localization support for **Items** text.

In below demo, disabled on `showItemCount` property on rendering swimlane row without total count.

{% aspTab template="kanban/swimlane/cards-count", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/cards-count.PNG)

## Enable frozen rows

Frozen rows provide an option to make the current swimlane row header text always visible on top of the content while scrolling the Kanban content. The swimlane header text will be changed dynamically, when you scroll to another swimlane row.

By default, the `enableFrozenRows` property is set as `false`. If you wish to show the swimlane frozen rows, you can enable the `enableFrozenRows` property.

> This feature support only when using Kanban content scrolling.

{% aspTab template="kanban/swimlane/frozen-rows", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

![kanban](./images/frozen-rows.png)
