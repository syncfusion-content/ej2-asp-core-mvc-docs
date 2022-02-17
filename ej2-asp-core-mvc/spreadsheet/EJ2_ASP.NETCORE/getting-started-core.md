---
layout: post
title: Getting Started with ##Platform_Name## Spreadsheet Component
description: Checkout and learn about getting started with ##Platform_Name## Spreadsheet component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to create a simple Spreadsheet in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/) page for introduction part of the system requirements and configure the common specifications.

## Add Spreadsheet to the project

Spreadsheet component can be rendered by using the `ejs-spreadsheet` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the Spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/getting-started-core/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spreadsheet.cs" %}
{% include code-snippet/spreadsheet/getting-started-core/spreadsheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Spreadsheet.cs" %}
{% include code-snippet/spreadsheet/getting-started-core/spreadsheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Spreadsheet Sample](images/spreadsheet.PNG)

## Run the application

The following example shows a basic Spreadsheet component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/getting-started-core/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spreadsheet.cs" %}
{% include code-snippet/spreadsheet/getting-started-core/spreadsheet.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Spreadsheet.cs" %}
{% include code-snippet/spreadsheet/getting-started-core/spreadsheet.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [ASP.NET Core Spreadsheet](https://www.syncfusion.com/aspnet-core-ui-controls/spreadsheet) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Spreadsheet example](https://ej2.syncfusion.com/aspnetcore/Spreadsheet/DefaultFunctionalities#/material) that shows you how present and manipulate data, including editing, formulas, formatting, importing, and exporting.

## See Also

* [Data Binding](./data-binding)
* [Open and Save](./open-save)