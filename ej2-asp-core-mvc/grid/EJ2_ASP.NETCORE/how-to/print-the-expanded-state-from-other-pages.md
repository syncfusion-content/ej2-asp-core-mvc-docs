---
layout: post
title: Print The Expanded State From Other Pages in ##Platform_Name## Grid Component
description: Learn here all about Print The Expanded State From Other Pages in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Print The Expanded State From Other Pages
publishingplatform: ##Platform_Name##
documentation: ug
---

# Print the expanded state from other pages

By default, when printing, the Syncfusion Grid component only includes the expanded child grids visible on the current page. However, you can enhance the printing functionality to include expanded child grids from other pages. This can be achieved using the  [load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) and [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) events, which help manage the expanded state of rows across different pages.

The following example demonstrates how to print the expanded child grids from other pages:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/hierarchyprint/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchyprint.cs" %}
{% include code-snippet/grid/how-to/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% endtabs %}

