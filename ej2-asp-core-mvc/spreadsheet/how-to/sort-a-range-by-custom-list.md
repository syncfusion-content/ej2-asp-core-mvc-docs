---
layout: post
title: Sort A Range By Custom List in ##Platform_Name## Spreadsheet Component
description: Learn here all about Sort A Range By Custom List in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Sort A Range By Custom List
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sort a range by custom list

You can also define the sorting of cell values based on your own customized personal list. In this article, custom list is achieved using `custom sort comparer`.

In the following demo, the `Trustworthiness` column is sorted based on the custom lists `Perfect`, `Sufficient`, and `Insufficient`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/custom-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomSortController.cs" %}
{% include code-snippet/spreadsheet/custom-sort/customSortController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/custom-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomSortController.cs" %}
{% include code-snippet/spreadsheet/custom-sort/customSortController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Filtering](./filter)
* [Sorting](./sort)
* [Hyperlink](./link)