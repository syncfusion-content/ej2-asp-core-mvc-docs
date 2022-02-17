---
layout: post
title: Filtering in ##Platform_Name## Multi Select Component
description: Learn here all about Filtering in Syncfusion ##Platform_Name## Multi Select component and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering

The MultiSelect has built-in support to filter data items when [allowFiltering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~AllowFiltering.html) is enabled. The filter
operation starts as soon as you start typing characters in the MultiSelect input.

To display filtered items in the popup, filter the required data and return it to the MultiSelect
via `updateData` method by using the [filtering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~Filtering.html) event.

The following sample illustrates how to query the data source and pass the data to the MultiSelect
through the `updateData` method in [filtering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~Filtering.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/multiselect/filtering/filter/Countries.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/multiselect/filtering/filter/Countries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limit the minimum filter character

When filtering the list items, you can set the limit for character count to raise remote request and fetch
filtered data on the MultiSelect. This can be done by manual validation within the filter event handler.

In the following example, the remote request does not fetch the search data until the search key contains three characters.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/filterlimit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filterlimit.cs" %}
{% include code-snippet/multiselect/filtering/filterlimit/filterlimit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/filterlimit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filterlimit.cs" %}
{% include code-snippet/multiselect/filtering/filterlimit/filterlimit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change the filter type

While filtering, you can change the filter type to `contains`,
`startsWith`, or `endsWith` for string type within the filter event handler.

In the following examples, data filtering is done with `endsWith` type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/filtertype/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtertype.cs" %}
{% include code-snippet/multiselect/filtering/filtertype/filtertype.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/filtertype/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtertype.cs" %}
{% include code-snippet/multiselect/filtering/filtertype/filtertype.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Case sensitive filtering

Data items can be filtered either with or without case sensitivity using the DataManager. This can be done
by passing the fourth optional parameter of the `where` clause.

The following example shows how to perform case-sensitive filter.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/casesensitive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Casesensitive.cs" %}
{% include code-snippet/multiselect/filtering/casesensitive/casesensitive.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/casesensitive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Casesensitive.cs" %}
{% include code-snippet/multiselect/filtering/casesensitive/casesensitive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Diacritics Filtering

MultiSelect supports diacritics filtering which will ignore the [diacritics](https://en.wikipedia.org/wiki/Diacritic) and
makes it easier to filter the results in international characters lists
when the [ignoreAccent](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~IgnoreAccent.html) is enabled.

In the following sample,data with diacritics are bound as dataSource for MultiSelect.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/diacritics/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Diacritics.cs" %}
{% include code-snippet/multiselect/filtering/diacritics/diacritics.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/diacritics/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Diacritics.cs" %}
{% include code-snippet/multiselect/filtering/diacritics/diacritics.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to bind the data](./data-binding/)
* [How to group the data using header](./grouping/)
* [How to add custom value to the MultiSelect](./custom-value/)