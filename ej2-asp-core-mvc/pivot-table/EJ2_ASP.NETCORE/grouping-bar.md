---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Grouping Bar of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Grouping Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping Bar

The Grouping Bar option in pivot table automatically populates fields from the bound data source and allows end users to drag fields between different axes such as columns, rows, values, and filters, and create pivot table at runtime. It can be enabled by setting the [`showGroupingBar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowGroupingBar) property in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**.

Similar to Field List, Grouping Bar UI also comes with basic interactions like,

* Re-arranging fields through drag-and-drop operation between row, column, value and filter axes.
* Remove fields from the existing report using remove icon.
* Add fields to the report using fields panel option.
* Filtering members of specific fields using filter icon.
* Sorting members of specific fields using sort icon.

> The grouping bar provides some additional options to customize it's UI using `e-groupingBarSettings` property.

{% aspTab template="pivot-table/getting-start-mvc/groupingbar", sourceFiles="groupingbar.cs" %}

{% endaspTab %}

![output](images/gs_groupingbar.png)

## Show or hide fields panel

The fields panel, which is positioned above the grouping bar, displays the fields that are available in the data source but are not bound in the report. The fields can be dragged and dropped into the appropriate axis. In addition, any field removed from any axes will be automatically added to the fields panel. The fields panel can be displayed by setting the [`showFieldsPanel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowFieldsPanel) property in the [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) to **true**.

{% aspTab template="pivot-table/grouping-bar/showFieldsPanel", sourceFiles="showFieldsPanel.cs" %}

{% endaspTab %}

![output](images/showfieldspanel.png)

## Show or hide all filter icon

The Grouping Bar has an option to filter members of particular fields at runtime in pivot table. In-order to filter members in a field, click the filter icon and check/uncheck members that needs to be displayed. By default, filter icon besides each field is enabled in the grouping bar. To disable the filter icon, set the property [`showFilterIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowFilterIcon) in [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) tag to **false**.

> By default, the filter icon is enabled in the grouping bar.

{% aspTab template="pivot-table/grouping-bar/show-filter", sourceFiles="ShowFilter.cs" %}

{% endaspTab %}

![output](images/groupingbar-filter.png)

## Show or hide specific filter icon

To disable the filter icon for a specific field, set the property [`showFilterIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowFilterIcon) to **false** to the corresponding field in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

In the below sample, the filter icon of "Quarter" and "Products" fields have been hidden.

{% aspTab template="pivot-table/grouping-bar/show-filter-specific", sourceFiles="ShowFilter.cs" %}

{% endaspTab %}

![output](images/groupingbar-filter-specific.png)

## Show or hide all sort icon

The Grouping Bar has an option to order members of a particular fields either in ascending or descending at runtime. In order to sort a field, click the sort icon and to reverse its sort direction, once again click the same sort icon. By default, the sort icon besides each field is enabled in the grouping bar and members will be arranged in ascending order. To disable the sort option, set the property [`showSortIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowFilterIcon) in [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) tag to **false**.

> By default, the sort icon is enabled in the grouping bar.

{% aspTab template="pivot-table/grouping-bar/show-sort", sourceFiles="ShowSort.cs" %}

{% endaspTab %}

![output](images/groupingbar-sort.png)

## Show or hide specific sort icon

To disable the sort icon for a specific button, set the property [`showSortIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSortIcon) to **false** to the corresponding field in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

In the below sample, the sort icon of "Quarter" and "Country" fields have been hidden.

{% aspTab template="pivot-table/grouping-bar/show-sort-specific", sourceFiles="ShowSort.cs" %}

{% endaspTab %}

![output](images/groupingbar-sort-specific.png)

## Show or hide all remove icon

The Grouping Bar has an option to remove any field at runtime. To remove a field, just click the remove icon. By default, the remove icon besides each field is enabled in the grouping bar. To disable the remove icon, set the property [`showRemoveIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowFilterIcon) in [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) tag to **false**.

> By default, the remove icon is enabled in the grouping bar.

{% aspTab template="pivot-table/grouping-bar/show-remove", sourceFiles="ShowRemove.cs" %}

{% endaspTab %}

![output](images/groupingbar-remove.png)

## Show or hide specific remove icon

To disable the remove icon for a specific button, set the property [`showRemoveIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowRemoveIcon) to **false** to the corresponding field in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

In the below sample, the remove icon of fields "Year", "Sold" and "Products" have been hidden.

{% aspTab template="pivot-table/grouping-bar/show-remove-specific", sourceFiles="ShowRemove.cs" %}

{% endaspTab %}

![output](images/groupingbar-remove-specific.png)

## Disable all fields from dragging

