---
layout: post
title: Filtering in ##Platform_Name## MultiSelect | Syncfusion
description: Enable Syncfusion ##Platform_Name## MultiSelect filtering by setting allowFiltering to true and configuring StartsWith, EndsWith, or Contains filter modes.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering in ##Platform_Name## MultiSelect

The MultiSelect has built-in support to filter data items when [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_AllowFiltering) is enabled. The filter operation starts as soon as you start typing characters in the MultiSelect input.

To display filtered items in the popup, filter the required data and return it to the MultiSelect via the `updateData` method by using the [filtering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Filtering) event.

The following sample illustrates how to query the data source and pass the data to the MultiSelect through the `updateData` method in the [filtering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Filtering) event.

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

When filtering list items, you can set a minimum character count before a remote request is raised to fetch filtered data on the MultiSelect. Do this with manual validation in the filter event handler.

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

While filtering, you can change the filter type to `contains`, `startsWith`, or `endsWith` for string-typed fields within the filter event handler.

In the following examples, data filtering is done with the `endsWith` type.

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



## Case-sensitive filtering

Data items can be filtered either with or without case sensitivity using the `DataManager`. Do this by passing the fourth optional parameter of the `where` clause.

The following example shows how to perform a case-sensitive filter.

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



## Diacritics filtering

The MultiSelect supports diacritics filtering, which ignores [diacritics](https://en.wikipedia.org/wiki/Diacritic) and makes it easier to filter results in lists that contain international characters when [ignoreAccent](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_IgnoreAccent) is enabled.

In the following sample, data with diacritics are bound as the data source for the MultiSelect.

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

## Debounce delay

Use the [debounceDelay](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_DebounceDelay) property to set a delay, in milliseconds, for filtering. This reduces the frequency of filtering as you type and improves performance and responsiveness. The default `DebounceDelay` is `300` ms. Set it to `0` to disable the delay entirely.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/arrayofstrings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/multiselect/filtering/arrayofstrings/arrayofstrings.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/filtering/arrayofstrings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/multiselect/filtering/arrayofstrings/arrayofstrings.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [How to bind the data](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/data-binding)
* [How to group the data using a header](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/grouping)
* [How to add a custom value to the MultiSelect](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/custom-value)