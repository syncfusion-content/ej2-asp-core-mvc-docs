---
layout: post
title: Prevent Nullable Input in ##Platform_Name## Numeric TextBox | Syncfusion
description: Learn how to prevent null values in ##Platform_Name## Numeric TextBox and ensure a valid numeric value is always maintained.
platform: ej2-asp-core-mvc
control: Prevent Nullable Input In Numerictextbox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Prevent Nullable Input in ##Platform_Name## NumericTextBox

By default, the value of the NumericTextBox sets to null. In some applications, the value of the NumericTextBox should not be null at any instance. In such cases, following sample can be used to prevent nullable input in NumericTextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/nullableInput/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="NullableInput.cs" %}
{% include code-snippet/numeric-textbox/how-to/nullableInput/nullableInput.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/nullableInput/razor %}
{% endhighlight %}
{% highlight c# tabtitle="NullableInput.cs" %}
{% include code-snippet/numeric-textbox/how-to/nullableInput/nullableInput.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](../images/nullableinput.png)