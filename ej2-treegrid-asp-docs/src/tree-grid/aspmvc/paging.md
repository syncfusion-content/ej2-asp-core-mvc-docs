---
title: "Paging"
component: "TreeGrid"
description: "Learn how to add and customize the pager in the Essential JS 2 TreeGrid control."
---

# Paging

Paging provides an option to display TreeGrid data in page segments. To enable paging, set the [`AllowPaging`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowPaging.html) to true. When paging is enabled, pager component renders at the bottom of the treegrid.
Paging options can be configured through the [`PageSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~PageSettings.html).

{% aspTab template="tree-grid/paging/default-paging", sourceFiles="defaultPaging.cs" %}

{% endaspTab %}

> You can achieve better performance by using treegrid paging to fetch only a pre-defined number of records from the data source.

## Page Size Mode

Two behaviour are available in TreeGrid paging to display certain number of records in a current page. Following are the two types of [`PageSizeMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSizeMode.html) property of [`PageSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings.html).

* **All** : This is the default mode. The number of records in a page is based on [`PageSize`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSize.html) property.
* **Root** : The number of root nodes or the 0th level records to be displayed per page is based on [`PageSize`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSize.html) property.

With [`PageSizeMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSizeMode.html) property as **Root**, only the root level or the 0th level records are considered in records count.

{% aspTab template="tree-grid/paging/page-mode", sourceFiles="pageMode.cs" %}

{% endaspTab %}

## Template

You can use custom elements inside the pager instead of default elements.
The custom elements can be defined by using the [`Template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~Template.html) property.
Inside this template, you can access the [`CurrentPage`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~CurrentPage.html), [`PageSize`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSize.html), [`PageCount`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageCount.html), **TotalPage** and **TotalRecordCount** values.

{% aspTab template="tree-grid/paging/pager-template", sourceFiles="pagerTemplate.cs" %}

{% endaspTab %}

## Pager with Page Size Dropdown

The pager Dropdown allows you to change the number of records in the TreeGrid dynamically. It can be enabled by defining the [`PageSizes`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSizes.html) property of [`PageSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings.html) as **true**.

{% aspTab template="tree-grid/paging/page-sizes", sourceFiles="pageSizes.cs" %}

{% endaspTab %}

![Page size dropdown](images/pagesizes.png)

## How to render Pager at the Top of the TreeGrid

By default, Pager will be rendered at the bottom of the TreeGrid. You can also render the Pager at the top of the TreeGrid by using the [`DataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataBound.html) event.

{% aspTab template="tree-grid/paging/customize", sourceFiles="customize.cs" %}

{% endaspTab %}

> During the paging action, the pager component triggers the below three events.
> The **created** event triggers when Pager is created.
> The **click** event triggers when the numeric items in the pager is clicked.
> The **dropDownChanged** event triggers when pageSize DropDownList value is selected.
> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.