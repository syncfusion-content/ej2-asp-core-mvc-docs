---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Maintain Trailing Zeros In Numerictextbox of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Maintain Trailing Zeros In Numerictextbox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Maintain trailing zeros in NumericTextBox

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

