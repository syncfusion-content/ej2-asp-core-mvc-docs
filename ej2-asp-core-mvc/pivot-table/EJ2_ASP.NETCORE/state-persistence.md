---
layout: post
title: State persistence in ASP.NET Core Pivot Table | Syncfusion
description: Learn how the ASP.NET Core Pivot Table retains the current report, filters, and expanded state across browser refreshes using enablePersistence.
platform: ej2-asp-core-mvc
control: Pivot Table
publishingplatform: ##Platform_Name##
documentation: ug
---

# State persistence in ASP.NET Core Pivot Table

State persistence enables users to automatically retain the entire configuration of the Pivot Table component in the browser's local storage. This includes the current layout, field arrangements, sorting, applied filters, and the expanded or collapsed states of fields. By enabling the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnablePersistence) property in the Pivot Table component, all these interactive states and settings are saved automatically. As a result, users can refresh the browser or navigate to different pages and return at any time, knowing that all modified report settings will be retained—ensuring a seamless and uninterrupted data analysis experience.

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

In addition to automatic state persistence, the Pivot Table component allows you to save and restore the current layout programmatically. By using the `getPersistData` method, you can retrieve the complete state of the Pivot Table component as a serialized string. This string can be stored and later re-applied to the component by passing it to the `loadPersistData` method. This approach offers flexibility for saving user-specific layouts, restoring previous configurations, or implementing custom workflows for managing and reloading the component’s state as needed.

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

