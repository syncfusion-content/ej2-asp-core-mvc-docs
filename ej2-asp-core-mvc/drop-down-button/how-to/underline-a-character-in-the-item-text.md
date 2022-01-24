---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Underline A Character In The Item Text of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Underline A Character In The Item Text
publishingplatform: ##Platform_Name##
documentation: ug
---


# Underline a character in the item text

Underline a particular character in a text can be handled in
[`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeItemRender)event by
adding `<u>` tag in between the text and given as innerHTML in `li` rendering.

In the following example, `C` is underlined in the text `Copy`.

{% aspTab template="dropdownbutton/underline", sourceFiles="underline.cs" %}

{% endaspTab %}