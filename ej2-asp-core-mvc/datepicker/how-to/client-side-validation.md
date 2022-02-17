---
layout: post
title: Client Side Validation in ##Platform_Name## Datepicker Component
description: Learn here all about Client Side Validation in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Client Side Validation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Client side validation

To achieve the client side validation in a DatePicker control by using
[Essential JavaScript 2 FormValidator](https://ej2.syncfusion.com/documentation/form-validator). It provides an option to customize the feedback error messages to the corresponding
fields to take action to resolve the issue.

In this below example, the required field validation is implemented by mapping
the name attribute
value to the rules property. It will validate the DatePicker control and display the validation
message when the textbox value is empty during form post back or focus out.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Validation.cs" %}
{% include code-snippet/datepicker/how-to/validation/validation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Validation.cs" %}
{% include code-snippet/datepicker/how-to/validation/validation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

