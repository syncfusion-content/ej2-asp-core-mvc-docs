---
layout: post
title: Getting Started with ##Platform_Name## Query Builder Component
description: Checkout and learn about getting started with ##Platform_Name## Query Builder component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to create a simple [Query Builder](https://www.syncfusion.com/aspnet-core-ui-controls/query-builder) in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add Query Builder to the project

To create simple Query Builder add the `ejs-querybuilder` tag with id attribute as `element` in your **Index.cshtml** page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/querybuilder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/querybuilder/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/querybuilder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/querybuilder/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of Query Builder.

Output be like the below.

![querybuilder Sample](./images/querybuilder.png)

## Render with rule

The following example shows a basic Query Builder component with rule.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![querybuilder Sample](./images/querybuilder-rule.png)

> You can also explore our [ASP.NET Core Query Builder example](https://ej2.syncfusion.com/aspnetcore/QueryBuilder/DefaultFunctionalities#/material) that shows how to render and configure the Query Builder in ASP.NET Core.
