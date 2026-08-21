---
layout: post
title: How to set disabled state in ##Platform_Name## TextBox | Syncfusion
description: Disable the Syncfusion ##Platform_Name## TextBox by setting the `enabled` property to `false`, preventing user interaction with the input.
platform: ej2-asp-core-mvc
control: Set The Disabled State
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to set disabled state in ##Platform_Name## TextBox

To disable the TextBox, set the `enabled` property to `false`.

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

