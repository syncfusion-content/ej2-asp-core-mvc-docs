---
layout: post
title: How to submit name and value in form in ##Platform_Name## Toggle Switch Button | Syncfusion
description: Submit the Syncfusion ##Platform_Name## Toggle Switch Button checked values to the server using the `name` and `value` attributes on form submit.
platform: ej2-asp-core-mvc
control: Submit Name And Value In Form
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to submit name and value in form in ##Platform_Name## Toggle Switch Button

The name attribute of the Switch is used to group Switches. When the Switches are grouped in form, the checked items value attribute will post to the server on form submit. The disabled and unchecked Switch values will not be sent to the server on form submit.

In the following code snippet, USB and Wi-Fi in the checked state, and Bluetooth is in disabled state. Values that are in checked state only be sent on form submit.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/switch/form/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/form/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/switch/form/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/form/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

