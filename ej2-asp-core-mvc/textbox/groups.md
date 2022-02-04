---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Groups of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Groups
publishingplatform: ##Platform_Name##
documentation: ug
---

  e-label-top     | Floats the label above of the TextBox.
  e-label-bottom  | Label to be placed as placeholder for the TextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/floating/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Floating.cs" %}
{% include code-snippet/textbox/groups/floating/floating.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/floating/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Floating.cs" %}
{% include code-snippet/textbox/groups/floating/floating.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multi-line input with floating label

Add the HTML`textarea` element with the `e-input` class to create default multi-line input.

Add the floating label support to the `multi-line input` by creating the floating label structure as defined in the initial section.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/multi-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiline.cs" %}
{% include code-snippet/textbox/groups/multi-line/multiline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/groups/multi-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiline.cs" %}
{% include code-snippet/textbox/groups/multi-line/multiline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to add floating label to TextBox programmatically](./how-to/add-floating-label-to-textbox-programmatically)
* [Change the floating label color of the TextBox](./how-to/change-the-floating-label-color-of-the-textbox)
* [Change the color of the TextBox based on its value](./how-to/change-the-color-of-the-textbox-based-on-its-value)
