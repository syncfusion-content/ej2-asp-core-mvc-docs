---
layout: post
title: Getting Started with ##Platform_Name## TreeGrid Control
description: Checkout and learn about getting started with ##Platform_Name## TreeGrid control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include [ASP.NET Core TreeGrid](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls. Here, the theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
    ....
    ....
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core TreeGrid control

Now, add the Syncfusion ASP.NET Core TreeGrid tag helper in `~/Pages/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/getting-start-core/tree-grid/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Tree-grid.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

## Defining Row Data

To bind data for the TreeGrid control, you can assign a IEnumerable object to the [`dataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) property. The list data source can also be provided as an instance of the **DataManager**.

{% if page.publishingplatform == "aspnet-core" %}

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

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/databinding/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core TreeGrid control will be rendered in the default web browser.

![ASP.NET Core TreeGrid Control](images/treegrid-control.png)

> [`childMapping`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ChildMapping.html) specifies the mapping property path for subtasks in dataSource.
> [`treeColumnIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~TreeColumnIndex.html) specifies the index of the column that needs to have the expander button.

## Defining Columns

The columns are automatically generated when columns declaration is empty or undefined while initializing the treegrid.

The TreeGrid has an option to define columns using [`e-treegrid-columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumns.html) tag helper. In [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper you have properties to customize columns.

Let’s check the properties used here:

* The [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) property is to map with a property name an array of JavaScript objects.
* The [`headerText`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) property is to change the title of columns.
* The [`textAlign`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~TextAlign.html) property is to change the alignment of columns. By default, columns will be left aligned. To change columns to right align, you need to define **textAlign** as **Right**.
* Using [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property
you can format number and date values to standard or custom formats.
Here, you have defined it for the conversion of numeric values to currency.

{% if page.publishingplatform == "aspnet-core" %}

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

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/columns/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core TreeGrid Columns](images/treegrid-columns.png)

## Enable Paging

The paging feature enables users to view the treegrid record in a paged view. It can be enabled by setting the  [`allowPaging`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowPaging.html) property to true. Pager can be customized using [`e-treegrid-pagesettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

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

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/tree-grid/getting-start-core/page/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core TreeGrid with Paging](images/treegrid-with-paging.png)

## Enable Sorting

The sorting feature enables you to order the records. It can be enabled by setting the  [`allowSorting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowSorting.html) property as true. Sorting feature can be customized using [`e-treegrid-sortsettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSortSettings.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

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

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/tree-grid/getting-start-core/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

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

> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.

## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)