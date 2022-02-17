---
layout: post
title: Getting Started with ##Platform_Name## Barcode Component
description: Checkout and learn about getting started with ##Platform_Name## Barcode component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get start with ASP.NET Core application, need to ensure the following software to be installed on the machine.
* Visual Studio 2017
* DotNet Core 2.0

## Setup ASP.NET Core application with Essential JS 2 for ASP.NET Core

The following steps to create ASP.NET Core Application.

**Step 1:** Create ASP.NET Core Web Application with default template project in Visual Studio 2017.

![Alt text](./images/default-template.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using Nugget Package Manager.

Open the `nuGet` package manager.

![Alt text](./images/solution-explorer-core.png)

Install the **Syncfusion.EJ2** package to the application

![Alt text](./images/nuget-demo.png)

After Installation complete this will included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as dependency since it **Syncfusion.EJ2** dependent to NewtonSoft.JSON package.

**Step 3:** Open the **Views/_ViewImports.cshtml** to import Syncfusion.EJ2 package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

**Step 4:** Add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **Views/Shared/_Layout.cshtml.**

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>
```

**Step 5:** Adding Script Manager in layout page **Views/Shared/_Layout.cshtml.**

```cs
<body>
    @RenderBody()
    @RenderSection("Scripts", required: false)
<ejs-scripts></ejs-scripts>
</body>
```

**Step 6:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the barcode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/getting-started/barcode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Barcode.cs" %}
{% include code-snippet/barcode/getting-started/barcode/barcode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/getting-started/barcode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Barcode.cs" %}
{% include code-snippet/barcode/getting-started/barcode/barcode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add Barcode to the project

Create and add a `barcode` (JSON data) with specific size, value .

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/getting-started/barcode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Barcode.cs" %}
{% include code-snippet/barcode/getting-started/barcode/barcode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/getting-started/barcode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Barcode.cs" %}
{% include code-snippet/barcode/getting-started/barcode/barcode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding QR Generator control

You can add the QR code in our barcode generator component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/getting-started/qrcode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Qrcode.cs" %}
{% include code-snippet/barcode/getting-started/qrcode/qrcode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/getting-started/qrcode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Qrcode.cs" %}
{% include code-snippet/barcode/getting-started/qrcode/qrcode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding Datamatrix Generator control

You can add the datamatrix code in our barcode generator component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/getting-started/datamatrix/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datamatrix.cs" %}
{% include code-snippet/barcode/getting-started/datamatrix/datamatrix.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/getting-started/datamatrix/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datamatrix.cs" %}
{% include code-snippet/barcode/getting-started/datamatrix/datamatrix.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

