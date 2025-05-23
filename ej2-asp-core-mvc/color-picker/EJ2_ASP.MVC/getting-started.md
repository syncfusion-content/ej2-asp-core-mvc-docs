---
layout: post
title: Getting Started with ##Platform_Name## ColorPicker Control |Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## ColorPicker control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET MVC ColorPicker Control

This section briefly explains about how to include [ASP.NET MVC ColorPicker](https://www.syncfusion.com/aspnet-mvc-ui-controls/color-picker) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

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

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> script manager

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

## Add ASP.NET MVC ColorPicker control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC ColorPicker control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/getting-started/default/razor %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC ColorPicker control will be rendered in the default web browser.

![ASP.NET MVC ColorPicker Control](images/color-picker.png)

## Inline type

By default, the ColorPicker will be rendered using SplitButton and open the pop-up to access the ColorPicker. To render the ColorPicker container alone and to access it directly, render it as inline. It can be achieved by setting the [Inline](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Inline) property to `true`.

The following sample shows the inline type rendering of ColorPicker.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/getting-started/inline/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC ColorPicker with Inline](images/color-picker-with-inline.png)

N> The [ShowButtons](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_ShowButtons) property is disabled in this sample because the control buttons are not needed for inline type. To know about the control buttons functionality, refer to the [showButtons](./how-to/hide-control-buttons) document.

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/ColorPicker/ASP.NET%20MVC%20Razor%20Examples).

## See also

* [Set color value](./mode-and-value#color-value)
* [ColorPicker customization](./how-to/customize-colorpicker)