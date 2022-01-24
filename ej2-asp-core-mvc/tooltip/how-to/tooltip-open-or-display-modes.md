---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Tooltip Open Or Display Modes of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Tooltip Open Or Display Modes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip open or display modes

The open mode property of tooltip can be defined on a target that is hovering, focusing, or clicking.
Tooltip component have the following types of open mode:

* Auto
* Hover
* Click
* Focus
* Custom

## Auto

Tooltip appears when you hover over the target or when the target element receives the focus.

## Hover

Tooltip appears when you hover over the target.

## Click

Tooltip appears when you click a target element.

## Focus

Tooltip appears when you focus (say through tab key) on a target element.

## Custom

Tooltip is not triggered by any default action. So, bind your own events and use either open or close public methods.

{% aspTab template="tooltip/open-custom", sourceFiles="open-custom.cs" %}

{% endaspTab %}