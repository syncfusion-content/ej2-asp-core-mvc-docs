---
layout: post
title: Responsive Columns in ##Platform_Name## Grid Component
description: Learn here all about Responsive Columns in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Responsive Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# Responsive Columns

You can toggle column visibility based on media queries which are defined
at the [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HideAtMedia).
The [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HideAtMedia) accepts valid
[Media Queries]( http://cssmediaqueries.com/what-are-css-media-queries.html ).In the below sample, for **OrderID** column, [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HideAtMedia) property value is set as **(min-width: 700px)** so that **OrderID** column will gets hidden when the browser screen width is lessthan 700px.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/responsivecolumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Responsivecolumns.cs" %}
{% include code-snippet/grid/columns/responsivecolumns/responsivecolumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/responsivecolumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Responsivecolumns.cs" %}
{% include code-snippet/grid/columns/responsivecolumns/responsivecolumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

