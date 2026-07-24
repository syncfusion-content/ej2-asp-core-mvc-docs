---
layout: post
title: Getting Started with ##Platform_Name## RangeNavigator Control | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## RangeNavigator control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Range Selector
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Range Selector Control

This section briefly explains how to include the [ASP.NET Core Range Selector](https://www.syncfusion.com/aspnet-core-ui-controls/range-selector) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

This section briefly explains how to include the [ASP.NET Core RangeNavigator](https://www.syncfusion.com/aspnet-core-ui-controls/range-selector) control in your ASP.NET Core application using Visual Studio.

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core package

To add [ASP.NET Core Range Selector](https://www.syncfusion.com/aspnet-core-ui-controls/range-selector) control in the app, open the NuGet package manager in Visual Studio *(Tools → NuGet Package Manager → Manage NuGet Packages for Solution)*, search for and install the [Syncfusion.AspNetCore.RangeNavigator](https://www.nuget.org/packages/Syncfusion.AspNetCore.RangeNavigator/) package. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it. Alternatively, you can run the following command in the **Package Manager Console**.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.RangeNavigator -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.Charts` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.Charts

{% endhighlight %}
{% endtabs %}

## Add script resources

Include the [script reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.Charts/scripts/sf-range-navigator.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core RangeNavigator Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core RangeNavigator tag helper to the `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-rangenavigator id="rangeNavigator"></ejs-rangenavigator>

{% endhighlight %}
{% endtabs %}

## Populate Range Navigator with data

Provide data to the RangeNavigator by adding a `series` object, mapping the `x` and `y` fields of your data to the `xName` and `yName` properties, and assigning the data to the `dataSource` property. Because the sample data contains `DateTime` values, set `valueType` to `DateTime` (the default is `Numeric`).

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/range-navigator/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RangeNavigatorData.cs" %}
public class RangeNavigatorData
{
    public DateTime x { get; set; }
    public double y { get; set; }
    public double y1 { get; set; }
}

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core RangeNavigator control will be rendered in the default web browser.

![ASP.NET Core Range Selector Control](images/rn.webp)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/RangeNavigator/ASP.NET%20Core%20Tag%20Helper%20Examples).

## Troubleshooting

If the RangeNavigator does not render or you run into build/runtime issues, try the following:

* **RangeNavigator is not visible on the page** — Ensure the `ejs-scripts` tag helper is registered at the end of `<body>` in `~/Pages/Shared/_Layout.cshtml`. Missing this registration prevents Syncfusion client-side scripts from initializing the control.
* **Series renders with no points** — Confirm that the data model exposes `x`, `y`, and any additional fields you reference, and that the `xName`/`yName` values on the `series` match the field names exactly.
* **Date axis shows raw numbers instead of dates** — Verify that `valueType` is set to `DateTime` on the navigator and that the data source's `x` field is a valid `DateTime` value.
* **Build error: `TagHelper is not registered`** — Verify that `~/Pages/_ViewImports.cshtml` contains `@addTagHelper *, Syncfusion.EJ2` and rebuild the solution.
* **NuGet restore failures** — Confirm the project targets a supported .NET version and that the NuGet feed is reachable. Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic.

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
