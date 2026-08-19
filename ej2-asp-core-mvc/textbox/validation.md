---
layout: post
title: Validation in ##Platform_Name## TextBox | Syncfusion
description: Show `error`, `warning`, or `success` validation states on the Syncfusion ##Platform_Name## TextBox by adding `e-error`, `e-warning`, or `e-success` to the `cssClass` property.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validation in ##Platform_Name## TextBox

The TextBox supports three types of validation styles namely `error`, `warning`, and `success`. These states are enabled by adding corresponding classes `.e-error`, `.e-warning`, or `.e-success` to the `cssClass` property.

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
