---
layout: post
title: Getting Started with ##Platform_Name## Tree Grid Component
description: Checkout and learn about getting started with ##Platform_Name## Tree Grid component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get start with ASP.NET Core application, need to ensure the following software to be installed on the machine.
* Visual Studio 2017
* DotNet Core 2.0

## Create ASP.NET Core application

Create ASP.NET Core Web Application with default template project in Visual Studio 2017.

![Alt text](./images/default-template.png)

## Adding Syncfusion package

Using Nuget Package Manager you need to add **Syncfusion.EJ2.AspNet.Core** package into your application.

Open the `NuGet` package manager.

![Alt text](./images/solution-explorer-core.png)

Install the **Syncfusion.EJ2.AspNet.Core** package to the application

![Alt text](./images/nuget-package-demo.png)

After Installation completed the Syncfusion DLL's will be included in the project.

> You need to install **NewtonSoft.JSON** as dependency since **Syncfusion.EJ2.AspNet.Core** dependent to NewtonSoft.JSON package.

Open the **Views/_ViewImports.cshtml** to import Syncfusion.EJ2.AspNet.Core package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

## Adding Scripts and CSS reference

You can add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or NPM [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **Views/Shared/_Layout.cshtml.**

CDN Link:

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>
```

NPM Package:

Install **@syncfusion/ej2** package using below command.

> npm install @syncfusion/ej2

Now the required scripts and CSS files are available in the **../node_modules/@syncfusion/ej2/dist** and CSS **../node_modules/@syncfusion/ej2/styles** package folders respectively. Copy those script and themes files from the **node_modules** into the **wwwroot** folder of the application.

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link href="~/styles/material.css" rel="stylesheet" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="~/scripts/ej2.min.js"></script>
</head>
```

## Adding ScriptManager in layout page

Add **ScriptManager** to the bottom of the **_Layout.cshtml** page. The ScriptManager used to place our control initialization script in the page.

```cs
<body>
    @RenderBody()
    @RenderSection("Scripts", required: false)
<ejs-scripts></ejs-scripts>
</body>
```

## Add TreeGrid Component

To initialize the TreeGrid component add the below code to your **Index.cshtml** view page which is present under **Views/Home** folder.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/tree-grid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tree-grid.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Tree-grid.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Defining Row Data

To bind data for the TreeGrid component, you can assign a IEnumerable object to the [`dataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) property. The list data source can also be provided as an instance of the **DataManager**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/databinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/databinding/page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/databinding/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> [`childMapping`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ChildMapping.html) specifies the mapping property path for subtasks in dataSource.
> [`treeColumnIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~TreeColumnIndex.html) specifies the index of the column that needs to have the expander button.

## Defining Columns

The columns are automatically generated when columns declaration is empty or undefined while initializing the treegrid.

The TreeGrid has an option to define columns using [`e-treegrid-columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumns.html) tag helper. In [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper you have properties to customize columns.

Let’s check the properties used here:

* The [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) property is to map with a property name an array of JavaScript objects.
* The [`headerText`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) property is to change the title of columns.
* The [`textAlign`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~TextAlign.html) property is to change the alignment of columns.
By default, columns will be left aligned. To change columns to right align, you need to define **textAlign** as **Right**.
* Using [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property
you can format number and date values to standard or custom formats.
Here, you have defined it for the conversion of numeric values to currency.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/columns/page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/columns/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Paging

The paging feature enables users to view the treegrid record in a paged view. It can be enabled by setting the  [`allowPaging`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowPaging.html) property to true. Pager can be customized using [`e-treegrid-pagesettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/page/page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/page/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Sorting

The sorting feature enables you to order the records. It can be enabled by setting the  [`allowSorting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowSorting.html) property as true. Sorting feature can be customized using [`e-treegrid-sortsettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSortSettings.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/tree-grid/getting-start-core/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/tree-grid/getting-start-core/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Filtering

The filtering feature enables you to view reduced amount of records based on filter criteria. It can be enabled by setting the [`allowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) property as true. Filtering feature can be customized using [`e-treegrid-filtersettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html) tag helper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/tree-grid/getting-start-core/filtering/filtering.cs %}
{% endhighlight %}
{% endtabs %}

Output be like the below.

![TreeGrid Sample Output](./images/treegrid-sample.png)

> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.