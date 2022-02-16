---
layout: post
title: Getting Started with ##Platform_Name## Grid Component
description: Checkout and learn about getting started with ##Platform_Name## Grid component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Create ASP.NET MVC application

Create ASP.NET MVC Application with default template project in Visual Studio 2017.

![Default Template](./images/default-template-mvc.png)

## Adding Syncfusion package

Once your project created, we need to add Syncfusion EJ2 MVC package into your application by using **NuGet Package Manager**.

Open the **NuGet** package manager.

![Solution Explorer](./images/solution-explorer-mvc.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo-mvc.png)

After Installation completed the Syncfusion DLL's will be included in the project.

> You need to install **NewtonSoft.JSON** as dependency since **Syncfusion.EJ2.MVC** dependent to NewtonSoft.JSON package.

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

![Nuget Demo](./images/script-nuget.jpg)

After Installation completed the script and CSS will be included in the project under the **Scripts** and **Content** folder.

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link href="~/Content/ej2/material.css" rel="stylesheet" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="~/Scripts/ej2/ej2.min.js"></script>
</head>
```

> **Syncfusion.EJ2.Javascript** includes typescript declaration files. If your application is not configured to compile typescript then exception may occur. To resolve this please refer [`here`](./how-to/avoid-typescript-compilation/).

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

## Add Grid Component

To initialize the Grid component add the below code to your **Index.cshtml** view page which is present under **Views/Home** folder.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/initialize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initialize.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/initialize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initialize.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Defining Row Data

To bind data for the Grid component, you can assign a IEnumerable object to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. The list data source can also be provided as an instance of the **DataManager**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/databinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/databinding/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/databinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/databinding/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Defining Columns

The columns are automatically generated when columns declaration is empty or undefined while initializing the grid.

The Grid has an option to define columns using [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) property.

Let’s check the properties used here:

* The [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property is to map with a property name an array of JavaScript objects.
* The [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) property is to change the title of columns.
* The [`TextAlign`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_TextAlign) property is to change the alignment of columns.
By default, columns will be left aligned. To change columns to right align, you need to define **textAlign** as **Right**.
* Using [Format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format) property
you can format number and date values to standard or custom formats.
Here, you have defined it for the conversion of numeric values to currency.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/columns/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/columns/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Paging

The paging feature enables users to view the grid record in a paged view. It can be enabled by setting the  [`AllowPaging`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowPaging) property to true. Pager can be customized using the [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/page/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/page/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Sorting

The sorting feature enables you to order the records. It can be enabled by setting the  [`AllowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property as true. Sorting feature can be customized using the [`SortSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/sorting/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/sorting/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Filtering

The filtering feature enables you to view reduced amount of records based on filter criteria. It can be enabled by setting the [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) property as true. Filtering feature can be customized using the [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/filtering/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/filtering/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Grouping

The grouping feature enables users to view the grid record in a grouped view. It can be enabled by setting the
 [`AllowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) property to true.
 Grouping feature can be customized using the [`GroupSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/grouping/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OrderDetails.cs" %}
{% include code-snippet/grid/getting-start-mvc/grouping/orderDetails.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](./images/grid-sample.png)

## See Also

* [Create an MVC Grid app](https://www.syncfusion.com/blogs/post/create-an-mvc-grid-app-in-10-minutes-with-the-syncfusion-grid.aspx)
* [How to render EJ2-Grid as HTML in ASP.NET MVC Grid](https://www.syncfusion.com/forums/137153/how-to-render-ej2-grid-as-html-in-asp-net-mvc-grid)
* [How to render Grid in partial view in ASP.NET MVC Grid](https://www.syncfusion.com/forums/139841/how-to-render-grid-in-partial-view-in-asp-net-mvc-grid)