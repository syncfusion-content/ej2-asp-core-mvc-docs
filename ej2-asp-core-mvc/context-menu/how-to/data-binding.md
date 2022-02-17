---
layout: post
title: Data Binding in ##Platform_Name## Context Menu Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Context Menu component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data Binding

To bind local data source to the ContextMenu, menu items are populated from data source and mapped
to [`items`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Items.html) property.

The below example demonstrates how to bind local data source to the ContextMenu and separator is added using
`insertAfter` method.

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


