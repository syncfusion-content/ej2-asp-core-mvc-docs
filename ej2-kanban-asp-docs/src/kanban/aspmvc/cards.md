---
title: "Cards in Kanban"
component: "Kanban"
description: "This article demonstrates how to use the cards in Kanban board and demonstrate and customize the card layout."
---

# Cards

The cards are main elements in Kanban board, which represent the task information with header and content. The header and content of a card is fetched from the corresponding mapping fields. The card layout can be customized with template also.

## Drag-and-drop

Transit or change the card position using the drag-and-drop functionality. By default, the `AllowDragAndDrop` property is enabled on the Kanban board, which is used to change the card position by column-to-column or within the column.

Added dotted border on Kanban cells except the dragged clone cells when dragging, which indicates the possible ways for dropping the cards into the cells.

## Header

The card header is achieved by mapping the `HeaderField` property, which is placed inside the `CardSettings` property. By default, the `ShowHeader` property enabled by Kanban board that is used to show the header at the top of the card.

> The `HeaderField` property of `CardSettings` is mandatory to render the cards in the Kanban board. It acts as a unique field that is used to avoid the duplication of card data. You can not change the `HeaderField` of mapped data value using the `updateCard` public method or server-side update of data.

In the following demo, the `ShowHeader` property is disabled on Kanban board.

{% aspTab template="kanban/cards/header", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/header.PNG)

## Content

The card's content is fetched from data source using the `ContentField` property, which is placed inside the `CardSettings` property. If the `ContentField` property is not used, card is rendered with empty content.

## Template

You can customize the default card layout using template as per your application needs. This can be achieved by template of the `CardSettings` property.

{% aspTab template="kanban/cards/template", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/card-template.PNG)

## Selection

Kanban board allows to select single and multiple selection of cards when mouse or keyboard interactions using `SelectionType` property. The property contains following types.

* **None**: No cards are allowed to select from Kanban board.
* **Single**: Only one card allowed to select at a time in the Kanban board.
* **Multiple**: Multiple cards are allowed to select in a board.

### Multiple Selection

Select the multiple cards randomly using Ctrl + mouse click and select the multiple cards continuously using Shift + mouse click action on Kanban board. Set `Multiple` in `SelectionType` to enable the multiple selection in a board.

{% aspTab template="kanban/cards/multiple-selection", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/multiple-selection.PNG)
