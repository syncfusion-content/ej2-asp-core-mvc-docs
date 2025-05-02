---
layout: post
title: Getting Started with ##Platform_Name## Spinner Component
description: Checkout and learn about getting started with ##Platform_Name## Spinner component of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started Asp Core
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Spinner Control

This section briefly explains about how to include ASP.NET Core Spinner control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create ASP.NET Core web application with Razor pages

 * [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

 * [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template)

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-script>` at the end of `<body>` in the ASP.NET Core application as follows.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Spinner Control

Initialize the Spinner using `createSpinner` method and show/hide the spinner using `showSpinner` and `hideSpinner` methods accordingly. Set the target to the spinner to render it based on specific target.

Now, add the `Spinner` using Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JavaScript library in `~/Pages/Index.cshtml` page.

```cshtml
....
<div id="container" style="position:center; height: 300px;">
    <p>If you click the <b>Show Spinner</b> button you can create the <b>ASP.NET Core Spinner component</b>  </p>
    <button id="showSpinnerButton">Show Spinner</button>
</div>

<script>

    var spinTarget = document.getElementById('container');
        ej.popups.createSpinner({
            target: spinTarget
        });

    // Attach a click event handler to the "Show Spinner" button
    document.getElementById('showSpinnerButton').addEventListener('click', function () {
        ej.popups.showSpinner(spinTarget);
                setInterval(function () {
                    //hideSpinner() method is used to hide the Spinner
                    ej.popups.hideSpinner(spinTarget);
                }, 5000);
    });
</script>

```