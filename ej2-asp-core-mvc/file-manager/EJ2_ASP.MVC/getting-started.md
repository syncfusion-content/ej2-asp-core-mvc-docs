---
layout: post
title: Getting Started with ASP.NET MVC File Manager Control | Syncfusion
description: Check out and learn about getting started with ASP.NET MVC File Manager control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: File Manager
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET MVC File Manager Control

This section briefly explains about how to include [ASP.NET MVC File Manager](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-manager) control in your ASP.NET MVC application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET MVC Web App with HTML Helper

Create an **ASP.NET MVC Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app) or the [Syncfusion® ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET MVC Getting Started](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-mvc-htmlhelper) documentation.

## Install the required ASP.NET MVC package

To add **ASP.NET MVC File Manager** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetMvc.FileManager](https://www.nuget.org/packages/Syncfusion.AspNetMvc.FileManager/) package. All Syncfusion ASP.NET MVC packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetMvc.FileManager -Version {{ site.releaseversion }}

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

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from the [CDN](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) inside the `<head>` of **~/Views/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent2.css" />
    <!-- ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the script manager

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

## Add ASP.NET MVC File Manager Control

Add the [ASP.NET MVC File Manager](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-manager) control in the **~/Views/Home/Index.cshtml** file.

Update a `~/Controllers/HomeController.cs` file with the following code. Create a `Content/Files` folder to store the files for the File Manager access. Make sure `Microsoft.AspNet.Mvc` is updated to the latest version.

{% tabs %}
{% highlight razor tabtitle="Index.cshtml" %}
{% include code-snippet/file-manager/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/getting-started/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET MVC File Manager](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-manager) control will render in your default web browser.

![ASP.NET MVC File Manager Control](images/getting-started.webp)

N> The File Manager can be rendered with `local service` for sending ajax request. Ajax request will be sent to the server which then processes the request and sends back the response. Refer Controller file for File Manager service.

## See also

* [Ajax Settings Configuration (uploadUrl, downloadUrl, getImageUrl)](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/file-operations#ajax-settings-configuration)
* [Overview](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/user-interface#file-manager-overview)
* [File Manager Views](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/views)
* [File Manager File Operations](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/file-operations)
* [File Manager Upload](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/upload)
* [File Manager Customization](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/customization)