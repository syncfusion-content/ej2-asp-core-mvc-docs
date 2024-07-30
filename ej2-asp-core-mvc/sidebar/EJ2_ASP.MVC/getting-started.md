---
layout: post
title: Getting Started with ##Platform_Name## Sidebar Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Sidebar control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Sidebar Control

This section briefly explains about how to include [ASP.NET MVC Sidebar](https://www.syncfusion.com/aspnet-mvc-ui-controls/sidebar) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it.

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion script manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Sidebar control

Now, add the Syncfusion ASP.NET MVC Sidebar control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/getting-started/getting-started/razor %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Sidebar control will be rendered in the default web browser.

![ASP.NET MVC Sidebar Control](images/getting_started.png)

## Enable backdrop

Enabling the [ShowBackdrop](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_ShowBackdrop) in the Sidebar component will prevent the main content from user interactions. Here, the DOM elements will not get changed. It only closes the main content by covering with a black backdrop overlay and focuses the Sidebar in the screen. Sidebar can be rendered with specific width by setting [width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Width) property.

N> To achieve a proper **backdrop**, we suggest that you create a wrapper parent container for the div block in which you intend to enable the backdrop. Set the class name of this parent container as the **target** for the Sidebar. Alternatively, you can place an empty div container after the target container.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/getting-started/backdrop/razor %}
{% endhighlight %}
{% endtabs %}

![Enabling Backdrop in ASP.NET MVC Sidebar Control](images/backdrop.png)

## Position

Positioning the Sidebar to the right or left of the main content can be achieved by using the [Position](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Position) property. If the position is not set, the Sidebar will expand from the left to the body element. [EnablePersistence](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_EnablePersistence) will persist the component's state between page reloads. [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Change) event will be triggered when the state(expand/collapse) of the component is changed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/getting-started/position/razor %}
{% endhighlight %}
{% endtabs %}

![Changing Side Position in ASP.NET MVC Sidebar](images/position.png)

## Animate

Animation transitions can be set while expanding or collapsing the Sidebar using the [Animate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Animate) property. By default , `Animate` property is set to true. [EnableRtl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_EnableRtl) will display the sidebar in the right-to-left direction.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/animate/razor %}
{% endhighlight %}
{% endtabs %}

![Animation in ASP.NET MVC Sidebar Control](images/backdrop.png)

## Close on document click

Sidebar can be closed on document click by setting [CloseOnDocumentClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_CloseOnDocumentClick) to true. If this property is not set, the Sidebar will not close on document click since its default value is false. Sidebar can be kept opened during rendering using [IsOpen](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_IsOpen) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/document-click/razor %}
{% endhighlight %}
{% endtabs %}

![Close on Document Click in ASP.NET MVC Sidebar](images/document-click.png)

## Enable gestures

Expand or collapse the Sidebar while swiping in touch devices using [EnableGestures](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_EnableGestures) property. By default, `EnableGestures` is set to true.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/gestures/razor %}
{% endhighlight %}
{% endtabs %}

![Enabling Gestures in ASP.NET MVC Sidebar Control](images/backdrop.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Sidebar/ASP.NET%20MVC%20Razor%20Examples).

## See also

* [Sidebar with Menu Component](https://ej2.syncfusion.com/aspnetmvc/Sidebar/SidebarWithMenu#/material)
* [Sidebar Responsive Panel](https://ej2.syncfusion.com/aspnetmvc/Sidebar/PanelWithResponsive#/material)
* [Usecase Sample](https://ej2.syncfusion.com/showcase/aspnetmvc/webmail/ )
