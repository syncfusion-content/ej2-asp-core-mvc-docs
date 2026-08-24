---
layout: post
title: How to change size in ##Platform_Name## Toggle Switch Button | Syncfusion
description: Change the size of the Syncfusion ##Platform_Name## Toggle Switch Button to small by applying the `e-small` CSS class via the `cssClass` property.
platform: ej2-asp-core-mvc
control: Change Size
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to change size in ##Platform_Name## Toggle Switch Button

The different Switch sizes available are default and small. To reduce the size of default Switch to small, set the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_CssClass) property to `e-small`.

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

