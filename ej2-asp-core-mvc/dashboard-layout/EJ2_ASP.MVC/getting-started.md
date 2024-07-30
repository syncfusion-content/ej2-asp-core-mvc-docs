---
layout: post
title: Getting Started with ##Platform_Name## DashboardLayout | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## DashboardLayout control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Dashboard Layout Control

This section briefly explains about how to include [ASP.NET MVC Dashboard Layout](https://www.syncfusion.com/aspnet-mvc-ui-controls/dashboard-layout) control in your ASP.NET MVC application using Visual Studio.

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

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

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

## Add ASP.NET MVC Dashboard Layout control

Now, add the Syncfusion ASP.NET MVC Dashboard Layout control in `~/Views/Home/Index.cshtml` page by the following ways.

* Defined the panels property as the attribute in the content template.
* Using the [Panels](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.DashboardLayout.html#Syncfusion_EJ2_Layouts_DashboardLayout_Panels) property through helper.

### Setting the panels property using content template

You can render the Dashboard Layout control by adding the panels property as the attribute to the content template. Add the content template with panel definition for Dashboard Layout into your `index.cshtml` page which is present under `Views/Home` folder.

In the following sample, the dashboard layout is rendered with [Panels](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.DashboardLayout.html#Syncfusion_EJ2_Layouts_DashboardLayout_Panels) property using content template.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/getting-started/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Dashboard Layout control will be rendered in the default web browser.

![ASP.NET MVC Dashboard Layout using Content Template](images/content_template.png)

### Setting the panels property using helper

You can render the Dashboard Layout control by using the **panels** property through helper.

In the following sample, the dashboard layout is rendered with [Panels](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.DashboardLayout.html#Syncfusion_EJ2_Layouts_DashboardLayout_Panels) property using tag helper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/getting-started-panel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/getting-started-panel/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Dashboard Layout using Tag Helper](images/tag_helper.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/DashboardLayout/ASP.NET%20MVC%20Razor%20Examples).