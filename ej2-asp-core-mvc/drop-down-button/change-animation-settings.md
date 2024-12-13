layout: post
title: Change animation settings in ##Platform_Name## Drop Down Button Component
description: Learn here all about Change animation settings in Syncfusion ##Platform_Name## Drop Down Button component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Popup Items
publishingplatform: ##Platform_Name##
documentation: ug
---

## Customize Popup Width

To change the animation of the DropDownButton, [`AnimationSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_AnimationSettings.html) property is used. The supported effects for DropDownButton are,

| Effect | Functionality |
| ------------ | ----------------------- |
| None | Specifies the Dropdown popup transform with no animation effect. |
| SlideDown | Specifies the Dropdown popup transform with slide down effect. |
| ZoomIn | Specifies the Dropdown popup transform with zoom in effect. |
| FadeIn | Specifies the Dropdown popup transform with fade in effect. |

In this sample, three different buttons are initialized using the DropDownButton component from Syncfusion, each showcasing a unique animation effect for the dropdown menu:

SlideDown Effect: The following sample illustrates how to open DropDownButton with `SlideDown` [`effect`](../../api/drop-down-button/animationSettingsModel/#effect) with the [`duration`](../../api/drop-down-button/animationSettingsModel/#duration) of `800ms`. Also we can set [`easing`](../../api/drop-down-button/animationSettingsModel/#easing) for Dropdown popup.

FadeIn Effect: The following sample illustrates how to open DropDownButton with ,`FadeIn` [`effect`](../../api/drop-down-button/animationSettingsModel/#effect) with the [`duration`](../../api/drop-down-button/animationSettingsModel/#duration) of `800ms`. Also we can set [`easing`](../../api/drop-down-button/animationSettingsModel/#easing) for Dropdown popup.

ZoomIn Effect: The following sample illustrates how to open DropDownButton with ,`ZoomIn` [`effect`](../../api/drop-down-button/animationSettingsModel/#effect) with the [`duration`](../../api/drop-down-button/animationSettingsModel/#duration) of `800ms`. Also we can set [`easing`](../../api/drop-down-button/animationSettingsModel/#easing) for Dropdown popup.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="default.cs" %}
{% include code-snippet/dropdownbutton/animation/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="default.cs" %}
{% include code-snippet/dropdownbutton/animation/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Integration with ListView component](./how-to/group-popup-items-with-listview-component)