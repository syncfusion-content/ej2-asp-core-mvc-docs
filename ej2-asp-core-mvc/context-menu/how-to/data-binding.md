---
layout: post
title: How to data bind in ##Platform_Name## Context Menu | Syncfusion
description: Populate Syncfusion ##Platform_Name## Context Menu items from a local data source by mapping the data fields to the items property.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to data bind in ##Platform_Name## Context Menu

{% if page.publishingplatform == "aspnet-core" %}

To bind local data source to the ContextMenu, menu items are populated from data source and mapped to [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Items) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

To bind local data source to the ContextMenu, menu items are populated from data source and mapped to [`items`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Items) property.

{% endif %}

The below example demonstrates how to bind local data source to the ContextMenu and separator is added using `insertAfter` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/data-bind/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/context-menu/howto/data-bind/databind.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/data-bind/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databind.cs" %}
{% include code-snippet/context-menu/howto/data-bind/databind.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


