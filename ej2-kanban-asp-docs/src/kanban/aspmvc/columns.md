---
title: "Columns in Kanban board"
component: "Kanban"
description: "This section explains how to create a columns in Kanban board with header template, toggle columns and validation."
---

# Columns in Kanban Board

The **Kanban** columns represent the each stage of the process. The column definitions are used as the **DataSource** schema in the Kanban. The Kanban operations such as drag-and-drop, swimlane, and toggle columns are performed based on column definitions.

## Single-key mapping

Kanban columns are categorized by mapping the **Key** from the datasource using the `KeyField` property. The corresponding **Value** in the datasource is mapped inside the columns `KeyField`.  Based on this categorization, Kanban columns are split on this board.

> The `KeyField` property is mandatory to render the columns in the Kanban board.

{% aspTab template="kanban/columns/single-key", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/singel-key.PNG)

## Multi-key mapping

Kanban board allows to render a single column by mapping multiple keys using `KeyField` property. In below sample, specified the multiple keys(Open, Validate) to a single column.

{% aspTab template="kanban/columns/multi-key", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/multi-key.PNG)

## Header text

You can provide the column header text of Kanban columns using the `HeaderText` property. If you have not specified any header text, it will render the header without any text.

## Header template

You can customize the column header with any HTML or CSS element using the `Template` property as shown in the following code.

You can get the following columns data when using header template.

* keyField
* headerText
* minCount
* maxCount
* allowToggle
* isExpanded
* showItemCount
* count

{% aspTab template="kanban/columns/header-template", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/header-template.PNG)

## Toggle columns

Kanban allows to expand or collapse its columns using `AllowToggle` inside the `Columns` property. When enable the property, it will render the expand or collapse icon to the column header.

> By default, collapsed column width is set to `50px`.

{% aspTab template="kanban/columns/toggle-columns", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/toggle-columns.PNG)

### Initially collapsed column

By default, all columns are on expanded state when loading the Kanban board initially. But, you can render the columns with collapsed state using the `IsExpanded` property.

>The `IsExpanded` property only works when enabling the `AllowToggle` property on particular column.

In the following example, the To Do column is collapsed on initialization of Kanban board.

{% aspTab template="kanban/columns/initially-collapsed", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/initially-collapsed.PNG)

## Stacked headers

Stacked headers are the additional headers to column header that will group the similar columns.

Define the grouping of columns **Key** value to the `KeyFields` property and provide the custom header text name to grouped columns using the `Text` property, which is placed inside the `StackedHeaders` property.

In the following code, the kanban columns 'InProgress, Review' are grouped under 'Development phase' category.

{% aspTab template="kanban/columns/stacked-headers", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/stacked-header.PNG)