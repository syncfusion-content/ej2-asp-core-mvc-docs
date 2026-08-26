---
layout: post
title: Position the Dialog on page scroll | Syncfusion
description: Keep the Syncfusion ##Platform_Name## Dialog in a fixed position on the page while scrolling by adding the e-fixed class to the Dialog element to prevent it from scrolling with the page.
platform: ej2-asp-core-mvc
control: Position The Dialog On Center Of The Page On Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to position Dialog on page scroll in ##Platform_Name## Dialog

By default, when the page or container is scrolled, the Dialog is also scrolled along with it. To keep the Dialog in a fixed position during scrolling, add the `e-fixed` class to the Dialog element. This prevents the Dialog from scrolling with the page content.

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

