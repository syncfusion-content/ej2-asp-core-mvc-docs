---
layout: post
title: Column Chooser in ##Platform_Name## Grid Component
description: Learn here all about Column Chooser in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Column Chooser
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Chooser

The column chooser has options to show or hide columns dynamically. It can be enabled by defining the
[`ShowColumnChooser`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnChooser) as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can hide the column names in column chooser by defining the [`ShowInColumnChooser`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ShowInColumnChooser) as false.

## Open column chooser by external button

The Column chooser can be displayed on a page through external button by invoking
the **openColumnChooser** method with X and Y axis positions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/externalbutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/grid/columns/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/externalbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/grid/columns/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


