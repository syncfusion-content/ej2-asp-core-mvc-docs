---
layout: post
title: Getting Started with ##Platform_Name## Listview Component
description: Checkout and learn about getting started with ##Platform_Name## Listview component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains how to create a simple Tooltip component and configure its
available functionalities in ASP.NET Core environment.

## System requirements

To work with ASP.NET Core 2.0, you need to make sure is whether you have installed the following software on your machine.

* Visual Studio 2017

* DotNetCore 2.0

## Configure Syncfusion UI Components in ASP.NET Core Application

The following steps helps to create a ASP.NET Core web application to configure our components.

* Open Visual Studio 2017  to create ASP.NET Core web application.

* After project creation, install the Syncfusion Packages in your application.

* Select the `Tools --> Nuget Package Manager -->Package Manager Settings`, the dialog window will open.

* Navigate to the `Nuget Package Manager --> Package Sources` from the options dialog.

* Click the `Add` button to create the new package sources.

* Select the newly created Package Source and rename the source name using the Name input box.

     Name: Name of the package that listed in Available package sources

     Source: Syncfusion ASP.NET Core NuGet Package feed URL

     <https://api.nuget.org/v3/index.json>

## Adding Tag Helpers

* Now open `_viewImports.cshtml` file from the `views` folder and add the following namespace for component references and Tag Helper support.

```javascript
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper *, Syncfusion.EJ2
```

## Adding ScriptManager

* Add ScriptManager to the bottom of the `layout.cshtml` page. The ScriptManager used to place our control initialization script in that page.

```javascript
<ej-scripts> </ej-scripts>

```

## Adding themes

Refer the required theme file in your `layout.cshtml` page from `wwwroot/styles` folder.

```javascript

    <link href="~/styles/material.css" rel="stylesheet"/>

```

> Above referred CSS is material theme. Likewise you can refer the theme specific CSS which is present inside the styles folder in order to render Slider component with required themes.

## Initialize the ListView

* ListView component can be rendered with the help of `ej-listview` tag helper. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder, where the ListView is initialized.


```cs

<ej-listview id="list"></ej-listview>

```



## Bind dataSource

Populate the data in `ListView` by using the `dataSource` property. Here, the JSON values are passed to the ListView component are generated in `HomeController.cs` and assigned to `ViewBag` variable.


```cs
public IActionResult Index()
        {
            //define the array of JSON
            List<object> data = new List<object>();
            data.Add(new { text: "Artwork", id: "01" });
            data.Add(new { text: "Abstract", id: "02" });
            data.Add(new { text: "Modern Painting", id: "03" });
            data.Add(new { text: "Ceramics", id: "04" });
            data.Add(new { text: "Animation Art", id: "05" });
            data.Add(new { text: "Oil Painting", id: "06" });
            ViewBag.dataSource = data;
            return View();
        }

```

 `ViewBag.dataSource` variable is used for bounding the `dataSource` property in view page.


```cs
    <ej-listview id="list" dataSource="@ViewBag.dataSource"></ej-listview>
```

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a basic ListView.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/listview/getting-started/demo/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/listview/getting-started/demo/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

