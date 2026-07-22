---
layout: post
title: Getting Started with ##Platform_Name## Splitter Control | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## Splitter control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Splitter
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Splitter Control

This section briefly explains how to include the [ASP.NET Core Splitter](https://www.syncfusion.com/aspnet-core-ui-controls/splitter) control in an ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create ASP.NET Core web application with Razor pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install ASP.NET Core package in the application

To add [ASP.NET Core Splitter](https://www.syncfusion.com/aspnet-core-ui-controls/splitter) control in the app, open the NuGet package manager in Visual Studio (*Tools → NuGet Package Manager → Manage NuGet Packages for Solution*), search for and install the [Syncfusion.AspNetCore.Layouts](https://www.nuget.org/packages/Syncfusion.AspNetCore.Layouts) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes/) packages. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Layouts -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helper

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.Layouts` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.Layouts

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script are referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of the **~/Pages/Shared/_Layout.cshtml**.

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

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Splitter control

Add the [ASP.NET Core Splitter](https://www.syncfusion.com/aspnet-core-ui-controls/splitter) control in the `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/splitter/getting-started/splitter/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. The [ASP.NET Core Splitter](https://www.syncfusion.com/aspnet-core-ui-controls/splitter) control will render in your default web browser.

![ASP.NET Core Splitter Control](../images/default.webp)

## Load content to the pane

You can load the pane content in either HTML element or string types using [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.SplitterPane.html#Syncfusion_EJ2_Layouts_SplitterPane_Content) property.

For detailed information, refer to the `Pane Content` section.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/splitter/getting-started/load-content/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Loading content to the panes](../images/content.webp)

## Configure pane size

You can specify the size to each pane using [`size`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.SplitterPane.html#Syncfusion_EJ2_Layouts_SplitterPane_Size) property. It accepts pane values in percentage and pixel types.

In case of pane size is not declared, panes will equally share the sizes automatically.

N> For Horizontal orientation, panes will share the total width.
 <br/> For Vertical orientation, panes will share the total height.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/splitter/getting-started/pane-size/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Resizable panes

Splitter allows you to change the pane dimensions by resizing the panes. By default, all the panes are resizable. You can disable the resize by using [`resizable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.SplitterPane.html#Syncfusion_EJ2_Layouts_SplitterPane_Resizable) property in each pane settings.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/splitter/getting-started/resizable-panes/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Splitter with Resizable Panes](../images/resizable.webp)

## Set minimum and maximum pane sizes

Splitter allows you to set the minimum and maximum sizes for each pane. Resize will happen up to the minimum and maximum values only. It accepts the size in both percentage and pixel formats.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/splitter/getting-started/min-max-panesize/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Orientation

Splitter supports both `Horizontal` and `Vertical` orientation for the panes. By default, it will be rendered in `Horizontal` orientation. You can change it by using [`orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Orientation.html) property.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/splitter/getting-started/orientation/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Splitter in Vertical Orientation](../images/orientation.webp)

## Nested Splitter

Splitter provides support to render the nested pane to achieve the complex layouts. You can render the nested splitter using the `<div>` element provided for parent splitter.

Also, you can render the nested splitter using direct child of the splitter pane. For this, nested splitter should have `100%` width and height to match with the parent pane dimensions.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/splitter/getting-started/nested-splitter/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Nested Splitter Control](../images/nested-splitter.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Splitter/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
* [Different layouts using Splitter](./different-layouts).