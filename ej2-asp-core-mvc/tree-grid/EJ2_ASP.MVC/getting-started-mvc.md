---
layout: post
title: Getting Started with ##Platform_Name## Tree Grid Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Tree Grid control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Tree Grid Control

This section briefly explains about how to include [ASP.NET MVC Tree Grid](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

N> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager `EJS().ScriptManager()` at the end of `<body>` in the ASP.NET MVC application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Tree Grid control

Now, add the Syncfusion ASP.NET MVC Tree Grid control in `~/Views/Home/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Initialize.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-mvc/initialize/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Defining Row Data

To bind data for the TreeGrid component, you can assign a IEnumerable object to the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DataSource) property. The list data source can also be provided as an instance of the **DataManager**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/databinding/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-mvc/databinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/databinding/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


N> [ChildMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ChildMapping) specifies the mapping property path for subtasks in dataSource.
<br/> [TreeColumnIndex](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_TreeColumnIndex) specifies the index of the column that needs to have the expander button.

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Tree Grid control will be rendered in the default web browser.

![ASP.NET MVC Tree Grid Row](images/treegrid-control.png)

## Defining Columns

The columns are automatically generated when columns declaration is empty or undefined while initializing the treegrid.

The TreeGrid has an option to define columns using [Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Columns) property. In `Column` property you have properties to customize columns.

Let’s check the properties used here:

* The [Field](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Field) property is to map with a property name an array of JavaScript objects.
* The [HeaderText](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_HeaderText) property is to change the title of columns.
* The [TextAlign](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_TextAlign) property is to change the alignment of columns. By default, columns will be left aligned. To change columns to right align, you need to define **textAlign** as **Right**.
* Using [Format](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Format) property, you can format number and date values to standard or custom formats. Here, you have defined it for the conversion of numeric values to currency.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columns.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/columns/columns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-mvc/columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/columns/columns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Tree Grid Columns](images/treegrid-columns.png)

## Enable Paging

The paging feature enables users to view the treegrid record in a paged view. It can be enabled by setting the  [AllowPaging](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_AllowPaging) property to true. Pager can be customized using [PageSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_PageSettings) property.

In root-level paging mode, paging is based on the root-level rows only, i.e., it ignores the child row count and it can be enabled by using the [PageSizeMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridPageSettings.html#Syncfusion_EJ2_TreeGrid_TreeGridPageSettings_PageSizeMode) property of [PageSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_PageSettings).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/page/page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-mvc/page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/page/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Tree Grid with Paging](images/treegrid-with-paging.png)

## Enable Sorting

The sorting feature enables you to order the records. It can be enabled by setting the [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_AllowSorting) property as true. Sorting feature can be customized using [SortSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_SortSettings) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-mvc/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Tree Grid with Sorting](images/treegrid-sorting.png)

## Enable Filtering

The filtering feature enables you to view reduced amount of records based on filter criteria. It can be enabled by setting the [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_AllowFiltering) property as true. Filtering feature can be customized using [FilterSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_FilterSettings) property.

By default, filtered records are shown along with its parent records. This behavior can be changed by using the [HierarchyMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html#Syncfusion_EJ2_TreeGrid_TreeGridFilterSettings_HierarchyMode) property of [FilterSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_FilterSettings).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/filtering/filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-mvc/filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/filtering/filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Tree Grid with Filtering](images/treegrid-sample.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/TreeGrid/ASP.NET%20MVC%20Razor%20Examples).

N> You can refer to our [ASP.NET MVC Tree Grid](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Tree Grid example](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.