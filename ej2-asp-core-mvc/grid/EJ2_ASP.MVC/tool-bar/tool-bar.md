---
layout: post
title: Tool Bar in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Tool Bar in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# ToolBar in ASP.NET MVC Grid Component

The Grid provides ToolBar support to handle grid actions. The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property accepts either the collection of built-in toolbar items and **ItemModel** objects for custom toolbar items or HTML element ID for toolbar template.

## Enable or disable toolbar items

You can enable/disable toolbar items by using the **enableItems** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/enable-disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-disable.cs" %}
{% include code-snippet/grid/toolbar/enable-disable/enable-disable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/enable-disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-disable.cs" %}
{% include code-snippet/grid/toolbar/enable-disable/enable-disable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Add toolbar at the bottom of Grid

You can add the Grid toolbar component at the bottom of Grid using the [Created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/toolbar-bottom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-bottom.cs" %}
{% include code-snippet/grid/toolbar/toolbar-bottom/toolbar-bottom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/toolbar-bottom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar-bottom.cs" %}
{% include code-snippet/grid/toolbar/toolbar-bottom/toolbar-bottom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}