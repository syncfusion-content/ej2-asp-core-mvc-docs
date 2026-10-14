---
layout: post
title: Drag and Drop in ##Platform_Name## Query Builder | Syncfusion
description: Learn how to reorder rules and groups in ##Platform_Name## Query Builder using drag-and-drop functionality and related events.
platform: ej2-asp-core-mvc
control: Drag and drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag and Drop in ##Platform_Name## Query Builder

The Query Builder provides the functionality to reposition rules or groups within the component effortlessly. This enhancement provides a more intuitive and flexible way to construct and modify queries. You can use [`AllowDragAndDrop`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_AllowDragAndDrop) to enable drag-and-drop functionality. The Query Builder also supports events for the drag-and-drop feature, which indicate the [`DragStart`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_DragStart), [`Drag`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_Drag) and [`Drop`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_Drop) actions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/drag-and-drop/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/drag-and-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/drag-and-drop/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The output will be as shown below.

![Query builder Sample](images/drag-and-drop.png)
