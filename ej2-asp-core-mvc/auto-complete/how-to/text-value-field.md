---
layout: post
title: Filter Using Text and Value Field in AutoComplete | Syncfusion
description: Learn here all about Text Value Field in the Syncfusion ##Platform_Name## AutoComplete component of Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Text Value Field
publishingplatform: ##Platform_Name##
documentation: ug
---

# Filter Using Text and Value Field in ##Platform_Name## AutoComplete

The AutoComplete data can be filtered based on both the text and value fields using a `Predicate` of the `DataManager` through the `Filtering` event. The filtered data can then be updated through the `updateData` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/filtering/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/autocomplete/how-to/filtering/filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/AutoComplete/AutoCompleteCustomSample).