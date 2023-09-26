---
layout: post
title: Getting Started with ##Platform_Name## Ribbon Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Ribbon Control

This section briefly explains about how to include `ASP.NET Core Ribbon` control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

## Install ASP.NET Core package in the application

To add ASP.NET Core controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it. Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

Also, register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls.

## Add ASP.NET Core Ribbon control

Now, add the Syncfusion ASP.NET Core Ribbon tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

<ejs-ribbon id="ribbon"></ejs-ribbon>

{% endhighlight %}
{% endtabs %}

## Adding Ribbon Tab

In Ribbon, the options are arranged in tabs for easy access. You can use the `e-ribbon-tab` tag helper to define the ribbon tab like below.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home"></e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

## Adding Ribbon Group

To define a ribbon group under each tab, you can use the `e-ribbon-group` tag helper like below. The `Orientation` property of ribbon group defines whether the collection of items will be rendered column-wise or row-wise.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard" orientation=Row></e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

## Adding Ribbon Items

You can use the `e-ribbon-collection` tag helper to define each ribbon collection that contains one or more items. To define each ribbon item, you can use the `e-ribbon-item` tag helper and the `Type` property to specify the type of control to be rendered, like a button, a drop-down button, a combo box, and more.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard" orientation=Row>
                    <e-ribbon-collections>
                        <e-ribbon-collection id="paste-collection">
                            <e-ribbon-items>
                                <e-ribbon-item type=SplitButton>
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=pasteOptions></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection id="cutcopy-collection">
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

The following example illustrates how tabs, groups, collections, and items are used in a ribbon control to form the ribbon layout.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/getting-started/default/tagHelper %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Ribbon control will be rendered in the default web browser.

![ASP.NET CORE Ribbon Control](images/ribbon.png)

## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
