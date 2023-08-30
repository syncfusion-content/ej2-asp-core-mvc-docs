---
layout: post
title: Getting Started with ##Platform_Name## FileManager Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## FileManager control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC FileManager Control

This section briefly explains about how to include [ASP.NET MVC FileManager](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-manager) control in your ASP.NET MVC application using Visual Studio.

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

## Add ASP.NET MVC FileManager Control

Now, add the Syncfusion ASP.NET MVC FileManager control in `~/Views/Home/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/getting-started/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/getting-started/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC FileManager control will be rendered in the default web browser.

![ASP.NET MVC FileManager Control](images/getting-started.PNG)

N> The File Manager can be rendered with `local service` for sending ajax request. Ajax request will be sent to the server which then processes the request and sends back the response. Refer Controller file for file manager service.

## File Download support

To perform the download operation, initialize the `DownloadUrl` property in a [AjaxSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_AjaxSettings) of File Manager component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-download-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="File-download-url.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-download-url/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## File Upload support

To perform the upload operation, initialize the [UploadUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManagerAjaxSettings.html#Syncfusion_EJ2_FileManager_FileManagerAjaxSettings_UploadUrl) property in a [AjaxSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_AjaxSettings) of File Manager Component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-upload-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="File-upload-url.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/file-upload-url/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Image Preview support

To perform the image preview support in the File Manager component, need to initialize the [GetImageUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManagerAjaxSettings.html#Syncfusion_EJ2_FileManager_FileManagerAjaxSettings_GetImageUrl) property in a [AjaxSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_AjaxSettings) of File Manager component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/image-preview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/image-preview/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/image-preview/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![File Manager Sample](images/getimage.png)

## File Manager Overview

By default, the File Manager component  having  extra module like [NavigationPane](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_NavigationPaneSettings), [Toolbar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_ToolbarSettings), [ContextMenu](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_ContextMenuSettings) module.

In this sample demonstrates the full features of the File Manager that includes toolbar, navigation pane and details view.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/overview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/overview/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/overview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/overview/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![FileManager overview](images/overview.PNG)

N> The appearance of the File Manager can be customized by using [cssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_CssClass) property. This adds a css class to the root of the File Manager which can be used to add new styles or override existing styles to the File Manager.

## Switching initial view of the File Manager

The initial view of the File Manager can be changed to details or largeicons view with the help of [View](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_View) property. By default, the File Manager will be rendered in large icons view. When the File Manager is initially rendered, [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Created) will be triggered. This event can be utilized for performing operations once the File Manager has been successfully created.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/view/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/view/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![FileManager switching view ](images/overview.PNG)

## Maintaining component state on page reload

The File Manager supports maintaining the component state on page reload. This can be achieved by enabling [EnablePersistence](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_EnablePersistence) property which maintains the following,
* Previous view of the File Manager - [View](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_View)
* Previous path of the File Manager - [Path](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Path)
* Previous selected items of the File Manager - [SelectedItems](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_SelectedItems)

For every operation in File Manager, ajax request will be sent to the server which then processes the request and sends back the response. When the ajax request is success, [Success](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Success) event will be triggered and [Failure](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Failure) event will be triggered if the request gets failed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/persistence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/persistence/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/persistence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/persistence/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![FileManager enable persistence](images/enable_persistence.PNG)

N> The files of the current folder opened in the File Manager can be refreshed programatically by calling `refreshFiles` method

## Rendering component in right-to-left direction

It is possible to render the File Manager in right-to-left direction by setting the [EnableRtl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_EnableRtl) API to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/rtl/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/rtl/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![FileManager enablertl](images/enable_rtl.PNG)

## Specifying the current path of the File Manager

The current path of the File Manager can be specified initially or dynamically using the [Path](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Path) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/path/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/path/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/path/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/path/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![FileManager enablertl](images/path.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/FileManager/ASP.NET%20MVC%20Razor%20Examples).