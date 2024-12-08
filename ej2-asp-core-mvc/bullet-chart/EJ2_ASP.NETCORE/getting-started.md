---
layout: post
title: Getting Started with ##Platform_Name## Bullet Chart Control |Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Bullet Chart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Bullet Chart Control

This section briefly explains about how to include [ASP.NET Core Bullet Chart](https://www.syncfusion.com/aspnet-core-ui-controls/bullet-chart) control in your ASP.NET Core application using Visual Studio.

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

## Add script resources

Here, script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

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

## Add ASP.NET Core Bullet Chart control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Bullet Chart tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<ejs-bulletchart id="container"></ejs-bulletchart>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Bullet Chart control will be rendered in the default web browser.

![ASP.NET Core Bullet Chart Control](images/bullet-chart-control.png)

## Bullet Chart With Data

Now, assign the data to `dataSource` property. **value** and **target** values should be mapped with `valueField` and `targetField` respectively.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class DefaultBulletData
{
    public double value;
    public double target;
}
{% endhighlight %}
{% endtabs %}

## Add Bullet Chart Title

You can add a title using `title` property to the bullet chart to provide quick information to the user about the data plotted in the bullet chart.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/title/tagHelper %}
{% endhighlight %}
{% highlight cshtml tabtitle="CSHTML.cs" %}
public class DefaultBulletData
{
    public double value;
    public double target;
}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Bullet Chart with Title](images/bullet-chart-with-title.png)

## Ranges

You can add a range using `e-bullet-range` of the `e-bullet-range-collection`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/ranges/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class DefaultBulletData
{
    public double value;
    public double target;
}
{% endhighlight %}
{% endtabs %}

## Tooltip

You can use tooltip for the bullet chart by setting the `enable` property to true in `e-bulletchart-tooltipsettings`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% highlight cshtml tabtitle="CSHTML.cs" %}
public class DefaultBulletData
{
    public double value;
    public double target;
}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Bullet Chart with Tooltip](images/bullet-chart-with-tooltip.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/BulletChart/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)