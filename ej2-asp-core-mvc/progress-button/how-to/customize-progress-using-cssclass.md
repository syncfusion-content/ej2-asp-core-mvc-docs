---
layout: post
title: Customize Progress Using Cssclass in ##Platform_Name## Progress Button Component
description: Learn here all about Customize Progress Using Cssclass in Syncfusion ##Platform_Name## Progress Button component and more.
platform: ej2-asp-core-mvc
control: Customize Progress Using Cssclass
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize progress using cssClass

You can customize the background filler UI using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_CssClass) property.

* Adding `e-vertical` to `cssClass` shows vertical progress.
* Adding `e-progress-top` to `cssClass` shows progress at the top.

You can also show reverse progress by adding custom class to the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_CssClass) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/custom-progress/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/custom-progress/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/custom-progress/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/custom-progress/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

