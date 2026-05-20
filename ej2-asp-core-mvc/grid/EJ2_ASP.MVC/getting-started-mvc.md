---
layout: post
title: Getting Started with ##Platform_Name## Grid Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Grid control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Grid Control

This section briefly explains about how to include [ASP.NET MVC Grid](https://www.syncfusion.com/aspnet-mvc-ui-controls/grid) control in your ASP.NET MVC application using Visual Studio.

> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetmvc/documentation/ai-coding-assistant/overview)

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

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
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent2.css" />
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

## Add ASP.NET MVC Grid control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid control in `~/Views/Home/Index.cshtml` page.

To bind data for the Grid component, you can assign a IEnumerable object to the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. The list data source can also be provided as an instance of the **DataManager**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/getting-start-mvc/columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(OrdersDetails.GetAllRecords());
    }
}
public class OrdersDetails
{
    public static List<OrdersDetails> order = new List<OrdersDetails>();
    public OrdersDetails()
    {

    }
    public OrdersDetails(int OrderID, string CustomerId, DateTime OrderDate, string ShipCountry, double Freight)
    {
        this.OrderID = OrderID;
        this.CustomerID = CustomerId;
        this.OrderDate = OrderDate;
        this.ShipCountry = ShipCountry;
        this.Freight = Freight;
    }
    public static List<OrdersDetails> GetAllRecords()
    {
        if (order.Count() == 0)
        {
            order.Add(new OrdersDetails(10248, "Ana Trujillo", new DateTime(2025, 1, 12), "France", 32.38));
            order.Add(new OrdersDetails(10249, "Martin Sommer", new DateTime(2025, 1, 15), "Germany", 11.61));
            order.Add(new OrdersDetails(10250, "Thomas Hardy", new DateTime(2025, 2, 5), "Brazil", 65.83));
            order.Add(new OrdersDetails(10251, "Elizabeth Lincoln", new DateTime(2025, 2, 18), "France", 41.34));
            order.Add(new OrdersDetails(10252, "Victoria Ashworth", new DateTime(2025, 3, 10), "Belgium", 51.30));
            order.Add(new OrdersDetails(10253, "Martine Rance", new DateTime(2025, 3, 22), "Brazil", 58.17));    
        }
        return order;
    }
    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
    public string ShipCountry { get; set; }
    public double Freight { get; set; }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid control will be rendered in the default web browser.

The output looks like below

![ASP.NET MVC Grid with Column Values](images/column.png)

## See also

* [Create an MVC Grid app](https://www.syncfusion.com/blogs/post/create-an-mvc-grid-app-in-10-minutes-with-the-syncfusion-grid.aspx)
* [How to render EJ2-Grid as HTML in ASP.NET MVC Grid](https://www.syncfusion.com/forums/137153/how-to-render-ej2-grid-as-html-in-asp-net-mvc-grid)
* [How to render Grid in partial view in ASP.NET MVC Grid](https://www.syncfusion.com/forums/139841/how-to-render-grid-in-partial-view-in-asp-net-mvc-grid)
