---
layout: post
title: Defer Update in ASP.NET Core Pivot Table | Syncfusion
description: Learn how the ASP.NET Core Pivot Table defers layout recalculation in the field list until the user clicks Apply, improving performance on large reports.
platform: ej2-asp-core-mvc
control: Pivot Table
publishingplatform: ##Platform_Name##
documentation: ug
---

# Defer update in ASP.NET Core Pivot Table

Defer layout update support allows updating the pivot table component only on demand, significantly improving performance for complex data operations. When this feature is enabled, users can drag-and-drop fields between row, column, value, and filter axes and apply sorting and filtering inside the Field List. These changes update the pivot report configuration without immediately updating the pivot table values. Once all operations are performed and the **Apply** button is clicked in the Field List, the pivot table updates with the final modified report. This approach reduces multiple unnecessary renders and brings better performance, especially when working with large datasets or performing multiple field operations.

The field list can be displayed in two different formats to interact with the pivot table:

* **In-built Field List (Popup)**: Displays the field list icon in the pivot table UI to invoke the built-in dialog.
* **Stand-alone Field List (Fixed)**: Displays the field list in a static position within a web page.

## In-built Field List (Popup)

To enable deferred updates in the pivot table, set the [`allowDeferLayoutUpdate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDeferLayoutUpdate) property to **true** in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html). Note that the defer update option can only be controlled via the Field List at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/defer-update/popup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DeferUpdate.cs" %}
{% include code-snippet/pivot-table/defer-update/popup/DeferUpdate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/defer-update/popup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DeferUpdate.cs" %}
{% include code-snippet/pivot-table/defer-update/popup/DeferUpdate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Defer update in popup field list](images/fieldlist_deferupdate.png)

## Stand-alone Field List (Fixed)

The field list can be rendered in a static position anywhere in the web page layout, functioning as a separate component. To achieve this, set the [`renderMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_RenderMode) property to [**Fixed**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Mode.html) in [`e-pivotfieldlist`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html).

To enable deferred updates in the static field list, set the [`allowDeferLayoutUpdate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_AllowDeferLayoutUpdate) in [`e-pivotfieldlist`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html) as **true**. Note that the defer update option can only be controlled via the Field List at runtime.

> To make the field list interact with the pivot table, use the `updateView` and `update` methods to synchronize data source updates between both the field list and pivot table components simultaneously.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/defer-update/static/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Static.cs" %}
{% include code-snippet/pivot-table/defer-update/static/Static.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/defer-update/static/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Static.cs" %}
{% include code-snippet/pivot-table/defer-update/static/Static.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Defer update in fixed field list](images/defer-update-static.png)

## See Also

* [Field List](./field-list)
* [Grouping Bar](./grouping-bar)
* [Data binding](./data-binding)