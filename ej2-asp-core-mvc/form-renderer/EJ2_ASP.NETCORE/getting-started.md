---
layout: post
title: Getting Started with ASP.NET Core Form Renderer | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## Form Renderer of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Form Renderer

The Form Renderer is a powerful, schema-driven component that enables you to build and render complex forms with ease using a structured JSON schema definition. It streamlines form creation, customization, and data capture by letting you define form layouts, fields, and validation declaratively and then render them through a simple component property binding.

This section briefly explains how to include the ASP.NET Core Form Renderer in an ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create an ASP.NET Core Web App with Razor Pages

{% tabcontents %}

{% tabcontent Visual Studio %}

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project).

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Run the following command to create a new ASP.NET Core Web App.

{% tabs %}
{% highlight C# tabtitle="Terminal" %}

dotnet new webapp -o RazorPagesFormRenderer
code -r RazorPagesFormRenderer

{% endhighlight %}
{% endtabs %}

Alternatively, create an ASP.NET Core Web App using Visual Studio Code via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio-code#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-code-integration/create-project), or the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extension.

{% endtabcontent %}

{% endtabcontents %}


## Install the required ASP.NET Core packages

Install the [Syncfusion.AspNetCore.FormRenderer](https://www.nuget.org/packages/Syncfusion.AspNetCore.FormRenderer) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes) NuGet packages. All Syncfusion ASP.NET Core packages are available on [nuget.org](https://www.nuget.org/packages?q=Syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for more details.

{% tabcontents %}

{% tabcontent Visual Studio %}

1. Go to *Tools → NuGet Package Manager → Manage NuGet Packages for Solution*.
2. Search the required NuGet packages (`Syncfusion.AspNetCore.FormRenderer` and `Syncfusion.AspNetCore.Themes`) and install them.

Alternatively, you can install the same packages using the Package Manager Console with the following commands.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.FormRenderer -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

Open the terminal and run the following commands.

{% tabs %}
{% highlight C# tabtitle="Terminal" %}

dotnet add package Syncfusion.AspNetCore.FormRenderer --version {{ site.releaseversion }}
dotnet add package Syncfusion.AspNetCore.Themes --version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

## Add ASP.NET Core tag helpers

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.FormRenderer` and `Syncfusion.AspNetCore.Base` tag helpers.

{% tabs %}
{% highlight C# tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.FormRenderer
@addTagHelper *, Syncfusion.AspNetCore.Base

{% endhighlight %}
{% endtabs %}


## Add stylesheet and script resources

The theme stylesheet and script can be referenced from NuGet through [Static Web Assets](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#static-web-assets). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of the **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    <script src="_content/Syncfusion.AspNetCore.FormRenderer/scripts/sf-formrenderer.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the script manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager (`<ejs-scripts>`) at the end of the `<body>` element as shown below.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Form Renderer

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Form Renderer tag helper in the `~/Pages/FormRenderer/Default.cshtml` page.

The Form Renderer control builds a form from a JSON-based `Schema` and renders the matching EJ2 input controls automatically. The schema has three parts: `Properties` (the form fields), `Layout` (how the fields are arranged in panels and tables), and `Settings` (form-level options such as name and width). In this example, a **Login Form** is built with an email address, password, a remember checkbox, and a Submit button.

### Create the page model

Add the following code to define the model that provides the schema for the Form Renderer component's `schema` property.

{% tabs %}
{% highlight cshtml tabtitle="Default.cshtml" %}

@page
@model FormRenderer.DefaultModel
@using Syncfusion.EJ2.FormRenderer

<ejs-formrenderer id="registrationForm" schema="Model.FormSchema"></ejs-formrenderer>

{% endhighlight %}
{% highlight C# tabtitle="Default.cshtml.cs" %}

    public class DefaultModel : PageModel
    {
        public Schema FormSchema { get; set; }

        public void OnGet()
        {
            FormSchema = new Schema
            {
                Version = "0.1.0",
                Properties = new Dictionary<string, BaseProperty>
                {
                    ["emailAddress"] = new TextboxProperty { Id = "t1", Name = "emailAddress", Type = "string", Label = "Email Address", TextboxType = "email", Required = true, Widget = "textbox" },
                    ["password"] = new TextboxProperty { Id = "t2", Name = "password", Type = "string", Label = "Password", TextboxType = "password", Required = true, MinLength = 6, Widget = "textbox" },
                    ["rememberMe"] = new CheckboxProperty { Id = "c1", Name = "rememberMe", Type = "boolean", Label = "Remember Me", Widget = "checkbox" },
                    ["submit"] = new SubmitButtonProperty { Id = "s1", Name = "submit", Type = "button", Label = "Submit", ButtonType = "submit", Widget = "button", Style = "primary", Disabled = false }
                },
                Layout = new List<LayoutNode>
                {
                    new LayoutNode { Type="field", PropertyId="emailAddress" },
                    new LayoutNode { Type="field", PropertyId="password" },
                    new LayoutNode { Type="field", PropertyId="rememberMe" },
                    new LayoutNode { Type="field", PropertyId="submit" }
                },
                Settings = new SchemaSettings { Name = "Login Form" }
            };
        }
    }
    public abstract class BaseProperty
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("label")] public string Label { get; set; }
        [JsonProperty("widget")] public string Widget { get; set; }
        [JsonProperty("size")] public string Size { get; set; }
    }
    public class TextboxProperty : BaseProperty
    {
        [JsonProperty("textboxType")] public string TextboxType { get; set; }
        [JsonProperty("required")] public bool Required { get; set; }
        [JsonProperty("minLength")] public int? MinLength { get; set; }
    }
    public class CheckboxProperty : BaseProperty { }
    public class SubmitButtonProperty : BaseProperty
    {
        [JsonProperty("buttonType")] public string ButtonType { get; set; }
        [JsonProperty("style")] public string Style { get; set; }
        [JsonProperty("disabled")] public bool Disabled { get; set; }
    }
    public class Schema
    {
        [JsonProperty("version")] public string Version { get; set; }
        [JsonProperty("properties")] public Dictionary<string, BaseProperty> Properties { get; set; }
        [JsonProperty("layout")] public List<LayoutNode> Layout { get; set; }
        [JsonProperty("settings")] public SchemaSettings Settings { get; set; }
    }
    public class SchemaSettings { [JsonProperty("name")] public string Name { get; set; } }
    public class LayoutNode { [JsonProperty("type")] public string Type { get; set; } [JsonProperty("propertyId")] public string PropertyId { get; set; } }

 

{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The ASP.NET Core Form Renderer will render in your default web browser.

![ASP.NET Core Form Renderer](../images/form-renderer.png)
