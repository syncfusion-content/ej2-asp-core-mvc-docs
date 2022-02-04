---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Responsive Mode of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Responsive Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

  Both     | Button text is visible in both `Toolbar` and `Popup`.
  Overflow | Button text is only visible in `Popup`.
  Toolbar  | Button text is only visible on the `Toolbar`.

In the following code sample, text is only visible in the popup container and not in the Toolbar container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/responsive-mode/textbutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Textbutton.cs" %}
{% include code-snippet/toolbar/responsive-mode/textbutton/textbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/responsive-mode/textbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Textbutton.cs" %}
{% include code-snippet/toolbar/responsive-mode/textbutton/textbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

