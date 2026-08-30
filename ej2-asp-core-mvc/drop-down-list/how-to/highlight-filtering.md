---
layout: post
title: Highlight Matched Characters in ##Platform_Name## DropDownList | Syncfusion
description: Highlight matched characters in Syncfusion ##Platform_Name## DropDownList filtering by calling the highlightSearch method to bold the typed substring.
platform: ej2-asp-core-mvc
control: Highlight Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Highlight Matched Characters in ##Platform_Name## DropDownList

Use the [`highlightSearch`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.html#Syncfusion_EJ2_DropDowns_highlightSearch) method to highlight the matched characters in DropDownList filtering. The [`highlightSearch`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.html#Syncfusion_EJ2_DropDowns_highlightSearch) method accepts the following parameters: `item` (the list item element), `query` (the search string to highlight), `ignoreCase` (boolean, whether to ignore case when matching), and `filterType` (the matching strategy, e.g., `StartsWith`, `Contains`, `EndsWith`). The method is typically called from the `itemCreated` event of the DropDownList fields, using the search string captured in the [`filtering`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Filtering) event handler, and the filtered data is refreshed via [`updateData`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.FilteringEventArgs.html#Syncfusion_EJ2_DropDowns_FilteringEventArgs_UpdateData).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/highlight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/dropdownlist/how-to/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/highlight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/dropdownlist/how-to/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

