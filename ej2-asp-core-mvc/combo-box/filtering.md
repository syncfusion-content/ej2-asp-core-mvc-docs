---
layout: post
title: Filtering in ##Platform_Name## Combo Box Control | Syncfusion
description: Learn here all about Filtering in Syncfusion ##Platform_Name## Combo Box Control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering in Combo Box Control

The ComboBox has built-in support to filter data items when [allowFiltering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~AllowFiltering.html) is enabled. The filter operation starts as soon as you start typing characters in the control.

To display filtered items in the popup, filter the required data and return it to the ComboBox via `updateData` method by using the [filtering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~Filtering.html) event.

The following sample illustrates how to query the data source and pass the data to the ComboBox through the `updateData` method in `filtering` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
public class Countries
{
    public string Name { get; set; }
    public string Code { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/combobox/filtering/filter/Countries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limit the minimum filter character

When filtering the list items, you can set the limit for character count to raise remote request and fetch filtered data on the ComboBox. This can be done by manual validation within the filter event handler.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/filterlimit/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/filterlimit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filterlimit.cs" %}
{% include code-snippet/combobox/filtering/filterlimit/filterlimit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change the filter type

While filtering, you can change the filter type to `contains`, `startsWith`, or `endsWith` for string type within the filter event handler.

In the following examples, data filtering is done with `endsWith` type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/filtertype/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/filtertype/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtertype.cs" %}
{% include code-snippet/combobox/filtering/filtertype/filtertype.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Case sensitive filtering

Data items can be filtered either with or without case sensitivity using the DataManager. This can be done by passing the fourth optional parameter of the `where` clause.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/casesensitive/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/casesensitive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Casesensitive.cs" %}
{% include code-snippet/combobox/filtering/casesensitive/casesensitive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Diacritics filtering

ComboBox supports diacritics filtering which will ignore the [diacritics](https://en.wikipedia.org/wiki/Diacritic) and makes it easier to filter the results in international characters lists when the [ignoreAccent](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~IgnoreAccent.html) is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/diacritics/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/filtering/diacritics/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Diacritics.cs" %}
{% include code-snippet/combobox/filtering/diacritics/diacritics.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ComboBox/FilteringUGSample).

## See also

* [How to acheive autofill while filtering](./how-to/autofill)
* [How to group the data using header](./grouping/)
