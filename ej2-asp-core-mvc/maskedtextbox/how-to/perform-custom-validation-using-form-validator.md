---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Perform Custom Validation Using Form Validator of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Perform Custom Validation Using Form Validator
publishingplatform: ##Platform_Name##
documentation: ug
---

# Perform custom validation using FormValidator

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