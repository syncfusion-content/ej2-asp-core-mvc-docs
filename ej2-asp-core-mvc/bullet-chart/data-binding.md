---
layout: post
title: Data Binding in ASP.NET MVC Bullet Chart Component
description: Learn here all about Data Binding in Syncfusion ASP.NET MVC Bullet Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ej2-asp-core-mvc 
documentation: ug
---


# Working with Data

[ASP.NET MVC Bullet Chart](https://www.syncfusion.com/aspnet-mvc-ui-controls/bullet-chart) can visualise data bound from local or remote data.

## Local Data

You can bind a simple JSON data to the chart using [DataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_DataSource) direct property of the bullet-chart. Now, map the fields in JSON to [`valueField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBuilder.html) and [`targetField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBuilder.html) properties. The `dataSource` property accepts a collection of values as input that helps to display measures, and compares them to a target bar. To display the actual and target bar, specify the property from the datasource into the `valueField` and `targetField` respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/working-with-data/working-with-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Working-with-data.cs" %}
{% include code-snippet/bullet-chart/working-with-data/working-with-data/working-with-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/working-with-data/working-with-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Working-with-data.cs" %}
{% include code-snippet/bullet-chart/working-with-data/working-with-data/working-with-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Data Binding in Bullet Chart](images/blazor-bullet-chart-data-binding.png)