The Grouping Bar has an option to drag-and-drop fields between row, column, value and filter axes in-order to change report at runtime. By default, all fields are available for drag-and-drop operation in the grouping bar. To disable these fields, set the property [`allowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_AllowDragAndDrop) in [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) tag to **false**. This will prevent end user from changing the current report.

{% aspTab template="pivot-table/grouping-bar/drag", sourceFiles="drag.cs" %}

{% endaspTab %}

![output](images/gbar_drag.png)

## Disable specific field from dragging

To disable dragging for a specific button, set the property [`allowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_AllowDragAndDrop) to **false** to the corresponding  field in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

In the below sample, the drag and drop of the fields "Year" and "Products" have been restricted.

{% aspTab template="pivot-table/grouping-bar/drag-specific", sourceFiles="drag.cs" %}

{% endaspTab %}

## Remove specific field(s) from displaying

When a report is bound to the pivot table, fields will be automatically populated within the Grouping Bar. In this case, you can also prevent specific fields from being displayed. To do so, set the appropriate field name(s) in the [`excludeFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExcludeFields) property of [`dataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

> The `excludeFields` property setting will be reflected in the field list UI as well, and for more information, see this [link](https://ej2.syncfusion.com/angular/documentation/pivotview/field-list/#remove-specific-fields-from-displaying).

{% aspTab template="pivot-table/grouping-bar/removespecific", sourceFiles="removespecific.cs" %}

{% endaspTab %}

![output](images/excludefieldgroupingbar.png)

## Changing aggregation type of value fields at runtime

End user can perform calculations over a group of values using the aggregation option. The value fields bound to the field list, appears with a dropdown icon, helps to select an appropriate aggregation type at runtime. On selection, the values in the Pivot Table will be changed dynamically. By default, the icon to set aggregation type is enabled in the grouping bar. To disable this icon, set the property [`showValueTypeIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowValueTypeIcon) in [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) tag to **false**. To know more about aggregation, [`refer`](./aggregation) here.

{% aspTab template="pivot-table/grouping-bar/aggregation", sourceFiles="aggregation.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD012 -->
![output](images/aggregation_gb_icon.png "Icon to change aggregation type")
<br/>
<br/>
<br/>
![output](images/aggregation_gb_menu.png "List of pre-defined aggregation types")

## Show or hide specific dropdown icon

To disable the dropdown icon for a specific button, set the property [`showValueTypeIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowValueTypeIcon) to **false** to the corresponding field in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

In the below sample, the dropdown icon of field "Sold" is hidden.

{% aspTab template="pivot-table/grouping-bar/aggregation-specific", sourceFiles="aggregation-specific.cs" %}

{% endaspTab %}

![output](images/groupingbar-dropdown-specific.png)

 >The property [`showFilterIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowFilterIcon), [`showSortIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSortIcon), [`showValueTypeIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowValueTypeIcon) and [`allowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_AllowDragAndDrop) in fields of [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) are applicable for both grouping bar and field list.

## Show values button

During runtime, the **Values** button in the grouping bar can be moved to a different position (i.e., different index) among other fields in the column or row axis. To enable the **Values** button, set the [`showValuesButton`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowValuesButton) property to **true**.

> This support is only available for relational data sources.

{% aspTab template="pivot-table/field-list/groupingbar-valuesbutton", sourceFiles="groupingbar-valuesbutton.cs" %}

{% endaspTab %}

![output](images/groupingbarvaluebutton.png)

## Event

### OnFieldDropped

The event [`onFieldDropped`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnFieldDropped) fires on whenever a field is dropped over an axis.

It has following parameters - `droppedAxis`, `droppedField` and `dataSourceSettings`. In this sample we have modified the `droppedField` caption based on the `droppedAxis`.

{% aspTab template="pivot-table/grouping-bar/field-dropped", sourceFiles="field-dropped.cs" %}

{% endaspTab %}

### FieldDragStart

The event [`fieldDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldDragStart) fires whenever a field drag starts from its axis. It allows the user to restrict the drag operation based on its parameters. It has the following parameters  

* `fieldName`: It holds the name of the appropriate field.

* `fieldItem`: It holds the complete definition of the appropriate field mentioned in data source settings.

* `axis`: It holds the axis name where the draggable field lies.

* `cancel`: It is a boolean property and by setting this to true, user can restrict the field from dragging.

In the below sample, the drag operation for the fields in row axis alone is restricted.

{% aspTab template="pivot-table/grouping-bar/field-drag-start", sourceFiles="field-drag-start.cs" %}

{% endaspTab %}

### FieldDrop

The event [`fieldDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldDrop) fires whenever a field is dropped into an axis. It allows the user to restrict the drop operation based on its parameters. It has the following parameters  

* `fieldName`: It holds the name of the appropriate field.

* `dropField`: It holds the complete definition of the appropriate field mentioned in data source settings.

* `draggedAxis`: It holds the axis name from where dragging was started.

* `dropAxis`: It holds the axis name where the field is dropped.

* `dropPosition`: It holds the dropped index among other existing fields in the axis.

* [`dataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html): It holds complete pivot report.

* `cancel`: It is a boolean property and by setting this to true, user can restrict the field from being dropped.

In the below sample, dropping of any fields in value axis alone is restricted.

{% aspTab template="pivot-table/grouping-bar/field-drop", sourceFiles="field-drop.cs" %}

{% endaspTab %}

### FieldRemove

The event [`fieldRemove`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldRemove) fires when removing any field from their axis. It helps the user to limit the elimination of a field based on its parameters. It has the following parameters

* `fieldName`: It holds the name of the field to be removed.

* `fieldItem`: It holds the complete definition of the appropriate field mentioned in data source settings.

* `axis`: It holds the name of the axis from where it is to remove the field.

* [`dataSourceSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html): It holds complete pivot report.

* `cancel`: It is a boolean property and by setting this to true, user can restrict the field from removing.

In the below sample, the field "Country" could not be removed from report by any UI operations.

{% aspTab template="pivot-table/grouping-bar/field-remove", sourceFiles="field-remove.cs" %}

{% endaspTab %}

### AggregateMenuOpen

The event [`aggregateMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateMenuOpen) fires while clicking dropdown icon of the value field button UI. It allows to customize the aggregate types to be displayed in the dropdown menu. It has the following parameters

* `fieldName`: It holds the name of the field that opens the aggregate menu.

* [`aggregateTypes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateTypes): It holds the aggregation types set for a field.

* `displayMenuCount`: It allows to set the menu count to be displayed initially. By default, its count is 7.

* `cancel`: It is a boolean property and by setting this to true, dropdown menu won’t be displayed.

In the below sample, the aggregate types of the field "Amount" has been customized in it's dropdown menu.

{% aspTab template="pivot-table/grouping-bar/aggregation-menu-open", sourceFiles="aggregation-menu-open.cs" %}

{% endaspTab %}

![output](images/aggregatemenuopen.png)

 >The events [`aggregateMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateMenuOpen), [`fieldRemove`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldRemove), [`fieldDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldDrop), [`fieldDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldDragStart) and [`onFieldDropped`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnFieldDropped) are applicable for both grouping bar and field list.

### ActionBegin

The event [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) triggers when the UI action such as sorting, filtering, aggregation or edit calculated field, that are present in the grouping bar begin. This allows user to identify the current action being performed at runtime. It has the following parameters:

* `dataSourceSettings`: It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action began. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| Sort icon| Sort field|
| Filter icon| Filter field|
| Aggregation (Value type drop down and menu)| Aggregate field|
| Remove icon| Remove field|
| Edit icon| Edit calculated field|

* `fieldInfo`: It holds the selected field information.

>Note: This option is applicable only when the field based UI actions are performed such as filtering, sorting, removing field from grouping bar, editing and aggregation type change.

* `cancel`: It allows user to restrict the current action.

In the below sample, grouping bar UI actions such as sorting and filtering can be restricted by setting the **args.cancel** option to **true** in the `actionBegin` event.

{% aspTab template="pivot-table/action-event/actionBegin-groupingBar", sourceFiles="actionBegin-groupingBar.cs" %}

{% endaspTab %}

### ActionComplete

The event [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionComplete) triggers when the UI action such as as sorting, filtering, aggregation or edit calculated field, that are present in the grouping bar UI, is completed. This allows user to identify the current UI actions being completed at runtime. It has the following parameters:

* `dataSourceSettings`: It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action completed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| Sort icon| Field sorted|
| Filter icon| Field filtered|
| Aggregation (Value type drop down and menu)| Field aggregated|
| Remove icon| Field removed|
| Edit icon| Calculated field edited|

* `fieldInfo`: It holds the selected field information.

>Note: This option is applicable only when the field based UI actions are performed such as filtering, sorting, removing field from grouping bar, editing and aggregation type change.

* `actionInfo`: It holds the unique information about the current UI action. For example, if sorting is completed, the event argument contains information such as sort order and the field name.

{% aspTab template="pivot-table/action-event/actionComplete-groupingBar", sourceFiles="actionComplete-groupingBar.cs" %}

{% endaspTab %}

### ActionFailure

The event [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) triggers when the current UI action fails to achieve the desired result. It has the following parameters:

* `actionName`: It holds the name of the current action failed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| Sort icon| Sort field|
| Filter icon| Filter field|
| Aggregation (Value type drop down and menu)| Aggregate field|
| Remove icon| Remove field|
| Edit icon| Edit calculated field|

* `errorInfo`: It holds the error information of the current UI action.

{% aspTab template="pivot-table/action-event/actionFailure-groupingBar", sourceFiles="actionFailure-groupingBar.cs" %}

{% endaspTab %}

## See Also

* [Change load limited data in member editor](./how-to/change-load-limited-data-in-member-editor)
* [Customize the icons for pivot table](./how-to/customize-the-icons-for-pivot-table)