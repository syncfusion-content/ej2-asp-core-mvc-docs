---
layout: post
title: Passing Parameter To Server Exporting in ##Platform_Name## Grid Component
description: Learn here all about Passing Parameter To Server Exporting in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Passing Parameter To Server Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Passing additional parameters to the server when Exporting

You can pass the additional parameter in the [`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property by invoking **addParams** method. In the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, you can define params as key and value pair so it will receive at the server side when exporting.

In the below example, we have passed **recordcount** as **12** using **addParams** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/passing-params-exporting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Addtional-parameter.cs" %}
{% include code-snippet/grid/how-to/passing-params-exporting/addtional-parameter.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Addtional-parameter.cs" %}
{% include code-snippet/grid/how-to/passing-params-exporting/addtional-parameter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/passing-params-exporting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Addtional-parameter.cs" %}
{% include code-snippet/grid/how-to/passing-params-exporting/addtional-parameter.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Addtional-parameter.cs" %}
{% include code-snippet/grid/how-to/passing-params-exporting/addtional-parameter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

