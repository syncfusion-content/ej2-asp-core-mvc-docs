---
layout: post
title: State Persistence in ##Platform_Name## Gantt Component
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---


# State Persistence Feature

State persistence refers to the Gantt's state maintained in the browser's [`localStorage`](https://www.w3schools.com/html/html5_webstorage.asp#) even if the browser is refreshed or if you move to the next page within the browser.
State persistence stores gantt’s model object in the local storage when the [`enablePersistence`]([https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~EnablePersistence.html](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html) is defined as true.

## Get or set localStorage value

If the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html) property is set to true, the gantt property value is saved in the **window.localStorage** for reference. You can get/set the localStorage value by using the getItem/setItem method in the **window.localStorage**.

```typescript
//get the Gantt model.
var value = window.localStorage.getItem('ganttGantt'); //"ganttGantt" is component name + component id.
var model = JSON.parse(model);

```

```typescript
//set the Gantt model.
window.localStorage.setItem('ganttGantt', JSON.stringify(model)); //"ganttGantt" is component name + component id.

```

## Prevent columns from persisting

When the [EnablePersistence](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnablePersistence) property is set to true, the Gantt properties such as [Filtering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowFiltering), [Sorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowSorting), and [Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Columns) will persist. You can use the `addOnPersist` method to prevent these Gantt properties from persisting.

The following example demonstrates how to prevent Gantt columns from persisting. In the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_DataBound) event of the Gantt, you can override the `addOnPersist` method and remove the columns from the key list given for persistence.

>**Note:** When the [EnablePersistence](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnablePersistence) property is set to true, the Gantt properties such as column template, column formatter, header text, and value accessor will not persist.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/state-persist/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-prevent.cs" %}
{% include code-snippet/gantt/state-persist/custom/column-prevent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/state-persist/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-prevent.cs" %}
{% include code-snippet/gantt/state-persist/custom/column-prevent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Persist the header template and header Text

By default, the Gantt properties such as column template, header text, header template, column formatter, and value accessor will not persist when [EnablePersistence](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnablePersistence) is set to true. Because the column template and header text can be customized at the application level.

If you wish to restore all these column properties, then you can achieve it by cloning the gantt’s columns property using JavaScript Object’s assign method and storing this along with the persist data manually. While restoring the settings, this column object must be assigned to the gantt’s columns property to restore the column settings as demonstrated in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/state-persist/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-persist.cs" %}
{% include code-snippet/gantt/state-persist/default/column-persist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/state-persist/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-persist.cs" %}
{% include code-snippet/gantt/state-persist/default/column-persist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
