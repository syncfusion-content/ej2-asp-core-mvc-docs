---
layout: post
title: Animation in ##Platform_Name## Dialog Component
description: Learn here all about Animation in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Animation

The Dialog can be animated during the open and close actions. Also, user can
customize animation's [`delay`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogAnimationSettings.html#Syncfusion_EJ2_Popups_DialogAnimationSettings_Delay),
[`duration`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogAnimationSettings.html#Syncfusion_EJ2_Popups_DialogAnimationSettings_Duration)
and [`effect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogAnimationSettings.html#Syncfusion_EJ2_Popups_DialogAnimationSettings_Effect).

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
delay</td><td>
The Dialog animation will start with the mentioned delay</td></tr>
<tr>
<td>
duration</td><td>
Specifies the animation duration to complete with one animation cycle</td></tr>
<tr>
<td>
effect</td><td>
Specifies the animation effects of Dialog open and close actions effect.
<br /><br />
List of supported animation effects:
<br />
'Fade' | 'FadeZoom' | 'FlipLeftDown' | 'FlipLeftUp' | 'FlipRightDown' | 'FlipRightUp' | 'FlipXDown' |
'FlipXUp' | 'FlipYLeft' | 'FlipYRight' | 'SlideBottom' | 'SlideLeft' | 'SlideRight' | 'SlideTop' |
'Zoom'| 'None'
<br /><br />
If the user sets 'Fade' effect, then the Dialog will open with 'FadeIn' effect and close with 'FadeOut' effect
</td></tr>
</table>

In the below sample, `Zoom` effect is enabled. So, The Dialog will open with `ZoomIn`
and close with `ZoomOut` effects.

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

