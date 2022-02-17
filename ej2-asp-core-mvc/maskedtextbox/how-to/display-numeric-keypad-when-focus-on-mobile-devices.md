---
layout: post
title: Display Numeric Keypad When Focus On Mobile Devices in ##Platform_Name## Maskedtextbox Component
description: Learn here all about Display Numeric Keypad When Focus On Mobile Devices in Syncfusion ##Platform_Name## Maskedtextbox component and more.
platform: ej2-asp-core-mvc
control: Display Numeric Keypad When Focus On Mobile Devices
publishingplatform: ##Platform_Name##
documentation: ug
---

# Display numeric keypad when focus on mobile devices

By default, on focusing the MaskedTextBox, alphanumeric keypad will be displayed on
mobile devices. Sometimes only numeric keypad for number
values is needed, and this can be achieved by setting "type" property to `tel`.
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

