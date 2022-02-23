---
title: "Customized CheckBox"
component: "CheckBox"
description: "CheckBox how to section, name and value in form submit, and customization of CheckBox appearance, frame & check icon."
---

# Customized CheckBox

## Customize CheckBox Appearance

You can customize the appearance of the CheckBox component using the CSS rules.
Define own CSS rules according to your requirement and assign the class name to the
[`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_CssClass) property.

The background and border color of the CheckBox is customized through the custom classes to create primary, success, warning, and danger info type of checkbox.

{% aspTab template="check-box/howto/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## Customize width and height

The height and width of the CheckBox component can be customized by setting `height` and `width` property.

The following section explains about how to customize the height and width of the CheckBox component.

{% aspTab template="check-box/howto/custom-height", sourceFiles="customheight.cs" %}

{% endaspTab %}

## Custom Frame

CheckBox frame can be customized as per the requirement by adding CSS rules.

In the following example, to-do list is displayed with round checkbox by changing
`border-radius` as `100%` by adding `e-custom` class.

{% aspTab template="check-box/howto/custom-size", sourceFiles="customsize.cs" %}

{% endaspTab %}

## Custom Check Icon

CheckBox check icon can be customized as per the requirement by adding CSS rules.

In the following example, the check icon can be customized by changing check icon content, background and
border color in focus and hovered states by adding `e-checkicon` class.

{% aspTab template="check-box/howto/custom-icon", sourceFiles="customicon.cs" %}

{% endaspTab %}