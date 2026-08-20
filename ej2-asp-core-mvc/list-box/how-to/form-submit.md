---
layout: post
title: How to submit a form with ##Platform_Name## ListBox | Syncfusion
description: Submit Syncfusion ##Platform_Name## ListBox selected values via an form by naming the list input and binding value to a controller action.
platform: ej2-asp-core-mvc
control: Form Submit
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to submit a form with ##Platform_Name## ListBox

In the following code snippet, the value that is in selected state will be sent on form submit.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/form-submit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formsubmit.cs" %}
{% include code-snippet/listbox/form-submit/formsubmit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/form-submit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formsubmit.cs" %}
{% include code-snippet/listbox/form-submit/formsubmit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

