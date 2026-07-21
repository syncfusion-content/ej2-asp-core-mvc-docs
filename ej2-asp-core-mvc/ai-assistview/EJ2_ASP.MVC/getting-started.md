---
layout: post
title: Getting Started with ASP.NET MVC AI AssistView Control | Syncfusion
description: Check out and learn about getting started with ASP.NET MVC AI AssistView control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: AI AssistView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET MVC AI AssistView control

This section briefly explains how to include the [ASP.NET MVC AI AssistView](https://www.syncfusion.com/aspnet-mvc-ui-controls/ai-assistview) control in your ASP.NET MVC application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Prerequisites

### .NET and Visual Studio compatibility

| .NET Version | Visual Studio Version |
|--------------|------------------------------|
| .NET Framework 4.6.2 | Visual Studio 2015 Update 3 or later |

### Browser support

|    Browser    |    Versions    |
|--------------|---------------|
|    Google Chrome, including Android & iOS    |    Latest Version  |
|    Mozilla Firefox    |    Latest Version  |
|    Microsoft Edge    |    Latest Version  |
|    Apple Safari, including iOS    |    Latest Version  |
|    Opera    |    Latest Version  |
|    Microsoft Internet Explorer    |    11  |

## Create an ASP.NET MVC Web App with HTML Helper

Create an **ASP.NET MVC Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app) or the [Syncfusion® ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET MVC Getting Started](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-mvc-htmlhelper) documentation.

## Install the required ASP.NET MVC package

To add **ASP.NET MVC AI AssistView** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetMvc.InteractiveChat](https://www.nuget.org/packages/Syncfusion.AspNetMvc.InteractiveChat/) package. All Syncfusion ASP.NET MVC packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetMvc.InteractiveChat -Version {{ site.releaseversion }}

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

The theme stylesheet and script are referenced from the [CDN](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) inside the `<head>` of the **~/Views/Shared/_Layout.cshtml**.

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

## Add ASP.NET MVC AI AssistView control

Add the [ASP.NET MVC AI AssistView](https://www.syncfusion.com/aspnet-mvc-ui-controls/ai-assistview) control in the **~/Views/Home/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/ai-assistview/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/ai-assistview/getting-started/gettingstarted.cs %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET MVC AI AssistView](https://www.syncfusion.com/aspnet-mvc-ui-controls/ai-assistview) control will render in your default web browser.

![ASP.NET MVC AI AssistView Control](images/ai-assistview-component.webp)

> **Note:** Starting from version 33.1x, when a user submits a prompt to the AI AssistView, the component automatically scrolls and focuses on the latest prompt and response. This behavior eliminates the need for users to manually scroll down to see the new response, ensuring they always view the most recent AI response without interruption. Prior to version 33.1x, the previous responses remained visible when new responses were added.

## Configure suggestions and responses

You can use the [PromptSuggestions](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptSuggestions) property to add prompt suggestions and the [PromptRequest](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptRequest) event to add responses when the prompt matches the specified prompts data otherwise, the default response will be displayed.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/ai-assistview/defaultprompts/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/ai-assistview/defaultprompts/defaultprompt.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC AI AssistView default prompt](images/default-prompt.webp)