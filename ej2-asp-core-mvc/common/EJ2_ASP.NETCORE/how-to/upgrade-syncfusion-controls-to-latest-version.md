---
layout: post
title: Upgrade Syncfusion Controls to Latest Version in ##Platform_Name## | Syncfusion
description: Checkout and learn here about the Upgrade Syncfusion Controls to Latest Version in ##Platform_Name##.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to upgrade ASP.NET Core Controls to the latest version

To upgrade Syncfusion ASP.NET Core Controls to the latest version, you need to ensure the following:

## Compatible .NET version

Syncfusion ASP.NET Core Controls in the latest version `'{:nuget-version:}'` are compatible with the latest version of .NET 7.0, .NET 6.0 and .NET Core 3.1. Also, refer to [version compatibility](../version-compatibility) documentation for more information about version compatibility of Syncfusion ASP.NET Core Controls and .NET Core SDK.

## Client resource file references

Ensure your Script and CSS files have been properly configured in your application.

* Add the required scripts and style sheet using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}
<head>
    ...
    <!-- Syncfusion ASP.NET Core controls Scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />
</head>
{% endhighlight %}
{% endtabs %}

* Make sure that the version in the URLs matches the version of the `Syncfusion.EJ2.AspNet.Core` NuGet package in your application.
    
N> For production purpose and minimal requirement, Syncfusion provides an option to generate custom styles of selective controls by using the ThemeStudio web application. Refer to this [link](http://ej2.syncfusion.com/themestudio/) for more details on ThemeStudio.

## Breaking changes

Some changes have been modified in our ASP samples for each release. So, we suggest you to ensure the breaking changes. Refer to this [release notes](https://ej2.syncfusion.com/aspnetcore/documentation/release-notes/index/?type=breaking-changes) for our ASP.NET Core controls.

## Cache problem

Before restoring the NuGet packages, clean the older versions of Syncfusion ASP.NET Core NuGet packages.

The following steps explain how to clean the cache:

1. Delete the Syncfusion ASP.NET Core NuGet packages from the installed location `{System-driver}/Users/{user-name}/.nuget/packages/`. In Windows, the installed location of Syncfusion ASP.NET Core NuGet packages can be found using `%userprofile%/.nuget/packages/`.

2. Update the latest version of Syncfusion ASP.NET Core NuGet packages.

## See also

* [Version Compatibility](../version-compatibility)
