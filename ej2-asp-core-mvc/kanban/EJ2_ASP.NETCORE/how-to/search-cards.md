---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Search Cards of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Search Cards
publishingplatform: ##Platform_Name##
documentation: ug
---


# Searching Cards

You can search the cards in Kanban by using the `query` property.

In the following sample, the searching operation starts as soon as you start typing characters in the external text box. It will search the cards based on the `Id` and `Summary` using the `search` query with `contains` operator.

{% aspTab template="kanban/how-to/search-cards", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/search-cards.PNG)
