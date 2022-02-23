---
title: "Filtering Cards"
component: "Kanban"
description: "This article demonstrates how to filter the collection of cards from the data source and displayed on Kanban board."
---

# Filtering Cards

You can filter the collection of cards from the dataSource and display it on the Kanban board by using the [`query`](../../api/kanban/#query) property.

In the below sample, you can filter the cards based on the ‘where’ query and display the filtered data to the Kanban board.

{% aspTab template="kanban/cards/filter-cards", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/filter-cards.PNG)