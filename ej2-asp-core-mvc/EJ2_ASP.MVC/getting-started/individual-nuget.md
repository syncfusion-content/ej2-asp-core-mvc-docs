---
layout: post
title: ##Platform_Name## DataGrid Control Using Individual NuGet | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## DataGrid control using the individual Syncfusion.AspNetMvc.Grid NuGet package.
platform: ej2-asp-core-mvc
control: Getting Started Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET MVC DataGrid Control (Individual NuGet Package)

This section briefly explains how to include the [ASP.NET MVC DataGrid](https://www.syncfusion.com/aspnet-mvc-ui-controls/grid) control in your application using the individual `Syncfusion.AspNetMvc.Grid` NuGet package in Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)
* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install Grid NuGet package in the application

Instead of installing the combined `Syncfusion.EJ2.MVC5` package, you can install only the **Grid**-specific package to reduce dependencies when your application needs just the DataGrid control.

Open the NuGet Package Manager in Visual Studio (Tools &rarr; NuGet Package Manager &rarr; Manage NuGet Packages for Solution), search for `Syncfusion.AspNetMvc.Grid` and then install it. Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.AspNetMvc.Grid -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC individual controls (like Grid) are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.aspnetmvc) Installing the control-specific package pulls in only the dependencies required for that control (such as `Syncfusion.EJ2.Grid` and `Syncfusion.Licensing`), instead of the full `Syncfusion.EJ2.MVC5` suite.

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
    <!-- Syncfusion ASP.NET MVC Grid control styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent2.css" />
    <!-- Syncfusion ASP.NET MVC Grid control scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> script manager

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

## Add ASP.NET MVC DataGrid control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC DataGrid control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
@Html.EJS().Grid("Grid").DataSource((IEnumerable<object>)ViewBag.DataSource).Columns(col =>
{
    col.Field("OrderID").HeaderText("Order ID").Width("120").Add();
    col.Field("CustomerID").HeaderText("Customer Name").Width("150").Add();
    col.Field("OrderDate").HeaderText("Order Date").Format("yMd").Width("130").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").Width("150").Add();
    col.Field("Freight").HeaderText("Freight").Format("C2").Width("120").Add();
}).Render()
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<Order> orders = new List<Order>
        {
            new Order(10248, "Ana Trujillo", new DateTime(2025,1,12), "France", 32.38),
            new Order(10249, "Martin Sommer", new DateTime(2025,1,15), "Germany", 11.61),
            new Order(10250, "Thomas Hardy", new DateTime(2025,2,5), "Brazil", 65.83),
            new Order(10251, "Elizabeth Lincoln", new DateTime(2025,2,18), "France", 41.34),
            new Order(10252, "Victoria Ashworth", new DateTime(2025,3,10), "Belgium", 51.30),
            new Order(10253, "Martine Rance", new DateTime(2025,3,22), "Brazil", 58.17)
        };
        ViewBag.DataSource = orders;
        return View();
    }

    public class Order
    {            
        public Order() { }
        public Order(int OrderID, string CustomerId, DateTime OrderDate, string ShipCountry, double Freight)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.OrderDate = OrderDate;
            this.ShipCountry = ShipCountry;
            this.Freight = Freight;
        }
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipCountry { get; set; }
        public double? Freight { get; set; }
    }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC DataGrid control will be rendered in the default web browser.

The output looks like below

![ASP.NET MVC DataGrid with Column Values](images/column.png)

## See also

* [Individual NuGet packages browse all available Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core packages](https://www.nuget.org/packages?q=syncfusion.aspnetmvc)