---
layout: post
title: How to add floating label to read-only TextBox in ##Platform_Name## TextBox | Syncfusion
description: Add a floating label to a read-only Syncfusion ##Platform_Name## TextBox programmatically and update its value dynamically using a button click handler.
platform: ej2-asp-core-mvc
control: Add Floating Label To Read Only Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add floating label to read-only TextBox in ##Platform_Name## TextBox

You can programatically add or remove the value to the `readonly` TextBox.

In this sample, click the update value button to fill the read-only textbox with value and float a label.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/float-read-only/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Float-read-only.cs" %}
{% include code-snippet/textbox/how-to/float-read-only/float-read-only.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/float-read-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Float-read-only.cs" %}
{% include code-snippet/textbox/how-to/float-read-only/float-read-only.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

