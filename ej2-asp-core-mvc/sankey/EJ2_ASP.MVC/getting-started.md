---
layout: post
title: Getting started with ##Platform_Name## Sankey Chart | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with the ASP.NET MVC Sankey Chart Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sankey Chart control to your ASP.NET MVC application using Visual Studio.

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

## Build the Sankey Chart control

This section walks through adding the Sankey Chart control to `~/Views/Home/Index.cshtml` and progressively binding data to it.

### Step 1: Add the Sankey Chart control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sankey Chart control to the `~/Views/Home/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().Sankey("sankey-container").Render()

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/getting-started/initialize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initialize.cs" %}
{% include code-snippet/sankey/getting-started/initialize/initialize.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sankey Chart control will be rendered in the default web browser.

### Step 2: Bind data to the Sankey Chart

Sankey charts are built from two collections: a `Nodes` list (the categories at each end of a flow) and a `Links` list (the connections between them with an associated value). Use the following model classes for the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/sankey/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/sankey/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sankey Chart control will be rendered in the default web browser.

## Troubleshooting

If the Sankey Chart control does not render as expected, review the following common issues and their resolutions.

* **"Script Manager is not defined" or scripts run twice** — `@Html.EJS().ScriptManager()` was not added, or was added more than once. Ensure `ScriptManager` is registered exactly once at the end of `<body>` in `_Layout.cshtml`.

* **"Could not load file or assembly 'Syncfusion.EJ2'"** — The NuGet package was not restored. Run `Update-Package -reinstall` in the Package Manager Console, or restore via Visual Studio (right-click solution → Restore NuGet Packages).

* **Chart renders but no flows appear** — The `SourceId` and `TargetId` values in `SankeyLink` must match an `Id` defined in `SankeyNode`. Property names are case-sensitive; verify they match exactly.

* **`Newtonsoft.Json` reference error after upgrade** — `Syncfusion.EJ2.MVC5` requires a specific `Newtonsoft.Json` version. Install a compatible `Newtonsoft.Json` version (≥ 12.0.2) via NuGet.

## See also

* [Data Label in ASP.NET MVC Sankey Chart](https://ej2.syncfusion.com/aspnetmvc/documentation/sankey/labels)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)