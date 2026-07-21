---
layout: post
title: Getting Started with ASP.NET MVC Maps Control | Syncfusion
description: Check out and learn about getting started with ASP.NET MVC Maps Control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with the ASP.NET MVC Maps Control

This section explains how to add the [ASP.NET MVC Maps](https://www.syncfusion.com/aspnet-mvc-ui-controls/maps-library) control to your ASP.NET MVC application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

You can explore some useful features in the Maps control using the following video.

{% youtube "https://www.youtube.com/watch?v=kwE6ikF7QYQ" %}

## Create an ASP.NET MVC Web App with HTML Helper

Create an **ASP.NET MVC Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app) or the [Syncfusion® ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET MVC Getting Started](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-mvc-htmlhelper) documentation.

## Install the required ASP.NET MVC package

To add **ASP.NET MVC Maps** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetMvc.Maps](https://www.nuget.org/packages/Syncfusion.AspNetMvc.Maps/) package. All Syncfusion ASP.NET MVC packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetMvc.Maps -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the Namespace

After the package is installed, open the **~/Views/Web.config** file and import the `Syncfusion.EJ2` namespace.

{% tabs %}
{% highlight xml tabtitle="Web.config" %}

<namespaces>
    <add namespace="Syncfusion.EJ2" />
</namespaces>

{% endhighlight %}
{% endtabs %}

## Add Script Resources

The script can be referenced from the [CDN](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme#cdn-reference). Include the [script references](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) inside the `<head>` of **~/Views/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Views/Shared/_Layout.cshtml** file and register the script manager `EJS().ScriptManager()` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET MVC Maps Control

Add the [ASP.NET MVC Maps](https://www.syncfusion.com/aspnet-mvc-ui-controls/maps-library) control in the **~/Views/Home/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

@Html.EJS().Maps("container").Layers(layer =>
{
    layer.ShapeData(Model).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

Place the **WorldMap.json** file in the **App_Data** folder of the project. Read the content of the **WorldMap.json** file in the **~/Controllers/HomeController.cs** file and assign the deserialized object to the [`ShapeData`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property of the Maps control as shown below.

{% tabs %}
{% highlight c# tabtitle="HomeController.cs" %}

public ActionResult Index()
{
    return View(GetWorldMap());
}

public object GetWorldMap()
{
    string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
    return JsonConvert.DeserializeObject(allText, typeof(object));
}

{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The ASP.NET MVC Maps control will render in your default web browser.

![ASP.NET MVC - Essential JS2 Maps](../maps/images/aspnetmvc-maps.webp)

N> Map layers render only when `ShapeData` is provided [here](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WorldMap-637657487).

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Map/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## See Also

1. [Getting Started with ASP.NET MVC using HTML Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-mvc-htmlhelper)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)
