---
layout: post
title: Getting Started with ##Platform_Name## Kanban Component
description: Checkout and learn about getting started with ##Platform_Name## Kanban component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains how to include simple **Kanban** control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [`link`](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

## Adding Kanban control to the application

* Add the Kanban control in view page to render our Syncfusion controls.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/getting-started/default/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/getting-started/default/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Initialize the Kanban

* Kanban control can be rendered with the help of `@Html.EJS().Kanban` tag helper. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder, where the Kanban is initialized.

## Run the application

After successful compilation of your application, simply press `F5` to run the application.

The below example shows the Kanban.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/getting-started/default/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/getting-started/default/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will display the empty Kanban.

![kanban](./images/default.PNG)

## Populating cards

To populate the empty Kanban with cards, define the list or remote data using the `DataSource` property. To define `DataSource`, the mandatory fields in the list should be relevant to `KeyField`. In the following example, you can see the cards defined with default fields such as ID, Summary, and Status.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/populating-cards/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/getting-started/populating-cards/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/populating-cards/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/getting-started/populating-cards/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/populating-cards.PNG)

## Enable swimlane

`Swimlane` can be enabled by mapping the tags `SwimlaneSettings.KeyField` to appropriate column name in dataSource. This enables the grouping of the cards based on the mapped column values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/enable-swimlane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/getting-started/enable-swimlane/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/getting-started/enable-swimlane/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/getting-started/enable-swimlane/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/enable-swimlane.PNG)
