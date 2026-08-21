---
layout: post
title: How to set rounded corner in ##Platform_Name## TextBox | Syncfusion
description: Render the Syncfusion ##Platform_Name## TextBox with rounded corners by adding the `e-corner` class to the `cssClass` property.
platform: ej2-asp-core-mvc
control: Set The Rounded Corner
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to set rounded corner in ##Platform_Name## TextBox

Render the TextBox with rounded corner by adding the `e-corner` class to the `cssClass` property of the TextBoxComponent.

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