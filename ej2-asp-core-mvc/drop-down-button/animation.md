---
layout: post
title: Animation in ##Platform_Name## Drop Down Button Component
description: Learn here all about Animation in Syncfusion ##Platform_Name## Drop Down Button component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animation in ##Platform_Name## Drop Down Button Component

The [AnimationSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_AnimationSettings) property in the DropDownButton component defines the animation effects applied when opening the dropdown menu. These animations provide a dynamic and smooth interaction for the dropdown.

The supported effects for DropDownButton are,

| Effect | Functionality |
| ------------ | ----------------------- |
| None | Specifies the Dropdown popup transform with no animation effect. |
| SlideDown | Specifies the Dropdown popup transform with slide down effect. |
| ZoomIn | Specifies the Dropdown popup transform with zoom in effect. |
| FadeIn | Specifies the Dropdown popup transform with fade in effect. |

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
{% include code-snippet/dropdownbutton/template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}