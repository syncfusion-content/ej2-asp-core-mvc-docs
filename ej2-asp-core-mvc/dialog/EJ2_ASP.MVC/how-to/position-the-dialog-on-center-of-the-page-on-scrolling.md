---
layout: post
title: Position The Dialog On Center Of The Page On Scrolling in ##Platform_Name## Dialog Component
description: Learn here all about Position The Dialog On Center Of The Page On Scrolling in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Position The Dialog On Center Of The Page On Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Position the Dialog in center of the page on scrolling

By default, when scroll the page/container Dialog also scrolled along with the page/container.
When a user expects to display the Dialog in the same position without scrolling achieving this in
sample level as like below. Here added 'e-fixed' class to Dialog element and prevent the scrolling.

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

