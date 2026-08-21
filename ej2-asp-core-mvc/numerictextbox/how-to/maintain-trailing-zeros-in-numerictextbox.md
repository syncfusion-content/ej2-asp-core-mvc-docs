---
layout: post
title: Maintain Trailing Zeros in ##Platform_Name## Numeric TextBox | Syncfusion
description: Learn how to maintain trailing zeros in ##Platform_Name## Numeric TextBox when the control receives focus using custom configuration.
platform: ej2-asp-core-mvc
control: Maintain Trailing Zeros In Numerictextbox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Maintain Trailing Zeros in ##Platform_Name## NumericTextBox

By default, trailing zeros disappear when the NumericTextBox gets focus. However, you can use the following sample to maintain the trailing zeros while focusing the NumericTextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/trailingZeros/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TrailingZeros.cs" %}
{% include code-snippet/numeric-textbox/how-to/trailingZeros/trailingZeros.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/trailingZeros/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TrailingZeros.cs" %}
{% include code-snippet/numeric-textbox/how-to/trailingZeros/trailingZeros.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

