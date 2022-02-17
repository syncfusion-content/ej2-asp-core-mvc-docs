---
layout: post
title: Sorting And Grouping in ##Platform_Name## List Box Component
description: Learn here all about Sorting And Grouping in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Sorting And Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# sorting and grouping

## Sorting

The ListBox supports sorting of available items in the alphabetical order that can be either ascending or descending. This can achieved using
[`sortOrder`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~SortOrder.html) property. Sort order can be `None`, `Ascending` or `Descending`.

In the following example, the `SortOrder` is set as `Descending`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/sorting-grouping/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/listbox/sorting-grouping/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/sorting-grouping/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/listbox/sorting-grouping/sorting/sorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Grouping

The ListBox supports to wrap the nested element into a group based on its category. The category of each list item can be mapped with
[`groupBy`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~GroupBy.html) field in the data table.

In the following example, vegetables are grouped based on its category.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/sorting-grouping/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/listbox/sorting-grouping/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/sorting-grouping/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/listbox/sorting-grouping/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


