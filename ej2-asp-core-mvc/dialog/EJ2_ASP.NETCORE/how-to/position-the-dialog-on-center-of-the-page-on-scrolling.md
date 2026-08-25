---
layout: post
title: Position the Dialog on page scroll in ##Platform_Name## | Syncfusion
description: Keep the Syncfusion ##Platform_Name## Dialog centered on the page while scrolling by adding the e-fixed class to the Dialog element to prevent page scroll.
platform: ej2-asp-core-mvc
control: Position The Dialog On Center Of The Page On Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to position the Dialog on page scroll in ##Platform_Name## Dialog

By default, when the page or container is scrolled, Dialog is also scrolled along with it. When a user expects to display the Dialog in the same position without scrolling, 'e-fixed' class is added to Dialog element to prevent the scrolling.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/scrolling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/scrolling/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/scrolling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/scrolling/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

