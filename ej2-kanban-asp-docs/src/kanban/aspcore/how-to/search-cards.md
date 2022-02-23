---
title: "Searching Cards"
component: "Kanban"
description: "This article demonstrates how to show the cards in Kanban board when you type or search the text in the textbox."
---

# Searching Cards

You can search the cards in Kanban by using the `query` property.

In the following sample, the searching operation starts as soon as you start typing characters in the external text box. It will search the cards based on the `Id` and `Summary` using the `search` query with `contains` operator.

{% aspTab template="kanban/how-to/search-cards", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/search-cards.PNG)
