---
layout: post
title: Show Dialog With Full Screen in ##Platform_Name## Dialog Component
description: Learn here all about Show Dialog With Full Screen in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Show Dialog With Full Screen
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show Dialog with fullscreen

You can show the dialog in fullscreen by passing `true` as argument to the dialog `show` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/fullscreen/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/fullscreen/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/fullscreen/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/fullscreen/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

