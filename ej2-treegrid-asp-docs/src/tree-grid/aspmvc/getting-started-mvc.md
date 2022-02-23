---
title: "Getting Started"
component: "TreeGrid"
description: "Learn how to create an Essential JS 2 TreeGrid control and enable features like paging, sorting, filtering in ASP.NET MVC."
---

# Getting Started with ASP.NET MVC

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our components.

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Create ASP.NET MVC application

Create ASP.NET MVC Application with default template project in Visual Studio 2017.

![Default Template](./images/default-template-mvc.png)

## Adding Syncfusion package

Once your project created, we need to add Syncfusion EJ2 package into your application by using **NuGet Package Manager**.

Open the **NuGet** package manager.

![Solution Explorer](./images/solution-explorer-mvc.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo.png)

After Installation completed the Syncfusion DLL's will be included in the project.

> You need to install **NewtonSoft.JSON** as dependency since **Syncfusion.EJ2.AspNet.Core** dependent to NewtonSoft.JSON package.

Add **Syncfusion.EJ2** namespace reference in **Web.config** under **Views** folder.

```cs
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>

```

## Adding Scripts and CSS reference

You can add client side resource through **Nuget** package manager or [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) in the layout page **Views/Shared/_Layout.cshtml.**

Nuget Package Manager:

Install the **Syncfusion.EJ2.Javascript** package to the application.

After Installation completed the script and CSS will be included in the project under the **Scripts** and **Content** folder.

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link href="~/Content/ej2/material.css" rel="stylesheet" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="~/Scripts/ej2/ej2.min.js"></script>
</head>
```

> **Syncfusion.EJ2.Javascript** includes typescript declaration files. If your application is not configured to compile typescript then exception may occur.

CDN Link:

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>
```

## Adding ScriptManager in layout page

Add **ScriptManager** to the bottom of the **_Layout.cshtml** page. The ScriptManager used to place our control initialization script in the page.

```cs
@Html.EJS().ScriptManager()
```

## Add TreeGrid Component

To initialize the TreeGrid component add the below code to your **Index.cshtml** view page which is present under **Views/Home** folder.

{% aspTab template="tree-grid/getting-start-mvc/initialize" %}

{% endaspTab %}

## Defining Row Data

To bind data for the TreeGrid component, you can assign a IEnumerable object to the [`DataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) property. The list data source can also be provided as an instance of the **DataManager**.

{% aspTab template="tree-grid/getting-start-mvc/databinding", sourceFiles="data.cs" %}

{% endaspTab %}

> [`ChildMapping`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ChildMapping.html) specifies the mapping property path for subtasks in dataSource.
> [`TreeColumnIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~TreeColumnIndex.html) specifies the index of the column that needs to have the expander button.

## Defining Columns

The columns are automatically generated when columns declaration is empty or undefined while initializing the treegrid.

The TreeGrid has an option to define columns using [`Columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumns.html) property. In [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) property you have properties to customize columns.

Let’s check the properties used here:

* The [`Field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) property is to map with a property name an array of JavaScript objects.
* The [`HeaderText`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) property is to change the title of columns.
* The [`TextAlign`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~TextAlign.html) property is to change the alignment of columns.
By default, columns will be left aligned. To change columns to right align, you need to define **textAlign** as **Right**.
* Using [`Format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property
you can format number and date values to standard or custom formats.
Here, you have defined it for the conversion of numeric values to currency.

{% aspTab template="tree-grid/getting-start-mvc/columns", sourceFiles="columns.cs" %}

{% endaspTab %}

## Enable Paging

The paging feature enables users to view the treegrid record in a paged view. It can be enabled by setting the  [`AllowPaging`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowPaging.html) property to true. Pager can be customized using [`PageSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings.html) property.

In root-level paging mode, paging is based on the root-level rows only, i.e., it ignores the child row count and it can be enabled by using the [`PageSizeMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSizeMode.html) property of [`PageSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings.html).

{% aspTab template="tree-grid/getting-start-mvc/page", sourceFiles="page.cs" %}

{% endaspTab %}

## Enable Sorting

The sorting feature enables you to order the records. It can be enabled by setting the [`AllowSorting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowSorting.html) property as true. Sorting feature can be customized using [`SortSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSortSettings.html) property.

{% aspTab template="tree-grid/getting-start-mvc/sorting", sourceFiles="sorting.cs" %}

{% endaspTab %}

## Enable Filtering

The filtering feature enables you to view reduced amount of records based on filter criteria. It can be enabled by setting the [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) property as true. Filtering feature can be customized using [`FilterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html) property.

By default, filtered records are shown along with its parent records. This behavior can be changed by using the [`HierarchyMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~HierarchyMode.html) property of [`FilterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html).

{% aspTab template="tree-grid/getting-start-mvc/filtering", sourceFiles="filtering.cs" %}

{% endaspTab %}

Output be like the below.

![TreeGrid Sample Demo](./images/treegrid-sample.png)

> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.