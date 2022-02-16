---
layout: post
title: State Persistence in ##Platform_Name## Pivot Table Component
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---


# State Persistence

State persistence allows user to maintain the current state of the component along with its report bounded in the browser local storage (cookie). Even if the browser is refreshed or if you move to the next page within the browser, components state will be persisted. State persistence stores the Pivot Table object in the local storage when [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnablePersistence) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class is set to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/state-persistence/persistence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Persistence.cs" %}
{% include code-snippet/pivot-table/state-persistence/persistence/Persistence.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/state-persistence/persistence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Persistence.cs" %}
{% include code-snippet/pivot-table/state-persistence/persistence/Persistence.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Save and Load Pivot Layout

You can save the current layout of the  pivot table by using `getPersistData` in string format. The saved layout can be loaded to pivot table any time by passing the saved data as a parameter to `loadPersistData` method in the [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/state-persistence/save-load/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Save.cs" %}
{% include code-snippet/pivot-table/state-persistence/save-load/Save.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/state-persistence/save-load/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Save.cs" %}
{% include code-snippet/pivot-table/state-persistence/save-load/Save.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

