---
layout: post
title: Customize Loading Spinner in ASP.NET MVC Pivot Table | Syncfusion
description: Learn how to customize the ASP.NET MVC Pivot Table's loading spinner via the SpinnerTemplate property, accepting an HTML string for custom styling.
platform: ej2-asp-core-mvc
control: Customizing Loading Indicator
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Customize the Loading Indicator in ASP.NET MVC Pivot Table

The Pivot Table displays a loading indicator during data processing operations such as filtering, sorting, and aggregation calculations. The default loading spinner can be customized to match application design requirements using the [`SpinnerTemplate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_SpinnerTemplate) property.

The [`SpinnerTemplate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_SpinnerTemplate) property accepts an HTML string that defines the custom loading indicator appearance. This enables control over the visual presentation, including custom styling and animations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/loading-indicator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/loading-indicator/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/loading-indicator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/loading-indicator/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

