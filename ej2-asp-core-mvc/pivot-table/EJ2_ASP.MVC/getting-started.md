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

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it.

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion script manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Views/Shared/_Layout.cshtml` file as follows.

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

* Now, add the Syncfusion ASP.NET MVC Pivot Table control in `~/Views/Home/Index.cshtml` page.

* The Pivot Table control further needs to be populated with an appropriate data source. For illustration purpose, a collection of objects mentioning the sales details of certain products over a period and region has been prepared. This sample data is assigned to the pivot table control through [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_DataSource) property under [PivotViewDataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/initial-pivot/razor %}
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

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Pivot Table control will be rendered in the default web browser.

## Adding fields to row, column, value and filter axes

Now that pivot table is initialized and assigned with sample data, will further move to showcase the component by organizing appropriate fields in row, column, value and filter axes.

In [PivotViewDataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class, four major axes -  [Rows](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows), [Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns), [Values](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) and [Filters](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Filters) plays a vital role in defining and organizing fields from the bound data source, to render the entire pivot table component in a desired format.

[Rows](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows) – Collection of fields that needs to be displayed in row axis of the pivot table.

[Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns) – Collection of fields that needs to be displayed in column axis of the pivot table.

[Values](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) – Collection of fields that needs to be displayed as aggregated numeric values in the pivot table.

[Filters](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Filters) - Collection of fields that would act as master filter over the data bound in row, column and value axes of the pivot table.

In-order to define each field in the respective axis, the following basic properties should be set.

* [Name](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Name): It allows to set the field name from the bound data source. It’s casing should match exactly like in the data source and if not set properly, the pivot table will not be rendered.
* [Caption](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Caption): It allows to set the field caption, which is the alias name of the field that needs to be displayed in the pivot table.
* [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_Type): It allows to set the summary type of the field. By default, [SummaryTypes.Sum](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.SummaryTypes.html) is applied.

In this illustration, "Year" and "Quarter" are added in column, "Country" and "Products" in row, and "Sold" and "Amount" in value section respectively.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/add-fields/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Pivot Table with Fields](images/pivottable-fields.png)

## Applying formatting to a value field

Formatting defines a way in which values should be displayed. For example, format **"C"** denotes the values should be displayed in currency pattern. To do so, define the [FormatSetting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) class with its [Name](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) and [Format](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format) properties and add it to [PivotViewFormatSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html). In this illustration, the [Name](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Name) property is set as **Amount**, a field from value section and its format is set as currency. Likewise, we can set format for other value fields as well and add it to [PivotViewFormatSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html).

N> Only fields from value section, which is in the form of numeric data values are applicable for formatting.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/format/razor %}
{% endhighlight %}
{% endtabs %}

![Formatting in ASP.NET MVC Pivot Table](images/pivottable-value-format.png)

## Enable Grouping Bar

The grouping bar feature automatically populates fields from the bound data source and allows end users to drag fields between different axes such as columns, rows, values, and filters, and alter pivot table at runtime. It also provides option to sort, filter and remove fields. It can be enabled by setting the [ShowGroupingBar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowGroupingBar) property to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/razor %}
{% endhighlight %}
{% endtabs %}

![Grouping in ASP.NET MVC Pivot Table](images/pivottable-group.png)

## Enable Pivot Field List

The field list allows to add or remove fields and also rearrange the fields between different axes, including column, row, value, and filter along with filter and sort options dynamically at runtime. It can be enabled by setting the [ShowFieldList](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Pivot Table with Field List](images/pivottable-with-pivotfield.png)

## Calculated field

The calculated field feature allows user to insert or add a new calculated field based on the available fields from the bound data source using basic arithmetic operators. The calculated field can be included in pivot table using the [CalculatedFieldSetting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html) class from code behind. Or else, calculated fields can be added at run time through the built-in dialog by just setting the [AllowCalculatedField](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowCalculatedField) property to **true** in pivot table. You will see a button enabled in the Field List UI automatically to invoke the calculated field dialog and perform necessary operation.

N> By default, the calculated fields created through code-behind are only added to the field list and calculated field dialog UI. To display the calculated field in the pivot table UI, it must be added to the [`Values`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Values) property, as shown in the code below. Additionally, calculated fields can only be added to the value axis.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/calculatedfield/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Pivot Table with Calculate Field](images/pivottable-calculatefield.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/PivotTable/ASP.NET%20MVC%20Razor%20Examples).
