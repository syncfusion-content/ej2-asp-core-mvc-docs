---
layout: post
title: Getting Started with ##Platform_Name## Chips Component
description: Checkout and learn about getting started with ##Platform_Name## Chips component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started

This section briefly explains about how to include a simple Chip in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add Chip to the project

We are going to render `Chip` control in **Index.cshtml** page.

```html

 @Html.EJS().ChipList("chip").Text("Janet Leverling").Render()

```

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of Chip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Chip Sample](./images/chip.png)
