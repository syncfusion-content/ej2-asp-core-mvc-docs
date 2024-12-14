---
layout: post
title: State management in ##Platform_Name## Grid Component
description: Learn here all about State management in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: State management
publishingplatform: ##Platform_Name##
documentation: ug
---

# State Management in ASP.NET Core Grid component

State management in the ASP.NET Core Grid component allows you to maintain the grid's state even after a browser refresh or when navigating to a different page within the same browser session. This feature is particularly useful for retaining the grid's configuration and data even after a page reload.

To enable state persistence in the Grid, you can utilize the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property. When this property is set to **true**, the grid will automatically save its state in the browser's [localStorage](https://www.w3schools.com/html/html5_webstorage.asp#), ensuring that the state is preserved across page reloads.

```html
<ejs-grid id="grid" dataSource="@ViewBag.datasource" enablePersistence="true">
    <e-grid-columns>
    </e-grid-columns>
</ejs-grid>
```

> The grid will store the state using the combination of the component name and component ID in the storage. For example, if the component name is **grid** and the ID is **OrderDetails**, the state will be stored as **gridOrderDetails**.


When enabling state persistence, the following grid settings will persist in the local storage.

| Grid Settings    | Properties persist                                                                                                                                                                                                                                                                                                                | Ignored properties                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| ---------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| pageSettings     | currentPage<br> pageCount<br> pageSize<br> pageSizes<br> totalRecordsCount                                                                                                                                                                                                                                                        | template<br> enableQueryString                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| groupSettings    | allowReordering<br> columns<br> disablePageWiseAggregates<br> enableLazyLoading<br> showDropArea<br> showGroupedColumn<br> showToggleButton<br> showUngroupButton                                                                                                                                                                 | captionTemplate                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| columns          | allowEditing<br> allowFiltering<br> allowGrouping<br> allowReordering<br> allowResizing<br> allowSearching<br> allowSorting<br> autoFit<br> disableHtmlEncode<br> enableGroupByFormat<br> field<br> foreignKeyField<br> index<br> showColumnMenu<br> showInColumnChooser<br> sortDirection<br> type<br> uid<br> visible<br> width | clipMode<br> commands<br> customAttributes<br> dataSource<br> defaultValue<br> displayAsCheckBox<br> edit<br> editTemplate<br> editType<br> filter<br> filterBarTemplate<br> filterTemplate<br> foreignKeyValue<br> format<br> formatter<br> freeze<br> headerTemplate<br> headerText<br> headerTextAlign<br> headerValueAccessor<br> hideAtMedia<br> isFrozen<br> isIdentity<br> isPrimaryKey<br> lockColumn<br> maxWidth<br> minWidth<br> sortComparer<br> template<br> textAlign<br> validationRules<br> valueAccessor |
| sortSettings     | -                                                                                                                                                                                                                                                                                                                                 | -                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| filterSettings   | -                                                                                                                                                                                                                                                                                                                                 | -                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| searchSettings   | -                                                                                                                                                                                                                                                                                                                                 | -                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| SelectedRowIndex | -                                                                                                                                                                                                                                                                                                                                 | -                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |


The grid will persist only the last selected row index.

## Restore initial Grid state

In the Syncfusion ASP.NET Core Grid component, you have the capability to restore the grid to its initial state, reverting all changes and configurations made during the interaction. This feature can be particularly useful when you want to reset the grid to its original settings, eliminating any applied filters, sorting, or column reordering.

Here are the steps to reset the grid to its initial state, even when the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is enabled:

### Changing component id

If you want to restore the initial state of the grid, consider changing the component ID. This step ensures that the grid is treated as a new instance, effectively reverting to its default settings.

Here is an example code to change the component id dynamically to restore initial grid state.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/state-changing-id/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="persist.cs" %}
{% include code-snippet/grid/state-persist/state-changing-id/persist.cs %}
{% endhighlight %}
{% endtabs %}

![Changing component id](../images/state-management/state-id.gif)

### Clearing local storage

Another method to reset the grid is by clearing the local storage associated with the grid component. This action removes any stored state information, allowing the grid to return to its original configuration.

Here is an example code on how to clear local storage to retain its default state.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/clearing-local-storage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="local-storage.cs" %}
{% include code-snippet/grid/state-persist/clearing-local-storage/local-storage.cs %}
{% endhighlight %}
{% endtabs %}

![Clearing local storage](../images/state-management/state-clear-stoarge.gif)

## Restore to specific state version

Syncfusion ASP.NET Core Grid supports version-based persistence for easy restoration to a specific state. To enable version based persistence, import `enableVersionBasedPersistence` from `@syncfusion/ej2-base` and set it globally to **true**. Define the grid in the template with properties, bind data, and configure persistence using [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) and `ej2state-persistenceVersion`. 

