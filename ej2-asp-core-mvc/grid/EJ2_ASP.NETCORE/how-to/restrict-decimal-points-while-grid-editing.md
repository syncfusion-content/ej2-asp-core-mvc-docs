---
layout: post
title: Restrict Decimal Points While Grid Editing in ##Platform_Name## Grid Component
description: Learn here all about Restrict Decimal Points While Grid Editing in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Restrict Decimal Points While Grid Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Restrict to type decimal points in a NumericTextBox while editing the numeric column

By default, the number of decimal places will be restricted to two in the NumericTextBox while editing the numeric column. We can restrict to type the decimal points in a NumericTextBox by using the **validateDecimalOnType** and **decimals** properties of NumericTextBox.

In the below demo, while editing the row we have restricted to type the decimal point value in the NumericTextBox of **Freight** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-decimal-point.cs" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/prevent-decimal-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-decimal-point.cs" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/prevent-decimal-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

