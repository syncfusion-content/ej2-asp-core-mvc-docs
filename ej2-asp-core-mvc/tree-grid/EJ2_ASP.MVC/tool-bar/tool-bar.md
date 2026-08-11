---
layout: post
title: ##Platform_Name## TreeGrid Toolbar | Syncfusion
description: Learn how to customize the toolbar in ##Platform_Name## TreeGrid, including item control, toolbar placement, and toolbar templates.
platform: ej2-asp-core-mvc
control: Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Toolbar in ##Platform_Name## TreeGrid

The TreeGrid provides ToolBar support to handle treegrid actions. The [`Toolbar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Toolbar) property accepts either the collection of built-in toolbar items and [`ItemModel`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Toolbar.html#Syncfusion_EJ2_Navigations_Toolbar_Items) objects for custom toolbar items or HTML element ID for toolbar template.



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



N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/treegrid/overview#/fluent2) to knows how to present and manipulate data.