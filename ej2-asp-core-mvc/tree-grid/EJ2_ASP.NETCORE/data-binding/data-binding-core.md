---
layout: post
title: Data Binding Core in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Data Binding Core in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data binding in ##Platform_Name## Tree Grid Component

The TreeGrid uses **DataManager**, which supports both RESTful JSON data services binding and local JavaScript object array binding. The [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DataSource) property can be assigned either with the instance of **DataManager** or JavaScript object array collection.
It supports two kinds of data binding method:
* Local data
* Remote data



## Binding with ajax

You can use TreeGrid [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DataSource) property to bind the data source to TreeGrid from external Fetch request. In the below code we have fetched the data source from the server with the help of Fetch request and provided that to [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DataSource) property by using **onSuccess** event of the Fetch.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/ajax-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ajax.cs" %}
{% include code-snippet/tree-grid/data-binding-core/ajax-data/ajax.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Ajax.cs" %}
{% include code-snippet/tree-grid/data-binding-core/ajax-data/ajax.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> * If you bind the dataSource from this way, then it acts like a local dataSource. So you cannot perform any server side crud actions.
<br/> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.

> * If you bind the dataSource from this way, then it acts like a local dataSource. So you cannot perform any server side crud actions.



## Handling expandStateMapping

To denotes the expand status of parent row, define the [`expandStateMapping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ExpandStateMapping) property of tree grid.

The `expandStateMapping` property maps the field name in data source, that denotes whether parent record is in expanded or collapsed state and this is useful to renders parent row in expanded or collapsed state based on this mapping property value in data source.



{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-core/expandstatemapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandStateMapping.cs" %}
{% include code-snippet/tree-grid/data-binding-core/expandstatemapping/expandstatemapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ExpandStateMapping.cs" %}
{% include code-snippet/tree-grid/data-binding-core/expandstatemapping/expandstatemapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.

