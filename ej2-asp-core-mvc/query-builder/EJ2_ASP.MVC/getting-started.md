---
layout: post
title: Getting Started with ##Platform_Name## Query Builder Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Query Builder control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Query Builder Control

This section briefly explains about how to include [ASP.NET MVC Query Builder](https://www.syncfusion.com/aspnet-mvc-ui-controls/query-builder) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

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

## Add ASP.NET MVC Query Builder control

Now, add the Syncfusion ASP.NET MVC Query Builder control in `~/Views/Home/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(EmployeeView.GetAllRecords());
    }
}
public class EmployeeView
{
    public EmployeeView()
    {

    }
    public EmployeeView(int EmployeeID, string FirstName, string LastName, string Title, DateTime BirthDate, DateTime HireDate, int ReportsTo, string Address, string PostalCode, string Phone, string City, string Country)
    {
        this.EmployeeID = EmployeeID;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Title = Title;
        this.BirthDate = BirthDate;
        this.HireDate = HireDate;
        this.ReportsTo = ReportsTo;
        this.Address = Address;
        this.PostalCode = PostalCode;
        this.Phone = Phone;
        this.City = City;
        this.Country = Country;

    }
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime HireDate { get; set; }

    public int ReportsTo { get; set; }

    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public static List<EmployeeView> GetAllRecords()
    {
        List<EmployeeView> Emp = new List<EmployeeView>();
        Emp.Add(new EmployeeView(1, "Nancy", "Davolio", "Sales Representative", new DateTime(1948, 12, 08), new DateTime(1992, 05, 01), 2, "507 - 20th Ave. E.Apt. 2A ", " 98122", "(206) 555-9857 ", "Seattle ", "USA"));
        Emp.Add(new EmployeeView(2, "Andrew", "Fuller", "Vice President, Sales", new DateTime(1952, 02, 19), new DateTime(1992, 08, 14), 4, "908 W. Capital Way", "98401 ", "(206) 555-9482 ", "Kirkland ", "USA"));
        Emp.Add(new EmployeeView(3, "Janet", "Leverling", "Sales Representative", new DateTime(1963, 08, 30), new DateTime(1992, 04, 01), 3, " 4110 Old Redmond Rd.", "98052 ", "(206) 555-8122", "Redmond ", "USA "));
        Emp.Add(new EmployeeView(4, "Margaret", "Peacock", "Sales Representative", new DateTime(1937, 09, 19), new DateTime(1993, 05, 03), 6, "14 Garrett Hill ", "SW1 8JR ", "(71) 555-4848 ", "London ", "UK "));
        Emp.Add(new EmployeeView(5, "Steven", "Buchanan", "Sales Manager", new DateTime(1955, 03, 04), new DateTime(1993, 10, 17), 8, "Coventry HouseMiner Rd. ", "EC2 7JR ", " (206) 555-8122", "Tacoma ", " USA"));
        Emp.Add(new EmployeeView(6, "Michael", "Suyama", "Sales Representative", new DateTime(1963, 07, 02), new DateTime(1993, 10, 17), 2, " 7 Houndstooth Rd.", " WG2 7LT", "(71) 555-4444 ", "London ", "UK "));
        Emp.Add(new EmployeeView(7, "Robert", "King", "Sales Representative", new DateTime(1960, 05, 29), new DateTime(1994, 01, 02), 7, "Edgeham HollowWinchester Way ", "RG1 9SP ", "(71) 555-5598 ", "London ", " UK"));
        Emp.Add(new EmployeeView(8, "Laura", "Callahan", "Inside Sales Coordinator", new DateTime(1958, 01, 09), new DateTime(1994, 03, 05), 9, "722 Moss Bay Blvd. ", "98033 ", " (206) 555-3412", "Seattle ", "USA "));
        Emp.Add(new EmployeeView(9, "Anne", "Dodsworth", "Sales Representative", new DateTime(1966, 01, 27), new DateTime(1994, 11, 15), 5, "4726 - 11th Ave. N.E. ", "98105 ", "(71) 555-5598 ", " London", "UK "));
        return Emp;
    }
}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Query Builder control will be rendered in the default web browser.

![ASP.NET MVC Query Builder Control](images/querybuilder.png)

## Render with rule

The following example shows a basic Query Builder component with rule.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
@Html.EJS().QueryBuilder("querybuilder").Width("72%").Columns(col =>
{
    col.Field("EmployeeID").Label("Employee ID").Type("number").Add();
    col.Field("FirstName").Label("First Name").Type("string").Add();
    col.Field("TitleOfCourtesy").Label("Title Of Courtesy").Type("boolean").Values(new List<string> { "Mr.", "Mrs." }).Add();
    col.Field("Title").Label("Title").Type("string").Add();
    col.Field("HireDate").Label("Hire Date").Type("date").Format("dd/MM/yyyy").Add();
    col.Field("Country").Label("Country").Type("string").Add();
    col.Field("City").Label("City").Type("string").Add();
}).DataSource(Model).Rule(ViewBag.rule).Render()
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        QueryBuilderRule rule = new QueryBuilderRule()
        {
            Condition = "and",
            Rules = new List<QueryBuilderRule>()
            {
                new QueryBuilderRule { Label="Employee ID", Field="EmployeeID", Type="number", Operator="equal", Value = 1 },
                new QueryBuilderRule { Label="Title", Field="Title", Type="string", Operator="equal", Value = "Sales Manager" }
            }
        };

        ViewBag.rule = rule;
        return View(EmployeeView.GetAllRecords());
    }
}
public class EmployeeView
{
    public EmployeeView()
    {

    }
    public EmployeeView(int EmployeeID, string FirstName, string LastName, string Title, DateTime BirthDate, DateTime HireDate, int ReportsTo, string Address, string PostalCode, string Phone, string City, string Country)
    {
        this.EmployeeID = EmployeeID;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Title = Title;
        this.BirthDate = BirthDate;
        this.HireDate = HireDate;
        this.ReportsTo = ReportsTo;
        this.Address = Address;
        this.PostalCode = PostalCode;
        this.Phone = Phone;
        this.City = City;
        this.Country = Country;

    }
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime HireDate { get; set; }

    public int ReportsTo { get; set; }

    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public static List<EmployeeView> GetAllRecords()
    {
        List<EmployeeView> Emp = new List<EmployeeView>();
        Emp.Add(new EmployeeView(1, "Nancy", "Davolio", "Sales Representative", new DateTime(1948, 12, 08), new DateTime(1992, 05, 01), 2, "507 - 20th Ave. E.Apt. 2A ", " 98122", "(206) 555-9857 ", "Seattle ", "USA"));
        Emp.Add(new EmployeeView(2, "Andrew", "Fuller", "Vice President, Sales", new DateTime(1952, 02, 19), new DateTime(1992, 08, 14), 4, "908 W. Capital Way", "98401 ", "(206) 555-9482 ", "Kirkland ", "USA"));
        Emp.Add(new EmployeeView(3, "Janet", "Leverling", "Sales Representative", new DateTime(1963, 08, 30), new DateTime(1992, 04, 01), 3, " 4110 Old Redmond Rd.", "98052 ", "(206) 555-8122", "Redmond ", "USA "));
        Emp.Add(new EmployeeView(4, "Margaret", "Peacock", "Sales Representative", new DateTime(1937, 09, 19), new DateTime(1993, 05, 03), 6, "14 Garrett Hill ", "SW1 8JR ", "(71) 555-4848 ", "London ", "UK "));
        Emp.Add(new EmployeeView(5, "Steven", "Buchanan", "Sales Manager", new DateTime(1955, 03, 04), new DateTime(1993, 10, 17), 8, "Coventry HouseMiner Rd. ", "EC2 7JR ", " (206) 555-8122", "Tacoma ", " USA"));
        Emp.Add(new EmployeeView(6, "Michael", "Suyama", "Sales Representative", new DateTime(1963, 07, 02), new DateTime(1993, 10, 17), 2, " 7 Houndstooth Rd.", " WG2 7LT", "(71) 555-4444 ", "London ", "UK "));
        Emp.Add(new EmployeeView(7, "Robert", "King", "Sales Representative", new DateTime(1960, 05, 29), new DateTime(1994, 01, 02), 7, "Edgeham HollowWinchester Way ", "RG1 9SP ", "(71) 555-5598 ", "London ", " UK"));
        Emp.Add(new EmployeeView(8, "Laura", "Callahan", "Inside Sales Coordinator", new DateTime(1958, 01, 09), new DateTime(1994, 03, 05), 9, "722 Moss Bay Blvd. ", "98033 ", " (206) 555-3412", "Seattle ", "USA "));
        Emp.Add(new EmployeeView(9, "Anne", "Dodsworth", "Sales Representative", new DateTime(1966, 01, 27), new DateTime(1994, 11, 15), 5, "4726 - 11th Ave. N.E. ", "98105 ", "(71) 555-5598 ", " London", "UK "));
        return Emp;
    }
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Query Builder with Rule](images/querybuilder-rule.png)

> You can also explore our [ASP.NET MVC Query Builder example](https://ej2.syncfusion.com/aspnetmvc/QueryBuilder/DefaultFunctionalities#/material) that shows how to render and configure the Query Builder in ASP.NET MVC.
