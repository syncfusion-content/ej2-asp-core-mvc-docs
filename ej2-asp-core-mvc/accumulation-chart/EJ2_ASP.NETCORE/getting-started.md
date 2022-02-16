---
layout: post
title: Getting Started with ##Platform_Name## Accumulation Chart Component
description: Checkout and learn about getting started with ##Platform_Name## Accumulation Chart component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

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

**Step 6:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the Accumulationchart.

```cs
<ejs-accumulationchart id="container" title="Mobile Browser Statistics">
            <e-accumulationchart-legendsettings visible="false">
            </e-accumulationchart-legendsettings>
            <e-accumulation-series-collection>
                <e-accumulation-series dataSource="ViewBag.dataSource" xName="xValue" yName="yValue" name="Browser">
                </e-accumulation-series>
            </e-accumulation-series-collection>
        </ejs-accumulationchart>
```

**Pie Series**

By default, the pie series will be rendered when assigning the JSON data to the series using the
[`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_DataSource)
property. Map the field names in the JSON data to the
[`xName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_XName) and
[`yName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_YName) properties of the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/initial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/initial/initial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/initial/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initial.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/initial/initial.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](./images/accumulationchart.png)