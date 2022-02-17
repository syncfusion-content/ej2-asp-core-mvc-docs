---
layout: post
title: Getting Started with ##Platform_Name## Accordion Component
description: Checkout and learn about getting started with ##Platform_Name## Accordion component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Asp Core
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Accordion Component

This section briefly explains about how to include [ASP.NET Core Accordion](https://www.syncfusion.com/aspnet-core-ui-controls/accordion) component in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core components](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

 * [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

 * [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

 ## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core components are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core components in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper
Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}
    
## Add ASP.NET Core Accordion Component

Now, add the Syncfusion ASP.NET Core Accordion tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

        <div class="control_wrapper accordion-control-section">
            <ejs-accordion id="defaultAccordion">
                <e-accordion-accordionitems>
                    <e-accordion-accordionitem expanded="true" header="ASP.NET" content="Microsoft ASP.NET is a set of technologies in the Microsoft .NET Framework for building Web applications and XML Web services. ASP.NET pages execute on the server and generate markup such as HTML, WML, or XML that is sent to a desktop or mobile browser. ASP.NET pages use a compiled,event-driven programming model that improves performance and enables the separation of application logic and user interface."></e-accordion-accordionitem>
                    <e-accordion-accordionitem header="ASP.NET MVC" content="The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller. The ASP.NET MVC framework provides an alternative to the ASP.NET Web Forms pattern for creating Web applications. The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication."></e-accordion-accordionitem>
                    <e-accordion-accordionitem header="JavaScript" content="JavaScript (JS) is an interpreted computer programming language.It was originally implemented as part of web browsers so that client-side scripts could interact with the user, control the browser, communicate asynchronously, and alter the document content that was displayed.More recently, however, it has become common in both game development and the creation of desktop applications."></e-accordion-accordionitem>
                </e-accordion-accordionitems>
            </ejs-accordion>
        </div>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Accordion component will be rendered in the default web browser.

[ASP.NET Core Accordion component - Getting Started](../../accordion/images/accordion.PNG)
    

## See Also

1. [Getting Started with Syncfusion ASP.NET Core for client-side in Visual Studio](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
2. [Getting Started with Syncfusion ASP.NET Core using Project Template](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)