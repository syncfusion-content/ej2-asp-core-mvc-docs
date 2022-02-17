---
layout: post
title: Change The Color Of The Textbox Based On Its Value in ##Platform_Name## Textbox Component
description: Learn here all about Change The Color Of The Textbox Based On Its Value in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Change The Color Of The Textbox Based On Its Value
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change the color of the TextBox based on its value

You can change the color of the TextBox by validating its value using regular expression in the `keyup` event for predicting the numeric values as demonstrated in the following code sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/text-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-color.cs" %}
{% include code-snippet/textbox/how-to/text-color/text-color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/text-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-color.cs" %}
{% include code-snippet/textbox/how-to/text-color/text-color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](../images/textbox-type.png)