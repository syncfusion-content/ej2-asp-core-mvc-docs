---
layout: post
title: Getting Started with ##Platform_Name## Listview Component
description: Checkout and learn about getting started with ##Platform_Name## Listview component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to render ListView component in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started/) page for introduction part of the system requirements and configure the common specifications.

> Starting with `v16.2.0.x`, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP .NET MVC application to use our components.

## Initialize the ListView component and add to the Application

ListView component can be rendered with the help of `@Html.EJS().ListView` tag helper. Now open your view page and add the below code which initializes the ListView component.

```cs
@*ListView with Empty DataSource*@
@Html.EJS().ListView("listview").Render()

```

## Bind dataSource

After initialization, populate the ListView with data using the `dataSource` property. Here, the JSON values are passed to the ListView component.

```cs
public IActionResult Index()
        {
            //define the array of JSON
            List<object> data = new List<object>();
            data.Add(new { text: "Artwork", id: "01" });
            data.Add(new { text: "Abstract", id: "02" });
            data.Add(new { text: "Modern Painting", id: "03" });
            data.Add(new { text: "Ceramics", id: "04" });
            data.Add(new { text: "Animation Art", id: "05" });
            data.Add(new { text: "Oil Painting", id: "06" });
            ViewBag.dataSource = data;
            return View();
        }

```

```cs
    @*ListView with DataSource*@
    @Html.EJS().ListView("listview").DataSource((IEnumerable<object>)ViewBag.dataSource).Render()

```

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a basic ListView.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/getting-started/mvc/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/listview/getting-started/mvc/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/getting-started/mvc/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/listview/getting-started/mvc/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ListView Sample](./images/listview.PNG)

## See Also

[Data Binding Types](./data-binding)

[ListView customization](./customizing-templates)

[Virtualization](./virtualization)