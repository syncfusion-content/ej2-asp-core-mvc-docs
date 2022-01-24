---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Show Slider From Hidden State of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Show Slider From Hidden State
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show Slider from Hidden State

This section demonstrates how-to render the Slider component in hidden state and make it visible in button click. We can initialize Slider in hidden state by setting display as none to it.

In the sample, by clicking on the button, we can make the Slider visible from hidden state, and we must also call the `refresh` method of the Slider to render it properly based on its original dimensions.

{% aspTab template="slider/hidden-slider", sourceFiles="hidden-slider.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Hidden - Slider](../images/hidden-slider.png)