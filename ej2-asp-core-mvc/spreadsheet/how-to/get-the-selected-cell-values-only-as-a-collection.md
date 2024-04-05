---
layout: post
title: Get the selected cell values only as a collection in ##Platform_Name## Spreadsheet control | Syncfusion
description: Learn here all about how to get the selected cell values only as a collection in Syncfusion ##Platform_Name## Spreadsheet control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Get the selected cell values only as a collection in ##Platform_Name## Spreadsheet control

You can get the selected cell's values only as a collection in a spreadsheet by using the `getData` method.

The following code example shows how to get the selected cell values only as a collection by using the `getData` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/selected-cell-values/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectedCellValuesController.cs" %}
{% include code-snippet/spreadsheet/selected-cell-values/selectedCellValuesController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/selected-cell-values/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectedCellValuesController.cs" %}
{% include code-snippet/spreadsheet/selected-cell-values/selectedCellValuesController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
