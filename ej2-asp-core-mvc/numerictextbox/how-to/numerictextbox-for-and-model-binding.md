---
layout: post
title: Numerictextbox For And Model Binding in ##Platform_Name## Numerictextbox Component
description: Learn here all about Numerictextbox For And Model Binding in Syncfusion ##Platform_Name## Numerictextbox component and more.
platform: ej2-asp-core-mvc
control: Numerictextbox For And Model Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# NumericTextBoxFor and Model Binding

This section demonstrates the Strongly typed extension support in NumericTextBox. The view which bind with any model is called as
strongly typed view. You can bind any class as model to view.
You can access model properties on that view. You can use data associated with model to render controls.

In this sample, first click the submit button to post the selected value in the MaskedTextBox. When posting the null value,
validation error message will be shown below the NumericTextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/modelBinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ModelBinding.cs" %}
{% include code-snippet/numeric-textbox/how-to/modelBinding/modelBinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/modelBinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ModelBinding.cs" %}
{% include code-snippet/numeric-textbox/how-to/modelBinding/modelBinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](../images/modelbinding.png)