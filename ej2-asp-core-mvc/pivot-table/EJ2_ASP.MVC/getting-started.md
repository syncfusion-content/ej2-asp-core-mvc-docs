---
layout: post
title: Getting Started with ##Platform_Name## Pivot Table Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Pivot Table control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Pivot Table Control

This section briefly explains about how to include [ASP.NET MVC Pivot Table](https://www.syncfusion.com/aspnet-mvc-ui-controls/pivot-table) control in your ASP.NET MVC application using Visual Studio.

> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetmvc/documentation/ai-coding-assistant/overview)

## Prerequisites

Before you begin, ensure your system meets the requirements for using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC UI components. You need a compatible browser and a supported ASP.NET MVC version to work with the Pivot Table component. For details on supported browsers and ASP.NET MVC versions, refer to the [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/tailwind3.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> script manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Pivot Table control

* Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Pivot Table control in `~/Views/Home/Index.cshtml` page.

* The Pivot Table control further needs to be populated with an appropriate data source. For illustration purpose, a collection of objects mentioning the sales details of certain products over a period and region has been prepared. This sample data is assigned to the pivot table control through [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_DataSource) property under [PivotViewDataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/add-fields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}

public class HomeController : Controller
 {
     public ActionResult Index()
     {
         return View(PivotData.GetPivotData());
        
     }
 }
     public class PivotData
{
    public int Sold { get; set; }
    public double Amount { get; set; }
    public string Country { get; set; }
    public string Products { get; set; }
    public string Year { get; set; }
    public string Quarter { get; set; }

    private static List<PivotData> pivotDataList = new List<PivotData>();

    public PivotData() { }

    public PivotData(int sold, double amount, string country, string products, string year, string quarter)
    {
        Sold = sold;
        Amount = amount;
        Country = country;
        Products = products;
        Year = year;
        Quarter = quarter;
    }

    public static List<PivotData> GetPivotData()
    {
        if (pivotDataList.Count == 0)
        {
            pivotDataList.Add(new PivotData(31, 52824, "France", "Mountain Bikes", "FY 2015", "Q1"));
            pivotDataList.Add(new PivotData(51, 86904, "France", "Mountain Bikes", "FY 2015", "Q2"));
            pivotDataList.Add(new PivotData(90, 153360, "France", "Mountain Bikes", "FY 2015", "Q3"));
            pivotDataList.Add(new PivotData(25, 42600, "France", "Mountain Bikes", "FY 2015", "Q4"));
            pivotDataList.Add(new PivotData(27, 46008, "France", "Mountain Bikes", "FY 2016", "Q1"));
            pivotDataList.Add(new PivotData(49, 83496, "France", "Mountain Bikes", "FY 2016", "Q2"));
            pivotDataList.Add(new PivotData(95, 161880, "France", "Mountain Bikes", "FY 2016", "Q3"));
            pivotDataList.Add(new PivotData(67, 114168, "France", "Mountain Bikes", "FY 2016", "Q4"));
            pivotDataList.Add(new PivotData(75, 127800, "France", "Mountain Bikes", "FY 2017", "Q1"));
            pivotDataList.Add(new PivotData(67, 114168, "France", "Mountain Bikes", "FY 2017", "Q2"));
            pivotDataList.Add(new PivotData(69, 117576, "France", "Mountain Bikes", "FY 2017", "Q3"));
            pivotDataList.Add(new PivotData(90, 153360, "France", "Mountain Bikes", "FY 2017", "Q4"));
            pivotDataList.Add(new PivotData(16, 27264, "France", "Mountain Bikes", "FY 2018", "Q1"));
            pivotDataList.Add(new PivotData(83, 124422, "France", "Road Bikes", "FY 2015", "Q1"));
            pivotDataList.Add(new PivotData(57, 85448, "France", "Road Bikes", "FY 2015", "Q2"));
            pivotDataList.Add(new PivotData(20, 29985, "France", "Road Bikes", "FY 2015", "Q3"));
            pivotDataList.Add(new PivotData(67, 70008, "France", "Road Bikes", "FY 2016", "Q1"));
            pivotDataList.Add(new PivotData(89, 60496, "France", "Road Bikes", "FY 2016", "Q2"));
            pivotDataList.Add(new PivotData(75, 801880, "France", "Road Bikes", "FY 2016", "Q3"));
            pivotDataList.Add(new PivotData(57, 204168, "France", "Road Bikes", "FY 2016", "Q4"));
            pivotDataList.Add(new PivotData(75, 737800, "France", "Road Bikes", "FY 2017", "Q1"));
            pivotDataList.Add(new PivotData(87, 884168, "France", "Road Bikes", "FY 2017", "Q2"));
            pivotDataList.Add(new PivotData(39, 729576, "France", "Road Bikes", "FY 2017", "Q3"));
            pivotDataList.Add(new PivotData(90, 38860, "France", "Road Bikes", "FY 2017", "Q4"));
            pivotDataList.Add(new PivotData(93, 139412, "France", "Road Bikes", "FY 2015", "Q4"));
            pivotDataList.Add(new PivotData(51, 92824, "Germany", "Mountain Bikes", "FY 2015", "Q1"));
            pivotDataList.Add(new PivotData(61, 76904, "Germany", "Mountain Bikes", "FY 2015", "Q2"));
            pivotDataList.Add(new PivotData(70, 43360, "Germany", "Mountain Bikes", "FY 2015", "Q3"));
            pivotDataList.Add(new PivotData(85, 62600, "Germany", "Mountain Bikes", "FY 2015", "Q4"));
            pivotDataList.Add(new PivotData(97, 86008, "Germany", "Mountain Bikes", "FY 2016", "Q1"));
            pivotDataList.Add(new PivotData(69, 93496, "Germany", "Mountain Bikes", "FY 2016", "Q2"));
            pivotDataList.Add(new PivotData(45, 301880, "Germany", "Mountain Bikes", "FY 2016", "Q3"));
            pivotDataList.Add(new PivotData(77, 404168, "Germany", "Mountain Bikes", "FY 2016", "Q4"));
            pivotDataList.Add(new PivotData(15, 137800, "Germany", "Mountain Bikes", "FY 2017", "Q1"));
            pivotDataList.Add(new PivotData(37, 184168, "Germany", "Mountain Bikes", "FY 2017", "Q2"));
            pivotDataList.Add(new PivotData(49, 89576, "Germany", "Mountain Bikes", "FY 2017", "Q3"));
            pivotDataList.Add(new PivotData(40, 33360, "Germany", "Mountain Bikes", "FY 2017", "Q4"));
            pivotDataList.Add(new PivotData(96, 77264, "Germany", "Mountain Bikes", "FY 2018", "Q1"));
            pivotDataList.Add(new PivotData(23, 24422, "Germany", "Road Bikes", "FY 2015", "Q1"));
            pivotDataList.Add(new PivotData(67, 75448, "Germany", "Road Bikes", "FY 2015", "Q2"));
            pivotDataList.Add(new PivotData(70, 52345, "Germany", "Road Bikes", "FY 2015", "Q3"));
            pivotDataList.Add(new PivotData(13, 135612, "Germany", "Road Bikes", "FY 2015", "Q4"));
            pivotDataList.Add(new PivotData(57, 90008, "Germany", "Road Bikes", "FY 2016", "Q1"));
            pivotDataList.Add(new PivotData(29, 90496, "Germany", "Road Bikes", "FY 2016", "Q2"));
            pivotDataList.Add(new PivotData(45, 301880, "Germany", "Road Bikes", "FY 2016", "Q3"));
            pivotDataList.Add(new PivotData(77, 404168, "Germany", "Road Bikes", "FY 2016", "Q4"));
            pivotDataList.Add(new PivotData(15, 137800, "Germany", "Road Bikes", "FY 2017", "Q1"));
            pivotDataList.Add(new PivotData(37, 184168, "Germany", "Road Bikes", "FY 2017", "Q2"));
            pivotDataList.Add(new PivotData(99, 829576, "Germany", "Road Bikes", "FY 2017", "Q3"));
            pivotDataList.Add(new PivotData(80, 38360, "Germany", "Road Bikes", "FY 2017", "Q4"));
            pivotDataList.Add(new PivotData(91, 67824, "United States", "Mountain Bikes", "FY 2015", "Q1"));
            pivotDataList.Add(new PivotData(81, 99904, "United States", "Mountain Bikes", "FY 2015", "Q2"));
            pivotDataList.Add(new PivotData(70, 49360, "United States", "Mountain Bikes", "FY 2015", "Q3"));
            pivotDataList.Add(new PivotData(65, 69600, "United States", "Mountain Bikes", "FY 2015", "Q4"));
            pivotDataList.Add(new PivotData(57, 90008, "United States", "Mountain Bikes", "FY 2016", "Q1"));
            pivotDataList.Add(new PivotData(29, 90496, "United States", "Mountain Bikes", "FY 2016", "Q2"));
            pivotDataList.Add(new PivotData(45, 301880, "United States", "Mountain Bikes", "FY 2016", "Q3"));
            pivotDataList.Add(new PivotData(77, 404168, "United States", "Mountain Bikes", "FY 2016", "Q4"));
            pivotDataList.Add(new PivotData(15, 137800, "United States", "Mountain Bikes", "FY 2017", "Q1"));
            pivotDataList.Add(new PivotData(37, 184168, "United States", "Mountain Bikes", "FY 2017", "Q2"));
            pivotDataList.Add(new PivotData(49, 89576, "United States", "Mountain Bikes", "FY 2017", "Q3"));
            pivotDataList.Add(new PivotData(40, 33360, "United States", "Mountain Bikes", "FY 2017", "Q4"));
            pivotDataList.Add(new PivotData(96, 77264, "United States", "Mountain Bikes", "FY 2018", "Q1"));
            pivotDataList.Add(new PivotData(23, 24422, "United States", "Road Bikes", "FY 2015", "Q1"));
            pivotDataList.Add(new PivotData(67, 75448, "United States", "Road Bikes", "FY 2015", "Q2"));
            pivotDataList.Add(new PivotData(70, 52345, "United States", "Road Bikes", "FY 2015", "Q3"));
            pivotDataList.Add(new PivotData(13, 135612, "United States", "Road Bikes", "FY 2015", "Q4"));
            pivotDataList.Add(new PivotData(57, 90008, "United States", "Road Bikes", "FY 2016", "Q1"));
            pivotDataList.Add(new PivotData(29, 90496, "United States", "Road Bikes", "FY 2016", "Q2"));
            pivotDataList.Add(new PivotData(45, 301880, "United States", "Road Bikes", "FY 2016", "Q3"));
            pivotDataList.Add(new PivotData(77, 404168, "United States", "Road Bikes", "FY 2016", "Q4"));
            pivotDataList.Add(new PivotData(15, 137800, "United States", "Road Bikes", "FY 2017", "Q1"));
            pivotDataList.Add(new PivotData(37, 184168, "United States", "Road Bikes", "FY 2017", "Q2"));
            pivotDataList.Add(new PivotData(99, 829576, "United States", "Road Bikes", "FY 2017", "Q3"));
            pivotDataList.Add(new PivotData(80, 38360, "United States", "Road Bikes", "FY 2017", "Q4"));
        }

        return pivotDataList;
    }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Pivot Table control will be rendered in the default web browser.

The output looks like below

![ASP.NET MVC Pivot Table with Fields](images/pivottable-fields.png)

## See also

* [Data Binding](./data-binding)
* [Field List](./field-list)
* [Grouping Bar](./grouping-bar)
