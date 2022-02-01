---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Restrict Decimal Points While Grid Editing of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
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
{% highlight c# tabtitle="prevent-decimal-point" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="prevent-decimal-point" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/prevent-decimal-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="prevent-decimal-point" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="prevent-decimal-point" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/prevent-decimal-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

