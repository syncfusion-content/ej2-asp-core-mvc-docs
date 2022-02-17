---
layout: post
title: Getting Started with ##Platform_Name## Ej2_asp.netcore Component
description: Checkout and learn about getting started with ##Platform_Name## Ej2_asp.netcore component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Vscode
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD024 -->

# Getting Started with ASP.NET Core in Visual Studio Code using Razor pages

This article provides a step-by-step instruction for building ASP.NET Core web application using the [Visual Studio Code](https://code.visualstudio.com/).

## Prerequisites

* [Visual Studio Code](https://code.visualstudio.com/download)
* [C# for Visual Studio Code (latest version)](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
* [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

## Created ASP.NET Core web application

1. Create a new folder and open it in the VS Code by **File > Open Folder...**.

> Visual Studio Code displays a dialog box that asks Do you trust the authors of the files in this folder. Select:

* The checkbox trust the authors of all files in the parent folder
* Yes, I trust the authors.

2. Open the [Integrated Terminal](https://code.visualstudio.com/docs/editor/integrated-terminal) by selecting a menu using **View > Terminal** in VS Code.

3. Run the following command in the terminal to create a new ASP.NET Core web application. 

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

dotnet new webapp -o GettingStartedUsingVsCode

{% endhighlight %}
{% endtabs %}

The dotnet new command creates a new Razor Pages project in the GettingStartedUsingVsCode folder. Please refer to this [topic](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=net60) for more information about .NET CLI commands.

4. Run the following command in the terminal to open the project in current instance of the VS Code. 

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

    code -r GettingStartedUsingVsCode

{% endhighlight %}
{% endtabs %}

## Install Syncfusion ASP.NET Core package in the application

Run the following command in the terminal to install `Syncfusion.EJ2.AspNet.Core` NuGet package in the application.

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

    dotnet add package Syncfusion.EJ2.AspNet.Core

{% endhighlight %}
{% endtabs %}

Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) for more details about NuGet packages.

## Add Syncfusion ASP.NET Core Tag Helper 
Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

    @addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add Style Sheet
Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core components. Here, the theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

    <head>
        ....
        ....

        <!-- Syncfusion ASP.NET Core components Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />

    </head>

{% endhighlight %}
{% endtabs %}

## Add Script Reference
In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

    <head>
        ....
        ....

        <!-- Syncfusion ASP.NET Core components Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
    </head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager
Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

    <body>
        ....
        ....
        <!-- Syncfusion ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    
{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Calendar Component

Now, add the Syncfusion ASP.NET Core Calendar tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> to run the app. Set `Select Environment` to `.NET Core`, if settings required for VS Code. Then, the default web browser launched with Syncfusion ASP.NET Core Calendar component.

    ![ASP.NET Core Calendar component - Getting Started using VS Code](images/aspnetcore-calendar.png)