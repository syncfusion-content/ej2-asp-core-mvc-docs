---
layout: post
title: Getting Started with ##Platform_Name## TextArea Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## TextArea control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC TextArea Control

This section briefly explains about how to include [ASP.NET MVC TextArea](https://www.syncfusion.com/aspnet-mvc-ui-controls/textarea) control in your ASP.NET MVC application using Visual Studio.

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

## Add ASP.NET MVC TextArea control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC TextArea control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/getting-started/textarea/razor %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC TextArea control will be rendered in the default web browser.

![ASP.NET MVC TextArea Control](images/textarea-control.png)


## Getting and setting values

To set the initial value of the TextArea control, you can utilize the [`value`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Value) property. Here's how you can achieve it:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/getting-started/set-value1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="set-value1.cs" %}
{% include code-snippet/textarea/getting-started/set-value1/setvalue1.cs %}
{% endhighlight %}
{% endtabs %}

* Alternatively, you can set the value to the textarea element by assigning text to the `value` property using the textarea instance.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/getting-started/set-value2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="setvalue2.cs" %}
{% include code-snippet/textarea/getting-started/set-value2/setvalue2.cs %}
{% endhighlight %}
{% endtabs %}

* You can dynamically retrieve the value of the TextArea control using the `value` property from the TextArea control instance.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/getting-started/get-value1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="getvalue1.cs" %}
{% include code-snippet/textarea/getting-started/get-value1/getvalue1.cs %}
{% endhighlight %}
{% endtabs %}

* You can retrieve the value of the TextArea by accessing it as an argument from the [`change`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_Change) event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/getting-started/get-value2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="getvalue1.cs" %}
{% include code-snippet/textarea/getting-started/get-value2/getvalue2.cs %}
{% endhighlight %}
{% endtabs %}
