---
layout: post
title: Disable in ##Platform_Name## Button Group Component
description: Learn here all about Disable in Syncfusion ##Platform_Name## Button Group component and more.
platform: ej2-asp-core-mvc
control: Disable
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable

## Particular button

To disable a particular button in a ButtonGroup, `disabled` attribute should be added to corresponding button element.

## Whole ButtonGroup

To disable whole ButtonGroup, `disabled` attribute should be added to all the button elements.

The following example illustrates how to disable the particular and the whole ButtonGroup.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/disable/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/disable/demo/default.cs %}
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



> To disable radio/checkbox type ButtonGroup, the `disabled` attribute should be added to the particular input element.