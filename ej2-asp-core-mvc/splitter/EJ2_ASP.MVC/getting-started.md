---
layout: post
title: Getting Started with ##Platform_Name## Splitter Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Splitter control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Splitter Control

This section briefly explains about how to include [ASP.NET MVC Splitter](https://www.syncfusion.com/aspnet-mvc-ui-controls/splitter) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

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

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> script manager

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

## Add ASP.NET MVC Splitter control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Splitter control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/getting-started/default-splitter/razor %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Splitter control will be rendered in the default web browser.

![ASP.NET MVC Splitter Control](images/default.png)

## Load content to the pane

You can load the pane contents in either HTML element or string types using [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.SplitterPane.html#Syncfusion_EJ2_Layouts_SplitterPane_Content) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/getting-started/load-content/razor %}
{% endhighlight %}
{% endtabs %}

![Loading Content to Panes in ASP.NET MVC Splitter](images/content.png)

## Configure pane size

You can specify the size to each pane using [Size](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.SplitterPane.html#Syncfusion_EJ2_Layouts_SplitterPane_Size) property. It accepts pane values in percentage and pixel types.

In case of pane size is not declared, panes will equally share the sizes automatically.

  N> For Horizontal orientation, panes will share the total width.
  <br/> For Vertical orientation, panes will share the total height.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/getting-started/pane-size/razor %}
{% endhighlight %}
{% endtabs %}

## Resizable panes

Splitter allows you to change the pane dimensions by resizing the panes. By default, all the panes are resizable. You can disable the resize by using [Resizable](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.SplitterPane.html#Syncfusion_EJ2_Layouts_SplitterPane_Resizable) property in each pane settings.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/getting-started/resizable-panes/razor %}
{% endhighlight %}
{% endtabs %}

![Resizable Panes in ASP.NET MVC Splitter](images/resizable.png)

## Set minimum and maximum pane sizes

Splitter allows you to set the minimum and maximum sizes for each pane. Resize will happens up to the minimum and maximum values only. It will accepts the size in both percentage and pixel formats.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/getting-started/min-max-panesize/razor %}
{% endhighlight %}
{% endtabs %}

## Orientation

Splitter supports both `Horizontal` and `Vertical` orientation for the panes. By default, it will be rendered in `Horizontal` orientation. You can change it by using [Orientation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_Orientation) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/getting-started/orientation/razor %}
{% endhighlight %}
{% endtabs %}

![Orientation in ASP.NET MVC Splitter Control](images/orientation.png)

## Nested Splitter

Splitter provides support to render the nested pane to achieve the complex layouts. You can render the nested splitter using the `<div>` element provided for parent splitter.

Also you can render the nested splitter using direct child of the splitter pane. For this, nested splitter should have `100%` width and height to match with the parent pane dimensions.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/getting-started/nested-splitter/razor %}
{% endhighlight %}
{% endtabs %}

![Nested ASP.NET MVC Splitter Control](images/nested-splitter.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Splitter/ASP.NET%20MVC%20Razor%20Examples).

## See also

* [Real time example using Splitter](https://ej2.syncfusion.com/aspnetmvc/Splitter/OutlookStyleLayout#/bootstrap5).
* [Construct different layouts using Splitter](./different-layouts).