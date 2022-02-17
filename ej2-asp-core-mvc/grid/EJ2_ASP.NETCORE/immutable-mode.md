---
layout: post
title: Immutable Mode in ##Platform_Name## Grid Component
description: Learn here all about Immutable Mode in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Immutable Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Immutable Mode

The immutable mode optimizes the Grid re-rendering performance by using the object reference and [`deep compare`](https://dmitripavlutin.com/how-to-compare-objects-in-javascript/#4-deep-equality) concept. When performing the Grid actions, it will only re-render the modified or newly added rows and prevent the re-rendering of the unchanged rows.

To enable this feature, you have to set the [`enableImmutableMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableImmutableMode) property as **true**.

>* This feature uses the primary key value for data comparison. So, you need to provide the [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/immutable-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Immutable.cs" %}
{% include code-snippet/grid/immutable-mode/immutable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/immutable-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Immutable.cs" %}
{% include code-snippet/grid/immutable-mode/immutable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations

The following features are not supported in the immutable mode:

* Frozen rows and columns
* Row Template
* Detail Template
* Hierarchy Grid
* Column reorder
* Virtual scroll
* Infinite scroll
* Grouping
