---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Print The Expanded State From Other Pages of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Print The Expanded State From Other Pages
publishingplatform: ##Platform_Name##
documentation: ug
---


# Print the expanded state from other pages

By default, the expanded child grids will be printed from the current page alone. You can print the expanded child grids from other pages by using the [`Load`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) and [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event.

In the following example, we have printed expanded child grids form other pages.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="hierarchyprint" %}
{% include_relative code-snippet/how-to/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="hierarchyprint" %}
{% include_relative code-snippet/how-to/hierarchyprint/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="hierarchyprint" %}
{% include_relative code-snippet/how-to/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% highlight razor tabtitle="hierarchyprint" %}
{% include_relative code-snippet/how-to/hierarchyprint/razor %}
{% endhighlight %}
{% endtabs %}

