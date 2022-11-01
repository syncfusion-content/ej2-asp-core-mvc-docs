---
layout: post
title: Mention Filtering in ##Platform_Name## Mention control | Syncfusion
description: Learn here all about mention filtering in Syncfusion ##Platform_Name## Mention control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Mention Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

# Filtering data in Mention

The Mention control has built-in support to filter data items. The filter operation starts as soon as you start typing characters in the mention element.

## Limit the minimum filter character

You can control the minimum length of user input to initiate the search action using the [MinLength](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_MinLength) property. This can be useful if you have a very large list of data. The default value is `zero`, where the suggestion list opens as soon as the user inputs the mention character.

The remote request does not fetch the search data until the search key contains three characters as shown in the following example.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/minimum-filter-char/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/minimum-filter-char/minimum-filter-char.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention minimum filter character](./images/asp-core-mvc-mention-minimum-filter-character.png)

## Change the filter type

While filtering, you can change the filter type to `Contains`, `StartsWith`, or `EndsWith` in the [FilterType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_FilterType) property. The default filter operator is `Contains`.

* StartsWith - Filter the items that begin with the specified text value.
* Contains - Filter the items that contain the specified text value.
* EndsWith - Filter the items that end with the specified text value.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/filter-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/filter-type/filter-type.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention change filter type](./images/asp-core-mvc-mention-filter-type.png)

## Allow spacing between search

While filtering the data in the data source, you can allow the space in the middle of the mention using the [AllowSpaces](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_AllowSpaces) property. If the data source does not match with the mentioned element data, the popup will be hidden on the space key press. The default value of the `AllowSpaces` is `false`.

> By default, the `AllowSpaces` property is disabled, and the space ends the mention control search.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/allow-space/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/allow-space/Employees.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention allow spacing between search](./images/asp-core-mvc-mention-allow-spacing.png)

## Customize the suggestion item count

While filtering, you can customize the number of list items to be displayed in the suggestion list using the [SuggestionCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuggestionCount) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/filtering-data/suggestion-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/suggestion-count/EmailData.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention suggestion item count](./images/asp-core-mvc-mention-suggestion-count.png)

## See also

* [Templates](./template)

