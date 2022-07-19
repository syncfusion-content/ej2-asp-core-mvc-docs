---
layout: post
title: Getting Started with ASP.NET Core Progress Button Control in Syncfusion
description: Checkout and learn about getting started with ASP.NET Core Progress Button control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ASP.NET Core
documentation: ug
---


# Getting Started with ASP.NET Core Progress Button Control

This section briefly explains about how to include [ASP.NET Core Progress Button](https://www.syncfusion.com/aspnet-core-ui-controls/progress-button) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls. Here, the theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Progress Button control

Now, add the Syncfusion ASP.NET Core Progress Button tag helper in `~/Pages/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/getting-started/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Progress Button control will be rendered in the default web browser.

![ASP.NET Core Progress Button Control](images/progress-button.png)

> Progress Button supports different styles, types and sizes like [`Button`](https://ej2.syncfusion.com/aspnetcore/documentation/button/). In addition, it also support `top` and `bottom` position of the icon.

## Enabling progress in button

You can enable the background filler UI by setting the [`enableProgress`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_EnableProgress) property to `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/enable-progress/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/enable-progress/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/enable-progress/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/ProgressButton/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)

N> You can also explore our [ASP.NET Core Progress Button Example](https://ej2.syncfusion.com/aspnetcore/Button/ProgressButton#/fluent) that shows you how to render and configure the Progress Button.