---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Collapse Grouped Rows At Initial Render of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Collapse Grouped Rows At Initial Render
publishingplatform: ##Platform_Name##
documentation: ug
---


# Collapse all grouped rows at initial render

You can collapse all the grouped rows at initial rendering by using [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event with  **collapseAll** method of the grid.

In the below demo, all the grouped rows are collapsed at initial rendering.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="collapseall" %}
{% include_relative code-snippet/how-to/collapse-grouped-rows/collapseall.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/collapse-grouped-rows/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="collapseall" %}
{% include_relative code-snippet/how-to/collapse-grouped-rows/collapseall.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/collapse-grouped-rows/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


