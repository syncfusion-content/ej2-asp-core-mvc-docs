---
layout: post
title: Globalization in ##Platform_Name## Inline AI Assist Control | Syncfusion
description: Checkout and learn about Globalization in ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Inline AI Assist
publishingplatform: ##Platform_Name##
documentation: ug
---

# Globalization in ##Platform_Name## Inline AI Assist control

## Localization

The Inline AI Assist can be localized to any culture by defining the text of the Inline AI Assist in the corresponding culture. The default locale is `en` (English). The following table represents the default text of the Inline AI Assist in `en` culture.

|KEY|Text|
|----|----|
|send|Send|
|stopResponseText|Stop Responding|
|thinkingIndicator|Thinking|
|editingIndicator|Editing|

The below example shows adding the German culture locale(`de-DE`)

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/globalization/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="localization.cs" %}
{% include code-snippet/inline-ai-assist/globalization/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

![Localization](images/localization.png)

## RTL

RTL provides an option to switch the text direction and layout of the Inline AI Assist control from right to left by setting the [EnableRtl][EnableRtl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_EnableRtl) property to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/globalization/enable-rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="enableRtl.cs" %}
{% include code-snippet/inline-ai-assist/globalization/enable-rtl/enableRtl.cs %}
{% endhighlight %}
{% endtabs %}

![EnableRtl](images/enable-rtl.png)
