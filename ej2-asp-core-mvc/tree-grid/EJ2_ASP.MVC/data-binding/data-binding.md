---
layout: post
title: Data Binding in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data binding in ##Platform_Name## Tree Grid Component

The TreeGrid uses **DataManager**, which supports both RESTful JSON data services binding and local JavaScript object array binding. The [`DataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) property can be assigned either with the instance of **DataManager** or JavaScript object array collection.

It supports two kinds of data binding method:
* Local data
* Remote data

## Binding with ajax

You can use TreeGrid [`DataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) property to bind the data source to TreeGrid from external ajax request. In the below code we have fetched the data source from the server with the help of ajax request and provided that to [`DataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) property by using **onSuccess** event of the ajax.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Ajaxbind.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/ajaxbind/ajaxbind.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/ajaxbind/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ajaxbind.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/ajaxbind/ajaxbind.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




N> If you bind the dataSource from this way, then it acts like a local dataSource. So you cannot perform any server side crud actions.
<br/> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.

> If you bind the dataSource from this way, then it acts like a local dataSource. So you cannot perform any server side crud actions.



## Handling expandStateMapping

To denotes the expand status of parent row, define the [`ExpandStateMapping`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.treegrid.treegrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ExpandStateMapping) property of tree grid.

The `ExpandStateMapping` property maps the field name in data source, that denotes whether parent record is in expanded or collapsed state and this is useful to renders parent row in expanded or collapsed state based on this mapping property value in data source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="ExpandStateMapping.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/expandstatemapping/expandstatemapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/data-binding-mvc/expandstatemapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandStateMapping.cs" %}
{% include code-snippet/tree-grid/data-binding-mvc/expandstatemapping/expandstatemapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.

