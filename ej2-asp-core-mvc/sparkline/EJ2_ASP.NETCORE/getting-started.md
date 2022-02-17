---
layout: post
title: Getting Started with ##Platform_Name## Sparkline Component
description: Checkout and learn about getting started with ##Platform_Name## Sparkline component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core

This section explains you the steps required to create a Sparkline and demonstrate the basic usage of the Sparkline control.

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

![Alt text](./images/solution-Explorer.png)

Install the **Syncfusion.EJ2** package to the application

![Alt text](./images/nuget-demo.png)

After Installation complete this will included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as dependency since it **Syncfusion.EJ2** dependent to NewtonSoft.JSON package.

**Step 3:** Open the **_ViewImports.cshtml** to import Syncfusion.EJ2 package.

```cs
@addTagHelper *, Syncfusion.EJ2
```

**Step 4:** Add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **_Layout.cshtml.**

```cs
@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
```

**Step 5:** Adding Script Manager in layout page **_Layout.cshtml.**

```cs
<ejs-scripts></ejs-scripts>
```

**Step 6:** Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the smith chart.

```html

@using Syncfusion.EJ2;
 <ejs-sparkline id="sparkline">
</ejs-sparkline>

```

## Bind data source to Sparkline

The [`dataSource`] property is used for binding data source to the sparkline. This property takes the collection value as input. For example, the list of objects can be provided as input.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/data-source/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data-source.cs" %}
{% include code-snippet/sparkline/getting-started/data-source/data-source.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/data-source/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-source.cs" %}
{% include code-snippet/sparkline/getting-started/data-source/data-source.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change the type of Sparkline

You can change the sparkline type by setting the [`type`] property to [`Line`], [`Column`], [`WinLoss`], [`Pie`], or [`Area`]. Here, the sparkline type has been set to [`area`].

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Type.cs" %}
{% include code-snippet/sparkline/getting-started/type/type.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Type.cs" %}
{% include code-snippet/sparkline/getting-started/type/type.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable tooltip for Sparkline

The sparkline displays additional information through tooltip when the mouse is hovered over the sparkline. You can enable tooltip by setting the [`visible`] property to true in [`tooltipSettings`] object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/sparkline/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/sparkline/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


