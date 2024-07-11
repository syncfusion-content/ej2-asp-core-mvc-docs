---
layout: post
title: Getting Started with EJ2 ASP.NET MVC PDF Viewer Control | Syncfusion
description: Learn how to getting started with PDF Viewer control in ASP.NET MVC application. You can view and comment on PDFs in ease and also can fill form fields. 
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET MVC Standalone PDF Viewer Control

The [ASP.NET MVC PDF Viewer](https://www.syncfusion.com/aspnet-mvc-ui-controls/pdf-viewer) control is used to viewing and printing PDF files in any web application. It provides the best viewing experience available with core interactions such as zooming, scrolling, text searching, text selection, and text copying. Thumbnail, bookmark, hyperlink and table of contents support provides easy navigation within and outside the PDF files. 

This section briefly explains about how to integrate ASP.NET MVC PDF Viewer control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Integrate PDF Viewer into an ASP.NET MVC application

1. Start Visual Studio and select **Create a new project**. 
2. Create a new ASP.NET MVC Web Application project. 
![Generate-ASP.NET-MVC-project-using-VS2022](AspNetMVC_Images/create-aspnet-mvc-project.png)
3. Choose the target framework. 
![Set-the-project-Name](AspNetMVC_Images/set-project-name.png)
4. Select Web Application pattern (MVC) for the project and then select **Create** button. 
![Select-web-application-pattern](AspNetMVC_Images/select-web-application-project.png)

## ASP.NET MVC PDF Viewer NuGet packages installation

To add .NET PDF Viewer control, the following NuGet packages need to be installed in your ASP.NET MVC application.

* [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5)

N> If you creating ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add style sheet

The theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls.

## Add script reference

Add the required scripts using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> While referring the scripts from the downloaded resources in your application, make sure to place the 'ej2-pdfviewer-lib' assets in the same directory as the 'ej2.min.js' script.

## Register Syncfusion Script Manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager in the ASP.NET MVC application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

N> Add the script manager `EJS().ScriptManager()` at the **end of `<body>`**.

## Add ASP.NET MVC PDF Viewer control

Add the Syncfusion ASP.NET MVC PDF Viewer control in `~/Views/Home/Index.cshtml` page. You can load a PDF file in the PDF Viewer by specifying the document name in the DocumentPath property as below.

{% tabs %}
{% highlight c# tabtitle="~/Index.cshtml" %}

@{
    ViewBag.Title = "Home Page";
}

<div>
    <div style="height:500px;width:100%;">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
    </div>
</div>

{% endhighlight %}
{% endtabs %}

[DocumentPath](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PdfViewer.PdfViewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_DocumentPath) is the property needed to load a PDF file in the PDF Viewer. 

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC PDF Viewer control will be rendered in the default web browser.

![ASP.NET MVC PDF Viewer Control](AspNetMVC_Images/pdfviewer-control.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/PDFViewer/ASP.NET%20MVC%20Razor%20Examples).

N> You can refer to our [ASP.NET MVC PDF Viewer](https://www.syncfusion.com/aspnet-mvc-ui-controls/pdf-viewer) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC PDF Viewer example](https://ej2.syncfusion.com/aspnetmvc/PdfViewer/Default#/material) to understand the core features of PDF Viewer.