---
layout: post
title: Group and Caption Aggregate in ##Platform_Name## Grid Component
description: Learn here all about Group and Caption Aggregate in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Group and Caption Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---


# Group and Caption Aggregate

Group and caption aggregate values are calculated from the current group items.
If [`groupFooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupFooterTemplate) is provided, the aggregate values are displayed in the group footer cells; and if [`groupCaptionTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupCaptionTemplate) is provided, aggregate values are displayed in the group caption cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/group-caption/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-caption.cs" %}
{% include code-snippet/grid/aggregate/group-caption/group-caption.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/group-caption/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-caption.cs" %}
{% include code-snippet/grid/aggregate/group-caption/group-caption.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The aggregate values must be accessed inside the template using their corresponding [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) name.