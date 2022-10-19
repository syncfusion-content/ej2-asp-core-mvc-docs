---
layout: post
title: Mention Filtering in ##Platform_Name## Mention Component
description: Learn here all about mention filtering in Syncfusion ##Platform_Name## Mention component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Mention Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

# Filtering

The Mention control has built-in support to filter data items. The filter operation starts as soon as you start typing characters in the mention element.

## Limit the minimum filter character

When filtering the list items, you can set the limit for character count to raise a remote request and fetch filtered data on the mention control. This can be done by configuring the [MinLength](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_MinLength) property.

The remote request does not fetch the search data until the search key contains three characters as shown in the following example.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/minimum-filter-char/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/minimum-filter-char/minimum-filter-char.cs %}
{% endhighlight %}
{% endtabs %}

![Minimum filter character](../images/asp-core-mvc-mention-minimum-filter-character.png)

## Change the filter type

While filtering, you can change the filter type to `Contains`, `StartsWith`, or `EndsWith` for string type within the [FilterType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_FilterType) property.

In the following examples, data filtering is done with `StartsWith` type.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/filter-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/filter-type/filter-type.cs %}
{% endhighlight %}
{% endtabs %}

![Change filter type](../images/asp-core-mvc-mention-filter-type.png)

## Allow spacing between search

While filtering, you can allow the space in the middle of the mention while searching the data in the data source by using the [AllowSpaces](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_AllowSpaces) property. If the data source does not match with the mentioned element data, the popup will be hidden.

> By default, the `AllowSpaces` property is disabled, and the space ends the mention control search.

In the following example, `AllowSpaces` property is enabled and the filtering waits after the space action

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/allow-space/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Email.cs" %}
{% include code-snippet/mention/filtering-data/allow-space/Countries.cs %}
{% endhighlight %}
{% endtabs %}

![Allow spacing between search](../images/asp-core-mvc-mention-allow-spacing.png)

## Customize the suggestion item count

With the large amount of data source data bound for the Mention control, you can customize the number of list items to be displayed in the popup by using the [SuggestionCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuggestionCount) property.

In the following example, the suggestion list for the popup is limited to eight data.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/suggestion-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Email.cs" %}
{% include code-snippet/mention/filtering-data/suggestion-count/EmailData.cs %}
{% endhighlight %}
{% endtabs %}

![suggestion item count](../images/asp-core-mvc-mention-suggestion-count.png)

## See Also

* [Templates](./template)

