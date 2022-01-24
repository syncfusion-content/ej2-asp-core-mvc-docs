---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize The Appearance Of A Switch of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize The Appearance Of A Switch
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the appearance of a Switch

You can customize the appearance of the Switch component using the CSS rules. Define your own CSS rules according to your requirement and assign the class name to the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_CssClass) property.

## Customize Switch bar and handle

Switch bar and handle can be customized as per requirement using CSS rules. Switch bar and handle customized using `cssClass` property. In the following sample, the `border-radius` CSS property for `e-switch-inner` and `e-switch-handle` elements was changed border radius circle to square shape.

{% aspTab template="switch/customize/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Color the Switch

Switch colors can be customized as per the requirement using CSS rules. Switch bar and handle colors customized using `cssClass` property. In the following sample, the `e-switch-inner` and `e-switch-off` elements background and border colors were changed from default colors.

{% aspTab template="switch/customize-color/demo", sourceFiles="default.cs" %}

{% endaspTab %}