---
layout: post
title: Getting Started with ##Platform_Name## Treeview Component
description: Checkout and learn about getting started with ##Platform_Name## Treeview component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

 This section briefly explains about how to include a simple [ASP.NET MVC TreeView](https://www.syncfusion.com/aspnet-mvc-ui-controls/treeview) in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started/) page for introduction part part of the system requirements and configure the common specifications.

## Adding control to the Application

TreeView control can be rendered by using the `EJS().TreeView()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the TreeView.

The following example shows a basic TreeView control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gettingstarted.cs" %}
{% include code-snippet/treeview/getting-started/gettingstarted.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gettingstarted.cs" %}
{% include code-snippet/treeview/getting-started/gettingstarted.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding data source

TreeView can load data either from local data sources or remote data services. This can be done using the dataSource property that is a member of the fields property. The dataSource property supports array of JavaScript objects and DataManager. Here, an array of JSON values is passed to the TreeView control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/self-referential/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selfreferential.cs" %}
{% include code-snippet/treeview/binding-data/self-referential/selfreferential.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/binding-data/self-referential/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selfreferential.cs" %}
{% include code-snippet/treeview/binding-data/self-referential/selfreferential.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](./images/binding-self.PNG)

> You can also explore our [ASP.NET MVC TreeView example](https://ej2.syncfusion.com/aspnetmvc/TreeView/DefaultFunctionalities#/material) to knows how to present and manipulate data.