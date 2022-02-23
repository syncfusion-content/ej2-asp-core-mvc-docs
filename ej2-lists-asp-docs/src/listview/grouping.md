---
title: "ListView Grouping"
component: "ListView"
description: "ListView component supports grouping feature that helps group the logically related items under a category."
---

# Grouping

The ListView supports to wrap the nested element into a group based on the category. The category of each list item can be mapped with groupBy field in the data table, that also supports single-level navigation.

In the following sample, The cars are grouped based on its category by using the groupBy field.

{% aspTab template="listview/grouping", sourceFiles="ListController.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core ListView - Grouping](./images/grouping.png)

## Customization

The grouping header can be customized by using the groupTemplate property for both inline and fixed group header. The complete customization description and explanation with an example is given in the following link.

[ASP .NET Core ListView - Group Template](./customizing-templates#group-template).