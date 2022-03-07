---
layout: post
title: Adding script references in ##Platform_Name## control
description: Learn here all about adding script references in Syncfusion ##Platform_Name## control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Adding Script References
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reference Scripts in ASP.NET Core Application

This section provides information about reference scripts from CDN and Custom resource generator (CRG) for Syncfusion ASP.NET Core controls.

## CDN Reference

Syncfusion hosts every ASP.NET Core control as a separate node package in CDN, from which scripts and style sheets of the individual package can be loaded. It also hosts a single node package with all ASP.NET Core controls on it, from which scripts and style sheets of all controls can be loaded as single script and style file.

Here, the generic syntax of the Syncfusion ASP.NET Core CDN URL for the both Individual ASP.NET Core control package and Complete ASP.NET Core controls package has been explained.

### CDN Reference for all controls

The primary goal of all the ASP.NET Core controls package is to help the novice to get started with Syncfusion ASP.NET Core control by referring the single line for script and styles without bothering about the dependency graph of the ASP.NET Core controls.

**Syntax:**

| controls | CDN Reference |
| --- | --- |
| Scripts reference for all controls| https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js |
| Styles reference for all controls | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{THEME-NAME}.css |

> Syncfusion will never recommend all controls CDN for real-time projects. Because, the size of this CDN impacts website/app loading time since this package includes all the Syncfusion ASP.NET Core controls.

Add the EJ2 CDN client-side resources to the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

{% tabs %}
{% highlight c# tabtitle="_Layout.cshtml" %}

<head>
    ....
    ....

    <!-- Syncfusion Essential JS 2 Styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />

    <!-- Syncfusion Essential JS 2 Scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

### Individual control CDN Reference

The primary goal of individual control CDN is to optimize the loading time and memory of the website/app in the production stage. The order of individual control package loading should be in line with its dependency graph. The CDN of the Dependency Packages should be included manually before the intended individual control package CDN.

**Syntax:**

| controls | CDN Reference |
| --- | --- |
| Scripts reference for individual control| https://cdn.syncfusion.com/ej2/{PACKAGE-NAME}/dist/global/{PACKAGE-NAME}.min.js |
| Styles reference for individual control | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{PACKAGE-NAME}/styles/{THEME-NAME}.css |

Add the CDN client-side resources in the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

{% tabs %}
{% highlight c# tabtitle="_Layout.cshtml" %}

<head>
    ...

    ...
        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/styles/material.css" />
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/styles/material.css" />
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/styles/material.css" />
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/styles/material.css" />
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2{{ site.ej2version }}//ej2-lists/styles/material.css" />


        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
        <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
        <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
        <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
        <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

In addition to above, Syncfusion ASP.NET Core controls provides latest scripts and styles in CDN without versioning. You can use this in development environment if you want to always use the latest version of scripts and styles. It is not recommended to use this in production environment.

| controls | CDN Reference |
| --- | --- |
| Scripts reference for all controls| https://cdn.syncfusion.com/ej2/dist/ej2.min.js |
| Styles reference for all controls | https://cdn.syncfusion.com/ej2/{THEME-NAME}.css |

## Custom Resource Generator

The Syncfusion ASP.NET Core provides an option to generate a control's scripts using the [Custom Resource Generator]((https://crg.syncfusion.com/) (CRG) tool for the ASP.NET Core Controls. To generate the control-wise scripts externally using CRG, refer [here](./custom-resource-generator).
