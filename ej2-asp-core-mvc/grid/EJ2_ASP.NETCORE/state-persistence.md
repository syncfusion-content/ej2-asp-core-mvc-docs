---
layout: post
title: State Persistence in ##Platform_Name## Grid Component
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---


# State Persistence

State persistence refers to the Grid's state maintained in the browser's [`localStorage`](https://www.w3schools.com/html/html5_webstorage.asp#) even if the browser is refreshed or if you move to the next page within the browser.
State persistence stores grid’s model object in the local storage when the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) is defined as true.

## Maintaining custom query in a persistent state

The grid does not maintain the query params after page load event when the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) is set to true. This is because the grid refreshes its query params for every page load. You can maintain the custom query params by resetting the **addParams** method in [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/state-persist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="State-persist.cs" %}
{% include code-snippet/grid/state-persist/state-persist/state-persist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/state-persist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="State-persist.cs" %}
{% include code-snippet/grid/state-persist/state-persist/state-persist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Get or set localStorage value

If the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to true, the grid property value is saved in the **window.localStorage** for reference. You can get/set the localStorage value by using the **getItem**/**setItem** method in the **window.localStorage**.

```typescript
//get the Grid model.
var value = window.localStorage.getItem('gridGrid'); //"gridGrid" is component name + component id.
var model= JSON.parse(model);

```

```typescript
//set the Grid model.
window.localStorage.setItem('gridGrid', JSON.stringify(model)); //"gridGrid" is component name + component id.

```

## Restore initial Grid state

When the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to **true**, the Grid will keep its state even if the page is reloaded. In some cases, you may be required to retain the Grid in its initial state. The Grid will not retain its initial state now since the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property has been enabled.

You can achieve this by destroying the grid after disabling the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property and clearing the local storage data, as shown in the sample below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/initial-grid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-grid.cs" %}
{% include code-snippet/grid/state-persist/initial-grid/initial-grid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/initial-grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-grid.cs" %}
{% include code-snippet/grid/state-persist/initial-grid/initial-grid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to add a new column while using enablePersistence

The Grid columns can be persisted when the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to true. If you want to add the new columns with the existing persist state, you can use the Grid inbuilt method such as `column.push` and call the `refreshColumns()` method for UI changes. Please refer to the following sample for more information.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-add/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-add.cs" %}
{% include code-snippet/grid/state-persist/column-add/column-add.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-add/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-add.cs" %}
{% include code-snippet/grid/state-persist/column-add/column-add.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to prevent columns from persisting

When the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to true, the Grid properties such as [Grouping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html), [Paging](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html), [Filtering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html), [Sorting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html), and [Columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) will persist. You can use the `addOnPersist` method to prevent these Grid properties from persisting.

The following example demonstrates how to prevent Grid columns from persisting. In the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the Grid, you can override the `addOnPersist` method and remove the columns from the key list given for persistence.

> When the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to true, the Grid properties such as column template, column formatter, header text, and value accessor will not persist.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-prevent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-prevent.cs" %}
{% include code-snippet/grid/state-persist/column-prevent/column-prevent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-prevent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-prevent.cs" %}
{% include code-snippet/grid/state-persist/column-prevent/column-prevent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Persist the Grid column template, header template, and headerText

By default, the Grid properties such as column template, header text, header template, column formatter, and value accessor will not persist when [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) is set to true. Because the column template and header text can be customized at the application level.

If you wish to restore all these column properties, then you can achieve it by cloning the grid’s columns property using JavaScript Object’s assign method and storing this along with the persist data manually. While restoring the settings, this column object must be assigned to the grid’s columns property to restore the column settings as demonstrated in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-persist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-persist.cs" %}
{% include code-snippet/grid/state-persist/column-persist/column-persist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-persist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-persist.cs" %}
{% include code-snippet/grid/state-persist/column-persist/column-persist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

