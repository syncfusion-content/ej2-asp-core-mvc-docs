---
layout: post
title: Sizing in ##Platform_Name## Textbox Component
description: Learn here all about Sizing in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Sizing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sizing

You can render the TextBox in two different sizes.

Property   | Description
------------ | -------------
  Normal     | By default, the TextBox is rendered with normal size.
  Small      | You need to add `e-small` class to the input element, or else add to the input container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/sizing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sizing.cs" %}
{% include code-snippet/textbox/sizing/sizing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/sizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sizing.cs" %}
{% include code-snippet/textbox/sizing/sizing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

