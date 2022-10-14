---
layout: post
title: Filtering in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Menu Filtering in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Menu filtering in Gantt control

The Gantt control provides the menu filtering support for each column. You can enable the filter menu by setting the [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~AllowFiltering.html) to `true`. The filter menu UI will be rendered based on its column type, which allows you to filter data. You can filter the records with different operators.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/filtering/enablefilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enablefilter.cs" %}
{% include code-snippet/gantt/filtering/enablefilter/enablefilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/filtering/enablefilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enablefilter.cs" %}
{% include code-snippet/gantt/filtering/enablefilter/enablefilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~AllowFiltering.html) property should be set to `true` to enable the filter menu. Setting the [`Columns.AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttColumn~AllowFiltering.html) property to `false` prevents rendering filter menu for a particular column.


## Custom component in filter menu

The [`column.filter.ui`](../api/gantt/column/#filter) is used to add custom filter components to a particular column.
To implement a custom filter UI, define the following functions:

* `create`:  Creates a custom component.
* `write`: Wire events for a custom component.
* `read`: Read the filter value from the custom component.

In the following sample, the dropdown is used  as a custom component in the TaskName column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/filtering/customComponent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="customComponent.cs" %}
{% include code-snippet/gantt/filtering/customComponent/customComponent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/filtering/customComponent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="customComponent.cs" %}
{% include code-snippet/gantt/filtering/customComponent/customComponent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
