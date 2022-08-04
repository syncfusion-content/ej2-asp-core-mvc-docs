---
layout: post
title: Complex Data Binding in ##Platform_Name## Tree Grid Component
description: Learn here all about Complex Data Binding in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Complex Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Complex Data Binding

You can achieve complex data binding in the treegrid by using the dot(.) operator in the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/complex-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ComplexData.cs" %}
{% include code-snippet/tree-grid/columns-core/complex-data/complexData.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ComplexData.cs" %}
{% include code-snippet/tree-grid/columns-core/complex-data/complexData.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.