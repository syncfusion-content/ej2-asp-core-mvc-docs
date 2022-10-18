---
layout: post
title: Tool Bar in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Tool Bar in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# ToolBar in ##Platform_Name## Tree Grid Component

The TreeGrid provides ToolBar support to handle treegrid actions. The [`Toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html) property accepts either the collection of built-in toolbar items and [`ItemModel`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ToolbarItem_members.html) objects for custom toolbar items or HTML element ID for toolbar template.



## Enable/disable toolbar items

You can enable/disable toolbar items by using the **enableItems** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/toolbar-enable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-enable.cs" %}
{% include code-snippet/tree-grid/toolbar/toolbar-enable/toolbar-enable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/toolbar/toolbar-enable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-enable.cs" %}
{% include code-snippet/tree-grid/toolbar/toolbar-enable/toolbar-enable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.