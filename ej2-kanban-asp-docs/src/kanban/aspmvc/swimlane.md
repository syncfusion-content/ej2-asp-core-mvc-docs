---
title: "Swimlane rows in Kanban board"
component: "Kanban"
description: "This section explains how to grouping of cards with swimlane rows, template, sorting, swimlane across drag and drop and show empty rows."
---

# Swimlane

Swimlanes are horizontal categorizations of cards on the Kanban board.  It is used for grouping of cards, which brings transparency to the workflow process.

## Render swimlane row

Cards can be grouped based on `KeyField` and displayed in rows, which are separated by columns. It is mandatory to define the `KeyField` that is mapped from the datasource for rendering swimlane rows in the Kanban board.

{% aspTab template="kanban/swimlane/swimlane-row", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/swimlane-row.PNG)

## Custom row text

Customize the swimlane row header text by using the `TextField` property mapped from datasource.

> It is not mandatory to define the `TextField` to `SwimlaneSettings`.  It will automatically consider the `KeyField` to swimlane row header text.
> If the mapping `TextField` key is not present in the datasource, it will consider the swimlane `KeyField` as swimlane row header text.

{% aspTab template="kanban/swimlane/custom-row", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

## Template

You can customize the Kanban swimlane row by using the `Template` property, which is specified within the `SwimlaneSettings` property. In this demo, the swimlane header is customized with HTML element.

{% aspTab template="kanban/swimlane/template", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/template.PNG)

## Sorting

Swimlane rows are rendered on descending order when using the `SortBy` property set to `Descending` order. By default, swimlane rows are rendered by **Ascending** order.

{% aspTab template="kanban/swimlane/sorting", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/sorting.PNG)

## Drag-and-drop

By default, The Kanban does not allow dragging the cards across the swimlane rows. Enabling the `DragAndDrop` property allows you to drag the cards across the swimlane rows, which is specified inside `SwimlaneSettings` property.

{% aspTab template="kanban/swimlane/drag-and-drop", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

## Create empty row

You can render the empty swimlane row by enabling the `ShowEmptyRow` property.  If mapping `KeyField` does not have cards, empty swimlane row will be rendered.

{% aspTab template="kanban/swimlane/empty-row", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/empty-row.PNG)

## Calculate cards count

Users can show or hide the cards count by swimlane row in header when enabling the `ShowItemCount` property, which is enabled by default on the Kanban board.

> Provided localization support for **Items** text.

In below demo, disabled on `ShowItemCount` property on rendering swimlane row without total count.

{% aspTab template="kanban/swimlane/cards-count", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/cards-count.PNG)

## Enable frozen rows

Frozen rows provide an option to make the current swimlane row header text always visible on top of the content while scrolling the Kanban content. The swimlane header text will be changed dynamically, when you scroll to another swimlane row.

By default, the `EnableFrozenRows` property is set as `false`. If you wish to show the swimlane frozen rows, you can enable the `EnableFrozenRows` property.

> This feature support only when using Kanban content scrolling.

{% aspTab template="kanban/swimlane/frozen-rows", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/frozen-rows.png)
