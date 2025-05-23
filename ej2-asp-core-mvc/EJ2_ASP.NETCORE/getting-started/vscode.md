---
layout: post
title: Getting Started with ##Platform_Name## in Visual Studio Code | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Calendar control using Tag helpers in Visual Studio Code.
platform: ej2-asp-core-mvc
control: Vscode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core in VS Code using Razor pages

This article provides a step-by-step instruction for building ASP.NET Core web application using the [Visual Studio Code](https://code.visualstudio.com/) and ASP.NET Core tag helper.

## Prerequisites

[System requirements for ASP.NET Core components](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create an ASP.NET Core web application

1.Create a new folder and open it in the VS Code by **File > Open Folder...**.

N> Visual Studio Code displays a dialog box that asks `Do you trust the authors of the files in this folder`. Select:
<br/> * The checkbox trust the authors of all files in the parent folder.
<br/> * Yes, I trust the authors.

2.Open the [Integrated Terminal](https://code.visualstudio.com/docs/editor/integrated-terminal) by selecting a menu using **View > Terminal** in VS Code.
3.Run the following command in the terminal to create a new ASP.NET Core web application.

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}
dotnet new webapp -o AspNetCoreWebApp
{% endhighlight %}
{% endtabs %}

The `dotnet new` command creates new Razor Pages project in the AspNetCoreWebApp folder. Refer to this [topic](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=net60) for more information about .NET CLI commands.

4.Run the following command in the terminal to open the project in current instance of the VS Code.
{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

code -r AspNetCoreWebApp

{% endhighlight %}
{% endtabs %}

## Install Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core package in the application

Run the following command in the terminal to install `Syncfusion.EJ2.AspNet.Core` NuGet package in the application.

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}
dotnet add package Syncfusion.EJ2.AspNet.Core
{% endhighlight %}
{% endtabs %}

Refer to [NuGet packages topic](../nuget-packages/) for more details about NuGet packages.

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
    <!-- Syncfusion ASP.NET Core controls style -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />
    <!-- Syncfusion ASP.NET Core controls script -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

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

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Add ASP.NET Core Calendar control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Calendar tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
<div>
    <ejs-calendar id="calendar"></ejs-calendar>
</div>
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> to run the app. Set `Select Environment` to `.NET Core`, if settings required for VS Code. Then, the default web browser launched with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Calendar control.

![ASP.NET Core Calendar control - Getting Started using VS Code](images/aspnetcore-calendar.png)

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)