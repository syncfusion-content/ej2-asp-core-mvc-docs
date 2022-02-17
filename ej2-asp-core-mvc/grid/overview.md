---
layout: post
title: Overview in ##Platform_Name## Grid Component
description: Learn here all about Overview in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Index
publishingplatform: ##Platform_Name##
documentation: ug
---


# Overview

The Grid component is used to display and manipulate tabular data with configuration options to control the way the data is presented. It can pull data from data sources such as array of JavaScript objects, `OData web services`, or `DataManager` and binding data fields to columns. It also displays the column header to identify the field with support for grouped records.

The most important features available in the grid component are paging, sorting, filtering, searching, and grouping.

## Key Features

* [**Data sources**](./data-binding/): Binds the grid component with an array of JavaScript objects or DataManager.
* [**Sorting**](./sorting/) and [**grouping**](./grouping/): Supports **n** level of sorting and grouping.
* [**Filtering**](./filtering/): Offers filter bar in each column to filter data.
* [**Paging**](./paging/): Allows easy switching between pages using the pager bar.
* [**Editing**](./edit/):provides the options for create, read, update, and delete operations.
* [**Columns**](./columns/):The column definitions are used as the dataSource schema in the Grid. This plays a vital role in rendering column values in the required format.
    * [**Reordering**](./columns/#reorder): Allows drag and drop of any column anywhere in the grid’s column header row, thus allowing repositioning of columns.
    * [**Column Chooser**](./columns/#column-chooser):The column chooser provides a list of column names paired with check boxes that allow the visibility to be toggled on the fly.
    * [**Resizing**](./columns/#column-resizing):Resizing allows changing column width on the fly by simply dragging the right corner of the column header.
    * [**Freeze**](./scrolling/#frozen-rows-and-columns):Columns and rows can be frozen to allow scrolling and comparing cell values.
    * [**Cell Spanning**](./columns/#column-spanning):Grid cells can be spanned based on the preferred criteria.
    * [**Foreign data source**](./columns/#foreign-key-column):This provides the option to show values from external or lookup data sources in a column based on foreign key/value mapping.
    * [**Cell Styling**](./how-to/#customize-column-styles):Grid cell styles can be customized either by using CSS or programmatically.
* [**Selection**](./selection/):Rows or cells can be selected in the grid. One or more rows or cells can also be selected by holding Ctrl or Command, or programmatically.
* [**Templates**](./columns/#column-template) - Templates can be used to create custom user experiences in the grid.
* [**Aggregation**](./aggregates/) - Provides the option to easily visualized the Aggregates for column values.
* [**Context menu**](./context-menu/) -The context menu provides a list of actions to be performed in the grid. It appears when a cell, header, or the pager is right-clicked.
* [**Clipboard**](./clipboard/) - Selected rows and cells can be copied from the grid
* [**Export**](./pdf-export/) - Provides the options to Export the grid data to Excel, PDF, and CSV formats.
* [**RTL support**](./global-local/#right-to-left-rtl): Provides right-to-left mode that aligns the grid content from right to left.
* [**Localization**](./global-local/#localization): Provides an inherent support to localize the UI.