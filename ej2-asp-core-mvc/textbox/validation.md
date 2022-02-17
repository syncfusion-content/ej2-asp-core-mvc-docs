---
layout: post
title: Validation in ##Platform_Name## Textbox Component
description: Learn here all about Validation in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Validation

The TextBox supports three types of validation styles namely `error`, `warning`, and `success`. These states are
enabled by adding corresponding classes `.e-error`, `.e-warning`, or `.e-success` to the input parent element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Validation.cs" %}
{% include code-snippet/textbox/validation/validation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Validation.cs" %}
{% include code-snippet/textbox/validation/validation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](./images/textbox-valid.png)
