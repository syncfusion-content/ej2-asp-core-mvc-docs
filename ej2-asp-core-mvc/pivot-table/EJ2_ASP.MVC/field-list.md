---
layout: post
title: Field List in ##Platform_Name## Pivot Table Component
description: Learn here all about Field List in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Field List
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pivot Field List

The pivot table provides a built-in Field List similar to Microsoft Excel. It allows to add or remove fields and also rearrange them between different axes, including column, row, value, and filter along with sort and filter options dynamically at runtime.

The field list can be displayed in two different formats to interact with pivot table. They are:

* **In-built Field List (Popup)**: To display the field list icon in pivot table UI to invoke the built-in dialog.
* **Stand-alone Field List (Fixed)**: To display the field list in a static position within a web page.

## In-built Field List (Popup)

To enable the field list in pivot table UI, set the [`ShowFieldList`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true**. A small icon will appear on the top left corner of the pivot table and clicking on this icon, field list dialog will appear.

> The field list icon will be displayed at the top right corner of the pivot table, when grouping bar is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/fieldlist/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD012 -->
![output](images/gs_fieldlist_icon.png "Field list icon at the top left of the pivot table component")
<br/>
![output](images/gs_fieldlist_dialog.png "Field list dialog for user interaction")


## Stand-alone Field List (Fixed)

The field list can be rendered in a static position, anywhere in web page layout, like a separate component. To do so, you need to set [`RenderMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_RenderMode) property to [**Mode.Fixed**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Mode.html) in [`PivotFieldList`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html).

> To make field list interact with pivot table, you need to use the **UpdateView** and **Update** methods for data source update in both field list and pivot table simultaneously.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/static/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Static.cs" %}
{% include code-snippet/pivot-table/field-list/static/Static.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/static/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Static.cs" %}
{% include code-snippet/pivot-table/field-list/static/Static.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/staticfieldlist.png "Static FieldList")

## Invoking dynamic Field List (Customized)

Also, you can display the field list dialog independently through other means. For example, you can invoke the field list dialog on an external button click. To do so, set [`RenderMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_RenderMode) property to [**Mode.Popup**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Mode.html) and  since on button click, field list dialog will be invoked.

> * Meanwhile, you can display the field list dialog at specific target element within a webpage using `target` property. By default, the `target` value is null, which refers the `document.body` element.
> * Moreover, to make field list interact with pivot table, you need to use the **updateView** and **update** methods for data source update in both field list and pivot table simultaneously.

The below sample code illustrates the field list dialog invoked on an external button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/popup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/pivot-table/field-list/popup/Popup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/popup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/pivot-table/field-list/popup/Popup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/fieldlist-custom.png "FieldList in Button")

## Add or remove fields

Using check box besides each field, end user can select or unselect to add or remove fields respectively from the report at runtime.

![output](images/fieldlist_treeview.png)

## Remove specific field(s) from displaying

When a data source is bound to the component, fields will be automatically populated inside the Field List. In such case, user can also restrict specific field(s) from displaying. To do so, set the appropriate field name(s) in [`ExcludeFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExcludeFields) property belonging to [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/exclude-fields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/field-list/exclude-fields/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/exclude-fields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/field-list/exclude-fields/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/fieldlist_hide.png)

## Re-arranging fields

In-order to re-arrange, drag any field from the field list and drop it into the column, row, value, or filter axis using the drag-and-drop holder. It helps end user to alter the report at runtime.

![output](images/fieldlist_axes.png)

## Filtering members

Using the filter icon besides each field in row, column and filter axes, members can be either included or excluded at runtime. To know more about member filtering, [`refer`](./filtering) here.

![output](images/fieldlist_filtericon.png "Filter icon besides each field")
<br/>
![output](images/fieldlist_editor.png "Filter dialog to either include or exclude members")
<br/>
![output](images/fieldlist_filteringgrid.png "Resultant pivot table on filtering members")

## Sorting members

Using the sort icon besides each field in row and column axes, members can be arranged either in ascending or descending order at runtime. To know more about member sorting, [`refer`](./sorting) here.

![output](images/fieldlist_sorticon.png "Sort icon besides each field")
<br/>
![output](images/fieldlist_sortgrid.png "Resultant pivot table showing countries in descending order")

## Calculated fields

The calculated field support allows end user to add a new calculated field based on the available fields from the bound data source using basic arithmetic operators. To enable this support in Field List UI, set the [`AllowCalculatedField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowCalculatedField) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true** in pivot table. Now a button will be seen automatically inside the field list UI which will invoke the calculated field dialog on click. To know more about calculated field, [`refer`](./calculated-field) here.

![output](images/gs_calc_button.png "Enabling calculated field in field list UI")
<br/>
![output](images/gs_calc_dialog.png "Creating new calculated field")
<br/>
![output](images/gs_calc_grid.png "New calculated field 'Total Amount' added in pivot table")

