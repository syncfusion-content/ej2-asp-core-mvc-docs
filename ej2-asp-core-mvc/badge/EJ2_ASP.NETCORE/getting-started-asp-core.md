---
layout: post
title: Getting Started with ##Platform_Name## Badge Component
description: Checkout and learn about getting started with ##Platform_Name## Badge component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Asp Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to render Badge component in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started/) page for introduction part of the system requirements and configure the common specifications.

> Starting with `v16.2.0.x`, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP .NET Core application to use our components.

## Adding Badge component to the Application

Since the `Badge` is a CSS component there is no need to html tag helper, the component is added by using
CSS classes. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder.

```html
<h1>Badge Component <span class="e-badge">New</span></h1>
```

## Run the application

After successful compilation of your application, simply press `F5` to run the application.

The following example shows a basic Badge.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/getting-started/core/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/getting-started/core/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/getting-started/core/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/getting-started/core/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Badge Sample](./images/badge.PNG)

## See Also

[Types of Badge](./types)