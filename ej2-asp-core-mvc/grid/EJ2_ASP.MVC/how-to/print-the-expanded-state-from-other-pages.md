---
layout: post
title: Print The Expanded State From Other Pages in ##Platform_Name## Grid Component
description: Learn here all about Print The Expanded State From Other Pages in Syncfusion ##Platform_Name## Grid component and more.
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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/hierarchyprint/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchyprint.cs" %}
{% include code-snippet/grid/how-to/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/hierarchyprint/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchyprint.cs" %}
{% include code-snippet/grid/how-to/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

