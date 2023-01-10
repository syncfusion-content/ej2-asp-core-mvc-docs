---
layout: post
title: Column resizing in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Column resizing in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Column resizing in gantt control

The column width can be resized by clicking and dragging the right edge of the column header. While dragging, the width of the column will be resized immediately. Each column can be auto resized by double-clicking the right edge of the column header to fit the width of that column based on the widest cell content. To resize the column, set the [`AllowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowResizing) property to true. The following code example shows how to enable the column resize feature in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/resizeColumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ResizeColumns.cs" %}
{% include code-snippet/gantt/columns/resizeColumns/resizeColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/resizeColumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ResizeColumns.cs" %}
{% include code-snippet/gantt/columns/resizeColumns/resizeColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable resizing for a particular column by setting the [`Columns.AllowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_AllowResizing) to `false`.

## Defining minimum and maximum column width

The column resizing can be restricted between minimum and maximum widths by defining the [`Columns->MinWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_MinWidth) and [`Columns->MaxWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_MaxWidth) properties.

In the following example, the minimum and maximum widths are defined for the `Duration`, and `Task Name` columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/minMaxWidth/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MinMaxWidth.cs" %}
{% include code-snippet/gantt/columns/minMaxWidth/minMaxWidth.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/minMaxWidth/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MinMaxWidth.cs" %}
{% include code-snippet/gantt/columns/minMaxWidth/minMaxWidth.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}