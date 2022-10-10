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

When filtering the list items, you can set the limit for character count to raise remote request and fetch filtered data on the mention control. This can be done, by configuring the [MinLength](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_MinLength) property.

In the following example, the remote request does not fetch the search data until the search key contains three characters.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/minimum-filter-char/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/minimum-filter-char/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/minimum-filter-char/minimum-filter-char.cs %}
{% endtabs %}
{% endif %}

## Change the filter type

While filtering, you can change the filter type to `Contains`, `StartsWith`, or `EndsWith` for string type within the [FilterType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_FilterType) property.

In the following examples, data filtering is done with `EndsWith` type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/filter-type/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/filter-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/filter-type/filter-type.cs %}
{% endtabs %}
{% endif %}

## Allow spacing between search

While filtering, you can allow the space in the middle of mention while searching the data in the dataSource by using the [AllowSpaces](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_AllowSpaces) property. If the datasource data doesn't matches, with the mention element data the popup will be hidden.

> By default, the `AllowSpaces` property is disabled, and the space ends the mention control search.

In the following example, `allowSpaces` property is enabled and the filtering waits after the space action

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/allow-space/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/allow-space/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/allow-space/allow-space.cs %}
{% endtabs %}
{% endif %}

## Customize the suggestion item count

With the large amount of datasource data bound for the Mention control, you can customize the number of list items to be displayed in the popup by using the [SuggestionCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuggestionCount) property.

In the following example, the suggestion list for the popup is limited to eight data's.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/suggestion-count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Email.cs" %}
{% include code-snippet/dropdownlist/data-binding/suggestion-count/EmailData.cs %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/suggestion-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Email.cs" %}
{% include code-snippet/mention/filtering-data/suggestion-count/EmailData.cs %}
{% endtabs %}
{% endif %}

## See Also

* [Templates](./template)

