---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customization of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

The Tooltip can be customized by using the `cssClass` property, which accepts custom CSS class names that define specific user-defined
 styles and themes to be applied on the Tooltip element.

## Tip pointer customization

Styling the tip pointer's size, background, and border color's can be done using the `cssClass` property, as given below.

{% aspTab template="tooltip/tooltip-pointer", sourceFiles="tooltip-pointer.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Tip Pointer Customization](./images/tip-pointer-customization.png)

## Tooltip customization

The complete look and feel of the Tooltip can be customized by changing it's background color, opacity, content font, etc.
 The following code example shows the way to achieve it.

{% aspTab template="tooltip/tooltip-view", sourceFiles="tooltip-view.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Customization](./images/tooltip-customization.png)
