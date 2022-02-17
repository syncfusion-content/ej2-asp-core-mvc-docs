---
layout: post
title: Set The Rounded Corner in ##Platform_Name## Textbox Component
description: Learn here all about Set The Rounded Corner in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Set The Rounded Corner
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the rounded corner

Render the TextBox with `rounded corner` by adding the `e-corner` class to the input parent element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/rounded-corner/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rounded-corner.cs" %}
{% include code-snippet/textbox/how-to/rounded-corner/rounded-corner.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/rounded-corner/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rounded-corner.cs" %}
{% include code-snippet/textbox/how-to/rounded-corner/rounded-corner.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

