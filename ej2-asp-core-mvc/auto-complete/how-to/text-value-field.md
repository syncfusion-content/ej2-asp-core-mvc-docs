---
layout: post
title: Text Value Field in ##Platform_Name## Auto Complete Component
description: Learn here all about Text Value Field in Syncfusion ##Platform_Name## Auto Complete component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Text Value Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filter using both text and value field

The AutoComplete data can be filtered based on both text and value fields using `predicate` of dataManager through filtering event. The filtered data can be again updated through `updateData` method.

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