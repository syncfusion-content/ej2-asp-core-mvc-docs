---
layout: post
title: Getting Started with ##Platform_Name## Circular Gauge | Syncfusion
description: Check out and learn about getting started with the ##Platform_Name## Circular Gauge control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with the ASP.NET MVC Circular Gauge Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC Circular Gauge](https://www.syncfusion.com/aspnet-mvc-ui-controls/circular-gauge) control to an ASP.NET MVC 5 (.NET Framework) application using Visual Studio.

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
{% highlight bash tabtitle="Package Manager Console" %}

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

## Build the Circular Gauge

This section walks through adding the Circular Gauge control to `~/Views/Home/Index.cshtml` and configuring its title and axis.

### Step 1: Add the Circular Gauge control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Circular Gauge control to the `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().CircularGauge("container").Render()

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application. The Circular Gauge control will be rendered as an empty placeholder in the default web browser.

![ASP.NET MVC Circular Gauge Control](images/circulargauge-control.png)

### Step 2: Add a title

Use the [Title](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Title) property to add a heading that provides quick information to the user.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().CircularGauge("container").Title("Speed").Render()

{% endhighlight %}
{% endtabs %}

### Step 3: Configure the axis

Use the [Minimum](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Minimum) and [Maximum](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Maximum) properties of the axis to set the value range. The [StartAngle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_EndAngle) properties (in degrees) define the arc, and [Radius](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Radius) (as a percentage) controls the gauge size.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().CircularGauge("container").Title("Speed").Axes(axes =>
axes.EndAngle(120).StartAngle(240).Radius("90%").Minimum(0).Maximum(120).Add()).Render();

{% endhighlight %}
{% endtabs %}

![ASP.NET MVC CircularGauge with Title and Axis](images/circulargauge-with-axis.png)

N> Explore the [ASP.NET MVC Circular Gauge sample on GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/CircularGauge/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.


## Troubleshooting

If the Circular Gauge control does not render as expected, review the following common issues and their resolutions.

* **"Script Manager is not defined" or scripts run twice** — `@Html.EJS().ScriptManager()` was not added, or was added more than once. Ensure `ScriptManager` is registered exactly once at the end of `<body>` in `_Layout.cshtml`.

* **Gauge is empty (no value indicator visible)** — A `Pointers(...)` block was not added. The axis range alone only draws the arc; add a pointer with `.Value(<n>)` to show the value.

* **`Newtonsoft.Json` reference error after upgrade** — `Syncfusion.EJ2.MVC5` requires `Newtonsoft.Json` ≥ 12.0.2. Install a compatible version via NuGet.

## See also

* [Pointers in ASP.NET MVC Circular Gauge](https://ej2.syncfusion.com/aspnetmvc/documentation/circular-gauge/gauge-pointers)
* [Ranges in ASP.NET MVC Circular Gauge](https://ej2.syncfusion.com/aspnetmvc/documentation/circular-gauge/gauge-ranges)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)
