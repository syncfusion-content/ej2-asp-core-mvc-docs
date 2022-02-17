---
layout: post
title: Change Size in ##Platform_Name## Switch Component
description: Learn here all about Change Size in Syncfusion ##Platform_Name## Switch component and more.
platform: ej2-asp-core-mvc
control: Change Size
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change Size

The different Switch sizes available are default and small. To reduce the size of default Switch to small,
set the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_CssClass) property to `e-small`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/switch/size/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/size/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/switch/size/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/size/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

