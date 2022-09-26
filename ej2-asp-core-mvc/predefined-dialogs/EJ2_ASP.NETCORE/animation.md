---
layout: post
title: animation in ##Platform_Name## Predefined Dialogs Control
description: Checkout and learn about animation in ##Platform_Name## Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animation in Predefined Dialogs 

The predefined dialogs can be animated during the open and close actions. You can customize the `Delay`, `Duration`, and `Effect` of animation by using the `animationSettings` property.

In the following sample, the zoom effect is enabled. So, the dialog will open with the zoom in and close with the zoom out effect.



{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/animation/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/animation/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/animation/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/predefined-dialogs/draggable/alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/getting-started/confirm-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}