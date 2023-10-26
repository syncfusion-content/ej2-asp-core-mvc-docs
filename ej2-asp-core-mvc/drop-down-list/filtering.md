---
layout: post
title: Filtering in ##Platform_Name## Drop Down List Component
description: Learn here all about filtering in Syncfusion ##Platform_Name## Drop Down List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering

The DropDownList has built-in support to filter data items when [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_AllowFiltering_System_Boolean_) is enabled. The filter operation starts as soon as you start typing characters in the search box.

To display the filtered items in the popup, filter the required data and return it to the DropDownList via `updateData` method by using the [filtering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_Filtering_System_String_) event.

The following sample illustrates how to query the data source and pass the data to the DropDownList through the `updateData` method in `filtering` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/dropdownlist/filtering/filter/Countries.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/dropdownlist/filtering/filter/Countries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limit the minimum filter character

When filtering the list items, you can set the limit for character count to raise remote request and fetch filtered data on the DropDownList. This can be done by manual validation within the filter event handler.

In the following example, the remote request does not fetch the search data until the search key contains three characters.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/filterlimit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filterlimit.cs" %}
{% include code-snippet/dropdownlist/filtering/filterlimit/filterlimit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/filterlimit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filterlimit.cs" %}
{% include code-snippet/dropdownlist/filtering/filterlimit/filterlimit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change the filter type

While filtering, you can change the filter type to `contains`, `startsWith`, or `endsWith` for string type within the filter event handler.

In the following examples, data filtering is done with `endsWith` type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/filtertype/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtertype.cs" %}
{% include code-snippet/dropdownlist/filtering/filtertype/filtertype.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/filtertype/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtertype.cs" %}
{% include code-snippet/dropdownlist/filtering/filtertype/filtertype.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Case sensitive filtering

Data items can be filtered either with or without case sensitivity using the DataManager. This can be done by passing the fourth optional parameter of the `where` clause.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/casesensitive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Casesensitive.cs" %}
{% include code-snippet/dropdownlist/filtering/casesensitive/casesensitive.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/casesensitive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Casesensitive.cs" %}
{% include code-snippet/dropdownlist/filtering/casesensitive/casesensitive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Diacritics Filtering

DropDownList supports diacritics filtering which will ignore the [diacritics](https://en.wikipedia.org/wiki/Diacritic) and makes it easier to filter the results in international characters lists when the [ignoreAccent](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_IgnoreAccent_System_Boolean_) is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/diacritics/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Diacritics.cs" %}
{% include code-snippet/dropdownlist/filtering/diacritics/diacritics.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/filtering/diacritics/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Diacritics.cs" %}
{% include code-snippet/dropdownlist/filtering/diacritics/diacritics.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to limit the search result while filtering](./how-to/search-on-filtering/)
* [How to highlight the matched characters in filtering](./how-to/highlight-filtering/)
* [How to modify the result data using remote data source](./how-to/modify-data/)