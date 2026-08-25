---
layout: post
title: Animation in ##Platform_Name## Dialog | Syncfusion
description: Animate the Syncfusion ##Platform_Name## Dialog during open and close actions with configurable delay, duration, and effect via the AnimationSettings property.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animation in ##Platform_Name## Dialog

The Dialog can be animated during the open and close actions. Users can also customize the animation's [`delay`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogAnimationSettings.html#Syncfusion_EJ2_Popups_DialogAnimationSettings_Delay), [`duration`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogAnimationSettings.html#Syncfusion_EJ2_Popups_DialogAnimationSettings_Duration), and [`effect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogAnimationSettings.html#Syncfusion_EJ2_Popups_DialogAnimationSettings_Effect) via the [`AnimationSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogAnimationSettings.html) property.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
delay</td><td>
The Dialog animation starts after the specified delay.</td></tr>
<tr>
<td>
duration</td><td>
Specifies the animation duration to complete one animation cycle.</td></tr>
<tr>
<td>
effect</td><td>
Specifies the animation effect for the Dialog open and close actions.
<br /><br />
List of supported animation effects:
<br />
'Fade' | 'FadeZoom' | 'FlipLeftDown' | 'FlipLeftUp' | 'FlipRightDown' | 'FlipRightUp' | 'FlipXDown' |
'FlipXUp' | 'FlipYLeft' | 'FlipYRight' | 'SlideBottom' | 'SlideLeft' | 'SlideRight' | 'SlideTop' |
'Zoom' | 'None'
<br /><br />
If the user sets 'Fade' effect, then the Dialog will open with 'FadeIn' effect and close with 'FadeOut' effect.
</td></tr>
</table>

In the following example, the `Zoom` effect is enabled. As a result, the Dialog opens with the `ZoomIn` effect and closes with the `ZoomOut` effect.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/animation/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/animation/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
