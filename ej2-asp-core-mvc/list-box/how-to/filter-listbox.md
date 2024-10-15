---
layout: post
title: Enable Scroller in ##Platform_Name## List Box Component
description: Learn here all about Enable Scroller in Syncfusion ##Platform_Name## List Box component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Enable Scroller
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable Scroller

This example demonstrates how to filter data in the Syncfusion ListBox using a TextBox component. It shows the implementation of a TextBox filter for data filtering in ListBox items.

In the following sample, `height` of the list box is restricted to `250px`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/filter-listbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scroller.cs" %}
{% include code-snippet/listbox/filter-listbox/filter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/filter-listbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scroller.cs" %}
{% include code-snippet/listbox/filter-listbox/filter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

