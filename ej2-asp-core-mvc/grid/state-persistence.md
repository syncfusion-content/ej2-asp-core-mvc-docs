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
State persistence stores grid’s model object in the local storage when the [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_EnablePersistence_System_Boolean_) is defined as true.

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



## Get or set localStorage value

If the [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_EnablePersistence_System_Boolean_) property is set to true, the grid property value is saved in the `window.localStorage` for reference. You can get/set the localStorage value by using the `getItem`/`setItem` method in the `window.localStorage`.

```typescript
//get the Grid model.
var value = window.localStorage.getItem('gridGrid'); //"gridGrid" is component name + component id.
var model= JSON.parse(model);

```

```typescript
//set the Grid model.
window.localStorage.setItem('gridGrid', JSON.stringify(model)); //"gridGrid" is component name + component id.

```