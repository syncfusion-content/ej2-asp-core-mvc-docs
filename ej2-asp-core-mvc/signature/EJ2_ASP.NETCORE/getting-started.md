---
layout: post
title: Getting Started with ##Platform_Name## Signature Component
description: Checkout and learn about getting started with ##Platform_Name## Signature component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

> Starting with v19.3.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get started with ASP.NET Core application, need to ensure the following software to be installed on the machine.
* Visual Studio 2017
* .Net Core 2.0

## Create ASP.NET Core application

Create ASP.NET Core Web Application with default template project in Visual Studio 2017.

![Alt text](./images/default-template.png)

## Adding Syncfusion package

Using NuGet Package Manager we need to add **Syncfusion.EJ2.AspNet.Core** package into your application.

Open the `NuGet` package manager.

![Alt text](/images/solution-explorer-core.png)

Install the **Syncfusion.EJ2.AspNet.Core** package to the application

![Alt text](./images/nuget-package-demo.png)

After Installation completed the Syncfusion DLL's will be included in the project.

> We need to install **NewtonSoft.JSON** as dependency since **Syncfusion.EJ2.AspNet.Core** dependent to NewtonSoft.JSON package.

Open the **Views/_ViewImports.cshtml** to import Syncfusion.EJ2.AspNet.Core package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

## Adding Scripts and CSS reference

We can add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or NPM [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **Views/Shared/_Layout.cshtml**

CDN Link:

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js">
</head>
```

NPM Package:

Install `@syncfusion/ej2` package using below command.

> npm install @syncfusion/ej2

Now the required scripts and CSS files are available in the **../node_modules/@syncfusion/ej2/dist** and CSS **../node_modules/@syncfusion/ej2/styles** package folders respectively. Copy those script and themes files from the `node_modules` into the `wwwroot` folder of the application.

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link href="~/styles/material.css" rel="stylesheet" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="~/scripts/ej2.min.js"></script>
</head>
```

## Adding ScriptManager in layout page

Add `ScriptManager` to the bottom of the `_Layout.cshtml` page. The ScriptManager used to place our control initialization script in the page.

```cs
<body>
@RenderBody()
@RenderSection("Scripts", required: false)
<ejs-scripts></ejs-scripts>
</body>
```

## Add Signature Control

To initialize the Signature control add the below code to your `Index.cshtml` view page which is present under `Views/Home` folder.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/signature/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/getting-started/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/signature/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/getting-started/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Signature Sample](./images/default.PNG)