## Changing aggregation type of value fields at runtime

End user can perform calculations over a group of values using the aggregation option. The value fields bound to the field list, appears with a dropdown icon, helps to select an appropriate aggregation type at runtime. On selection, the values in the Pivot Table will be changed dynamically. To know more about aggregation, [`refer`](./aggregation) here.

![output](images/aggregation_fl_icon.png "Icon to change aggregation type")
<br/>
<br/>
![output](images/fieldlist_aggregation_avg.png "List of pre-defined aggregation types")
<br/>
![output](images/fieldlist_aggregation_grid.png "Resultant pivot table showing average aggregation type applied in 'Unit Sold' value field")

## Defer layout update

Defer layout update support to update the pivot table only on demand and not during every user action. To enable this support in Field List UI, set the [`AllowDeferLayoutUpdate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDeferLayoutUpdate) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true** in pivot table. Now a check box inside Field List UI will be seen in checked state, allowing pivot table to update only on demand. To know more about defer layout, [`refer`](./defer-update) here.

![output](images/fieldlist_deferupdate.png)

## Show built-in Field List (Popup) over specific target

By passing the target element to the built-in field list dialog module in the [`dataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event, the field list dialog will be displayed over the appropriate target element on a web page. By default, the Pivot Table's parent element is used as the target element to display the built-in field list dialog.

The sample code below shows the built-in field list dialog using `document.body` as the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/fieldlist-on-specifictarget/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist-on-specifictarget.cs" %}
{% include code-snippet/pivot-table/field-list/fieldlist-on-specifictarget/fieldlist-on-specifictarget.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/fieldlist-on-specifictarget/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist-on-specifictarget.cs" %}
{% include code-snippet/pivot-table/field-list/fieldlist-on-specifictarget/fieldlist-on-specifictarget.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/popup-fieldlist-specifictarget.png)

## Show field list using toolbar

It can also be viewed in toolbar by setting [`ShowFieldList`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDeferLayoutUpdate) and [`ShowToolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDeferLayoutUpdate) properties in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true**. Also, include the item **FieldList** within the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDeferLayoutUpdate) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class. When toolbar is enabled, field list icon will be automatically added into the toolbar and the icon won't appear on top left corner in the pivot table component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/field-list/toolbar/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/field-list/toolbar/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/fieldlist_toolbar.png)

## Set caption to fields which isn’t bound to the report

One can set the caption to all fields from the data source even if it is not bound to the actual report. It can be achieved using the [`EnginePopulated`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_EnginePopulated) event. On doing so, caption of the respective field will be displayed in both grouping bar and field list.

In the sample, we have set caption to the fields `Year` and `Quarter` dynamically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/fieldlist-caption/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/field-list/fieldlist-caption/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/fieldlist-caption/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/field-list/fieldlist-caption/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/fieldlist_caption1.png)

During runtime, the **Values** button in the field list can be moved to a different position (i.e., different index) among other fields in the column or row axis. To enable the **Values** button, set the [`showValuesButton`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_ShowValuesButton) property to **true**.

> This support is only available for relational data sources.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/fieldlist-valuesbutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist-valuesbutton.cs" %}
{% include code-snippet/pivot-table/field-list/fieldlist-valuesbutton/fieldlist-valuesbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/fieldlist-valuesbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist-valuesbutton.cs" %}
{% include code-snippet/pivot-table/field-list/fieldlist-valuesbutton/fieldlist-valuesbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/fieldlistmeasureatdifferentposition.png)

## Events

### EnginePopulated

The [`EnginePopulated`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_EnginePopulated) event is available in both Pivot Table and Field List.

* The event [`EnginePopulated`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_EnginePopulated) is triggered in field list whenever the report gets modified. The updated report is passed to the pivot table via `UpdateView` method written within this event to refresh the same.

* Likewise, [`EnginePopulated`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnginePopulated) event is triggered in pivot table whenever the report gets modified. The updated report is passed to the field list via `Update` method written within this event to refresh the same.

The event [`EnginePopulated`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_EnginePopulated) is triggered after engine is populated. It has following parameters - `DataSourceSettings`, `PivotFieldList` and `PivotValues`.

> This event is not required for Popup field list since it is a in built one.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/static/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Static.cs" %}
{% include code-snippet/pivot-table/field-list/static/Static.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/static/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Static.cs" %}
{% include code-snippet/pivot-table/field-list/static/Static.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




### FieldListRefreshed

The event [`FieldListRefreshed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldListRefreshed) is triggered whenever there is any change done in the field list UI. It has following parameter - `DataSourceSettings` and `PivotValues`. It allows user to identify each field list update. This event is applicable only for static field list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/refresh-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/pivot-table/field-list/refresh-event/Popup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/refresh-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/pivot-table/field-list/refresh-event/Popup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




### FieldDropped

The event [`OnFieldDropped`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnFieldDropped) fires whenever a field is dropped in an axis. It has following parameters - `DroppedAxis`, `DroppedField` and `DataSourceSettings`. In this illustration, we have modified the `DroppedField` caption through this event at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/field-dropped/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dropped.cs" %}
{% include code-snippet/pivot-table/field-list/field-dropped/dropped.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/field-dropped/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dropped.cs" %}
{% include code-snippet/pivot-table/field-list/field-dropped/dropped.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/fielddropped_fieldlist.png)

### ActionBegin

The event [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_ActionBegin) triggers when the UI actions such as sorting, filtering, aggregation or edit calculated field, that are present in the field list UI begin. This allows user to identify the current action being performed at runtime. It has the following parameters:

* `dataSourceSettings`:  It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action began. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Sort icon`](./field-list/#Sorting-members)| Sort field|
| [`Filter icon`](./field-list/#Filtering-members)| Filter field|
| [`Aggregation`](./field-list/#Changing-aggregation-type-of-value-fields-at-runtime) (Value type drop down and menu)| Aggregate field|
| [`Edit icon`](./calculated-field/#Editing-through-the-field-list-and-the-grouping-bar)| Edit calculated field|
| [`Calculated field button`](./field-list/#calculated-fields)| Open calculated field dialog|
| [`Field list`](./field-list/#In-built-Field-List)| Open field list|
| [`Field list tree – Sort icon`](./field-list/#In-built-Field-List)| Sort field tree|

* `fieldInfo`: It holds the selected field information.

> This option is applicable only when the field based UI actions are performed such as filtering, sorting, removing field from grouping bar, editing and aggregation type change.

* `cancel`: It allows user to restrict the current action.

In the below sample, opening pop-up field list can be restricted by setting the **args.cancel** option to **true** in the `actionBegin` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-fieldList/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-fieldList.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-fieldList/actionBegin-fieldList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-fieldList/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-fieldList.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-fieldList/actionBegin-fieldList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### ActionComplete

The event [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_ActionComplete) triggers when the UI actions such as sorting, filtering, aggregation or edit calculated field, that are present in the field list UI, is completed. This allows user to identify the current UI actions being completed at runtime. It has the following parameters:

* `dataSourceSettings`:  It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action completed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Sort icon`](./field-list/#Sorting-members)| Field sorted|
| [`Filter icon`](./field-list/#Filtering-members)| Field filtered|
| [`Aggregation`](./field-list/#Changing-aggregation-type-of-value-fields-at-runtime)(Value type drop down and menu)| Field aggregated|
| [`Edit icon`](./calculated-field/#Editing-the-existing-calculated-field-formula)| Calculated field edited|
| [`Calculated field button`](./field-list/#calculated-fields)| Calculated field applied|
| [`Field list`](./field-list/#In-built-Field-List)| Field list closed|
| [`Field list tree – Sort icon`](./field-list/#In-built-Field-List)| Field tree sorted|

* `fieldInfo`: It holds the selected field information.

> This option is applicable only when the field based UI actions are performed such as filtering, sorting, removing field from grouping bar, editing and aggregation type change.

* `actionInfo`: It holds the unique information about the current UI action. For example, if sorting is completed, the event argument contains information such as sort order and the field name.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-fieldList/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-fieldList.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-fieldList/actionComplete-fieldList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-fieldList/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-fieldList.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-fieldList/actionComplete-fieldList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### ActionFailure

The event [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html#Syncfusion_EJ2_PivotView_PivotFieldList_ActionFailure) triggers when the current UI action fails to achieve the desired result. It has the following parameters:

* `actionName`: It holds the name of the current action failed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Sort icon`](./field-list/#Sorting-members)| Sort field|
| [`Filter icon`](./field-list/#Filtering-members)| Filter field|
| [`Aggregation`](./field-list/#Changing-aggregation-type-of-value-fields-at-runtime) (Value type drop down and menu)| Aggregate field|
| [`Edit icon`](./calculated-field/#Editing-the-existing-calculated-field-formula)| Edit calculated field|
| [`Calculated field button`](./field-list/#calculated-fields)| Open calculated field dialog|
| [`Field list`](./field-list/#In-built-Field-List)| Open field list|
| [`Field list tree – Sort icon`](./field-list/#In-built-Field-List)| Sort field tree|

* `errorInfo`: It holds the error information of the current UI action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-fieldList/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-fieldList.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-fieldList/actionFailure-fieldList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-fieldList/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-fieldList.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-fieldList/actionFailure-fieldList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Change load limited data in member editor](./how-to/change-load-limited-data-in-member-editor)
* [Customize the icons for pivot table](./how-to/customize-the-icons-for-pivot-table)