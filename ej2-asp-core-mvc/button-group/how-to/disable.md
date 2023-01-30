---
layout: post
title: Disable in ##Platform_Name## Button Group Control | Syncfusion
description: Learn here all about Disable in Syncfusion ##Platform_Name## Button Group control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Disable
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable in Button Group Control

## Particular button

To disable a particular button in a ButtonGroup, `disabled` attribute should be added to corresponding button element.

## Whole ButtonGroup

To disable whole ButtonGroup, `disabled` attribute should be added to all the button elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/disable/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/disable/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/disable/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> To disable radio/checkbox type ButtonGroup, the `disabled` attribute should be added to the particular input element.

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ButtonGroup/ButtonGroupHowToSample).