---
layout: post
title: Getting Started with ##Platform_Name## Treeview Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Treeview control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC TreeView Control

This section briefly explains about how to include [ASP.NET MVC TreeView](https://www.syncfusion.com/aspnet-mvc-ui-controls/treeview) control in your ASP.NET MVC application using Visual Studio.

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

## Add ASP.NET MVC TreeView control

Now, add the Syncfusion ASP.NET MVC TreeView control in `~/Views/Home/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gettingstarted.cs" %}
{% include code-snippet/treeview/getting-started/gettingstarted.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/getting-started/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding data source

TreeView can load data either from local data sources or remote data services. This can be done using the dataSource property that is a member of the fields property. The dataSource property supports array of JavaScript objects and DataManager. Here, an array of JSON values is passed to the TreeView control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/self-referential/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selfreferential.cs" %}
{% include code-snippet/treeview/binding-data/self-referential/selfreferential.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/self-referential/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selfreferential.cs" %}
public ActionResult Index()
{
    List<object> listdata = new List<object>();
    listdata.Add(new
    {
        id = 1,
        name = "Australia",
        hasChild = true,
        expanded = true
    });
    listdata.Add(new
    {
        id = 2,
        pid = 1,
        name = "New South Wales",

    });
    listdata.Add(new
    {
        id = 3,
        pid = 1,
        name = "Victoria"
    });

    listdata.Add(new
    {
        id = 4,
        pid = 1,
        name = "South Australia"
    });
    listdata.Add(new
    {
        id = 6,
        pid = 1,
        name = "Western Australia",

    });
    listdata.Add(new
    {
        id = 7,
        name = "Brazil",
        hasChild = true
    });
    listdata.Add(new
    {
        id = 8,
        pid = 7,
        name = "Paraná"
    });
    listdata.Add(new
    {
        id = 9,
        pid = 7,
        name = "Ceará"
    });
    listdata.Add(new
    {
        id = 10,
        pid = 7,
        name = "Acre"
    });
    listdata.Add(new
    {
        id = 11,
        name = "China",
        hasChild = true
    });
    listdata.Add(new
    {
        id = 12,
        pid = 11,
        name = "Guangzhou"
    });
    listdata.Add(new
    {
        id = 13,
        pid = 11,
        name = "Shanghai"
    });
    listdata.Add(new
    {
        id = 14,
        pid = 11,
        name = "Beijing"
    });
    listdata.Add(new
    {
        id = 15,
        pid = 11,
        name = "Shantou"

    });
    listdata.Add(new
    {
        id = 16,
        name = "France",
        hasChild = true

    });
    listdata.Add(new
    {
        id = 17,
        pid = 16,
        name = "Pays de la Loire"

    });
    listdata.Add(new
    {
        id = 18,
        pid = 16,
        name = "Aquitaine"

    });
    listdata.Add(new
    {
        id = 19,
        pid = 16,
        name = "Brittany"

    });
    listdata.Add(new
    {
        id = 20,
        pid = 16,
        name = "Lorraine"
    });
    listdata.Add(new
    {
        id = 21,
        name = "India",
        hasChild = true

    });
    listdata.Add(new
    {
        id = 22,
        pid = 21,
        name = "Assam"

    });
    listdata.Add(new
    {
        id = 23,
        pid = 21,
        name = "Bihar"
    });
    listdata.Add(new
    {
        id = 24,
        pid = 21,
        name = "Tamil Nadu"
    });
    return View(listdata);
}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC TreeView control will be rendered in the default web browser.

![ASP.NET MVC TreeView Control](images/binding-self.PNG)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/TreeView/ASP.NET%20MVC%20Razor%20Examples).

N> You can also explore our [ASP.NET MVC TreeView example](https://ej2.syncfusion.com/aspnetmvc/TreeView/DefaultFunctionalities#/material) to knows how to present and manipulate data.