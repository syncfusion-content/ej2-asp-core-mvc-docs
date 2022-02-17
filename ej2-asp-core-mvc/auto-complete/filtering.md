---
layout: post
title: Filtering in ##Platform_Name## Auto Complete Component
description: Learn here all about Filtering in Syncfusion ##Platform_Name## Auto Complete component and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering

The AutoComplete has built-in support to filter data items. The filter operation
starts as soon as you start typing characters in the control.

## Change the filter type

Determines on which filter type, the control needs to be considered on search action.
The available [filterType](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~FilterType.html) and its supported data types are

| **Filter Type** | **Description** | **Supported Types** |
| --- | --- |
| StartsWith | Checks whether a value begins with the specified value. | String |
| EndsWith | Checks whether a value ends with specified value. | String |
| Contains | Checks whether a value contains with specified value. | String |

The following examples shows the data filtering is done with `StartsWith` type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filtertype/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtertype.cs" %}
{% include code-snippet/autocomplete/filtering/filtertype/filtertype.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filtertype/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtertype.cs" %}
{% include code-snippet/autocomplete/filtering/filtertype/filtertype.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Filter item count

You can specify the filter suggestion item count through
[suggestionCount](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~SuggestionCount.html) property of AutoComplete.

The following example, to restrict the suggestion list item counts as 5.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filtercount/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtercount.cs" %}
{% include code-snippet/autocomplete/filtering/filtercount/filtercount.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filtercount/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtercount.cs" %}
{% include code-snippet/autocomplete/filtering/filtercount/filtercount.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limit the minimum filter character

You can set the limit for the character count to filter the data on the AutoComplete. This can be done by
set the [minLength](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~MinLength.html) property to AutoComplete.

In the following example, the remote request doesn't fetch the search data, until the search key contains three characters.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filterlimit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filterlimit.cs" %}
{% include code-snippet/autocomplete/filtering/filterlimit/filterlimit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filterlimit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filterlimit.cs" %}
{% include code-snippet/autocomplete/filtering/filterlimit/filterlimit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Case sensitive filtering

Data items can be filtered either with or without case sensitivity using the DataManager.
This can be done by setting the [ignoreCase](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~IgnoreCase.html) property of AutoComplete.

The following sample depicts how to filter the data with case-sensitive.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/casesensitive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Casesensitive.cs" %}
{% include code-snippet/autocomplete/filtering/casesensitive/casesensitive.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/casesensitive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Casesensitive.cs" %}
{% include code-snippet/autocomplete/filtering/casesensitive/casesensitive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Diacritics filtering

An AutoComplete supports diacritics filtering which will ignore the [diacritics](https://en.wikipedia.org/wiki/Diacritic) and
makes it easier to filter the results in international characters lists
when the [ignoreAccent](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~IgnoreAccent.html) is enabled.

In the following sample,data with diacritics are bound as dataSource for AutoComplete.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/diacritics/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Diacritics.cs" %}
{% include code-snippet/autocomplete/filtering/diacritics/diacritics.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/diacritics/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Diacritics.cs" %}
{% include code-snippet/autocomplete/filtering/diacritics/diacritics.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to acheive autofill while filtering](./how-to/autofill/)
* [How to group the data using header](./grouping/)
* [How to highlight the search data](./how-to/custom-search/)
