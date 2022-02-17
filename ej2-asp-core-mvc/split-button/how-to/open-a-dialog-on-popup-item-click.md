---
layout: post
title: Open A Dialog On Popup Item Click in ##Platform_Name## Split Button Component
description: Learn here all about Open A Dialog On Popup Item Click in Syncfusion ##Platform_Name## Split Button component and more.
platform: ej2-asp-core-mvc
control: Open A Dialog On Popup Item Click
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open a dialog on popup item click

This section explains about how to open a dialog on SplitButton popup item click. This can be achieved by
handling dialog open in [`select`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_Select) event of the SplitButton.

In the following example, Dialog will open while selecting `Update...` item:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/dialog/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DialogButton-core.cs" %}
{% include code-snippet/split-button/dialog/demo/dialogButton-core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/dialog/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DialogButton-core.cs" %}
{% include code-snippet/split-button/dialog/demo/dialogButton-core.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

