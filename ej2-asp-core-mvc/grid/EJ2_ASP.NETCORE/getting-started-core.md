---
layout: post
title: Getting Started with ##Platform_Name## Grid Component
description: Checkout and learn about getting started with ##Platform_Name## Grid component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get started with ASP.NET Core application, need to ensure the following software to be installed on the machine.
* Visual Studio 2017
* DotNet Core 2.0

## Create ASP.NET Core application

Create ASP.NET Core Web Application with default template project in Visual Studio 2017.

![Alt text](./images/default-template.png)

## Adding Syncfusion package

Using Nuget Package Manager we need to add **Syncfusion.EJ2.AspNet.Core** package into your application.

Open the `NuGet` package manager.

![Alt text](./images/solution-explorer-core.png)

Install the **Syncfusion.EJ2.AspNet.Core** package to the application

![Alt text](./images/nuget-package-demo.png)

After Installation completed the Syncfusion DLL's will be included in the project.

> We need to install **NewtonSoft.JSON** as dependency since **Syncfusion.EJ2.AspNet.Core** dependent to NewtonSoft.JSON package.

Open the **Views/_ViewImports.cshtml** to import Syncfusion.EJ2.AspNet.Core package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

## Adding Scripts and CSS reference

We can add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or NPM [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **Views/Shared/_Layout.cshtml.**

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

Install `@syncfusion/ej2` package using below command.

> npm install @syncfusion/ej2

Now the required scripts and CSS files are available in the **../node_modules/@syncfusion/ej2/dist** and CSS **../node_modules/@syncfusion/ej2/styles** package folders respectively. Copy those script and themes files from the `node_modules` into the `wwwroot` folder of the application.

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link href="~/styles/material.css" rel="stylesheet" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="~/scripts/ej2.min.js"></script>
</head>
```

## Adding ScriptManager in layout page

Add `ScriptManager` to the bottom of the `_Layout.cshtml` page. The ScriptManager used to place our control initialization script in the page.

```cs
<body>
    @RenderBody()
    @RenderSection("Scripts", required: false)
<ejs-scripts></ejs-scripts>
</body>
```

## Add Grid Component

To initialize the Grid component add the below code to your `Index.cshtml` view page which is present under `Views/Home` folder.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-core/grid/tagHelper %}
{% endhighlight %}
{% highlight cshtml tabtitle="Grid.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="Grid.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Defining Row Data

To bind data for the Grid component, you can assign a IEnumerable object to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. The list data source can also be provided as an instance of the `DataManager`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-core/databinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/databinding/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/databinding/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Defining Columns

The columns are automatically generated when `columns` declaration is empty or undefined while initializing the grid.

The Grid has an option to define columns using [`e-grid-columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) tag helper. In `e-grid-column` tag helper we have properties to customize columns.

Let’s check the properties used here:

* We have added [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) to map with a property name an array of JavaScript objects.
* We have added [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) to change the title of columns.
* We have used [`textAlign`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_TextAlign) to change the alignment of columns.
By default, columns will be left aligned. To change columns to right align, we need to define `textAlign` as `Right`.
* Also, we have used another useful property, [format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format).
Using this, we can format number and date values to standard or custom formats.
Here, we have defined it for the conversion of numeric values to currency.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-core/gridcolumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/gridcolumns/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/gridcolumns/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Paging

The paging feature enables users to view the grid record in a paged view. It can be enabled by setting the  [`allowPaging`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowPaging) property to true. Pager can be customized using [`e-grid-pagesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PageSettings) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-core/page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/page/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/page/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Sorting

The sorting feature enables you to order the records. It can be enabled by setting the  [`allowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property as true. Sorting feature can be customized using [`e-grid-sortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_SortSettings) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-core/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/sorting/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/sorting/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Filtering

The filtering feature enables you to view reduced amount of records based on filter criteria. It can be enabled by setting the [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) property as true. Filtering feature can be customized using [`e-grid-filtersettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_FilterSettings) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-core/filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/filtering/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/filtering/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Grouping

The grouping feature enables users to view the grid record in a grouped view. It can be enabled by setting the
 [`allowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) property to true.
 Grouping feature can be customized using the [`e-grid-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_GroupSettings) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-core/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/grouping/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-core/grouping/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](./images/grid-sample.png)