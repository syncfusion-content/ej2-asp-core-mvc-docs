---
layout: post
title: animation in ##Platform_Name## Predefined Dialogs | Syncfusion
description: Checkout and learn about animation in ##Platform_Name## Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animation in Predefined Dialogs 

The predefined dialogs can be animated during the open and close actions. You can customize the `Delay`, `Duration`, and `Effect` of animation by using the `animationSettings` property.

In the following sample, the zoom effect is enabled. So, the dialog will open with the zoom in and close with the zoom out effect.

**Alert**

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/animation/alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/animation/alert/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Confirm**

{% tabs %}
{% highlight razor tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/animation/confirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/animation/confirm/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Prompt**

{% tabs %}
{% highlight razor tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/animation/prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/animation/prompt/controller.cs %}
{% endhighlight %}
{% endtabs %}