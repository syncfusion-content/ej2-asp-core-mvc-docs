---
layout: post
title: Getting Started with ASP.NET Core TreeMap Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core TreeMap control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: TreeMap
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core TreeMap Control

This section briefly explains how to include the [ASP.NET Core TreeMap](https://www.syncfusion.com/aspnet-core-ui-controls/treemap) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core package

To add **ASP.NET Core TreeMap** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetCore.TreeMap](https://www.nuget.org/packages/Syncfusion.AspNetCore.TreeMap/) package. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.TreeMap -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helpers

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.TreeMap` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.TreeMap

{% endhighlight %}
{% endtabs %}

## Add script resources

The script can be referenced using the [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references). Include the script reference inside the `<head>` of **~/Pages/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.TreeMap/scripts/sf-treemap.min.js"></script>
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

## Add ASP.NET Core TreeMap control

Add the [ASP.NET Core TreeMap](https://www.syncfusion.com/aspnet-core-ui-controls/treemap) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-treemap id="treemap">
</ejs-treemap>

{% endhighlight %}
{% endtabs %}

## Render tree map

This section explains how to render the tree map with data source.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/treemap/getting-started/data-source/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core TreeMap](https://www.syncfusion.com/aspnet-core-ui-controls/treemap) control will render in your default web browser.

![ASP.NET Core TreeMap Control](images/treemap-control.webp)

Here, the tree map is created with data source and set with the `weightValuePath` as count. You can customize the leaf level tree map items using the `leafItemSettings`. The properties such as `fill`, `border`, and `labelPosition` can be changed using the `leafItemSettings`.

## Apply color mapping

The color mapping feature supports customization of item colors based on the underlying value of item received from bound data source. Specify the field name from the values that have to be compared for the item in the `equalColorValuePath` or `rangeColorValuePath` property.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/treemap/getting-started/color-mapping/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core TreeMap with ColorMapping](images/treemap-with-color-mapping.webp)

## Enable legend

You can show legend for the tree map by setting the `visible` property to **true** in `legendSettings` object.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/treemap/getting-started/legend/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core TreeMap with Legend](images/treemap-with-legend.webp)

## Add labels

The labels are added to show additional information of the items in tree map. By default, the visibility of the label is **true**. This can be customized using the `showLabels` property in `leafItemSettings`.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/treemap/getting-started/labels/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core TreeMap with Label](images/treemap-with-labels.webp)

## Enable tooltip

The tooltips are used when labels cannot display information due to space constraints. Tooltips can be enabled by setting the `visible` property to **true** in `tooltipSettings` object.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/treemap/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core TreeMap with Tooltip](images/treemap-with-tooltip.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/TreeMap/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
