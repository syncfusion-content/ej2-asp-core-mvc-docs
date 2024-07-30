---
layout: post
title: Filtering in ##Platform_Name## Auto Complete Control | Syncfusion
description: Learn here all about Filtering in Syncfusion ##Platform_Name## Auto Complete control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering in ##Platform_Name## AutoComplete Control

The AutoComplete has built-in support to filter data items. The filter operation starts as soon as you start typing characters in the control.

## Change the filter type

Determines on which filter type, the control needs to be considered on search action. The available [filterType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteBuilder.html#Syncfusion_EJ2_DropDowns_AutoCompleteBuilder_FilterType_Syncfusion_EJ2_DropDowns_FilterType_) and its supported data types are as follows.

| **Filter Type** | **Description** | **Supported Types** |
| --- | --- |
| StartsWith | Checks whether a value begins with the specified value. | String |
| EndsWith | Checks whether a value ends with the specified value. | String |
| Contains | Checks whether a value contains the specified value. | String |

The following examples shows the data filtering is done with `StartsWith` type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filtertype/tagHelper %}
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

You can specify the filter suggestion item count through [suggestionCount](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteBuilder.html#Syncfusion_EJ2_DropDowns_AutoCompleteBuilder_SuggestionCount_System_Double_) property of AutoComplete.

The following example, to restrict the suggestion list item counts as 5.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filtercount/tagHelper %}
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

You can set the limit for the character count to filter the data on the AutoComplete. This can be done by setting the [minLength](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteBuilder.html#Syncfusion_EJ2_DropDowns_AutoCompleteBuilder_MinLength_System_Double_) property to AutoComplete.

In the following example, the remote request doesn't fetch the search data, until the search key contains three characters.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/filterlimit/tagHelper %}
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

Data items can be filtered either with or without case sensitivity using the DataManager. This can be done by setting the [ignoreCase](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteBuilder.html#Syncfusion_EJ2_DropDowns_AutoCompleteBuilder_IgnoreCase_System_Boolean_) property of AutoComplete.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/casesensitive/tagHelper %}
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

An AutoComplete supports diacritics filtering which will ignore the [diacritics](https://en.wikipedia.org/wiki/Diacritic) and makes it easier to filter the results in international characters lists when the [ignoreAccent](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteBuilder.html#Syncfusion_EJ2_DropDowns_AutoCompleteBuilder_IgnoreAccent_System_Boolean_) is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/diacritics/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/filtering/diacritics/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/AutoComplete/GroupingandFilreringSample).

## See also

* [How to acheive autofill while filtering](https://ej2.syncfusion.com/aspnetcore/documentation/auto-complete/how-to/autofill)
* [How to group the data using header](https://ej2.syncfusion.com/aspnetcore/documentation/auto-complete/grouping)
* [How to highlight the search data](https://ej2.syncfusion.com/aspnetcore/documentation/auto-complete/how-to/custom-search)
