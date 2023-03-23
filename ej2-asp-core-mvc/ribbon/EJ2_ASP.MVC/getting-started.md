---
layout: post
title: Getting Started with ##Platform_Name## Ribbon Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET MVC Ribbon Control

This section briefly explains about how to include `ASP.NET MVC Ribbon` control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

N> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager `EJS().ScriptManager()` at the end of `<body>` in the ASP.NET MVC application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Ribbon control

Now, add the Syncfusion ASP.NET MVC Ribbon control in `~/Home/Index.cshtml` page.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@Html.EJS().Ribbon("ribbon").Render()

{% endhighlight %}
{% endtabs %}

## Adding Ribbon Tab

In Ribbon, the options are arranged in tabs for easy access. You can use the `Tabs` property of ribbon to define the ribbon tab like below.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Add();
}).Render()

{% endhighlight %}
{% endtabs %}

## Adding Ribbon Group

To define a ribbon group under each tab, you can use the `Groups` property of ribbon tab like below. The `orientation` property of ribbon group defines whether the collection of items will rendered in column-wise or row-wise.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(groups =>
    {
        groups.Header("Clipboard").Orientation(ItemOrientation.Row).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

## Adding Ribbon Items

Inside each group, options are present in rows or columns as collections of items. You can use the `Collections` property of ribbon group to define each ribbon collection. Each collection can have single or multiple items. Ribbon support several built-in items like buttons, drop-down buttons, combo boxes, and more. The `type` property of ribbon item defines the control with which the item will be rendered. You can use the `Items` property of ribbon collection to define each ribbon item like below.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(groups =
    {
        groups.Header("Clipboard").Orientation(ItemOrientation.Row).Collections(collection =>
        {
            collection.Id("ribbon-collection").Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitbutton =>
                {
                    splitbutton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

The following example illustrates how tabs, groups, collections, and items are used in a ribbon control to form the ribbon layout.


{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/getting-started/default/razor %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Ribbon control will be rendered in the default web browser.

![ASP.NET MVC Ribbon Control](images/ribbon.png)
