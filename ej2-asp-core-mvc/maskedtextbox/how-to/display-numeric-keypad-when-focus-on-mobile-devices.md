---
layout: post
title: How to display mobile numeric keypad in ##Platform_Name## MaskedTextBox | Syncfusion
description: Show Syncfusion ##Platform_Name## MaskedTextBox numeric keypad on mobile devices by setting the input type attribute to tel and configuring cssClass.
platform: ej2-asp-core-mvc
control: Display Numeric Keypad When Focus On Mobile Devices
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to display mobile numeric keypad in ##Platform_Name## MaskedTextBox

By default, on focusing the MaskedTextBox, alphanumeric keypad will be displayed on mobile devices. Sometimes only numeric keypad for number values is needed, and this can be achieved by setting "type" property to `tel`.
Refer to the following example to enable numeric keypad in MaskedTextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/numeric/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="NumericKeypad.cs" %}
{% include code-snippet/maskedtextbox/numeric/numericKeypad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/numeric/razor %}
{% endhighlight %}
{% highlight c# tabtitle="NumericKeypad.cs" %}
{% include code-snippet/maskedtextbox/numeric/numericKeypad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

