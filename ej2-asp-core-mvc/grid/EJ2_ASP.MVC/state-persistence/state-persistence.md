---
layout: post
title: State Persistence in ##Platform_Name## Grid Component
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---


# State Persistence

State persistence refers to the Grid's state maintained in the browser's [`localStorage`](https://www.w3schools.com/html/html5_webstorage.asp#) even if the browser is refreshed or if you move to the next page within the browser.
State persistence stores grid’s model object in the local storage when the [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_EnablePersistence_System_Boolean_) is defined as true.

## Restore initial Grid state

When the [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_EnablePersistence_System_Boolean_) property is set to **true**, the Grid will keep its state even if the page is reloaded. In some cases, you may be required to retain the Grid in its initial state. The Grid will not retain its initial state now since the [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_EnablePersistence_System_Boolean_) property has been enabled.

You can achieve this by destroying the grid after disabling the [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_EnablePersistence_System_Boolean_) property and clearing the local storage data, as shown in the sample below.

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



## Maintaining custom query in a persistent state

The grid does not maintain the query params after page load event when the [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_EnablePersistence_System_Boolean_) is set to true. This is because the grid refreshes its query params for every page load. You can maintain the custom query params by resetting the `addParams` method in the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_ActionBegin_System_String_) event.

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



## Add a new column in persisted columns list

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

