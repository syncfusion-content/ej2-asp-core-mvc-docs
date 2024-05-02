---
layout: post
title: Getting Started with EJ2 ASP.NET Core PDF Viewer Control | Syncfusion
description: Learn how to getting started with PDF Viewer control in ASP.NET Core application. You can view and comment on PDFs in ease and also can fill forms.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ej2-asp-core-mvc
documentation: ug
---

# Getting Started with ASP.NET Core Standalone PDF Viewer control

The [ASP.NET Core PDF Viewer](https://www.syncfusion.com/aspnet-core-ui-controls/pdf-viewer) control is used to viewing and printing PDF files in any web application. It provides the best viewing experience available with core interactions such as zooming, scrolling, text searching, text selection, and text copying. Thumbnail, bookmark, hyperlink and table of contents support provides easy navigation within and outside the PDF files.

This section briefly explains about how to integrate ASP.NET Core PDF Viewer control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Integrate PDF Viewer into an ASP.NET Core application

1. Start Visual Studio and select **Create a new project**.
2. In the **Create a new project** dialog, select **ASP.NET Core Web App**.
![select-aspnet-core-web-app](Core_Images/Select-aspnet-core-project.png)
3. In the **Configure your new project** dialog, enter *Project Name* and select Next.
![Set-project-name](Core_Images/Set-project-name.png)
4. In the **Additional information** dialog, select **.NET 6.0 (Long-term Support) and then select Create**.
![Set-framework](Core_Images/additional-info.png)

## ASP.NET Core PDF Viewer NuGet package installation

To add ASP.NET Core PDF Viewer control, the following NuGet package need to be installed in your ASP.NET Core application.

* [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/)

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add style sheet

The theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls.

## Add script reference

Add the required scripts using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> While referring the scripts from the downloaded resources in your application, make sure to place the 'ej2-pdfviewer-lib' assets in the same directory as the 'ej2.min.js' script.

## Register Syncfusion Script Manager

Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager in the ASP.NET Core application as follows.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
    ....
    ....
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

N> Add the script manager `<ejs-script>` at the **end of `<body>`**.

## Add ASP.NET Core PDF Viewer control

Add the Syncfusion ASP.NET Core PDF Viewer tag helper in `~/Pages/Index.cshtml` page. You can load a PDF file in the PDF Viewer by specifying the document name in the documentPath property as below.

{% tabs %}
{% highlight c# tabtitle="~/Index.cshtml" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% endtabs %}

In the above code,

**ejs-pdfviewer** refers to the PDF Viewer control among the EJ components with id as "pdfviewer".

**documentPath** is the property needed to load a PDF file in the PDF Viewer.

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core PDF Viewer control will be rendered in the default web browser.

![ASP.NET Core PDF Viewer Control](Core_Images/pdfviewer-control.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/PDFViewer/ASP.NET%20Core%20Tag%20Helper%20Examples%20-%20Standalone%20PDF%20Viewer).

## Limitation over Server-Backed PDF Viewer to Standalone PDF Viewer control

When comparing a Standalone PDF Viewer to a Server-Backed PDF Viewer control, it's crucial to understand the limitations that the Standalone PDF Viewer may have in comparison. These limitations are important to consider

### Local File Access

* The Standalone PDF Viewer control does not have the capability to directly access and load local physical files from a user's device. As a result, it is not possible to use a documentPath to load a PDF file directly from a local server within the viewer.

* The Standalone PDF Viewer allows users to export annotations and form fields from the viewer, it's important to be aware that the viewer does not support the direct import of annotations and form fields from a locally specified file path. In other words, you can extract annotations and form fields from the viewer, but you cannot reintroduce them into the viewer from external sources by specifying a file path located on your local device.

N> These limitations are temporary and are expected to be addressed in the near future.

## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)