In the below example, the `clickHandler` method is responsible for handling button clicks corresponding to different versions. Inside this method, the targeted version is assigned to the grid's `ej2state-persistenceVersion` dynamically. The code checks if there is already a persisted state for the selected version in the local storage. If found, the grid is updated with the settings retrieved from the local storage, including columns, filter settings, group settings, sort settings, page settings, and selected row index. If no persisted state is found, the current grid state is persisted to the local storage using the `getPersistData` method.

Here is an example of how to integrate version-based persistence into your ASP.NET Core component and restore to specific state version:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/state-state-version/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="state-version.cs" %}
{% include code-snippet/grid/state-persist/state-state-version/state-version.cs %}
{% endhighlight %}
{% endtabs %}

![Restore to specific state version](../images/state-management/state-version.gif)

## Restore to previous state

The Syncfusion ASP.NET Core Grid component allows you to save and restore its state using local storage. This feature is helpful when you want to preserve the current state of the Grid, such as column order, sorting, and filtering, so that you can return to your previous work or configurations.

To implement this functionality, use the `getItem` and `setItem` methods for local storage, along with the Grid component's `setProperties` and `getPersistData` methods.

The provided code demonstrates how to save and restore the previous state of a Syncfusion ASP.NET Core Grid component using local storage.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/state-previous-state/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="previous-state.cs" %}
{% include code-snippet/grid/state-persist/state-previous-state/previous-state.cs %}
{% endhighlight %}
{% endtabs %}

![Restore to previous state](../images/state-management/state-previous.gif)

## Maintaining custom query in a persistent state

When [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) is enabled, the Grid does not automatically maintain custom query parameters after a page load. This is because the Grid refreshes its query params for every page load. You can maintain the custom query params by resetting the `addParams` method in the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/state-custom-query/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="custom-query.cs" %}
{% include code-snippet/grid/state-persist/state-custom-query/custom-query.cs %}
{% endhighlight %}
{% endtabs %}

## Get or set local storage value

If the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to **true**, the Grid property value is saved in the **window.localStorage** for reference. You can get or set the localStorage value by using the **getItem** and **setItem** methods in **window.localStorage**.

To retrieve the Grid model from Local Storage, follow these steps:

```typescript
//get the Grid model.
let value = window.localStorage.getItem('gridOrders'); //"gridOrders" is component name + component id.
let model = JSON.parse(value);

```

```typescript
//set the Grid model.
window.localStorage.setItem('gridOrders', JSON.stringify(value)); //"gridOrders" is component name + component id.

```

## Prevent columns from persisting

In the Syncfusion ASP.NET Core Grid component, you may sometimes want to prevent certain settings from being persisted when using the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) feature. When the enablePersistence property is set to **true**, the Grid properties such as [Grouping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html), [Paging](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html), [Filtering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html), [Sorting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html), and [Columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumns.html) will persist. You can use the `addOnPersist` method to prevent these Grid properties from persisting.

The following example demonstrates how to prevent Grid columns from persisting. In the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the Grid, you can override the `addOnPersist` method and remove the columns from the key list given for persistence.


{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/state-prevent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="state-prevent.cs" %}
{% include code-snippet/grid/state-persist/state-prevent/state-prevent.cs %}
{% endhighlight %}
{% endtabs %}

![Prevent columns from persisting](../images/state-management/state-prevent.gif)

## Add to persist

Persistence can be added to a Syncfusion ASP.NET Core Grid component to enhance the user experience. Persistence allows saving and restoring the state of the grid, including column layouts, sorting, filtering, and other user-specific settings. In this documentation, you will explore how to persist column templates, header templates, and header text settings in the ASP.NET Core Grid.

### Add a new column in persisted columns list

When the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to true in the Syncfusion Grid component, column configurations are persisted. If you need to add new columns to the existing persisted state, you can achieve this by using the Grid's built-in methods like `column.push`, and then call the `refreshColumns` method to update the UI with the new columns.

Here's an example of how to add a new column to a list of persisted columns:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-add/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="column-add.cs" %}
{% include code-snippet/grid/state-persist/column-add/column-add.cs %}
{% endhighlight %}
{% endtabs %}

![Add a new column in persisted columns list](../images/state-management/state-add.gif)

> * Adding new columns using `columns` directly in the grid initialization is not recommended if you intend to persist the new columns with the existing columns list 

### Persist the column template, header template and header text

By default, when the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to **true** in the Syncfusion Grid component, certain column properties such as column template, header text, header template, column formatter, and value accessor are not persisted. This is because these properties can be customized at the application level.

To restore these column properties and achieve persistence, you can follow the approach of cloning the grid's columns property using JavaScript Object's assign method and manually storing it along with the persist data. When restoring the settings, this cloned column object must be assigned to the grid's columns property to restore the column settings. The following sample demonstrates this process:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-persist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="persist.cs" %}
{% include code-snippet/grid/state-persist/column-persist/persist.cs %}
{% endhighlight %}
{% endtabs %}

![template](../images/state-management/state-template.gif)

