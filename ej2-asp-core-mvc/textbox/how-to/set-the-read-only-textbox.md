---
layout: post
title: Set The Read Only Textbox in ##Platform_Name## Textbox Component
description: Learn here all about Set The Read Only Textbox in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Set The Read Only Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the read-only TextBox

You can make the TextBox as `read-only` by setting the `readonly` attribute to the input element.

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

