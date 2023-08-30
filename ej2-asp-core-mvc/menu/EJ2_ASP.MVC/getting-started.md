---
layout: post
title: Getting Started with ##Platform_Name## Menu Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Menu control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Menu Control

This section briefly explains about how to include [ASP.NET MVC Menu](https://www.syncfusion.com/aspnet-core-ui-controls/menu-bar) control in your ASP.NET MVC application using Visual Studio.

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

## Add ASP.NET MVC Menu control

Now, add the Syncfusion ASP.NET MVC Menu control in `~/Views/Home/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/menu/getting-started/Default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "File",
        items = new List<object>()
            {
                new { text = "Open" },
                new { text = "Save" },
                new { text = "Exit" }
            }
    });
    menuItems.Add(new
    {
        text = "Edit",
        items = new List<object>()
            {
                new { text = "Cut" },
                new { text = "Copy" },
                new { text = "Paste" }
            }
    });
    menuItems.Add(new
    {
        text = "View",
        items = new List<object>()
            {
                new { text = "Toolbar" },
                new { text = "Sidebar" },
                new { text = "Fullscreen" }
            }
    });
    menuItems.Add(new
    {
        text = "Tools",
        items = new List<object>()
            {
                new { text = "Spelling & Grammar" },
                new { text = "Customize" },
                new { text = "Options" }
            }
    });
    menuItems.Add(new
    {
        text = "Go"
    });
    menuItems.Add(new
    {
        text = "Help"
    });
    return View(menuItems);
}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Menu control will be rendered in the default web browser.

![ASP.NET MVC Menu Control](images/menu.png)

N> This example demonstrates the basic rendering of Menu with items support. For more information about data source support, refer to the [Data Source Binding](./data-source-binding-and-custom-menu-items#data-binding) section.

## Group menu items with separator

The separators are both horizontal and vertical lines used to separate the menu items. You cannot select the separators, but you can enable separators to group the menu items using the [Separator](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.MenuItem.html#Syncfusion_EJ2_Navigations_MenuItem_Separator) property. The `Open` and `Save` sub menu items are grouped using the `separator` property in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/menu/separator/Separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "File",
        items = new List<object>()
            {
                new { text = "Open" },
                new { text = "Save" },
                new { separator = true},
                new { text = "Exit" }
            }
    });
    menuItems.Add(new
    {
        text = "Edit",
        items = new List<object>()
            {
                new { text = "Cut" },
                new { text = "Copy" },
                new { text = "Paste" }
            }
    });
    menuItems.Add(new
    {
        text = "View",
        items = new List<object>()
            {
                new { text = "Toolbar" },
                new { text = "Sidebar" },
                new { text = "Fullscreen" }
            }
    });
    menuItems.Add(new
    {
        text = "Tools",
        items = new List<object>()
            {
                new { text = "Spelling & Grammar" },
                new { text = "Customize" },
                new { text = "Options" }
            }
    });
    menuItems.Add(new
    {
        text = "Go"
    });
    menuItems.Add(new
    {
        text = "Help"
    });
    return View(menuItems);
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Menu with Separator](images/menu-with-separator.png)

N> The `separator` property should not be given along with the other fields in the `MenuItem`. You can also enable the separator to group **horizontal** menu items.

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Menu/ASP.NET%20MVC%20Razor%20Examples).

## See also

* [Create menu using data source](./data-source-binding-and-custom-menu-items#data-binding)
* [Customize menu items using template support](./data-source-binding-and-custom-menu-items#custom-menu-items)
* [Integrating with Toolbar component](./use-case-scenarios#menu-in-toolbar)