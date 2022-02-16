---
layout: post
title: Collapse Grouped Rows At Initial Render in ##Platform_Name## Grid Component
description: Learn here all about Collapse Grouped Rows At Initial Render in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Collapse Grouped Rows At Initial Render
publishingplatform: ##Platform_Name##
documentation: ug
---


# Collapse all grouped rows at initial render

You can collapse all the grouped rows at initial rendering by using [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event with **collapseAll** method of the grid.

In the below demo, all the grouped rows are collapsed at initial rendering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/collapse-grouped-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Collapseall.cs" %}
{% include code-snippet/grid/how-to/collapse-grouped-rows/collapseall.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/collapse-grouped-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Collapseall.cs" %}
{% include code-snippet/grid/how-to/collapse-grouped-rows/collapseall.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


