---
layout: post
title: Getting Started with ASP.NET Core Maps Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Maps control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with the ASP.NET Core Maps Control

This section explains how to add the [ASP.NET Core Maps](https://www.syncfusion.com/aspnet-core-ui-controls/maps) control to your application using [Visual Studio](https://visualstudio.microsoft.com/vs/) and [Visual Studio Code](https://code.visualstudio.com/).

To get started quickly with the ASP.NET Core Maps control, watch the following video:

{% youtube "https://www.youtube.com/watch?v=kwE6ikF7QYQ" %}

## Create an ASP.NET Core Web App with Razor pages

{% tabcontents %}

{% tabcontent Visual Studio %}

Create an ASP.NET Core Web App using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Run the following command to create a new ASP.NET Core Web App.

{% tabs %}
{% highlight razor tabtitle="Terminal" %}

dotnet new webapp -o RazorPagesMovie
code -r RazorPagesMovie

{% endhighlight %}
{% endtabs %}

Alternatively, create an **ASP.NET Core Web App** using Visual Studio Code via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app), the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project) or the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extension.

{% endtabcontent %}

{% endtabcontents %}

## Install the required ASP.NET Core package

Install [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package. All Syncfusion ASP.NET Core controls are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for the details.

{% tabcontents %}

{% tabcontent Visual Studio %}

1. Go to *Tools → NuGet Package Manager → Manage NuGet Packages for Solution*.
2. Search the required NuGet package (`Syncfusion.EJ2.AspNet.Core`) and install it.

Alternatively, you can install the same packages using the Package Manager Console with the following command.

{% tabs %}
{% highlight razor tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run the following command.

{% tabs %}
{% highlight razor tabtitle="Terminal" %}

dotnet add package Syncfusion.EJ2.AspNet.Core -v {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

## Add the ASP.NET Core Tag Helper

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.EJ2` Tag Helper.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add Script Resources

The script can be referenced from the [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** 

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Maps Control

Add the [ASP.NET Core Maps](https://www.syncfusion.com/aspnet-core-ui-controls/maps) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Maps

<ejs-maps id="maps">
</ejs-maps>

{% endhighlight %}
{% endtabs %}

## Render Shapes from WorldMap.json Data

Elements in the Maps control are rendered as layers. Add a layer to the Maps control using the [`Layers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_Layers) property. Then, bind the **WorldMap.json** data to the [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

@using Newtonsoft.Json
@using Syncfusion.EJ2.Maps

@{
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var WorldMapData = JsonConvert.DeserializeObject(allText);
}

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer shapeData="WorldMapData">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

## Run the application

{% tabcontents %}

{% tabcontent Visual Studio %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Maps](https://www.syncfusion.com/aspnet-core-ui-controls/maps) control will render in your default web browser.

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run the following command.

{% tabs %}
{% highlight razor tabtitle="Terminal" %}

dotnet run

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

![ASP.NET Core Maps Control](../images/maps-control.webp)

N> Map layers render only when [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) is provided. Refer to the [world map data values](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WorldMap-637657487).

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Maps/ASP.NET%20Core%20Tag%20Helper%20Examples) to understand how this getting started example works.

## See Also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)