---
layout: post
title: Print in ##Platform_Name## Spreadsheet Component
description: Learn here all about Print in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Print
publishingplatform: ##Platform_Name##
documentation: ug
---


You can use the `print` method by importing from ej2-base package. Here, the `Select` event in the dropdown and the `dataBound` event are used to print the single/multiple sheets of data. To print the single/multiple sheets, use the dropdown button and select the `Print` (or) `Print All` option. In the following sample, you can be able to print the single/multiple sheets.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PrintController.cs" %}
{% include code-snippet/spreadsheet/print/printController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PrintController.cs" %}
{% include code-snippet/spreadsheet/print/printController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

