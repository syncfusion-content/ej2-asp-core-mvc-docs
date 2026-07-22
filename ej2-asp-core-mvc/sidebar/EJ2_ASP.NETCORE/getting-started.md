---
layout: post
title: Getting Started with ##Platform_Name## Sidebar Control
description: Check out and learn about getting started with ##Platform_Name## Sidebar control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Sidebar Control

This section briefly explains how to include the [ASP.NET Core Sidebar](https://www.syncfusion.com/aspnet-core-ui-controls/sidebar) control in your ASP.NET Core Web App using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project).

## Install the required ASP.NET Core packages

To add [ASP.NET Core Sidebar](https://www.syncfusion.com/aspnet-core-ui-controls/sidebar) control in the app, open the NuGet package manager in Visual Studio (*Tools → NuGet Package Manager → Manage NuGet Packages for Solution*), then search and install [Syncfusion.AspNetCore.Navigations](https://www.nuget.org/packages/Syncfusion.AspNetCore.Navigations) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes). All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for more details.

Alternatively, you can install the same packages using the Package Manager Console with the following commands.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Navigations -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core tag helpers

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Navigations` and `Syncfusion.AspNetCore.Base` tag helpers.

{% tabs %}
{% highlight C# tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Navigations
@addTagHelper *, Syncfusion.AspNetCore.Base

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from NuGet through [Static Web Assets](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#static-web-assets). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    ...
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    <script src="_content/Syncfusion.AspNetCore.Navigations/scripts/sf-sidebar.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the script manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager (`<ejs-scripts>`) at the end of the `<body>` element as shown below.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Sidebar control

Add the [ASP.NET Core Sidebar](https://www.syncfusion.com/aspnet-core-ui-controls/sidebar) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/getting-started/getting-started/tagHelper %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Sidebar](https://www.syncfusion.com/aspnet-core-ui-controls/sidebar) control will render in your default web browser.

![ASP.NET Core Sidebar Control](images/getting_Started.png)

## Enable backdrop

Enabling [`showBackdrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_ShowBackdrop) prevents interaction with the main content. Here, the DOM elements will not get changed. It only closes the main content by covering with a black backdrop overlay and focuses the Sidebar on the screen. Sidebar can be rendered with specific width by setting [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Width) property.

N> To achieve a proper **backdrop**, we suggest that you create a wrapper parent container for the div block in which you intend to enable the backdrop. Set the class name of this parent container as the **target** for the Sidebar. Alternatively, you can place an empty div container after the target container.

The following example shows a Sidebar component with enabled backdrop.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/getting-started/backdrop/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Enable Backdrop in ASP.NET Core Sidebar](images/backdrop.png)

## Position

Positioning the Sidebar to the right or left of the main content can be achieved by using the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Position) property. If the position is not set, the Sidebar will expand from the left to the body element. [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_EnablePersistence) will persist the component's state between page reloads. [`change`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Change) event will be triggered when the state(expand/collapse) of the component is changed.

In the following sample, the sidebar is rendered with position property.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/getting-started/position/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Changing ASP.NET Core Sidebar Position](images/position.png)

## Animate

Animation transitions can be set while expanding or collapsing the Sidebar using the [`animate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Animate) property. By default, [`animate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Animate) property is set to true. [`enableRTL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_EnableRtl) will display the sidebar in the right-to-left direction.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/animate/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Sidebar Sample](images/backdrop.png)

## Close on document click

Sidebar can be closed on document click by setting [`closeOnDocumentClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_CloseOnDocumentClick) to `true`. By default, the `closeOnDocumentClick` property is set to `false`, which prevents the Sidebar from closing when the user clicks outside of it. To keep the Sidebar open when it is initially rendered, use the [`isOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_IsOpen) property.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/document-click/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Sidebar Sample](images/document-click.png)

## Enable gestures

Use the [`enableGestures`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_EnableGestures) property to allow users to open or close the Sidebar with swipe gestures on touch-enabled devices. By default, this property is set to `true`.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/gestures/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Sidebar with Gesture](images/backdrop.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Sidebar/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

1. [Getting Started with ASP.NET Core in Visual Studio Mac](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/visual-studio-mac)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
3. [Sidebar with Menu Component](https://ej2.syncfusion.com/aspnetcore/Sidebar/SidebarWithMenu#/material)
4. [Sidebar Responsive Panel](https://ej2.syncfusion.com/aspnetcore/Sidebar/PanelWithResponsive#/material)
5. [Use Case Sample](https://showcase.syncfusion.com/aspnetcore/webmail/)
