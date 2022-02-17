---
layout: post
title: Defer Update in ##Platform_Name## Pivot Table Component
description: Learn here all about Defer Update in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Defer Update
publishingplatform: ##Platform_Name##
documentation: ug
---


# Defer Layout Update

Defer layout update support allows to update the pivot table component only on demand. On enabling this feature, end user can drag-and-drop fields between row, column, value and filter axes, apply sorting and filtering inside the Field List, resulting in change of pivot report alone but not the pivot table values. Once all operations are performed and on clicking the "Apply" button in the Field List, pivot table will start to update with the last modified report. This also helps in bringing better performance in pivot table component rendering.

The field list can be displayed in two different formats to interact with pivot table. They are:

* **In-built Field List (Popup)**: To display the field list icon in pivot table UI to invoke the built-in dialog.
* **Stand-alone Field List (Fixed)**: To display the field list in a static position within a web page.

## In-built Field List (Popup)

To enable deferred updates in the pivot table, set the property [`allowDeferLayoutUpdate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDeferLayoutUpdate) in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) as **true**. To make a note, the defer update option can be controlled only via Field List during runtime.

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



![output](images/fieldlist_deferupdate.png)

## Stand-alone Field List (Fixed)

The field list can be rendered in a static position, anywhere in web page layout, like a separate component. To do so, you need to set [`renderMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_RenderMode) property to [**Fixed**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.Mode.html) in [`e-pivotfieldlist`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html).

To enable deferred updates in the static fieldlist, set the property [`allowDeferLayoutUpdate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_AllowDeferLayoutUpdate) in [`e-pivotfieldlist`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html) as **true**. To make a note, the defer update option can be controlled only via Field List during runtime.

> To make field list interact with pivot table, you need to use the **UpdateView** and **Update** methods for data source update in both field list and pivot table simultaneously.

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



![output](images/defer-update-static.png)