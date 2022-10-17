---
layout: post
title: Column Chooser in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Column Chooser in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Chooser
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Chooser in ##Platform_Name## Tree Grid Component

The column chooser has options to show or hide columns dynamically. It can be enabled by defining the [`ShowColumnChooser`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ShowColumnChooser) as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can hide the column names in column chooser by defining the [`ShowInColumnChooser`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ShowColumnChooser) as false.

## Open column chooser by external button

The Column chooser can be displayed on a page through external button by invoking the **openColumnChooser** method with X and Y axis positions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.