---
layout: post
title: Add to Persist in ##Platform_Name## Grid Component
description: Learn here all about Add to Persist in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Add to Persist
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add to Persist

## Persist the column template, header template and header Text

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

