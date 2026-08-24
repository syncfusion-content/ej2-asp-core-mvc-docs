---
layout: post
title: ##Platform_Name## TreeGrid Headers | Syncfusion
description: Learn how to configure and customize column headers in ##Platform_Name## TreeGrid, including header text and template options.
platform: ej2-asp-core-mvc
control: Headers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Headers in ##Platform_Name## TreeGrid

## Header text

By default, column header title is displayed from column [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Field) value. To override the default header title, you have to define the [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_HeaderText) value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> If both the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Field) and [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_HeaderText)
are not defined in the column, the column renders with **empty** header text.

## Header template

You can customize the header element by using the [`headerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_HeaderTemplate) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/header-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-core/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-core/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/treegrid/overview#/fluent2) to knows how to present and manipulate data.