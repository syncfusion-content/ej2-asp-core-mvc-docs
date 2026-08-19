---
layout: post
title: Name and Value in Form Submission for ##Platform_Name## Radio Button | Syncfusion
description: Learn how the name and value properties of ##Platform_Name## Radio Button work during form submission and how selected values are posted to the server.
platform: ej2-asp-core-mvc
control: Name And Value In Form Submit
publishingplatform: ##Platform_Name##
documentation: ug
---


# Name and Value in Form Submission for Radio Button

The name attribute of the RadioButton is used to group RadioButton. When the RadioButton are grouped in form, the checked items value attribute will be post to server on form submit that can be retrieved through the name. The disabled RadioButton value will not be sent to the server on form submit.

In the following code snippet, Credit and Debit card is in checked state. Now, the value that is in checked state will be sent on form submit.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/form/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Form.cs" %}
{% include code-snippet/radio-button/howto/form/form.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/form/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Form.cs" %}
{% include code-snippet/radio-button/howto/form/form.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

