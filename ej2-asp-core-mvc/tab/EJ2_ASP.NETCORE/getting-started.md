---
layout: post
title: Getting Started with ##Platform_Name## Tab Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Tab control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Tab Control

This section briefly explains how to include the [ASP.NET Core Tab](https://www.syncfusion.com/aspnet-core-ui-controls/tabs) control in your ASP.NET Core Web App using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project).

## Install the required ASP.NET Core packages

To add [ASP.NET Core Tab](https://www.syncfusion.com/aspnet-core-ui-controls/tabs) control in the app, open the NuGet package manager in Visual Studio (*Tools → NuGet Package Manager → Manage NuGet Packages for Solution*), then search and install [Syncfusion.AspNetCore.Navigations](https://www.nuget.org/packages/Syncfusion.AspNetCore.Navigations) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes). All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for more details.

Alternatively, you can install the same packages using the Package Manager Console with the following commands.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Navigations -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core tag helpers

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Navigations` and `Syncfusion.AspNetCore.Base` tag helpers.

{% tabs %}
{% highlight C# tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Navigations
@addTagHelper *, Syncfusion.AspNetCore.Base

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from NuGet through [Static Web Assets](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#static-web-assets). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    ...
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    <script src="_content/Syncfusion.AspNetCore.Navigations/scripts/sf-tab.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the script manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager (`<ejs-scripts>`) at the end of the `<body>` element as shown below.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tab control

Add the [ASP.NET Core Tab](https://www.syncfusion.com/aspnet-core-ui-controls/tabs) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/tab/gettingstarted/tagHelper %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Tab](https://www.syncfusion.com/aspnet-core-ui-controls/tabs) control will render in your default web browser.

![ASP.NET Core Tab Control](images/gettingstarted.PNG)

## Initialize the Tab using JSON items collection

The Tab control can be rendered using a JSON array. Each tab item is defined with a [TabHeader](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabHeader.html), which specifies the tab text and a [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabItem.html#Syncfusion_EJ2_Navigations_TabItem_Content) property, which defines the content displayed for the tab.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/tab/items/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Initialize the Tab using HTML elements

The Tab control can be rendered based on the given HTML element using `id` as `target`. Header section must be enclosed with in a wrapper element using `e-tab-header` class and corresponding content must be mapped with `e-content` class. You need to follow the below structure of HTML elements to render the Tab,

```html

<div id='ej2Tab'>   --> Root Tab element
  <div class="e-tab-header">      --> Tab header
      <div>   --> Header Item
      </div>
  </div>
  <div class="e-content">      --> Tab content
      <div>   --> Content Item
      </div>
  </div>
</div>

```

* Add the HTML template data with its id attribute and add it in your `index.cshtml` file to initialize the Tab.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/tab/htmldom/tagHelper %}
{% endhighlight %}
{% endtabs %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Tab).

## See also

1. [Getting Started with ASP.NET Core in Visual Studio Mac](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/visual-studio-mac)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
3. [How to load tab with DataSource](./how-to/load-tab-with-data-source)
