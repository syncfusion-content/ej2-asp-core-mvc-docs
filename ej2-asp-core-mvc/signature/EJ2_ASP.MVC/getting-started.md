---
layout: post
title: Getting Started with ##Platform_Name## Signature Component
description: Checkout and learn about getting started with ##Platform_Name## Signature component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC

> Starting with v19.3.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our components.

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Create ASP.NET MVC application

Create ASP.NET MVC Application with default template project in Visual Studio 2017.

![Default Template](./images/default-template-mvc.png)

## Adding Syncfusion package

Once your project created, we need to add Syncfusion EJ2 MVC package into your application by using **NuGet Package Manager**.

Open the **NuGet** package manager.

![Solution Explorer](./images/solution-explorer-mvc.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo-mvc.png)

After Installation completed the Syncfusion DLL's will be included in the project.

> You need to install **NewtonSoft.JSON** as dependency since **Syncfusion.EJ2.MVC** dependent to NewtonSoft.JSON package.

Add **Syncfusion.EJ2** namespace reference in **Web.config** under **Views** folder.

```cs
<namespaces>
<add namespace="Syncfusion.EJ2"/>
</namespaces>

```

## Adding Scripts and CSS reference

You can add client side resource through **NuGet** package manager or [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) in the layout page **Views/Shared/_Layout.cshtml**

NuGet Package Manager:

Install the **Syncfusion.EJ2.Javascript** package to the application.

![Nuget Demo](./images/script-nuget.jpg)

After Installation completed the script and CSS will be included in the project under the **Scripts** and **Content** folder.

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link href="~/Content/ej2/material.css" rel="stylesheet" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="~/Scripts/ej2/ej2.min.js"></script>
</head>
```

> **Syncfusion.EJ2.Javascript** includes typescript declaration files. If your application is not configured to compile typescript then exception may occur. To resolve this please refer [`here`](./how-to/avoid-typescript-compilation/).

CDN Link:

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js">
</head>
```

## Adding ScriptManager in layout page

Add **ScriptManager** to the bottom of the **_Layout.cshtml** page. The ScriptManager used to place our control initialization script in the page.

```cs
@Html.EJS().ScriptManager()
```

## Add Signature Control

To initialize the Signature control add the below code to your **Index.cshtml** view page which is present under **Views/Home** folder.

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
