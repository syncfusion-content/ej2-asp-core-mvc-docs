---
layout: post
title: animation in ASP.NET Core Predefined Dialogs | Syncfusion
description: Checkout and learn about animation in ASP.NET Core Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: aspnet-core
documentation: ug
---

# Animation in Predefined Dialogs 

The predefined dialogs can be animated during the open and close actions. You can customize the `Delay`, `Duration`, and `Effect` of animation by using the `animationSettings` property.

In the following sample, the zoom effect is enabled. So, the dialog will open with the zoom in and close with the zoom out effect.


{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/animation/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/animation/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/animation/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}