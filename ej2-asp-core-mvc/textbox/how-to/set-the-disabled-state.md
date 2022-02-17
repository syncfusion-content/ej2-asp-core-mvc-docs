---
layout: post
title: Set The Disabled State in ##Platform_Name## Textbox Component
description: Learn here all about Set The Disabled State in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Set The Disabled State
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the disabled state

Disable the TextBox by adding the `e-disabled` to the input parent element and set `disabled` attribute to the input element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/disabled/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/textbox/how-to/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/textbox/how-to/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

