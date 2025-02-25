---
layout: post
title: Getting Started with ##Platform_Name## TreeGrid Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## TreeGrid control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core TreeGrid Control

This section briefly explains about how to include [ASP.NET Core TreeGrid](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.  Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper
Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-script>` at the end of `<body>` in the ASP.NET Core application as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core TreeGrid control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core TreeGrid tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/tree-grid/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Defining Row Data

To bind data for the TreeGrid control, you can assign a IEnumerable object to the [`dataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) property. The list data source can also be provided as an instance of the **DataManager**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/databinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class TreeGridItems
{
    public TreeGridItems() { }
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public int Duration { get; set; }
    public List<TreeGridItems> Children { get; set; }

    public static List<TreeGridItems> GetTreeData()
    {
        List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

        TreeGridItems Record1 = null;

        Record1 = new TreeGridItems()
        {
            TaskId = 1,
            TaskName = "Planning",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5,
            Children = new List<TreeGridItems>(),
        };
        TreeGridItems Child1 = new TreeGridItems()
        {
            TaskId = 2,
            TaskName = "Plan timeline",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };

        TreeGridItems Child2 = new TreeGridItems()
        {
            TaskId = 3,
            TaskName = "Plan budget",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        TreeGridItems Child3 = new TreeGridItems()
        {
            TaskId = 4,
            TaskName = "Allocate resources",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        Record1.Children.Add(Child1);
        Record1.Children.Add(Child2);
        Record1.Children.Add(Child3);
        TreeGridItems Record2 = new TreeGridItems()
        {
            TaskId = 6,
            TaskName = "Design",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3,
            Children = new List<TreeGridItems>()
        };
        TreeGridItems Child5 = new TreeGridItems()
        {
            TaskId = 7,
            TaskName = "Software Specification",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };

        TreeGridItems Child6 = new TreeGridItems()
        {
            TaskId = 8,
            TaskName = "Develop prototype",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };
        TreeGridItems Child7 = new TreeGridItems()
        {
            TaskId = 9,
            TaskName = "Get approval from customer",
            StartDate = new DateTime(2024, 06, 27),
            Duration = 2
        };
        Record2.Children.Add(Child5);
        Record2.Children.Add(Child6);
        Record2.Children.Add(Child7);
        BusinessObjectCollection.Add(Record1);
        BusinessObjectCollection.Add(Record2);
        return BusinessObjectCollection;
    }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core TreeGrid control will be rendered in the default web browser.

![ASP.NET Core TreeGrid Control](images/treegrid-control.png)

N> [`childMapping`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ChildMapping.html) specifies the mapping property path for subtasks in dataSource.
N> [`treeColumnIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~TreeColumnIndex.html) specifies the index of the column that needs to have the expander button.

## Defining Columns

The columns are automatically generated when columns declaration is empty or undefined while initializing the treegrid.

The TreeGrid has an option to define columns using [`e-treegrid-columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumns.html) tag helper. In [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper you have properties to customize columns.

Let’s check the properties used here:

* The [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) property is to map with a property name an array of JavaScript objects.
* The [`headerText`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) property is to change the title of columns.
* The [`textAlign`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~TextAlign.html) property is to change the alignment of columns. By default, columns will be left aligned. To change columns to right align, you need to define **textAlign** as **Right**.
* Using [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property, you can format number and date values to standard or custom formats. Here, you have defined it for the conversion of numeric values to currency.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class TreeGridItems
{
    public TreeGridItems() { }
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public int Duration { get; set; }
    public List<TreeGridItems> Children { get; set; }

    public static List<TreeGridItems> GetTreeData()
    {
        List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

        TreeGridItems Record1 = null;

        Record1 = new TreeGridItems()
        {
            TaskId = 1,
            TaskName = "Planning",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5,
            Children = new List<TreeGridItems>(),
        };
        TreeGridItems Child1 = new TreeGridItems()
        {
            TaskId = 2,
            TaskName = "Plan timeline",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };

        TreeGridItems Child2 = new TreeGridItems()
        {
            TaskId = 3,
            TaskName = "Plan budget",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        TreeGridItems Child3 = new TreeGridItems()
        {
            TaskId = 4,
            TaskName = "Allocate resources",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        Record1.Children.Add(Child1);
        Record1.Children.Add(Child2);
        Record1.Children.Add(Child3);
        TreeGridItems Record2 = new TreeGridItems()
        {
            TaskId = 6,
            TaskName = "Design",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3,
            Children = new List<TreeGridItems>()
        };
        TreeGridItems Child5 = new TreeGridItems()
        {
            TaskId = 7,
            TaskName = "Software Specification",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };

        TreeGridItems Child6 = new TreeGridItems()
        {
            TaskId = 8,
            TaskName = "Develop prototype",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };
        TreeGridItems Child7 = new TreeGridItems()
        {
            TaskId = 9,
            TaskName = "Get approval from customer",
            StartDate = new DateTime(2024, 06, 27),
            Duration = 2
        };
        Record2.Children.Add(Child5);
        Record2.Children.Add(Child6);
        Record2.Children.Add(Child7);
        BusinessObjectCollection.Add(Record1);
        BusinessObjectCollection.Add(Record2);
        return BusinessObjectCollection;
    }
}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core TreeGrid Columns](images/treegrid-columns.png)

## Enable Paging

The paging feature enables users to view the treegrid record in a paged view. It can be enabled by setting the  [`allowPaging`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowPaging.html) property to true. Pager can be customized using [`e-treegrid-pagesettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings.html) tag helper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class TreeGridItems
{
    public TreeGridItems() { }
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public int Duration { get; set; }
    public List<TreeGridItems> Children { get; set; }

    public static List<TreeGridItems> GetTreeData()
    {
        List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

        TreeGridItems Record1 = null;

        Record1 = new TreeGridItems()
        {
            TaskId = 1,
            TaskName = "Planning",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5,
            Children = new List<TreeGridItems>(),
        };
        TreeGridItems Child1 = new TreeGridItems()
        {
            TaskId = 2,
            TaskName = "Plan timeline",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };

        TreeGridItems Child2 = new TreeGridItems()
        {
            TaskId = 3,
            TaskName = "Plan budget",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        TreeGridItems Child3 = new TreeGridItems()
        {
            TaskId = 4,
            TaskName = "Allocate resources",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        Record1.Children.Add(Child1);
        Record1.Children.Add(Child2);
        Record1.Children.Add(Child3);
        TreeGridItems Record2 = new TreeGridItems()
        {
            TaskId = 6,
            TaskName = "Design",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3,
            Children = new List<TreeGridItems>()
        };
        TreeGridItems Child5 = new TreeGridItems()
        {
            TaskId = 7,
            TaskName = "Software Specification",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };

        TreeGridItems Child6 = new TreeGridItems()
        {
            TaskId = 8,
            TaskName = "Develop prototype",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };
        TreeGridItems Child7 = new TreeGridItems()
        {
            TaskId = 9,
            TaskName = "Get approval from customer",
            StartDate = new DateTime(2024, 06, 27),
            Duration = 2
        };
        Record2.Children.Add(Child5);
        Record2.Children.Add(Child6);
        Record2.Children.Add(Child7);
        BusinessObjectCollection.Add(Record1);
        BusinessObjectCollection.Add(Record2);
        return BusinessObjectCollection;
    }
}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core TreeGrid with Paging](images/treegrid-with-paging.png)

## Enable Sorting

The sorting feature enables you to order the records. It can be enabled by setting the  [`allowSorting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowSorting.html) property as true. Sorting feature can be customized using [`e-treegrid-sortsettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSortSettings.html) tag helper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class TreeGridItems
{
    public TreeGridItems() { }
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public int Duration { get; set; }
    public List<TreeGridItems> Children { get; set; }

    public static List<TreeGridItems> GetTreeData()
    {
        List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

        TreeGridItems Record1 = null;

        Record1 = new TreeGridItems()
        {
            TaskId = 1,
            TaskName = "Planning",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5,
            Children = new List<TreeGridItems>(),
        };
        TreeGridItems Child1 = new TreeGridItems()
        {
            TaskId = 2,
            TaskName = "Plan timeline",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };

        TreeGridItems Child2 = new TreeGridItems()
        {
            TaskId = 3,
            TaskName = "Plan budget",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        TreeGridItems Child3 = new TreeGridItems()
        {
            TaskId = 4,
            TaskName = "Allocate resources",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        Record1.Children.Add(Child1);
        Record1.Children.Add(Child2);
        Record1.Children.Add(Child3);
        TreeGridItems Record2 = new TreeGridItems()
        {
            TaskId = 6,
            TaskName = "Design",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3,
            Children = new List<TreeGridItems>()
        };
        TreeGridItems Child5 = new TreeGridItems()
        {
            TaskId = 7,
            TaskName = "Software Specification",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };

        TreeGridItems Child6 = new TreeGridItems()
        {
            TaskId = 8,
            TaskName = "Develop prototype",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };
        TreeGridItems Child7 = new TreeGridItems()
        {
            TaskId = 9,
            TaskName = "Get approval from customer",
            StartDate = new DateTime(2024, 06, 27),
            Duration = 2
        };
        Record2.Children.Add(Child5);
        Record2.Children.Add(Child6);
        Record2.Children.Add(Child7);
        BusinessObjectCollection.Add(Record1);
        BusinessObjectCollection.Add(Record2);
        return BusinessObjectCollection;
    }
}
{% endhighlight %}
{% endtabs %}

![Sorting in ASP.NET Core TreeGrid](images/treegrid-sorting.png)

## Enable Filtering

The filtering feature enables you to view reduced amount of records based on filter criteria. It can be enabled by setting the [`allowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) property as true. Filtering feature can be customized using [`e-treegrid-filtersettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html) tag helper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class TreeGridItems
{
    public TreeGridItems() { }
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public int Duration { get; set; }
    public List<TreeGridItems> Children { get; set; }

    public static List<TreeGridItems> GetTreeData()
    {
        List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

        TreeGridItems Record1 = null;

        Record1 = new TreeGridItems()
        {
            TaskId = 1,
            TaskName = "Planning",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5,
            Children = new List<TreeGridItems>(),
        };
        TreeGridItems Child1 = new TreeGridItems()
        {
            TaskId = 2,
            TaskName = "Plan timeline",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };

        TreeGridItems Child2 = new TreeGridItems()
        {
            TaskId = 3,
            TaskName = "Plan budget",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        TreeGridItems Child3 = new TreeGridItems()
        {
            TaskId = 4,
            TaskName = "Allocate resources",
            StartDate = new DateTime(2016, 06, 07),
            Duration = 5
        };
        Record1.Children.Add(Child1);
        Record1.Children.Add(Child2);
        Record1.Children.Add(Child3);
        TreeGridItems Record2 = new TreeGridItems()
        {
            TaskId = 6,
            TaskName = "Design",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3,
            Children = new List<TreeGridItems>()
        };
        TreeGridItems Child5 = new TreeGridItems()
        {
            TaskId = 7,
            TaskName = "Software Specification",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };

        TreeGridItems Child6 = new TreeGridItems()
        {
            TaskId = 8,
            TaskName = "Develop prototype",
            StartDate = new DateTime(2021, 08, 25),
            Duration = 3
        };
        TreeGridItems Child7 = new TreeGridItems()
        {
            TaskId = 9,
            TaskName = "Get approval from customer",
            StartDate = new DateTime(2024, 06, 27),
            Duration = 2
        };
        Record2.Children.Add(Child5);
        Record2.Children.Add(Child6);
        Record2.Children.Add(Child7);
        BusinessObjectCollection.Add(Record1);
        BusinessObjectCollection.Add(Record2);
        return BusinessObjectCollection;
    }
}
{% endhighlight %}
{% endtabs %}

![Filtering in ASP.NET Core TreeGrid Conrtol](images/treegrid-sample.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/TreeGrid/ASP.NET%20Core%20Tag%20Helper%20Examples).

## Handling errors

Error handling in Tree Grid identifies exceptions and notifies them through the [actionFailure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ActionFailure) event. When configuring the Tree Grid or enabling specific features through its API, mistakes can occur. The `actionFailure` event can be used to manage these errors. This event triggers when such mistakes happen. The `actionFailure` event handles various scenarios, including:

* For CRUD operations, row drag and drop, and persisiting the selection, ensure the `isPrimaryKey` property is mapped to a unique data column. Failure to do so will cause an error.
* [Paging](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/paging) is not supported with [virtualization](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/virtual-scroll). Enabling `paging` with `virtualization` will result in an error.
* To render the Tree Grid, map either the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DataSource) or [columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Columns) property. Failure to do so will result in an error.
* Freeze columns by mapping either `isFrozen` or [frozenColumns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_FrozenColumns). Enabling both properties simultaneously will result in an error.
* The [detailTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DetailTemplate) is not supported with `virtualization` and `stacked header`. Enabling them with these features will result in an error.
* The [frozenRows](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_FrozenRows) and `frozenColumns` are not supported with [rowTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_RowTemplate), `detailTemplate`, and [cell editing](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/editing/cell-editing). Enabling them with these features will result in an error.
* In `stacked header`, the `freeze` direction is incompatible with [column reordering](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/columns/column-reorder).
* [Selection](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/selection/selection) functionality is not supported when using `rowTemplate`. Enabling both properties simultaneously will result in an error.
* Set the [treeColumnIndex](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_TreeColumnIndex) value to display the tree structure.  Make sure the value does not exceed the total column count, or it will result in an error.
* For `virtualization`, do not specify height and width in percentages. Using percentages will result in an error.
* When using the default filter ([filterbar](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/filtering/filter-bar)) type, do not apply the other [filterType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.FilterType.html) to columns within the same tree grid, as this will result in an error.
* In Tree Grid avoid enabling [idMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_IdMapping) and [childMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ChildMapping) simultaneously. Enabling both properties at the same time will result in an error.
* The `showCheckbox` column should only be defined in the tree column. Defining it elsewhere will result in an error.
* The `textAlign` right is not applicable for tree columns in the Tree Grid. Enabling right alignment for tree columns will result in an error.

The following code example shows how to use the [actionFailure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ActionFailure) event in the Tree Grid control to display an exception when `isPrimaryKey` are not configured properly in the Tree Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/error-handling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ErrorHandling.cs" %}
{% include code-snippet/tree-grid/getting-start-mvc/error-handling/errorHandling.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET CORE Tree Grid with Handling errors](images/error-handling.png)

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> JavaScript documentation](https://ej2.syncfusion.com/documentation/treegrid/getting-started)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> JavaScript (ES5) documentation](https://ej2.syncfusion.com/javascript/documentation/treegrid/getting-started)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> Angular documentation](https://ej2.syncfusion.com/angular/documentation/treegrid/getting-started)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> React documentation](https://ej2.syncfusion.com/react/documentation/treegrid/getting-started)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core documentation](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/getting-started-core)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> Vue documentation](https://ej2.syncfusion.com/vue/documentation/treegrid/getting-started)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> Blazor documentation](https://blazor.syncfusion.com/documentation/treegrid/getting-started-webapp)