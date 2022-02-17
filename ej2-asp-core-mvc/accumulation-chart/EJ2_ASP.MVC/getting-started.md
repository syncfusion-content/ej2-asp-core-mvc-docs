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

# Getting Started with ASP.NET MVC

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Preparing ASP.NET MVC application

The following steps to create ASP.NET MVC Application.

**Step 1:** Create ASP.NET MVC Application with default template project in Visual Studio.

![Default Template](./images/default-template.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using `NuGet Package Manager`.

Open the `NuGet` package manager.

![Solution Explorer](./images/solution-explorer-mvc.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo.png)

After installation complete, this will be included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as a dependency, since **Syncfusion.EJ2** dependent to `NewtonSoft.JSON` package.

**Step 3:** Add `Syncfusion.EJ2` namespace reference in `Web.config`

```cs
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>

```

```cs
<system.web>
    <compilation>
      <assemblies>
        <add assembly="Syncfusion.EJ2" Version=15.3400.0.27, Culture=neutral, PublicKeyToken=31BF3856AD364E35"/>
      </assemblies>
    </compilation>
  </system.web>
```

**Step 4:** Add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page `_Layout.cshtml`.

```html
<head>
@* Syncfusion Essential JS 2 Styles *@
<link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>
```

**Step 5:** Adding Script Manager in layout page `_Layout.cshtml`.

```cs
@Html.EJS().ScriptManager()
```

**Step 6:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the accumulation chart.

```html

 @(Html.EJS().AccumulationChart("container").Render())

```

**Pie Series**

By default, the pie series will be rendered when assigning the JSON data to the series using the
[`dataSource`](../api/accumulation-chart/accumulationSeriesModel/#datasource)
property. Map the field names in the JSON data to the
[`xName`](../api/accumulation-chart/accumulationSeriesModel/#xname) and
[`yName`](../api/accumulation-chart/accumulationSeriesModel/#yname) properties of the series.

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