---
layout: post
title: Getting Started with ##Platform_Name## Document Editor Component
description: Checkout and learn about getting started with ##Platform_Name## Document Editor component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

This article provides a step-by-step introduction to configure Essential JS 2 setup and build a simple .NET Core web application with Razor pages using Visual Studio.

> Starting with v16.2.0.x, if you reference to Syncfusion assemblies from trial setup or NuGet feed, you should include a license key in your projects. Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to learn about registering Syncfusion license key in your ASP.NET Core application to use the components.

## Getting Started with ASP.NET Core 2.x

### Prerequisites

The official prerequisites to create and run an ASP.NET Core 2.x application on Windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-2.0#prerequisites-1).

### Create ASP.NET Core web application with Razor pages

1. Choose **File > New > Project...** in the Visual Studio menu bar.

    ![new project in aspnetcore2.x razor](images/new-project.png)

2. Select **Installed > Visual C# > .NET Core** and choose the required **.NET Framework** in the drop-down.

3. Select **ASP.NET Core Web Application** and change the application name and click **OK**.

    > The Essential JS 2 supports 4.5+ .NET Framework in the ASP.NET Core application. i.e. The minimum target framework is 4.5 for Syncfusion ASP.NET Core (Essential JS 2).

    ![aspnetcore2.x project template](images/aspnetcore2x-template.png)

4. Choose **.NET Core** with **ASP.NET Core 2.0** and select **Web Application**, and then click **OK**. Now, the web application project is created with default ASP.NET Core template.

    ![aspnetcore2.x razor web application template](images/aspnetcore2x-netcore-razor.png)

### Configure Essential JS 2 in the application

1. Add the [`Syncfusion.EJ2.AspNet.Core`](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package to the new application by using the Nuget Package Manager. Right-click the project and select **Manage NuGet Packages...**.

    > Refer to [this article](../nuget-packages) to learn more details about installing Essential JS 2 NuGet packages in various OS environment.

    ![aspnetcore2.x razor manage nuget packages](images/aspnetcore2x-razor-manage-nuget.png)

2. Search the `Syncfusion.EJ2.AspNet` in the **Browse** tab and install **Syncfusion.EJ2.AspNet.Core** NuGet package in the application.

    ![aspnetcore2.x razor install nuget packages](images/aspnetcore-nuget-package.png)

    The Essential JS 2 package will be included in the project, after the installation process is completed.

    > The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

3. Open the `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

4. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of `~/Pages/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

5. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Pages/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

6. Now, you can add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Pages` folder.

For example, the Document Editor component is added to the `~/Pages/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/getting-started/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/getting-started/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



For example, the Document Editor Container component is added to the `~/Pages/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor-continer.cs" %}
{% include code-snippet/document-editor-container/getting-started/document-editor-continer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor-continer.cs" %}
{% include code-snippet/document-editor-container/getting-started/document-editor-continer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Starting from `v19.3.0.x`, we have optimized the accuracy of text size measurements such as to match Microsoft Word pagination for most Word documents. This improvement is included as default behavior along with an optional API [to disable it and retain the document pagination behavior of older versions](../document-editor/how-to/disable-optimized-text-measuring).

## Frequently Asked Questions

* [How to localize the Documenteditor container](../document-editor/global-local).
* [How to load the document by default](../document-editor/how-to/open-default-document).
* [How to customize tool bar](../document-editor/how-to/customize-tool-bar).
* [How to resize Document editor component](../document-editor/how-to/resize-document-editor).
