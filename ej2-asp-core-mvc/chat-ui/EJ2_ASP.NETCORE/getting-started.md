---
layout: post
title: Getting Started with ASP.NET Core Chat UI Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Chat UI control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Chat UI
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Chat UI Control

This section briefly explains how to include the [ASP.NET Core Chat UI](https://www.syncfusion.com/aspnet-core-ui-controls/chat-ui) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Prerequisites

### .NET and Visual Studio compatibility

| .NET version | Minimum Visual Studio version |
|--------------|------------------------------|
| .NET 10.0 | Visual Studio 2026 18.0.0 or later |
| .NET 9.0 | Visual Studio 2022 17.12.0 or later |
| .NET 8.0 | Visual Studio 2022 17.8.0 or later |
| .NET Core SDK 3.1 | Visual Studio 2019 16.4 or later |
| .NET Core SDK 2.0 | Visual Studio 2017 15.7 or later |

### Browser support

|    Browser    |    Versions    |
|--------------|---------------|
|    Google Chrome, including Android & iOS    |    Latest Version  |
|    Mozilla Firefox    |    Latest Version  |
|    Microsoft Edge    |    Latest Version  |
|    Apple Safari, including iOS    |    Latest Version  |
|    Opera    |    Latest Version  |
|    Microsoft Internet Explorer    |    11  |

## Create an ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core packages

To add [ASP.NET Core Chat UI](https://www.syncfusion.com/aspnet-core-ui-controls/chat-ui) control in the app, open the NuGet package manager in Visual Studio *(Tools → NuGet Package Manager → Manage NuGet Packages for Solution)*, search for and install the [Syncfusion.AspNetCore.InteractiveChat](https://www.nuget.org/packages/Syncfusion.AspNetCore.InteractiveChat/) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes/) packages. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following commands.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.InteractiveChat -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helpers

After the packages are installed installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.InteractiveChat` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.InteractiveChat

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script are referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of the **~/Pages/Shared/_Layout.cshtml** 

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.InteractiveChat/scripts/sf-chat-ui.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Chat UI control

Add the [ASP.NET Core Chat UI](https://www.syncfusion.com/aspnet-core-ui-controls/chat-ui) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/chat-ui/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/chat-ui/getting-started/gettingstarted.cs %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Chat UI](https://www.syncfusion.com/aspnet-core-ui-controls/chat-ui) will render in your default web browser.

![ASP.NET Core Chat UI Control](images/chat-ui-component.webp)

## Configure messages and user

You can use the `<e-chatui-messages>` tag directive to group all the messages and `<e-chatui-message>` directive to define each message and the `<e-chatui-user>` tag directive to configure the current user for the chat.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/chat-ui/default-messages/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/chat-ui/default-messages/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Chat UI default messages](images/default-messages.webp)

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
