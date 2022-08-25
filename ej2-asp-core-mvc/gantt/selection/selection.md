---
layout: post
title: Selection in ##Platform_Name## Gantt Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection

Selection provides an option to highlight a row or a cell. It can be done using arrow keys or by scrolling down the mouse. To disable selection in the Gantt control, set the [`AllowSelection`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~AllowSelection.html) to false.

The Gantt control supports two types of selection that can be set by using the [`SelectionSettings.Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSelectionSettings~Type.html) property. They are:

* `Single`: Sets a single value by default and allows only selection of a single row or a cell.
* `Multiple`: Allows you to select multiple rows or cells. To perform the multi-selection, press and hold the CTRL key and click the desired rows or cells.

## Selection mode

The Gantt control supports three types of selection modes that can be set by using the [`SelectionSettings.Mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSelectionSettings~Mode.html). They are:

* `Row`: Allows you to select only rows, and the row value is set by default.
* `Cell`: Allows you to select only cells.
* `Both`: Allows you to select rows and cells at the same time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/bothType/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="BothType.cs" %}
{% include code-snippet/gantt/selection/bothType/bothType.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/bothType/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BothType.cs" %}
{% include code-snippet/gantt/selection/bothType/bothType.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}