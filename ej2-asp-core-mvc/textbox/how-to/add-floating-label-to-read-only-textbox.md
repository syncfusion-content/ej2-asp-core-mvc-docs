---
layout: post
title: How to Add a Floating Label to a Read-Only Textbox in Syncfusion Textbox Component
description: Learn here all about Add Floating Label To Read Only Textbox in Syncfusion ##Platform_Name## Textbox component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Add Floating Label To Read Only Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add floating label to read-only textbox

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

