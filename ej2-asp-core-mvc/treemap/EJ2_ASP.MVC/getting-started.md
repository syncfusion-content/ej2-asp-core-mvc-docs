---
layout: post
title: Getting Started with ##Platform_Name## TreeMap Control | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## TreeMap control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with the ASP.NET MVC TreeMap Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC TreeMap](https://www.syncfusion.com/aspnet-mvc-ui-controls/treemap) control to your ASP.NET MVC application using Visual Studio.

## Prerequisites

Refer to the [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) before creating the application.

## Create an ASP.NET MVC application with HTML helper

You can create an ASP.NET MVC application using either of the following options:

* [Create a project using Microsoft templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install the ASP.NET MVC NuGet package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET MVC** controls in the application, open the NuGet Package Manager in Visual Studio by selecting (Tools → NuGet Package Manager → Manage NuGet Packages for Solution). Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.

Alternatively, you can use the Package Manager Console by navigating to:
Tools → NuGet Package Manager → Package Manager Console, and then run the following command:

{% tabs %}
{% highlight bash tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.MVC5 NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the namespace

Add the **Syncfusion.EJ2** namespace reference in the `Web.config` file available in the `Views` folder.

{% tabs %}
{% highlight xml tabtitle="~/Views/Web.config" %}

<namespaces>
    <add namespace="Syncfusion.EJ2" />
</namespaces>

{% endhighlight %}
{% endtabs %}

## Add script resources

Add the script reference inside the `<head>` element of the `~/Views/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Refer to the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register the Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Register the script manager `EJS().ScriptManager()` at the end of the `<body>` element in the `~/Views/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC TreeMap control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC TreeMap control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}

<h2> Essential JS 2 for ASP.NET MVC TreeMap </h2>

<div id="container">
    @Html.EJS().TreeMap("container").Load("load").WeightValuePath("Count").LeafItemSettings(leaf=>leaf.LabelPath("State")).Render()
</div>
<script>
    function load(args)
    {
        var data = [
            { Title: 'State wise International Airport count in South America', State: "Brazil", Count: 25 },
            { Title: 'State wise International Airport count in South America', State: "Colombia", Count: 12 },
            { Title: 'State wise International Airport count in South America', State: "Argentina", Count: 9 },
            { Title: 'State wise International Airport count in South America', State: "Ecuador", Count: 7 },
            { Title: 'State wise International Airport count in South America', State: "Chile", Count: 6 },
            { Title: 'State wise International Airport count in South America', State: "Peru", Count: 3 },
            { Title: 'State wise International Airport count in South America', State: "Venezuela", Count: 3 },
            { Title: 'State wise International Airport count in South America', State: "Bolivia", Count: 2 },
            { Title: 'State wise International Airport count in South America', State: "Paraguay", Count: 2 },
            { Title: 'State wise International Airport count in South America', State: "Uruguay", Count: 2 },
            { Title: 'State wise International Airport count in South America', State: "Falkland Islands", Count: 1 },
            { Title: 'State wise International Airport count in South America', State: "French Guiana", Count: 1 },
            { Title: 'State wise International Airport count in South America', State: "Guyana", Count: 1 },
            { Title: 'State wise International Airport count in South America', State: "Suriname", Count: 1 },
        ];
        args.treemap.dataSource = data;
    }
</script>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sparkline control will be rendered in the default web browser.

![ASP.NET MVC TreeMap Control](images/treemap-control.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/TreeMap/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## Troubleshooting

If the TreeMap control does not render as expected, review the following common issues and their resolutions.

* **"Unlicensed" watermark appears on the page** — The `Syncfusion.Licensing` package is installed but the license key has not been registered. Register the license key in `~/App_Start/FilterConfig.cs` (or `Program.cs`) and rebuild. See [Registering the Syncfusion license key](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application).

* **"Script Manager is not defined" or scripts run twice** — `@Html.EJS().ScriptManager()` was not added, or was added more than once. Ensure `ScriptManager` is registered exactly once at the end of `<body>` in `_Layout.cshtml`.

* **"Could not load file or assembly 'Syncfusion.EJ2'"** — The NuGet package was not restored. Run `Update-Package -reinstall` in the Package Manager Console, or restore via Visual Studio (right-click solution → Restore NuGet Packages).

* **TreeMap renders but rectangles are empty** — The field assigned to `WeightValuePath` does not match a numeric property in the data source, or the data source is empty. Verify the field name and that the controller returns a non-empty list.

* **`Newtonsoft.Json` reference error after upgrade** — `Syncfusion.EJ2.MVC5` requires a specific `Newtonsoft.Json` version. Install a compatible `Newtonsoft.Json` version (≥ 12.0.2) via NuGet.

## See also

* [TreeMap Levels in ASP.NET MVC](https://ej2.syncfusion.com/aspnetmvc/documentation/treemap/levels)
* [TreeMap Color Mapping in ASP.NET MVC](https://ej2.syncfusion.com/aspnetmvc/documentation/treemap/color-mapping)
* [TreeMap Legend in ASP.NET MVC](https://ej2.syncfusion.com/aspnetmvc/documentation/treemap/legend)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)
