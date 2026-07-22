---
layout: post
title: Get Started with ASP.NET Core Sparkline Charts Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Sparkline Charts control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Sparkline Charts
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Sparkline Charts Control

This section briefly explains how to include the [ASP.NET Core Sparkline Charts](https://www.syncfusion.com/aspnet-core-ui-controls/sparkline) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core package

To add **ASP.NET Core Sparkline Charts** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetCore.Sparkline](https://www.nuget.org/packages/Syncfusion.AspNetCore.Sparkline/) package. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Sparkline -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helpers

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.Charts` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.Charts

{% endhighlight %}
{% endtabs %}

## Add script resources

The script can be referenced using the [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references). Include the script reference inside the `<head>` of **~/Pages/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.Sparkline/scripts/sf-sparkline.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the script manager

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

## Add ASP.NET Core Sparkline Charts control

Add the [ASP.NET Core Sparkline Charts](https://www.syncfusion.com/aspnet-core-ui-controls/sparkline) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-sparkline id="sparkline">
</ejs-sparkline>

{% endhighlight %}
{% endtabs %}

## Bind data source to Sparkline Charts

The `dataSource` property is used for binding data source to the Sparkline Charts. This property takes the collection value as input. For example, you can provide a list of objects as input.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sparkline/getting-started/data-source/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}

public class DataSource
{
    public int x;
    public string xval;
    public double yval;
    public static List<DataSource> GetData()
    {
        List<DataSource> data1 = new List<DataSource>();
        data1.Add(new DataSource() { x = 0, xval = "2005", yval = 20090440 });
        data1.Add(new DataSource() { x = 1, xval = "2006", yval = 20264080 });
        data1.Add(new DataSource() { x = 2, xval = "2007", yval = 20434180 });
        data1.Add(new DataSource() { x = 3, xval = "2008", yval = 21007310 });
        data1.Add(new DataSource() { x = 4, xval = "2009", yval = 21262640 });
        data1.Add(new DataSource() { x = 5, xval = "2010", yval = 21515750 });
        data1.Add(new DataSource() { x = 6, xval = "2011", yval = 21766710 });
        data1.Add(new DataSource() { x = 7, xval = "2012", yval = 22015580 });
        data1.Add(new DataSource() { x = 8, xval = "2013", yval = 22262500 });
        data1.Add(new DataSource() { x = 9, xval = "2014", yval = 22507620 });
        return data1;
    }
}

{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Sparkline Charts](https://www.syncfusion.com/aspnet-core-ui-controls/sparkline) will render in your default web browser.

![ASP.NET Core Sparkline Charts Control](images/sparkline-control.webp)

## Change the type of Sparkline Charts

You can change the Sparkline Charts type by setting the `type` property to `Line`, `Column`, `WinLoss`, `Pie`, or `Area`. Here, the sparkline type has been set to `area`.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sparkline/getting-started/type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}

public class DataSource
{
    public int x;
    public string xval;
    public double yval;
    public static List<DataSource> GetData()
    {
        List<DataSource> data1 = new List<DataSource>();
        data1.Add(new DataSource() { x = 0, xval = "2005", yval = 20090440 });
        data1.Add(new DataSource() { x = 1, xval = "2006", yval = 20264080 });
        data1.Add(new DataSource() { x = 2, xval = "2007", yval = 20434180 });
        data1.Add(new DataSource() { x = 3, xval = "2008", yval = 21007310 });
        data1.Add(new DataSource() { x = 4, xval = "2009", yval = 21262640 });
        data1.Add(new DataSource() { x = 5, xval = "2010", yval = 21515750 });
        data1.Add(new DataSource() { x = 6, xval = "2011", yval = 21766710 });
        data1.Add(new DataSource() { x = 7, xval = "2012", yval = 22015580 });
        data1.Add(new DataSource() { x = 8, xval = "2013", yval = 22262500 });
        data1.Add(new DataSource() { x = 9, xval = "2014", yval = 22507620 });
        return data1;
    }
}

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Area Sparkline Charts](images/area-sparkline.webp)

## Enable tooltip for Sparkline Charts

The Sparkline Charts displays additional information through tooltip when the mouse is hovered over the sparkline. You can enable tooltip by setting the `visible` property to true in `tooltipSettings` object.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sparkline/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}

public class DataSource
{
    public int x;
    public string xval;
    public double yval;
    public static List<DataSource> GetData()
    {
        List<DataSource> data1 = new List<DataSource>();
        data1.Add(new DataSource() { x = 0, xval = "2005", yval = 20090440 });
        data1.Add(new DataSource() { x = 1, xval = "2006", yval = 20264080 });
        data1.Add(new DataSource() { x = 2, xval = "2007", yval = 20434180 });
        data1.Add(new DataSource() { x = 3, xval = "2008", yval = 21007310 });
        data1.Add(new DataSource() { x = 4, xval = "2009", yval = 21262640 });
        data1.Add(new DataSource() { x = 5, xval = "2010", yval = 21515750 });
        data1.Add(new DataSource() { x = 6, xval = "2011", yval = 21766710 });
        data1.Add(new DataSource() { x = 7, xval = "2012", yval = 22015580 });
        data1.Add(new DataSource() { x = 8, xval = "2013", yval = 22262500 });
        data1.Add(new DataSource() { x = 9, xval = "2014", yval = 22507620 });
        return data1;
    }
}

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Sparkline Charts with Tooltip](images/sparkline-with-tooltip.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/SparkLine/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
