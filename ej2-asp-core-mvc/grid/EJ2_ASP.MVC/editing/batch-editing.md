---
layout: post
title: Batch Editing in ##Platform_Name## Grid Component
description: Learn here all about Batch Editing in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Batch Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Batch Editing

In batch edit mode, when you double-click on the grid cell, then the target cell changed to edit state. You can bulk save (added, changed and deleted data in the single request) to data source by click on the toolbar's **Update** button or by externally calling the **batchSave** method. To enable Batch edit, set the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Batch**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/grid/edit/batch/batch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/grid/edit/batch/batch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> If a column's [AllowEditing](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing) property is set to false, then the focus can be skipped in that non-editable column by clicking the tab or shift-tab key while in batch edit mode.

## Cancel edit based on condition in batch mode

You can prevent the CRUD operations of the Batch edit Grid by using condition in the `cellEdit`, `beforeBatchAdd` and `beforeBatchDelete` events for Edit, Add and Delete actions respectively.

In the below demo, we prevent the CRUD operation based on the `Role` column value. If the Role Column is `Employee`, we are unable to edit/delete that row.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cancel-edit-batch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Canceleditbatch.cs" %}
{% include code-snippet/grid/edit/cancel-edit-batch/canceleditbatch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cancel-edit-batch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Canceleditbatch.cs" %}
{% include code-snippet/grid/edit/cancel-edit-batch/canceleditbatch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Confirmation dialog

By default, grid will show the confirm dialog when saving or cancelling or performing any actions like filtering, sorting, etc.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchconfirm/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batchconfirm.cs" %}
{% include code-snippet/grid/edit/batchconfirm/batchconfirm.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchconfirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batchconfirm.cs" %}
{% include code-snippet/grid/edit/batchconfirm/batchconfirm.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> [`ShowConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowConfirmDialog) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html)requires the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) to be **Batch**.
> If [`ShowConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowConfirmDialog) set to **false**, then confirmation dialog does not display in batch editing.