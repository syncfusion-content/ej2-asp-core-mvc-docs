---
layout: post
title: Form Submit in ##Platform_Name## Button Group Component
description: Learn here all about Form Submit in Syncfusion ##Platform_Name## Button Group component and more.
platform: ej2-asp-core-mvc
control: Form Submit
publishingplatform: ##Platform_Name##
documentation: ug
---


# Form submit

The name attribute of the input element is used to group the radio/checkbox type ButtonGroup. When the radio/checkbox type are grouped
in the form, the checked items value attribute will be posted to the server on form submit that can be retrieved through the name. The disabled
radio/checkbox type value will not be sent to the server on form submit.

In the following code snippet, the radio type ButtonGroup is explained with male value as checked.
Now, the value that is in checked state will be sent on form submit.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/form/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/form/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/form/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/form/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

