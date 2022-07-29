---
layout: post
title: Buttongroup With Rounded Corner in ##Platform_Name## Button Group | Syncfusion
description: Learn here all about how to create Buttongroup with Rounded Corner in Syncfusion ##Platform_Name## Button Group control of syncfusion and more.
platform: ej2-asp-core-mvc
control: Create Buttongroup With Rounded Corner
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create ButtonGroup with rounded corner

The ButtonGroup with rounded corner has round edges on both sided. To ButtonGroup with rounded corner, `e-round-corner` class is to be added to the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/round/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/round/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/round/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

