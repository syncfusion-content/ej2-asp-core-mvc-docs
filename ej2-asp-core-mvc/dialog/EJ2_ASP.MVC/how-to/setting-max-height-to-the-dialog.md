---
layout: post
title: How to set max height of the Dialog in ASP.NET MVC Dialog | Syncfusion
description: Set the maxHeight of the Syncfusion ASP.NET MVC Dialog in the beforeOpen event so the popup respects a custom maximum height.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to set max height of the Dialog in ASP.NET MVC Dialog

By default, the maxHeight for the Dialog is calculated based on the target. If the target is not specified externally, the Dialog consider the body as target and will calculate the maxHeight based on it. We have an option to set the maxHeight of the Dialog in the `beforeOpen` event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/max-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/max-height/controller.cs %}
{% endhighlight %}
{% endtabs %}
