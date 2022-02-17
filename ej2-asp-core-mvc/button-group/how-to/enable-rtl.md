---
layout: post
title: Enable Rtl in ##Platform_Name## Button Group Component
description: Learn here all about Enable Rtl in Syncfusion ##Platform_Name## Button Group component and more.
platform: ej2-asp-core-mvc
control: Enable Rtl
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable RTL

ButtonGroup supports RTL functionality. This can be achieved by adding `e-rtl` class to the target element.

The following example illustrates how to create ButtonGroup with RTL support.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/rtl/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/rtl/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/rtl/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/rtl/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

