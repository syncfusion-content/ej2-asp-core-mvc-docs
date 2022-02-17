---
layout: post
title: Center The Dialog Based On Current Scroll Position in ##Platform_Name## Dialog Component
description: Learn here all about Center The Dialog Based On Current Scroll Position in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Center The Dialog Based On Current Scroll Position
publishingplatform: ##Platform_Name##
documentation: ug
---


# Center the dialog based on the current scroll position

The dialog is always centered based on the target container. If the target is not specified, then the dialog will be rendered based on its body and centered in the position of the current viewpoint.

In the following sample, the model dialog is centered based on its current scroll position of the page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/center-the-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/center-the-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/center-the-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/center-the-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

