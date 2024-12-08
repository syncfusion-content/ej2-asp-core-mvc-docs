---
layout: post
title: Getting Started with ##Platform_Name## Syncfusion Dashboard Layout
description: Checkout and learn about getting started with ##Platform_Name## Dashboard Layout control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core DashoardLayout Control

This section briefly explains about how to include [ASP.NET Core DashboardLayout](https://www.syncfusion.com/aspnet-core-ui-controls/dashboard-layout) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.  Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper
Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-script>` at the end of `<body>` in the ASP.NET Core application as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core DashboardLayout control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core DashboardLayout tag helper in `~/Pages/Index.cshtml` page.

* Defined the panels property as the attribute in the content template.
* Using the [`panels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.DashboardLayout.html#Syncfusion_EJ2_Layouts_DashboardLayout_Panels) property through tag helper.

### Setting the panels property using content template

DashboardLayout control can be rendered by using the [`ejs-dashboardlayout`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.DashboardLayout.html) tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DashboardLayout.

In the following sample, the dashboardlayout is rendered with [`panels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.DashboardLayout.html#Syncfusion_EJ2_Layouts_DashboardLayout_Panels) property using content template.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class spacingModel
{
    public double[] cellSpacing { get; set; }
}
...
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core DashboardLayout control will be rendered in the default web browser.

![Dashboard content template](images/content_template.png)

### Setting the panels property using tag helper

You can render the DashboardLayout control by using the **panels** property through [`e-dashboardlayout-panels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.DashboardLayoutPanels.html) tag helper.

In the following sample, the dashboardlayout is rendered with [`panels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.DashboardLayout.html#Syncfusion_EJ2_Layouts_DashboardLayout_Panels) property using tag helper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/getting-started-panel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class spacingModel
{
    public double[] cellSpacing { get; set; }
}
...
{% endhighlight %}
{% endtabs %}

![Dashboard tag helper](images/tag_helper.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/DashboardLayout/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)