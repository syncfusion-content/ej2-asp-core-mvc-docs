---
layout: post
title: Prevent Nullable Input In Numerictextbox in ##Platform_Name## Numerictextbox Component
description: Learn here all about Prevent Nullable Input In Numerictextbox in Syncfusion ##Platform_Name## Numerictextbox component and more.
platform: ej2-asp-core-mvc
control: Prevent Nullable Input In Numerictextbox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Prevent nullable input in NumericTextBox

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

![NumericTextBox Sample](../images/nullableInput.png)