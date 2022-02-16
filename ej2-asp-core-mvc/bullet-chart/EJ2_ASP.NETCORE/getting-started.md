---
layout: post
title: Getting Started with ##Platform_Name## Bullet Chart Component
description: Checkout and learn about getting started with ##Platform_Name## Bullet Chart component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get start with ASP.NET Core application, need to ensure the following software to be installed on the machine.
* Visual Studio 2017
* DotNet Core 2.0

## Setup ASP.NET Core application with Essential JS 2 for ASP.NET Core

The following steps to create ASP.NET Core Application.

**Step 1:** Create ASP.NET Core Web Application with default template project in Visual Studio 2017.

![project selection](./images/default-template.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using Nugget Package Manager.

Open the `nuGet` package manager.

![nugget package install](./images/solution-explorer-core.png)

Install the **Syncfusion.EJ2** package to the application

![package install](./images/nuget-demo.png)

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

## Adding component to the Application

* Now open your view page to render our Syncfusion components.

```cs
<ejs-bulletchart id="container"></ejs-bulletchart>
```

## BulletChart With Data

This section explains how to plot local data to the Bullet Chart.

```javascript
<script type="text/javascript" >
        window.onLoad = function (args) {
            args.bulletChart.dataSource = data;
        }
        var data = [
       { value: 100, target: 80 },
       { value: 200, target: 180 },
       { value: 300, target: 280 },
       { value: 400, target: 380 },
       { value: 500, target: 480 },
        ];
</script>
```

Now assign the data to `dataSource` property. **value** and **target** values should be mapped with `valueField` and `targetField` respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/bullet-chart/getting-started/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/bullet-chart/getting-started/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add Bullet Chart Title

You can add a title using `title` property to the bullet chart to provide quick
information to the user about the data plotted in the bullet chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/bullet-chart/getting-started/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/bullet-chart/getting-started/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Ranges

You can add a range using `e-bullet-range` of the `e-bullet-range-collection`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/ranges/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/bullet-chart/getting-started/ranges/ranges.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/ranges/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/bullet-chart/getting-started/ranges/ranges.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip

You can use tooltip for the bullet chart by setting the `enable` property to true in `e-bulletchart-tooltipsettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/bullet-chart/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/getting-started/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/bullet-chart/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

