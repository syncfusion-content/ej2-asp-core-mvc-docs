---
layout: post
title: Columns menu in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Columns menu in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Column menu in gantt control

The column menu has options to integrate features like sorting, filtering, and autofit. It will show a menu with the integrated feature when users click the Multiple icon of the column. To enable the column menu, you should set the [`ShowColumnMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ShowColumnMenu) property to true. The default items are displayed in the following table:

| Item | Description |
|-----|-----|
| `SortAscending` | Sort the current column in ascending order. |
| `SortDescending` | Sort the current column in descending order. |
| `AutoFit` | Auto fit the current column. |
| `AutoFitAll` | Auto fit all columns. |
| `Filter` | Show the filter option as given in the `filterSettings.type` property. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/columnMenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnMenu.cs" %}
{% include code-snippet/gantt/columns/columnMenu/columnMenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/columnMenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnMenu.cs" %}
{% include code-snippet/gantt/columns/columnMenu/columnMenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/columnMenu.png)

> You can disable the column menu for a particular column by setting the `Columns.ShowColumnMenu` to `false`.

## Column menu Events

During the resizing action, the gantt component triggers the below two events.

1. The [`columnMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnMenuOpen) event triggers before the column menu opens.
2. The [`columnMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnMenuClick) event triggers when the user clicks the column menu of the gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuEvents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuEvents.cs" %}
{% include code-snippet/gantt/columns/colMenuEvents/colMenuEvents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuEvents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuEvents.cs" %}
{% include code-snippet/gantt/columns/colMenuEvents/colMenuEvents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom Column Menu Item

Custom column menu items can be added by defining the `columnMenuItems`. Actions for this customized items can be defined in the [`columnMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnMenuClick) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuItem/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuItem.cs" %}
{% include code-snippet/gantt/columns/colMenuItem/colMenuItem.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuItem/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuItem.cs" %}
{% include code-snippet/gantt/columns/colMenuItem/colMenuItem.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize menu items for particular columns

Sometimes, you have a scenario that to hide an item from column menu for particular columns. In that case, you need to define the `columnMenuOpenEventArgs.hide` as true in the [`columnMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnMenuOpen) event.

The following sample, **Filter** item was hidden in column menu when opens for the **Task Name** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuAction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuAction.cs" %}
{% include code-snippet/gantt/columns/colMenuAction/colMenuAction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuAction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuAction.cs" %}
{% include code-snippet/gantt/columns/colMenuAction/colMenuAction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}