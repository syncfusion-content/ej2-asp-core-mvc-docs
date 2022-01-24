---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Change Animation Settings of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Change Animation Settings
publishingplatform: ##Platform_Name##
documentation: ug
---

# Change animation settings

To change the animation of the ContextMenu, [`animationSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~AnimationSettings.html) property is used.
The supported effects for ContextMenu are,

| Effect | Functionality |
| ------------ | ----------------------- |
| None | Specifies the sub menu transform with no animation effect. |
| SlideDown | Specifies the sub menu transform with slide down effect. |
| ZoomIn | Specifies the sub menu transform with zoom in effect. |
| FadeIn | Specifies the sub menu transform with fade in effect. |

The following sample illustrates how to open ContextMenu with `FadeIn` effect with the `duration` of `800ms`.

{% aspTab template="context-menu/howto/animation", sourceFiles="animation.cs" %}

{% endaspTab %}
