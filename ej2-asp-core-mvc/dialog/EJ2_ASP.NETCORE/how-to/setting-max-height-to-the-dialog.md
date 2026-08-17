---
layout: post
title: Set max height of dialog | Syncfusion
description: Set the maxHeight of the Syncfusion ##Platform_Name## Dialog in the beforeOpen event so the popup respects a custom maximum height.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to set max height of the Dialog in ##Platform_Name## Dialog

By default, the maxHeight for the Dialog is calculated based on the target. If the target is not specified externally, the Dialog consider the body as target and will calculate the maxHeight based on it. There is an option to set the maxHeight of the Dialog in the `beforeOpen` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/max-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/max-height/controller.cs %}
{% endhighlight %}
{% endtabs %}
