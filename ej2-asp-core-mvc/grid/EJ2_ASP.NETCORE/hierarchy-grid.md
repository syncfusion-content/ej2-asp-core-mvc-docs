---
layout: post
title: Hierarchy grid in ##Platform_Name## Grid Component
description: Learn here all about Hierarchy grid in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Hierarchy grid
publishingplatform: ##Platform_Name##
documentation: ug
---

# Hierarchy grid in ASP.NET Core Grid component

The Hierarchy Grid in an ASP.NET Core Grid component is typically used when you need to display hierarchical data in a tabular format with expandable and collapsible rows. It allows you to represent parent and child relationships within the grid, making it easier for you to navigate and understand the data.

This feature can be enabled by utilizing the [childGrid](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ChildGrid) and [childGrid.queryString](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryString) properties of the grid component.

To enable the Hierarchy Grid feature:

1. Define the `childGrid` property within the Grid component configuration. This property describes the options of the child grid.

2. Specify the `childGrid.queryString` property to establish the relation between the parent and child grids and visualizes the data in a hierarchical structure. This property determines how the child records are fetched based on the parent record.

The following example demonstrates how to enable the hierarchy feature in the grid

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/hierarchy-grid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/hierarchy-grid/html.cs %}
{% endhighlight %}
{% endtabs %}

![Hierarchy grid](../images/hierarchy-grid/hierarchy-grid.png)

> * Grid supports n level of child grids.
> * Hierarchical binding is not supported when [DetailTemplate](https://ej2.syncfusion.com/aspnetcore/documentation/grid/row/detail-template) is enabled.
> * In Syncfusion Grid component, searching operates independently for parent and child grids. Searching within the parent grid filters only parent records, and similarly, searching within the child grid filters only child records. The component does not support simultaneous searching across both parent and child grids.

## Bind hierarchy grid with different field

By default, the parent and child grids have the same field name to map and render a hierarchical grid. However, the component supports establishing a parent-child relationship between grids with different field names. This feature is beneficial when you want to create a parent-child relationship between grids but need to use distinct field names for mapping the data. As a result, you can easily establish the desired relationship between the parent and child grids, even with different field names for data mapping.

By default, the parent and child grid relation is maintained using the [queryString](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryString) property, which requires the same field name for both grids. However, to achieve the parent and child relation with different fields, you need to modify the mapping value in the [load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event of child grid. 

In the following example, the `load` event is utilized to customize the mapping value for the child grid. By accessing the `parentDetails` property and its **parentKeyFieldValue**, you can set the desired mapping value. The `parentRowData` property contains the data of the parent row, and by using the **EmployeeID** field name, you can extract the corresponding value from the parent row data.