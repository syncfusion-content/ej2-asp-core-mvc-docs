---
layout: post
title: Pane Content in ##Platform_Name## Splitter Control | Syncfusion
description: Learn here all about Pane Content in Syncfusion ##Platform_Name## Splitter component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pane Content
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pane content in Splitter Control

This section explains how to provide plain text content or HTML markup or integrate other Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC UI controls as content of splitter.

## HTML Markup

Splitter is a layout based container control. You can render the pane contents from existing HTML markups. Converting HTML markup as splitter pane is easy way to add the panes content dynamically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/htmlmarkup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/htmlmarkup/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/htmlmarkup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/htmlmarkup/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![HTML markup](./images/htmlmarkup.png)

## Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC UI controls

You can render any Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC UI controls along with their native and control events within splitter as pane content.

You can refer [Accordion within splitter](https://ej2.syncfusion.com/aspnetmvc/Splitter/AccordionNavigationMenu#/material) and [Listview within splitter](https://ej2.syncfusion.com/aspnetmvc/Splitter/DetailsView#/material) samples.

## Plain content

You can add the plain text as a pane contents using either inner HTML or [`Content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings) API.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/plain-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/plain-content/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/plain-content/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/plain-content/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Plain content](./images/plain-content.png)

## Pane content using selector

You can set HTML element as pane content, using the query selectors such as ID or CSS class selectors.

The following code demonstrates how to fetch an element from the document and load it to pane using its ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/selector-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/selector-content/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/selector-content/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/selector-content/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Selector content](images/selector-content.png)