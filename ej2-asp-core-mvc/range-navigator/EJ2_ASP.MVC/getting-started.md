---
layout: post
title: Getting Started with ##Platform_Name## Range Navigator Control | Syncfusion
description: Check out and learn about getting started with the ##Platform_Name## Range Navigator control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Getting Started with the ASP.NET MVC Range Navigator Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC Range Navigator](https://www.syncfusion.com/aspnet-mvc-ui-controls/range-selector) control to an ASP.NET MVC 5 (.NET Framework) application using Visual Studio.

## Prerequisites

Refer to the [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) before creating the application. 

## Create an ASP.NET MVC application with HTML helper

You can create an ASP.NET MVC application using either of the following options:

* [Create a project using Microsoft templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)
* [Create a project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install the ASP.NET MVC NuGet package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET MVC** controls in the application, open the NuGet Package Manager in Visual Studio by selecting **Tools → NuGet Package Manager → Manage NuGet Packages for Solution**. Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.

Alternatively, you can use the Package Manager Console by navigating to **Tools → NuGet Package Manager → Package Manager Console**, and then run the following command:

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The `Syncfusion.EJ2.MVC5` NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) (≥ 12.0.2) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the namespace

Add the **Syncfusion.EJ2** namespace reference inside the `<system.web.webPages.razor>` → `<pages>` → `<namespaces>` element of the `~/Views/Web.config` file.

{% tabs %}
{% highlight xml tabtitle="~/Views/Web.config" %}

<namespaces>
    <add namespace="Syncfusion.EJ2" />
</namespaces>

{% endhighlight %}
{% endtabs %}

## Add script resources

Add the script reference inside the `<head>` element of the `~/Views/Shared/_Layout.cshtml` file as follows. The reference loads the base `ej2.min.js` bundle, which contains the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC helper scripts.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Refer to the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in an ASP.NET MVC application.

## Register the Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Register the script manager `EJS().ScriptManager()` at the end of the `<body>` element in the `~/Views/Shared/_Layout.cshtml` file as follows. The Script Manager resolves and loads control-specific scripts automatically.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Build the Range Navigator

This section walks through adding the Range Navigator control to `~/Views/Home/Index.cshtml` and progressively binding data and selecting a range.

### Step 1: Add the Range Navigator control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Range Navigator control to the `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().RangeNavigator("container").Render()

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application. The Range Navigator control will be rendered as an empty placeholder in the default web browser.

![ASP.NET MVC Range Navigator Control](images/rangenavigator-control.png)

### Step 2: Bind data with a series

Define a `RangeNavigatorData` model in `~/Controllers/HomeController.cs` and pass it as the view model. Map the field names in the data source to the [XName](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_XName), [YName](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_YName), and [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_DataSource) properties of the [Series](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_Series) configuration. Since the data contains `DateTime` values, set the [ValueType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_ValueType) to `DateTime`. The default value is `Numeric`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<RangeNavigatorData> dataSource = new List<RangeNavigatorData>
        {
            new RangeNavigatorData { x = new DateTime(2005, 1, 1),  y = 21, y1 = 28 },
            new RangeNavigatorData { x = new DateTime(2006, 1, 1),  y = 24, y1 = 44 },
            new RangeNavigatorData { x = new DateTime(2007, 1, 1),  y = 36, y1 = 48 },
            new RangeNavigatorData { x = new DateTime(2008, 1, 1),  y = 38, y1 = 50 },
            new RangeNavigatorData { x = new DateTime(2009, 1, 1),  y = 54, y1 = 66 },
            new RangeNavigatorData { x = new DateTime(2010, 1, 1),  y = 57, y1 = 78 },
            new RangeNavigatorData { x = new DateTime(2011, 1, 1),  y = 70, y1 = 84 }
        };
        return View(dataSource);
    }
}

public class RangeNavigatorData
{
    public DateTime x { get; set; }
    public double y { get; set; }
    public double y1 { get; set; }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Range Navigator control will be rendered with the bound data in the default web browser.

![ASP.NET MVC Range Navigator Control with Data](images/rangenavigator-control.png)

N> Explore the [ASP.NET MVC Range Navigator sample on GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/RangeNavigator/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## Troubleshooting

If the Range Navigator control does not render as expected, review the following common issues and their resolutions.

* **"Script Manager is not defined" or scripts run twice** — `@Html.EJS().ScriptManager()` was not added, or was added more than once. Ensure `ScriptManager` is registered exactly once at the end of `<body>` in `_Layout.cshtml`.

* **Chart renders but no data points appear** — `XName` / `YName` do not match the property names in the data source. Property names are case-sensitive; verify they match the model property names exactly (e.g., `x`, `y`).

* **Axis renders as `1970-01-01 ...` or only spans one year** — `ValueType` is still `Numeric` (the default). Set it to `DateTime` when the `XName` is a `DateTime` field.

* **`CS0103: The name 'x' does not exist` or `CS0206` compile errors** — `RangeNavigatorData` was declared with public *fields* (`public DateTime x;`) and then initialized using object-initializer syntax that requires *properties*. Change the fields to auto-properties (`public DateTime x { get; set; }`).

* **`Newtonsoft.Json` reference error after upgrade** — `Syncfusion.EJ2.MVC5` requires `Newtonsoft.Json` ≥ 12.0.2. Install a compatible version via NuGet.

## See also

* [Lightweight Range Navigator in ASP.NET MVC](https://ej2.syncfusion.com/aspnetmvc/documentation/range-navigator/light-weight)
* [Period selector in ASP.NET MVC Range Navigator](https://ej2.syncfusion.com/aspnetmvc/documentation/range-navigator/period-selector)
* [Tooltip in ASP.NET MVC Range Navigator](https://ej2.syncfusion.com/aspnetmvc/documentation/range-navigator/tool-tip)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)