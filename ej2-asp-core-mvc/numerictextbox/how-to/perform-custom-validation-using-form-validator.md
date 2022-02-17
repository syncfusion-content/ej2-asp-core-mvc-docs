---
layout: post
title: Perform Custom Validation Using Form Validator in ##Platform_Name## Numerictextbox Component
description: Learn here all about Perform Custom Validation Using Form Validator in Syncfusion ##Platform_Name## Numerictextbox component and more.
platform: ej2-asp-core-mvc
control: Perform Custom Validation Using Form Validator
publishingplatform: ##Platform_Name##
documentation: ug
---

# Perform custom validation using FormValidator

This section explains how to perform custom validation on the NumericTextBox using FormValidator. The NumericTextBox will be validated when the value changes or the user clicks the submit button.
Validation can be performed by adding custom validation in the rules collection of the FormValidator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/customValidation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomValidation.cs" %}
{% include code-snippet/numeric-textbox/how-to/customValidation/customValidation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/customValidation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomValidation.cs" %}
{% include code-snippet/numeric-textbox/how-to/customValidation/customValidation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](../images/customValidation.png)