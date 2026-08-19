---
layout: post
title: How to set read-only TextBox in ##Platform_Name## TextBox | Syncfusion
description: Make the Syncfusion ##Platform_Name## TextBox read-only by setting the `readonly` property to `true`, while still allowing users to copy the value.
platform: ej2-asp-core-mvc
control: Set The Read Only Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to set read-only TextBox in ##Platform_Name## TextBox

To make the TextBox `read-only`, set the `readonly` property to `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/read-only/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Read-only.cs" %}
{% include code-snippet/textbox/how-to/read-only/read-only.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/read-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Read-only.cs" %}
{% include code-snippet/textbox/how-to/read-only/read-only.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

