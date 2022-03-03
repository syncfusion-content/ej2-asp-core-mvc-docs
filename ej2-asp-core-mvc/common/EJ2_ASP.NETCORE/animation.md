---
layout: post
title: Animation in ##Platform_Name## Common Component
description: Learn here all about Animation in Syncfusion ##Platform_Name## Common component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animation in Syncfusion ASP.NET Core

The **Animation** library is used to perform animation effects on HTML elements by running sequence of frames.

## Animation Supported Components

The following table demonstrates the list of Syncfusion ASP.NET Core component documents that are supported with Animation.

* [Accordion](../accordion/how-to/customize-expand-collapse-actions)
* [Accumulation Chart](../accumulation-chart/legend#enable-animation)
* [Bullet Chart](../bullet-chart/customization#animation)
* [Chart](../chart/legend#enable-animation)
* [Circular Gauge](../circular-gauge/gauge-pointers#animation)
* [Context Menu](../context-menu/how-to/change-animation-settings)
* [Dialog](../dialog/animation)

## Animating a HTML Element

The `animate` method of `Animation` library can be used to animate the HTML elements. This method can also take additional `AnimationModel`. Refer the below code snippet to animate a multiple DOM element.

```cshtml
<div id="fade"></div>
<div id="zoom"></div>

<script>
    var animation = new ej.base.Animation({ duration: 5000 });
    animation.animate('#fade', { name: 'FadeOut' });
    animation.animate('#zoom', { name: 'ZoomOut' });
</script>

<style>
#fade, #zoom {
    background: #333333;
    border: 1px solid #cecece;
    box-sizing: border-box;
    float: left;
    height: 100px;
    width: 100px;
}
</style>
```
