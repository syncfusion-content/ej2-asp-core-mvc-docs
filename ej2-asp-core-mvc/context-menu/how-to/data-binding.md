---
layout: post
title: Data Binding in ASP.Net Core Context Menu Control | Syncfusion
description: Learn here all about Data Binding in Syncfusion ASP.Net Core Context Menu component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ASP.Net Core
documentation: ug
---

# Data Binding in Context Menu Control

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


