---
layout: post
title: Complex Data Binding in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Complex Data Binding in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Complex Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Complex Data Binding in ##Platform_Name## Tree Grid Component

You can achieve complex data binding in the treegrid by using the dot(.) operator in the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) in [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/tree-grid/columns-mvc/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/complexbinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/tree-grid/columns-mvc/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.