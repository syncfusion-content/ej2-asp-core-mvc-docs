---
layout: post
title: Form Submit in ##Platform_Name## Button Group Control | Syncfusion
description: Learn here all about Form Submit in Syncfusion ##Platform_Name## Button Group control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Form Submit
publishingplatform: ##Platform_Name##
documentation: ug
---


# Form submit in Button Group Control

The name attribute of the input element is used to group the radio or checkbox type ButtonGroup. When the radio or checkbox type are grouped in the form, the checked items value attribute will be posted to the server on form submit that can be retrieved through the name. The disabled radio or checkbox type value will not be sent to the server on form submit.

In the following code snippet, the radio type ButtonGroup is explained with male value as checked. Now, the value that is in checked state will be sent on form submit.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/form/demo/tagHelper %}
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

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ButtonGroup/ButtonGroupHowToSample).