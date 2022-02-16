---
layout: post
title: Complex Data Binding in ##Platform_Name## Grid Component
description: Learn here all about Complex Data Binding in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Complex Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Complex Data Binding

You can achieve complex data binding in the grid by using the dot(.) operator in the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property of **e-grid-column** tag helper.

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



For OData and ODataV4 adaptors, you need to add [`expand`](https://ej2.syncfusion.com/documentation/api/data/query/#expand) query to the [`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property (of Grid), to eager load the complex data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/query/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Query.cs" %}
{% include code-snippet/grid/columns/query/query.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/query/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Query.cs" %}
{% include code-snippet/grid/columns/query/query.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

