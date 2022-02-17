---
layout: post
title: Getting Started with ##Platform_Name## Breadcrumb Component
description: Checkout and learn about getting started with ##Platform_Name## Breadcrumb component of Syncfusion, and more details.
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

![Alt text](./images/solution-explorer-core.png)

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
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
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

## Add Breadcrumb component

To initialize the Breadcrumb component add the below code to your `Index.cshtml` view page which is present under `Views/Home` folder.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/default.PNG)

## Add Items to the Breadcrumb Component

Use `items` property to bind items for Breadcrumb component. The below example demonstrates the basic rendering of Breadcrumb with items support.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/items.PNG)

## Enable or Disable Navigation

This feature enables or disables the item navigation. By default, the navigation will be enabled when setting `Url` property. To prevent breadcrumb item navigation, set `enableNavigation` property as false in Breadcrumb. The below example shows enabling and disabling the navigation of Breadcrumb items.

The following example shows a Enable or disable navigation of Breadcrumb.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/enable-disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/getting-started/enable-disable/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/enable-disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/getting-started/enable-disable/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/enable-disable.png)
