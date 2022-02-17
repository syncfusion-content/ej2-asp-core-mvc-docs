---
layout: post
title: Getting Started with ##Platform_Name## Drop Down Tree Component
description: Checkout and learn about getting started with ##Platform_Name## Drop Down Tree component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET CORE application to use our components.

This section briefly explains you about how to include simple **DropDown Tree** control in your ASP.NET Core application. You can refer to [ASP.NET Core Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Initialize DropDown Tree control to the Application

DropDown Tree control can be rendered by using the `ejs-dropdowntree` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DropDown Tree.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/dropdowntree/getting-started/default/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/dropdowntree/getting-started/default/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Running the above code will display the basic DropDown Tree on the browser.

## Binding data source

The Dropdown Tree control can load the data either from local data sources or remote data services. This can be done using the `dataSource` property that is a member of the `fields` property. The dataSource property supports nested list of data and DataManager. Here, nested list of data is passed to the Dropdown Tree control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/dropdowntree/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/dropdowntree/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![DropDownTree Sample](./images/getting-started.PNG)
