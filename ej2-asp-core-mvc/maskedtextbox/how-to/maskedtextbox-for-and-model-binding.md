---
layout: post
title: How to bind ##Platform_Name## MaskedTextBox to a model | Syncfusion
description: Bind Syncfusion ##Platform_Name## MaskedTextBox to a strongly typed ASP.NET MVC model using the MaskedTextBoxFor HtmlHelper extension to render model-bound inputs.
platform: ej2-asp-core-mvc
control: Maskedtextbox For And Model Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to bind ##Platform_Name## MaskedTextBox to a model

This section demonstrates the Strongly typed extension support in MaskedTextBox. The view which bind with any model is called as strongly typed view. You can bind any class as model to view. You can access model properties on that view. You can use data associated with model to render controls.

In this sample, first click the submit button to post the selected value in the MaskedTextBox. When posting the null value, validation error message will be shown below the MaskedTextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/modelBinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ModelBinding.cs" %}
{% include code-snippet/maskedtextbox/modelBinding/modelBinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/modelBinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ModelBinding.cs" %}
{% include code-snippet/maskedtextbox/modelBinding/modelBinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![MaskedTextBox Sample](../images/modelbinding.png)
