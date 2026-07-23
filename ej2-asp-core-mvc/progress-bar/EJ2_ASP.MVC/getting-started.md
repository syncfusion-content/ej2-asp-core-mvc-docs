---
layout: post
title: Getting Started with ##Platform_Name## Progress Bar Control | Syncfusion
description: Check out and learn about getting started with the ##Platform_Name## Progress Bar control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Getting Started with the ASP.NET MVC Progress Bar Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC Progress Bar](https://www.syncfusion.com/aspnet-mvc-ui-controls/progressbar) control to an ASP.NET MVC 5 (.NET Framework) application using Visual Studio.

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

## Build the Progress Bar

This section walks through adding the Progress Bar control to `~/Views/Home/Index.cshtml` and progressively configuring its type, value, and label.

### Step 1: Add the Progress Bar control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Progress Bar control to the `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().ProgressBar("container").Render()

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application. The Progress Bar control will be rendered as an empty bar in the default web browser.

### Step 2: Set the type

Use the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ProgressBar.ProgressBar.html#Syncfusion_EJ2_ProgressBar_ProgressBar_Type) property to switch between the supported variants: `Linear` (default) and `Circular`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().ProgressBar("container")
    .Type(Syncfusion.EJ2.ProgressBar.ProgressType.Linear)
    .Render()

{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Progress Bar Control](images/progressbar-control.png)

N> Explore the [ASP.NET MVC Progress Bar sample on GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/ProgressBar/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## Troubleshooting

If the Progress Bar control does not render as expected, review the following common issues and their resolutions.

* **"Script Manager is not defined" or scripts run twice** — `@Html.EJS().ScriptManager()` was not added, or was added more than once. Ensure `ScriptManager` is registered exactly once at the end of `<body>` in `_Layout.cshtml`.

* **Bar appears empty even though `Value` is set** — The `Value` falls outside the `[Minimum, Maximum]` range. Ensure `Value >= Minimum` and `Value <= Maximum`.

* **`Newtonsoft.Json` reference error after upgrade** — `Syncfusion.EJ2.MVC5` requires `Newtonsoft.Json` ≥ 12.0.2. Install a compatible version via NuGet.

## See also

* [Progress Bar types in ASP.NET MVC](https://ej2.syncfusion.com/aspnetmvc/documentation/progress-bar/types)
* [Animation in ASP.NET MVC Progress Bar](https://ej2.syncfusion.com/aspnetmvc/documentation/progress-bar/animation)
* [States in ASP.NET MVC Progress Bar](https://ej2.syncfusion.com/aspnetmvc/documentation/progress-bar/states)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)