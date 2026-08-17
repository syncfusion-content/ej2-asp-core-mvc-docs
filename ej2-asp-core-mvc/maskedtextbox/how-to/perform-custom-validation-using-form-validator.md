---
layout: post
title: Validate MaskedTextBox with custom rules | Syncfusion
description: Validate Syncfusion ##Platform_Name## MaskedTextBox input by attaching to FormValidator with custom rules and associate the validator with the input name.
platform: ej2-asp-core-mvc
control: Perform Custom Validation Using Form Validator
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to validate ##Platform_Name## MaskedTextBox with custom rules

To perform custom validation on the MaskedTextBox use the FormValidator along with custom validation rules.

In the following example, the MaskedTextBox is validated for invalid mobile number by adding custom validation in the rules collection of the FormValidator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/how-to/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Howto.cs" %}
{% include code-snippet/maskedtextbox/how-to/howto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/how-to/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Howto.cs" %}
{% include code-snippet/maskedtextbox/how-to/howto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![MaskedTextBox Sample](../images/customvalidation.png)