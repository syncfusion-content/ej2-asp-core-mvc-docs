---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Complex Data Binding of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Complex Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Complex Data Binding

You can achieve complex data binding in the grid by using the dot(.) operator in the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/complexbinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/grid/columns/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/complexbinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/grid/columns/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

