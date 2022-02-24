---
layout: post
title: Reordering on Grouped Columns in ##Platform_Name## Grid Component
description: Learn here all about Reordering on Grouped Columns in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Reordering on Grouped Columns
publishingplatform: aspnet-core
documentation: ug
---


# Reordering on Grouped Columns

Grid provides an option to interchange the position of the Grouped Columns by dragging and dropping the grouped headercells in the droparea. So, any new column entering into the droparea can also be dropped in any position.

To enable this feature, you have to set the [`allowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html) of **e-grid-groupsettings** property as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/reordering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GroupOrdering.cs" %}
{% include code-snippet/grid/grouping/reordering/GroupOrdering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/reordering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GroupOrdering.cs" %}
{% include code-snippet/grid/grouping/reordering/GroupOrdering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

