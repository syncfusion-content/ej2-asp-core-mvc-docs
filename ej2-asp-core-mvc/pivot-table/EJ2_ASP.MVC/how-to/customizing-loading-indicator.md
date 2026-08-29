---
layout: post
title: How to customize the Pivot Table loading indicator | Syncfusion
description: Step-by-step example showing how to customize the loading indicator in the ASP.NET MVC Pivot Table using the SpinnerTemplate property.
platform: ej2-asp-core-mvc
control: Customizing Loading Indicator
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the Pivot Table loading indicator in ASP.NET MVC

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

